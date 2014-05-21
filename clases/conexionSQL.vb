Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports System.Configuration
Imports System.Collections
Imports System.Threading

Public Class conexionSQL

    Private seguridadIntegrada As Boolean = True
    Public vEspera As String = "15"
    Private vServidor As String = "SERVIDOR-BD"
    Private vbd As String = "colegio"
    Public vusuario As String = "sa"
    Public vpassword As String = "123"
    Private vtabla As String = ""
    Private vcampos As String = ""
    Private vorden As String = ""
    Private vstrConn As String = ""
    Private colegioConnection As SqlConnection


    Shared ThreadProcConn As Data.SqlClient.SqlConnection
    Shared connectSuccess As Boolean = False

#Region " Propiedades "
    Public Property servidor() As String
        Get
            Return vServidor
        End Get
        Set(ByVal Value As String)
            vServidor = Value
            Construye_String()
        End Set
    End Property

    Public Property bd() As String
        Get
            Return vbd
        End Get

        Set(ByVal Value As String)
            vbd = Value
            Construye_String()
            Me.colegioConnection.ConnectionString = vstrConn
        End Set
    End Property

    Public Property strConn() As String
        Get
            Return vstrConn
        End Get
        Set(ByVal Value As String)
            vstrConn = Value
        End Set
    End Property

    Public Property conexion() As SqlConnection
        Get
            Return colegioConnection
        End Get

        Set(ByVal Value As SqlConnection)
            colegioConnection = Value
        End Set
    End Property

#End Region

    Sub New()
        ' carga el archivo de password general
        Try
            Construye_String()
            colegioConnection = New SqlConnection(vstrConn)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub New(ByVal serv As String, ByVal base As String, ByVal cuenta As String, ByVal pass As String)

        vServidor = serv
        vbd = base
        vusuario = cuenta
        vpassword = pass

        Construye_String()
        colegioConnection = New SqlConnection(vstrConn)
    End Sub

    Sub New(ByVal base As String)
        vusuario = frmLogin.TextBoxX1.Text
        vpassword = frmLogin.TextBoxX2.Text
        vbd = base
        Construye_String()
        colegioConnection = New SqlConnection(vstrConn)
    End Sub

#Region "CONEXION OK"

    Function conexionOK() As Boolean
        Return QuickOpen(colegioConnection, 5)
    End Function


    Public Shared Sub ThreadProc()
        Try ' Try to open the connection, if anything goes wrong, make sure we set connectSuccess = false
            ThreadProcConn.Open()
            connectSuccess = True
        Catch
            connectSuccess = False
        End Try
    End Sub
    Public Shared Function QuickOpen(ByVal conn As Data.SqlClient.SqlConnection, ByVal timeout As Integer) As Boolean
        ThreadProcConn = conn
        Dim t As New Thread(AddressOf ThreadProc)
        Dim StartTime As Date = Date.Now
        ' Make sure it’s marked as a background thread so it’ll get cleaned up automatically
        t.IsBackground = True
        t.Start()
        ' Keep trying to join the thread until we either succeed or the timeout value has been exceeded
        While StartTime.AddSeconds(timeout) > Date.Now
            If t.Join(1) Then
                Exit While
            End If
        End While
        ' If we didn’t connect successfully, throw an exception
        'If Not connectSuccess Then
        '    Throw New Exception("Server Unavailable")
        'End If

        Return connectSuccess

    End Function


