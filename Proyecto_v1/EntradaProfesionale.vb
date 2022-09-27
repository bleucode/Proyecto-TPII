Imports System.Runtime.InteropServices

Public Class EntradaProfesionales

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrEmpty(txtNombreProfesional.Text) = False And String.IsNullOrEmpty(txtApellidoProfesional.Text) = False And (String.IsNullOrEmpty(DniProfesional.Text) = False And IsNumeric(DniProfesional.Text) = True) Then
            TablaProfesionales.DataGridView1.Rows.Add(txtNombreProfesional.Text,
                                                      txtApellidoProfesional.Text,
                                                      DniProfesional.Text,
                                                      LocalidadProfesional.Text,
                                                      ProvinciaProfesional.Text,
                                                      DireccionProfesional.Text,
                                                      NroTelProfesional.Text,
                                                      "#",
                                                      dtpIngre.Value,
                                                      dtpNacimiento.Value,
                                                      EmailProfesional.Text)
            MsgBox("Se insertó un nuevo Profesional", vbInformation, "Exito")
            Me.Hide()
        Else
            MsgBox("Hay campos requeridos", vbCritical, "Requerido")
        End If
    End Sub


End Class