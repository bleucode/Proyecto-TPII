Imports System.Runtime.InteropServices
Public Class LogginForm
#Region "Form Behaviors"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region
#Region "Customize Controls"
    Private Sub CustomizeComponents()
        'txtUsuario
        txtUsuario.AutoSize = False
        'txtUsuario.Size = New Size(350, 35)
        'txtContrasenia
        txtContrasenia.AutoSize = False
        'txtContrasenia.Size = New Size(350, 35)
        txtContrasenia.UseSystemPasswordChar = True
    End Sub
    Private Sub butIngresar_Paint(sender As Object, e As PaintEventArgs) Handles butIngresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = butIngresar.ClientRectangle
        myRectangle.Inflate(0, 20)
        buttonPath.AddEllipse(myRectangle)
        butIngresar.Region = New Region(buttonPath)
    End Sub
#End Region
#Region "Botones"
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub

    Private Sub butIngresar_Click(sender As Object, e As EventArgs) Handles butIngresar.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txtUsuario.Text
        contraseña = txtContrasenia.Text
        If (usuario = "admin") And (contraseña = "123456") Then
            MsgBox("Bienvenido Administrador al Sistema del Hospital", vbInformation, "Sistema")
            FormPrincipal.Show()
            Me.Hide()
        ElseIf usuario = "secre" And contraseña = "123456" Then
            MsgBox("Bienvenid@ Secretari@ al Sistema del Hospital", vbInformation, "Sistema")
            FormPrincipal.Show()
            Me.Hide()
        ElseIf usuario = "" And contraseña = "" Then
            MsgBox("Rellene los campos", vbCritical, "Sistema")
        Else
            MsgBox("Los datos intruducidos son Incorrectos", vbCritical, "Sistema")
        End If

        txtUsuario.Text = ""
        txtContrasenia.Text = ""
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se permite LETRAS", MessageBoxIcon.Warning, "Sistema")
        End If
    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtContrasenia.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se permite NUMEROS", MessageBoxIcon.Warning, "Sistema")
        End If
    End Sub
#End Region
End Class
