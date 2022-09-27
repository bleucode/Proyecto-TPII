<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimized = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lbNombreUsuario = New System.Windows.Forms.Label()
        Me.lbContrasenia = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.butIngresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleBar.SuspendLayout()
        CType(Me.btnMinimized, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.DodgerBlue
        Me.TitleBar.Controls.Add(Me.btnMinimized)
        Me.TitleBar.Controls.Add(Me.btnClose)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Margin = New System.Windows.Forms.Padding(2)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(514, 30)
        Me.TitleBar.TabIndex = 0
        '
        'btnMinimized
        '
        Me.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimized.Image = Global.Proyecto_v1.My.Resources.Resources.menos
        Me.btnMinimized.Location = New System.Drawing.Point(436, 2)
        Me.btnMinimized.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(28, 24)
        Me.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimized.TabIndex = 2
        Me.btnMinimized.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Proyecto_v1.My.Resources.Resources.x
        Me.btnClose.Location = New System.Drawing.Point(476, 2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 24)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 2
        Me.btnClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 370)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 9)
        Me.Panel1.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.DimGray
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(131, 182)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(245, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'lbNombreUsuario
        '
        Me.lbNombreUsuario.AutoSize = True
        Me.lbNombreUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbNombreUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbNombreUsuario.Location = New System.Drawing.Point(131, 153)
        Me.lbNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNombreUsuario.Name = "lbNombreUsuario"
        Me.lbNombreUsuario.Size = New System.Drawing.Size(70, 21)
        Me.lbNombreUsuario.TabIndex = 3
        Me.lbNombreUsuario.Text = "Usuario:"
        '
        'lbContrasenia
        '
        Me.lbContrasenia.AutoSize = True
        Me.lbContrasenia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbContrasenia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbContrasenia.Location = New System.Drawing.Point(131, 233)
        Me.lbContrasenia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbContrasenia.Name = "lbContrasenia"
        Me.lbContrasenia.Size = New System.Drawing.Size(107, 21)
        Me.lbContrasenia.TabIndex = 5
        Me.lbContrasenia.Text = "Contraseña:"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.BackColor = System.Drawing.Color.DimGray
        Me.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasenia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContrasenia.ForeColor = System.Drawing.Color.White
        Me.txtContrasenia.Location = New System.Drawing.Point(131, 261)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(245, 20)
        Me.txtContrasenia.TabIndex = 4
        '
        'butIngresar
        '
        Me.butIngresar.BackColor = System.Drawing.Color.RoyalBlue
        Me.butIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butIngresar.FlatAppearance.BorderSize = 0
        Me.butIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butIngresar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.butIngresar.Location = New System.Drawing.Point(131, 322)
        Me.butIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.butIngresar.Name = "butIngresar"
        Me.butIngresar.Size = New System.Drawing.Size(245, 29)
        Me.butIngresar.TabIndex = 7
        Me.butIngresar.Text = "Ingresar"
        Me.butIngresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_v1.My.Resources.Resources.logo_hospital
        Me.PictureBox1.Location = New System.Drawing.Point(173, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'LogginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 379)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.butIngresar)
        Me.Controls.Add(Me.lbContrasenia)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.lbNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TitleBar)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LogginForm"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TitleBar.ResumeLayout(False)
        CType(Me.btnMinimized, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleBar As Panel
    Friend WithEvents btnMinimized As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lbNombreUsuario As Label
    Friend WithEvents lbContrasenia As Label
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents butIngresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
