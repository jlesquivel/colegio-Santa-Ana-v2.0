Public Class cEstudiantes

    Private acarnet As String
    Dim conn As New conexionSQL

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

    Public Function RecibosPendientes() As DataTable
        Dim dt As DataTable
        dt = conn.llenaTabla("exec RecibosPendientes " & acarnet)
        RecibosPendientes = dt
    End Function

    Public Function RPendientes() As Boolean
        RPendientes = RecibosPendientes.Rows.Count > 0
    End Function
End Class
