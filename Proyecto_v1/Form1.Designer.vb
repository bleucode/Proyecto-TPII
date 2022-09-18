<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BAgenda = New System.Windows.Forms.Button()
        Me.BProfesionales = New System.Windows.Forms.Button()
        Me.BPacientes = New System.Windows.Forms.Button()
        Me.BTurnos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TMes = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BAgenda)
        Me.Panel1.Controls.Add(Me.BProfesionales)
        Me.Panel1.Controls.Add(Me.BPacientes)
        Me.Panel1.Controls.Add(Me.BTurnos)
        Me.Panel1.Location = New System.Drawing.Point(12, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 503)
        Me.Panel1.TabIndex = 0
        '
        'BAgenda
        '
        Me.BAgenda.BackColor = System.Drawing.SystemColors.Info
        Me.BAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BAgenda.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BAgenda.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BAgenda.ForeColor = System.Drawing.Color.White
        Me.BAgenda.Location = New System.Drawing.Point(17, 392)
        Me.BAgenda.Name = "BAgenda"
        Me.BAgenda.Size = New System.Drawing.Size(191, 43)
        Me.BAgenda.TabIndex = 5
        Me.BAgenda.Text = "AGENDA"
        Me.BAgenda.UseVisualStyleBackColor = False
        '
        'BProfesionales
        '
        Me.BProfesionales.BackColor = System.Drawing.SystemColors.Info
        Me.BProfesionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BProfesionales.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BProfesionales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BProfesionales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BProfesionales.Location = New System.Drawing.Point(17, 289)
        Me.BProfesionales.Name = "BProfesionales"
        Me.BProfesionales.Size = New System.Drawing.Size(191, 43)
        Me.BProfesionales.TabIndex = 4
        Me.BProfesionales.Text = "PROFESIONALES"
        Me.BProfesionales.UseVisualStyleBackColor = False
        '
        'BPacientes
        '
        Me.BPacientes.BackColor = System.Drawing.SystemColors.Info
        Me.BPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BPacientes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BPacientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BPacientes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BPacientes.Location = New System.Drawing.Point(17, 180)
        Me.BPacientes.Name = "BPacientes"
        Me.BPacientes.Size = New System.Drawing.Size(191, 43)
        Me.BPacientes.TabIndex = 3
        Me.BPacientes.Text = "PACIENTES"
        Me.BPacientes.UseVisualStyleBackColor = False
        '
        'BTurnos
        '
        Me.BTurnos.BackColor = System.Drawing.SystemColors.Info
        Me.BTurnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTurnos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTurnos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BTurnos.ForeColor = System.Drawing.SystemColors.Info
        Me.BTurnos.Location = New System.Drawing.Point(17, 70)
        Me.BTurnos.Name = "BTurnos"
        Me.BTurnos.Size = New System.Drawing.Size(191, 43)
        Me.BTurnos.TabIndex = 2
        Me.BTurnos.Text = "TURNOS"
        Me.BTurnos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 153)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(271, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1049, 649)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(1072, 53)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TMes)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(327, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 76)
        Me.Panel2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(567, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(629, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TMes
        '
        Me.TMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TMes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TMes.Location = New System.Drawing.Point(31, 24)
        Me.TMes.Name = "TMes"
        Me.TMes.Size = New System.Drawing.Size(312, 22)
        Me.TMes.TabIndex = 6
        Me.TMes.Text = "ENERO, 2022"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(327, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(690, 26)
        Me.Panel3.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 26)
        Me.Panel4.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(81, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(84, 26)
        Me.Panel5.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.IndianRed
        Me.Panel6.Location = New System.Drawing.Point(155, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 26)
        Me.Panel6.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1338, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTurnos As Button
    Friend WithEvents BPacientes As Button
    Friend WithEvents BAgenda As Button
    Friend WithEvents BProfesionales As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TMes As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
