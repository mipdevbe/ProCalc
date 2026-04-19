Imports System.Globalization
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace TestProCalc
    <TestClass()> Public Class CalculatorEngineTests
        <TestMethod()>
        Public Sub Parse_WithEnglishCulture_ParsesDot()
            Dim culture As CultureInfo = New CultureInfo("en-US")
            Dim value As Double
            Dim ok = CalculatorEngine.TryParseDisplayToDouble("1.5", value, culture)
            Assert.IsTrue(ok)
            Assert.AreEqual(1.5, value)
        End Sub

        <TestMethod()>
        Public Sub Parse_WithGermanCulture_ParsesComma()
            Dim culture As CultureInfo = New CultureInfo("de-DE")
            Dim value As Double
            Dim ok = CalculatorEngine.TryParseDisplayToDouble("1,5", value, culture)
            Assert.IsTrue(ok)
            Assert.AreEqual(1.5, value)
        End Sub

        <TestMethod()>
        Public Sub Calculate_Addition_Works()
            Dim res As Double
            Dim ok = CalculatorEngine.TryCalculate(2, 3, "+", res)
            Assert.IsTrue(ok)
            Assert.AreEqual(5, res)
        End Sub

        <TestMethod()>
        Public Sub Calculate_DivideByZero_ReturnsFalse()
            Dim res As Double
            Dim ok = CalculatorEngine.TryCalculate(2, 0, "%", res)
            Assert.IsFalse(ok)
        End Sub
    End Class

End Namespace

