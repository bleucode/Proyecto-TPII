Public Class MesCalendarioInfo
    Private _Mes As Integer
    Private _Anio As Integer
    Private ReadOnly _Dias(5, 6) As DateTime

    Public ReadOnly Property Month
        Get
            Return _Mes
        End Get
    End Property

    Public ReadOnly Property Anio
        Get
            Return _Anio
        End Get
    End Property

    Public Sub New()
        _Mes = Now.Month
        _Anio = Now.Year
        SetDia()
    End Sub

    Public Sub New(anio As Integer, mes As Integer)
        If anio < 1 Or anio > 9999 Then
            Throw New ArgumentOutOfRangeException("anio")
        End If

        If mes < 1 Or mes > 12 Then
            Throw New ArgumentOutOfRangeException("mes")
        End If

        _Mes = mes
        _Anio = anio
        SetDia()
    End Sub

    Private Sub SetDia()
        Dim primerDia As DateTime
        Dim columna As Integer
        Dim primerDiaGrid As DateTime
        Dim gridFecha As DateTime

        primerDia = New Date(_Anio, _Mes, 1)
        columna = CInt(primerDia.DayOfWeek)
        primerDiaGrid = primerDia.AddDays(columna * -1)

        gridFecha = primerDiaGrid

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                _Dias(rowIndex, colIndex) = gridFecha
                gridFecha = gridFecha.AddDays(1)
            Next
        Next

        Return

    End Sub

    Public Sub IrAlMes(anio As Integer, mes As Integer)
        If anio < 1 Or anio > 9999 Then
            Throw New ArgumentOutOfRangeException("anio")
        End If

        If mes < 1 Or mes > 12 Then
            Throw New ArgumentOutOfRangeException("mes")
        End If

        _Mes = mes
        _Anio = anio
        SetDia()
    End Sub

    Public Function DiaEnMes(fila As Integer, columna As Integer) As Integer
        If fila < 0 Or fila > 5 Then
            Throw New ArgumentOutOfRangeException("fila")
        End If

        If columna < 0 Or columna > 6 Then
            Throw New ArgumentOutOfRangeException("columna")
        End If

        Return _Dias(fila, columna).Day
    End Function

    Public Function EsMesActivo(fila As Integer, columna As Integer) As Boolean
        If fila < 0 Or fila > 5 Then
            Throw New ArgumentOutOfRangeException("fila")
        End If

        If columna < 0 Or columna > 6 Then
            Throw New ArgumentOutOfRangeException("columna")
        End If

        Return _Dias(fila, columna).Month = Month

    End Function

    Public Function EsHoy(fila As Integer, columna As Integer) As Boolean
        If fila < 0 Or fila > 5 Then
            Throw New ArgumentOutOfRangeException("fila")
        End If

        If columna < 0 Or columna > 6 Then
            Throw New ArgumentOutOfRangeException("columna")
        End If

        Return _Dias(fila, columna).Date = Now.Date
    End Function

    Public Function Fila(dt As DateTime) As Integer
        Dim colIndex = 0
        Dim rowIndex = 0

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                If _Dias(rowIndex, colIndex) = dt Then
                    Return rowIndex
                End If
            Next
        Next

        Return -1
    End Function

    Public Function Col(dt As DateTime) As Integer
        Dim colIndex = 0
        Dim rowIndex = 0

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                If _Dias(rowIndex, colIndex) = dt Then
                    Return colIndex
                End If
            Next
        Next

        Return -1
    End Function

    Public Function ExisteDia(dt As DateTime) As Boolean
        If Fila(dt) > -1 Then
            Return True
        End If

        Return False

    End Function
End Class
