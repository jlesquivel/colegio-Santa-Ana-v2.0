Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Security.Principal
Imports AutoUpdaterDotNET

'TODO Al efecuar un traslado eliminar todos los cobros de ese mes en adelantes (si es < 15 el dia mantener el mes actual)
'OK AutoActualizar
'TODO Enviar cobros por correo electronico solo los pendientes a la fecha
'TODO a la ventana de cancelar recibos asignar el periodo de cobro enero-2015
'TODO Agregar formula 14
'TODO Convertir modulo de recoleccion de notas via web

Public Class frmPrincipal2
    Inherits DevComponents.DotNetBar.RibbonForm

    Public institucion As String
    Dim AppImp As Printing.PrinterSettings
    Dim oVentana As New Ventanas
    Dim proceso As Boolean = False  ' indicar si el servidor de carga esta corriendo


    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        RibbonCobros.Visible = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmPrincipal2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim myUri As New Uri(My.Settings.ServActilizacion)
        Dim host As String = myUri.Host

        If My.Computer.Network.Ping(host, 400) Then
            AddHandler AutoUpdater.CheckForUpdateEvent, AddressOf AutoUpdaterRevisarEvent
            AutoUpdater.Start(My.Settings.ServActilizacion)
        End If

        institucion = My.Settings.institucion
        organizacion = My.Settings.institucion
        Text = My.Settings.institucion
        AppImp = New Printing.PrinterSettings
        RibbonMatricula.Select()
    End Sub

    Private Sub frmPrincipal2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim sqlcon As New conexionSQL

        LabelItem3.Text = WindowsIdentity.GetCurrent.Name
        LabelItem2.Text = Format(Now.Date, "D")
        'Me.LabelItem1.Text = sqlcon.servidor
        LabelItem1.Text = sqlcon.servidor

        ButtonItem40.Enabled = (DateTime.Now.Month = 10 Or DateTime.Now.Month = 11 Or DateTime.Now.Month = 12)
        ButtonItem41.Enabled = (DateTime.Now.Month = 1 Or DateTime.Now.Month = 2 Or DateTime.Now.Month = 3)

        RibbonCobros.Visible = sqlcon.verifica_seguridad("colegio", "bncr")
        'ButtonItem20.Enabled = sqlcon.verifica_seguridad("colegio", "cuotas")
        Refresh()
        With MicroChartItem1.PieChartStyle.SliceColors
            .Item(0) = .Item(4)
        End With

        LabelX1.Text = My.Application.Info.Version.ToString()

    End Sub

    Private Sub frmPrincipal2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        Application.Exit()
    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        PrintDialog1.Document = New Printing.PrintDocument
        Dim result As DialogResult = PrintDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            AppImp = PrintDialog1.PrinterSettings
        End If
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        oVentana.cargarVentana(New frmConfiguracion, Me)
    End Sub


#Region "MATRICULA"
    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        oVentana.cargarVentana(New frmEstudiantes, Me)
    End Sub
    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        oVentana.cargarVentana(New frmListaClase, Me)
    End Sub
    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        oVentana.cargarVentana(New frmMatriculaV, Me)
    End Sub


#End Region

#Region "COBROS"
    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click
        oVentana.cargarVentana(New frmCuotas, Me)
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        oVentana.cargarVentana(New frmCobrosAnual, Me)
    End Sub
    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        oVentana.cargarVentana(New frmCancelaCobros, Me)
    End Sub
    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmCobros, Me)
    End Sub
    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem27.Click
        oVentana.cargarVentana(New frmCobroAdelantado, Me)
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        oVentana.cargarVentana(New frmGenCobroMatricula, Me)
    End Sub
    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        oVentana.cargarVentana(New frmConvenios, Me)
    End Sub
#End Region

#Region "NOTAS"

    Private Sub ButtonItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click
        oVentana.cargarVentana(New frmAusencias, Me)
    End Sub
    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click
        oVentana.cargarVentana(New frmRegistraNotas, Me)
    End Sub
    Private Sub ButtonItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem35.Click
        oVentana.cargarVentana(New frmRepNotas, Me)
    End Sub
    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        oVentana.cargarVentana(New frmDiskette, Me)
    End Sub

