Imports System
Imports System.Management

Public Class cProcesosRemotos

    Public Sub New()

    End Sub

    Public Function LocalizarTodosProcesos(pComputadora As String, pUsuario As String, pClave As String) As ArrayList

        Dim procesos As New ArrayList

        Dim options As ConnectionOptions = New ConnectionOptions()

        ' Then set the options.Username and 
        options.Username = pUsuario
        options.Password = pClave

        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & pComputadora & "\root\cimv2", options)
        scope.Connect()

        Dim query As ObjectQuery
        query = New ObjectQuery(
                "SELECT * FROM Win32_Process")


        Dim objSearcher As Object = New ManagementObjectSearcher("SELECT * FROM Win32_Process")

        Dim opsObserver As Object = New ManagementOperationObserver()
        objSearcher.Scope = scope

        Dim queryCollection As ManagementObjectCollection
        queryCollection = objSearcher.Get()

        Dim sep As String() = {vbCr, vbCrLf}
        Dim detalles, opciones As String()



        For Each obj As Object In queryCollection
            Dim linea As String = obj.GetText(TextFormat.Mof)

            linea = linea.Remove(0, linea.IndexOf("{"))
            detalles = linea.Split(";")

            For Each elemto As Object In detalles
                elemto = elemto.Replace("""", "")

                If InStr(1, elemto, "Description") > 0 Then
                    opciones = elemto.Split("=")
                    procesos.Add(opciones(1).Trim)
                End If
            Next

        Next
        Return procesos
    End Function

    Public Function isProcesoLista(_compu As String, proceso As String) As Boolean

        Dim procesos As ArrayList = LocalizarTodosProcesos(_compu, "joseluis", "123")
        If procesos IsNot Nothing Then
            Dim res As Integer = procesos.IndexOf(proceso)
            Return res > 0
        Else
            Return False
        End If

    End Function

    Public Sub CreateProcess(ByVal strComputer As String, ByVal strProcess As String, ByVal UserName As String, ByVal Password As String)

        Dim processBatch As ManagementClass = New ManagementClass("Win32_Process")
        Dim inParams As ManagementBaseObject = processBatch.GetMethodParameters("Create")
        Dim msc As ManagementScope

        inParams("CurrentDirectory") = Nothing
        inParams("CommandLine") = strProcess
        Dim co As ConnectionOptions = New ConnectionOptions()
        co.Username = UserName
        co.Password = Password

        Try
            If (strComputer = System.Environment.MachineName) Then
                msc = New Management.ManagementScope("\\" & strComputer & "\root\cimv2")
            Else
                msc = New Management.ManagementScope("\\" & strComputer & "\root\cimv2", co)
            End If

            msc.Connect()
            processBatch.Scope = msc
            Dim meyhodoptions As InvokeMethodOptions = New InvokeMethodOptions(Nothing, System.TimeSpan.MaxValue)
            Dim outParamas As ManagementBaseObject = Nothing
            outParamas = processBatch.InvokeMethod("Create", inParams, Nothing)
            MsgBox(outParamas.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function isProceso(pComputadora As String, proceso As String, pUsuario As String, pClave As String) As Boolean
        Dim options As ConnectionOptions = New ConnectionOptions()
        options.Username = pUsuario
        options.Password = pClave

        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & pComputadora & "\root\cimv2", options)
        scope.Connect()

        Dim query As ObjectQuery
        query = New ObjectQuery(
                "SELECT * FROM Win32_Process")

        Dim objSearcher As Object = New ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE Name = '" & proceso & "'")
        Dim opsObserver As Object = New ManagementOperationObserver()
        objSearcher.Scope = scope

        Dim queryCollection As ManagementObjectCollection
        queryCollection = objSearcher.Get()

        Return (queryCollection.Count > 0)
    End Function

End Class
