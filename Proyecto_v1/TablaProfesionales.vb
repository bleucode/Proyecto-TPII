Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TablaProfesionales
    Private dtTable As New DataTable
    Private dtTableGrd As DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EntradaProfesionales.ShowDialog()
    End Sub

    Private Sub TablaProfesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class