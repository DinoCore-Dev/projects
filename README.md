# Integrative Programming and Technologies 1 (VB.NET) — Project & Activity Compilation

- **Author:** Rex M. Alvarez
- **Course / Year / Section:** BSIT 3B
- **Address:** Barucboc, Quezon, Isabela
- **Word Document (.docx):** [`COMPILATION.docx`](./docs/COMPILATION.docx) | [`docs/COMPILATION.docx`](./docs/COMPILATION.docx)

---

## Table of Contents

| # | Folder / Solution | Activity Title | Type |
|---|---|---|---|
| 1 | `Act1_Activity202606241600` (`Activity202606241600.sln`) | Activity 1: Introduction to VB.NET Console & Data Types (Activity202606241600) | VB.NET Console Application (.NET Framework 4.0) |
| 2 | `Act2 Celcius-Fahrenheit Converter` (`Act2.sln`) | Activity 2: Console User Input & Celsius–Fahrenheit Temperature Converter (Act2) | VB.NET Console Application (.NET Framework 4.0) |
| 3 | `Activity3_20260629` (`Activity3_20260629.sln`) | Activity 3: Three-Number Arithmetic Operations & Exception Handling (Activity3_20260629) | VB.NET Console Application (.NET Framework 4.0) |
| 4 | `Activity4_20260703` (`Activity4_20260703.sln`) | Activity 4: Windows Forms Three-Number Calculator (Activity4_20260703) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 5 | `Act5` (`Ternary2.sln`) | Activity 5: Grade Evaluator Using Nested Ternary If() Operator (Act5 / Ternary2) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 6 | `Act6_IntegProg1_20260715` (`IntegrativeProg1_20260715.sln`) | Activity 6: Grade Average & Multi-Remark Evaluation Using Select Case (Act6_IntegProg1_20260715) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 7 | `Act7_IntegProg1_SW20260720` (`IntegProg1_SW20260720.sln`) | Activity 7: Multi-Tab Control & Looping Structures (Act7_IntegProg1_SW20260720) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 8 | `Act8_SW20260805` (`TheMessage.sln`) | Activity 8: Interactive MessageBox Customizer — "The Message" (Act8_SW20260805) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 9 | `SW202609301600` (`SW202609301600.sln`) | Activity 9: ListView File Explorer — Question 6 (SW202609301600) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 10 | `SW20261002` (`PanelSplitPanelDemo.sln`) | Activity 10: Panel and SplitContainer Demonstration (SW20261002 / PanelSplitPanelDemo) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 11 | `SW202610021600` (`SW202610021600.sln`) | Activity 11: Windows Forms File Explorer & Dialog Controls Suite — Questions 6–9 (SW202610021600) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 12 | `FileExplorerClone` (`PanelSplitDemo.sln`) | Activity 12: Folder Explorer with Multi-Format Preview Engine (FileExplorerClone / PanelSplitDemo) | VB.NET Windows Forms Application (.NET Framework 4.0) |
| 13 | `IntegProgProject2026` (`IntegProgProject2026.sln`) | Activity 13: Integrative Programming Project 2026 — MDI Information Management System (IntegProgProject2026) | VB.NET Windows Forms MDI Application (.NET Framework 4.0) |

---

## Activity 1: Introduction to VB.NET Console & Data Types (Activity202606241600)

### 1. Activity Title
- **Activity Title:** Activity 1: Introduction to VB.NET Console & Data Types (Activity202606241600)
- **Project Folder / Solution:** `Act1_Activity202606241600` (`Activity202606241600.sln`)
- **Application Type:** VB.NET Console Application (.NET Framework 4.0)
- **Date:** June 24, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Module1.vb`
```vbnet
Module Module1

    Sub Main()
        Console.WriteLine("Activity202606241600")
        Console.WriteLine("Author: Alvarez, Rex")

        Dim theName = "Alvarez, Rex"
        Console.WriteLine("Hello " + theName)

        Dim n1 As Integer = 0
        Dim n2 As Double = 0.0
        Dim isValid As Boolean = True
        Dim character As Char = "A"
        Dim number1 As Integer = 12
        Dim number2 As Double = 12.12

        Console.ReadKey()
    End Sub

End Module
```

### 3. Sample Run
![Figure 1.1 — Sample Run of Activity202606241600 in Windows Command Prompt](docs/images/act1_run.png)
*Figure 1.1 — Sample Run of Activity202606241600 in Windows Command Prompt*

**Sample Run Walkthrough:**
- Program outputs the activity identifier 'Activity202606241600' and author line 'Author: Alvarez, Rex'.
- Concatenates 'Hello ' with the string variable theName ('Alvarez, Rex') to print 'Hello Alvarez, Rex'.
- Initializes local variables of types Integer (n1 = 0, number1 = 12), Double (n2 = 0.0, number2 = 12.12), Boolean (isValid = True), and Char (character = "A").
- Waits for a key press via Console.ReadKey() before closing the console window.

### 4. Form Design
![Figure 1.2 — Console Application Variable & Execution Layout (Activity202606241600)](docs/images/act1_design.png)
*Figure 1.2 — Console Application Variable & Execution Layout (Activity202606241600)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `Module1` | Module | `Module1` | Main entry container for the console application |
| `Sub Main()` | Procedure | `Main()` | Entry-point method executed when the program starts |
| `theName` | String Variable | `"Alvarez, Rex"` | Stores the student's full name for greeting output |
| `n1, number1` | Integer Variables | `0, 12` | Demonstrates 32-bit signed whole-number declarations |
| `n2, number2` | Double Variables | `0.0, 12.12` | Demonstrates double-precision floating-point declarations |
| `isValid` | Boolean Variable | `True` | Demonstrates logical True/False variable declaration |
| `character` | Char Variable | `"A"` | Demonstrates single Unicode character declaration |

### 5. Brief Description
Activity 1 (Activity202606241600) introduces the structure of a Visual Basic .NET Console Application using Module1 and Sub Main(). It demonstrates printing text to standard output via Console.WriteLine(), string concatenation using the + operator, and declaring and initializing variables using the Dim keyword across core .NET primitive data types (String, Integer, Double, Boolean, and Char). Finally, Console.ReadKey() is used to pause execution so the console output remains visible to the user.

---

## Activity 2: Console User Input & Celsius–Fahrenheit Temperature Converter (Act2)

### 1. Activity Title
- **Activity Title:** Activity 2: Console User Input & Celsius–Fahrenheit Temperature Converter (Act2)
- **Project Folder / Solution:** `Act2 Celcius-Fahrenheit Converter` (`Act2.sln`)
- **Application Type:** VB.NET Console Application (.NET Framework 4.0)
- **Date:** June 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Module1.vb`
```vbnet
Module Module1

    Sub Main()
        Console.Write("Hello world")
        Console.ReadLine()

        Dim lastName As String = ""
        Dim firstName As String = ""

        Console.Write("Enter Lastname: ")
        lastName = Console.ReadLine()
        Console.Write("Enter Firstname: ")
        firstName = Console.ReadLine()

        Console.WriteLine("Your Lastname is " + lastName)
        Console.WriteLine("Your Firstname is " + firstName)
        Console.ReadLine()

        ' Converter 1: Celsius to Fahrenheit
        Console.WriteLine("--- Celsius to Fahrenheit Converter ---" & vbNewLine)
        Console.Write("Enter Celsius: ")
        Dim celsiusInput As Decimal = Convert.ToDecimal(Console.ReadLine())
        Dim fahrenheitResult As Decimal = (celsiusInput * 1.8) + 32
        Console.WriteLine("Result in Fahrenheit: " & fahrenheitResult)
        Console.ReadLine()

        ' Converter 2: Fahrenheit to Celsius
        Console.WriteLine("--- Fahrenheit to Celsius Converter ---" & vbNewLine)
        Console.Write("Enter Fahrenheit: ")
        Dim fahrenheitInput As Decimal = Convert.ToDecimal(Console.ReadLine())
        Dim celsiusResult As Decimal = (fahrenheitInput - 32) / 1.8
        Console.WriteLine("Result in Celsius: " & celsiusResult)
        Console.ReadLine()

    End Sub

End Module
```

### 3. Sample Run
![Figure 2.1 — Sample Run of Act2 Celsius–Fahrenheit Converter](docs/images/act2_run.png)
*Figure 2.1 — Sample Run of Act2 Celsius–Fahrenheit Converter*

**Sample Run Walkthrough:**
- Displays 'Hello world' and waits for Enter via Console.ReadLine().
- Prompts the user for Lastname ('Alvarez') and Firstname ('Rex') and echoes both back.
- Converter 1 (Celsius to Fahrenheit): Accepts 37 °C and computes (37 * 1.8) + 32 = 98.6 °F.
- Converter 2 (Fahrenheit to Celsius): Accepts 98.6 °F and computes (98.6 - 32) / 1.8 = 37 °C.

### 4. Form Design
![Figure 2.2 — Console Application I/O & Formula Design (Act2)](docs/images/act2_design.png)
*Figure 2.2 — Console Application I/O & Formula Design (Act2)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `lastName` | String Variable | `User Input` | Stores the user's last name read from Console.ReadLine() |
| `firstName` | String Variable | `User Input` | Stores the user's first name read from Console.ReadLine() |
| `celsiusInput` | Decimal Variable | `Convert.ToDecimal()` | Stores the input temperature in degrees Celsius |
| `fahrenheitResult` | Decimal Variable | `(celsiusInput * 1.8) + 32` | Stores the converted temperature in degrees Fahrenheit |
| `fahrenheitInput` | Decimal Variable | `Convert.ToDecimal()` | Stores the input temperature in degrees Fahrenheit |
| `celsiusResult` | Decimal Variable | `(fahrenheitInput - 32) / 1.8` | Stores the converted temperature in degrees Celsius |

### 5. Brief Description
Activity 2 (Act2 — Celsius–Fahrenheit Converter) demonstrates interactive console input and mathematical expressions in VB.NET. The program first reads the user's last name and first name as strings using Console.ReadLine() and displays them using string concatenation. It then performs two temperature conversions using the Decimal data type and Convert.ToDecimal(): converting Celsius to Fahrenheit using the formula F = (C * 1.8) + 32, and converting Fahrenheit back to Celsius using C = (F - 32) / 1.8.

---

## Activity 3: Three-Number Arithmetic Operations & Exception Handling (Activity3_20260629)

### 1. Activity Title
- **Activity Title:** Activity 3: Three-Number Arithmetic Operations & Exception Handling (Activity3_20260629)
- **Project Folder / Solution:** `Activity3_20260629` (`Activity3_20260629.sln`)
- **Application Type:** VB.NET Console Application (.NET Framework 4.0)
- **Date:** June 29, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Module1.vb`
```vbnet
Module Module1
    Sub Main()

        'Activity3_20260629'
        'Create a vb.net console app that will accept 3 numbers, and display the sum, difference, product, quotient, and ave of the 3 numbers'

        Try
ulit:
            Console.WriteLine("Activity3_20260629")
            Console.WriteLine("Author: Alvarez, Rex")
            Console.WriteLine("Course Year Section: BSIT 3B")

            Console.Write("Enter number 1: ")
            Dim n1 As Integer = Convert.ToInt16(Console.ReadLine())
            Console.Write("Enter number 2: ")
            Dim n2 As Integer = Convert.ToInt16(Console.ReadLine())
            Console.Write("Enter number 3: ")
            Dim n3 As Integer = Convert.ToInt16(Console.ReadLine())

            Console.Write("The sum is: ")
            Dim sum As Double = n1 + n2 + n3
            Console.WriteLine(sum)

            Console.Write("The difference is: ")
            Dim difference As Double = n1 - n2 - n3
            Console.WriteLine(difference)

            Console.Write("The product is: ")
            Dim product As Double = n1 * n2 * n3
            Console.WriteLine(product)

            Console.Write("The quotient is: ")
            Dim quotient As Double = n1 / n2 / n3
            Console.WriteLine(quotient)

            Console.Write("The average is: ")
            Dim ave As Double = sum / 3
            Console.WriteLine(ave)

        Catch ex As FormatException
            Console.WriteLine("Error: " & ex.Message)
            GoTo ulit
        End Try

        Console.ReadKey()

        'Iti nasursurwak ditoy nga taraon ket iti makuna nga "convertion method" iti agduduma nga datatypes.'
        'ken syak ket na gwapo'
    End Sub
End Module
```

### 3. Sample Run
![Figure 3.1 — Sample Run of Activity3_20260629 Showing Error Recovery and Calculations](docs/images/act3_run.png)
*Figure 3.1 — Sample Run of Activity3_20260629 Showing Error Recovery and Calculations*

**Sample Run Walkthrough:**
- First attempt: Entering non-numeric text ('abc') triggers Catch ex As FormatException, prints 'Error: Input string was not in a correct format.', and jumps back to the 'ulit:' label.
- Second attempt: Entering n1 = 20, n2 = 10, n3 = 5 computes Sum = 35, Difference = 5, Product = 1000, Quotient = 0.4, and Average = 11.6666666666667.

### 4. Form Design
![Figure 3.2 — Console Application Architecture & Exception Handling Flow (Activity3_20260629)](docs/images/act3_design.png)
*Figure 3.2 — Console Application Architecture & Exception Handling Flow (Activity3_20260629)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `ulit:` | Label | `Jump Target` | Label used with GoTo ulit to restart input after a FormatException |
| `n1, n2, n3` | Integer Variables | `Convert.ToInt16()` | Store the three integer inputs entered by the user |
| `sum` | Double Variable | `n1 + n2 + n3` | Stores the sum of the three numbers |
| `difference` | Double Variable | `n1 - n2 - n3` | Stores the sequential difference of the three numbers |
| `product` | Double Variable | `n1 * n2 * n3` | Stores the product of the three numbers |
| `quotient` | Double Variable | `n1 / n2 / n3` | Stores the floating-point quotient of the three numbers |
| `ave` | Double Variable | `sum / 3` | Stores the arithmetic mean of the three numbers |
| `Try...Catch` | Exception Block | `FormatException` | Catches invalid non-numeric input and prompts the user again |

### 5. Brief Description
Activity 3 (Activity3_20260629) is a VB.NET console application that accepts three numbers from the user and calculates their sum, difference, product, quotient, and average. It demonstrates explicit data type conversion via Convert.ToInt16(Console.ReadLine()), floating-point arithmetic stored in Double variables, and structured exception handling using Try...Catch ex As FormatException combined with a retry label (ulit:) so the program gracefully recovers when non-numeric input is entered.

---

## Activity 4: Windows Forms Three-Number Calculator (Activity4_20260703)

### 1. Activity Title
- **Activity Title:** Activity 4: Windows Forms Three-Number Calculator (Activity4_20260703)
- **Project Folder / Solution:** `Activity4_20260703` (`Activity4_20260703.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** July 3, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Public Class Form1

    Private n1 As Integer
    Private n2 As Integer
    Private n3 As Integer
    Private sum As Integer
    Private diff As Integer
    Private quot As Integer
    Private product As Integer
    Private average As Integer

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtn1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtn1.TextChanged

    End Sub

    Private Sub txtn2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtn2.TextChanged

    End Sub

    Private Sub txtn3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtn3.TextChanged

    End Sub

    Private Sub txtsum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsum.TextChanged

    End Sub

    Private Sub txtdiff_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiff.TextChanged

    End Sub

    Private Sub txtprod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprod.TextChanged

    End Sub

    Private Sub txtquot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquot.TextChanged
        
    End Sub

    Private Sub txtave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtave.TextChanged

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            n1 = Convert.ToInt32(txtn1.Text())
            n2 = Convert.ToInt32(txtn2.Text())
            n3 = Convert.ToInt32(txtn3.Text())

            sum = n1 + n2 + n3
            txtsum.Text() = sum.ToString()
            

        Catch ex As Exception
            txtsum.Text = "Error: Maybe Invalid Number..."
        End Try

    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        Try
            n1 = Convert.ToInt32(txtn1.Text())
            n2 = Convert.ToInt32(txtn2.Text())
            n3 = Convert.ToInt32(txtn3.Text())

            diff = n1 - n2 - n3
            txtdiff.Text() = diff.ToString()


        Catch ex As Exception
            txtdiff.Text = "Error: Maybe Invalid Number..."
        End Try
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        Try
            n1 = Convert.ToInt32(txtn1.Text())
            n2 = Convert.ToInt32(txtn2.Text())
            n3 = Convert.ToInt32(txtn3.Text())

            quot = n1 * n2 * n3
            txtquot.Text() = quot.ToString()

        Catch ex As Exception
            txtquot.Text = "Error: Maybe Invalid Number..."
        End Try
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        Try
            n1 = Convert.ToInt32(txtn1.Text())
            n2 = Convert.ToInt32(txtn2.Text())
            n3 = Convert.ToInt32(txtn3.Text())

            product = n1 / n2 / n3
            txtprod.Text() = product.ToString()


        Catch ex As Exception
            txtprod.Text = "Error: Maybe Invalid Number..."
        End Try
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Try
            n1 = Convert.ToInt32(txtn1.Text())
            n2 = Convert.ToInt32(txtn2.Text())
            n3 = Convert.ToInt32(txtn3.Text())

            average = (n1 + n2 + n3) / 3
            txtave.Text() = average.ToString()


        Catch ex As Exception
            txtave.Text = "Error: Maybe Invalid Number..."
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtn1.Clear()
        txtn2.Clear()
        txtn3.Clear()
        txtsum.Clear()
        txtdiff.Clear()
        txtprod.Clear()
        txtquot.Clear()
        txtave.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtn3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdiff = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtquot = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtave = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Author: Alvarez Rex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course: BSIT Year: 2026 Section: 3B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number 1:"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(98, 66)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(202, 20)
        Me.txtn1.TabIndex = 11
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(98, 92)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(202, 20)
        Me.txtn2.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Number 2:"
        '
        'txtsum
        '
        Me.txtsum.Location = New System.Drawing.Point(98, 144)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.Size = New System.Drawing.Size(202, 20)
        Me.txtsum.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sum:"
        '
        'txtn3
        '
        Me.txtn3.Location = New System.Drawing.Point(98, 118)
        Me.txtn3.Name = "txtn3"
        Me.txtn3.Size = New System.Drawing.Size(202, 20)
        Me.txtn3.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Number 3:"
        '
        'txtprod
        '
        Me.txtprod.Location = New System.Drawing.Point(98, 196)
        Me.txtprod.Name = "txtprod"
        Me.txtprod.Size = New System.Drawing.Size(202, 20)
        Me.txtprod.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Prod:"
        '
        'txtdiff
        '
        Me.txtdiff.Location = New System.Drawing.Point(98, 170)
        Me.txtdiff.Name = "txtdiff"
        Me.txtdiff.Size = New System.Drawing.Size(202, 20)
        Me.txtdiff.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Diff:"
        '
        'txtquot
        '
        Me.txtquot.Location = New System.Drawing.Point(98, 222)
        Me.txtquot.Name = "txtquot"
        Me.txtquot.Size = New System.Drawing.Size(202, 20)
        Me.txtquot.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Quot:"
        '
        'txtave
        '
        Me.txtave.Location = New System.Drawing.Point(98, 248)
        Me.txtave.Name = "txtave"
        Me.txtave.Size = New System.Drawing.Size(202, 20)
        Me.txtave.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ave:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 292)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(93, 292)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(93, 23)
        Me.btnSubtract.TabIndex = 27
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(192, 292)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(85, 23)
        Me.btnMultiply.TabIndex = 28
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(283, 292)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 29
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAverage.Location = New System.Drawing.Point(52, 321)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 30
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(133, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(214, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 375)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtquot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtprod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiff)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtn3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Activity4_20260703"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtn1 As System.Windows.Forms.TextBox
    Friend WithEvents txtn2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtsum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtn3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdiff As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtquot As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtave As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
```

### 3. Sample Run
![Figure 4.1 — Sample Run of Activity4_20260703 Windows Forms Calculator](docs/images/act4_run.png)
*Figure 4.1 — Sample Run of Activity4_20260703 Windows Forms Calculator*

**Sample Run Walkthrough:**
- User enters Number 1 = 24, Number 2 = 6, and Number 3 = 2.
- Clicking Add, Subtract, Multiply, Divide, and Average populates Sum (32), Diff (16), Prod (2), Quot (288), and Ave (11).
- If an invalid number is entered, the Try...Catch block displays 'Error: Maybe Invalid Number...' in the target output TextBox.
- Clicking Clear resets all 8 TextBoxes; clicking Exit closes the application via Application.Exit().

### 4. Form Design
![Figure 4.2 — Visual Studio Form Design of Activity4_20260703 (399 × 375 px)](docs/images/act4_design.png)
*Figure 4.2 — Visual Studio Form Design of Activity4_20260703 (399 × 375 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `Form1` | Form | `"Activity4_20260703"` | Main calculator window (ClientSize: 399 × 375) |
| `Label1` | Label | `"Author: Alvarez Rex"` | Displays author name at (12, 9) in Courier New 9.75pt |
| `Label2` | Label | `"Course: BSIT Year: 2026 Section: 3B"` | Displays course/year/section at (12, 34) |
| `txtn1, txtn2, txtn3` | TextBox | `(Input Fields)` | Input textboxes for Number 1, Number 2, and Number 3 |
| `txtsum, txtdiff` | TextBox | `(Output Fields)` | Display computed sum and difference |
| `txtprod, txtquot, txtave` | TextBox | `(Output Fields)` | Display computed division/multiplication and average results |
| `btnAdd, btnSubtract` | Button | `"Add", "Subtract"` | Event buttons to compute sum and difference |
| `btnMultiply, btnDivide` | Button | `"Multiply", "Divide"` | Event buttons to compute product and quotient |
| `btnAverage` | Button | `"Average"` | Computes (n1 + n2 + n3) / 3 |
| `btnClear, btnExit` | Button | `"Clear", "Exit"` | Clears all textboxes or exits the application |

### 5. Brief Description
Activity 4 (Activity4_20260703) transitions from Console applications to event-driven Windows Forms GUI programming. The form contains three input TextBoxes (txtn1, txtn2, txtn3), five output TextBoxes (txtsum, txtdiff, txtprod, txtquot, txtave), and seven Buttons (Add, Subtract, Multiply, Divide, Average, Clear, and Exit). Each arithmetic button click handler parses the inputs using Convert.ToInt32() inside a Try...Catch block and displays either the calculated result or an error message.

---

## Activity 5: Grade Evaluator Using Nested Ternary If() Operator (Act5 / Ternary2)

### 1. Activity Title
- **Activity Title:** Activity 5: Grade Evaluator Using Nested Ternary If() Operator (Act5 / Ternary2)
- **Project Folder / Solution:** `Act5` (`Ternary2.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** July 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Public Class Form1

    'todo:
    'display passed or failed
    'get the value from the textbox
    Dim ave As Double
    Dim remarks As String

    'try to challenge your self

    Private Sub txtAverage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAverage.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub txtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks.TextChanged

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAverage.Clear()
        txtRemarks.Clear()
        txtRemarks2.Clear()
        txtRemarks3.Clear()
    End Sub

    Private Sub btnRemarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemarks.Click
        Try
            ave = Convert.ToDouble(txtAverage.Text)

            ' Remarks 1
            txtRemarks.Text = If(ave >= 75, "Passed", If(ave >= 70, "Conditional", "Failed"))

            ' Remarks 2
            txtRemarks2.Text = If(ave >= 94, "A",
                               If(ave >= 89, "B",
                               If(ave >= 84, "C",
                               If(ave >= 80, "D",
                               If(ave >= 75, "E", "F")))))

            ' Remarks 3 
            txtRemarks3.Text = If(ave >= 98, "1.00",
                               If(ave >= 95, "1.25",
                               If(ave >= 92, "1.50",
                               If(ave >= 89, "1.75",
                               If(ave >= 86, "2.00",
                               If(ave >= 83, "2.25",
                               If(ave >= 80, "2.50",
                               If(ave >= 77, "2.75",
                               If(ave >= 75, "3.00",
                               If(ave >= 70, "5.00", "Invalid Grade..."))))))))))

        Catch ex As Exception
            txtRemarks.Text = "There's something wrong with your code.."
            txtRemarks2.Text = "Make sure to enter the right grade number"
            txtRemarks3.Text = "Enter only numbers or decimal numbers"
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtRemarks2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks2.TextChanged

    End Sub

    Private Sub txtRemarks3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks3.TextChanged

    End Sub
End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemarks = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks2 = New System.Windows.Forms.TextBox()
        Me.txtRemarks3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Ternary Opt"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(114, 127)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(146, 20)
        Me.txtRemarks.TabIndex = 29
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(114, 101)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(146, 20)
        Me.txtAverage.TabIndex = 28
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 39)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemarks
        '
        Me.btnRemarks.Location = New System.Drawing.Point(23, 243)
        Me.btnRemarks.Name = "btnRemarks"
        Me.btnRemarks.Size = New System.Drawing.Size(75, 39)
        Me.btnRemarks.TabIndex = 25
        Me.btnRemarks.Text = "Display Remark"
        Me.btnRemarks.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Remarks:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Average:"
        '
        'txtRemarks2
        '
        Me.txtRemarks2.Location = New System.Drawing.Point(114, 153)
        Me.txtRemarks2.Name = "txtRemarks2"
        Me.txtRemarks2.Size = New System.Drawing.Size(146, 20)
        Me.txtRemarks2.TabIndex = 31
        '
        'txtRemarks3
        '
        Me.txtRemarks3.Location = New System.Drawing.Point(114, 179)
        Me.txtRemarks3.Name = "txtRemarks3"
        Me.txtRemarks3.Size = New System.Drawing.Size(146, 20)
        Me.txtRemarks3.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 360)
        Me.Controls.Add(Me.txtRemarks3)
        Me.Controls.Add(Me.txtRemarks2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRemarks As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks3 As System.Windows.Forms.TextBox

End Class
```

### 3. Sample Run
![Figure 5.1 — Sample Run of Ternary2 Grade Evaluator (Average = 92.5)](docs/images/act5_run.png)
*Figure 5.1 — Sample Run of Ternary2 Grade Evaluator (Average = 92.5)*

**Sample Run Walkthrough:**
- User enters an average grade of 92.5 into txtAverage and clicks 'Display Remark'.
- Remarks 1 (txtRemarks) evaluates If(ave >= 75, "Passed", ...) -> 'Passed'.
- Remarks 2 (txtRemarks2) evaluates nested ternary letter grade -> 'B' (for 89 <= ave < 94).
- Remarks 3 (txtRemarks3) evaluates nested ternary numeric grade point -> '1.50' (for 92 <= ave < 95).

### 4. Form Design
![Figure 5.2 — Visual Studio Form Design of Ternary2 (284 × 360 px)](docs/images/act5_design.png)
*Figure 5.2 — Visual Studio Form Design of Ternary2 (284 × 360 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `Form1` | Form | `"Form1"` | Main form container (ClientSize: 284 × 360) |
| `Label3` | Label | `"Ternary Opt"` | Form heading label at (111, 56) |
| `Label1, txtAverage` | Label, TextBox | `"Average:"` | Input field for the student's average grade at (114, 101) |
| `Label2, txtRemarks` | Label, TextBox | `"Remarks:"` | Displays Pass / Conditional / Failed remark at (114, 127) |
| `txtRemarks2` | TextBox | `(Letter Grade)` | Displays letter grade equivalent (A to F) at (114, 153) |
| `txtRemarks3` | TextBox | `(Point Equivalent)` | Displays college grade point (1.00 to 5.00) at (114, 179) |
| `btnRemarks` | Button | `"Display Remark"` | Evaluates all three nested ternary If() expressions |
| `btnClear` | Button | `"Clear"` | Clears txtAverage, txtRemarks, txtRemarks2, and txtRemarks3 |
| `btnExit` | Button | `"Exit"` | Closes the program via Application.Exit() |

### 5. Brief Description
Activity 5 (Act5 / Ternary2) demonstrates decision-making in VB.NET using the inline ternary operator If(condition, trueValue, falseValue). When the user enters a numerical average and clicks 'Display Remark', the program converts the input to a Double and evaluates three levels of nested ternary expressions to simultaneously output: (1) status remarks ('Passed', 'Conditional', or 'Failed'), (2) letter grade ('A' through 'F'), and (3) university numerical grade point equivalent ('1.00' through '5.00').

---

## Activity 6: Grade Average & Multi-Remark Evaluation Using Select Case (Act6_IntegProg1_20260715)

### 1. Activity Title
- **Activity Title:** Activity 6: Grade Average & Multi-Remark Evaluation Using Select Case (Act6_IntegProg1_20260715)
- **Project Folder / Solution:** `Act6_IntegProg1_20260715` (`IntegrativeProg1_20260715.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** July 15, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Public Class Form1

    Dim g1, g2, g3, sum, ave As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub txtG1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtG2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtG3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtAve_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtRemarks1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtRemarks2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtRemarks3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub btnDisplay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()

    End Sub

    Private Sub btnDisplay_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Try

            'convert to double first
            g1 = Convert.ToInt32(txtG1.Text())
            g2 = Convert.ToInt32(txtG2.Text())
            g3 = Convert.ToInt32(txtG3.Text())

            'get the sum and average of the 3 numbers
            sum = g1 + g2 + g3
            ave = sum / 3.0

            'get the value of txtave then convert to string
            txtAve.Text = ave.ToString()

            'decisions
            'remarks 1
            Select Case ave
                Case Is >= 75
                    txtRemarks1.Text = "Passed!"
                Case 74 To 70
                    txtRemarks1.Text = "Conditional!"
                Case Is < 70
                    txtRemarks1.Text = "Failed!"
                Case Else
                    txtRemarks1.Text = "Invalid Grade..."
            End Select

            'remarks 2
            Select Case ave
                Case 95 To 100
                    txtRemarks2.Text = "A"
                Case 89 To 94
                    txtRemarks2.Text = "B"
                Case 80 To 88
                    txtRemarks2.Text = "C"
                Case 75 To 79
                    txtRemarks2.Text = "D"
                Case 70 To 74
                    txtRemarks2.Text = "E"
                Case Is < 70
                    txtRemarks2.Text = "F"
                Case Else
                    txtRemarks2.Text = "Invalid Grade..."
            End Select

            'remarks 3
            Select Case ave
                Case 98 To 100
                    txtRemarks3.Text = "1.00"
                Case 95 To 97
                    txtRemarks3.Text = "1.25"
                Case 92 To 94
                    txtRemarks3.Text = "1.50"
                Case 89 To 91
                    txtRemarks3.Text = "1.75"
                Case 86 To 88
                    txtRemarks3.Text = "2.00"
                Case 83 To 85
                    txtRemarks3.Text = "2.25"
                Case 80 To 82
                    txtRemarks3.Text = "2.50"
                Case 77 To 79
                    txtRemarks3.Text = "2.75"
                Case 75 To 76
                    txtRemarks3.Text = "3.00"
                Case 70 To 74
                    txtRemarks3.Text = "4.00"
                Case Is < 70
                    txtRemarks3.Text = "5.00"
                Case Else
                    txtRemarks3.Text = "Invalid Grade..."
            End Select


            'errror handling
        Catch ex As Exception
            txtRemarks1.Text = "Theres something wrong with your code.."
            txtRemarks2.Text = "Make sure to enter the right grade number"
            txtRemarks3.Text = "Enter only number or decimal number"
        End Try
    End Sub

    Private Sub btnExit_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'exits the application
        Application.Exit()
    End Sub

    Private Sub btnClear_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear all grade inputs and outputs
        txtG1.Clear()
        txtG2.Clear()
        txtG3.Clear()
        txtAve.Clear()
        txtRemarks1.Clear()
        txtRemarks2.Clear()
        txtRemarks3.Clear()
    End Sub
End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtRemarks3 = New System.Windows.Forms.TextBox()
        Me.txtRemarks2 = New System.Windows.Forms.TextBox()
        Me.txtRemarks1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAve = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtG3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtG2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtG1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 18)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Author: ALVAREZ REX M."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 18)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Select Case Demo"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(216, 287)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 25)
        Me.btnExit.TabIndex = 73
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(138, 287)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 25)
        Me.btnClear.TabIndex = 72
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(60, 287)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(74, 25)
        Me.btnDisplay.TabIndex = 71
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtRemarks3
        '
        Me.txtRemarks3.Location = New System.Drawing.Point(153, 250)
        Me.txtRemarks3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRemarks3.Name = "txtRemarks3"
        Me.txtRemarks3.Size = New System.Drawing.Size(158, 20)
        Me.txtRemarks3.TabIndex = 70
        '
        'txtRemarks2
        '
        Me.txtRemarks2.Location = New System.Drawing.Point(153, 227)
        Me.txtRemarks2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRemarks2.Name = "txtRemarks2"
        Me.txtRemarks2.Size = New System.Drawing.Size(158, 20)
        Me.txtRemarks2.TabIndex = 69
        '
        'txtRemarks1
        '
        Me.txtRemarks1.Location = New System.Drawing.Point(153, 205)
        Me.txtRemarks1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRemarks1.Name = "txtRemarks1"
        Me.txtRemarks1.Size = New System.Drawing.Size(158, 20)
        Me.txtRemarks1.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Remarks:"
        '
        'txtAve
        '
        Me.txtAve.Location = New System.Drawing.Point(153, 182)
        Me.txtAve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAve.Name = "txtAve"
        Me.txtAve.Size = New System.Drawing.Size(158, 20)
        Me.txtAve.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Ave:"
        '
        'txtG3
        '
        Me.txtG3.Location = New System.Drawing.Point(153, 159)
        Me.txtG3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtG3.Name = "txtG3"
        Me.txtG3.Size = New System.Drawing.Size(158, 20)
        Me.txtG3.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Grade 3:"
        '
        'txtG2
        '
        Me.txtG2.Location = New System.Drawing.Point(153, 136)
        Me.txtG2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtG2.Name = "txtG2"
        Me.txtG2.Size = New System.Drawing.Size(158, 20)
        Me.txtG2.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Grade 2:"
        '
        'txtG1
        '
        Me.txtG1.Location = New System.Drawing.Point(153, 114)
        Me.txtG1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtG1.Name = "txtG1"
        Me.txtG1.Size = New System.Drawing.Size(158, 20)
        Me.txtG1.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Grade 1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 353)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtRemarks3)
        Me.Controls.Add(Me.txtRemarks2)
        Me.Controls.Add(Me.txtRemarks1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAve)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtG3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtG2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtG1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Activity Case"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents txtRemarks3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAve As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtG3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtG2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtG1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
