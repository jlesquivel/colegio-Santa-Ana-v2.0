Imports System.Collections.Generic
Imports System.Security.Principal

Public Class frmPrincipal2
    Inherits DevComponents.DotNetBar.RibbonForm


    Public institucion As String
    Dim AppImp As Printing.PrinterSettings
    Dim sqlcon As New conexionSQL
    Dim oVentana As New Ventanas

    Private Sub frmPrincipal2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub frmPrincipal2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.LabelItem3.Text = WindowsIdentity.GetCurrent.Name
        Me.LabelItem2.Text = Format(Now.Date, "D")
        Me.LabelItem1.Text = sqlcon.servidor

        Me.ButtonItem40.Enabled = (DateTime.Now.Month = 10 Or DateTime.Now.Month = 11 Or DateTime.Now.Month = 12)
        Me.ButtonItem41.Enabled = (DateTime.Now.Month = 2 Or DateTime.Now.Month = 3)
    End Sub

    Private Sub frmPrincipal2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmPrincipal2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '' Dim oVentana As Ventanas = New Ventanas
        '' oVentana.cambia_fondoMDI(Me)

        'Me.LabelItem3.Text = WindowsIdentity.GetCurrent.Name
        'Me.LabelItem2.Text = Format(Now.Date, "D")
        'Me.LabelItem1.Text = sqlcon.servidor


        institucion = My.Settings.institucion
        organizacion = My.Settings.institucion
        Me.Text = My.Settings.institucion
        Me.AppImp = New Printing.PrinterSettings

        'prueba
        'If Not sqlcon.conexionOK Then
        '    MessageBoxEx.Show("No se pudo conectar al servido SQL, Intente luego", "SQL Error!", _
        '     MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.Close()
        'End If

        Me.RibbonCobros.Visible = sqlcon.verifica_seguridad("colegio", "bncr")
        'ButtonItem20.Enabled = sqlcon.verifica_seguridad("colegio", "cuotas")

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
        oVentana.cargarVentana(New frmGenCobro, Me)
    End Sub
    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        oVentana.cargarVentana(New frmCancelaCobros, Me)
    End Sub
    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click
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

    Private Sub ButtonItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem34.Click
        oVentana.cargarVentana(New frmNiveles, Me)
    End Sub
    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem33.Click
        oVentana.cargarVentana(New frmMaterias, Me)
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

        Dim oCorreo As New cCorreo
        oCorreo.Enviar_Cobros_correo()

    End Sub



    Private Sub RibbonCobros_Click(sender As Object, e As EventArgs) Handles RibbonCobros.Click

        Dim resultado As ArrayList
        Dim conn As New conexionSQL

        resultado = conn.llena("select * from cobros_cancelado_pendientes")
        Dim points As New List(Of Double)()
        points.Add(resultado(0)(0))
        points.Add(resultado(0)(1))
        MicroChartItem1.DataPoints = points

        MicroChartItem1.DataPointTooltips = New List(Of String)(New String() {"Cancelado: {0}", "Pendientes: {0}"})
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
End Class

