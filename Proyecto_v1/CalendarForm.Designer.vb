<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PDia5 = New System.Windows.Forms.Panel()
        Me.PDia4 = New System.Windows.Forms.Panel()
        Me.PDia3 = New System.Windows.Forms.Panel()
        Me.PDia2 = New System.Windows.Forms.Panel()
        Me.PDia1 = New System.Windows.Forms.Panel()
        Me.PDia0 = New System.Windows.Forms.Panel()
        Me.PDia = New System.Windows.Forms.Panel()
        Me.PMesAnio = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PDia5
        '
        Me.PDia5.BackColor = System.Drawing.Color.DodgerBlue
        Me.PDia5.Location = New System.Drawing.Point(12, 406)
        Me.PDia5.Name = "PDia5"
        Me.PDia5.Size = New System.Drawing.Size(776, 49)
        Me.PDia5.TabIndex = 15
        '
        'PDia4
        '
        Me.PDia4.BackColor = System.Drawing.Color.AliceBlue
        Me.PDia4.Location = New System.Drawing.Point(12, 349)
        Me.PDia4.Name = "PDia4"
        Me.PDia4.Size = New System.Drawing.Size(776, 49)
        Me.PDia4.TabIndex = 14
        '
        'PDia3
        '
        Me.PDia3.BackColor = System.Drawing.Color.SteelBlue
        Me.PDia3.Location = New System.Drawing.Point(12, 294)
        Me.PDia3.Name = "PDia3"
        Me.PDia3.Size = New System.Drawing.Size(776, 49)
        Me.PDia3.TabIndex = 13
        '
        'PDia2
        '
        Me.PDia2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PDia2.Location = New System.Drawing.Point(12, 239)
        Me.PDia2.Name = "PDia2"
        Me.PDia2.Size = New System.Drawing.Size(776, 49)
        Me.PDia2.TabIndex = 12
        '
        'PDia1
        '
        Me.PDia1.BackColor = System.Drawing.Color.SkyBlue
        Me.PDia1.Location = New System.Drawing.Point(12, 184)
        Me.PDia1.Name = "PDia1"
        Me.PDia1.Size = New System.Drawing.Size(776, 49)
        Me.PDia1.TabIndex = 11
        '
        'PDia0
        '
        Me.PDia0.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PDia0.Location = New System.Drawing.Point(12, 124)
        Me.PDia0.Name = "PDia0"
        Me.PDia0.Size = New System.Drawing.Size(776, 49)
        Me.PDia0.TabIndex = 10
        '
        'PDia
        '
        Me.PDia.BackColor = System.Drawing.Color.LightBlue
        Me.PDia.Location = New System.Drawing.Point(12, 73)
        Me.PDia.Name = "PDia"
        Me.PDia.Size = New System.Drawing.Size(776, 31)
        Me.PDia.TabIndex = 9
        '
        'PMesAnio
        '
        Me.PMesAnio.BackColor = System.Drawing.Color.PowderBlue
        Me.PMesAnio.Location = New System.Drawing.Point(12, -5)
        Me.PMesAnio.Name = "PMesAnio"
        Me.PMesAnio.Size = New System.Drawing.Size(776, 61)
        Me.PMesAnio.TabIndex = 8
        '
        'CalendarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 464)
        Me.Controls.Add(Me.PDia5)
        Me.Controls.Add(Me.PDia4)
        Me.Controls.Add(Me.PDia3)
        Me.Controls.Add(Me.PDia2)
        Me.Controls.Add(Me.PDia1)
        Me.Controls.Add(Me.PDia0)
        Me.Controls.Add(Me.PDia)
        Me.Controls.Add(Me.PMesAnio)
        Me.Name = "CalendarForm"
        Me.Text = "CalendarForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PDia5 As Panel
    Friend WithEvents PDia4 As Panel
    Friend WithEvents PDia3 As Panel
    Friend WithEvents PDia2 As Panel
    Friend WithEvents PDia1 As Panel
    Friend WithEvents PDia0 As Panel
    Friend WithEvents PDia As Panel
    Friend WithEvents PMesAnio As Panel
    Friend WithEvents BNext As Button
    Friend WithEvents BPrev As Button
End Class
