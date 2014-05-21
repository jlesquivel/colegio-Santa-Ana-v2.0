Public Class carga
    ' declaro la variable que uso para asignar o obtener el valor del Codigo
    ' es de tipo object porque el valor puede ser un valor numérico o alfanumérico
    Private mCodigo As Object
    ' declaro la variable que uso para asignar o obtener el valor de la Descripción
    Private mDescripcion As String

    ' declaro la propiedad Codigo de la clase Carga
    Public Property Codigo() As Object
        Get
            Return mCodigo
        End Get
        Set(ByVal Value As Object)
            mCodigo = Value
        End Set
    End Property

    ' declaro la propiedad Descripcion de la clase Carga
    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    ' declaro el método New de la clase Carga
    Public Sub New(ByVal InitCodigo As Object, ByVal InitDescripcion As String)
        mCodigo = InitCodigo
        mDescripcion = InitDescripcion
    End Sub
End Class
