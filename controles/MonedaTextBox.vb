Imports System.ComponentModel

Public Class MonedaTextBox
    Inherits System.Windows.Forms.TextBox
    Dim teclado As Boolean = False
    Dim formatoI As formatos

    Enum formatos
        Moneda = 0
        Numero = 1
    End Enum
#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()
        TextAlign = HorizontalAlignment.Right

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region
    'COMENT : Coloca el mensaje para lenguaje
    <Description("Seleccione el formato del control"), Category("Format")> _
    Public Property FormatoText() As formatos
        Get
            Return formatoI

        End Get
        Set(ByVal Value As formatos)
            formatoI = Value
        End Set
    End Property


    Private Sub MonedaTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Validated
        MyBase.Text = convertirFormato(Text)
        teclado = False
    End Sub

    Private Sub MonedaTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        If teclado Then
        Else
            MyBase.Text = convertirFormato(Text)
            teclado = False
        End If
    End Sub

    Private Sub MonedaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        teclado = True
    End Sub

    Private Function convertirFormato(ByVal valor As String) As String
        If IsNumeric(valor) Then
            If formatoI = formatos.Numero Then
                convertirFormato = FormatNumber(valor, 2, , , TriState.True)
            Else
                convertirFormato = FormatCurrency(valor, , , TriState.True, TriState.True)
            End If
        Else
            convertirFormato = valor
        End If
    End Function

    Private Sub MonedaTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        SelectAll()
    End Sub


    Public Overrides Property Text() As String
        Get
            Dim valor As String = MyBase.Text
            If valor.Length > 1 And Not IsNumeric(valor) Then
                valor = valor.Substring(1, valor.Length - 1)
            End If
            Return valor
        End Get
        Set(ByVal Value As String)
            MyBase.Text = Value
        End Set
    End Property
End Class
