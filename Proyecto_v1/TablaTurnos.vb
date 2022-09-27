Public Class TablaTurnos
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EntradaTurnos.ShowDialog()
    End Sub
End Class