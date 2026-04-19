Imports System.Globalization

Public Class CalculatorForm

    ' Note: UI-level code. Business logic (parsing, formatting, arithmetic) should be placed
    ' in a separate testable class (CalculatorEngine) — see CalculatorEngine.vb.

    ''' <summary>
    ''' Clear UI fields and reset displayed values.
    ''' Uses String.Empty to make intent explicit.
    ''' </summary>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDisplay()
    End Sub

    ''' <summary>
    ''' Numerical buttons (0-9) share this handler.
    ''' The sender Button.Text is appended to the display.
    ''' We use culture-agnostic text appending here; parsing happens when performing calculations.
    ''' </summary>
    Private Sub ButtonNumerical_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button5.Click, Button6.Click, Button7.Click, Button9.Click, Button10.Click, Button11.Click, Button14.Click
        ManageNumricalInput(sender)
    End Sub

    ''' <summary>
    ''' Clears visible controls used by the calculator.
    ''' This does not clear any engine-level state because the current implementation keeps state in labels.
    ''' </summary>
    Private Sub ClearDisplay()
        Me.txtDisplay.Text = String.Empty
        Me.lblFirstNumber.Text = String.Empty
        Me.lblOperator.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Decimal separator button: inserts the decimal separator defined by the current culture.
    ''' Uses CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator to show dot or comma
    ''' depending on user/system locale.
    ''' </summary>
    Private Sub ButtonDecimal_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim decSeparator As String = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

        ' Prevent inserting multiple decimal separators
        If Not Me.txtDisplay.Text.Contains(decSeparator) Then
            If Me.txtDisplay.Text = String.Empty Then
                ' When starting a fractional number, show leading zero (e.g. "0," or "0.")
                Me.txtDisplay.Text = "0"
            End If

            ' Append the culture-specific decimal separator
            Me.txtDisplay.Text &= decSeparator
        End If
    End Sub

    ''' <summary>
    ''' Append numeric button text to display.
    ''' Uses '&=' for string concatenation to avoid VB's '+' ambiguity.
    ''' </summary>
    Private Sub ManageNumricalInput(sender As Object)

        Dim button As Button = CType(sender, Button)
        If Me.txtDisplay.Text = String.Empty Then
            Me.txtDisplay.Text = button.Text
        Else
            ' Use string concatenation operator (&=) to avoid implicit numeric addition
            Me.txtDisplay.Text &= button.Text
        End If

    End Sub

    ''' <summary>
    ''' Operator buttons (+, -, x, %) set the first operand and operator label.
    ''' Parsing/validation occurs when the user presses equals.
    ''' </summary>
    Private Sub ButtonOperator_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button17.Click, Button8.Click, Button12.Click
        ManageOperatorInput(sender)
    End Sub

    Private Sub ManageOperatorInput(sender As Object)
        Dim button As Button = CType(sender, Button)

        ' Move the current display into lblFirstNumber for later evaluation
        If Not (String.IsNullOrEmpty(Me.txtDisplay.Text)) Then
            Me.lblFirstNumber.Text = Me.txtDisplay.Text
            Me.txtDisplay.Text = String.Empty
        End If

        ' Only set operator if we have a first number
        If Not (String.IsNullOrEmpty(Me.lblFirstNumber.Text)) Then
            Me.lblOperator.Text = button.Text
        End If

    End Sub

    ''' <summary>
    ''' Evaluate the expression when equals is pressed.
    ''' Uses CalculatorEngine helpers (ParseDisplayToDouble/FormatDoubleForDisplay) which respect the current culture.
    ''' Shows error messages for invalid input or divide-by-zero.
    ''' </summary>
    Private Sub ManageEqualInput(sender As Object)

        Dim firstValue As Double
        Dim secondValue As Double

        ' Parse the first/second operands using culture-aware parsing
        If Not CalculatorEngine.TryParseDisplayToDouble(Me.lblFirstNumber.Text, firstValue) Then
            MessageBox.Show("Invalid first number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not CalculatorEngine.TryParseDisplayToDouble(Me.txtDisplay.Text, secondValue) Then
            MessageBox.Show("Invalid second number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            Dim result As Double
            If CalculatorEngine.TryCalculate(firstValue, secondValue, Me.lblOperator.Text, result) Then
                Me.txtDisplay.Text = CalculatorEngine.FormatDoubleForDisplay(result)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred during calculation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDisplay()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ManageEqualInput(sender)
    End Sub

End Class