#End Region

    Private Sub ButtonItem38_Click(sender As Object, e As EventArgs) Handles ButtonItem38.Click
        oVentana.cargarVentana(New frmCobrosMsjCorreo, Me)
    End Sub


    Private Sub RibbonCobros_Click(sender As Object, e As EventArgs) Handles RibbonCobros.Click
        Dim resultado As ArrayList
        Dim conn As New conexionSQL

        resultado = conn.llena("select * from cobros_cancelado_pendientes")
        If resultado.Count > 0 Then
            Dim points As New List(Of Double)()
            points.Add(resultado(0)(0))
            points.Add(resultado(0)(1))
            MicroChartItem1.DataPoints = points
            MicroChartItem1.DataPointTooltips = New List(Of String)(New String() {"Cancelado:   {0}", "Pendientes: {0}"})
        End If
        ServCobros.SymbolColor = Color.Gray

        BackgroundWorker1.RunWorkerAsync() ' ejecuta actualizacion de indicador de carga cobros del servidor

    End Sub

    Private Sub ButtonItem39_Click(sender As Object, e As EventArgs) Handles ButtonItem39.Click
        Dim oNotas As New Notas
        oNotas.CreaNotasBD()
        oNotas = Nothing
    End Sub

    Private Sub ButtonItem40_Click(sender As Object, e As EventArgs) Handles ButtonItem40.Click
        Dim oNotas As New Notas
        oNotas.CreaNotasConv1()
        oNotas = Nothing
    End Sub

    Private Sub ButtonItem41_Click(sender As Object, e As EventArgs) Handles ButtonItem41.Click
        Dim oNotas As New Notas
        oNotas.CreaNotasConv2()
        oNotas = Nothing
    End Sub

    Private Sub ButtonItem42_Click(sender As Object, e As EventArgs) Handles ButtonItem42.Click
        oVentana.cargarVentana(New frmCobros, Me)
    End Sub

    Private Sub ButtonItem29_Click(sender As Object, e As EventArgs) Handles ButtonItem29.Click
        oVentana.cargarVentana(New frmRecibos, Me)
    End Sub

    Private Sub ButtonItem37_Click(sender As Object, e As EventArgs) Handles ButtonItem37.Click
        oVentana.cargarVentana(New frmConstEstud, Me)
    End Sub

    Private Sub ButtonItem28_Click_1(sender As Object, e As EventArgs) Handles ButtonItem28.Click
        '' boton Cons Pago estudiantes
    End Sub

    Private Sub ButtonItem43_Click(sender As Object, e As EventArgs) Handles ButtonItem43.Click
        oVentana.cargarVentana(New frmMaterias, Me)
    End Sub

    Private Sub ButtonItem44_Click(sender As Object, e As EventArgs) Handles ButtonItem44.Click
        oVentana.cargarVentana(New frmNiveles, Me)
    End Sub


    Private Sub ButtonItem34_Click_2(sender As Object, e As EventArgs) Handles ButtonItem34.Click
        oVentana.cargarVentana(New CISA, Me)
    End Sub


    ''' <summary>
    ''' Consulta el servidor para verificar si esta cargado el servidor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim serv As New cProcesosRemotos
        Dim conn2 As New conexionSQL

        proceso = serv.isProceso(conn2.servidor, "ApPagos.exe", "AdmBD", "Liber1a")
    End Sub
    ''' <summary>
    ''' aactualiza color de boton
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ServCobros.SymbolColor = If(proceso, Color.Green, Color.Red)
    End Sub

    Private Sub AutoUpdaterRevisarEvent(args As UpdateInfoEventArgs)
        If args IsNot Nothing Then
            If (args.IsUpdateAvailable) Then
                Dim dialogResult = MessageBox.Show(String.Format(
               "Existe una nueva versión {0} desea actualizarla ?",
               args.CurrentVersion), "Actualización Disponible",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If (dialogResult.Equals(dialogResult.Yes)) Then
                    Try
                        AutoUpdater.DownloadUpdate()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            MessageBox.Show(
                   "Problemas con la conexión internet. intente más tarde.",
                   "Error servidor ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class

