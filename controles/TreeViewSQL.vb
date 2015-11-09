Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class TreeViewSQL
    Inherits System.Windows.Forms.TreeView

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region

    Dim instSQL As SqlCommand
    Dim Petiquetas As String

    <Description("Inserte la instruccion SQL"), Category("Data")> _
        Public Property InstruccionSQL() As SqlCommand
        Get
            Return instSQL
        End Get
        Set(ByVal Value As SqlCommand)
            instSQL = Value
        End Set
    End Property


    <Description("Inserte las  etiquetas "), Category("Data")> _
       Public Property Etiquetas() As String
        Get
            Return Petiquetas
        End Get
        Set(ByVal Value As String)
            Petiquetas = Value
        End Set
    End Property


    Function ruta(ByVal pRuta As String) As String()
        Dim partes() As String = Split(pRuta, "\")
        Dim Aetiquetas As String() = Petiquetas.Split(",")
        ReDim Preserve Aetiquetas(partes.Length)

        Dim parte As String
        Dim i As Integer = 0

        For Each parte In partes
            If Not (Aetiquetas(i) Is Nothing) Then
                partes.SetValue(parte.Remove(0, Aetiquetas(i).Length), i)
            End If
            i = i + 1
        Next
        Return partes

    End Function

    Sub llenar(ByVal base As String)
        Try
            Dim conexion1 As New conexionSQL
            conexion1.bd = base
            Dim DataSet1 As New DataSet("DataSet1")
            DataSet1.Tables.Add("tree")

            conexion1.llena(DataSet1, "tree", instSQL.CommandText)

            Dim fila As DataRow
            Dim columna As DataColumn
            Dim nodoPadre As TreeNode
            'Dim pos As Integer
            Dim textoI As String
            Dim tagi As Object
            Dim pos As Integer
            Dim Aetiquetas As String()
            TopNode.Nodes.Clear()
            If DataSet1.Tables("tree").Rows.Count > 0 Then
                If Not (Petiquetas Is Nothing) Then
                    Aetiquetas = Petiquetas.Split(",")
                End If
                ReDim Preserve Aetiquetas(DataSet1.Tables("tree").Columns.Count)

                For Each fila In DataSet1.Tables("tree").Rows
                    nodoPadre = TopNode
                    For Each columna In DataSet1.Tables("tree").Columns
                        ' etiqueta a insertar
                        textoI = Trim(Aetiquetas(columna.Ordinal + 1) & fila(columna.ColumnName).ToString())
                        tagi = Nothing
                        Dim divi() As String = textoI.Split(":")
                        If divi.Length > 1 Then
                            textoI = divi(0)
                            tagi = divi(1).Split(",")
                        End If

                        If (nodoPadre Is Nothing) Then
                            If existeNodo(Nodes, textoI) > -1 Then
                                nodoPadre = Nodes.Item(existeNodo(Nodes, textoI))
                            Else
                                If textoI <> "" Then
                                    If tagi Is Nothing Then
                                        pos = 0
                                    Else
                                        If tagi.length > 1 Then
                                            pos = CInt(tagi(1))
                                        End If
                                    End If
                                    Dim nuevoNodo As TreeNode = inserta(textoI, columna.Ordinal + 1 + pos)
                                    nuevonodo.Tag = tagi
                                    Nodes.Add(nuevoNodo)
                                    nodoPadre = nuevoNodo
                                End If
                                End If
                        Else ' se añade el nuevo nodo al nodo padre.
                            If existeNodo(nodoPadre.Nodes, textoI) > -1 Then
                                nodoPadre = nodoPadre.Nodes.Item(existeNodo(nodoPadre.Nodes, textoI))
                            Else
                                If textoI <> "" Then
                                    If tagi Is Nothing Then
                                        pos = 0
                                    Else
                                        If tagi.length > 1 Then
                                            pos = CInt(tagi(1))
                                        End If
                                    End If
                                    Dim nuevoNodo As TreeNode = inserta(textoI, columna.Ordinal + 1 + pos)
                                    nuevonodo.Tag = tagi
                                    nodoPadre.Nodes.Add(nuevoNodo)
                                    nodoPadre = nuevoNodo
                                End If
                            End If
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function inserta(ByVal pvalor As String, ByVal image As Integer) As TreeNode
        Dim nuevoNodo As New TreeNode
        nuevoNodo.Text = pvalor
        nuevoNodo.ImageIndex = image
        inserta = nuevoNodo
    End Function

    Function existeNodo(ByVal objetos As TreeNodeCollection, ByVal valor As String) As Integer
        Dim nodo As TreeNode
        existeNodo = -1
        For Each nodo In objetos
            If nodo.Text = valor Then
                existeNodo = nodo.Index
                Exit For
            End If
        Next
    End Function

End Class
