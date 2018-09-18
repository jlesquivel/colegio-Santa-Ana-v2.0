Public Class cEstudiantes

    Private acarnet As String
    Dim conn As New ConexionSQL

    Sub New(pcarnet As String)
        acarnet = pcarnet
    End Sub

    Public Property carnet As String
        Get
            Return acarnet
        End Get
        Set(value As String)
            acarnet = value
        End Set
    End Property
#Region "Pendiente sin matricula"
    Public Function RecibosPendientes() As DataTable
        Dim dt As DataTable
        dt = conn.llenaTabla("exec RecibosPendientes " & acarnet)
        RecibosPendientes = dt
    End Function

    Public Function RPendientes() As Boolean
        RPendientes = RecibosPendientes.Rows.Count > 0
    End Function

    Public Function RPendientesCant() As Integer
        RPendientesCant = RecibosPendientes.Rows.Count
    End Function
#End Region


#Region "Pendiente incluye cobros matricula"
    Public Function TRecibosPendientes() As DataTable
        Dim dt As DataTable
        dt = conn.llenaTabla("exec RecibosPendientesTodos '" & acarnet & "'")
        TRecibosPendientes = dt
    End Function
    Public Function TRPendientes() As Boolean
        TRPendientes = TRecibosPendientes.Rows.Count > 0
    End Function

    Public Function TRPendientesCant() As Integer
        TRPendientesCant = TRecibosPendientes.Rows.Count
    End Function

    Public Function Traslado() As Integer
        'TODO hacer translado y eliminar cobros a parti de la fecha indicada

        Return 0
    End Function

    Public Function CambioGrupo() As Integer
        'TODO hacer cambio de grupo y actualizar monto de cobro si es necesario
        Return 0
    End Function




#End Region

End Class
