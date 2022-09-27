
Public Class FormPacientes
#Region "BOTONES"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMantPacientes.ShowDialog()
    End Sub

    Private Sub FormPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class