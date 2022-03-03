Public Class Form1

    Function restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim NuevoTexto As String
        numero = numero - 1
        NuevoTexto = numero.ToString()
        Return NuevoTexto
    End Function


    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim NuevoTexto As String
        numero = numero + 1
        NuevoTexto = numero.ToString()
        Return NuevoTexto
    End Function
    Private Sub btnAmenos_Click(sender As Object, e As EventArgs) Handles btnAmenos.Click
        Dim NumeroEntrante As String = lbA.Text
        NumeroEntrante = restar(NumeroEntrante)
        lbA.Text = NumeroEntrante
    End Sub

    Private Sub btnAmas_Click(sender As Object, e As EventArgs) Handles btnAmas.Click
        Dim NumeroEntrante As String = lbA.Text
        NumeroEntrante = Aumentar(NumeroEntrante)
        lbA.Text = NumeroEntrante
    End Sub

    Private Sub btnBmenos_Click(sender As Object, e As EventArgs) Handles btnBmenos.Click
        Dim NumeroEntrante As String = lbB.Text
        NumeroEntrante = restar(NumeroEntrante)
        lbB.Text = NumeroEntrante
    End Sub

    Private Sub btnBmas_Click(sender As Object, e As EventArgs) Handles btnBmas.Click
        Dim NumeroEntrante As String = lbB.Text
        NumeroEntrante = Aumentar(NumeroEntrante)
        lbB.Text = NumeroEntrante
    End Sub

    Function Suma(numeroA As Integer, NumeroB As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA + NumeroB
        Return resultado
    End Function

    Function Resta(numeroA As Integer, NumeroB As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA - NumeroB
        Return resultado
    End Function

    Function Multiplicar(numeroA As Integer, NumeroB As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA * NumeroB
        Return resultado
    End Function

    Function Dividir(numeroA As Double, NumeroB As Double) As Double
        Dim resultado As Double
        resultado = numeroA / NumeroB
        Return resultado
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtA = lbA.Text
        Dim NumA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim NumB = Int32.Parse(txtB)

        Dim ResultadoSuma = Suma(NumA, NumB)

        lbResultado.Text = "El Resultado de A + B es: " + ResultadoSuma.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtA = lbA.Text
        Dim NumA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim NumB = Int32.Parse(txtB)

        Dim ResultadoResta = Resta(NumA, NumB)

        lbResultado.Text = "El Resultado de A - B es: " + ResultadoResta.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txtA = lbA.Text
        Dim NumA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim NumB = Int32.Parse(txtB)

        Dim ResultadoMultiplicacion = Multiplicar(NumA, NumB)

        lbResultado.Text = "El Resultado de A * B es: " + ResultadoMultiplicacion.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim txtA = lbA.Text
        Dim NumA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim NumB = Int32.Parse(txtB)

        Dim ResultadoDividir = Dividir(NumA, NumB)

        lbResultado.Text = "El Resultado de A / B es: " + ResultadoDividir.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lbA.Text = "0"
        lbB.Text = "0"
        lbResultado.Text = "El Resultado es:"
    End Sub
End Class