#End Region

    Sub llena(ByRef ds As DataSet, ByVal tabla As String, ByVal instruccion As String)
        Try
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            Dim da As New SqlDataAdapter(instruccion, conexion)
            If ds.Tables.Item(tabla) Is Nothing Then
                ds.Tables.Add(tabla)
            End If

            ds.Tables(tabla).Clear()
            da.Fill(ds, tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub llena(ByRef ds As DataSet, ByVal tabla As String, ByVal instruccion As SqlCommand)
        Try
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            Dim da As New SqlDataAdapter(instruccion)
            da.SelectCommand.Connection = conexion
            If ds.Tables.Item(tabla) Is Nothing Then
                ds.Tables.Add(tabla)
            End If

            ds.Tables(tabla).Clear()
            da.Fill(ds, tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function llena(ByVal instruccion As String) As ArrayList
        Dim arreglo As New ArrayList
        Dim pos As Integer = 0
        Try

            Dim ds As New DataSet
            Dim registros As Integer
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            Dim da As New SqlDataAdapter(instruccion, conexion)

            registros = da.Fill(ds, 0)
            ' convierte ds a un arreglo a partir de aqui

            For Each fila As DataRow In ds.Tables(0).Rows
                arreglo.Add(fila.ItemArray)
                pos = pos + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return arreglo
    End Function

    Public Sub ejecuta(ByVal comando As String)
        Try
            Dim myCommand As New SqlCommand(comando)
            myCommand.Connection = colegioConnection
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            myCommand.ExecuteNonQuery()
            myCommand.Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ejecuta_sinerror(ByVal comando As String)

        Dim myCommand As New SqlCommand(comando)
        myCommand.Connection = colegioConnection
        If colegioConnection.State = ConnectionState.Closed Then
            colegioConnection.Open()
        End If
        myCommand.ExecuteNonQuery()
        myCommand.Connection.Close()
    End Sub

    Public Function GeneraArchivo(ByVal FilePath As String, ByVal ds As DataTable) As String
        'Variables para abrir el archivo en modo de escritura  
        Dim strStreamW As Stream = File.OpenWrite(FilePath)

        Dim strStreamWriter As StreamWriter = New StreamWriter(strStreamW, _
                     System.Text.Encoding.ASCII)

        Try
            Dim dr As DataRow
            Dim valor As Object
            Dim linea As String = ""

            For Each dr In ds.Rows         'Obtenemos los datos del dataset   
                For Each valor In dr.ItemArray
                    linea = linea & CStr(valor)
                Next
                'Escribimos la línea en el achivo de texto 
                linea = linea.Replace("Ñ", "N")
                strStreamWriter.WriteLine(linea)
                linea = ""
            Next
            strStreamWriter.Close()
            Return ("El archivo se generó con éxito")
        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
            Return ("El archivo se generó con ERROR")
        End Try
    End Function

    Private Sub Construye_String()
        vstrConn = "data source=" & vServidor & _
                   ";initial catalog=" & vbd
        Dim dominio As NetworkInformation = NetworkInformation.LocalComputer

        If dominio.Status = NetworkInformation.JoinStatus.Domain Then  ' seguridad integrada
            vstrConn = vstrConn & _
                          ";integrated security=SSPI" & _
                          ";persist security info=TRUE"
        Else                                        ' seguridad de SQL server
            vstrConn = vstrConn & " ;user id=" & vusuario & ";password=" & vpassword
        End If

        vstrConn = vstrConn & " ;Connection Timeout=" & vEspera
    End Sub
    Public Function verifica_seguridad(ByVal pBasedato As String, ByVal ptabla As String) As Boolean
        Dim retorno As Boolean

        Try
            Me.ejecuta_sinerror("Select TOP 1 * from " & ptabla)
            retorno = True

        Catch ex As Exception
            retorno = False
        End Try

        Return retorno
    End Function



    'Private Function Busca_servidor() As String

    '    Dim resp As String = ""
    '    Try
    '        Dim i As Integer
    '        Dim oNames As SQLDMO.NameList
    '        Dim oSQLApp As SQLDMO.Application

    '        Dim val As String
    '        oSQLApp = New SQLDMO.ApplicationClass
    '        oNames = oSQLApp.Application.ListAvailableSQLServers

    '        For i = 1 To oNames.Count
    '            val = oNames.Item(i)
    '            If Left(val, 8) = "SERVIDOR" Then
    '                resp = val
    '            End If
    '        Next


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    '    Return resp
    'End Function
End Class
