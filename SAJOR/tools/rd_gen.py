# -*- coding: utf-8 -*-
"""Emit a fresh Visual Studio style *.Designer.vb (one block per control) from a small spec."""
import re

NS = "System.Windows.Forms."
STRIPS = ("MenuStrip", "StatusStrip", "ToolStrip")
ITEMS = ("ToolStripMenuItem", "ToolStripStatusLabel", "ToolStripSeparator", "ToolStripButton")
CONT = ("Panel", "GroupBox", "TabControl", "TabPage", "SplitContainer", "FlowLayoutPanel", "MenuStrip", "StatusStrip", "ToolStrip")


def P(x, y):
    return "New System.Drawing.Point(%d, %d)" % (x, y)


def S(w, h):
    return "New System.Drawing.Size(%d, %d)" % (w, h)


def Q(s):
    return '"%s"' % s.replace('"', '""')


class C(object):
    def __init__(self, name, kind, parent=None, x=None, y=None, w=None, h=None, text=None, **props):
        self.name, self.kind, self.parent = name, kind, parent
        self.props = []
        if x is not None:
            self.props.append(("Location", P(x, y)))
        if w is not None:
            self.props.append(("Size", S(w, h)))
        if text is not None:
            self.props.append(("Text", Q(text)))
        for k, v in props.items():
            self.props.append((k.replace("__", "."), v))


def gen(path, cls, ctls, form_props, size, text, bom=True):
    byname = {c.name: c for c in ctls}
    kids = {}
    for c in ctls:
        kids.setdefault(c.parent, []).append(c)
    out = []
    A = out.append
    A("<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _\r\n" if False else "")
    out = ["<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _",
           "Partial Class %s" % cls,
           "    Inherits System.Windows.Forms.Form",
           "",
           "    'Form overrides dispose to clean up the component list.",
           "    <System.Diagnostics.DebuggerNonUserCode()> _",
           "    Protected Overrides Sub Dispose(ByVal disposing As Boolean)",
           "        Try",
           "            If disposing AndAlso components IsNot Nothing Then",
           "                components.Dispose()",
           "            End If",
           "        Finally",
           "            MyBase.Dispose(disposing)",
           "        End Try",
           "    End Sub",
           "",
           "    'Required by the Windows Form Designer",
           "    Private components As System.ComponentModel.IContainer",
           "",
           "    'NOTE: The following procedure is required by the Windows Form Designer",
           "    'It can be modified using the Windows Form Designer.  ",
           "    'Do not modify it using the code editor.",
           "    <System.Diagnostics.DebuggerStepThrough()> _",
           "    Private Sub InitializeComponent()"]
    A = out.append
    for c in ctls:
        A("        Me.%s = New System.Windows.Forms.%s()" % (c.name, c.kind))
    cont = [c for c in ctls if c.kind in CONT and c.kind not in ITEMS]
    for c in cont:
        A("        Me.%s.SuspendLayout()" % c.name)
    A("        Me.SuspendLayout()")
    idx = 0
    for c in ctls:
        A("        '")
        A("        '%s" % c.name)
        A("        '")
        ch = kids.get(c.name, [])
        if c.kind in STRIPS:
            A("        Me.%s.Items.AddRange(New System.Windows.Forms.ToolStripItem() {%s})" %
              (c.name, ", ".join("Me." + k.name for k in ch)))
        elif c.kind == "ToolStripMenuItem" and ch:
            A("        Me.%s.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {%s})" %
              (c.name, ", ".join("Me." + k.name for k in ch)))
        else:
            for k in ch:
                A("        Me.%s.Controls.Add(Me.%s)" % (c.name, k.name))
        for k, v in c.props:
            A("        Me.%s.%s = %s" % (c.name, k, v))
        A('        Me.%s.Name = "%s"' % (c.name, c.name))
        if c.kind not in ITEMS:
            A("        Me.%s.TabIndex = %d" % (c.name, idx))
        idx += 1
    A("        '")
    A("        '%s" % cls)
    A("        '")
    A("        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)")
    A("        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font")
    A("        Me.ClientSize = New System.Drawing.Size(%d, %d)" % size)
    for c in kids.get(None, []):
        A("        Me.Controls.Add(Me.%s)" % c.name)
    for k, v in form_props:
        A("        Me.%s = %s" % (k, v))
    A('        Me.Name = "%s"' % cls)
    A("        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen")
    A("        Me.Text = %s" % Q(text))
    for c in cont:
        A("        Me.%s.ResumeLayout(False)" % c.name)
        if c.kind in STRIPS:
            A("        Me.%s.PerformLayout()" % c.name)
    A("        Me.ResumeLayout(False)")
    A("        Me.PerformLayout()")
    A("")
    A("    End Sub")
    for c in ctls:
        A("    Friend WithEvents %s As System.Windows.Forms.%s" % (c.name, c.kind))
    A("End Class")
    txt = "\r\n".join(out) + "\r\n"
    data = txt.encode("utf-8")
    if bom:
        data = b"\xef\xbb\xbf" + data
    open(path, "wb").write(data)
