Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intNum As Integer
        intNum = 7
        intNum = intNum + 1
        MessageBox.Show("Valor: " & intNum.ToString, "Variaveis")
    End Sub
End Class
