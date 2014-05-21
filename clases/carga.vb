Public Class carga
    ' declaro la variable que uso para asignar o obtener el valor del Codigo
    ' es de tipo object porque el valor puede ser un valor num�rico o alfanum�rico
    Private mCodigo As Object
    ' declaro la variable que uso para asignar o obtener el valor de la Descripci�n
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

    ' declaro el m�todo New de la clase Carga
    Public Sub New(ByVal InitCodigo As Object, ByVal InitDescripcion As String)
        mCodigo = InitCodigo
        mDescripcion = InitDescripcion
    End Sub
End Class
