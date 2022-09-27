Imports System.Runtime.InteropServices

Public Class FormMantPacientes
#Region "BOTONES PARTE SUPERIOR"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnC.Click
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
#End Region
#Region "RESTRICCIONES"
    Private Sub txtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimiento.ValueChanged
        dtpNacimiento.MaxDate = DateTime.Today
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpAlta.ValueChanged
        dtpAlta.MaxDate = DateTime.Today
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtLoc.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtProv.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtTelef.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDirec_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDirec.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ask As MsgBoxResult = MsgBox("Se perderán los datos no guardados", MsgBoxStyle.YesNo, "Salir")
        If ask = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub
#End Region
    Private mru As FormPacientes
    'Public Sub New(ByVal multrows As FormPacientes)
    '    InitializeComponent()
    '    Me.mru = multrows
    'End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim obraSoc As Integer
        If cbOS.Text = "Ioscor" Then
            obraSoc = 1
        Else
            obraSoc = 2
        End If

        FormPacientes.DataGridView1.Rows.Add(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtLoc.Text, txtProv.Text, txtDirec.Text, txtTelef.Text, "#", dtpAlta.Value, obraSoc, dtpNacimiento.Value, txtEmail.Text)
        MsgBox("Se insertó un nuevo Paciente", vbInformation, "Exito")
        Me.Hide()
        'mru.DataGridView1.CurrentRow.Cells(1).Value = txtNombre.Text
        'mru.DataGridView1.CurrentRow.Cells(2).Value = txtApellido.Text
        'mru.DataGridView1.CurrentRow.Cells(3).Value = txtDNI.Text
        'mru.DataGridView1.CurrentRow.Cells(4).Value = txtLoc.Text
        'mru.DataGridView1.CurrentRow.Cells(5).Value = txtProv.Text
        'mru.DataGridView1.CurrentRow.Cells(6).Value = txtDirec.Text
        'mru.DataGridView1.CurrentRow.Cells(7).Value = txtTelef.Text
        'mru.DataGridView1.CurrentRow.Cells(8).Value = "#"
        'mru.DataGridView1.CurrentRow.Cells(9).Value = dtpAlta.Value
        'mru.DataGridView1.CurrentRow.Cells(10).Value = obraSoc
        'mru.DataGridView1.CurrentRow.Cells(11).Value = dtpNacimiento.Value
        'mru.DataGridView1.CurrentRow.Cells(12).Value = txtEmail.Text
        'Me.Close()
    End Sub


End Class