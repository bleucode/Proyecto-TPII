Public Class CalendarForm
    Private _InfoCalendario As MesCalendarioInfo
    Private currentDate As DateTime = DateTime.Today
    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SizeContainers()
        CrearMesAnio()
        TamanioMesAnio()
        CrearDias()
        TamanioDias()
        CrearDia()
        TamanioDia()
        _InfoCalendario = New MesCalendarioInfo(2022, 9)
        LlenarCalendario()
        CrearDatos()

    End Sub

    Private Sub SizeContainers()
        Dim altura As Integer
        Dim comienzoDia As Integer

        PMesAnio.Size = New Size(ClientSize.Width, 50)
        PMesAnio.Location = New Point(0, 0)
        PDia.Size = New Size(ClientSize.Width, 30)
        PDia.Location = New Point(0, PMesAnio.Height)

        altura = (ClientSize.Height - PMesAnio.Height - PDia.Height) / 6
        comienzoDia = PMesAnio.Height + PDia.Height

        PDia0.Size = New Size(ClientSize.Width, altura)
        PDia0.Location = New Point(0, comienzoDia)
        PDia1.Size = New Size(ClientSize.Width, altura)
        PDia1.Location = New Point(0, comienzoDia + (altura))
        PDia2.Size = New Size(ClientSize.Width, altura)
        PDia2.Location = New Point(0, comienzoDia + (altura * 2))
        PDia3.Size = New Size(ClientSize.Width, altura)
        PDia3.Location = New Point(0, comienzoDia + (altura * 3))
        PDia4.Size = New Size(ClientSize.Width, altura)
        PDia4.Location = New Point(0, comienzoDia + (altura * 4))
        PDia5.Size = New Size(ClientSize.Width, altura)
        PDia5.Location = New Point(0, comienzoDia + (altura * 5))


    End Sub

    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        SizeContainers()
        TamanioMesAnio()
        TamanioDias()
        TamanioDia()
    End Sub

    Private Sub CrearMesAnio()
        Dim lbl As Label = New Label()

        lbl.Name = "lblMesAnio"
        lbl.Font = New Font("Segoe UI", 18, FontStyle.Regular)
        lbl.AutoSize = True
        lbl.Text = "Mes Año"

        PMesAnio.Controls.Add(lbl)
    End Sub

    Private Sub TamanioMesAnio()
        Dim x As Integer
        Dim y As Integer
        Dim lbl As Label

        If PMesAnio.Controls.Count > 0 Then
            lbl = PMesAnio.Controls.Find("lblMesAnio", False).First
            x = (PMesAnio.Width - lbl.Width) / 2
            y = (PMesAnio.Height - lbl.Height) / 2
            lbl.Location = New Point(x, y)
        End If

    End Sub

    Private Sub CrearDias()
        Dim lbl As Label
        Dim dias As String() = New String(6) {"Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"}

        For i = 0 To 6
            lbl = New Label
            lbl.Name = String.Format("lbl{0}", dias(1))
            lbl.Text = dias(i)
            lbl.AutoSize = False
            lbl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            PDia.Controls.Add(lbl)
        Next
    End Sub

    Private Sub TamanioDias()
        TamanioAnchoIgual(PDia)
    End Sub

    Private Sub TamanioAnchoIgual(ByVal c As Control)
        Dim ancho As Integer
        Dim x As Integer

        If c.Controls.Count = 0 Then
            Return
        End If

        ancho = c.Width / c.Controls.Count

        For Each ctrl As Control In c.Controls
            ctrl.Height = c.Height
            ctrl.Width = ancho
            ctrl.Location = New Point(x, 0)
            x += ancho
        Next

    End Sub

    Private Sub CrearDia()
        Dim panelDia As Panel
        Dim diaMesLbl As Label

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                panelDia = New Panel
                panelDia.Name = String.Format("DiaPnl{0}{1}", rowIndex, colIndex)
                diaMesLbl = New Label
                diaMesLbl.Name = String.Format("lblDiaMes{0}{1}", rowIndex, colIndex)
                diaMesLbl.Text = diaMesLbl.Name
                panelDia.Controls.Add(diaMesLbl)

                Select Case rowIndex
                    Case 0
                        PDia0.Controls.Add(panelDia)
                    Case 1
                        PDia1.Controls.Add(panelDia)
                    Case 2
                        PDia2.Controls.Add(panelDia)
                    Case 3
                        PDia3.Controls.Add(panelDia)
                    Case 4
                        PDia4.Controls.Add(panelDia)
                    Case 5
                        PDia5.Controls.Add(panelDia)
                End Select
            Next
        Next
    End Sub

    Private Sub TamanioDia()
        TamanioAnchoIgual(PDia0)
        TamanioAnchoIgual(PDia1)
        TamanioAnchoIgual(PDia2)
        TamanioAnchoIgual(PDia3)
        TamanioAnchoIgual(PDia4)
        TamanioAnchoIgual(PDia5)

    End Sub

    Private Sub LlenarCalendario()
        Dim lbl As Control
        Dim lblName As String

        lbl = PMesAnio.Controls.Find("lblMesAnio", False).First
        lbl.Text = String.Format("{0}{1}", MonthName(_InfoCalendario.Month), _InfoCalendario.Anio)

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                lblName = String.Format("lblDiaMes{0}{1}", rowIndex, colIndex)
                lbl = Me.Controls.Find(lblName, True).First
                lbl.Text = _InfoCalendario.DiaEnMes(rowIndex, colIndex)

                If _InfoCalendario.EsMesActivo(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Black
                Else
                    lbl.ForeColor = Color.Gray
                End If

                If _InfoCalendario.EsHoy(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Red
                End If

            Next


        Next
    End Sub

    Public Sub CrearDatos()
        Dim fechas As New List(Of DateTime)
        Dim info As New List(Of String)
        Dim col As Integer
        Dim fila As Integer
        Dim pnl As Panel
        Dim lbl As Label
        Dim pnlNombre As String
        Dim pnlTurno As String
        fechas.Add(New Date(2022, 9, 20))
        fechas.Add(New Date(2022, 9, 18))
        fechas.Add(New Date(2022, 9, 16))

        pnlTurno = String.Format("Paciente:{0} - Medico: {1} - Hora: {2}", EntradaTurnos.txtNombre.Text, EntradaTurnos.txtApeProfesional.Text, EntradaTurnos.Hora.Value)
        info.Add(pnlTurno)
        info.Add(pnlTurno)
        info.Add(pnlTurno)

        For i = 0 To fechas.Count - 1
            If _InfoCalendario.ExisteDia(fechas(i)) Then
                col = _InfoCalendario.Col(fechas(i))
                fila = _InfoCalendario.Fila(fechas(i))
                pnlNombre = String.Format("DiaPnl{0}{1}", fila, col)
                pnl = Controls.Find(pnlNombre, True).First

                lbl = New LinkLabel
                lbl.Name = String.Format("lblTest{0}{1}", fila, col)
                lbl.BackColor = Color.Thistle
                lbl.Size = New Size(100, 100)
                lbl.Text = info(i)
                lbl.TextAlign = ContentAlignment.MiddleLeft
                lbl.Location = New Point(0, 25)
                pnl.Controls.Add(lbl)

            End If
        Next

    End Sub

    Private Sub PMesAnio_Click(sender As Object, e As EventArgs) Handles PMesAnio.Click
        Dim puntoClick As Point
        Dim midPointX As Integer
        Dim mesActivo As DateTime
        Dim mesNuevo As DateTime

        midPointX = PMesAnio.Width / 2
        puntoClick = PMesAnio.PointToClient(Cursor.Position)
        mesActivo = New Date(_InfoCalendario.Anio, _InfoCalendario.Month, 1)

        If puntoClick.X < midPointX Then
            mesNuevo = mesActivo.AddMonths(-1)
        Else
            mesNuevo = mesActivo.AddMonths(1)
        End If

        _InfoCalendario.IrAlMes(mesNuevo.Year, mesNuevo.Month)

        EliminarDatos(Me)
        LlenarCalendario()
        CrearDatos()


    End Sub

    Private Sub EliminarDatos(c As Control)
        For Each ctrl As Control In c.Controls
            EliminarDatos(ctrl)
        Next

        If c.Name.Contains("lblTest") Then
            c.Parent.Controls.Remove(c)
        End If
    End Sub

End Class