```

### 3. Sample Run
![Figure 6.1 — Sample Run of Activity Case (Select Case Demo)](docs/images/act6_run.png)
*Figure 6.1 — Sample Run of Activity Case (Select Case Demo)*

**Sample Run Walkthrough:**
- User enters three grades: Grade 1 = 90, Grade 2 = 92, Grade 3 = 94, and clicks Display.
- Program computes sum = 276 and ave = 92, displaying '92' in txtAve.
- Three Select Case blocks evaluate ave = 92 to display 'Passed!' in txtRemarks1, 'B' in txtRemarks2, and '1.50' in txtRemarks3.

### 4. Form Design
![Figure 6.2 — Visual Studio Form Design of Activity Case (350 × 353 px)](docs/images/act6_design.png)
*Figure 6.2 — Visual Studio Form Design of Activity Case (350 × 353 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `Form1` | Form | `"Activity Case"` | Main form window (ClientSize: 350 × 353) |
| `Label6` | Label | `"Select Case Demo"` | Header title label at (112, 40) |
| `Label7` | Label | `"Author: ALVAREZ REX M."` | Author label at (95, 69) |
| `txtG1, txtG2, txtG3` | TextBox | `(Grade Inputs)` | Input textboxes for Grade 1, Grade 2, and Grade 3 |
| `txtAve` | TextBox | `(Computed Average)` | Displays the average of the three grades at (153, 182) |
| `txtRemarks1` | TextBox | `(Status Remark)` | Displays 'Passed!', 'Conditional!', or 'Failed!' |
| `txtRemarks2` | TextBox | `(Letter Grade)` | Displays 'A', 'B', 'C', 'D', 'E', or 'F' |
| `txtRemarks3` | TextBox | `(Numeric Grade)` | Displays '1.00' through '5.00' grade equivalent |
| `btnDisplay, btnClear, btnExit` | Button | `"Display", "Clear", "Exit"` | Action buttons at row Y = 287 |

### 5. Brief Description
Activity 6 (Act6_IntegProg1_20260715) computes the average of three student grades (txtG1, txtG2, txtG3) and uses VB.NET Select Case statements—featuring relational clauses (Case Is >= 75, Case Is < 70) and range clauses (Case 95 To 100, Case 92 To 94, etc.)—to classify the resulting average into pass/fail remarks, letter grades (A–F), and numerical grade points (1.00–5.00).

---

## Activity 7: Multi-Tab Control & Looping Structures (Act7_IntegProg1_SW20260720)

### 1. Activity Title
- **Activity Title:** Activity 7: Multi-Tab Control & Looping Structures (Act7_IntegProg1_SW20260720)
- **Project Folder / Solution:** `Act7_IntegProg1_SW20260720` (`IntegProg1_SW20260720.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** July 20, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Public Class Form1

    Private Sub calculateButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles calculateButton.Click

        Dim principal As Decimal = Val(principalTextBox.Text)
        Dim rate As Decimal = Val(interestRateTextBox.Text)
        Dim amount As Decimal

        resultsListBox.Items.Add(
            "Year" & vbTab & "Amount on Deposit")

        For yearCounter As Integer = 1 To yearsNumericUpDown.Value
            amount = principal * ((1 + rate / 100) ^ yearCounter)
            resultsListBox.Items.Add(yearCounter & vbTab &
                String.Format("{0:C}", amount))
        Next
    End Sub

    Private Sub principalTextBox_TextChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles principalTextBox.TextChanged
        resultsListBox.Items.Clear()
    End Sub

    Private Sub interestRateTextBox_TextChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles interestRateTextBox.TextChanged
        resultsListBox.Items.Clear()
    End Sub

    Private Sub yearsNumericUpDown_ValueChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles yearsNumericUpDown.ValueChanged
        resultsListBox.Items.Clear()
    End Sub

    Private Sub displaySquareButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles displaySquareButton.Click

        outputTextBox.Clear()

        Dim fillCharacter As String = fillCharacterTextBox.Text
        Dim sideLength As Integer = sideLengthNumericUpDown.Value

        For row As Integer = 1 To sideLength
            For column As Integer = 1 To sideLength
                outputTextBox.AppendText(fillCharacter & " ")
            Next column

            outputTextBox.AppendText(vbCrLf)
        Next row
    End Sub

    Private Sub fillCharacterTextBox_TextChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles fillCharacterTextBox.TextChanged
        outputTextBox.Clear()
    End Sub

    Private Sub sideLengthNumericUpDown_ValueChanged(ByVal sender As Object,
            ByVal e As EventArgs) Handles sideLengthNumericUpDown.ValueChanged
        outputTextBox.Clear()
    End Sub

    Dim aCount As Integer
    Dim bCount As Integer
    Dim cCount As Integer
    Dim dCount As Integer
    Dim fCount As Integer
    Dim perfectScoreCount As Integer

    Private Sub submitGradeButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles submitGradeButton.Click

        Dim grade As Integer = Val(gradeTextBox.Text)

        gradesListBox.Items.Add(grade)
        gradeTextBox.Clear()

        Select Case grade
            Case 100
                perfectScoreCount += 1
                aCount += 1
            Case 90 To 99
                aCount += 1
            Case 80 To 89
                bCount += 1
            Case 70 To 79
                cCount += 1
            Case 60 To 69
                dCount += 1
            Case Else
                fCount += 1
        End Select

        gradeTextBox.Focus()
    End Sub

    Private Sub calculateAverageButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles calculateAverageButton.Click

        Dim total As Integer
        Dim gradeCounter As Integer
        Dim grade As Integer
        Dim average As Double

        total = 0
        gradeCounter = 0

        Do While gradeCounter < gradesListBox.Items.Count
            grade = gradesListBox.Items(gradeCounter)
            total += grade
            gradeCounter += 1
        Loop

        If gradeCounter <> 0 Then
            average = total / gradeCounter

            classAverageLabel.Text = "Total of the " & gradeCounter &
                " grade(s) is " & total & vbCrLf & "Class average is " &
                String.Format("{0:F}", average) & vbCrLf & vbCrLf

            classAverageLabel.Text &=
                "Letter grade summary:" & vbCrLf & "A: " & aCount &
                vbCrLf & "B: " & bCount & vbCrLf & "C: " & cCount &
                vbCrLf & "D: " & dCount & vbCrLf & "F: " & fCount &
                vbCrLf & "Perfect scores: " & perfectScoreCount
        Else
            classAverageLabel.Text = "No grades were entered"
        End If
    End Sub

    Private Sub clearGradesButton_Click(ByVal sender As Object,
            ByVal e As EventArgs) Handles clearGradesButton.Click

        gradesListBox.Items.Clear()
        classAverageLabel.Text = String.Empty
    End Sub

    Private Sub Form1_Load(ByVal sender As Object,
            ByVal e As EventArgs) Handles MyBase.Load

        decimalOutputTextBox.AppendText("Decimal" & vbTab & "Octal" &
            vbTab & "Hexadecimal" & vbTab & "Binary" & vbCrLf)

        For number As Integer = 1 To 255
            decimalOutputTextBox.AppendText(number & vbTab &
                Convert.ToString(number, 8) & vbTab &
                Convert.ToString(number, 16).ToUpper() & vbTab & vbTab &
                Convert.ToString(number, 2) & vbCrLf)
        Next number
    End Sub

    Private Sub decimalOutputTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decimalOutputTextBox.TextChanged

    End Sub

    Private Sub tabClassAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabClassAverage.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        'square, rectangle, trapesoid, triangle, circle
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub
End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInterest = New System.Windows.Forms.TabPage()
        Me.principalLabel = New System.Windows.Forms.Label()
        Me.principalTextBox = New System.Windows.Forms.TextBox()
        Me.interestRateLabel = New System.Windows.Forms.Label()
        Me.interestRateTextBox = New System.Windows.Forms.TextBox()
        Me.yearsLabel = New System.Windows.Forms.Label()
        Me.yearsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.balancesLabel = New System.Windows.Forms.Label()
        Me.resultsListBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.tabSquare = New System.Windows.Forms.TabPage()
        Me.fillCharacterLabel = New System.Windows.Forms.Label()
        Me.fillCharacterTextBox = New System.Windows.Forms.TextBox()
        Me.sideLengthLabel = New System.Windows.Forms.Label()
        Me.sideLengthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.displaySquareButton = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.tabClassAverage = New System.Windows.Forms.TabPage()
        Me.gradeLabel = New System.Windows.Forms.Label()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.submitGradeButton = New System.Windows.Forms.Button()
        Me.gradesLabel = New System.Windows.Forms.Label()
        Me.gradesListBox = New System.Windows.Forms.ListBox()
        Me.calculateAverageButton = New System.Windows.Forms.Button()
        Me.clearGradesButton = New System.Windows.Forms.Button()
        Me.classAverageLabel = New System.Windows.Forms.Label()
        Me.tabDecimalEquivalent = New System.Windows.Forms.TabPage()
        Me.decimalOutputTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tabInterest.SuspendLayout()
        CType(Me.yearsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSquare.SuspendLayout()
        CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClassAverage.SuspendLayout()
        Me.tabDecimalEquivalent.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInterest)
        Me.TabControl1.Controls.Add(Me.tabSquare)
        Me.TabControl1.Controls.Add(Me.tabClassAverage)
        Me.TabControl1.Controls.Add(Me.tabDecimalEquivalent)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 412)
        Me.TabControl1.TabIndex = 0
        '
        'tabInterest
        '
        Me.tabInterest.Controls.Add(Me.principalLabel)
        Me.tabInterest.Controls.Add(Me.principalTextBox)
        Me.tabInterest.Controls.Add(Me.interestRateLabel)
        Me.tabInterest.Controls.Add(Me.interestRateTextBox)
        Me.tabInterest.Controls.Add(Me.yearsLabel)
        Me.tabInterest.Controls.Add(Me.yearsNumericUpDown)
        Me.tabInterest.Controls.Add(Me.balancesLabel)
        Me.tabInterest.Controls.Add(Me.resultsListBox)
        Me.tabInterest.Controls.Add(Me.calculateButton)
        Me.tabInterest.Location = New System.Drawing.Point(4, 22)
        Me.tabInterest.Name = "tabInterest"
        Me.tabInterest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInterest.Size = New System.Drawing.Size(564, 386)
        Me.tabInterest.TabIndex = 0
        Me.tabInterest.Text = "App: Interest Calculator"
        Me.tabInterest.UseVisualStyleBackColor = True
        '
        'principalLabel
        '
        Me.principalLabel.AutoSize = True
        Me.principalLabel.Location = New System.Drawing.Point(12, 17)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Size = New System.Drawing.Size(50, 13)
        Me.principalLabel.TabIndex = 0
        Me.principalLabel.Text = "Principal:"
        '
        'principalTextBox
        '
        Me.principalTextBox.Location = New System.Drawing.Point(90, 15)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Size = New System.Drawing.Size(150, 20)
        Me.principalTextBox.TabIndex = 1
        Me.principalTextBox.Text = "1000"
        '
        'interestRateLabel
        '
        Me.interestRateLabel.AutoSize = True
        Me.interestRateLabel.Location = New System.Drawing.Point(12, 43)
        Me.interestRateLabel.Name = "interestRateLabel"
        Me.interestRateLabel.Size = New System.Drawing.Size(66, 13)
        Me.interestRateLabel.TabIndex = 2
        Me.interestRateLabel.Text = "Interest rate:"
        '
        'interestRateTextBox
        '
        Me.interestRateTextBox.Location = New System.Drawing.Point(90, 41)
        Me.interestRateTextBox.Name = "interestRateTextBox"
        Me.interestRateTextBox.Size = New System.Drawing.Size(150, 20)
        Me.interestRateTextBox.TabIndex = 3
        Me.interestRateTextBox.Text = "5"
        '
        'yearsLabel
        '
        Me.yearsLabel.AutoSize = True
        Me.yearsLabel.Location = New System.Drawing.Point(12, 69)
        Me.yearsLabel.Name = "yearsLabel"
        Me.yearsLabel.Size = New System.Drawing.Size(37, 13)
        Me.yearsLabel.TabIndex = 4
        Me.yearsLabel.Text = "Years:"
        '
        'yearsNumericUpDown
        '
        Me.yearsNumericUpDown.Location = New System.Drawing.Point(90, 67)
        Me.yearsNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.yearsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.yearsNumericUpDown.Name = "yearsNumericUpDown"
        Me.yearsNumericUpDown.Size = New System.Drawing.Size(150, 20)
        Me.yearsNumericUpDown.TabIndex = 5
        Me.yearsNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'balancesLabel
        '
        Me.balancesLabel.AutoSize = True
        Me.balancesLabel.Location = New System.Drawing.Point(12, 106)
        Me.balancesLabel.Name = "balancesLabel"
        Me.balancesLabel.Size = New System.Drawing.Size(54, 13)
        Me.balancesLabel.TabIndex = 6
        Me.balancesLabel.Text = "Balances:"
        '
        'resultsListBox
        '
        Me.resultsListBox.FormattingEnabled = True
        Me.resultsListBox.Location = New System.Drawing.Point(90, 103)
        Me.resultsListBox.Name = "resultsListBox"
        Me.resultsListBox.Size = New System.Drawing.Size(440, 212)
        Me.resultsListBox.TabIndex = 7
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(255, 13)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(90, 23)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'tabSquare
        '
        Me.tabSquare.Controls.Add(Me.fillCharacterLabel)
        Me.tabSquare.Controls.Add(Me.fillCharacterTextBox)
        Me.tabSquare.Controls.Add(Me.sideLengthLabel)
        Me.tabSquare.Controls.Add(Me.sideLengthNumericUpDown)
        Me.tabSquare.Controls.Add(Me.displaySquareButton)
        Me.tabSquare.Controls.Add(Me.outputTextBox)
        Me.tabSquare.Location = New System.Drawing.Point(4, 22)
        Me.tabSquare.Name = "tabSquare"
        Me.tabSquare.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSquare.Size = New System.Drawing.Size(564, 386)
        Me.tabSquare.TabIndex = 1
        Me.tabSquare.Text = "Square of Character"
        Me.tabSquare.UseVisualStyleBackColor = True
        '
        'fillCharacterLabel
        '
        Me.fillCharacterLabel.AutoSize = True
        Me.fillCharacterLabel.Location = New System.Drawing.Point(14, 20)
        Me.fillCharacterLabel.Name = "fillCharacterLabel"
        Me.fillCharacterLabel.Size = New System.Drawing.Size(95, 13)
        Me.fillCharacterLabel.TabIndex = 0
        Me.fillCharacterLabel.Text = "Enter fill character:"
        '
        'fillCharacterTextBox
        '
        Me.fillCharacterTextBox.Location = New System.Drawing.Point(119, 17)
        Me.fillCharacterTextBox.Name = "fillCharacterTextBox"
        Me.fillCharacterTextBox.Size = New System.Drawing.Size(50, 20)
        Me.fillCharacterTextBox.TabIndex = 1
        Me.fillCharacterTextBox.Text = "#"
        '
        'sideLengthLabel
        '
        Me.sideLengthLabel.AutoSize = True
        Me.sideLengthLabel.Location = New System.Drawing.Point(14, 46)
        Me.sideLengthLabel.Name = "sideLengthLabel"
        Me.sideLengthLabel.Size = New System.Drawing.Size(89, 13)
        Me.sideLengthLabel.TabIndex = 2
        Me.sideLengthLabel.Text = "Enter side length:"
        '
        'sideLengthNumericUpDown
        '
        Me.sideLengthNumericUpDown.Location = New System.Drawing.Point(119, 43)
        Me.sideLengthNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.sideLengthNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sideLengthNumericUpDown.Name = "sideLengthNumericUpDown"
        Me.sideLengthNumericUpDown.Size = New System.Drawing.Size(50, 20)
        Me.sideLengthNumericUpDown.TabIndex = 3
        Me.sideLengthNumericUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'displaySquareButton
        '
        Me.displaySquareButton.Location = New System.Drawing.Point(230, 15)
        Me.displaySquareButton.Name = "displaySquareButton"
        Me.displaySquareButton.Size = New System.Drawing.Size(100, 23)
        Me.displaySquareButton.TabIndex = 4
        Me.displaySquareButton.Text = "Display Square"
        Me.displaySquareButton.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTextBox.Location = New System.Drawing.Point(14, 78)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(535, 290)
        Me.outputTextBox.TabIndex = 5
        '
        'tabClassAverage
        '
        Me.tabClassAverage.Controls.Add(Me.gradeLabel)
        Me.tabClassAverage.Controls.Add(Me.gradeTextBox)
        Me.tabClassAverage.Controls.Add(Me.submitGradeButton)
        Me.tabClassAverage.Controls.Add(Me.gradesLabel)
        Me.tabClassAverage.Controls.Add(Me.gradesListBox)
        Me.tabClassAverage.Controls.Add(Me.calculateAverageButton)
        Me.tabClassAverage.Controls.Add(Me.clearGradesButton)
        Me.tabClassAverage.Controls.Add(Me.classAverageLabel)
        Me.tabClassAverage.Location = New System.Drawing.Point(4, 22)
        Me.tabClassAverage.Name = "tabClassAverage"
        Me.tabClassAverage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClassAverage.Size = New System.Drawing.Size(564, 386)
        Me.tabClassAverage.TabIndex = 2
        Me.tabClassAverage.Text = "Class Average"
        Me.tabClassAverage.UseVisualStyleBackColor = True
        '
        'gradeLabel
        '
        Me.gradeLabel.AutoSize = True
        Me.gradeLabel.Location = New System.Drawing.Point(18, 20)
        Me.gradeLabel.Name = "gradeLabel"
        Me.gradeLabel.Size = New System.Drawing.Size(65, 13)
        Me.gradeLabel.TabIndex = 0
        Me.gradeLabel.Text = "Enter grade:"
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(87, 17)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(70, 20)
        Me.gradeTextBox.TabIndex = 1
        '
        'submitGradeButton
        '
        Me.submitGradeButton.Location = New System.Drawing.Point(172, 15)
        Me.submitGradeButton.Name = "submitGradeButton"
        Me.submitGradeButton.Size = New System.Drawing.Size(95, 23)
        Me.submitGradeButton.TabIndex = 2
        Me.submitGradeButton.Text = "Submit Grade"
        Me.submitGradeButton.UseVisualStyleBackColor = True
        '
        'gradesLabel
        '
        Me.gradesLabel.AutoSize = True
        Me.gradesLabel.Location = New System.Drawing.Point(18, 50)
        Me.gradesLabel.Name = "gradesLabel"
        Me.gradesLabel.Size = New System.Drawing.Size(44, 13)
        Me.gradesLabel.TabIndex = 3
        Me.gradesLabel.Text = "Grades:"
        '
        'gradesListBox
        '
        Me.gradesListBox.FormattingEnabled = True
        Me.gradesListBox.Location = New System.Drawing.Point(18, 70)
        Me.gradesListBox.Name = "gradesListBox"
        Me.gradesListBox.Size = New System.Drawing.Size(150, 186)
        Me.gradesListBox.TabIndex = 4
        '
        'calculateAverageButton
        '
        Me.calculateAverageButton.Location = New System.Drawing.Point(18, 263)
        Me.calculateAverageButton.Name = "calculateAverageButton"
        Me.calculateAverageButton.Size = New System.Drawing.Size(150, 24)
        Me.calculateAverageButton.TabIndex = 5
        Me.calculateAverageButton.Text = "Calculate Average"
        Me.calculateAverageButton.UseVisualStyleBackColor = True
        '
        'clearGradesButton
        '
        Me.clearGradesButton.Location = New System.Drawing.Point(18, 293)
        Me.clearGradesButton.Name = "clearGradesButton"
        Me.clearGradesButton.Size = New System.Drawing.Size(150, 24)
        Me.clearGradesButton.TabIndex = 6
        Me.clearGradesButton.Text = "Clear Grades"
        Me.clearGradesButton.UseVisualStyleBackColor = True
        '
        'classAverageLabel
        '
        Me.classAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.classAverageLabel.Location = New System.Drawing.Point(184, 70)
        Me.classAverageLabel.Name = "classAverageLabel"
        Me.classAverageLabel.Size = New System.Drawing.Size(365, 247)
        Me.classAverageLabel.TabIndex = 7
        '
        'tabDecimalEquivalent
        '
        Me.tabDecimalEquivalent.Controls.Add(Me.decimalOutputTextBox)
        Me.tabDecimalEquivalent.Location = New System.Drawing.Point(4, 22)
        Me.tabDecimalEquivalent.Name = "tabDecimalEquivalent"
        Me.tabDecimalEquivalent.Size = New System.Drawing.Size(564, 386)
        Me.tabDecimalEquivalent.TabIndex = 3
        Me.tabDecimalEquivalent.Text = "Decimal Equivalent"
        Me.tabDecimalEquivalent.UseVisualStyleBackColor = True
        '
        'decimalOutputTextBox
        '
        Me.decimalOutputTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decimalOutputTextBox.Location = New System.Drawing.Point(14, 14)
        Me.decimalOutputTextBox.Multiline = True
        Me.decimalOutputTextBox.Name = "decimalOutputTextBox"
        Me.decimalOutputTextBox.ReadOnly = True
        Me.decimalOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.decimalOutputTextBox.Size = New System.Drawing.Size(536, 350)
        Me.decimalOutputTextBox.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 386)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Area Calculator"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(6, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(552, 377)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 351)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(544, 351)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(544, 351)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 424)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IntegProg1_SW20260720"
        Me.TabControl1.ResumeLayout(False)
        Me.tabInterest.ResumeLayout(False)
        Me.tabInterest.PerformLayout()
        CType(Me.yearsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSquare.ResumeLayout(False)
        Me.tabSquare.PerformLayout()
        CType(Me.sideLengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClassAverage.ResumeLayout(False)
        Me.tabClassAverage.PerformLayout()
        Me.tabDecimalEquivalent.ResumeLayout(False)
        Me.tabDecimalEquivalent.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabInterest As System.Windows.Forms.TabPage
    Friend WithEvents tabSquare As System.Windows.Forms.TabPage
    Friend WithEvents tabClassAverage As System.Windows.Forms.TabPage
    Friend WithEvents tabDecimalEquivalent As System.Windows.Forms.TabPage
    Friend WithEvents principalLabel As System.Windows.Forms.Label
    Friend WithEvents principalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents interestRateLabel As System.Windows.Forms.Label
    Friend WithEvents interestRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents yearsLabel As System.Windows.Forms.Label
    Friend WithEvents yearsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents balancesLabel As System.Windows.Forms.Label
    Friend WithEvents resultsListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents fillCharacterLabel As System.Windows.Forms.Label
    Friend WithEvents fillCharacterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sideLengthLabel As System.Windows.Forms.Label
    Friend WithEvents sideLengthNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents displaySquareButton As System.Windows.Forms.Button
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gradeLabel As System.Windows.Forms.Label
    Friend WithEvents gradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents submitGradeButton As System.Windows.Forms.Button
    Friend WithEvents gradesLabel As System.Windows.Forms.Label
    Friend WithEvents gradesListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateAverageButton As System.Windows.Forms.Button
    Friend WithEvents clearGradesButton As System.Windows.Forms.Button
    Friend WithEvents classAverageLabel As System.Windows.Forms.Label
    Friend WithEvents decimalOutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
End Class
```

### 3. Sample Run
![Figure 7.1 — Sample Runs Across All 4 Active Tabs of IntegProg1_SW20260720](docs/images/act7_run.png)
*Figure 7.1 — Sample Runs Across All 4 Active Tabs of IntegProg1_SW20260720*

**Sample Run Walkthrough:**
- Tab 1 (App: Interest Calculator): With Principal = 1000, Interest rate = 5%, Years = 10, clicking Calculate runs a For...Next loop from year 1 to 10 using A = P(1 + r/100)^n and lists currency-formatted balances ($1,050.00 to $1,628.89).
- Tab 2 (Square of Character): With fill character '#' and side length 8, nested For...Next loops (row and column) render an 8×8 grid of '#' characters in outputTextBox.
- Tab 3 (Class Average): Submitting grades (100, 92, 85, 78, 95, 88) tallies letter buckets via Select Case and uses a Do While...Loop to compute Total = 538, Class average = 89.67, and Letter grade summary.
- Tab 4 (Decimal Equivalent): On Form1_Load, a For...Next loop from 1 to 255 populates Decimal, Octal (base 8), Hexadecimal (base 16), and Binary (base 2) equivalents.

### 4. Form Design
![Figure 7.2 — Visual Studio Form Design of IntegProg1_SW20260720 (584 × 424 px)](docs/images/act7_design.png)
*Figure 7.2 — Visual Studio Form Design of IntegProg1_SW20260720 (584 × 424 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `TabControl1` | TabControl | `5 TabPages` | Main tab container (572 × 412) organizing 5 mini-applications |
| `tabInterest` | TabPage | `"App: Interest Calculator"` | Contains principalTextBox, interestRateTextBox, yearsNumericUpDown, resultsListBox, calculateButton |
| `tabSquare` | TabPage | `"Square of Character"` | Contains fillCharacterTextBox, sideLengthNumericUpDown, displaySquareButton, outputTextBox |
| `tabClassAverage` | TabPage | `"Class Average"` | Contains gradeTextBox, submitGradeButton, gradesListBox, calculateAverageButton, clearGradesButton, classAverageLabel |
| `tabDecimalEquivalent` | TabPage | `"Decimal Equivalent"` | Contains read-only multiline decimalOutputTextBox with vertical scrollbar |
| `TabPage1 / TabControl2` | TabPage / TabControl | `"Area Calculator"` | Demonstrates nested TabControl (TabControl2 with TabPage2, TabPage3, TabPage4) |

### 5. Brief Description
Activity 7 (Act7_IntegProg1_SW20260720) combines the Windows Forms TabControl container with VB.NET repetition and selection structures. Across its tabs, it demonstrates: (1) a single For...Next loop for compound interest calculation with currency formatting ({0:C}), (2) nested For...Next loops for 2D character grid generation, (3) a Do While...Loop paired with Select Case counters for computing class averages and letter-grade distributions, and (4) base conversion (Convert.ToString(number, base)) for generating a Decimal, Octal, Hexadecimal, and Binary table from 1 to 255.

---

## Activity 8: Interactive MessageBox Customizer — "The Message" (Act8_SW20260805)

### 1. Activity Title
- **Activity Title:** Activity 8: Interactive MessageBox Customizer — "The Message" (Act8_SW20260805)
- **Project Folder / Solution:** `Act8_SW20260805` (`TheMessage.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** August 5, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub messageInfoGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles messageInfoGroupBox.Enter

    End Sub

    Private Sub titleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titleTextBox.TextChanged

    End Sub

    Private Sub messageTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles messageTextBox.TextChanged

    End Sub

    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click

        Dim messageDescription As String = messageTextBox.Text
        Dim messageTitle As String = titleTextBox.Text

        Dim iconType As MessageBoxIcon
        Dim buttonType As MessageBoxButtons
        Dim defaultButton As MessageBoxDefaultButton

        Dim result As DialogResult

        Try

            If String.IsNullOrWhiteSpace(titleTextBox.Text) Then
                MessageBox.Show("Please enter a title.",
                                "Missing Title",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                titleTextBox.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(messageTextBox.Text) Then
                MessageBox.Show("Please enter a message.",
                                "Missing Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                messageTextBox.Focus()
                Return
            End If

            If Not informationRadioButton.Checked AndAlso
               Not warningRadioButton.Checked AndAlso
               Not questionRadioButton.Checked AndAlso
               Not criticalRadioButton.Checked Then

                MessageBox.Show("Please select an icon.",
                                "Icon Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                Return
            End If

            If Not okRadioButton.Checked AndAlso
               Not okCancelRadioButton.Checked AndAlso
               Not yesNoRadioButton.Checked AndAlso
               Not yesNoCancelRadioButton.Checked AndAlso
               Not retryCancelRadioButton.Checked AndAlso
               Not abortRetryIgnoreRadioButton.Checked Then

                MessageBox.Show("Please select a button type.",
                                "Button Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                Return
            End If

            If Not defaultButton1RadioButton.Checked AndAlso
               Not defaultButton2RadioButton.Checked AndAlso
               Not defaultButton3RadioButton.Checked Then

                MessageBox.Show("Please select a default button.",
                                "Default Button Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                Return
            End If

            If informationRadioButton.Checked Then
                iconType = MessageBoxIcon.Information

            ElseIf warningRadioButton.Checked Then
                iconType = MessageBoxIcon.Warning

            ElseIf questionRadioButton.Checked Then
                iconType = MessageBoxIcon.Question

            Else
                iconType = MessageBoxIcon.Error
            End If

            If okRadioButton.Checked Then
                buttonType = MessageBoxButtons.OK

            ElseIf okCancelRadioButton.Checked Then
                buttonType = MessageBoxButtons.OKCancel

            ElseIf yesNoRadioButton.Checked Then
                buttonType = MessageBoxButtons.YesNo

            ElseIf yesNoCancelRadioButton.Checked Then
                buttonType = MessageBoxButtons.YesNoCancel

            ElseIf retryCancelRadioButton.Checked Then
                buttonType = MessageBoxButtons.RetryCancel

            Else
                buttonType = MessageBoxButtons.AbortRetryIgnore
            End If

            If defaultButton1RadioButton.Checked Then
                defaultButton = MessageBoxDefaultButton.Button1

            ElseIf defaultButton2RadioButton.Checked Then
                defaultButton = MessageBoxDefaultButton.Button2

            Else
                defaultButton = MessageBoxDefaultButton.Button3
            End If

            result = MessageBox.Show(
                messageDescription,
                messageTitle,
                buttonType,
                iconType,
                defaultButton)

            Select Case result

                Case DialogResult.OK
                    MessageBox.Show("OK has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Case DialogResult.Cancel
                    MessageBox.Show("Cancel has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Case DialogResult.Yes
                    MessageBox.Show("Yes has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Case DialogResult.No
                    MessageBox.Show("No has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Case DialogResult.Retry
                    MessageBox.Show("Retry has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Case DialogResult.Abort
                    MessageBox.Show("Abort has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                Case DialogResult.Ignore
                    MessageBox.Show("Ignore has been clicked!",
                                    "Result",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

            End Select

        Catch ex As Exception

            MessageBox.Show(ex.Message,
                            "There is an error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        titleTextBox.Clear()
        messageTextBox.Clear()

        informationRadioButton.Checked = False
        warningRadioButton.Checked = False
        questionRadioButton.Checked = False
        criticalRadioButton.Checked = False

        okRadioButton.Checked = False
        okCancelRadioButton.Checked = False
        yesNoRadioButton.Checked = False
        yesNoCancelRadioButton.Checked = False
        retryCancelRadioButton.Checked = False
        abortRetryIgnoreRadioButton.Checked = False

        defaultButton1RadioButton.Checked = False
        defaultButton2RadioButton.Checked = False
        defaultButton3RadioButton.Checked = False

        titleTextBox.Focus()

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click

        Application.Exit()

    End Sub

    Private Sub iconsGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iconsGroupBox.Enter

    End Sub

    Private Sub informationRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationRadioButton.CheckedChanged

    End Sub

    Private Sub questionRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles questionRadioButton.CheckedChanged

    End Sub

    Private Sub warningRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles warningRadioButton.CheckedChanged

    End Sub

    Private Sub criticalRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles criticalRadioButton.CheckedChanged

    End Sub

    Private Sub buttonsGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonsGroupBox.Enter

    End Sub

    Private Sub okRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okRadioButton.CheckedChanged

    End Sub

    Private Sub okCancelRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okCancelRadioButton.CheckedChanged

    End Sub

    Private Sub yesNoRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesNoRadioButton.CheckedChanged

    End Sub

    Private Sub yesNoCancelRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesNoCancelRadioButton.CheckedChanged

    End Sub

    Private Sub retryCancelRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retryCancelRadioButton.CheckedChanged

    End Sub

    Private Sub abortRetryIgnoreRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abortRetryIgnoreRadioButton.CheckedChanged

    End Sub

    Private Sub defaultButtonGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultButtonGroupBox.Enter

    End Sub

    Private Sub defaultButton1RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultButton1RadioButton.CheckedChanged

    End Sub

    Private Sub defaultButton2RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultButton2RadioButton.CheckedChanged

    End Sub

    Private Sub defaultButton3RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultButton3RadioButton.CheckedChanged

    End Sub

End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.abortRetryIgnoreRadioButton = New System.Windows.Forms.RadioButton()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.messageInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.criticalRadioButton = New System.Windows.Forms.RadioButton()
        Me.buttonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.okRadioButton = New System.Windows.Forms.RadioButton()
        Me.okCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.yesNoRadioButton = New System.Windows.Forms.RadioButton()
        Me.yesNoCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.retryCancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.warningRadioButton = New System.Windows.Forms.RadioButton()
        Me.defaultButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.headingLabel = New System.Windows.Forms.Label()
        Me.questionRadioButton = New System.Windows.Forms.RadioButton()
        Me.informationRadioButton = New System.Windows.Forms.RadioButton()
        Me.iconsGroupBox = New System.Windows.Forms.GroupBox()
        Me.defaultButton1RadioButton = New System.Windows.Forms.RadioButton()
        Me.defaultButton2RadioButton = New System.Windows.Forms.RadioButton()
        Me.defaultButton3RadioButton = New System.Windows.Forms.RadioButton()
        Me.messageInfoGroupBox.SuspendLayout()
        Me.buttonsGroupBox.SuspendLayout()
        Me.defaultButtonGroupBox.SuspendLayout()
        Me.iconsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'abortRetryIgnoreRadioButton
        '
        Me.abortRetryIgnoreRadioButton.AutoSize = True
        Me.abortRetryIgnoreRadioButton.Location = New System.Drawing.Point(175, 72)
        Me.abortRetryIgnoreRadioButton.Name = "abortRetryIgnoreRadioButton"
        Me.abortRetryIgnoreRadioButton.Size = New System.Drawing.Size(105, 17)
        Me.abortRetryIgnoreRadioButton.TabIndex = 5
        Me.abortRetryIgnoreRadioButton.Text = "AbortRetryIgnore"
        Me.abortRetryIgnoreRadioButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(335, 69)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(128, 28)
        Me.displayButton.TabIndex = 30
        Me.displayButton.Text = "Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Location = New System.Drawing.Point(17, 45)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(101, 13)
        Me.authorLabel.TabIndex = 28
        Me.authorLabel.Text = "Author: Rex Alvarez"
        '
        'messageInfoGroupBox
        '
        Me.messageInfoGroupBox.Controls.Add(Me.titleLabel)
        Me.messageInfoGroupBox.Controls.Add(Me.titleTextBox)
        Me.messageInfoGroupBox.Controls.Add(Me.messageLabel)
        Me.messageInfoGroupBox.Controls.Add(Me.messageTextBox)
        Me.messageInfoGroupBox.Location = New System.Drawing.Point(17, 69)
        Me.messageInfoGroupBox.Name = "messageInfoGroupBox"
        Me.messageInfoGroupBox.Size = New System.Drawing.Size(294, 108)
        Me.messageInfoGroupBox.TabIndex = 29
        Me.messageInfoGroupBox.TabStop = False
        Me.messageInfoGroupBox.Text = "Message Info:"
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(44, 30)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(30, 13)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Title:"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(80, 27)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(197, 20)
        Me.titleTextBox.TabIndex = 1
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(16, 57)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(53, 13)
        Me.messageLabel.TabIndex = 2
        Me.messageLabel.Text = "Message:"
        '
        'messageTextBox
        '
        Me.messageTextBox.Location = New System.Drawing.Point(80, 54)
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(197, 20)
        Me.messageTextBox.TabIndex = 3
        '
        'criticalRadioButton
        '
        Me.criticalRadioButton.AutoSize = True
        Me.criticalRadioButton.Location = New System.Drawing.Point(116, 52)
        Me.criticalRadioButton.Name = "criticalRadioButton"
        Me.criticalRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.criticalRadioButton.TabIndex = 3
        Me.criticalRadioButton.Text = "Critical"
        Me.criticalRadioButton.UseVisualStyleBackColor = True
        '
        'buttonsGroupBox
        '
        Me.buttonsGroupBox.Controls.Add(Me.okRadioButton)
        Me.buttonsGroupBox.Controls.Add(Me.okCancelRadioButton)
        Me.buttonsGroupBox.Controls.Add(Me.yesNoRadioButton)
        Me.buttonsGroupBox.Controls.Add(Me.yesNoCancelRadioButton)
        Me.buttonsGroupBox.Controls.Add(Me.retryCancelRadioButton)
        Me.buttonsGroupBox.Controls.Add(Me.abortRetryIgnoreRadioButton)
        Me.buttonsGroupBox.Location = New System.Drawing.Point(254, 189)
        Me.buttonsGroupBox.Name = "buttonsGroupBox"
        Me.buttonsGroupBox.Size = New System.Drawing.Size(288, 108)
        Me.buttonsGroupBox.TabIndex = 34
        Me.buttonsGroupBox.TabStop = False
        Me.buttonsGroupBox.Text = "Buttons"
        '
        'okRadioButton
        '
        Me.okRadioButton.AutoSize = True
        Me.okRadioButton.Checked = True
        Me.okRadioButton.Location = New System.Drawing.Point(18, 24)
        Me.okRadioButton.Name = "okRadioButton"
        Me.okRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.okRadioButton.TabIndex = 0
        Me.okRadioButton.TabStop = True
        Me.okRadioButton.Text = "Ok"
        Me.okRadioButton.UseVisualStyleBackColor = True
        '
        'okCancelRadioButton
        '
        Me.okCancelRadioButton.AutoSize = True
        Me.okCancelRadioButton.Location = New System.Drawing.Point(18, 48)
        Me.okCancelRadioButton.Name = "okCancelRadioButton"
        Me.okCancelRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.okCancelRadioButton.TabIndex = 1
        Me.okCancelRadioButton.Text = "Ok/Cancel"
        Me.okCancelRadioButton.UseVisualStyleBackColor = True
        '
        'yesNoRadioButton
        '
        Me.yesNoRadioButton.AutoSize = True
        Me.yesNoRadioButton.Location = New System.Drawing.Point(18, 72)
        Me.yesNoRadioButton.Name = "yesNoRadioButton"
        Me.yesNoRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.yesNoRadioButton.TabIndex = 2
        Me.yesNoRadioButton.Text = "Yes/No"
        Me.yesNoRadioButton.UseVisualStyleBackColor = True
        '
        'yesNoCancelRadioButton
        '
        Me.yesNoCancelRadioButton.AutoSize = True
        Me.yesNoCancelRadioButton.Location = New System.Drawing.Point(175, 24)
        Me.yesNoCancelRadioButton.Name = "yesNoCancelRadioButton"
        Me.yesNoCancelRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.yesNoCancelRadioButton.TabIndex = 3
        Me.yesNoCancelRadioButton.Text = "YesNoCancel"
        Me.yesNoCancelRadioButton.UseVisualStyleBackColor = True
        '
        'retryCancelRadioButton
        '
        Me.retryCancelRadioButton.AutoSize = True
        Me.retryCancelRadioButton.Location = New System.Drawing.Point(175, 48)
        Me.retryCancelRadioButton.Name = "retryCancelRadioButton"
        Me.retryCancelRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.retryCancelRadioButton.TabIndex = 4
        Me.retryCancelRadioButton.Text = "RetryCancel"
        Me.retryCancelRadioButton.UseVisualStyleBackColor = True
        '
        'warningRadioButton
        '
        Me.warningRadioButton.AutoSize = True
        Me.warningRadioButton.Location = New System.Drawing.Point(116, 26)
        Me.warningRadioButton.Name = "warningRadioButton"
        Me.warningRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.warningRadioButton.TabIndex = 1
        Me.warningRadioButton.Text = "Warning"
        Me.warningRadioButton.UseVisualStyleBackColor = True
        '
        'defaultButtonGroupBox
        '
        Me.defaultButtonGroupBox.Controls.Add(Me.defaultButton1RadioButton)
        Me.defaultButtonGroupBox.Controls.Add(Me.defaultButton2RadioButton)
        Me.defaultButtonGroupBox.Controls.Add(Me.defaultButton3RadioButton)
        Me.defaultButtonGroupBox.Location = New System.Drawing.Point(17, 307)
        Me.defaultButtonGroupBox.Name = "defaultButtonGroupBox"
        Me.defaultButtonGroupBox.Size = New System.Drawing.Size(525, 84)
        Me.defaultButtonGroupBox.TabIndex = 35
        Me.defaultButtonGroupBox.TabStop = False
        Me.defaultButtonGroupBox.Text = "DefaultButton"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(335, 103)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(128, 28)
        Me.clearButton.TabIndex = 31
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(335, 137)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(128, 28)
        Me.exitButton.TabIndex = 32
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'headingLabel
        '
        Me.headingLabel.AutoSize = True
        Me.headingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headingLabel.Location = New System.Drawing.Point(17, 19)
        Me.headingLabel.Name = "headingLabel"
        Me.headingLabel.Size = New System.Drawing.Size(103, 16)
        Me.headingLabel.TabIndex = 27
        Me.headingLabel.Text = "The Message"
        '
        'questionRadioButton
        '
        Me.questionRadioButton.AutoSize = True
        Me.questionRadioButton.Location = New System.Drawing.Point(16, 52)
        Me.questionRadioButton.Name = "questionRadioButton"
        Me.questionRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.questionRadioButton.TabIndex = 2
        Me.questionRadioButton.Text = "Question"
        Me.questionRadioButton.UseVisualStyleBackColor = True
        '
        'informationRadioButton
        '
        Me.informationRadioButton.AutoSize = True
        Me.informationRadioButton.Checked = True
        Me.informationRadioButton.Location = New System.Drawing.Point(16, 26)
        Me.informationRadioButton.Name = "informationRadioButton"
        Me.informationRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.informationRadioButton.TabIndex = 0
        Me.informationRadioButton.TabStop = True
        Me.informationRadioButton.Text = "Information"
        Me.informationRadioButton.UseVisualStyleBackColor = True
        '
        'iconsGroupBox
        '
        Me.iconsGroupBox.Controls.Add(Me.informationRadioButton)
        Me.iconsGroupBox.Controls.Add(Me.warningRadioButton)
        Me.iconsGroupBox.Controls.Add(Me.questionRadioButton)
        Me.iconsGroupBox.Controls.Add(Me.criticalRadioButton)
        Me.iconsGroupBox.Location = New System.Drawing.Point(17, 189)
        Me.iconsGroupBox.Name = "iconsGroupBox"
        Me.iconsGroupBox.Size = New System.Drawing.Size(225, 108)
        Me.iconsGroupBox.TabIndex = 33
        Me.iconsGroupBox.TabStop = False
        Me.iconsGroupBox.Text = "Icons"
        '
        'defaultButton1RadioButton
        '
        Me.defaultButton1RadioButton.AutoSize = True
        Me.defaultButton1RadioButton.Checked = True
        Me.defaultButton1RadioButton.Location = New System.Drawing.Point(94, 34)
        Me.defaultButton1RadioButton.Name = "defaultButton1RadioButton"
        Me.defaultButton1RadioButton.Size = New System.Drawing.Size(96, 17)
        Me.defaultButton1RadioButton.TabIndex = 3
        Me.defaultButton1RadioButton.TabStop = True
        Me.defaultButton1RadioButton.Text = "DefaultButton1"
        Me.defaultButton1RadioButton.UseVisualStyleBackColor = True
        '
        'defaultButton2RadioButton
        '
        Me.defaultButton2RadioButton.AutoSize = True
        Me.defaultButton2RadioButton.Location = New System.Drawing.Point(217, 34)
        Me.defaultButton2RadioButton.Name = "defaultButton2RadioButton"
        Me.defaultButton2RadioButton.Size = New System.Drawing.Size(96, 17)
        Me.defaultButton2RadioButton.TabIndex = 4
        Me.defaultButton2RadioButton.Text = "DefaultButton2"
        Me.defaultButton2RadioButton.UseVisualStyleBackColor = True
        '
        'defaultButton3RadioButton
        '
        Me.defaultButton3RadioButton.AutoSize = True
        Me.defaultButton3RadioButton.Location = New System.Drawing.Point(334, 34)
        Me.defaultButton3RadioButton.Name = "defaultButton3RadioButton"
        Me.defaultButton3RadioButton.Size = New System.Drawing.Size(96, 17)
        Me.defaultButton3RadioButton.TabIndex = 5
        Me.defaultButton3RadioButton.Text = "DefaultButton3"
        Me.defaultButton3RadioButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 411)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.messageInfoGroupBox)
        Me.Controls.Add(Me.buttonsGroupBox)
        Me.Controls.Add(Me.defaultButtonGroupBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.headingLabel)
        Me.Controls.Add(Me.iconsGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.messageInfoGroupBox.ResumeLayout(False)
        Me.messageInfoGroupBox.PerformLayout()
        Me.buttonsGroupBox.ResumeLayout(False)
        Me.buttonsGroupBox.PerformLayout()
        Me.defaultButtonGroupBox.ResumeLayout(False)
        Me.defaultButtonGroupBox.PerformLayout()
        Me.iconsGroupBox.ResumeLayout(False)
        Me.iconsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents abortRetryIgnoreRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents authorLabel As System.Windows.Forms.Label
    Friend WithEvents messageInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents titleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents messageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents criticalRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents buttonsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents okRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents okCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents yesNoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents yesNoCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents retryCancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents warningRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents defaultButtonGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultButton1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents defaultButton2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents defaultButton3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents headingLabel As System.Windows.Forms.Label
    Friend WithEvents questionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents informationRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents iconsGroupBox As System.Windows.Forms.GroupBox

End Class
```

### 3. Sample Run
![Figure 8.1 — Sample Run of 'The Message' Showing Custom MessageBox & DialogResult Feedback](docs/images/act8_run.png)
*Figure 8.1 — Sample Run of 'The Message' Showing Custom MessageBox & DialogResult Feedback*

**Sample Run Walkthrough:**
- User enters Title = 'Confirm Submission' and Message = 'Save changes to record?', selects Icon = Question, Buttons = Yes/No, and DefaultButton = DefaultButton1.
- Clicking Display validates that all fields and radio groups have selections, then calls MessageBox.Show(messageDescription, messageTitle, buttonType, iconType, defaultButton).
- When the user clicks 'Yes' on the popup dialog, the Select Case result block captures DialogResult.Yes and displays a second confirmation MessageBox: 'Yes has been clicked!'.

### 4. Form Design
![Figure 8.2 — Visual Studio Form Design of 'The Message' (558 × 411 px)](docs/images/act8_design.png)
*Figure 8.2 — Visual Studio Form Design of 'The Message' (558 × 411 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `headingLabel, authorLabel` | Label | `"The Message", "Author: Rex Alvarez"` | Header and author identification labels |
| `messageInfoGroupBox` | GroupBox | `"Message Info:"` | Groups titleTextBox and messageTextBox (294 × 108) |
| `iconsGroupBox` | GroupBox | `"Icons"` | Groups Information, Warning, Question, and Critical RadioButtons |
| `buttonsGroupBox` | GroupBox | `"Buttons"` | Groups Ok, Ok/Cancel, Yes/No, YesNoCancel, RetryCancel, AbortRetryIgnore RadioButtons |
| `defaultButtonGroupBox` | GroupBox | `"DefaultButton"` | Groups DefaultButton1, DefaultButton2, and DefaultButton3 RadioButtons |
| `displayButton` | Button | `"Display"` | Validates selections, displays custom MessageBox, and reports DialogResult |
| `clearButton` | Button | `"Clear"` | Clears textboxes and unchecks all RadioButtons across all groups |
| `exitButton` | Button | `"Exit"` | Exits the application via Application.Exit() |

### 5. Brief Description
Activity 8 (Act8_SW20260805 — 'The Message') demonstrates grouping mutually exclusive RadioButton controls inside GroupBox containers and dynamically configuring the .NET MessageBox.Show() dialog. The program validates non-empty title and message inputs using String.IsNullOrWhiteSpace(), maps the selected RadioButtons to MessageBoxIcon, MessageBoxButtons, and MessageBoxDefaultButton enumerations using If...ElseIf chains, and evaluates the returned DialogResult in a Select Case block to inform the user which dialog button was clicked.

---

## Activity 9: ListView File Explorer — Question 6 (SW202609301600)

### 1. Activity Title
- **Activity Title:** Activity 9: ListView File Explorer — Question 6 (SW202609301600)
- **Project Folder / Solution:** `SW202609301600` (`SW202609301600.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** September 30, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `ListViewSample.vb`
```vbnet
Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class ListViewSample
    Private currentFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    Public Sub New()
        InitializeComponent()
        AddHandler menuList.Click, AddressOf OpenListForm
      
        AddHandler menuExit.Click, AddressOf ExitApplication
    End Sub

    Private Sub OpenListForm(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New ListViewSample()
            form.ShowDialog()
        End Using
    End Sub


    Private Sub ExitApplication(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadFolder(currentFolder)
    End Sub

    Private Sub LoadFolder(ByVal folder As String)
        If Not Directory.Exists(folder) Then Return
        currentFolder = folder
        txtPath.Text = folder
        lv.Items.Clear()
        Try
            For Each directoryName As String In Directory.GetDirectories(folder)
                Dim item As New ListViewItem(Path.GetFileName(directoryName))
                item.SubItems.Add("Folder")
                item.SubItems.Add(Directory.GetLastWriteTime(directoryName).ToString())
                item.Tag = directoryName
                lv.Items.Add(item)
            Next
            For Each fileName As String In Directory.GetFiles(folder)
                Dim info As New FileInfo(fileName)
                Dim item As New ListViewItem(info.Name)
                item.SubItems.Add(info.Extension)
                item.SubItems.Add(info.Length.ToString() & " bytes")
                item.Tag = fileName
                lv.Items.Add(item)
            Next
            lbl.Text = lv.Items.Count.ToString() & " item(s)"
        Catch ex As Exception
            lbl.Text = ex.Message
        End Try
    End Sub

    Private Sub browse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browse.Click
        Using dialog As New FolderBrowserDialog()
            dialog.SelectedPath = currentFolder
            dialog.Description = "Select a folder"
            If dialog.ShowDialog() = DialogResult.OK Then
                LoadFolder(dialog.SelectedPath)
            End If
        End Using
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        LoadFolder(currentFolder)
    End Sub

    Private Sub details_Click(ByVal sender As Object, ByVal e As EventArgs) Handles details.Click
        lv.View = View.Details
    End Sub

    Private Sub list_Click(ByVal sender As Object, ByVal e As EventArgs) Handles list.Click
        lv.View = View.List
    End Sub

    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lv.DoubleClick
        If lv.SelectedItems.Count = 0 Then Return
        Dim selectedPath As String = CStr(lv.SelectedItems(0).Tag)
        If Directory.Exists(selectedPath) Then
            LoadFolder(selectedPath)
        ElseIf File.Exists(selectedPath) Then
            Process.Start(selectedPath)
        End If
    End Sub

    Private Sub lv_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles lv.ColumnClick
        lv.ListViewItemSorter = New ListViewComparer(e.Column)
        lv.Sort()
    End Sub

    Private Class ListViewComparer
        Implements System.Collections.IComparer
        Private ReadOnly columnNumber As Integer

        Public Sub New(ByVal column As Integer)
            columnNumber = column
        End Sub

        Public Function Compare(ByVal first As Object, ByVal second As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim a As ListViewItem = DirectCast(first, ListViewItem)
            Dim b As ListViewItem = DirectCast(second, ListViewItem)
            Return String.Compare(a.SubItems(columnNumber).Text, b.SubItems(columnNumber).Text, True)
        End Function
    End Class
End Class
```

#### `ListViewSample.Designer.vb`
```vbnet
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents txtPath As TextBox
 Friend WithEvents browse As Button
 Friend WithEvents btnRefresh As Button
 Friend WithEvents details As Button
 Friend WithEvents list As Button
 Friend WithEvents lv As ListView
 Friend WithEvents lbl As Label
 Friend WithEvents menuStrip1 As MenuStrip
 Friend WithEvents menuForms As ToolStripMenuItem
 Friend WithEvents menuList As ToolStripMenuItem
 Friend WithEvents menuTree As ToolStripMenuItem
 Friend WithEvents menuOpen As ToolStripMenuItem
 Friend WithEvents menuCombined As ToolStripMenuItem
 Friend WithEvents menuExit As ToolStripMenuItem
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.txtPath=New TextBox() : Me.browse=New Button() : Me.btnRefresh=New Button() : Me.details=New Button() : Me.list=New Button() : Me.lv=New ListView() : Me.lbl=New Label()
  Me.menuStrip1=New MenuStrip() : Me.menuForms=New ToolStripMenuItem() : Me.menuList=New ToolStripMenuItem() : Me.menuTree=New ToolStripMenuItem() : Me.menuOpen=New ToolStripMenuItem() : Me.menuCombined=New ToolStripMenuItem() : Me.menuExit=New ToolStripMenuItem()
  Me.SuspendLayout()
  Me.menuForms.Text="Forms"
  Me.menuList.Text="ListView File Explorer"
  Me.menuTree.Text="TreeView File Explorer"
  Me.menuOpen.Text="OpenFileDialog File Explorer"
  Me.menuCombined.Text="Combined File Explorer"
  Me.menuExit.Text="Exit"
  Me.menuForms.DropDownItems.AddRange(New ToolStripItem() {Me.menuList,Me.menuTree,Me.menuOpen,Me.menuCombined,Me.menuExit})
  Me.menuStrip1.Items.Add(Me.menuForms)
  Me.menuStrip1.Dock=DockStyle.Top
  Me.txtPath.SetBounds(10,38,560,25) : Me.browse.SetBounds(580,36,85,28) : Me.browse.Text="Browse..." : Me.btnRefresh.SetBounds(675,36,75,28) : Me.btnRefresh.Text="Refresh" : Me.details.SetBounds(760,36,70,28) : Me.details.Text="Details" : Me.list.SetBounds(840,36,55,28) : Me.list.Text="List" : Me.lv.SetBounds(10,73,885,460) : Me.lv.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.lv.View=View.Details : Me.lv.FullRowSelect=True : Me.lv.GridLines=True : Me.lv.Columns.Add("Name",300) : Me.lv.Columns.Add("Type",150) : Me.lv.Columns.Add("Modified/Size",200) : Me.lbl.SetBounds(10,543,800,25) : Me.Controls.AddRange(New Control() {Me.txtPath,Me.browse,Me.btnRefresh,Me.details,Me.list,Me.lv,Me.lbl,Me.menuStrip1})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 6 - ListView File Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.Controls.Add(Me.lv)
  Me.ResumeLayout(False)
 End Sub
End Class
```

### 3. Sample Run
![Figure 9.1 — Sample Run of Question 6 ListView File Explorer (SW202609301600)](docs/images/act9_run.png)
*Figure 9.1 — Sample Run of Question 6 ListView File Explorer (SW202609301600)*

**Sample Run Walkthrough:**
- On load, LoadFolder() populates the ListView (lv) with all subdirectories and files inside the user's MyDocuments folder.
- Clicking 'Browse...' opens a FolderBrowserDialog allowing the user to switch to any directory; 'Details' and 'List' toggle lv.View between View.Details and View.List.
- Clicking any column header ('Name', 'Type', 'Modified/Size') sorts the ListView using the custom ListViewComparer (IComparer) class.
- Double-clicking a folder navigates into it; double-clicking a file opens it via Process.Start().

### 4. Form Design
![Figure 9.2 — Visual Studio Form Design of ListViewSample (900 × 560 px)](docs/images/act9_design.png)
*Figure 9.2 — Visual Studio Form Design of ListViewSample (900 × 560 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `menuStrip1` | MenuStrip | `"Forms" Menu` | Top menu bar with ListView, TreeView, OpenFileDialog, Combined, and Exit items |
| `txtPath` | TextBox | `(Current Folder Path)` | Displays the active directory path at (10, 38), width 560 |
| `browse` | Button | `"Browse..."` | Opens FolderBrowserDialog to select a directory |
| `btnRefresh` | Button | `"Refresh"` | Reloads the current folder contents into the ListView |
| `details, list` | Button | `"Details", "List"` | Switch ListView display mode between View.Details and View.List |
| `lv` | ListView | `Columns: Name, Type, Modified/Size` | Main file/folder table (885 × 460) with FullRowSelect and GridLines |
| `lbl` | Label | `(Item Count Status)` | Displays total number of items loaded or error messages at (10, 543) |

### 5. Brief Description
Activity 9 (Seatwork SW202609301600 — Question 6) implements a functional File Explorer using the Windows Forms ListView control and System.IO classes (Directory, FileInfo, Path). It loads folders (with last-modified timestamps) and files (with extension and byte size) as ListViewItem and SubItems, supports interactive column sorting via a custom IComparer implementation (ListViewComparer), and provides folder browsing via FolderBrowserDialog and file launching via Process.Start().

---

## Activity 10: Panel and SplitContainer Demonstration (SW20261002 / PanelSplitPanelDemo)

### 1. Activity Title
- **Activity Title:** Activity 10: Panel and SplitContainer Demonstration (SW20261002 / PanelSplitPanelDemo)
- **Project Folder / Solution:** `SW20261002` (`PanelSplitPanelDemo.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** October 2, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Option Strict On
Option Explicit On

Public Class Form1
    Private colorChanged As Boolean = False

    Private Sub menuSplitPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuSplitPanel.Click
        Dim nextForm As New Form2()
        nextForm.Owner = Me
        AddHandler nextForm.FormClosed, AddressOf SplitFormClosed
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub SplitFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If Not Me.IsDisposed Then Me.Show()
    End Sub

    Private Sub menuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub btnVisible_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVisible.Click
        pnlGroup.Visible = Not pnlGroup.Visible
        btnVisible.Text = If(pnlGroup.Visible, "Hide Group", "Show Group")
        lblStatus.Text = "Visible = " & pnlGroup.Visible.ToString()
    End Sub

    Private Sub btnBackColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBackColor.Click
        colorChanged = Not colorChanged
        pnlNested.BackColor = If(colorChanged, Color.LightSkyBlue, Color.PaleGreen)
        lblStatus.Text = "BackColor changed on the nested panel."
    End Sub

    Private Sub btnBorder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBorder.Click
        If pnlWorkspace.BorderStyle = BorderStyle.Fixed3D Then
            pnlWorkspace.BorderStyle = BorderStyle.FixedSingle
        Else
            pnlWorkspace.BorderStyle = BorderStyle.Fixed3D
        End If
        lblStatus.Text = "BorderStyle = " & pnlWorkspace.BorderStyle.ToString()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        pnlWorkspace.Refresh()
        lblStatus.Text = "Refresh() repainted the workspace panel."
    End Sub

    Private Sub btnInvalidate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInvalidate.Click
        pnlWorkspace.Invalidate(True)
        lblStatus.Text = "Invalidate() requested a redraw of the panel and child controls."
    End Sub

    Private Sub btnFocus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFocus.Click
        Dim result As Boolean = pnlWorkspace.Focus()
        lblStatus.Text = "Focus() result = " & result.ToString()
    End Sub

    Private Sub btnContains_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContains.Click
        Dim result As Boolean = pnlWorkspace.Contains(pnlGroup)
        lblStatus.Text = "Contains(pnlGroup) = " & result.ToString()
    End Sub

    Private Sub btnDispose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDispose.Click
        Dim sample As New Panel()
        sample.Controls.Add(New Label())
        sample.Dispose()
        lblStatus.Text = "Dispose() released a temporary panel and its controls."
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        lblStatus.Text = txtName.Text & " - " & txtCourse.Text & " saved from grouped controls."
    End Sub
End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents menuDemo As ToolStripMenuItem
    Friend WithEvents menuPanel As ToolStripMenuItem
    Friend WithEvents menuSplitPanel As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlTools As Panel
    Friend WithEvents btnVisible As Button
    Friend WithEvents btnBackColor As Button
    Friend WithEvents btnBorder As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnInvalidate As Button
    Friend WithEvents btnFocus As Button
    Friend WithEvents btnContains As Button
    Friend WithEvents btnDispose As Button
    Friend WithEvents pnlWorkspace As Panel
    Friend WithEvents pnlGroup As Panel
    Friend WithEvents lblGroup As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlNested As Panel
    Friend WithEvents lblNested As Label
    Friend WithEvents pnlScrollable As Panel
    Friend WithEvents lblScrollable As Label
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatus As Label

    Private Sub InitializeComponent()
        Me.menuMain = New MenuStrip()
        Me.menuDemo = New ToolStripMenuItem()
        Me.menuPanel = New ToolStripMenuItem()
        Me.menuSplitPanel = New ToolStripMenuItem()
        Me.menuExit = New ToolStripMenuItem()
        Me.pnlHeader = New Panel()
        Me.pnlTools = New Panel()
        Me.btnVisible = New Button()
        Me.btnBackColor = New Button()
        Me.btnBorder = New Button()
        Me.btnRefresh = New Button()
        Me.btnInvalidate = New Button()
        Me.btnFocus = New Button()
        Me.btnContains = New Button()
        Me.btnDispose = New Button()
        Me.pnlWorkspace = New Panel()
        Me.pnlGroup = New Panel()
        Me.lblGroup = New Label()
        Me.txtName = New TextBox()
        Me.txtCourse = New TextBox()
        Me.btnSave = New Button()
        Me.pnlNested = New Panel()
        Me.lblNested = New Label()
        Me.pnlScrollable = New Panel()
        Me.lblScrollable = New Label()
        Me.pnlStatus = New Panel()
        Me.lblStatus = New Label()
        Me.menuMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        Me.pnlWorkspace.SuspendLayout()
        Me.pnlGroup.SuspendLayout()
        Me.pnlNested.SuspendLayout()
        Me.pnlScrollable.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        Me.menuMain.Items.AddRange(New ToolStripItem() {Me.menuDemo})
        Me.menuMain.Dock = DockStyle.Top
        Me.menuDemo.DropDownItems.AddRange(New ToolStripItem() {Me.menuPanel, Me.menuSplitPanel, New ToolStripSeparator(), Me.menuExit})
        Me.menuDemo.Text = "Demonstration"
        Me.menuPanel.Checked = True
        Me.menuPanel.Text = "Panel Form"
        Me.menuSplitPanel.Text = "SplitPanel Form"
        Me.menuExit.Text = "Exit"
        Me.pnlHeader.BackColor = Color.SteelBlue
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Size = New Size(920, 10)
        Me.pnlTools.BackColor = Color.WhiteSmoke
        Me.pnlTools.BorderStyle = BorderStyle.FixedSingle
        Me.pnlTools.Controls.Add(Me.btnVisible)
        Me.pnlTools.Controls.Add(Me.btnBackColor)
        Me.pnlTools.Controls.Add(Me.btnBorder)
        Me.pnlTools.Controls.Add(Me.btnRefresh)
        Me.pnlTools.Controls.Add(Me.btnInvalidate)
        Me.pnlTools.Controls.Add(Me.btnFocus)
        Me.pnlTools.Controls.Add(Me.btnContains)
        Me.pnlTools.Controls.Add(Me.btnDispose)
        Me.pnlTools.Dock = DockStyle.Top
        Me.pnlTools.Size = New Size(920, 48)
        Me.btnVisible.Location = New Point(8, 9)
        Me.btnVisible.Size = New Size(92, 28)
        Me.btnVisible.Text = "Hide Group"
        Me.btnBackColor.Location = New Point(105, 9)
        Me.btnBackColor.Size = New Size(88, 28)
        Me.btnBackColor.Text = "BackColor"
        Me.btnBorder.Location = New Point(198, 9)
        Me.btnBorder.Size = New Size(82, 28)
        Me.btnBorder.Text = "BorderStyle"
        Me.btnRefresh.Location = New Point(285, 9)
        Me.btnRefresh.Size = New Size(68, 28)
        Me.btnRefresh.Text = "Refresh"
        Me.btnInvalidate.Location = New Point(358, 9)
        Me.btnInvalidate.Size = New Size(72, 28)
        Me.btnInvalidate.Text = "Invalidate"
        Me.btnFocus.Location = New Point(435, 9)
        Me.btnFocus.Size = New Size(58, 28)
        Me.btnFocus.Text = "Focus"
        Me.btnContains.Location = New Point(498, 9)
        Me.btnContains.Size = New Size(70, 28)
        Me.btnContains.Text = "Contains"
        Me.btnDispose.Location = New Point(573, 9)
        Me.btnDispose.Size = New Size(88, 28)
        Me.btnDispose.Text = "Dispose Test"
        Me.pnlWorkspace.AutoScroll = True
        Me.pnlWorkspace.BackColor = Color.White
        Me.pnlWorkspace.BorderStyle = BorderStyle.Fixed3D
        Me.pnlWorkspace.Controls.Add(Me.pnlGroup)
        Me.pnlWorkspace.Controls.Add(Me.pnlNested)
        Me.pnlWorkspace.Controls.Add(Me.pnlScrollable)
        Me.pnlWorkspace.Dock = DockStyle.Fill
        Me.pnlWorkspace.TabStop = True
        Me.pnlGroup.BackColor = Color.AliceBlue
        Me.pnlGroup.BorderStyle = BorderStyle.FixedSingle
        Me.pnlGroup.Controls.Add(Me.lblGroup)
        Me.pnlGroup.Controls.Add(Me.txtName)
        Me.pnlGroup.Controls.Add(Me.txtCourse)
        Me.pnlGroup.Controls.Add(Me.btnSave)
        Me.pnlGroup.Location = New Point(25, 25)
        Me.pnlGroup.Size = New Size(270, 210)
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.lblGroup.Location = New Point(14, 14)
        Me.lblGroup.Text = "Grouped Controls"
        Me.txtName.Location = New Point(18, 55)
        Me.txtName.Size = New Size(230, 20)
        Me.txtName.Text = "Student name"
        Me.txtCourse.Location = New Point(18, 90)
        Me.txtCourse.Size = New Size(230, 20)
        Me.txtCourse.Text = "Course"
        Me.btnSave.Location = New Point(18, 130)
        Me.btnSave.Size = New Size(90, 30)
        Me.btnSave.Text = "Save"
        Me.pnlNested.BackColor = Color.PaleGreen
        Me.pnlNested.BorderStyle = BorderStyle.FixedSingle
        Me.pnlNested.Controls.Add(Me.lblNested)
        Me.pnlNested.Location = New Point(320, 25)
        Me.pnlNested.Size = New Size(250, 210)
        Me.pnlNested.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.lblNested.Dock = DockStyle.Fill
        Me.lblNested.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.lblNested.Text = "Nested Panel" & vbCrLf & vbCrLf & "Dock and Anchor keep this area aligned while the form is resized."
        Me.lblNested.TextAlign = ContentAlignment.MiddleCenter
        Me.pnlScrollable.AutoScroll = True
        Me.pnlScrollable.BackColor = Color.Moccasin
        Me.pnlScrollable.BorderStyle = BorderStyle.FixedSingle
        Me.pnlScrollable.Controls.Add(Me.lblScrollable)
        Me.pnlScrollable.Location = New Point(595, 25)
        Me.pnlScrollable.Size = New Size(250, 210)
        Me.lblScrollable.AutoSize = False
        Me.lblScrollable.Location = New Point(15, 15)
        Me.lblScrollable.Size = New Size(430, 360)
        Me.lblScrollable.Text = "AutoScroll Panel" & vbCrLf & vbCrLf & "This content is intentionally larger than its panel." & vbCrLf & vbCrLf & "Use the horizontal and vertical scrollbars." & vbCrLf & vbCrLf & "Panel properties:" & vbCrLf & "BackColor" & vbCrLf & "BorderStyle" & vbCrLf & "AutoScroll" & vbCrLf & "Dock" & vbCrLf & "Anchor" & vbCrLf & "Visible"
        Me.pnlStatus.BackColor = SystemColors.ControlLight
        Me.pnlStatus.BorderStyle = BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = DockStyle.Bottom
        Me.pnlStatus.Size = New Size(920, 31)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New Point(10, 8)
        Me.lblStatus.Text = "Use the menu to open the SplitPanel form."
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(920, 560)
        Me.Controls.Add(Me.pnlWorkspace)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlTools)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.MinimumSize = New Size(760, 480)
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Activity 3 - Panel Form"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.pnlWorkspace.ResumeLayout(False)
        Me.pnlGroup.ResumeLayout(False)
        Me.pnlGroup.PerformLayout()
        Me.pnlNested.ResumeLayout(False)
        Me.pnlScrollable.ResumeLayout(False)
        Me.pnlScrollable.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
```

#### `Form2.vb`
```vbnet
Option Strict On
Option Explicit On

Public Class Form2
    Private locked As Boolean = False

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SetSafeDistance(splitMain, 210)
        SetSafeDistance(splitInner, CInt(splitInner.Height * 0.62))
        AddRecord("Student Records", "ListView in Panel1")
        AddRecord("Course Information", "Independent content")
        AddRecord("Enrollment Report", "Resizable section")
        AddRecord("System Settings", "Navigation example")
    End Sub

    Private Sub AddRecord(ByVal title As String, ByVal category As String)
        Dim item As New ListViewItem(title)
        item.SubItems.Add(category)
        lvRecords.Items.Add(item)
    End Sub

    Private Sub lvRecords_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvRecords.SelectedIndexChanged
        If lvRecords.SelectedItems.Count = 0 Then Return
        txtDetails.Text = "Selected record: " & lvRecords.SelectedItems(0).Text & vbCrLf & vbCrLf & _
                          "This information is displayed independently inside Panel2." & vbCrLf & vbCrLf & _
                          "Both panels can be resized by dragging the splitter."
    End Sub

    Private Sub menuPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuPanel.Click
        If Me.Owner IsNot Nothing Then
            Me.Owner.Show()
        Else
            Dim panelForm As New Form1()
            panelForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub menuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCollapse1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollapse1.Click
        CollapsePanel(splitMain, 1)
        lblStatus.Text = "CollapsePanel() collapsed Panel1 of the main SplitContainer."
    End Sub

    Private Sub btnCollapse2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollapse2.Click
        CollapsePanel(splitInner, 2)
        lblStatus.Text = "CollapsePanel() collapsed Panel2 of the inner SplitContainer."
    End Sub

    Private Sub btnExpand_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExpand.Click
        ExpandPanel(splitMain)
        ExpandPanel(splitInner)
        SetSafeDistance(splitMain, 210)
        If splitInner.Orientation = Orientation.Horizontal Then
            SetSafeDistance(splitInner, CInt(splitInner.Height * 0.62))
        Else
            SetSafeDistance(splitInner, CInt(splitInner.Width * 0.62))
        End If
        lblStatus.Text = "ExpandPanel() displayed Panel1 and Panel2."
    End Sub

    Private Sub btnOrientation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOrientation.Click
        Try
            splitInner.Panel1MinSize = 60
            splitInner.Panel2MinSize = 60
            SetSafeDistance(splitInner, 150)
            If splitInner.Orientation = Orientation.Horizontal Then
                splitInner.Orientation = Orientation.Vertical
                splitInner.Panel1MinSize = 180
                splitInner.Panel2MinSize = 160
                SetSafeDistance(splitInner, CInt(splitInner.Width * 0.62))
                lblStatus.Text = "Orientation = Vertical, panels are left and right."
            Else
                splitInner.Orientation = Orientation.Horizontal
                splitInner.Panel1MinSize = 120
                splitInner.Panel2MinSize = 100
                SetSafeDistance(splitInner, CInt(splitInner.Height * 0.62))
                lblStatus.Text = "Orientation = Horizontal, panels are top and bottom."
            End If
        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnLock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLock.Click
        locked = Not locked
        splitMain.IsSplitterFixed = locked
        splitInner.IsSplitterFixed = locked
        btnLock.Text = If(locked, "Unlock Splitters", "Lock Splitters")
        lblStatus.Text = "IsSplitterFixed = " & locked.ToString()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        splitMain.Refresh()
        splitInner.Refresh()
        lblStatus.Text = "Refresh() repainted both SplitContainer controls."
    End Sub

    Private Sub btnInvalidate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInvalidate.Click
        splitMain.Invalidate(True)
        splitInner.Invalidate(True)
        lblStatus.Text = "Invalidate() requested a redraw of every split panel."
    End Sub

    Private Sub btnDispose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDispose.Click
        Dim sample As New SplitContainer()
        sample.Panel1.Controls.Add(New Label())
        sample.Panel2.Controls.Add(New Button())
        sample.Dispose()
        lblStatus.Text = "Dispose() released a temporary SplitContainer and both panels."
    End Sub

    Private Sub CollapsePanel(ByVal target As SplitContainer, ByVal panelNumber As Integer)
        If panelNumber = 1 Then
            target.Panel1Collapsed = True
        Else
            target.Panel2Collapsed = True
        End If
    End Sub

    Private Sub ExpandPanel(ByVal target As SplitContainer)
        target.Panel1Collapsed = False
        target.Panel2Collapsed = False
    End Sub

    Private Sub SetSafeDistance(ByVal target As SplitContainer, ByVal requested As Integer)
        Dim available As Integer
        If target.Orientation = Orientation.Vertical Then
            available = target.ClientSize.Width
        Else
            available = target.ClientSize.Height
        End If
        Dim minimum As Integer = target.Panel1MinSize
        Dim maximum As Integer = available - target.Panel2MinSize - target.SplitterWidth
        If maximum >= minimum Then target.SplitterDistance = Math.Max(minimum, Math.Min(requested, maximum))
    End Sub

    Private Sub splitMain_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splitMain.SplitterMoved
        lblStatus.Text = "Main SplitterDistance = " & splitMain.SplitterDistance.ToString()
    End Sub

    Private Sub splitInner_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splitInner.SplitterMoved
        lblStatus.Text = "Inner SplitterDistance = " & splitInner.SplitterDistance.ToString()
    End Sub
End Class
```

#### `Form2.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents menuDemo As ToolStripMenuItem
    Friend WithEvents menuPanel As ToolStripMenuItem
    Friend WithEvents menuSplitPanel As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlTools As Panel
    Friend WithEvents btnCollapse1 As Button
    Friend WithEvents btnCollapse2 As Button
    Friend WithEvents btnExpand As Button
    Friend WithEvents btnOrientation As Button
    Friend WithEvents btnLock As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnInvalidate As Button
    Friend WithEvents btnDispose As Button
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents lblPanel1 As Label
    Friend WithEvents lstNavigation As ListBox
    Friend WithEvents splitInner As SplitContainer
    Friend WithEvents lblPanel2 As Label
    Friend WithEvents lvRecords As ListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colType As ColumnHeader
    Friend WithEvents lblDetails As Label
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatus As Label

    Private Sub InitializeComponent()
        Me.menuMain = New MenuStrip()
        Me.menuDemo = New ToolStripMenuItem()
        Me.menuPanel = New ToolStripMenuItem()
        Me.menuSplitPanel = New ToolStripMenuItem()
        Me.menuExit = New ToolStripMenuItem()
        Me.pnlHeader = New Panel()
        Me.pnlTools = New Panel()
        Me.btnCollapse1 = New Button()
        Me.btnCollapse2 = New Button()
        Me.btnExpand = New Button()
        Me.btnOrientation = New Button()
        Me.btnLock = New Button()
        Me.btnRefresh = New Button()
        Me.btnInvalidate = New Button()
        Me.btnDispose = New Button()
        Me.splitMain = New SplitContainer()
        Me.lblPanel1 = New Label()
        Me.lstNavigation = New ListBox()
        Me.splitInner = New SplitContainer()
        Me.lblPanel2 = New Label()
        Me.lvRecords = New ListView()
        Me.colName = New ColumnHeader()
        Me.colType = New ColumnHeader()
        Me.lblDetails = New Label()
        Me.txtDetails = New TextBox()
        Me.pnlStatus = New Panel()
        Me.lblStatus = New Label()
        Me.menuMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTools.SuspendLayout()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        CType(Me.splitInner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitInner.Panel1.SuspendLayout()
        Me.splitInner.Panel2.SuspendLayout()
        Me.splitInner.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        Me.menuMain.Items.AddRange(New ToolStripItem() {Me.menuDemo})
        Me.menuMain.Dock = DockStyle.Top
        Me.menuDemo.DropDownItems.AddRange(New ToolStripItem() {Me.menuPanel, Me.menuSplitPanel, New ToolStripSeparator(), Me.menuExit})
        Me.menuDemo.Text = "Demonstration"
        Me.menuPanel.Text = "Panel Form"
        Me.menuSplitPanel.Checked = True
        Me.menuSplitPanel.Text = "SplitPanel Form"
        Me.menuExit.Text = "Exit"
        Me.pnlHeader.BackColor = Color.SeaGreen
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Size = New Size(960, 10)
        Me.pnlTools.BackColor = Color.WhiteSmoke
        Me.pnlTools.BorderStyle = BorderStyle.FixedSingle
        Me.pnlTools.Controls.Add(Me.btnCollapse1)
        Me.pnlTools.Controls.Add(Me.btnCollapse2)
        Me.pnlTools.Controls.Add(Me.btnExpand)
        Me.pnlTools.Controls.Add(Me.btnOrientation)
        Me.pnlTools.Controls.Add(Me.btnLock)
        Me.pnlTools.Controls.Add(Me.btnRefresh)
        Me.pnlTools.Controls.Add(Me.btnInvalidate)
        Me.pnlTools.Controls.Add(Me.btnDispose)
        Me.pnlTools.Dock = DockStyle.Top
        Me.pnlTools.Size = New Size(960, 48)
        Me.btnCollapse1.Location = New Point(8, 9)
        Me.btnCollapse1.Size = New Size(100, 28)
        Me.btnCollapse1.Text = "Collapse Panel1"
        Me.btnCollapse2.Location = New Point(113, 9)
        Me.btnCollapse2.Size = New Size(100, 28)
        Me.btnCollapse2.Text = "Collapse Panel2"
        Me.btnExpand.Location = New Point(218, 9)
        Me.btnExpand.Size = New Size(82, 28)
        Me.btnExpand.Text = "Expand All"
        Me.btnOrientation.Location = New Point(305, 9)
        Me.btnOrientation.Size = New Size(105, 28)
        Me.btnOrientation.Text = "Change Direction"
        Me.btnLock.Location = New Point(415, 9)
        Me.btnLock.Size = New Size(88, 28)
        Me.btnLock.Text = "Lock Splitters"
        Me.btnRefresh.Location = New Point(508, 9)
        Me.btnRefresh.Size = New Size(68, 28)
        Me.btnRefresh.Text = "Refresh"
        Me.btnInvalidate.Location = New Point(581, 9)
        Me.btnInvalidate.Size = New Size(72, 28)
        Me.btnInvalidate.Text = "Invalidate"
        Me.btnDispose.Location = New Point(658, 9)
        Me.btnDispose.Size = New Size(88, 28)
        Me.btnDispose.Text = "Dispose Test"
        Me.splitMain.Dock = DockStyle.Fill
        Me.splitMain.FixedPanel = FixedPanel.Panel1
        Me.splitMain.IsSplitterFixed = False
        Me.splitMain.Orientation = Orientation.Vertical
        Me.splitMain.Size = New Size(960, 463)
        Me.splitMain.Panel1MinSize = 130
        Me.splitMain.Panel2MinSize = 350
        Me.splitMain.SplitterWidth = 7
        Me.splitMain.Panel1.BackColor = Color.Honeydew
        Me.splitMain.Panel1.Controls.Add(Me.lstNavigation)
        Me.splitMain.Panel1.Controls.Add(Me.lblPanel1)
        Me.splitMain.Panel2.Controls.Add(Me.splitInner)
        Me.lblPanel1.Dock = DockStyle.Top
        Me.lblPanel1.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblPanel1.Padding = New Padding(10)
        Me.lblPanel1.Size = New Size(210, 42)
        Me.lblPanel1.Text = "Panel1 - Navigation"
        Me.lstNavigation.Dock = DockStyle.Fill
        Me.lstNavigation.Items.AddRange(New Object() {"Dashboard", "Students", "Courses", "Reports", "Settings"})
        Me.splitInner.Dock = DockStyle.Fill
        Me.splitInner.FixedPanel = FixedPanel.None
        Me.splitInner.IsSplitterFixed = False
        Me.splitInner.Orientation = Orientation.Horizontal
        Me.splitInner.Size = New Size(743, 463)
        Me.splitInner.Panel1MinSize = 120
        Me.splitInner.Panel2MinSize = 100
        Me.splitInner.SplitterWidth = 7
        Me.splitInner.Panel1.BackColor = Color.White
        Me.splitInner.Panel1.Controls.Add(Me.lvRecords)
        Me.splitInner.Panel1.Controls.Add(Me.lblPanel2)
        Me.splitInner.Panel2.BackColor = Color.WhiteSmoke
        Me.splitInner.Panel2.Controls.Add(Me.txtDetails)
        Me.splitInner.Panel2.Controls.Add(Me.lblDetails)
        Me.lblPanel2.Dock = DockStyle.Top
        Me.lblPanel2.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblPanel2.Padding = New Padding(10)
        Me.lblPanel2.Size = New Size(743, 42)
        Me.lblPanel2.Text = "Panel1 of Inner SplitContainer - Records"
        Me.lvRecords.Columns.AddRange(New ColumnHeader() {Me.colName, Me.colType})
        Me.lvRecords.Dock = DockStyle.Fill
        Me.lvRecords.FullRowSelect = True
        Me.lvRecords.GridLines = True
        Me.lvRecords.View = View.Details
        Me.colName.Text = "Name"
        Me.colName.Width = 240
        Me.colType.Text = "Category"
        Me.colType.Width = 160
        Me.lblDetails.Dock = DockStyle.Top
        Me.lblDetails.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblDetails.Padding = New Padding(10)
        Me.lblDetails.Size = New Size(743, 42)
        Me.lblDetails.Text = "Panel2 of Inner SplitContainer - Details"
        Me.txtDetails.BackColor = Color.White
        Me.txtDetails.Dock = DockStyle.Fill
        Me.txtDetails.Multiline = True
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.ScrollBars = ScrollBars.Both
        Me.pnlStatus.BackColor = SystemColors.ControlLight
        Me.pnlStatus.BorderStyle = BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = DockStyle.Bottom
        Me.pnlStatus.Size = New Size(960, 31)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New Point(10, 8)
        Me.lblStatus.Text = "Drag the splitter bars to resize the panels."
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(960, 600)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlTools)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.menuMain)
        Me.MainMenuStrip = Me.menuMain
        Me.MinimumSize = New Size(760, 500)
        Me.Name = "Form2"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Activity 3 - SplitPanel Form"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlTools.ResumeLayout(False)
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        Me.splitInner.Panel1.ResumeLayout(False)
        Me.splitInner.Panel2.ResumeLayout(False)
        Me.splitInner.Panel2.PerformLayout()
        CType(Me.splitInner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitInner.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
```

### 3. Sample Run
![Figure 10.1 — Sample Run of Form1 (Panel Form) and Form2 (SplitPanel Form)](docs/images/act10_run.png)
*Figure 10.1 — Sample Run of Form1 (Panel Form) and Form2 (SplitPanel Form)*

**Sample Run Walkthrough:**
- Form1 (Activity 3 - Panel Form): Demonstrates toggling panel visibility (Hide/Show Group), changing BackColor on the nested panel, toggling BorderStyle (Fixed3D/FixedSingle), calling Refresh(), Invalidate(True), Focus(), Contains(pnlGroup), Dispose(), and saving grouped student inputs.
- Form2 (Activity 3 - SplitPanel Form): Demonstrates nested SplitContainers (splitMain vertical and splitInner horizontal). Selecting a record in the top ListView displays its details independently in the bottom Panel2 TextBox, while toolbar buttons collapse/expand panels, toggle Horizontal/Vertical orientation, and lock/unlock splitters.

### 4. Form Design
![Figure 10.2 — Visual Studio Form Designs of Form1 (Panel Form) & Form2 (SplitPanel Form)](docs/images/act10_design.png)
*Figure 10.2 — Visual Studio Form Designs of Form1 (Panel Form) & Form2 (SplitPanel Form)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `Form1 (Panel Form)` | Form | `"Activity 3 - Panel Form"` | Demonstrates Panel container properties and methods (920 × 560) |
| `pnlTools (Form1)` | Panel | `8 Command Buttons` | Contains Hide Group, BackColor, BorderStyle, Refresh, Invalidate, Focus, Contains, Dispose Test |
| `pnlWorkspace (Form1)` | Panel | `Main Workspace Panel` | Contains pnlGroup (Grouped Controls), pnlNested (Anchored), and pnlScrollable (AutoScroll) |
| `Form2 (SplitPanel Form)` | Form | `"Activity 3 - SplitPanel Form"` | Demonstrates nested SplitContainer controls (960 × 600) |
| `splitMain (Form2)` | SplitContainer | `Vertical SplitContainer` | Panel1 holds lstNavigation; Panel2 embeds splitInner |
| `splitInner (Form2)` | SplitContainer | `Horizontal/Vertical Split` | Panel1 holds lvRecords (ListView); Panel2 holds txtDetails (TextBox) |
| `pnlStatus / lblStatus` | Panel / Label | `Bottom Status Bar` | Displays real-time feedback for every property/method action and SplitterMoved event |

### 5. Brief Description
Activity 10 (SW20261002 / PanelSplitPanelDemo) is a two-form Windows Forms project that thoroughly demonstrates container controls: Panel (in Form1) and SplitContainer (in Form2). Form1 showcases how Panel controls group child controls, nest with Dock and Anchor rules, scroll oversized content via AutoScroll, and respond to methods such as Refresh(), Invalidate(), Focus(), Contains(), and Dispose(). Form2 showcases nested SplitContainers with collapsible panels (Panel1Collapsed / Panel2Collapsed), dynamic Orientation switching, splitter locking (IsSplitterFixed), and safe SplitterDistance calculation.

---

## Activity 11: Windows Forms File Explorer & Dialog Controls Suite — Questions 6–9 (SW202610021600)

### 1. Activity Title
- **Activity Title:** Activity 11: Windows Forms File Explorer & Dialog Controls Suite — Questions 6–9 (SW202610021600)
- **Project Folder / Solution:** `SW202610021600` (`SW202610021600.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** October 2, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `MenuForm.vb`
```vbnet
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MenuForm
    Inherits Form

    Private menuStrip1 As MenuStrip
    Private listMenu As ToolStripMenuItem
    Private treeMenu As ToolStripMenuItem
    Private openMenu As ToolStripMenuItem
    Private combinedMenu As ToolStripMenuItem
    Private exitMenu As ToolStripMenuItem

    Public Sub New()
        Me.Text = "SW202610021600"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(720, 400)
        menuStrip1 = New MenuStrip()
        treeMenu = New ToolStripMenuItem("TreeView File Explorer")
        openMenu = New ToolStripMenuItem("OpenFileDialog File Explorer")
        combinedMenu = New ToolStripMenuItem("Combined File Explorer")
        exitMenu = New ToolStripMenuItem("Exit")
        menuStrip1.Items.AddRange(New ToolStripItem() {treeMenu, openMenu, combinedMenu, exitMenu})
        menuStrip1.Dock = DockStyle.Top
        Me.Controls.Add(menuStrip1)
        Me.MainMenuStrip = menuStrip1

        AddHandler treeMenu.Click, AddressOf OpenTree
        AddHandler openMenu.Click, AddressOf OpenDialog
        AddHandler combinedMenu.Click, AddressOf OpenCombined
        AddHandler exitMenu.Click, AddressOf ExitProgram
    End Sub


    Private Sub OpenTree(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New TreeViewSample()
            form.ShowDialog()
        End Using
    End Sub

    Private Sub OpenDialog(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New OpenFileDialogSample()
            form.ShowDialog()
        End Using
    End Sub

    Private Sub OpenCombined(ByVal sender As Object, ByVal e As EventArgs)
        Using form As New CombinedSample()
            form.ShowDialog()
        End Using
    End Sub

    Private Sub ExitProgram(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'MenuForm
        '
        Me.ClientSize = New System.Drawing.Size(729, 387)
        Me.Name = "MenuForm"
        Me.ResumeLayout(False)

    End Sub

    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
```

#### `MainForm.vb`
```vbnet
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private tabs As TabControl
    Private explorerTab As TabPage
    Private listTab As TabPage
    Private treeTab As TabPage
    Private answersTab As TabPage

    Public Sub New()
        Me.Text = "SW202610021600 - Windows Forms Controls"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.MinimumSize = New Size(900, 600)
        tabs = New TabControl()
        tabs.Dock = DockStyle.Fill
        explorerTab = New TabPage("File explorer + dialogs")
        listTab = New TabPage("ListView examples")
        treeTab = New TabPage("TreeView examples")
        answersTab = New TabPage("Assignment answers")
        tabs.TabPages.Add(explorerTab)
        tabs.TabPages.Add(listTab)
        tabs.TabPages.Add(treeTab)
        tabs.TabPages.Add(answersTab)
        Me.Controls.Add(tabs)
        EmbedForm(New CombinedSample(), explorerTab)
        EmbedForm(New ListViewSample(), listTab)
        EmbedForm(New TreeViewSample(), treeTab)
        BuildAnswersTab()
    End Sub

    Private Sub EmbedForm(ByVal child As Form, ByVal page As TabPage)
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        page.Controls.Add(child)
        child.Show()
    End Sub

    Private Sub BuildAnswersTab()
        Dim text As New RichTextBox()
        text.Dock = DockStyle.Fill
        text.ReadOnly = True
        text.Font = New Font("Segoe UI", 11.0F)
        text.Text = "SW202610021600" & Environment.NewLine & Environment.NewLine & _
                    "Question 6 - ListView" & Environment.NewLine & _
                    "The ListView examples tab imitates File Explorer with folder browsing, Details/List views, columns, sorting, double-click opening, and a status bar." & Environment.NewLine & Environment.NewLine & _
                    "Question 7 - TreeView" & Environment.NewLine & _
                    "The TreeView examples tab displays drives and directories. Nodes are loaded when expanded and the selected path is shown." & Environment.NewLine & Environment.NewLine & _
                    "Question 8 - OpenFileDialog" & Environment.NewLine & _
                    "The File explorer + dialogs tab demonstrates OpenFileDialog, file filters, multiple selection, CheckFileExists, and RestoreDirectory." & Environment.NewLine & Environment.NewLine & _
                    "Question 9 - Combined form" & Environment.NewLine & _
                    "The File explorer + dialogs tab combines OpenFileDialog, SaveFileDialog, TreeView, ListView, folder navigation, and saving a directory listing."
        answersTab.Controls.Add(text)
    End Sub
End Class
```

#### `ListViewSample.vb`
```vbnet
Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class ListViewSample
    Private currentFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadFolder(currentFolder)
    End Sub

    Private Sub LoadFolder(ByVal folder As String)
        If Not Directory.Exists(folder) Then Return
        currentFolder = folder
        txtPath.Text = folder
        lv.Items.Clear()
        Try
            For Each directoryName As String In Directory.GetDirectories(folder)
                Dim item As New ListViewItem(Path.GetFileName(directoryName))
                item.SubItems.Add("Folder")
                item.SubItems.Add(Directory.GetLastWriteTime(directoryName).ToString())
                item.Tag = directoryName
                lv.Items.Add(item)
            Next
            For Each fileName As String In Directory.GetFiles(folder)
                Dim info As New FileInfo(fileName)
                Dim item As New ListViewItem(info.Name)
                item.SubItems.Add(info.Extension)
                item.SubItems.Add(info.Length.ToString() & " bytes")
                item.Tag = fileName
                lv.Items.Add(item)
            Next
            lbl.Text = lv.Items.Count.ToString() & " item(s)"
        Catch ex As Exception
            lbl.Text = ex.Message
        End Try
    End Sub

    Private Sub browse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browse.Click
        Using dialog As New FolderBrowserDialog()
            dialog.SelectedPath = currentFolder
            dialog.Description = "Select a folder"
            If dialog.ShowDialog() = DialogResult.OK Then
                LoadFolder(dialog.SelectedPath)
            End If
        End Using
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        LoadFolder(currentFolder)
    End Sub

    Private Sub details_Click(ByVal sender As Object, ByVal e As EventArgs) Handles details.Click
        lv.View = View.Details
    End Sub

    Private Sub list_Click(ByVal sender As Object, ByVal e As EventArgs) Handles list.Click
        lv.View = View.List
    End Sub

    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lv.DoubleClick
        If lv.SelectedItems.Count = 0 Then Return
        Dim selectedPath As String = CStr(lv.SelectedItems(0).Tag)
        If Directory.Exists(selectedPath) Then
            LoadFolder(selectedPath)
        ElseIf File.Exists(selectedPath) Then
            Process.Start(selectedPath)
        End If
    End Sub

    Private Sub lv_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles lv.ColumnClick
        lv.ListViewItemSorter = New ListViewComparer(e.Column)
        lv.Sort()
    End Sub

    Private Class ListViewComparer
        Implements System.Collections.IComparer
        Private ReadOnly columnNumber As Integer

        Public Sub New(ByVal column As Integer)
            columnNumber = column
        End Sub

        Public Function Compare(ByVal first As Object, ByVal second As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim a As ListViewItem = DirectCast(first, ListViewItem)
            Dim b As ListViewItem = DirectCast(second, ListViewItem)
            Return String.Compare(a.SubItems(columnNumber).Text, b.SubItems(columnNumber).Text, True)
        End Function
    End Class
End Class
```

#### `ListViewSample.Designer.vb`
```vbnet
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents txtPath As TextBox
 Friend WithEvents browse As Button
 Friend WithEvents btnRefresh As Button
 Friend WithEvents details As Button
 Friend WithEvents list As Button
 Friend WithEvents lv As ListView
 Friend WithEvents lbl As Label
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.txtPath=New TextBox() : Me.browse=New Button() : Me.btnRefresh=New Button() : Me.details=New Button() : Me.list=New Button() : Me.lv=New ListView() : Me.lbl=New Label()
  Me.SuspendLayout()
  Me.txtPath.SetBounds(10,10,560,25) : Me.browse.SetBounds(580,8,85,28) : Me.browse.Text="Browse..." : Me.btnRefresh.SetBounds(675,8,75,28) : Me.btnRefresh.Text="Refresh" : Me.details.SetBounds(760,8,70,28) : Me.details.Text="Details" : Me.list.SetBounds(840,8,55,28) : Me.list.Text="List" : Me.lv.SetBounds(10,45,885,460) : Me.lv.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.lv.View=View.Details : Me.lv.FullRowSelect=True : Me.lv.GridLines=True : Me.lv.Columns.Add("Name",300) : Me.lv.Columns.Add("Type",150) : Me.lv.Columns.Add("Modified/Size",200) : Me.lbl.SetBounds(10,515,800,25) : Me.Controls.AddRange(New Control() {Me.txtPath,Me.browse,Me.btnRefresh,Me.details,Me.list,Me.lv,Me.lbl})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 6 - ListView File Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.Controls.Add(Me.lv)
  Me.ResumeLayout(False)
 End Sub
End Class
```

#### `TreeViewSample.vb`
```vbnet
Imports System
Imports System.IO
Imports System.Windows.Forms

Public Class TreeViewSample
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BuildTree()
    End Sub
    Private Sub BuildTree()
        tree.Nodes.Clear()
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            If drive.IsReady Then
                Dim node As New TreeNode(drive.Name)
                node.Tag = drive.RootDirectory.FullName
                node.Nodes.Add("Loading...")
                tree.Nodes.Add(node)
            End If
        Next
    End Sub
    Private Sub tree_BeforeExpand(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles tree.BeforeExpand
        Dim folder As String = CStr(e.Node.Tag)
        e.Node.Nodes.Clear()
        Try
            For Each directoryName As String In Directory.GetDirectories(folder)
                Dim child As New TreeNode(Path.GetFileName(directoryName))
                child.Tag = directoryName
                Try
                    If Directory.GetDirectories(directoryName).Length > 0 Then child.Nodes.Add("Loading...")
                Catch
                End Try
                e.Node.Nodes.Add(child)
            Next
        Catch
        End Try
    End Sub
    Private Sub tree_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tree.AfterSelect
        selectedPath.Text = CStr(e.Node.Tag)
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        BuildTree()
    End Sub
End Class
```

#### `TreeViewSample.Designer.vb`
```vbnet
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents tree As TreeView
 Friend WithEvents selectedPath As TextBox
 Friend WithEvents btnRefresh As Button
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.tree=New TreeView() : Me.selectedPath=New TextBox() : Me.btnRefresh=New Button()
  Me.SuspendLayout()
  Me.tree.SetBounds(10,10,400,520) : Me.tree.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left : Me.selectedPath.SetBounds(430,45,440,25) : Me.selectedPath.ReadOnly=True : Me.btnRefresh.SetBounds(430,10,100,28) : Me.btnRefresh.Text="Refresh" : Me.Controls.AddRange(New Control() {Me.tree,Me.selectedPath,Me.btnRefresh}) : Me.Controls.AddRange(New Control() {Me.tree,Me.selectedPath,Me.btnRefresh})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 7 - TreeView File Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.Controls.Add(Me.tree)
  Me.ResumeLayout(False)
 End Sub
End Class
```

#### `OpenFileDialogSample.vb`
```vbnet
Imports System
Imports System.Windows.Forms

Public Class OpenFileDialogSample
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub one_Click(ByVal sender As Object, ByVal e As EventArgs) Handles one.Click
        Using dialog As New OpenFileDialog()
            Configure(dialog, False)
            If dialog.ShowDialog() = DialogResult.OK Then ShowFiles(dialog.FileNames)
        End Using
    End Sub
    Private Sub many_Click(ByVal sender As Object, ByVal e As EventArgs) Handles many.Click
        Using dialog As New OpenFileDialog()
            Configure(dialog, True)
            If dialog.ShowDialog() = DialogResult.OK Then ShowFiles(dialog.FileNames)
        End Using
    End Sub
    Private Sub Configure(ByVal dialog As OpenFileDialog, ByVal allowMultiple As Boolean)
        dialog.Title = "Select file"
        dialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Images (*.jpg;*.png)|*.jpg;*.png"
        dialog.FilterIndex = 1
        dialog.Multiselect = allowMultiple
        dialog.CheckFileExists = True
        dialog.CheckPathExists = True
        dialog.RestoreDirectory = True
    End Sub
    Private Sub ShowFiles(ByVal files() As String)
        selected.Items.Clear()
        For Each fileName As String In files
            selected.Items.Add(fileName)
        Next
    End Sub
    Private Sub clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clear.Click
        selected.Items.Clear()
    End Sub
End Class
```

#### `OpenFileDialogSample.Designer.vb`
```vbnet
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenFileDialogSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents one As Button
 Friend WithEvents many As Button
 Friend WithEvents clear As Button
 Friend WithEvents selected As ListBox
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.one=New Button() : Me.many=New Button() : Me.clear=New Button() : Me.selected=New ListBox()
  Me.SuspendLayout()
  Me.one.SetBounds(10,10,130,30) : Me.one.Text="Open one..." : Me.many.SetBounds(150,10,160,30) : Me.many.Text="Open multiple..." : Me.clear.SetBounds(320,10,80,30) : Me.clear.Text="Clear" : Me.selected.SetBounds(10,55,860,470) : Me.selected.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.Controls.AddRange(New Control() {Me.one,Me.many,Me.clear,Me.selected})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 8 - OpenFileDialog"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.Controls.Add(Me.selected)
  Me.ResumeLayout(False)
 End Sub
End Class
```

#### `CombinedSample.vb`
```vbnet
Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class CombinedSample
    Private currentFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BuildTree()
        LoadFolder(currentFolder)
    End Sub
    Private Sub BuildTree()
        tree.Nodes.Clear()
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            If drive.IsReady Then
                Dim node As New TreeNode(drive.Name)
                node.Tag = drive.RootDirectory.FullName
                node.Nodes.Add("Loading...")
                tree.Nodes.Add(node)
            End If
        Next
    End Sub
    Private Sub tree_BeforeExpand(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles tree.BeforeExpand
        Dim folder As String = CStr(e.Node.Tag)
        e.Node.Nodes.Clear()
        Try
            For Each directoryName As String In Directory.GetDirectories(folder)
                Dim child As New TreeNode(Path.GetFileName(directoryName))
                child.Tag = directoryName
                e.Node.Nodes.Add(child)
            Next
        Catch
        End Try
    End Sub
    Private Sub tree_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tree.AfterSelect
        currentFolder = CStr(e.Node.Tag)
        LoadFolder(currentFolder)
    End Sub
    Private Sub LoadFolder(ByVal folder As String)
        If Not Directory.Exists(folder) Then Return
        lv.Items.Clear()
        Try
            For Each directoryName As String In Directory.GetDirectories(folder)
                Dim item As New ListViewItem(Path.GetFileName(directoryName))
                item.SubItems.Add("Folder")
                item.Tag = directoryName
                lv.Items.Add(item)
            Next
            For Each fileName As String In Directory.GetFiles(folder)
                Dim item As New ListViewItem(Path.GetFileName(fileName))
                item.SubItems.Add("File")
                item.Tag = fileName
                lv.Items.Add(item)
            Next
        Catch
        End Try
    End Sub
    Private Sub open_Click(ByVal sender As Object, ByVal e As EventArgs) Handles open.Click
        Using dialog As New OpenFileDialog()
            dialog.Filter = "All files (*.*)|*.*"
            dialog.CheckFileExists = True
            If dialog.ShowDialog() = DialogResult.OK Then Process.Start(dialog.FileName)
        End Using
    End Sub
    Private Sub save_Click(ByVal sender As Object, ByVal e As EventArgs) Handles save.Click
        Using dialog As New SaveFileDialog()
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            If dialog.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(dialog.FileName)
                    For Each item As ListViewItem In lv.Items
                        writer.WriteLine(item.Text & Microsoft.VisualBasic.ControlChars.Tab & item.SubItems(1).Text)
                    Next
                End Using
            End If
        End Using
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        BuildTree()
        LoadFolder(currentFolder)
    End Sub
End Class
```

#### `CombinedSample.Designer.vb`
```vbnet
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombinedSample
 Inherits System.Windows.Forms.Form
 Private components As System.ComponentModel.IContainer
  Friend WithEvents tree As TreeView
 Friend WithEvents lv As ListView
 Friend WithEvents open As Button
 Friend WithEvents save As Button
 Friend WithEvents btnRefresh As Button
 <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub Dispose(ByVal disposing As Boolean)
  If disposing AndAlso components IsNot Nothing Then components.Dispose()
  MyBase.Dispose(disposing)
 End Sub
 <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
  Me.components = New System.ComponentModel.Container()
  Me.tree=New TreeView() : Me.lv=New ListView() : Me.open=New Button() : Me.save=New Button() : Me.btnRefresh=New Button()
  Me.SuspendLayout()
  Me.open.SetBounds(10,10,100,28) : Me.open.Text="Open file" : Me.save.SetBounds(120,10,100,28) : Me.save.Text="Save As" : Me.btnRefresh.SetBounds(230,10,90,28) : Me.btnRefresh.Text="Refresh" : Me.tree.SetBounds(10,50,300,480) : Me.tree.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left : Me.lv.SetBounds(320,50,560,480) : Me.lv.Anchor=AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right : Me.lv.View=View.Details : Me.lv.Columns.Add("Name",300) : Me.lv.Columns.Add("Type",150) : Me.Controls.AddRange(New Control() {Me.tree,Me.lv,Me.open,Me.save,Me.btnRefresh})
  Me.ClientSize = New System.Drawing.Size(900, 560)
  Me.Text = "Question 9 - Combined Explorer"
  Me.StartPosition = FormStartPosition.CenterScreen
  Me.Controls.Add(Me.lv)
  Me.ResumeLayout(False)
 End Sub
End Class
```

#### `Application.vb`
```vbnet
Imports System
Imports System.Windows.Forms
Module Application
 <STAThread()> Public Sub Main()
  System.Windows.Forms.Application.EnableVisualStyles()
  System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)
  System.Windows.Forms.Application.Run(New MainForm())
 End Sub
End Module
```

### 3. Sample Run
![Figure 11.1 — Sample Runs of MenuForm, TreeViewSample (Q7), OpenFileDialogSample (Q8), and CombinedSample (Q9)](docs/images/act11_run.png)
*Figure 11.1 — Sample Runs of MenuForm, TreeViewSample (Q7), OpenFileDialogSample (Q8), and CombinedSample (Q9)*

**Sample Run Walkthrough:**
- MenuForm / MainForm provides central navigation to open the individual sample forms as modal dialogs or embedded tabs.
- Question 7 (TreeViewSample): Enumerates ready drives via DriveInfo.GetDrives(), populates child folders on demand inside tree_BeforeExpand, and displays the full path in selectedPath on tree_AfterSelect.
- Question 8 (OpenFileDialogSample): 'Open one...' and 'Open multiple...' configure an OpenFileDialog with file filters (All files, Text files, Images), CheckFileExists, RestoreDirectory, and Multiselect, listing chosen file paths in the ListBox.
- Question 9 (CombinedSample): Synchronizes a left TreeView with a right ListView and adds 'Open file' (OpenFileDialog + Process.Start) and 'Save As' (SaveFileDialog + StreamWriter) to export the current directory's contents to a text file.

### 4. Form Design
![Figure 11.2 — Visual Studio Form Designs of MenuForm and CombinedSample (SW202610021600)](docs/images/act11_design.png)
*Figure 11.2 — Visual Studio Form Designs of MenuForm and CombinedSample (SW202610021600)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `MenuForm` | Form | `"SW202610021600"` | Launcher form with MenuStrip items for TreeView, OpenFileDialog, Combined Explorer, and Exit |
| `MainForm` | Form | `"SW202610021600 - Windows Forms Controls"` | Tabbed host form embedding CombinedSample, ListViewSample, TreeViewSample, and Assignment Answers |
| `ListViewSample (Q6)` | Form | `"Question 6 - ListView File Explorer"` | Folder browser with ListView, Details/List views, and column sorting |
| `TreeViewSample (Q7)` | Form | `"Question 7 - TreeView File Explorer"` | Drive & folder hierarchy browser using TreeView, btnRefresh, and selectedPath TextBox |
| `OpenFileDialogSample (Q8)` | Form | `"Question 8 - OpenFileDialog"` | Single/Multi-file picker using OpenFileDialog and selected ListBox |
| `CombinedSample (Q9)` | Form | `"Question 9 - Combined Explorer"` | Combines TreeView, ListView, OpenFileDialog ('Open file'), and SaveFileDialog ('Save As') |

### 5. Brief Description
Activity 11 (Seatwork SW202610021600) consolidates four Windows Forms file-navigation and dialog exercises (Questions 6 through 9). It demonstrates how ListView, TreeView, OpenFileDialog, and SaveFileDialog work both individually and together: lazy-loading directory trees on node expansion (BeforeExpand), filtering and selecting single or multiple files (OpenFileDialog), displaying directory contents on node selection (AfterSelect), and exporting directory listings to disk using SaveFileDialog and StreamWriter.

---

## Activity 12: Folder Explorer with Multi-Format Preview Engine (FileExplorerClone / PanelSplitDemo)

### 1. Activity Title
- **Activity Title:** Activity 12: Folder Explorer with Multi-Format Preview Engine (FileExplorerClone / PanelSplitDemo)
- **Project Folder / Solution:** `FileExplorerClone` (`PanelSplitDemo.sln`)
- **Application Type:** VB.NET Windows Forms Application (.NET Framework 4.0)
- **Date:** October 24, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Form1.vb`
```vbnet
Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text

Public Class Form1
    Private currentPath As String = ""
    Private history As New List(Of String)()
    Private historyPosition As Integer = -1
    Private changingFolder As Boolean = False
    Private splittersLocked As Boolean = False
    Private previewHost As Panel
    Private cutPaths As New List(Of String)()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = ""
            cboShowMode.Items.Clear()
            cboShowMode.Items.Add("Details")
            cboShowMode.Items.Add("Preview")
            cboShowMode.Items.Add("Details + Preview")
            cboShowMode.SelectedIndex = 2
            SetSafeSplitterDistance(splitMain, 220)
            SetSafeSplitterDistance(splitContent, CInt(splitContent.Width * 0.64))
            LoadFolderTree()
            Dim startFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If Not Directory.Exists(startFolder) Then startFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If Not Directory.Exists(startFolder) Then startFolder = Environment.CurrentDirectory
            NavigateTo(startFolder, True)
            UpdateFileToolState()
        Catch ex As Exception
            lblStatus.Text = "The explorer could not finish loading: " & ex.Message
        End Try
    End Sub

    Private Sub LoadFolderTree()
        tvFolders.Nodes.Clear()
        AddRootNode("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        AddRootNode("Documents", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        AddRootNode("Pictures", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
        AddRootNode("Computer", "")
        Dim computer As TreeNode = tvFolders.Nodes(tvFolders.Nodes.Count - 1)
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            Dim node As New TreeNode(drive.Name)
            node.Tag = drive.RootDirectory.FullName
            node.Nodes.Add(New TreeNode("Loading"))
            computer.Nodes.Add(node)
        Next
        computer.Expand()
    End Sub

    Private Sub AddRootNode(ByVal title As String, ByVal folderPath As String)
        If folderPath = "" OrElse Not Directory.Exists(folderPath) Then Return
        Dim node As New TreeNode(title)
        node.Tag = folderPath
        node.Nodes.Add(New TreeNode("Loading"))
        tvFolders.Nodes.Add(node)
    End Sub

    Private Sub tvFolders_BeforeExpand(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs) Handles tvFolders.BeforeExpand
        If e.Node.Tag Is Nothing Then Return
        If e.Node.Nodes.Count = 1 AndAlso e.Node.Nodes(0).Tag Is Nothing Then
            e.Node.Nodes.Clear()
            Try
                For Each folder As String In Directory.GetDirectories(CStr(e.Node.Tag))
                    Dim info As New DirectoryInfo(folder)
                    If (info.Attributes And FileAttributes.Hidden) = 0 Then
                        Dim child As New TreeNode(info.Name)
                        child.Tag = info.FullName
                        child.Nodes.Add(New TreeNode("Loading"))
                        e.Node.Nodes.Add(child)
                    End If
                Next
            Catch
            End Try
        End If
    End Sub

    Private Sub tvFolders_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tvFolders.AfterSelect
        If changingFolder OrElse e.Node.Tag Is Nothing Then Return
        NavigateTo(CStr(e.Node.Tag), True)
    End Sub

    Private Sub NavigateTo(ByVal folderPath As String, ByVal addToHistory As Boolean)
        If folderPath = "" OrElse Not Directory.Exists(folderPath) Then
            lblStatus.Text = "Folder not found."
            Return
        End If
        Try
            currentPath = folderPath
            txtAddress.Text = folderPath
            lblFiles.Text = IO.Path.GetFileName(folderPath)
            If lblFiles.Text = "" Then lblFiles.Text = folderPath
            If addToHistory Then
                If historyPosition < history.Count - 1 Then
                    history.RemoveRange(historyPosition + 1, history.Count - historyPosition - 1)
                End If
                If history.Count = 0 OrElse history(history.Count - 1) <> folderPath Then
                    history.Add(folderPath)
                    historyPosition = history.Count - 1
                End If
            End If
            FillFileList(txtSearch.Text.Trim())
            SelectTreePath(folderPath)
            ClearPreview("Select a file or folder to preview it.")
        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub SelectTreePath(ByVal folderPath As String)
        changingFolder = True
        Try
            Dim found As TreeNode = FindNode(tvFolders.Nodes, folderPath)
            If found IsNot Nothing Then tvFolders.SelectedNode = found
        Finally
            changingFolder = False
        End Try
    End Sub

    Private Function FindNode(ByVal nodes As TreeNodeCollection, ByVal folderPath As String) As TreeNode
        For Each node As TreeNode In nodes
            If node.Tag IsNot Nothing AndAlso String.Equals(CStr(node.Tag), folderPath, StringComparison.OrdinalIgnoreCase) Then Return node
            If node.IsExpanded Then
                Dim found As TreeNode = FindNode(node.Nodes, folderPath)
                If found IsNot Nothing Then Return found
            End If
        Next
        Return Nothing
    End Function

    Private Sub FillFileList(ByVal filter As String)
        lvFiles.BeginUpdate()
        lvFiles.Items.Clear()
        Try
            For Each folder As String In Directory.GetDirectories(currentPath)
                Dim info As New DirectoryInfo(folder)
                If (info.Attributes And FileAttributes.Hidden) = 0 AndAlso MatchesFilter(info.Name, filter) Then
                    Dim item As New ListViewItem(info.Name)
                    item.SubItems.Add("File folder")
                    item.SubItems.Add("")
                    item.SubItems.Add(info.LastWriteTime.ToString("g"))
                    item.Tag = info.FullName
                    lvFiles.Items.Add(item)
                End If
            Next
            For Each fileName As String In Directory.GetFiles(currentPath)
                Dim info As New FileInfo(fileName)
                If MatchesFilter(info.Name, filter) Then
                    Dim item As New ListViewItem(info.Name)
                    Dim extension As String = info.Extension.ToUpperInvariant()
                    If extension = "" Then extension = "File"
                    item.SubItems.Add(extension & " file")
                    item.SubItems.Add(FormatSize(info.Length))
                    item.SubItems.Add(info.LastWriteTime.ToString("g"))
                    item.Tag = info.FullName
                    lvFiles.Items.Add(item)
                End If
            Next
            lblStatus.Text = lvFiles.Items.Count.ToString() & " items   |   " & currentPath
        Catch ex As Exception
            lblStatus.Text = "Cannot open folder: " & ex.Message
        Finally
            lvFiles.EndUpdate()
        End Try
    End Sub

    Private Function MatchesFilter(ByVal itemName As String, ByVal filter As String) As Boolean
        If filter = "" Then Return True
        Return itemName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0
    End Function

    Private Function FormatSize(ByVal value As Long) As String
        If value >= 1073741824 Then Return (value / 1073741824.0).ToString("0.00") & " GB"
        If value >= 1048576 Then Return (value / 1048576.0).ToString("0.00") & " MB"
        If value >= 1024 Then Return (value / 1024.0).ToString("0.00") & " KB"
        Return value.ToString() & " bytes"
    End Function

    Private Sub lvFiles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvFiles.SelectedIndexChanged
        UpdateFileToolState()
        If lvFiles.SelectedItems.Count = 0 Then
            ClearPreview("Select a file or folder to preview it.")
            Return
        End If
        ShowPreview(CStr(lvFiles.SelectedItems(0).Tag))
    End Sub

    Private Sub lvFiles_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvFiles.DoubleClick
        If lvFiles.SelectedItems.Count = 0 Then Return
        Dim selectedPath As String = CStr(lvFiles.SelectedItems(0).Tag)
        If Directory.Exists(selectedPath) Then
            NavigateTo(selectedPath, True)
        Else
            Try
                Process.Start(selectedPath)
            Catch ex As Exception
                lblStatus.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub ShowPreview(ByVal selectedPath As String)
        ClearPreview("")
        previewHost = New Panel()
        previewHost.Dock = DockStyle.Fill
        previewHost.AutoScroll = True
        previewHost.BackColor = Color.White
        previewHost.TabStop = True
        pnlPreviewContent.Controls.Add(previewHost)
        lblPreviewTitle.Text = IO.Path.GetFileName(selectedPath)

        If Directory.Exists(selectedPath) Then
            Try
                Dim info As New DirectoryInfo(selectedPath)
                Dim folderCount As Integer = 0
                Dim fileCount As Integer = 0
                Try
                    folderCount = Directory.GetDirectories(selectedPath).Length
                    fileCount = Directory.GetFiles(selectedPath).Length
                Catch
                End Try
                Dim parentLocation As String = info.FullName
                If info.Parent IsNot Nothing Then parentLocation = info.Parent.FullName
                txtPreviewDetails.Text = "Type: File folder" & vbCrLf & _
                                         "Location: " & parentLocation & vbCrLf & _
                                         "Modified: " & info.LastWriteTime.ToString("g") & vbCrLf & _
                                         "Contains: " & folderCount.ToString() & " folders, " & fileCount.ToString() & " files"
                Dim text As New StringBuilder()
                text.AppendLine(info.FullName)
                text.AppendLine()
                Try
                    For Each folder As String In Directory.GetDirectories(selectedPath)
                        text.AppendLine("[Folder]  " & IO.Path.GetFileName(folder))
                        If text.Length > 100000 Then Exit For
                    Next
                    For Each fileName As String In Directory.GetFiles(selectedPath)
                        Dim child As New FileInfo(fileName)
                        text.AppendLine("          " & child.Name & "   " & FormatSize(child.Length))
                        If text.Length > 200000 Then Exit For
                    Next
                Catch ex As Exception
                    text.AppendLine(ex.Message)
                End Try
                AddTextPreview(text.ToString(), False)
            Catch ex As Exception
                AddTextPreview("Folder preview is not available." & vbCrLf & ex.Message, True)
            End Try
            Return
        End If

        Try
            If Not File.Exists(selectedPath) Then
                ClearPreview("The selected file no longer exists.")
                Return
            End If

            Dim info As New FileInfo(selectedPath)
            Dim extension As String = info.Extension.ToLowerInvariant()
            txtPreviewDetails.Text = "Type: " & If(extension = "", "File", extension.ToUpperInvariant() & " file") & vbCrLf & _
                                     "Size: " & FormatSize(info.Length) & vbCrLf & _
                                     "Created: " & info.CreationTime.ToString("g") & vbCrLf & _
                                     "Modified: " & info.LastWriteTime.ToString("g") & vbCrLf & _
                                     "Attributes: " & info.Attributes.ToString()

            Select Case extension
                Case ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico", ".tif", ".tiff", ".wmf", ".emf"
                    If info.Length > 52428800 Then
                        AddTextPreview("This image is larger than 50 MB. Open it normally to avoid using too much memory.", True)
                        Return
                    End If
                    Dim data As Byte() = File.ReadAllBytes(selectedPath)
                    Using stream As New MemoryStream(data)
                        Using source As Image = Image.FromStream(stream)
                            Dim picture As New PictureBox()
                            picture.Dock = DockStyle.Fill
                            picture.SizeMode = PictureBoxSizeMode.Zoom
                            picture.Image = New Bitmap(source)
                            previewHost.Controls.Add(picture)
                            txtPreviewDetails.Text &= vbCrLf & "Dimensions: " & source.Width.ToString() & " x " & source.Height.ToString()
                        End Using
                    End Using

                Case ".rtf"
                    AddRtfPreview(selectedPath)

                Case ".htm", ".html", ".mht", ".mhtml", ".xhtml", ".svg"
                    AddWebPreview(selectedPath)

                Case ".pdf"
                    AddTextPreview(PreviewEngine.GetPdfText(selectedPath), True)

                Case ".docx", ".docm", ".dotx"
                    AddTextPreview(PreviewEngine.GetDocxText(selectedPath), True)

                Case ".xlsx", ".xltx"
                    AddTextPreview(PreviewEngine.GetXlsxText(selectedPath), False)

                Case ".pptx", ".ppsx", ".potx"
                    AddTextPreview(PreviewEngine.GetPptxText(selectedPath), True)

                Case ".doc", ".dot", ".xls", ".xlsm", ".xlsb", ".ppt", ".pps"
                    Dim officeText As String = PreviewEngine.GetLegacyOfficeText(selectedPath)
                    If String.IsNullOrEmpty(officeText) Then
                        officeText = "Microsoft Office is not available for a full preview." & vbCrLf & vbCrLf & PreviewEngine.ScrapeText(selectedPath, 1048576)
                    End If
                    AddTextPreview(officeText, True)

                Case ".csv"
                    AddTextPreview(PreviewEngine.FormatDelimited(ReadText(selectedPath), ","c), False)

                Case ".tsv"
                    AddTextPreview(PreviewEngine.FormatDelimited(ReadText(selectedPath), CChar(vbTab)), False)

                Case ".zip", ".jar", ".apk", ".vsix", ".nupkg", ".epub"
                    AddTextPreview(PreviewEngine.GetZipListing(selectedPath), False)

                Case ".exe", ".dll", ".ocx", ".sys"
                    AddTextPreview(PreviewEngine.GetVersionText(selectedPath) & vbCrLf & GetHexPreview(selectedPath, 512), False)

                Case ".mp3", ".wav", ".wma", ".m4a", ".flac", ".ogg", ".aac", ".mp4", ".avi", ".mkv", ".wmv", ".mov", ".flv", ".3gp", ".webm"
                    AddTextPreview(PreviewEngine.GetMediaText(selectedPath), True)

                Case ".txt", ".log", ".ini", ".xml", ".vb", ".cs", ".cpp", ".c", ".h", ".json", ".sql", ".bat", ".cmd", ".ps1", ".py", ".java", ".js", ".css", ".config", ".md"
                    AddTextPreview(ReadText(selectedPath), False)

                Case Else
                    If LooksLikeText(selectedPath) Then
                        AddTextPreview(ReadText(selectedPath), False)
                    Else
                        AddTextPreview("This format has no visual preview. The first bytes are shown below." & vbCrLf & vbCrLf & GetHexPreview(selectedPath, 2048), False)
                    End If
            End Select

            previewHost.Focus()
            pnlPreviewContent.Refresh()
        Catch ex As OutOfMemoryException
            AddTextPreview("The file is too large or damaged to preview safely.", True)
        Catch ex As UnauthorizedAccessException
            AddTextPreview("Access to this file was denied.", True)
        Catch ex As IOException
            AddTextPreview("The file is unavailable or is being used by another program." & vbCrLf & ex.Message, True)
        Catch ex As Exception
            AddTextPreview("Preview is not available." & vbCrLf & vbCrLf & ex.Message, True)
        End Try
    End Sub

    Private Sub AddRtfPreview(ByVal fileName As String)
        Dim box As New RichTextBox()
        box.BackColor = Color.White
        box.BorderStyle = BorderStyle.None
        box.Dock = DockStyle.Fill
        box.ReadOnly = True
        box.ScrollBars = RichTextBoxScrollBars.Both
        box.LoadFile(fileName)
        previewHost.Controls.Add(box)
    End Sub

    Private Sub AddWebPreview(ByVal fileName As String)
        Dim browser As New WebBrowser()
        browser.AllowWebBrowserDrop = False
        browser.Dock = DockStyle.Fill
        browser.IsWebBrowserContextMenuEnabled = False
        browser.ScriptErrorsSuppressed = True
        previewHost.Controls.Add(browser)
        browser.Navigate(New Uri(fileName))
    End Sub

    Private Function LooksLikeText(ByVal fileName As String) As Boolean
        Try
            Using stream As New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim size As Integer = CInt(Math.Min(stream.Length, 1024))
                If size = 0 Then Return True
                Dim data(size - 1) As Byte
                stream.Read(data, 0, size)
                Dim unusual As Integer = 0
                For Each value As Byte In data
                    If value = 0 Then Return False
                    If value < 9 OrElse (value > 13 AndAlso value < 32) Then unusual += 1
                Next
                Return unusual * 100 \ size < 5
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Function GetHexPreview(ByVal fileName As String, ByVal maximum As Integer) As String
        Dim data() As Byte
        Using stream As New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim size As Integer = CInt(Math.Min(stream.Length, maximum))
            If size = 0 Then Return "Empty file"
            ReDim data(size - 1)
            stream.Read(data, 0, size)
        End Using
        Dim result As New StringBuilder()
        Dim offset As Integer = 0
        While offset < data.Length
            Dim hexText As New StringBuilder()
            Dim normalText As New StringBuilder()
            For column As Integer = 0 To 15
                If offset + column < data.Length Then
                    Dim value As Byte = data(offset + column)
                    hexText.Append(value.ToString("X2") & " ")
                    If value >= 32 AndAlso value <= 126 Then
                        normalText.Append(Chr(value))
                    Else
                        normalText.Append("."c)
                    End If
                Else
                    hexText.Append("   ")
                End If
            Next
            result.AppendLine(offset.ToString("X8") & "  " & hexText.ToString() & " " & normalText.ToString())
            offset += 16
        End While
        Return result.ToString()
    End Function

    Private Function ReadText(ByVal fileName As String) As String
        Using stream As New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim size As Integer = CInt(Math.Min(stream.Length, 262144))
            If size = 0 Then Return ""
            Dim data(size - 1) As Byte
            stream.Read(data, 0, size)
            Dim text As String = Encoding.Default.GetString(data)
            If stream.Length > size Then text &= vbCrLf & vbCrLf & "Preview shortened."
            Return text
        End Using
    End Function

    Private Sub AddTextPreview(ByVal value As String, ByVal wrapText As Boolean)
        Dim box As New TextBox()
        box.BackColor = Color.White
        box.BorderStyle = BorderStyle.None
        box.Dock = DockStyle.Fill
        box.Font = New Font("Consolas", 9.0!)
        box.Multiline = True
        box.ReadOnly = True
        box.ScrollBars = ScrollBars.Both
        box.WordWrap = wrapText
        box.Text = value
        previewHost.Controls.Add(box)
    End Sub

    Private Sub ClearPreview(ByVal message As String)
        If previewHost IsNot Nothing Then
            If pnlPreviewContent.Contains(previewHost) Then pnlPreviewContent.Controls.Remove(previewHost)
            previewHost.Dispose()
            previewHost = Nothing
        End If
        lblPreviewTitle.Text = "Preview"
        txtPreviewDetails.Text = If(message = "", "", "No file selected")
        If message <> "" Then
            previewHost = New Panel()
            previewHost.Dock = DockStyle.Fill
            previewHost.BackColor = Color.White
            pnlPreviewContent.Controls.Add(previewHost)
            Dim label As New Label()
            label.Dock = DockStyle.Fill
            label.ForeColor = SystemColors.GrayText
            label.Text = message
            label.TextAlign = ContentAlignment.MiddleCenter
            previewHost.Controls.Add(label)
        End If
    End Sub

    Private Function GetSelectedPath() As String
        If lvFiles.SelectedItems.Count = 0 Then Return ""
        Return CStr(lvFiles.SelectedItems(0).Tag)
    End Function

    Private Sub UpdateFileToolState()
        Dim hasSelection As Boolean = lvFiles.SelectedItems.Count > 0
        toolCut.Enabled = hasSelection
        toolCopy.Enabled = hasSelection
        toolRename.Enabled = hasSelection
        toolDelete.Enabled = hasSelection
        Try
            toolPaste.Enabled = Clipboard.ContainsFileDropList()
        Catch
            toolPaste.Enabled = False
        End Try
    End Sub

    Private Sub toolNewFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolNewFolder.Click
        Try
            Dim folderName As String = GetUniqueDestination(currentPath, "New folder")
            Directory.CreateDirectory(folderName)
            FillFileList(txtSearch.Text.Trim())
            For Each item As ListViewItem In lvFiles.Items
                If String.Equals(CStr(item.Tag), folderName, StringComparison.OrdinalIgnoreCase) Then
                    item.Selected = True
                    item.BeginEdit()
                    Exit For
                End If
            Next
            lblStatus.Text = "A new folder was created."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub toolCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolCopy.Click
        CopySelection(False)
    End Sub

    Private Sub toolCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolCut.Click
        CopySelection(True)
    End Sub

    Private Sub CopySelection(ByVal cut As Boolean)
        Dim selectedPath As String = GetSelectedPath()
        If selectedPath = "" Then Return
        Try
            Dim files As New System.Collections.Specialized.StringCollection()
            files.Add(selectedPath)
            Clipboard.SetFileDropList(files)
            cutPaths.Clear()
            If cut Then cutPaths.Add(selectedPath)
            toolPaste.Enabled = True
            lblStatus.Text = If(cut, "Item ready to move.", "Item copied to the Clipboard.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub toolPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolPaste.Click
        If currentPath = "" Then Return
        Try
            If Not Clipboard.ContainsFileDropList() Then Return
            Dim clipboardItems As System.Collections.Specialized.StringCollection = Clipboard.GetFileDropList()
            For Each source As String In clipboardItems
                If Not File.Exists(source) AndAlso Not Directory.Exists(source) Then Continue For
                If Directory.Exists(source) AndAlso currentPath.StartsWith(source.TrimEnd(IO.Path.DirectorySeparatorChar) & IO.Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase) Then
                    Throw New IOException("A folder cannot be pasted inside itself.")
                End If
                Dim destination As String = GetUniqueDestination(currentPath, IO.Path.GetFileName(source.TrimEnd(IO.Path.DirectorySeparatorChar)))
                Dim moveItem As Boolean = cutPaths.Exists(Function(value As String) String.Equals(value, source, StringComparison.OrdinalIgnoreCase))
                If moveItem Then
                    If Directory.Exists(source) Then
                        Directory.Move(source, destination)
                    Else
                        File.Move(source, destination)
                    End If
                ElseIf Directory.Exists(source) Then
                    CopyDirectory(source, destination)
                Else
                    File.Copy(source, destination, False)
                End If
            Next
            cutPaths.Clear()
            FillFileList(txtSearch.Text.Trim())
            lblStatus.Text = "Paste completed."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        UpdateFileToolState()
    End Sub

    Private Sub CopyDirectory(ByVal source As String, ByVal destination As String)
        Directory.CreateDirectory(destination)
        For Each fileName As String In Directory.GetFiles(source)
            File.Copy(fileName, IO.Path.Combine(destination, IO.Path.GetFileName(fileName)), False)
        Next
        For Each folder As String In Directory.GetDirectories(source)
            CopyDirectory(folder, IO.Path.Combine(destination, IO.Path.GetFileName(folder)))
        Next
    End Sub

    Private Function GetUniqueDestination(ByVal parentFolder As String, ByVal itemName As String) As String
        Dim destination As String = IO.Path.Combine(parentFolder, itemName)
        If Not File.Exists(destination) AndAlso Not Directory.Exists(destination) Then Return destination
        Dim baseName As String = IO.Path.GetFileNameWithoutExtension(itemName)
        Dim extension As String = IO.Path.GetExtension(itemName)
        Dim number As Integer = 2
        Do
            destination = IO.Path.Combine(parentFolder, baseName & " (" & number.ToString() & ")" & extension)
            number += 1
        Loop While File.Exists(destination) OrElse Directory.Exists(destination)
        Return destination
    End Function

    Private Sub toolRename_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolRename.Click
        If lvFiles.SelectedItems.Count > 0 Then lvFiles.SelectedItems(0).BeginEdit()
    End Sub

    Private Sub lvFiles_AfterLabelEdit(ByVal sender As Object, ByVal e As LabelEditEventArgs) Handles lvFiles.AfterLabelEdit
        If e.Label Is Nothing Then Return
        If e.Label.Trim() = "" OrElse e.Label.IndexOfAny(IO.Path.GetInvalidFileNameChars()) >= 0 Then
            e.CancelEdit = True
            MessageBox.Show("Enter a valid name.", "Rename", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim source As String = CStr(lvFiles.Items(e.Item).Tag)
        Dim destination As String = IO.Path.Combine(IO.Path.GetDirectoryName(source), e.Label.Trim())
        Try
            If File.Exists(destination) OrElse Directory.Exists(destination) Then Throw New IOException("An item with that name already exists.")
            If Directory.Exists(source) Then
                Directory.Move(source, destination)
            Else
                File.Move(source, destination)
            End If
            lvFiles.Items(e.Item).Tag = destination
            lblStatus.Text = "Item renamed."
        Catch ex As Exception
            e.CancelEdit = True
            MessageBox.Show(ex.Message, "Rename", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub toolDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolDelete.Click
        Dim selectedPath As String = GetSelectedPath()
        If selectedPath = "" Then Return
        If MessageBox.Show("Delete " & IO.Path.GetFileName(selectedPath) & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return
        Try
            ClearPreview("Select a file or folder to preview it.")
            If Directory.Exists(selectedPath) Then
                Directory.Delete(selectedPath, True)
            Else
                File.Delete(selectedPath)
            End If
            FillFileList(txtSearch.Text.Trim())
            lblStatus.Text = "Item deleted."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Sort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sortName.Click, sortDate.Click, sortType.Click, sortSize.Click
        Dim mode As Integer = 0
        If sender Is sortDate Then mode = 1
        If sender Is sortType Then mode = 2
        If sender Is sortSize Then mode = 3
        lvFiles.ListViewItemSorter = New ExplorerItemComparer(mode)
        lvFiles.Sort()
        lblStatus.Text = "Items sorted by " & DirectCast(sender, ToolStripMenuItem).Text & "."
    End Sub

    Private Class ExplorerItemComparer
        Implements System.Collections.IComparer
        Private mode As Integer

        Public Sub New(ByVal sortMode As Integer)
            mode = sortMode
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim first As ListViewItem = DirectCast(x, ListViewItem)
            Dim second As ListViewItem = DirectCast(y, ListViewItem)
            Dim firstPath As String = CStr(first.Tag)
            Dim secondPath As String = CStr(second.Tag)
            Dim firstFolder As Boolean = Directory.Exists(firstPath)
            Dim secondFolder As Boolean = Directory.Exists(secondPath)
            If firstFolder AndAlso Not secondFolder Then Return -1
            If secondFolder AndAlso Not firstFolder Then Return 1
            Try
                Select Case mode
                    Case 1
                        Return DateTime.Compare(File.GetLastWriteTime(firstPath), File.GetLastWriteTime(secondPath))
                    Case 2
                        Return String.Compare(IO.Path.GetExtension(firstPath), IO.Path.GetExtension(secondPath), True)
                    Case 3
                        Dim firstSize As Long = If(firstFolder, 0, New FileInfo(firstPath).Length)
                        Dim secondSize As Long = If(secondFolder, 0, New FileInfo(secondPath).Length)
                        Return firstSize.CompareTo(secondSize)
                    Case Else
                        Return String.Compare(first.Text, second.Text, True)
                End Select
            Catch
                Return String.Compare(first.Text, second.Text, True)
            End Try
        End Function
    End Class

    Private Sub viewDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles viewDetails.Click
        lvFiles.View = View.Details
    End Sub

    Private Sub viewList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles viewList.Click
        lvFiles.View = View.List
    End Sub

    Private Sub viewLarge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles viewLarge.Click
        lvFiles.View = View.LargeIcon
    End Sub

    Private Sub toolDetailsPane_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolDetailsPane.Click
        If toolDetailsPane.Checked Then
            ExpandPanel(splitContent)
            pnlPreview.Visible = True
            btnPreview.Text = "Hide Preview"
        Else
            pnlPreview.Visible = False
            CollapsePanel(splitContent, 2)
            btnPreview.Text = "Show Preview"
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        If historyPosition > 0 Then
            historyPosition -= 1
            NavigateTo(history(historyPosition), False)
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUp.Click
        If currentPath = "" Then Return
        Dim parent As DirectoryInfo = Directory.GetParent(currentPath)
        If parent IsNot Nothing Then NavigateTo(parent.FullName, True)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        FillFileList(txtSearch.Text.Trim())
        pnlFiles.Refresh()
        splitContent.Refresh()
        lblStatus.Text = "Refresh() updated the folder and repainted the panels."
    End Sub

    Private Sub txtAddress_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            NavigateTo(txtAddress.Text.Trim(), True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        If currentPath <> "" Then FillFileList(txtSearch.Text.Trim())
    End Sub

    Private Sub cboShowMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboShowMode.SelectedIndexChanged
        ApplyPreviewMode()
        If Me.Visible AndAlso splitContent.Panel2Collapsed Then
            ExpandPanel(splitContent)
            pnlPreview.Visible = True
            btnPreview.Text = "Hide Preview"
        End If
    End Sub

    Private Sub ApplyPreviewMode()
        Select Case cboShowMode.SelectedIndex
            Case 0
                txtPreviewDetails.Visible = True
                txtPreviewDetails.Dock = DockStyle.Fill
                pnlPreviewContent.Visible = False
                lblStatus.Text = "The right pane is showing file details."
            Case 1
                txtPreviewDetails.Visible = False
                pnlPreviewContent.Visible = True
                pnlPreviewContent.Dock = DockStyle.Fill
                lblStatus.Text = "The right pane is showing the file preview."
            Case Else
                txtPreviewDetails.Dock = DockStyle.Top
                txtPreviewDetails.Height = 112
                txtPreviewDetails.Visible = True
                pnlPreviewContent.Visible = True
                pnlPreviewContent.Dock = DockStyle.Fill
                lblStatus.Text = "The right pane is showing details and preview."
        End Select
        pnlPreview.PerformLayout()
        pnlPreview.Invalidate(True)
    End Sub

    Private Sub btnFolders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFolders.Click
        If splitMain.Panel1Collapsed Then
            ExpandPanel(splitMain)
            pnlFolders.Visible = True
            btnFolders.Text = "Hide Folders"
            lblStatus.Text = "ExpandPanel() displayed the folder panel."
        Else
            pnlFolders.Visible = False
            CollapsePanel(splitMain, 1)
            btnFolders.Text = "Show Folders"
            lblStatus.Text = "CollapsePanel() hid the folder panel."
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        If splitContent.Panel2Collapsed Then
            ExpandPanel(splitContent)
            pnlPreview.Visible = True
            btnPreview.Text = "Hide Preview"
            toolDetailsPane.Checked = True
            lblStatus.Text = "ExpandPanel() displayed the preview panel."
        Else
            pnlPreview.Visible = False
            CollapsePanel(splitContent, 2)
            btnPreview.Text = "Show Preview"
            toolDetailsPane.Checked = False
            lblStatus.Text = "CollapsePanel() hid the preview panel."
        End If
    End Sub

    Private Sub btnOrientation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOrientation.Click
        Try
            splitContent.Panel1MinSize = 60
            splitContent.Panel2MinSize = 60
            SetSafeSplitterDistance(splitContent, 180)
            If splitContent.Orientation = Orientation.Vertical Then
                splitContent.Orientation = Orientation.Horizontal
                splitContent.Panel1MinSize = 100
                splitContent.Panel2MinSize = 100
                SetSafeSplitterDistance(splitContent, CInt(splitContent.Height * 0.62))
                btnOrientation.Text = "Preview Right"
                lblStatus.Text = "Orientation changed to horizontal."
            Else
                splitContent.Orientation = Orientation.Vertical
                splitContent.Panel1MinSize = 220
                splitContent.Panel2MinSize = 180
                SetSafeSplitterDistance(splitContent, CInt(splitContent.Width * 0.64))
                btnOrientation.Text = "Preview Below"
                lblStatus.Text = "Orientation changed to vertical."
            End If
        Catch ex As Exception
            lblStatus.Text = "The preview direction could not be changed: " & ex.Message
        End Try
    End Sub

    Private Sub SetSafeSplitterDistance(ByVal target As SplitContainer, ByVal requested As Integer)
        Dim available As Integer
        If target.Orientation = Orientation.Vertical Then
            available = target.ClientSize.Width
        Else
            available = target.ClientSize.Height
        End If
        Dim lowest As Integer = target.Panel1MinSize
        Dim highest As Integer = available - target.Panel2MinSize - target.SplitterWidth
        If highest < lowest Then Return
        target.SplitterDistance = Math.Max(lowest, Math.Min(requested, highest))
    End Sub

    Private Sub btnLock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLock.Click
        splittersLocked = Not splittersLocked
        splitMain.IsSplitterFixed = splittersLocked
        splitContent.IsSplitterFixed = splittersLocked
        btnLock.Text = If(splittersLocked, "Unlock Panes", "Lock Panes")
        lblStatus.Text = "IsSplitterFixed = " & splittersLocked.ToString()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheck.Click
        Dim containsList As Boolean = pnlFiles.Contains(lvFiles)
        Dim focused As Boolean = pnlFiles.Focus()
        lblStatus.Text = "Contains(ListView) = " & containsList.ToString() & "   Focus() = " & focused.ToString()
    End Sub

    Private Sub btnRedraw_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRedraw.Click
        pnlFolders.Invalidate(True)
        pnlFiles.Invalidate(True)
        pnlPreview.Invalidate(True)
        splitMain.Invalidate(True)
        splitContent.Invalidate(True)
        lblStatus.Text = "Invalidate() requested a redraw of all panels."
    End Sub

    Private Sub CollapsePanel(ByVal target As SplitContainer, ByVal panelNumber As Integer)
        If panelNumber = 1 Then
            target.Panel1Collapsed = True
        Else
            target.Panel2Collapsed = True
        End If
    End Sub

    Private Sub ExpandPanel(ByVal target As SplitContainer)
        target.Panel1Collapsed = False
        target.Panel2Collapsed = False
    End Sub

    Private Sub splitMain_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splitMain.SplitterMoved
        lblStatus.Text = "Folder pane width: " & splitMain.SplitterDistance.ToString() & " pixels"
    End Sub

    Private Sub splitContent_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splitContent.SplitterMoved
        lblStatus.Text = "SplitterDistance: " & splitContent.SplitterDistance.ToString() & " pixels"
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If previewHost IsNot Nothing Then
                previewHost.Dispose()
                previewHost = Nothing
            End If
            splitContent.Dispose()
            splitMain.Dispose()
        Catch
        End Try
    End Sub
End Class
```

#### `Form1.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlAddress As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents toolFiles As ToolStrip
    Friend WithEvents toolNewFolder As ToolStripButton
    Friend WithEvents toolCut As ToolStripButton
    Friend WithEvents toolCopy As ToolStripButton
    Friend WithEvents toolPaste As ToolStripButton
    Friend WithEvents toolRename As ToolStripButton
    Friend WithEvents toolDelete As ToolStripButton
    Friend WithEvents toolSort As ToolStripDropDownButton
    Friend WithEvents sortName As ToolStripMenuItem
    Friend WithEvents sortDate As ToolStripMenuItem
    Friend WithEvents sortType As ToolStripMenuItem
    Friend WithEvents sortSize As ToolStripMenuItem
    Friend WithEvents toolView As ToolStripDropDownButton
    Friend WithEvents viewDetails As ToolStripMenuItem
    Friend WithEvents viewList As ToolStripMenuItem
    Friend WithEvents viewLarge As ToolStripMenuItem
    Friend WithEvents toolDetailsPane As ToolStripButton
    Friend WithEvents pnlCommands As Panel
    Friend WithEvents btnFolders As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnOrientation As Button
    Friend WithEvents btnLock As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnRedraw As Button
    Friend WithEvents lblShowMode As Label
    Friend WithEvents cboShowMode As ComboBox
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents pnlFolders As Panel
    Friend WithEvents lblFolders As Label
    Friend WithEvents tvFolders As TreeView
    Friend WithEvents splitContent As SplitContainer
    Friend WithEvents pnlFiles As Panel
    Friend WithEvents lblFiles As Label
    Friend WithEvents lvFiles As ListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colType As ColumnHeader
    Friend WithEvents colSize As ColumnHeader
    Friend WithEvents colModified As ColumnHeader
    Friend WithEvents pnlPreview As Panel
    Friend WithEvents lblPreviewTitle As Label
    Friend WithEvents txtPreviewDetails As TextBox
    Friend WithEvents pnlPreviewContent As Panel
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatus As Label

    Private Sub InitializeComponent()
        Me.pnlHeader = New Panel()
        Me.lblTitle = New Label()
        Me.pnlAddress = New Panel()
        Me.btnBack = New Button()
        Me.btnUp = New Button()
        Me.btnRefresh = New Button()
        Me.txtAddress = New TextBox()
        Me.txtSearch = New TextBox()
        Me.toolFiles = New ToolStrip()
        Me.toolNewFolder = New ToolStripButton()
        Me.toolCut = New ToolStripButton()
        Me.toolCopy = New ToolStripButton()
        Me.toolPaste = New ToolStripButton()
        Me.toolRename = New ToolStripButton()
        Me.toolDelete = New ToolStripButton()
        Me.toolSort = New ToolStripDropDownButton()
        Me.sortName = New ToolStripMenuItem()
        Me.sortDate = New ToolStripMenuItem()
        Me.sortType = New ToolStripMenuItem()
        Me.sortSize = New ToolStripMenuItem()
        Me.toolView = New ToolStripDropDownButton()
        Me.viewDetails = New ToolStripMenuItem()
        Me.viewList = New ToolStripMenuItem()
        Me.viewLarge = New ToolStripMenuItem()
        Me.toolDetailsPane = New ToolStripButton()
        Me.pnlCommands = New Panel()
        Me.btnFolders = New Button()
        Me.btnPreview = New Button()
        Me.btnOrientation = New Button()
        Me.btnLock = New Button()
        Me.btnCheck = New Button()
        Me.btnRedraw = New Button()
        Me.lblShowMode = New Label()
        Me.cboShowMode = New ComboBox()
        Me.splitMain = New SplitContainer()
        Me.pnlFolders = New Panel()
        Me.lblFolders = New Label()
        Me.tvFolders = New TreeView()
        Me.splitContent = New SplitContainer()
        Me.pnlFiles = New Panel()
        Me.lblFiles = New Label()
        Me.lvFiles = New ListView()
        Me.colName = New ColumnHeader()
        Me.colType = New ColumnHeader()
        Me.colSize = New ColumnHeader()
        Me.colModified = New ColumnHeader()
        Me.pnlPreview = New Panel()
        Me.lblPreviewTitle = New Label()
        Me.txtPreviewDetails = New TextBox()
        Me.pnlPreviewContent = New Panel()
        Me.pnlStatus = New Panel()
        Me.lblStatus = New Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlAddress.SuspendLayout()
        Me.toolFiles.SuspendLayout()
        Me.pnlCommands.SuspendLayout()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.pnlFolders.SuspendLayout()
        CType(Me.splitContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContent.Panel1.SuspendLayout()
        Me.splitContent.Panel2.SuspendLayout()
        Me.splitContent.SuspendLayout()
        Me.pnlFiles.SuspendLayout()
        Me.pnlPreview.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        Me.pnlHeader.BackColor = Color.SteelBlue
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Size = New Size(1080, 48)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 15.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(14, 9)
        Me.lblTitle.Text = "Folder Explorer"
        Me.pnlAddress.BackColor = SystemColors.Control
        Me.pnlAddress.BorderStyle = BorderStyle.FixedSingle
        Me.pnlAddress.Controls.Add(Me.btnBack)
        Me.pnlAddress.Controls.Add(Me.btnUp)
        Me.pnlAddress.Controls.Add(Me.btnRefresh)
        Me.pnlAddress.Controls.Add(Me.txtAddress)
        Me.pnlAddress.Controls.Add(Me.txtSearch)
        Me.pnlAddress.Dock = DockStyle.Top
        Me.pnlAddress.Size = New Size(1080, 42)
        Me.btnBack.Location = New Point(8, 7)
        Me.btnBack.Size = New Size(55, 27)
        Me.btnBack.Text = "Back"
        Me.btnUp.Location = New Point(68, 7)
        Me.btnUp.Size = New Size(45, 27)
        Me.btnUp.Text = "Up"
        Me.btnRefresh.Location = New Point(118, 7)
        Me.btnRefresh.Size = New Size(65, 27)
        Me.btnRefresh.Text = "Refresh"
        Me.txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.txtAddress.Location = New Point(190, 9)
        Me.txtAddress.Size = New Size(625, 20)
        Me.txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.txtSearch.Location = New Point(823, 9)
        Me.txtSearch.Size = New Size(245, 20)
        Me.toolFiles.BackColor = Color.WhiteSmoke
        Me.toolFiles.GripStyle = ToolStripGripStyle.Hidden
        Me.toolFiles.Items.AddRange(New ToolStripItem() {Me.toolNewFolder, New ToolStripSeparator(), Me.toolCut, Me.toolCopy, Me.toolPaste, New ToolStripSeparator(), Me.toolRename, Me.toolDelete, New ToolStripSeparator(), Me.toolSort, Me.toolView, New ToolStripSeparator(), Me.toolDetailsPane})
        Me.toolFiles.Dock = DockStyle.Top
        Me.toolFiles.Font = New Font("Segoe UI", 9.0!)
        Me.toolFiles.Padding = New Padding(8, 2, 0, 2)
        Me.toolFiles.Size = New Size(1080, 35)
        Me.toolNewFolder.Text = "New Folder"
        Me.toolNewFolder.ToolTipText = "Create a new folder"
        Me.toolCut.Text = "Cut"
        Me.toolCopy.Text = "Copy"
        Me.toolPaste.Text = "Paste"
        Me.toolRename.Text = "Rename"
        Me.toolDelete.Text = "Delete"
        Me.toolSort.DropDownItems.AddRange(New ToolStripItem() {Me.sortName, Me.sortDate, Me.sortType, Me.sortSize})
        Me.toolSort.Text = "Sort"
        Me.sortName.Text = "Name"
        Me.sortDate.Text = "Date modified"
        Me.sortType.Text = "Type"
        Me.sortSize.Text = "Size"
        Me.toolView.DropDownItems.AddRange(New ToolStripItem() {Me.viewDetails, Me.viewList, Me.viewLarge})
        Me.toolView.Text = "View"
        Me.viewDetails.Text = "Details"
        Me.viewList.Text = "List"
        Me.viewLarge.Text = "Large icons"
        Me.toolDetailsPane.CheckOnClick = True
        Me.toolDetailsPane.Checked = True
        Me.toolDetailsPane.Text = "Details pane"
        Me.pnlCommands.BackColor = Color.WhiteSmoke
        Me.pnlCommands.BorderStyle = BorderStyle.FixedSingle
        Me.pnlCommands.Controls.Add(Me.btnFolders)
        Me.pnlCommands.Controls.Add(Me.btnPreview)
        Me.pnlCommands.Controls.Add(Me.btnOrientation)
        Me.pnlCommands.Controls.Add(Me.btnLock)
        Me.pnlCommands.Controls.Add(Me.btnCheck)
        Me.pnlCommands.Controls.Add(Me.btnRedraw)
        Me.pnlCommands.Controls.Add(Me.lblShowMode)
        Me.pnlCommands.Controls.Add(Me.cboShowMode)
        Me.pnlCommands.Dock = DockStyle.Top
        Me.pnlCommands.Size = New Size(1080, 43)
        Me.btnFolders.Location = New Point(8, 7)
        Me.btnFolders.Size = New Size(92, 27)
        Me.btnFolders.Text = "Hide Folders"
        Me.btnPreview.Location = New Point(105, 7)
        Me.btnPreview.Size = New Size(92, 27)
        Me.btnPreview.Text = "Hide Preview"
        Me.btnOrientation.Location = New Point(202, 7)
        Me.btnOrientation.Size = New Size(118, 27)
        Me.btnOrientation.Text = "Preview Below"
        Me.btnLock.Location = New Point(325, 7)
        Me.btnLock.Size = New Size(92, 27)
        Me.btnLock.Text = "Lock Panes"
        Me.btnCheck.Location = New Point(422, 7)
        Me.btnCheck.Size = New Size(102, 27)
        Me.btnCheck.Text = "Check Layout"
        Me.btnRedraw.Location = New Point(529, 7)
        Me.btnRedraw.Size = New Size(88, 27)
        Me.btnRedraw.Text = "Redraw"
        Me.lblShowMode.AutoSize = True
        Me.lblShowMode.Location = New Point(635, 13)
        Me.lblShowMode.Text = "Show:"
        Me.cboShowMode.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboShowMode.FormattingEnabled = True
        Me.cboShowMode.Location = New Point(680, 9)
        Me.cboShowMode.Size = New Size(145, 21)
        Me.splitMain.Dock = DockStyle.Fill
        Me.splitMain.FixedPanel = FixedPanel.Panel1
        Me.splitMain.IsSplitterFixed = False
        Me.splitMain.Location = New Point(0, 133)
        Me.splitMain.Orientation = Orientation.Vertical
        Me.splitMain.Size = New Size(1080, 488)
        Me.splitMain.Panel1MinSize = 130
        Me.splitMain.Panel2MinSize = 350
        Me.splitMain.SplitterWidth = 7
        Me.splitMain.Panel1.Controls.Add(Me.pnlFolders)
        Me.splitMain.Panel2.Controls.Add(Me.splitContent)
        Me.pnlFolders.AutoScroll = True
        Me.pnlFolders.BackColor = Color.WhiteSmoke
        Me.pnlFolders.BorderStyle = BorderStyle.Fixed3D
        Me.pnlFolders.Controls.Add(Me.tvFolders)
        Me.pnlFolders.Controls.Add(Me.lblFolders)
        Me.pnlFolders.Dock = DockStyle.Fill
        Me.pnlFolders.Visible = True
        Me.lblFolders.Dock = DockStyle.Top
        Me.lblFolders.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblFolders.Padding = New Padding(8, 7, 0, 0)
        Me.lblFolders.Size = New Size(220, 34)
        Me.lblFolders.Text = "Folders"
        Me.tvFolders.BorderStyle = BorderStyle.None
        Me.tvFolders.Dock = DockStyle.Fill
        Me.tvFolders.HideSelection = False
        Me.tvFolders.Location = New Point(0, 34)
        Me.tvFolders.Name = "tvFolders"
        Me.tvFolders.Scrollable = True
        Me.splitContent.Dock = DockStyle.Fill
        Me.splitContent.FixedPanel = FixedPanel.None
        Me.splitContent.IsSplitterFixed = False
        Me.splitContent.Orientation = Orientation.Vertical
        Me.splitContent.Size = New Size(853, 488)
        Me.splitContent.Panel1MinSize = 220
        Me.splitContent.Panel2MinSize = 180
        Me.splitContent.SplitterWidth = 7
        Me.splitContent.Panel1.Controls.Add(Me.pnlFiles)
        Me.splitContent.Panel2.Controls.Add(Me.pnlPreview)
        Me.pnlFiles.AutoScroll = True
        Me.pnlFiles.BackColor = Color.White
        Me.pnlFiles.BorderStyle = BorderStyle.FixedSingle
        Me.pnlFiles.Controls.Add(Me.lvFiles)
        Me.pnlFiles.Controls.Add(Me.lblFiles)
        Me.pnlFiles.Dock = DockStyle.Fill
        Me.pnlFiles.TabStop = True
        Me.lblFiles.Dock = DockStyle.Top
        Me.lblFiles.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblFiles.Padding = New Padding(8, 7, 0, 0)
        Me.lblFiles.Size = New Size(520, 34)
        Me.lblFiles.Text = "Files"
        Me.lvFiles.Columns.AddRange(New ColumnHeader() {Me.colName, Me.colType, Me.colSize, Me.colModified})
        Me.lvFiles.Dock = DockStyle.Fill
        Me.lvFiles.FullRowSelect = True
        Me.lvFiles.GridLines = True
        Me.lvFiles.HideSelection = False
        Me.lvFiles.MultiSelect = False
        Me.lvFiles.LabelEdit = True
        Me.lvFiles.Scrollable = True
        Me.lvFiles.View = View.Details
        Me.colName.Text = "Name"
        Me.colName.Width = 220
        Me.colType.Text = "Type"
        Me.colType.Width = 110
        Me.colSize.Text = "Size"
        Me.colSize.TextAlign = HorizontalAlignment.Right
        Me.colSize.Width = 85
        Me.colModified.Text = "Date modified"
        Me.colModified.Width = 130
        Me.pnlPreview.AutoScroll = True
        Me.pnlPreview.BackColor = SystemColors.Control
        Me.pnlPreview.BorderStyle = BorderStyle.Fixed3D
        Me.pnlPreview.Controls.Add(Me.pnlPreviewContent)
        Me.pnlPreview.Controls.Add(Me.txtPreviewDetails)
        Me.pnlPreview.Controls.Add(Me.lblPreviewTitle)
        Me.pnlPreview.Dock = DockStyle.Fill
        Me.pnlPreview.Visible = True
        Me.lblPreviewTitle.Dock = DockStyle.Top
        Me.lblPreviewTitle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblPreviewTitle.Padding = New Padding(8, 7, 0, 0)
        Me.lblPreviewTitle.Size = New Size(326, 34)
        Me.lblPreviewTitle.Text = "Preview"
        Me.txtPreviewDetails.BackColor = Color.WhiteSmoke
        Me.txtPreviewDetails.BorderStyle = BorderStyle.FixedSingle
        Me.txtPreviewDetails.Dock = DockStyle.Top
        Me.txtPreviewDetails.Font = New Font("Segoe UI", 8.25!)
        Me.txtPreviewDetails.Multiline = True
        Me.txtPreviewDetails.ReadOnly = True
        Me.txtPreviewDetails.ScrollBars = ScrollBars.Vertical
        Me.txtPreviewDetails.Size = New Size(326, 112)
        Me.txtPreviewDetails.TabStop = False
        Me.txtPreviewDetails.Text = "No file selected"
        Me.pnlPreviewContent.AutoScroll = True
        Me.pnlPreviewContent.BackColor = Color.White
        Me.pnlPreviewContent.Dock = DockStyle.Fill
        Me.pnlPreviewContent.TabStop = True
        Me.pnlStatus.BackColor = SystemColors.ControlLight
        Me.pnlStatus.BorderStyle = BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = DockStyle.Bottom
        Me.pnlStatus.Size = New Size(1080, 29)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New Point(9, 7)
        Me.lblStatus.Text = "Ready"
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1080, 650)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlCommands)
        Me.Controls.Add(Me.toolFiles)
        Me.Controls.Add(Me.pnlAddress)
        Me.Controls.Add(Me.pnlHeader)
        Me.MinimumSize = New Size(760, 500)
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Folder Explorer - Panel and SplitPanel Demo"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlAddress.ResumeLayout(False)
        Me.pnlAddress.PerformLayout()
        Me.toolFiles.ResumeLayout(False)
        Me.toolFiles.PerformLayout()
        Me.pnlCommands.ResumeLayout(False)
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        Me.pnlFolders.ResumeLayout(False)
        Me.splitContent.Panel1.ResumeLayout(False)
        Me.splitContent.Panel2.ResumeLayout(False)
        CType(Me.splitContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContent.ResumeLayout(False)
        Me.pnlFiles.ResumeLayout(False)
        Me.pnlPreview.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
End Class
```

#### `PreviewEngine.vb`
```vbnet
Option Strict Off
Option Explicit On
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Public Module PreviewEngine
#Region "Word"
    Public Function GetDocxText(ByVal file As String) As String
        Try
            Using pkg As Packaging.Package = Packaging.Package.Open(file, FileMode.Open, FileAccess.Read)
                Dim uri As New Uri("/word/document.xml", UriKind.Relative)
                If Not pkg.PartExists(uri) Then Return "(No readable document part inside this file.)"
                Dim xml As String
                Using sr As New StreamReader(pkg.GetPart(uri).GetStream())
                    xml = sr.ReadToEnd()
                End Using
                xml = xml.Replace("<w:br/>", vbCrLf).Replace("<w:br />", vbCrLf)
                xml = xml.Replace("<w:tab/>", vbTab).Replace("<w:tab />", vbTab)
                xml = xml.Replace("</w:p>", vbCrLf)
                xml = xml.Replace("</w:tc>", vbTab)
                xml = xml.Replace("</w:tr>", vbCrLf)
                Return CleanXmlText(xml)
            End Using
        Catch ex As Exception
            Return "Cannot read this Word document." & vbCrLf & ex.Message
        End Try
    End Function
#End Region
#Region "Excel"
    Public Function GetXlsxText(ByVal file As String) As String
        Try
            Using pkg As Packaging.Package = Packaging.Package.Open(file, FileMode.Open, FileAccess.Read)
                Dim shared_ As New List(Of String)
                Dim ssUri As New Uri("/xl/sharedStrings.xml", UriKind.Relative)
                If pkg.PartExists(ssUri) Then
                    Dim xml As String
                    Using sr As New StreamReader(pkg.GetPart(ssUri).GetStream())
                        xml = sr.ReadToEnd()
                    End Using
                    For Each m As Match In Regex.Matches(xml, "<si>(.*?)</si>", RegexOptions.Singleline)
                        shared_.Add(CleanXmlText(m.Groups(1).Value).Replace(vbCrLf, " ").Trim())
                    Next
                End If
                Dim sb As New StringBuilder()
                Dim sheet As Integer = 0
                For Each part As Packaging.PackagePart In pkg.GetParts()
                    If Not part.Uri.ToString().StartsWith("/xl/worksheets/sheet") Then Continue For
                    sheet += 1
                    sb.AppendLine("=== Sheet " & sheet & " (" & IO.Path.GetFileName(part.Uri.ToString()) & ") ===")
                    sb.AppendLine()
                    Dim xml As String
                    Using sr As New StreamReader(part.GetStream())
                        xml = sr.ReadToEnd()
                    End Using
                    Dim rows As Integer = 0
                    For Each rm As Match In Regex.Matches(xml, "<row[^>]*>(.*?)</row>", RegexOptions.Singleline)
                        Dim line As New StringBuilder()
                        For Each cm As Match In Regex.Matches(rm.Groups(1).Value, "<c([^>]*)>(.*?)</c>", RegexOptions.Singleline)
                            Dim attrs As String = cm.Groups(1).Value
                            Dim inner As String = cm.Groups(2).Value
                            Dim vm As Match = Regex.Match(inner, "<v>(.*?)</v>", RegexOptions.Singleline)
                            Dim val As String = ""
                            If vm.Success Then
                                val = vm.Groups(1).Value
                                If attrs.Contains("t=""s""") Then
                                    Dim idx As Integer
                                    If Integer.TryParse(val, idx) AndAlso idx >= 0 AndAlso idx < shared_.Count Then
                                        val = shared_(idx)
                                    End If
                                End If
                            Else
                                val = CleanXmlText(inner).Trim()
                            End If
                            line.Append(PadCell(val))
                        Next
                        If line.ToString().Trim() <> "" Then
                            sb.AppendLine(line.ToString().TrimEnd())
                            rows += 1
                        End If
                        If rows >= 400 Then
                            sb.AppendLine("... (only the first 400 rows are previewed) ...")
                            Exit For
                        End If
                    Next
                    sb.AppendLine()
                Next
                If sb.Length = 0 Then Return "(This workbook has no readable sheet.)"
                Return sb.ToString()
            End Using
        Catch ex As Exception
            Return "Cannot read this Excel workbook." & vbCrLf & ex.Message
        End Try
    End Function
    Private Function PadCell(ByVal v As String) As String
        If v Is Nothing Then v = ""
        If v.Length > 16 Then v = v.Substring(0, 15) & Chr(133)
        Return v.PadRight(18)
    End Function
#End Region
#Region "PowerPoint"
    Public Function GetPptxText(ByVal file As String) As String
        Try
            Using pkg As Packaging.Package = Packaging.Package.Open(file, FileMode.Open, FileAccess.Read)
                Dim slides As New List(Of String)
                For Each part As Packaging.PackagePart In pkg.GetParts()
                    Dim u As String = part.Uri.ToString()
                    If Regex.IsMatch(u, "^/ppt/slides/slide\d+\.xml$") Then slides.Add(u)
                Next
                slides.Sort(New SlideComparer())
                Dim sb As New StringBuilder()
                Dim n As Integer = 0
                For Each u As String In slides
                    n += 1
                    Dim xml As String
                    Using sr As New StreamReader(pkg.GetPart(New Uri(u, UriKind.Relative)).GetStream())
                        xml = sr.ReadToEnd()
                    End Using
                    xml = xml.Replace("</a:p>", vbCrLf).Replace("<a:br/>", vbCrLf)
                    sb.AppendLine("----- Slide " & n & " -----")
                    sb.AppendLine(CleanXmlText(xml).Trim())
                    sb.AppendLine()
                Next
                If n = 0 Then Return "(No slides found in this presentation.)"
                Return sb.ToString()
            End Using
        Catch ex As Exception
            Return "Cannot read this PowerPoint file." & vbCrLf & ex.Message
        End Try
    End Function
    Private Class SlideComparer
        Implements IComparer(Of String)
        Public Function Compare(ByVal a As String, ByVal b As String) As Integer _
                Implements IComparer(Of String).Compare
            Return Num(a).CompareTo(Num(b))
        End Function
        Private Function Num(ByVal s As String) As Integer
            Dim m As Match = Regex.Match(s, "(\d+)")
            If m.Success Then Return CInt(m.Groups(1).Value)
            Return 0
        End Function
    End Class
#End Region
#Region "Legacy Office (.doc .xls .ppt) - late bound automation + fallback"
    Public Function GetLegacyOfficeText(ByVal file As String) As String
        Dim ext As String = IO.Path.GetExtension(file).ToLowerInvariant()
        Dim app As Object = Nothing
        Try
            Select Case ext
                Case ".doc", ".dot", ".rtf"
                    app = CreateObject("Word.Application")
                    app.Visible = False
                    Dim doc As Object = app.Documents.Open(file, , True)
                    Dim t As String = doc.Content.Text
                    doc.Close(False)
                    Return t
                Case ".xls", ".xlsm", ".xlsb"
                    app = CreateObject("Excel.Application")
                    app.Visible = False
                    Dim wb As Object = app.Workbooks.Open(file, , True)
                    Dim sb As New StringBuilder()
                    For s As Integer = 1 To wb.Sheets.Count
                        Dim ws As Object = wb.Sheets(s)
                        sb.AppendLine("=== " & ws.Name & " ===")
                        Dim used As Object = ws.UsedRange
                        Dim rows As Integer = Math.Min(CInt(used.Rows.Count), 200)
                        Dim cols As Integer = Math.Min(CInt(used.Columns.Count), 20)
                        For r As Integer = 1 To rows
                            Dim line As New StringBuilder()
                            For c As Integer = 1 To cols
                                Dim v As Object = used.Cells(r, c).Text
                                line.Append(PadCell(CStr(v)))
                            Next
                            sb.AppendLine(line.ToString().TrimEnd())
                        Next
                        sb.AppendLine()
                    Next
                    wb.Close(False)
                    Return sb.ToString()
                Case ".ppt"
                    app = CreateObject("PowerPoint.Application")
                    Dim pres As Object = app.Presentations.Open(file, True, False, False)
                    Dim sb As New StringBuilder()
                    For i As Integer = 1 To pres.Slides.Count
                        sb.AppendLine("----- Slide " & i & " -----")
                        For Each shp As Object In pres.Slides(i).Shapes
                            Try
                                If shp.HasTextFrame Then
                                    If shp.TextFrame.HasText Then sb.AppendLine(shp.TextFrame.TextRange.Text)
                                End If
                            Catch
                            End Try
                        Next
                        sb.AppendLine()
                    Next
                    pres.Close()
                    Return sb.ToString()
            End Select
        Catch
            Return Nothing
        Finally
            Try
                If app IsNot Nothing Then
                    app.Quit()
                    Runtime.InteropServices.Marshal.ReleaseComObject(app)
                End If
            Catch
            End Try
        End Try
        Return Nothing
    End Function
    Public Function ScrapeText(ByVal file As String, ByVal maxBytes As Integer) As String
        Dim buf() As Byte
        Using fs As New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim take As Integer = CInt(Math.Min(fs.Length, maxBytes))
            ReDim buf(Math.Max(take - 1, 0))
            fs.Read(buf, 0, take)
        End Using
        Dim sb As New StringBuilder()
        Dim run As New StringBuilder()
        Dim i As Integer = 0
        While i < buf.Length
            Dim b As Byte = buf(i)
            Dim isUni As Boolean = (i + 1 < buf.Length AndAlso buf(i + 1) = 0 AndAlso b >= 32 AndAlso b <= 126)
            If b >= 32 AndAlso b <= 126 Then
                run.Append(Chr(b))
                i += IIf(isUni, 2, 1)
            ElseIf b = 13 OrElse b = 10 Then
                run.Append(vbLf) : i += 1
            Else
                If run.Length >= 4 Then sb.AppendLine(run.ToString().Trim())
                run.Length = 0
                i += 1
            End If
        End While
        If run.Length >= 4 Then sb.AppendLine(run.ToString().Trim())
        Dim res As String = Regex.Replace(sb.ToString(), "(\r?\n){3,}", vbCrLf & vbCrLf)
        If res.Trim() = "" Then Return "(No readable text found in this file.)"
        Return res
    End Function
#End Region
#Region "PDF"
    Public Function GetPdfText(ByVal file As String) As String
        Try
            Dim data As Byte() = IO.File.ReadAllBytes(file)
            Dim latin As Encoding = Encoding.GetEncoding(28591)
            Dim raw As String = latin.GetString(data)
            If raw.IndexOf("/Encrypt") >= 0 Then
                Return "This PDF is encrypted / password protected, text cannot be previewed."
            End If
            Dim text As New StringBuilder()
            Dim pos As Integer = 0
            Dim streams As Integer = 0
            While True
                Dim s As Integer = raw.IndexOf("stream", pos, StringComparison.Ordinal)
                If s < 0 Then Exit While
                Dim e As Integer = raw.IndexOf("endstream", s, StringComparison.Ordinal)
                If e < 0 Then Exit While
                Dim start As Integer = s + 6
                If start < raw.Length AndAlso raw(start) = vbCr Then start += 1
                If start < raw.Length AndAlso raw(start) = vbLf Then start += 1
                Dim len As Integer = e - start
                If len > 0 Then
                    Dim chunk(len - 1) As Byte
                    Array.Copy(data, start, chunk, 0, len)
                    Dim plain As String = Inflate(chunk)
                    If plain IsNot Nothing Then
                        text.Append(ExtractPdfOperators(plain))
                        streams += 1
                    End If
                End If
                pos = e + 9
                If streams > 400 Then Exit While
            End While
            Dim result As String = text.ToString()
            result = Regex.Replace(result, "[ \t]{2,}", " ")
            result = Regex.Replace(result, "(\r?\n){3,}", vbCrLf & vbCrLf)
            If result.Trim() = "" Then
                Return "No extractable text in this PDF (it is probably a scanned image)." & vbCrLf & _
                       "Double-click the file to open it in your PDF reader."
            End If
            Return result.Trim()
        Catch ex As Exception
            Return "Cannot read this PDF." & vbCrLf & ex.Message
        End Try
    End Function
    Private Function Inflate(ByVal data As Byte()) As String
        Try
            If data.Length < 3 Then Return Nothing
            Dim skip As Integer = 0
            If data(0) = &H78 Then skip = 2
            Using ms As New MemoryStream(data, skip, data.Length - skip)
                Using ds As New DeflateStream(ms, CompressionMode.Decompress)
                    Using outMs As New MemoryStream()
                        Dim buf(8191) As Byte
                        Dim n As Integer = ds.Read(buf, 0, buf.Length)
                        While n > 0
                            outMs.Write(buf, 0, n)
                            If outMs.Length > 4 * 1024 * 1024 Then Exit While
                            n = ds.Read(buf, 0, buf.Length)
                        End While
                        Return Encoding.GetEncoding(28591).GetString(outMs.ToArray())
                    End Using
                End Using
            End Using
        Catch
            Return Nothing
        End Try
    End Function
    Private Function ExtractPdfOperators(ByVal content As String) As String
        Dim sb As New StringBuilder()
        For Each m As Match In Regex.Matches(content, "\((?:\\.|[^\\()])*\)\s*(Tj|TJ|')|\[(?:[^\[\]]*)\]\s*TJ", _
                                             RegexOptions.Singleline)
            Dim piece As String = m.Value
            For Each sm As Match In Regex.Matches(piece, "\((?:\\.|[^\\()])*\)", RegexOptions.Singleline)
                Dim t As String = sm.Value.Substring(1, sm.Value.Length - 2)
                t = t.Replace("\(", "(").Replace("\)", ")").Replace("\\", "\")
                t = t.Replace("\n", vbLf).Replace("\r", vbCr).Replace("\t", vbTab)
                sb.Append(t)
            Next
            If piece.TrimEnd().EndsWith("'") OrElse piece.TrimEnd().EndsWith("TJ") Then sb.Append(" ")
        Next
        If Regex.IsMatch(content, "\bTD\b|\bTd\b|\bT\*\b") Then sb.AppendLine()
        Return sb.ToString()
    End Function
#End Region
#Region "ZIP archives"
    Public Function GetZipListing(ByVal file As String) As String
        Try
            Dim d As Byte() = IO.File.ReadAllBytes(file)
            Dim eocd As Integer = -1
            For i As Integer = d.Length - 22 To Math.Max(0, d.Length - 65557) Step -1
                If i < 0 Then Exit For
                If d(i) = &H50 AndAlso d(i + 1) = &H4B AndAlso d(i + 2) = 5 AndAlso d(i + 3) = 6 Then
                    eocd = i : Exit For
                End If
            Next
            If eocd < 0 Then Return "(Not a readable ZIP archive.)"
            Dim count As Integer = BitConverter.ToUInt16(d, eocd + 10)
            Dim cdOff As Integer = CInt(BitConverter.ToUInt32(d, eocd + 16))
            Dim sb As New StringBuilder()
            sb.AppendLine("Archive contents - " & count & " entries")
            sb.AppendLine(New String("-"c, 70))
            sb.AppendLine("Size".PadLeft(12) & "  " & "Packed".PadLeft(12) & "  Name")
            Dim p As Integer = cdOff
            Dim shown As Integer = 0
            While shown < count AndAlso p + 46 <= d.Length
                If Not (d(p) = &H50 AndAlso d(p + 1) = &H4B AndAlso d(p + 2) = 1 AndAlso d(p + 3) = 2) Then Exit While
                Dim comp As UInteger = BitConverter.ToUInt32(d, p + 20)
                Dim uncomp As UInteger = BitConverter.ToUInt32(d, p + 24)
                Dim nameLen As Integer = BitConverter.ToUInt16(d, p + 28)
                Dim extraLen As Integer = BitConverter.ToUInt16(d, p + 30)
                Dim cmtLen As Integer = BitConverter.ToUInt16(d, p + 32)
                Dim name As String = Encoding.UTF8.GetString(d, p + 46, nameLen)
                sb.AppendLine(Format(uncomp, "#,##0").PadLeft(12) & "  " & _
                              Format(comp, "#,##0").PadLeft(12) & "  " & name)
                p += 46 + nameLen + extraLen + cmtLen
                shown += 1
                If shown >= 500 Then
                    sb.AppendLine("... (only the first 500 entries are listed) ...")
                    Exit While
                End If
            End While
            Return sb.ToString()
        Catch ex As Exception
            Return "Cannot read this archive." & vbCrLf & ex.Message
        End Try
    End Function
#End Region
#Region "Helpers"
    Public Function CleanXmlText(ByVal xml As String) As String
        Dim t As String = Regex.Replace(xml, "<[^>]+>", "")
        t = t.Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">")
        t = t.Replace("&quot;", """").Replace("&apos;", "'").Replace("&#10;", vbCrLf)
        t = Regex.Replace(t, "(\r?\n){3,}", vbCrLf & vbCrLf)
        Return t
    End Function
    Public Function FormatDelimited(ByVal text As String, ByVal sep As Char) As String
        Dim lines() As String = text.Replace(vbCrLf, vbLf).Split(CChar(vbLf))
        Dim sb As New StringBuilder()
        Dim max As Integer = Math.Min(lines.Length, 500)
        For i As Integer = 0 To max - 1
            Dim cells() As String = lines(i).Split(sep)
            Dim line As New StringBuilder()
            For Each c As String In cells
                line.Append(PadCell(c.Trim(""""c)))
            Next
            sb.AppendLine(line.ToString().TrimEnd())
            If i = 0 Then sb.AppendLine(New String("-"c, Math.Min(line.Length, 100)))
        Next
        If lines.Length > max Then sb.AppendLine("... (" & (lines.Length - max) & " more rows) ...")
        Return sb.ToString()
    End Function
    Public Function GetVersionText(ByVal file As String) As String
        Try
            Dim fv As FileVersionInfo = FileVersionInfo.GetVersionInfo(file)
            Dim sb As New StringBuilder()
            sb.AppendLine("Program information")
            sb.AppendLine(New String("-"c, 40))
            sb.AppendLine("Product name   : " & fv.ProductName)
            sb.AppendLine("Description    : " & fv.FileDescription)
            sb.AppendLine("Company        : " & fv.CompanyName)
            sb.AppendLine("File version   : " & fv.FileVersion)
            sb.AppendLine("Product version: " & fv.ProductVersion)
            sb.AppendLine("Copyright      : " & fv.LegalCopyright)
            sb.AppendLine("Language       : " & fv.Language)
            Return sb.ToString()
        Catch ex As Exception
            Return "No version information available."
        End Try
    End Function
    Public Function GetMediaText(ByVal file As String) As String
        Dim fi As New FileInfo(file)
        Dim sb As New StringBuilder()
        sb.AppendLine("Media file")
        sb.AppendLine(New String("-"c, 40))
        sb.AppendLine("Name     : " & fi.Name)
        sb.AppendLine("Type     : " & IO.Path.GetExtension(file).ToUpperInvariant() & " file")
        sb.AppendLine("Size     : " & Format(fi.Length / 1048576.0, "#,##0.00") & " MB")
        sb.AppendLine("Created  : " & fi.CreationTime.ToString("g"))
        sb.AppendLine("Modified : " & fi.LastWriteTime.ToString("g"))
        sb.AppendLine()
        sb.AppendLine("Double-click the file to play it in your default player.")
        Return sb.ToString()
    End Function
#End Region
End Module
```

### 3. Sample Run
![Figure 12.1 — Sample Run of Folder Explorer Showing TreeView, File ListView, and Live Code/Metadata Preview](docs/images/act12_run.png)
*Figure 12.1 — Sample Run of Folder Explorer Showing TreeView, File ListView, and Live Code/Metadata Preview*

**Sample Run Walkthrough:**
- Left pane (tvFolders) displays quick-access nodes (Desktop, Documents, Pictures, Computer + Drives) with lazy directory expansion.
- Middle pane (lvFiles) lists folders and files with Name, Type, formatted Size (bytes/KB/MB/GB), and Date modified, filtered in real time by txtSearch.
- Top ToolStrip provides full file management: New Folder, Cut, Copy, Paste (with recursive directory copy and self-paste protection), inline Rename (LabelEdit), Delete, Sort (by Name/Date/Type/Size), and View mode switching.
- Right pane (pnlPreview) uses PreviewEngine.vb to display file metadata and live content previews for images, RTF, HTML/SVG, Word (.docx), Excel (.xlsx), PowerPoint (.pptx), PDF streams, ZIP archives, EXEs/DLLs (version info + hex dump), media files, and source code.

### 4. Form Design
![Figure 12.2 — Visual Studio Form Design of Folder Explorer (1080 × 650 px)](docs/images/act12_design.png)
*Figure 12.2 — Visual Studio Form Design of Folder Explorer (1080 × 650 px)*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `pnlHeader, lblTitle` | Panel, Label | `"Folder Explorer"` | Top SteelBlue banner (1080 × 48) |
| `pnlAddress` | Panel | `Back, Up, Refresh, txtAddress, txtSearch` | Navigation history bar, path textbox, and live search filter |
| `toolFiles` | ToolStrip | `New Folder, Cut, Copy, Paste, Rename, Delete, Sort, View, Details pane` | File operations toolbar |
| `pnlCommands` | Panel | `Hide Folders, Hide Preview, Preview Below, Lock Panes, Check Layout, Redraw, Show:` | Panel & SplitContainer control bar |
| `splitMain, splitContent` | SplitContainer | `Outer & Inner SplitContainers` | Divides Folders pane (left), Files pane (center), and Preview pane (right/bottom) |
| `tvFolders, lvFiles` | TreeView, ListView | `Folder Tree & File List` | Synchronized directory navigation and sortable file table |
| `pnlPreview, PreviewEngine` | Panel, Module | `txtPreviewDetails & pnlPreviewContent` | Renders rich previews across 30+ document, image, archive, binary, and code formats |

### 5. Brief Description
Activity 12 (FileExplorerClone / PanelSplitDemo) is a comprehensive Windows Explorer clone built around nested SplitContainers, Panels, TreeView, ListView, and a custom PreviewEngine module. It supports browsing with Back/Up history, live filename filtering, clipboard Cut/Copy/Paste for both files and directories, inline renaming, multi-criteria sorting, dynamic layout reconfiguration (collapsing panes, locking splitters, toggling horizontal/vertical preview orientation), and built-in content inspection for Office OpenXML (.docx, .xlsx, .pptx), PDFs, ZIP packages, images, RTF/HTML, executables, and source code.

---

## Activity 13: Integrative Programming Project 2026 — MDI Information Management System (IntegProgProject2026)

### 1. Activity Title
- **Activity Title:** Activity 13: Integrative Programming Project 2026 — MDI Information Management System (IntegProgProject2026)
- **Project Folder / Solution:** `IntegProgProject2026` (`IntegProgProject2026.sln`)
- **Application Type:** VB.NET Windows Forms MDI Application (.NET Framework 4.0)
- **Date:** October 25, 2026
- **Author:** Rex M. Alvarez (BSIT 3B)

### 2. Source Code
#### `Forms/frmMain.vb`
```vbnet
Public Class frmMain

    Private Sub LogLine(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            toolstripUserInfo.Text = "UserInfo: Rex M. Alvarez  |  BSIT 3B"
            UpdateDateTime()
            Timer1.Interval = 1000
            Timer1.Start()
            lblStatusBar.Text = "Choose a form from the menu."
            LogLine("main form loaded")
        Catch ex As Exception
            LogLine("main load failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            UpdateDateTime()
        Catch
        End Try
    End Sub

    Private Sub UpdateDateTime()
        toolstripCurrentDate.Text = "CurrentDate: " & Date.Now.ToString("dddd, d MMMM yyyy")
        toolstripCurrentTime.Text = "Current Time: " & Date.Now.ToString("h:mm:ss tt")
    End Sub

    Private Sub SchedulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulesToolStripMenuItem.Click
        ShowChild(GetType(frmSchedules))
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ShowChild(GetType(frmAbout))
    End Sub

    Private Sub QuotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotesToolStripMenuItem.Click
        ShowChild(GetType(frmQuotes))
    End Sub

    Private Sub BibleVerseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BibleVerseToolStripMenuItem.Click
        ShowChild(GetType(frmBibleVerses))
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ShowChild(ByVal formType As Type)
        LogLine("opening " & formType.Name)
        Try
            For Each openForm As Form In Me.MdiChildren
                If openForm.GetType() Is formType Then
                    openForm.Activate()
                    lblStatusBar.Text = "Form: " & openForm.Text
                    LogLine(formType.Name & " already open - activated")
                    Return
                End If
            Next
            Dim child As Form = CType(Activator.CreateInstance(formType), Form)
            child.MdiParent = Me
            child.Show()
            child.WindowState = FormWindowState.Maximized
            lblStatusBar.Text = "Form: " & child.Text
            LogLine(formType.Name & " shown inside main form, Visible=" & child.Visible.ToString())
        Catch ex As Exception
            LogLine(formType.Name & " FAILED: " & ex.GetType().Name & " - " & ex.Message)
            Try
                MessageBox.Show("The form could not be opened." & vbCrLf & vbCrLf & _
                    "Form: " & formType.Name & vbCrLf & vbCrLf & _
                    "Details: " & ex.Message, "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch
            End Try
        End Try
    End Sub

End Class
```

#### `Forms/frmMain.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SchedulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibleVerseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolstripUserInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripCurrentDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripCurrentTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchedulesToolStripMenuItem, Me.AboutToolStripMenuItem, Me.QuotesToolStripMenuItem, Me.BibleVerseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.SchedulesToolStripMenuItem.Name = "SchedulesToolStripMenuItem"
        Me.SchedulesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SchedulesToolStripMenuItem.Text = "Schedules"
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.QuotesToolStripMenuItem.Name = "QuotesToolStripMenuItem"
        Me.QuotesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuotesToolStripMenuItem.Text = "Quotes"
        Me.BibleVerseToolStripMenuItem.Name = "BibleVerseToolStripMenuItem"
        Me.BibleVerseToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.BibleVerseToolStripMenuItem.Text = "BibleVerse"
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripUserInfo, Me.toolstripCurrentDate, Me.toolstripCurrentTime, Me.lblStatusBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 546)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.toolstripUserInfo.Name = "toolstripUserInfo"
        Me.toolstripUserInfo.Size = New System.Drawing.Size(60, 17)
        Me.toolstripUserInfo.Text = "UserInfo"
        Me.toolstripCurrentDate.Name = "toolstripCurrentDate"
        Me.toolstripCurrentDate.Size = New System.Drawing.Size(76, 17)
        Me.toolstripCurrentDate.Text = "CurrentDate"
        Me.toolstripCurrentTime.Name = "toolstripCurrentTime"
        Me.toolstripCurrentTime.Size = New System.Drawing.Size(80, 17)
        Me.toolstripCurrentTime.Text = "Current Time"
        Me.lblStatusBar.Name = "lblStatusBar"
        Me.lblStatusBar.Size = New System.Drawing.Size(40, 17)
        Me.lblStatusBar.Text = "Ready"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 568)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SchedulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BibleVerseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents toolstripUserInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripCurrentDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripCurrentTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
```

#### `Forms/frmSchedules.vb`
```vbnet
Imports System.Data.OleDb

Public Class frmSchedules

    Private selectedId As Integer = 0
    Private isLoading As Boolean = False
    Private store As DataTable
    Private nextId As Integer = 1

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmSchedules] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Function XmlPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.xml")
    End Function

    Private Function SdfPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.sdf")
    End Function

    Private Function HasSqlCe() As Boolean
        Try
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
        Catch
        End Try
        Return False
    End Function

    Private Sub frmSchedules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogStep("Load")
        Try
            SetupStore()
        Catch ex As Exception
            LogStep("SetupStore failed: " & ex.Message)
        End Try
        Try
            ClearFields()
        Catch
        End Try
        RefreshGrid()
    End Sub

    Private Sub SetupStore()
        store = New DataTable("Schedules")
        store.Columns.Add("ScheduleID", GetType(Integer))
        store.Columns.Add("CourseID", GetType(String))
        store.Columns.Add("TeacherID", GetType(String))
        store.Columns.Add("Day", GetType(String))
        store.Columns.Add("Time", GetType(String))
        store.Columns.Add("Room", GetType(String))
        If IO.File.Exists(XmlPath()) Then
            Try
                store.ReadXml(XmlPath())
                LogStep("loaded rows from xml: " & store.Rows.Count.ToString())
            Catch ex As Exception
                LogStep("xml unreadable, reseeding: " & ex.Message)
                store.Clear()
            End Try
        End If
        If store.Rows.Count = 0 Then
            SeedSampleData()
            SaveStore()
            LogStep("seeded sample data")
        End If
        nextId = 1
        For Each row As DataRow In store.Rows
            Dim id As Integer = Convert.ToInt32(row.Item("ScheduleID"))
            If id >= nextId Then nextId = id + 1
        Next
        lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
    End Sub

    Private Sub SaveStore()
        Try
            store.AcceptChanges()
            store.WriteXml(XmlPath())
        Catch ex As Exception
            LogStep("WriteXml failed: " & ex.Message)
        End Try
        SyncToSdf()
    End Sub

    Private Sub SyncToSdf()
        If Not HasSqlCe() Then Return
        Try
            If Not IO.File.Exists(SdfPath()) Then
                Dim catalog As Object = CreateObject("ADOX.Catalog")
                catalog.Create("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath())
                catalog = Nothing
            End If
            Using conn As New OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath() & ";Persist Security Info=False;")
                conn.Open()
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [Schedules]", conn)
                    cmd.ExecuteScalar()
                End Using
                Using cmd As New OleDbCommand("DELETE FROM [Schedules]", conn)
                    cmd.ExecuteNonQuery()
                End Using
                For Each row As DataRow In store.Rows
                    Using cmd As New OleDbCommand("INSERT INTO [Schedules] ([CourseID], [TeacherID], [Day], [Time], [Room]) VALUES (?, ?, ?, ?, ?)", conn)
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("CourseID")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("TeacherID")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Day")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Time")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Room")))
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            LogStep("sdf mirror skipped: " & ex.Message)
        End Try
    End Sub

    Private Sub SeedSampleData()
        Dim rows As String() = New String() { _
            "IT301|T-005|Monday|07:30|Room 205", _
            "IT302|T-006|Monday|11:00|Lab 3", _
            "CS201|T-007|Tuesday|09:30|Room 206", _
            "IT303|T-005|Wednesday|08:00|Lab 4", _
            "CS202|T-006|Thursday|13:30|Room 207", _
            "IT304|T-007|Friday|10:00|Room 208", _
            "CS203|T-005|Saturday|09:00|Lab 5"
            }
        For Each line As String In rows
            Dim parts As String() = line.Split("|"c)
            If parts.Length = 5 Then
                Dim row As DataRow = store.NewRow()
                row.Item("ScheduleID") = nextId
                row.Item("CourseID") = parts(0)
                row.Item("TeacherID") = parts(1)
                row.Item("Day") = parts(2)
                row.Item("Time") = parts(3)
                row.Item("Room") = parts(4)
                store.Rows.Add(row)
                nextId += 1
            End If
        Next
    End Sub

    Private Sub RefreshGrid()
        Try
            If store Is Nothing Then Return
            Dim view As New DataTable("Schedules")
            view = store.Copy()
            dataGridView1.DataSource = view
            FormatGrid()
            lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
        Catch ex As Exception
            LogStep("RefreshGrid failed: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dataGridView1.Columns.Count = 0 Then Return
        With dataGridView1
            .Columns("ScheduleID").HeaderText = "ID"
            .Columns("CourseID").HeaderText = "Course ID"
            .Columns("TeacherID").HeaderText = "Teacher ID"
            .Columns("Day").HeaderText = "Day"
            .Columns("Time").HeaderText = "Time"
            .Columns("Room").HeaderText = "Room"
        End With
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try
            If Not IsValidInput() Then Return
            Dim row As DataRow = store.NewRow()
            row.Item("ScheduleID") = nextId
            row.Item("CourseID") = txtCourseID.Text.Trim()
            row.Item("TeacherID") = txtTeacherID.Text.Trim()
            row.Item("Day") = cboDay.Text.Trim()
            row.Item("Time") = dtpTime.Value.ToString("HH:mm")
            row.Item("Room") = txtRoom.Text.Trim()
            store.Rows.Add(row)
            nextId += 1
            SaveStore()
            MessageBox.Show("The record was saved." & vbCrLf & vbCrLf & "New ID: " & (nextId - 1).ToString(), _
                "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Add failed: " & ex.Message)
            MessageBox.Show("The record could not be saved." & vbCrLf & vbCrLf & ex.Message, _
                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If Not IsValidInput() Then Return
            Dim found As DataRow = Nothing
            For Each row As DataRow In store.Rows
                If Convert.ToInt32(row.Item("ScheduleID")) = selectedId Then
                    found = row
                    Exit For
                End If
            Next
            If found Is Nothing Then
                MessageBox.Show("That record no longer exists.", "Record Not Found", _
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RefreshGrid()
                Return
            End If
            found.Item("CourseID") = txtCourseID.Text.Trim()
            found.Item("TeacherID") = txtTeacherID.Text.Trim()
            found.Item("Day") = cboDay.Text.Trim()
            found.Item("Time") = dtpTime.Value.ToString("HH:mm")
            found.Item("Room") = txtRoom.Text.Trim()
            SaveStore()
            MessageBox.Show("The record was updated.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Update failed: " & ex.Message)
            MessageBox.Show("The record could not be updated." & vbCrLf & vbCrLf & ex.Message, _
                "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If MessageBox.Show("Delete this record?" & vbCrLf & vbCrLf & "ID: " & selectedId.ToString(), _
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If
            For i As Integer = store.Rows.Count - 1 To 0 Step -1
                If Convert.ToInt32(store.Rows(i).Item("ScheduleID")) = selectedId Then
                    store.Rows.RemoveAt(i)
                End If
            Next
            SaveStore()
            MessageBox.Show("The record was deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Delete failed: " & ex.Message)
            MessageBox.Show("The record could not be deleted." & vbCrLf & vbCrLf & ex.Message, _
                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ClearFields()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGridView1.SelectionChanged
        If isLoading Then Return
        If dataGridView1.CurrentRow Is Nothing Then Return
        FillFromRow()
    End Sub

    Private Sub FillFromRow()
        Dim row As DataGridViewRow = dataGridView1.CurrentRow
        If row Is Nothing Then Return
        If row.Cells("ScheduleID").Value Is Nothing Then Return
        If row.Cells("ScheduleID").Value Is DBNull.Value Then Return
        isLoading = True
        Try
            selectedId = Convert.ToInt32(row.Cells("ScheduleID").Value)
            txtScheduleID.Text = selectedId.ToString()
            txtCourseID.Text = Convert.ToString(row.Cells("CourseID").Value)
            txtTeacherID.Text = Convert.ToString(row.Cells("TeacherID").Value)
            cboDay.Text = Convert.ToString(row.Cells("Day").Value)
            Dim TimeText As String = Convert.ToString(row.Cells("Time").Value)
            Dim TimeParsed As Date
            If Date.TryParse(DateTime.Today.ToShortDateString() & " " & TimeText, TimeParsed) Then
                dtpTime.Value = TimeParsed
            End If
            txtRoom.Text = Convert.ToString(row.Cells("Room").Value)
        Catch ex As Exception
            LogStep("FillFromRow failed: " & ex.Message)
        Finally
            isLoading = False
        End Try
    End Sub

    Private Sub ClearFields()
        isLoading = True
        Try
            dataGridView1.CurrentCell = Nothing
        Catch
        End Try
        selectedId = 0
        txtScheduleID.Clear()
        txtCourseID.Clear()
        txtTeacherID.Clear()
        cboDay.SelectedIndex = -1
        dtpTime.Value = DateTime.Today.AddHours(8)
        txtRoom.Clear()
        txtCourseID.Focus()
        isLoading = False
    End Sub

    Private Function IsValidInput() As Boolean
        If txtCourseID.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Course ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCourseID.Focus()
            Return False
        End If
        If txtTeacherID.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Teacher ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTeacherID.Focus()
            Return False
        End If
        If cboDay.SelectedIndex < 0 Then
            MessageBox.Show("Please choose the Day.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboDay.Focus()
            Return False
        End If
        If txtRoom.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Room.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoom.Focus()
            Return False
        End If
        Return True
    End Function


    Private Function IntValue(ByVal text As String) As Integer
        Dim value As Integer = 0
        If Integer.TryParse(text.Trim(), value) Then Return value
        Return 0
    End Function

    Private Function DateValue(ByVal text As String) As Date
        Dim parts As String() = text.Split("-"c)
        If parts.Length = 3 Then
            Dim y As Integer = 0
            Dim m As Integer = 0
            Dim d As Integer = 0
            If Integer.TryParse(parts(0), y) AndAlso Integer.TryParse(parts(1), m) AndAlso Integer.TryParse(parts(2), d) Then
                If y >= 1 AndAlso m >= 1 AndAlso m <= 12 AndAlso d >= 1 AndAlso d <= 31 Then
                    Return New Date(y, m, d)
                End If
            End If
        End If
        Return Date.Today
    End Function

End Class
```

#### `Forms/frmSchedules.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedules
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblScheduleID = New System.Windows.Forms.Label()
        Me.txtScheduleID = New System.Windows.Forms.TextBox()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.lblTeacherID = New System.Windows.Forms.Label()
        Me.txtTeacherID = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.grpDetails.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.grpDetails.Controls.Add(Me.lblScheduleID)
        Me.grpDetails.Controls.Add(Me.txtScheduleID)
        Me.grpDetails.Controls.Add(Me.lblCourseID)
        Me.grpDetails.Controls.Add(Me.txtCourseID)
        Me.grpDetails.Controls.Add(Me.lblTeacherID)
        Me.grpDetails.Controls.Add(Me.txtTeacherID)
        Me.grpDetails.Controls.Add(Me.lblDay)
        Me.grpDetails.Controls.Add(Me.cboDay)
        Me.grpDetails.Controls.Add(Me.lblTime)
        Me.grpDetails.Controls.Add(Me.dtpTime)
        Me.grpDetails.Controls.Add(Me.lblRoom)
        Me.grpDetails.Controls.Add(Me.txtRoom)
        Me.grpDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(370, 192)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        Me.lblScheduleID.AutoSize = True
        Me.lblScheduleID.Location = New System.Drawing.Point(12, 25)
        Me.lblScheduleID.Name = "lblScheduleID"
        Me.lblScheduleID.Size = New System.Drawing.Size(77, 13)
        Me.lblScheduleID.TabIndex = 0
        Me.lblScheduleID.Text = "Schedule ID:"
        Me.txtScheduleID.Location = New System.Drawing.Point(120, 22)
        Me.txtScheduleID.Name = "txtScheduleID"
        Me.txtScheduleID.ReadOnly = True
        Me.txtScheduleID.Size = New System.Drawing.Size(230, 20)
        Me.txtScheduleID.TabIndex = 1
        Me.txtScheduleID.TabStop = False
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Location = New System.Drawing.Point(12, 53)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(63, 13)
        Me.lblCourseID.TabIndex = 2
        Me.lblCourseID.Text = "Course ID:"
        Me.txtCourseID.Location = New System.Drawing.Point(120, 50)
        Me.txtCourseID.MaxLength = 50
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(230, 20)
        Me.txtCourseID.TabIndex = 3
        Me.lblTeacherID.AutoSize = True
        Me.lblTeacherID.Location = New System.Drawing.Point(12, 81)
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Size = New System.Drawing.Size(70, 13)
        Me.lblTeacherID.TabIndex = 4
        Me.lblTeacherID.Text = "Teacher ID:"
        Me.txtTeacherID.Location = New System.Drawing.Point(120, 78)
        Me.txtTeacherID.MaxLength = 50
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Size = New System.Drawing.Size(230, 20)
        Me.txtTeacherID.TabIndex = 5
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(12, 109)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(21, 13)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day:"
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cboDay.Location = New System.Drawing.Point(120, 106)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(230, 21)
        Me.cboDay.TabIndex = 7
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 137)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(28, 13)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time:"
        Me.dtpTime.CustomFormat = "HH:mm"
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Location = New System.Drawing.Point(120, 134)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(230, 20)
        Me.dtpTime.TabIndex = 9
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(12, 165)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(28, 13)
        Me.lblRoom.TabIndex = 10
        Me.lblRoom.Text = "Room:"
        Me.txtRoom.Location = New System.Drawing.Point(120, 162)
        Me.txtRoom.MaxLength = 50
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(230, 20)
        Me.txtRoom.TabIndex = 11
        Me.addButton.Location = New System.Drawing.Point(12, 214)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(66, 25)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        Me.updateButton.Location = New System.Drawing.Point(84, 214)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(66, 25)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        Me.deleteButton.Location = New System.Drawing.Point(156, 214)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(66, 25)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        Me.clearButton.Location = New System.Drawing.Point(228, 214)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(66, 25)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        Me.exitButton.Location = New System.Drawing.Point(300, 214)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 25)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(394, 12)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(600, 326)
        Me.grpRecords.TabIndex = 2
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Records"
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(10, 20)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(580, 300)
        Me.dataGridView1.TabIndex = 0
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(12, 348)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(56, 13)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 374)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.lblDatabase)
        Me.Name = "frmSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSchedules"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblScheduleID As System.Windows.Forms.Label
    Friend WithEvents txtScheduleID As System.Windows.Forms.TextBox
    Friend WithEvents lblCourseID As System.Windows.Forms.Label
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents lblTeacherID As System.Windows.Forms.Label
    Friend WithEvents txtTeacherID As System.Windows.Forms.TextBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDatabase As System.Windows.Forms.Label

End Class
```

#### `Forms/frmQuotes.vb`
```vbnet
Imports System.Data.OleDb

Public Class frmQuotes

    Private selectedId As Integer = 0
    Private isLoading As Boolean = False
    Private store As DataTable
    Private nextId As Integer = 1

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmQuotes] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Function XmlPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.xml")
    End Function

    Private Function SdfPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.sdf")
    End Function

    Private Function HasSqlCe() As Boolean
        Try
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
        Catch
        End Try
        Return False
    End Function

    Private Sub frmQuotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogStep("Load")
        Try
            SetupStore()
        Catch ex As Exception
            LogStep("SetupStore failed: " & ex.Message)
        End Try
        Try
            ClearFields()
        Catch
        End Try
        RefreshGrid()
    End Sub

    Private Sub SetupStore()
        store = New DataTable("Quotes")
        store.Columns.Add("QuoteID", GetType(Integer))
        store.Columns.Add("Content", GetType(String))
        store.Columns.Add("Author", GetType(String))
        store.Columns.Add("Source", GetType(String))
        store.Columns.Add("QuoteDate", GetType(Date))
        If IO.File.Exists(XmlPath()) Then
            Try
                store.ReadXml(XmlPath())
                LogStep("loaded rows from xml: " & store.Rows.Count.ToString())
            Catch ex As Exception
                LogStep("xml unreadable, reseeding: " & ex.Message)
                store.Clear()
            End Try
        End If
        If store.Rows.Count = 0 Then
            SeedSampleData()
            SaveStore()
            LogStep("seeded sample data")
        End If
        nextId = 1
        For Each row As DataRow In store.Rows
            Dim id As Integer = Convert.ToInt32(row.Item("QuoteID"))
            If id >= nextId Then nextId = id + 1
        Next
        lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
    End Sub

    Private Sub SaveStore()
        Try
            store.AcceptChanges()
            store.WriteXml(XmlPath())
        Catch ex As Exception
            LogStep("WriteXml failed: " & ex.Message)
        End Try
        SyncToSdf()
    End Sub

    Private Sub SyncToSdf()
        If Not HasSqlCe() Then Return
        Try
            If Not IO.File.Exists(SdfPath()) Then
                Dim catalog As Object = CreateObject("ADOX.Catalog")
                catalog.Create("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath())
                catalog = Nothing
            End If
            Using conn As New OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath() & ";Persist Security Info=False;")
                conn.Open()
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [Quotes]", conn)
                    cmd.ExecuteScalar()
                End Using
                Using cmd As New OleDbCommand("DELETE FROM [Quotes]", conn)
                    cmd.ExecuteNonQuery()
                End Using
                For Each row As DataRow In store.Rows
                    Using cmd As New OleDbCommand("INSERT INTO [Quotes] ([Content], [Author], [Source], [QuoteDate]) VALUES (?, ?, ?, ?)", conn)
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Content")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Author")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Source")))
                        cmd.Parameters.AddWithValue("?", Convert.ToDateTime(row.Item("QuoteDate")))
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            LogStep("sdf mirror skipped: " & ex.Message)
        End Try
    End Sub

    Private Sub SeedSampleData()
        Dim rows As String() = New String() { _
            "Simplicity is the soul of efficiency.|Austin Freeman|The Social Welfare of the Blind|1912-01-01", _
            "First, solve the problem. Then, write the code.|John Johnson|Tech talk|1980-05-20", _
            "Experience is the name everyone gives to their mistakes.|Oscar Wilde|Lady Windermere Fan|1892-02-20", _
            "Code is like humor. When you have to explain it, it is bad.|Cory House|Blog post|2015-03-11", _
            "Make it work, make it right, make it fast.|Kent Beck|Extreme Programming|1999-10-05", _
            "The best error message is the one that never shows up.|Thomas Fuchs|Conference talk|2011-07-19"
            }
        For Each line As String In rows
            Dim parts As String() = line.Split("|"c)
            If parts.Length = 4 Then
                Dim row As DataRow = store.NewRow()
                row.Item("QuoteID") = nextId
                row.Item("Content") = parts(0)
                row.Item("Author") = parts(1)
                row.Item("Source") = parts(2)
                row.Item("QuoteDate") = DateValue(parts(3))
                store.Rows.Add(row)
                nextId += 1
            End If
        Next
    End Sub

    Private Sub RefreshGrid()
        Try
            If store Is Nothing Then Return
            Dim view As New DataTable("Quotes")
            view = store.Copy()
            dataGridView1.DataSource = view
            FormatGrid()
            lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
        Catch ex As Exception
            LogStep("RefreshGrid failed: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dataGridView1.Columns.Count = 0 Then Return
        With dataGridView1
            .Columns("QuoteID").HeaderText = "ID"
            .Columns("Content").HeaderText = "Content"
            .Columns("Author").HeaderText = "Author"
            .Columns("Source").HeaderText = "Source"
            .Columns("QuoteDate").HeaderText = "Quote Date"
        End With
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try
            If Not IsValidInput() Then Return
            Dim row As DataRow = store.NewRow()
            row.Item("QuoteID") = nextId
            row.Item("Content") = txtContent.Text.Trim()
            row.Item("Author") = txtAuthor.Text.Trim()
            row.Item("Source") = txtSource.Text.Trim()
            row.Item("QuoteDate") = dtpQuoteDate.Value.Date
            store.Rows.Add(row)
            nextId += 1
            SaveStore()
            MessageBox.Show("The record was saved." & vbCrLf & vbCrLf & "New ID: " & (nextId - 1).ToString(), _
                "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Add failed: " & ex.Message)
            MessageBox.Show("The record could not be saved." & vbCrLf & vbCrLf & ex.Message, _
                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If Not IsValidInput() Then Return
            Dim found As DataRow = Nothing
            For Each row As DataRow In store.Rows
                If Convert.ToInt32(row.Item("QuoteID")) = selectedId Then
                    found = row
                    Exit For
                End If
            Next
            If found Is Nothing Then
                MessageBox.Show("That record no longer exists.", "Record Not Found", _
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RefreshGrid()
                Return
            End If
            found.Item("Content") = txtContent.Text.Trim()
            found.Item("Author") = txtAuthor.Text.Trim()
            found.Item("Source") = txtSource.Text.Trim()
            found.Item("QuoteDate") = dtpQuoteDate.Value.Date
            SaveStore()
            MessageBox.Show("The record was updated.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Update failed: " & ex.Message)
            MessageBox.Show("The record could not be updated." & vbCrLf & vbCrLf & ex.Message, _
                "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If MessageBox.Show("Delete this record?" & vbCrLf & vbCrLf & "ID: " & selectedId.ToString(), _
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If
            For i As Integer = store.Rows.Count - 1 To 0 Step -1
                If Convert.ToInt32(store.Rows(i).Item("QuoteID")) = selectedId Then
                    store.Rows.RemoveAt(i)
                End If
            Next
            SaveStore()
            MessageBox.Show("The record was deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Delete failed: " & ex.Message)
            MessageBox.Show("The record could not be deleted." & vbCrLf & vbCrLf & ex.Message, _
                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ClearFields()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGridView1.SelectionChanged
        If isLoading Then Return
        If dataGridView1.CurrentRow Is Nothing Then Return
        FillFromRow()
    End Sub

    Private Sub FillFromRow()
        Dim row As DataGridViewRow = dataGridView1.CurrentRow
        If row Is Nothing Then Return
        If row.Cells("QuoteID").Value Is Nothing Then Return
        If row.Cells("QuoteID").Value Is DBNull.Value Then Return
        isLoading = True
        Try
            selectedId = Convert.ToInt32(row.Cells("QuoteID").Value)
            txtQuoteID.Text = selectedId.ToString()
            txtContent.Text = Convert.ToString(row.Cells("Content").Value)
            txtAuthor.Text = Convert.ToString(row.Cells("Author").Value)
            txtSource.Text = Convert.ToString(row.Cells("Source").Value)
            Dim QuoteDateDate As Date
            If Date.TryParse(Convert.ToString(row.Cells("QuoteDate").Value), QuoteDateDate) Then
                dtpQuoteDate.Value = QuoteDateDate
            End If
        Catch ex As Exception
            LogStep("FillFromRow failed: " & ex.Message)
        Finally
            isLoading = False
        End Try
    End Sub

    Private Sub ClearFields()
        isLoading = True
        Try
            dataGridView1.CurrentCell = Nothing
        Catch
        End Try
        selectedId = 0
        txtQuoteID.Clear()
        txtContent.Clear()
        txtAuthor.Clear()
        txtSource.Clear()
        dtpQuoteDate.Value = Date.Today
        txtContent.Focus()
        isLoading = False
    End Sub

    Private Function IsValidInput() As Boolean
        If txtContent.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Content.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Return False
        End If
        If txtAuthor.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Author.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAuthor.Focus()
            Return False
        End If
        Return True
    End Function


    Private Function IntValue(ByVal text As String) As Integer
        Dim value As Integer = 0
        If Integer.TryParse(text.Trim(), value) Then Return value
        Return 0
    End Function

    Private Function DateValue(ByVal text As String) As Date
        Dim parts As String() = text.Split("-"c)
        If parts.Length = 3 Then
            Dim y As Integer = 0
            Dim m As Integer = 0
            Dim d As Integer = 0
            If Integer.TryParse(parts(0), y) AndAlso Integer.TryParse(parts(1), m) AndAlso Integer.TryParse(parts(2), d) Then
                If y >= 1 AndAlso m >= 1 AndAlso m <= 12 AndAlso d >= 1 AndAlso d <= 31 Then
                    Return New Date(y, m, d)
                End If
            End If
        End If
        Return Date.Today
    End Function

End Class
```

#### `Forms/frmQuotes.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotes
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblQuoteID = New System.Windows.Forms.Label()
        Me.txtQuoteID = New System.Windows.Forms.TextBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblQuoteDate = New System.Windows.Forms.Label()
        Me.dtpQuoteDate = New System.Windows.Forms.DateTimePicker()
        Me.addButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.grpDetails.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.grpDetails.Controls.Add(Me.lblQuoteID)
        Me.grpDetails.Controls.Add(Me.txtQuoteID)
        Me.grpDetails.Controls.Add(Me.lblContent)
        Me.grpDetails.Controls.Add(Me.txtContent)
        Me.grpDetails.Controls.Add(Me.lblAuthor)
        Me.grpDetails.Controls.Add(Me.txtAuthor)
        Me.grpDetails.Controls.Add(Me.lblSource)
        Me.grpDetails.Controls.Add(Me.txtSource)
        Me.grpDetails.Controls.Add(Me.lblQuoteDate)
        Me.grpDetails.Controls.Add(Me.dtpQuoteDate)
        Me.grpDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(370, 164)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        Me.lblQuoteID.AutoSize = True
        Me.lblQuoteID.Location = New System.Drawing.Point(12, 25)
        Me.lblQuoteID.Name = "lblQuoteID"
        Me.lblQuoteID.Size = New System.Drawing.Size(56, 13)
        Me.lblQuoteID.TabIndex = 0
        Me.lblQuoteID.Text = "Quote ID:"
        Me.txtQuoteID.Location = New System.Drawing.Point(120, 22)
        Me.txtQuoteID.Name = "txtQuoteID"
        Me.txtQuoteID.ReadOnly = True
        Me.txtQuoteID.Size = New System.Drawing.Size(230, 20)
        Me.txtQuoteID.TabIndex = 1
        Me.txtQuoteID.TabStop = False
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(12, 53)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(49, 13)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "Content:"
        Me.txtContent.Location = New System.Drawing.Point(120, 50)
        Me.txtContent.MaxLength = 500
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(230, 20)
        Me.txtContent.TabIndex = 3
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(12, 81)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(42, 13)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "Author:"
        Me.txtAuthor.Location = New System.Drawing.Point(120, 78)
        Me.txtAuthor.MaxLength = 100
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(230, 20)
        Me.txtAuthor.TabIndex = 5
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(12, 109)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(42, 13)
        Me.lblSource.TabIndex = 6
        Me.lblSource.Text = "Source:"
        Me.txtSource.Location = New System.Drawing.Point(120, 106)
        Me.txtSource.MaxLength = 150
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(230, 20)
        Me.txtSource.TabIndex = 7
        Me.lblQuoteDate.AutoSize = True
        Me.lblQuoteDate.Location = New System.Drawing.Point(12, 137)
        Me.lblQuoteDate.Name = "lblQuoteDate"
        Me.lblQuoteDate.Size = New System.Drawing.Size(70, 13)
        Me.lblQuoteDate.TabIndex = 8
        Me.lblQuoteDate.Text = "Quote Date:"
        Me.dtpQuoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpQuoteDate.Location = New System.Drawing.Point(120, 134)
        Me.dtpQuoteDate.Name = "dtpQuoteDate"
        Me.dtpQuoteDate.Size = New System.Drawing.Size(230, 20)
        Me.dtpQuoteDate.TabIndex = 9
        Me.addButton.Location = New System.Drawing.Point(12, 186)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(66, 25)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        Me.updateButton.Location = New System.Drawing.Point(84, 186)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(66, 25)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        Me.deleteButton.Location = New System.Drawing.Point(156, 186)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(66, 25)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        Me.clearButton.Location = New System.Drawing.Point(228, 186)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(66, 25)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        Me.exitButton.Location = New System.Drawing.Point(300, 186)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 25)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(394, 12)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(600, 326)
        Me.grpRecords.TabIndex = 2
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Records"
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(10, 20)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(580, 300)
        Me.dataGridView1.TabIndex = 0
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(12, 348)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(56, 13)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 374)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.lblDatabase)
        Me.Name = "frmQuotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuotes"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuoteID As System.Windows.Forms.Label
    Friend WithEvents txtQuoteID As System.Windows.Forms.TextBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblQuoteDate As System.Windows.Forms.Label
    Friend WithEvents dtpQuoteDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDatabase As System.Windows.Forms.Label

End Class
```

#### `Forms/frmBibleVerses.vb`
```vbnet
Imports System.Data.OleDb

Public Class frmBibleVerses

    Private selectedId As Integer = 0
    Private isLoading As Boolean = False
    Private store As DataTable
    Private nextId As Integer = 1

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmBibleVerses] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Function XmlPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.xml")
    End Function

    Private Function SdfPath() As String
        Return IO.Path.Combine(Application.StartupPath, "projectDB.sdf")
    End Function

    Private Function HasSqlCe() As Boolean
        Try
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
            Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Classes\Microsoft.SQLSERVER.CE.OLEDB.3.5")
                If key IsNot Nothing Then Return True
            End Using
        Catch
        End Try
        Return False
    End Function

    Private Sub frmBibleVerses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogStep("Load")
        Try
            SetupStore()
        Catch ex As Exception
            LogStep("SetupStore failed: " & ex.Message)
        End Try
        Try
            ClearFields()
        Catch
        End Try
        RefreshGrid()
    End Sub

    Private Sub SetupStore()
        store = New DataTable("BibleVerses")
        store.Columns.Add("VerseID", GetType(Integer))
        store.Columns.Add("Book", GetType(String))
        store.Columns.Add("Chapter", GetType(Integer))
        store.Columns.Add("Verse", GetType(Integer))
        store.Columns.Add("Content", GetType(String))
        store.Columns.Add("Translation", GetType(String))
        store.Columns.Add("Remarks", GetType(String))
        store.Columns.Add("Category", GetType(String))
        If IO.File.Exists(XmlPath()) Then
            Try
                store.ReadXml(XmlPath())
                LogStep("loaded rows from xml: " & store.Rows.Count.ToString())
            Catch ex As Exception
                LogStep("xml unreadable, reseeding: " & ex.Message)
                store.Clear()
            End Try
        End If
        If store.Rows.Count = 0 Then
            SeedSampleData()
            SaveStore()
            LogStep("seeded sample data")
        End If
        nextId = 1
        For Each row As DataRow In store.Rows
            Dim id As Integer = Convert.ToInt32(row.Item("VerseID"))
            If id >= nextId Then nextId = id + 1
        Next
        lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
    End Sub

    Private Sub SaveStore()
        Try
            store.AcceptChanges()
            store.WriteXml(XmlPath())
        Catch ex As Exception
            LogStep("WriteXml failed: " & ex.Message)
        End Try
        SyncToSdf()
    End Sub

    Private Sub SyncToSdf()
        If Not HasSqlCe() Then Return
        Try
            If Not IO.File.Exists(SdfPath()) Then
                Dim catalog As Object = CreateObject("ADOX.Catalog")
                catalog.Create("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath())
                catalog = Nothing
            End If
            Using conn As New OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=" & SdfPath() & ";Persist Security Info=False;")
                conn.Open()
                Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [BibleVerses]", conn)
                    cmd.ExecuteScalar()
                End Using
                Using cmd As New OleDbCommand("DELETE FROM [BibleVerses]", conn)
                    cmd.ExecuteNonQuery()
                End Using
                For Each row As DataRow In store.Rows
                    Using cmd As New OleDbCommand("INSERT INTO [BibleVerses] ([Book], [Chapter], [Verse], [Content], [Translation], [Remarks], [Category]) VALUES (?, ?, ?, ?, ?, ?, ?)", conn)
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Book")))
                        cmd.Parameters.AddWithValue("?", IntValue(Convert.ToString(row.Item("Chapter"))))
                        cmd.Parameters.AddWithValue("?", IntValue(Convert.ToString(row.Item("Verse"))))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Content")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Translation")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Remarks")))
                        cmd.Parameters.AddWithValue("?", Convert.ToString(row.Item("Category")))
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            LogStep("sdf mirror skipped: " & ex.Message)
        End Try
    End Sub

    Private Sub SeedSampleData()
        Dim rows As String() = New String() { _
            "Genesis|1|1|In the beginning God created the heavens and the earth.|NIV|Creation|Old Testament", _
            "Exodus|20|3|You shall have no other gods before me.|NIV|Commandments|Old Testament", _
            "Joshua|1|9|Be strong and courageous. Do not be afraid.|NIV|Courage|History", _
            "Isaiah|41|10|So do not fear, for I am with you.|NIV|Comfort|Prophecy", _
            "Matthew|5|9|Blessed are the peacemakers.|NIV|Peace|Gospel", _
            "James|1|22|Do not merely listen to the word, and so deceive yourselves. Do what it says.|NIV|Action|Epistle"
            }
        For Each line As String In rows
            Dim parts As String() = line.Split("|"c)
            If parts.Length = 7 Then
                Dim row As DataRow = store.NewRow()
                row.Item("VerseID") = nextId
                row.Item("Book") = parts(0)
                row.Item("Chapter") = IntValue(parts(1))
                row.Item("Verse") = IntValue(parts(2))
                row.Item("Content") = parts(3)
                row.Item("Translation") = parts(4)
                row.Item("Remarks") = parts(5)
                row.Item("Category") = parts(6)
                store.Rows.Add(row)
                nextId += 1
            End If
        Next
    End Sub

    Private Sub RefreshGrid()
        Try
            If store Is Nothing Then Return
            Dim view As New DataTable("BibleVerses")
            view = store.Copy()
            dataGridView1.DataSource = view
            FormatGrid()
            lblDatabase.Text = "Storage: " & XmlPath() & "   |   " & store.Rows.Count.ToString() & " record(s)"
        Catch ex As Exception
            LogStep("RefreshGrid failed: " & ex.Message)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dataGridView1.Columns.Count = 0 Then Return
        With dataGridView1
            .Columns("VerseID").HeaderText = "ID"
            .Columns("Book").HeaderText = "Book"
            .Columns("Chapter").HeaderText = "Chapter"
            .Columns("Verse").HeaderText = "Verse"
            .Columns("Content").HeaderText = "Content"
            .Columns("Translation").HeaderText = "Translation"
            .Columns("Remarks").HeaderText = "Remarks"
            .Columns("Category").HeaderText = "Category"
        End With
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Try
            If Not IsValidInput() Then Return
            Dim row As DataRow = store.NewRow()
            row.Item("VerseID") = nextId
            row.Item("Book") = txtBook.Text.Trim()
            row.Item("Chapter") = IntValue(txtChapter.Text)
            row.Item("Verse") = IntValue(txtVerse.Text)
            row.Item("Content") = txtContent.Text.Trim()
            row.Item("Translation") = txtTranslation.Text.Trim()
            row.Item("Remarks") = txtRemarks.Text.Trim()
            row.Item("Category") = txtCategory.Text.Trim()
            store.Rows.Add(row)
            nextId += 1
            SaveStore()
            MessageBox.Show("The record was saved." & vbCrLf & vbCrLf & "New ID: " & (nextId - 1).ToString(), _
                "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Add failed: " & ex.Message)
            MessageBox.Show("The record could not be saved." & vbCrLf & vbCrLf & ex.Message, _
                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If Not IsValidInput() Then Return
            Dim found As DataRow = Nothing
            For Each row As DataRow In store.Rows
                If Convert.ToInt32(row.Item("VerseID")) = selectedId Then
                    found = row
                    Exit For
                End If
            Next
            If found Is Nothing Then
                MessageBox.Show("That record no longer exists.", "Record Not Found", _
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RefreshGrid()
                Return
            End If
            found.Item("Book") = txtBook.Text.Trim()
            found.Item("Chapter") = IntValue(txtChapter.Text)
            found.Item("Verse") = IntValue(txtVerse.Text)
            found.Item("Content") = txtContent.Text.Trim()
            found.Item("Translation") = txtTranslation.Text.Trim()
            found.Item("Remarks") = txtRemarks.Text.Trim()
            found.Item("Category") = txtCategory.Text.Trim()
            SaveStore()
            MessageBox.Show("The record was updated.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Update failed: " & ex.Message)
            MessageBox.Show("The record could not be updated." & vbCrLf & vbCrLf & ex.Message, _
                "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Try
            If selectedId = 0 Then
                MessageBox.Show("Select a record in the table first.", "No Record Selected", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If MessageBox.Show("Delete this record?" & vbCrLf & vbCrLf & "ID: " & selectedId.ToString(), _
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If
            For i As Integer = store.Rows.Count - 1 To 0 Step -1
                If Convert.ToInt32(store.Rows(i).Item("VerseID")) = selectedId Then
                    store.Rows.RemoveAt(i)
                End If
            Next
            SaveStore()
            MessageBox.Show("The record was deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            RefreshGrid()
        Catch ex As Exception
            LogStep("Delete failed: " & ex.Message)
            MessageBox.Show("The record could not be deleted." & vbCrLf & vbCrLf & ex.Message, _
                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ClearFields()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub dataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataGridView1.SelectionChanged
        If isLoading Then Return
        If dataGridView1.CurrentRow Is Nothing Then Return
        FillFromRow()
    End Sub

    Private Sub FillFromRow()
        Dim row As DataGridViewRow = dataGridView1.CurrentRow
        If row Is Nothing Then Return
        If row.Cells("VerseID").Value Is Nothing Then Return
        If row.Cells("VerseID").Value Is DBNull.Value Then Return
        isLoading = True
        Try
            selectedId = Convert.ToInt32(row.Cells("VerseID").Value)
            txtVerseID.Text = selectedId.ToString()
            txtBook.Text = Convert.ToString(row.Cells("Book").Value)
            txtChapter.Text = Convert.ToString(row.Cells("Chapter").Value)
            txtVerse.Text = Convert.ToString(row.Cells("Verse").Value)
            txtContent.Text = Convert.ToString(row.Cells("Content").Value)
            txtTranslation.Text = Convert.ToString(row.Cells("Translation").Value)
            txtRemarks.Text = Convert.ToString(row.Cells("Remarks").Value)
            txtCategory.Text = Convert.ToString(row.Cells("Category").Value)
        Catch ex As Exception
            LogStep("FillFromRow failed: " & ex.Message)
        Finally
            isLoading = False
        End Try
    End Sub

    Private Sub ClearFields()
        isLoading = True
        Try
            dataGridView1.CurrentCell = Nothing
        Catch
        End Try
        selectedId = 0
        txtVerseID.Clear()
        txtBook.Clear()
        txtChapter.Clear()
        txtVerse.Clear()
        txtContent.Clear()
        txtTranslation.Clear()
        txtRemarks.Clear()
        txtCategory.Clear()
        txtBook.Focus()
        isLoading = False
    End Sub

    Private Function IsValidInput() As Boolean
        If txtBook.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Book.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBook.Focus()
            Return False
        End If
        If txtChapter.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Chapter.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChapter.Focus()
            Return False
        End If
        Dim ChapterNum As Integer = 0
        If txtChapter.Text.Trim() <> "" AndAlso Not Integer.TryParse(txtChapter.Text.Trim(), ChapterNum) Then
            MessageBox.Show("The Chapter must be a whole number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChapter.Focus()
            Return False
        End If
        If txtVerse.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Verse.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerse.Focus()
            Return False
        End If
        Dim VerseNum As Integer = 0
        If txtVerse.Text.Trim() <> "" AndAlso Not Integer.TryParse(txtVerse.Text.Trim(), VerseNum) Then
            MessageBox.Show("The Verse must be a whole number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerse.Focus()
            Return False
        End If
        If txtContent.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Content.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Return False
        End If
        If txtTranslation.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Translation.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTranslation.Focus()
            Return False
        End If
        Return True
    End Function


    Private Function IntValue(ByVal text As String) As Integer
        Dim value As Integer = 0
        If Integer.TryParse(text.Trim(), value) Then Return value
        Return 0
    End Function

    Private Function DateValue(ByVal text As String) As Date
        Dim parts As String() = text.Split("-"c)
        If parts.Length = 3 Then
            Dim y As Integer = 0
            Dim m As Integer = 0
            Dim d As Integer = 0
            If Integer.TryParse(parts(0), y) AndAlso Integer.TryParse(parts(1), m) AndAlso Integer.TryParse(parts(2), d) Then
                If y >= 1 AndAlso m >= 1 AndAlso m <= 12 AndAlso d >= 1 AndAlso d <= 31 Then
                    Return New Date(y, m, d)
                End If
            End If
        End If
        Return Date.Today
    End Function

End Class
```

#### `Forms/frmBibleVerses.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBibleVerses
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblVerseID = New System.Windows.Forms.Label()
        Me.txtVerseID = New System.Windows.Forms.TextBox()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.lblChapter = New System.Windows.Forms.Label()
        Me.txtChapter = New System.Windows.Forms.TextBox()
        Me.lblVerse = New System.Windows.Forms.Label()
        Me.txtVerse = New System.Windows.Forms.TextBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.grpDetails.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.grpDetails.Controls.Add(Me.lblVerseID)
        Me.grpDetails.Controls.Add(Me.txtVerseID)
        Me.grpDetails.Controls.Add(Me.lblBook)
        Me.grpDetails.Controls.Add(Me.txtBook)
        Me.grpDetails.Controls.Add(Me.lblChapter)
        Me.grpDetails.Controls.Add(Me.txtChapter)
        Me.grpDetails.Controls.Add(Me.lblVerse)
        Me.grpDetails.Controls.Add(Me.txtVerse)
        Me.grpDetails.Controls.Add(Me.lblContent)
        Me.grpDetails.Controls.Add(Me.txtContent)
        Me.grpDetails.Controls.Add(Me.lblTranslation)
        Me.grpDetails.Controls.Add(Me.txtTranslation)
        Me.grpDetails.Controls.Add(Me.lblRemarks)
        Me.grpDetails.Controls.Add(Me.txtRemarks)
        Me.grpDetails.Controls.Add(Me.lblCategory)
        Me.grpDetails.Controls.Add(Me.txtCategory)
        Me.grpDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(370, 248)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        Me.lblVerseID.AutoSize = True
        Me.lblVerseID.Location = New System.Drawing.Point(12, 25)
        Me.lblVerseID.Name = "lblVerseID"
        Me.lblVerseID.Size = New System.Drawing.Size(56, 13)
        Me.lblVerseID.TabIndex = 0
        Me.lblVerseID.Text = "Verse ID:"
        Me.txtVerseID.Location = New System.Drawing.Point(120, 22)
        Me.txtVerseID.Name = "txtVerseID"
        Me.txtVerseID.ReadOnly = True
        Me.txtVerseID.Size = New System.Drawing.Size(230, 20)
        Me.txtVerseID.TabIndex = 1
        Me.txtVerseID.TabStop = False
        Me.lblBook.AutoSize = True
        Me.lblBook.Location = New System.Drawing.Point(12, 53)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Size = New System.Drawing.Size(28, 13)
        Me.lblBook.TabIndex = 2
        Me.lblBook.Text = "Book:"
        Me.txtBook.Location = New System.Drawing.Point(120, 50)
        Me.txtBook.MaxLength = 50
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(230, 20)
        Me.txtBook.TabIndex = 3
        Me.lblChapter.AutoSize = True
        Me.lblChapter.Location = New System.Drawing.Point(12, 81)
        Me.lblChapter.Name = "lblChapter"
        Me.lblChapter.Size = New System.Drawing.Size(49, 13)
        Me.lblChapter.TabIndex = 4
        Me.lblChapter.Text = "Chapter:"
        Me.txtChapter.Location = New System.Drawing.Point(120, 78)
        Me.txtChapter.MaxLength = 4
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Size = New System.Drawing.Size(230, 20)
        Me.txtChapter.TabIndex = 5
        Me.lblVerse.AutoSize = True
        Me.lblVerse.Location = New System.Drawing.Point(12, 109)
        Me.lblVerse.Name = "lblVerse"
        Me.lblVerse.Size = New System.Drawing.Size(35, 13)
        Me.lblVerse.TabIndex = 6
        Me.lblVerse.Text = "Verse:"
        Me.txtVerse.Location = New System.Drawing.Point(120, 106)
        Me.txtVerse.MaxLength = 4
        Me.txtVerse.Name = "txtVerse"
        Me.txtVerse.Size = New System.Drawing.Size(230, 20)
        Me.txtVerse.TabIndex = 7
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(12, 137)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(49, 13)
        Me.lblContent.TabIndex = 8
        Me.lblContent.Text = "Content:"
        Me.txtContent.Location = New System.Drawing.Point(120, 134)
        Me.txtContent.MaxLength = 500
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(230, 20)
        Me.txtContent.TabIndex = 9
        Me.lblTranslation.AutoSize = True
        Me.lblTranslation.Location = New System.Drawing.Point(12, 165)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(77, 13)
        Me.lblTranslation.TabIndex = 10
        Me.lblTranslation.Text = "Translation:"
        Me.txtTranslation.Location = New System.Drawing.Point(120, 162)
        Me.txtTranslation.MaxLength = 50
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(230, 20)
        Me.txtTranslation.TabIndex = 11
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(12, 193)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 12
        Me.lblRemarks.Text = "Remarks:"
        Me.txtRemarks.Location = New System.Drawing.Point(120, 190)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(230, 20)
        Me.txtRemarks.TabIndex = 13
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(12, 221)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(56, 13)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Category:"
        Me.txtCategory.Location = New System.Drawing.Point(120, 218)
        Me.txtCategory.MaxLength = 50
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(230, 20)
        Me.txtCategory.TabIndex = 15
        Me.addButton.Location = New System.Drawing.Point(12, 270)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(66, 25)
        Me.addButton.TabIndex = 60
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        Me.updateButton.Location = New System.Drawing.Point(84, 270)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(66, 25)
        Me.updateButton.TabIndex = 61
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        Me.deleteButton.Location = New System.Drawing.Point(156, 270)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(66, 25)
        Me.deleteButton.TabIndex = 62
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        Me.clearButton.Location = New System.Drawing.Point(228, 270)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(66, 25)
        Me.clearButton.TabIndex = 63
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        Me.exitButton.Location = New System.Drawing.Point(300, 270)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 25)
        Me.exitButton.TabIndex = 64
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        Me.grpRecords.Controls.Add(Me.dataGridView1)
        Me.grpRecords.Location = New System.Drawing.Point(394, 12)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(600, 326)
        Me.grpRecords.TabIndex = 2
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "Records"
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(10, 20)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(580, 300)
        Me.dataGridView1.TabIndex = 0
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(12, 348)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(56, 13)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 374)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.lblDatabase)
        Me.Name = "frmBibleVerses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBibleVerses"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblVerseID As System.Windows.Forms.Label
    Friend WithEvents txtVerseID As System.Windows.Forms.TextBox
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter As System.Windows.Forms.Label
    Friend WithEvents txtChapter As System.Windows.Forms.TextBox
    Friend WithEvents lblVerse As System.Windows.Forms.Label
    Friend WithEvents txtVerse As System.Windows.Forms.TextBox
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lblTranslation As System.Windows.Forms.Label
    Friend WithEvents txtTranslation As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDatabase As System.Windows.Forms.Label

End Class
```

#### `Forms/frmAbout.vb`
```vbnet
Public Class frmAbout

    Private Sub LogStep(ByVal text As String)
        Try
            IO.File.AppendAllText(IO.Path.Combine(Application.StartupPath, "forms_log.txt"), _
                Date.Now.ToString("HH:mm:ss") & "  [frmAbout] " & text & vbCrLf)
        Catch
        End Try
    End Sub

    Private Const PhotoData As String = _
        "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" & _
        "CqqIgID9oezT3/sW4ot1M0unNC6WNo/eLPFj6L8y3iQzEPBG5yD0X6y8QQvqbFX08Zw+WmkY34lhAX5XV1DLQ1slNVtOuI4J/i8j8CN/msJGcTcdnHC0nEN1LWxExx+KQnoOi9IcO2ih4atcb6iRkTOQJPMrU9iFkprb2e01e6DM1W1073Bu5BOw/ABb/wD4Kud7xcL1WsiEjT3dO2PUImnkN+vmVWruv39RqTxFFhtaXc000stm4tlbZqoN/wCaUgPLDpWtJ/Erf0dHTzsD4Hte3+IOyFzG8dltvLu8jrnObzLJIhgnz25LZcK2y4cPzN9nqjLTtIxGTuPRcVSjQxmEjrp1a2faidG9gJ5N+CPoIw37zA9TyWbb6p1TTMc5ulxWj4zirKyI0gf3LDzeDgrnjTi3uzc6kuiMS713Dtvy2tudJE8b6TKM/go/JxJw9LO+Bk4njAw5wblu61NbwLSXCbFTWSNaXe8wAuPzKlFl7P8AhWOnERoZJCBsTKc/iF1RhbJc3k0SncZ5LBHOJeBuHuJrcTRxQtl0+CaMYIPqvP8AxfwPduHat7ZWODWO2cNwR0K9cUXB0dqkbV2iZ7GA4kgechzT5HzWPxVYKK60eirgY84IyR0W2jeSt5YTzEwq2sLiO6wzxfFOCCx7A12dLir40iSKoDsuA7t36fqsntNtTrHxNV0UQLI2vw3zIWr4VZNcL1T0cbDLLUvbDGzGdTy7AH4lWWElOCkupXJx4JuL6H6ZdkMz6jsv4ZlkaWvNshBGfJgH6KUrA4ct4tPD9vtgx/ZKaOEkDAJa0An8Qs9dC5HOwiIvoCIiAIiIAiIgCIiAIiIAiIgCqqKqAKiFCgCIiAIiIAiIgCIiAInREAREQBERAEREBR7WvY5jwC1wwQeoXhj7aXZ/W2DtCHFFJCP2ReBExpa3DYpms0lp+IbkL3QuZdudRwffOG7jwdfZdVTLD3kThA6QU02CYnnTuN/zWurOMFmTwbKUJTeIrJyrsriL+BLJHsR7KwDCz+MeKGWSFrfZqiplJ0NjiAGSfNx2aPMnkrPZZTOpOAbNFK0tlZSNDgehychSN9DHN4pY2uJ/iCplWUVVed1kttKL4F7jifaf2kcW8J11FT1dos8DKqJszfvJZ/ASQfG3DSRjfH+8ysl2q6mntf7Vgp6apr6NlVF3EhLWahqMbwd2vA39R5clv7rwnaKh2ZKCl2OQCzUGnzAOwX3T2RjWtYGBsTfdGMZW6pXoyp4UMM106NWM8ueUbyy1rvYoQ4bnCt8T1DpnCMkjVuf6+C+aSJrDoHutx81lVdLHVtbk4IUcpYZ38Cwcf45u3EFPwpPeLZOKapjmaGUfsokn7okjWdWwPu+EAkA5KxOyziHjW6WOqrLpXslrKeRjaejqLeAarLcu0vjDSwA8nHbcc9112qsjSQXBxx+804ysm3wyU7gIZDjljSFIK6gqfDwI4nbSc+PifuK8IXqpq6VrbhSSUsmMOa52rB8srYXSJpYdJ2cFdip+8Ic4b+a+qmLTHpIJAC45PJ0rZnj/ALeqMzcV1c+5DZMOx8P9FuvsUcHv4j7Xaa8TxF1FaGvqtenLXSDDWN+Piz8l16t4Ftl+qLyy4U4eJKxjmuO2GtAP5k5Uz7NZ4ODONqew0kEEFruDRDGyOMM7uVoyM455HU+qnrPUoR4aTXxIi50ydTiqxfng7giIrAV4IhRAEREAREQBERAEREAREQBERAFVUVUAVOqIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAeS4LxOyM9rV+fJu77vJxnA0DA+i70uIdq0P7E47uF2LfBW0kBaf8AECWn9FD60m6Ca8Sa0OS7+UX1X3R82CBhj0lulrHOAbjGN/8AVbh1KHAadgFF+DpBFAXOlLzLI6Q5OcEn/ZTFrw5oc1VmROtcLwa2WniaMvGfisSR2t+iMai7bbothciHQOYw7laG4z11vopjRxNfLJGWsc5wwx2NiR1Gd1itzJG4pqR0MYAAd81kS0srMSsDXHq1Q3hZt/t9qjbcr0bxVl2qSWSJkOMnkA0AYCyxDcouIW32m4huTho0SWyQtNKfUeHLSPMHdbO7jlrJ843hEjbKyR4a4aX/AMJV+Ona5+4CxmU0j3GqnfGJXbhrOQ+fVZdDL49L+a143De2xnwxgDGBhWa3SGHZZBeAFrLvPpjI89lng1Ry2Ri93F9pp4pPZ3SR1lXoe5rtJY3HvZ89h+K190qT+2LDWUr3ShtyjaSeYO/6FZ17ZUXac2SChmEcEbZPa34ERcRnA6nB2/FffZrw7US8S22jmmjqhTTurKxzCSxjgMNbk/E/RZU4OpUUY82dqnGlSc5dEzvyIivZ5+EREARE6IAiIgCIiAIiIAiIgCIiAKqoqhAURVVCgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAFCu1vh913sYqoKdk81KHa43DOuM+8Nt9iAVNeqLTXoxrU3CXU3W9aVCoqkeaPO9HS0sDoqujZJB4GtdCHksb8uWfVb6GtIiPNdCreCbXU1ks3fVMUcpLnRRkBuT64zj0XLauOWguEtJOCHRyFjs+YKqd1Y1bdZmWehe07h+yJruGzBrQXSO5DoAsOtuEfeaZKmIu6sadRHxUZ42sFwukf9guFRRENwHwYJH4+iu8F2+1UVshhvdDXVVW2RrJJo6k6Xs3BfjYgjYkY+GVrhSg45ybsyb5ZNvLcITtFIdXXAB2/FXaW60TPC9z2tPNxwtpS0XCsMcZZa6qSTYuL5H79ceXorjhaxO5tDw7TFhZoJmbnHPLt878lsUImWJNfgZbiv1qa3Q+5ww9B3rtOPmViycQUwqGOpayGpw7DzE8OB8+Sx+IrLJxNStt8tLRUlMWBkrKeBrQ/w6Tl3PByeW/qsm2cJ2qxUMVLQ0kULWbAMYBkeZ9VhNQivMxw8kqjqNUQx8lquI5pmUn9mhknqHOa2KONupz3EgAAdVkUwOdzgY2W14PibXcX" & _
        "U/h1MpmumPocYH1Kwt6Xe1FDxFaoqUHPwNJbKW41zG0tMyYPk2c10TmvaeucgYXSuCuG6fh23mNuHVEm8jx+Q/n1W/RWWz0ynbS485ZX7zU6lzHgxheoREUmRgREQBERAEREAREQAIiIAiIgCIiAIiqgKIqqiAdEREAREQBERAEREACIiAIiIAiIgCIiAIiICq5p2tWJ4nbeoARFIAyox+67k13z5fgulK3VQQ1NPJT1EbZIpGlr2OGxB5hc9zbqvTcGb7eu6NRTR5+opXRvLXjU07EqlXSSMkNRRHQ8jxN6OS4sNluVRSVW8UUzo9Z6YcQM/RbahMbxqJBaRtuqdLipyLZCSaTRHJai+ueP7JKehOoBZlppbnUTZnkMberQ7K3z3UmMbah1VyCopoztjf6L738mbHOTWMmVRQxwRaWDfqcr6ljyC5x6dVcFTSiLJcAtNcLl30hipjnHUcgteW3lmCLtbVMgZpbvIdgB1Ur7K6dwqK2d4Gvu2g/Mk/oodR0v3glk8Tj1PRT7s0x/zHHnH+Tl36Zh3UV7/Q5dR2tpP3epMeiIitpVQiIgCIiAIiIB1REQBERAEREAREQBERAFVUVUBRERAETqiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIqoDjXaTQNHFlbGW/dzhkuCOeW4P1BUKmZcbe0so36mD3Wu6fBdQ7WYdF6oagD+9gcw/Frs/+yhU7fEHc8Km3v8ALuZrz9S2Wb47eD8iJVHEFzgBfJbZvkMhWqXiG7VUp7igkaD/ABDdTRjaabwkNz0BV+FlNE4NDW/DC5+/S/pOju89TS2qmvFaQatzomdGjqt9T0AgxoHyWxp3wmMNa0BXQGn1KwlPJktj4giOjSpT2bv01dwhJydMbvq5R9jRpWBV8c2Xs9E1+v8A7S23uLKeV8EXeGMveA1xGeWeePNdWmz4bqBzX8eO2mjsiKzQ1VNX0UFbRysmpqiNssUjDlr2OGQR6EEFXlcypBERAEREAREQBERAEREAREQBERAECIgCqqIgCKqICiIiAInREAREQBERAEREAREQAIiIAiIgCIiAIqr4leyON0jzpa0FxPkBzQHM+1++Wr9vWzh4VGbq2F9YYwNmwkhmSehLuQ9CotOAYsgb+S4pxjxhUxds8XHdc5zqC56qd0YOe6hGA3HwGk/EO812alnhqYWSQSMlie0OY9hyHA8iFXu02n1rG8cKqw8L0J/Qrqnc2uYPxMWSI849nei+6aF2vL3kuV4PYx2l+M+qusdE3xO0qvNk2jOoxp05OyzWHUcrXR1bQ3S1oA6lfNXeKO30zqmsqoqeFgyXyODWhfU23hGMttzdtxjdce+0lfbbBwxNw65zZ6+vDT3I3McYcDrPkcjDfM/BYPGHbFU1kxs/A1K+qqpMj2pzMhvmWNPP/M7A+KjNi4efBcJb1fag190ee8L5Hawxx5HJ9534AdPNXDs52VutQqqpJcME+ZW9Y1+haU3CLzJndfszcVzUdgtfBt2ODFStbSvc7drtyYj8uXzHku6rxhT3sWqSou4lMbKUd4DyILd249c8l6D7HO2Hhzjy0U0UlZHR3xsbW1dLI0sb3uBnu3HZwJ3GDn8FeO0Wkxta0e5XNZa8MY3+JUtIvZ16cu96P16fA6YiqqKsEyEREAREQBERAEREAREQBERAEREARFVAUREQBERAEREAREQBERAEREAREQBERAEVVi3K40Ftg7+4VtPSxfxTSBo+vNfYxcnhLLPjaSyzJVJHsjY58jmsa0ZLnHAA+K5Zxj22WG1d5T2anmutUNg7BZED8TufwXHuK+NuJ+Kg+S+V76SgG7aOHwNd6AdfiVZNP7L3l1iVRcEfPn8Fz9CJutZt6KxF8T8uXzO7cc9rvBnCtuqKuev9uMIJLaXxjI6auXPbbK4Fx/21cbcS8P3Gsgi/4bsrIi6OBgJqqphIHid+63BJwME/BQ3iXRdeH5aWSTQWzsLG42IHJu/Tmvi5unuFO6Gqy5s0Pijz/EFcLTstbW6aSzPDw34+7l++ZEVdXrTgpPZN7peBpLrGLzw1JR05HeNcJaZx2z5D0yCfxCy+zHtCqOHw2zXKR5hD8N1A5j8248vyWltM0lneLRXn75n9xJnwyx9MHzHLC+7taqS6uM0jjFUj3ZQ3fbofP8wuTtD2ch2jod/S2qpYlHz8PJ+HRo6tJ1OelVeB7we6fl+/kegKa5QXCljqo3hzXjLXNOcrJbLC1pklm045ZP6rhXCXENwtEcrKpwc2DBLm5LJm8s+juhGx3HmpFeuIBf7O1tHVSwumOhxjOHMb1A8ieWfUrxZdmb2WoRsFHE2+u3x+SZ6MtYoK1dy3sjM427WaegmNFw/T+3VLXaXSOB7tp9AN3fkoLU0nEPFdSKviG4Td1nIjB9zyAaPC36lbq2W2iootNPTQwlwwTgucem5PxWa2emtsMk1XLHEwknW8hox5ZK9c0jsHYabHvbp8Ul8F8/8ASKLf9o7m7fDS2RdslHBa6cw0kLIRydIPedjq4ncpdLiyOB756mOGFvvyO6n08/QDdRe58WwvmNNbIZa2Rx8GWlrM+jfed9F8U1iq7jMK7iW4NiDRltNG8agPLDdmD4b+an//ACVNvudPhxtbZSxCPvfX3Ih3ay/5LmWPV/D9TBuFbXcSTezQNkp7XFJkvI3J83euOTenMqTWSKWLh2ZsOmCOCfWCP+ozk0n1A2XzUy07oo7ZbI2sYfCdLdmt6gfHqVtZ2tt9jmYDq733gD1Kk7LT/wCG/mVnxVZtZb9EuiRpq3PHiEFiK5L9fMnXCfaPxdwrQU8rK51zt+A10FXl7YhjbS73gPmuqcKdt1hujmwXKiqKCfkS0iRh9eh+i86cKVrZKd9HU+KBzNJZhXLnbJqNw9keC0e6AfFjmo+/7P2N1UcakOGXitv8fQ22uo16XscWffuezrNebVeacT2yvgqmYye7dkj4jmFnrxHS3m8WStp6+mrJqWra" & _
        "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" & _
        "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" & _
        "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" & _
        "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" & _
        "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" & _
        "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" & _
        "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" & _
        "hu3/ALV7P2TcGftGdrKq61OqK2UOrHfPA3c7qI27Fx+AG5C8yXu//wDDd2ouIaaRsclqmZUgO3BDSCRj1Gy4n2y9oV47TOOKviW6kxsd93R0odltLAD4Yx675J6kkqodpraVetSz+FJv5lq0PEaMvE3fCN9HEFzu9XdDGKu41T6uXu2Bjdb3FzsDoMnkpLFWyGZkUDGlpGk557Lj/Ds9TT1hlp85Y0uJ8sLpfClfFUPZrBa8/grz2euVcWSUucVj/Jx6jb8FRzXUlUBfGWyMDThwOHbhyllMxlRD3mcBwzjyPkooGd5TFz5MOa7kDyW8sc/9n7gkkcxkLou4tx4lzREn1Ux1HeljY3Y5ZxyVy2UPtFdEyYeEO3BHP1Wc+ZrInhwBIwGrIs7m989/vOazYepXDKrJQeEapNI9HdlvCdDZ7TBdXQh1wqog4vcP7th3DG+W2M+ZU1XN+yHj9t8iZYbqIorlBGBFIzZlQxo5gdHAcx8x5LpK8c1SFxC6krj8X26Y8i+2TpOhHuuQVERR51BECqgP/9k="

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogStep("Load start")
        Try
            Dim bytes As Byte() = Convert.FromBase64String(PhotoData)
            Using stream As New IO.MemoryStream(bytes)
                Using photo As Image = Image.FromStream(stream)
                    PictureBox1.Image = New Bitmap(photo)
                End Using
            End Using
        Catch ex As Exception
        End Try
    LogStep("Load end")
    End Sub

End Class
```

#### `Forms/frmAbout.Designer.vb`
```vbnet
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(218, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(150, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Rex M. Alvarez"
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(218, 56)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(120, 13)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course/Year/Section: BSIT 3B"
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(218, 80)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(160, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address: Barucboc, Quezon, Isabela"
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Location = New System.Drawing.Point(218, 104)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(140, 13)
        Me.lblSkills.TabIndex = 4
        Me.lblSkills.Text = "Skills: Programmer"
        Me.lblQuote.Location = New System.Drawing.Point(218, 132)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(300, 80)
        Me.lblQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.TabIndex = 5
        Me.lblQuote.Text = "Trust God, Always!"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 248)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.lblQuote)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSkills As System.Windows.Forms.Label
    Friend WithEvents lblQuote As System.Windows.Forms.Label

End Class
```

### 3. Sample Run
![Figure 13.1 — Sample Run of frmMain (MDI Container) and frmAbout (Author Profile with Embedded Base64 Photo)](docs/images/act13_run_1.png)
*Figure 13.1 — Sample Run of frmMain (MDI Container) and frmAbout (Author Profile with Embedded Base64 Photo)*

![Figure 13.2 — Sample Runs of CRUD Modules: frmSchedules, frmQuotes, frmBibleVerses, and frmAbout](docs/images/act13_run_2.png)
*Figure 13.2 — Sample Runs of CRUD Modules: frmSchedules, frmQuotes, frmBibleVerses, and frmAbout*

**Sample Run Walkthrough:**
- frmMain (MDI Parent): Displays the top MenuStrip (Schedules, About, Quotes, BibleVerse, Exit) and bottom StatusStrip showing 'UserInfo: Rex M. Alvarez | BSIT 3B', live date, live 1-second ticking clock (Timer1), and active child form name.
- frmSchedules: Manages class schedules (ScheduleID, CourseID, TeacherID, Day, Time, Room) with 7 seeded records (IT301–CS203) and full Add, Update, Delete, and Clear CRUD operations persisted to projectDB.xml and mirrored to projectDB.sdf.
- frmQuotes: Manages notable quotes (QuoteID, Content, Author, Source, QuoteDate) with 6 seeded quotes and full CRUD support.
- frmBibleVerses: Manages Bible verses (VerseID, Book, Chapter, Verse, Content, Translation, Remarks, Category) with whole-number validation on Chapter and Verse and 6 seeded scripture records.
- frmAbout: Decodes the embedded Base64 JPEG portrait into PictureBox1 and displays Rex M. Alvarez's profile ('BSIT 3B', 'Barucboc, Quezon, Isabela', 'Programmer', 'Trust God, Always!').

### 4. Form Design
![Figure 13.3 — Visual Studio Form Designs of frmMain and frmAbout](docs/images/act13_design_1.png)
*Figure 13.3 — Visual Studio Form Designs of frmMain and frmAbout*

![Figure 13.4 — Visual Studio Form Designs of frmSchedules, frmQuotes, frmBibleVerses, and frmAbout](docs/images/act13_design_2.png)
*Figure 13.4 — Visual Studio Form Designs of frmSchedules, frmQuotes, frmBibleVerses, and frmAbout*

| Control / Identifier | Control / Data Type | Text / Initial Value | Description & Role |
|---|---|---|---|
| `frmMain` | MDI Form | `"Main Form" (1024 × 568)` | IsMdiContainer = True; hosts MenuStrip1, StatusStrip1, and Timer1 |
| `MenuStrip1 (frmMain)` | MenuStrip | `Schedules, About, Quotes, BibleVerse, Exit` | Opens or activates maximized MDI child forms via ShowChild() |
| `StatusStrip1 (frmMain)` | StatusStrip | `toolstripUserInfo, CurrentDate, CurrentTime, lblStatusBar` | Displays student info and live date/time updated every 1000 ms |
| `frmSchedules` | Child Form | `"frmSchedules" (1006 × 374)` | CRUD form with txtScheduleID, txtCourseID, txtTeacherID, cboDay, dtpTime, txtRoom, dataGridView1 |
| `frmQuotes` | Child Form | `"frmQuotes" (1006 × 374)` | CRUD form with txtQuoteID, txtContent, txtAuthor, txtSource, dtpQuoteDate, dataGridView1 |
| `frmBibleVerses` | Child Form | `"frmBibleVerses" (1006 × 374)` | CRUD form with txtVerseID, txtBook, txtChapter, txtVerse, txtContent, txtTranslation, txtRemarks, txtCategory, dataGridView1 |
| `frmAbout` | Child Form | `"About" (560 × 248)` | Profile form with PictureBox1 (180 × 210), lblName, lblCourse, lblAddress, lblSkills, lblQuote |

### 5. Brief Description
Activity 13 (IntegProgProject2026) is the capstone Integrative Programming 1 project: a Multiple Document Interface (MDI) desktop application authored by Rex M. Alvarez (BSIT 3B). The MDI parent form (frmMain) manages single-instance maximized child windows via reflection (Activator.CreateInstance) and maintains a real-time status bar using a Windows Forms Timer. Three data-driven child forms (frmSchedules, frmQuotes, and frmBibleVerses) implement complete CRUD (Create, Read, Update, Delete) workflows bound to DataGridView controls, featuring input validation, automatic sample data seeding, dual XML (DataTable.WriteXml/ReadXml) and SQL Server Compact 3.5 (OleDb / projectDB.sdf) persistence, and diagnostic activity logging (forms_log.txt). The fourth child form (frmAbout) renders the developer's profile and decodes an embedded Base64 portrait directly into a PictureBox.

---
