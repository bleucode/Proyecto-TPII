Imports System.Runtime.InteropServices

Public Class EntradaTurnos
    Private _InfoCalendario As MesCalendarioInfo
    Private Sub EntradaTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Hora.CustomFormat = "HH:mm"

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrEmpty(txtApellido.Text) = False And String.IsNullOrEmpty(txtApeProfesional.Text) = False And (String.IsNullOrEmpty(DNIProfesional.Text) = False And IsNumeric(DNIProfesional.Text) = True) And (String.IsNullOrEmpty(txtDNI.Text) = False And IsNumeric(txtDNI.Text) = True) Then
            TablaTurnos.DataGridView1.Rows.Add(dtpTurno.Value, Hora.Value, txtApellido.Text, txtNombre.Text, txtDNI.Text, txtApeProfesional.Text, DNIProfesional.Text, txtNombreProfesional.Text)
            Debug.Print(dtpTurno.Value)
            MsgBox("Se insertó un nuevo Turno", vbInformation, "Exito")
            Me.Hide()
        Else
            MsgBox("Hay campos requeridos", vbCritical, "Requerido")
            Me.Hide()
        End If
    End Sub

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
End Class