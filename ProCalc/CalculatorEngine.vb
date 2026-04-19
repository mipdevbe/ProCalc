Imports System.Globalization

''' <summary>
''' Testable engine that encapsulates parsing/formatting and arithmetic.
''' Keep UI code thin and delegate calculation/parsing to this class so it can be unit-tested.
''' </summary>
Public Class CalculatorEngine

    ''' <summary>
    ''' Try to parse a displayed number using the provided culture (or current culture if Nothing).
    ''' Returns True when parse succeeds and sets <paramref name="value"/>.
    ''' </summary>
    Public Shared Function TryParseDisplayToDouble(text As String, ByRef value As Double, Optional culture As CultureInfo = Nothing) As Boolean
        If culture Is Nothing Then
            culture = CultureInfo.CurrentCulture
        End If

        Return Double.TryParse(text, Globalization.NumberStyles.Float Or Globalization.NumberStyles.AllowThousands, culture, value)
    End Function

    ''' <summary>
    ''' Format a double for display using the provided culture (or current culture if Nothing).
    ''' </summary>
    Public Shared Function FormatDoubleForDisplay(value As Double, Optional culture As CultureInfo = Nothing) As String
        If culture Is Nothing Then
            culture = CultureInfo.CurrentCulture
        End If

        Return value.ToString(culture)
    End Function

    ''' <summary>
    ''' Try to perform the arithmetic operation. Returns True on success and sets result.
    ''' For division by zero, returns False.
    ''' Supported operators: "+", "-", "x", "%".
    ''' </summary>
    Public Shared Function TryCalculate(first As Double, second As Double, op As String, ByRef result As Double) As Boolean
        Dim ret As Boolean = True

        Select Case op
            Case "+"
                result = first + second
            Case "-"
                result = first - second
            Case "x", "*"
                result = first * second
            Case "%", "/"
                If second = 0 Then
                    Throw New DivideByZeroException("Cannot divide by zero.")
                End If

                result = first / second
            Case Else
                result = 0
                ret = False
        End Select

        Return ret
    End Function

End Class

