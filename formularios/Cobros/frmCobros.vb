Imports System.Data.SqlClient
Imports colegioReportes

Public Class frmCobros
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim conn As New conexionSQL

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        LinkLabel7 = New System.Windows.Forms.LinkLabel()
        LinkLabel5 = New System.Windows.Forms.LinkLabel()
        LinkLabel3 = New System.Windows.Forms.LinkLabel()
        LinkLabel4 = New System.Windows.Forms.LinkLabel()
        LinkLabel6 = New System.Windows.Forms.LinkLabel()
        LinkLabel1 = New System.Windows.Forms.LinkLabel()
        LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Splitter1 = New System.Windows.Forms.Splitter()
        Panel1 = New System.Windows.Forms.Panel()
        CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'ComboBox1
        '
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New System.Drawing.Point(6, 282)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(109, 21)
        ComboBox1.TabIndex = 1
        '
        'LinkLabel7
        '
        LinkLabel7.Location = New System.Drawing.Point(3, 150)
        LinkLabel7.Name = "LinkLabel7"
        LinkLabel7.Size = New System.Drawing.Size(120, 24)
        LinkLabel7.TabIndex = 6
        LinkLabel7.TabStop = True
        LinkLabel7.Text = "Arch. BNCR"
        LinkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel5
        '
        LinkLabel5.Location = New System.Drawing.Point(3, 126)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New System.Drawing.Size(120, 24)
        LinkLabel5.TabIndex = 4
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Pagos x mes"
        LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel3
        '
        LinkLabel3.Location = New System.Drawing.Point(3, 102)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New System.Drawing.Size(120, 24)
        LinkLabel3.TabIndex = 3
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Pagos por dia"
        LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel4
        '
        LinkLabel4.Location = New System.Drawing.Point(3, 78)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New System.Drawing.Size(120, 24)
        LinkLabel4.TabIndex = 2
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Morosos con Monto"
        LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel6
        '
        LinkLabel6.Location = New System.Drawing.Point(3, 54)
        LinkLabel6.Name = "LinkLabel6"
        LinkLabel6.Size = New System.Drawing.Size(120, 24)
        LinkLabel6.TabIndex = 5
        LinkLabel6.TabStop = True
        LinkLabel6.Text = "Morosos x Clase"
        LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LinkLabel1.Location = New System.Drawing.Point(3, 30)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New System.Drawing.Size(120, 24)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Notas de Cobro"
        LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel2
        '
        LinkLabel2.Location = New System.Drawing.Point(3, 6)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New System.Drawing.Size(133, 24)
        LinkLabel2.TabIndex = 1
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Clase con Monto"
        LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Splitter1.Location = New System.Drawing.Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New System.Drawing.Size(3, 511)
        Splitter1.TabIndex = 2
        Splitter1.TabStop = False
        '
        'Panel1
        '
        Panel1.BackColor = System.Drawing.Color.Transparent
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(LinkLabel7)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(LinkLabel5)
        Panel1.Controls.Add(LinkLabel6)
        Panel1.Controls.Add(LinkLabel3)
        Panel1.Controls.Add(LinkLabel4)
        Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Panel1.Location = New System.Drawing.Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(133, 511)
        Panel1.TabIndex = 4
        '
        'CrystalReportViewer1
        '
        CrystalReportViewer1.ActiveViewIndex = -1
        CrystalReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        CrystalReportViewer1.ForeColor = System.Drawing.Color.Black
        CrystalReportViewer1.Location = New System.Drawing.Point(136, 0)
        CrystalReportViewer1.Name = "CrystalReportViewer1"
        CrystalReportViewer1.ShowLogo = False
        CrystalReportViewer1.ShowParameterPanelButton = False
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.Size = New System.Drawing.Size(748, 511)
        CrystalReportViewer1.TabIndex = 5
        '
        'frmCobros
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(884, 511)
        Controls.Add(CrystalReportViewer1)
        Controls.Add(Panel1)
        Controls.Add(Splitter1)
        DoubleBuffered = True
        Name = "frmCobros"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Text = "Reporte Cobros"
        WindowState = System.Windows.Forms.FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    Public Sub inserta_parametro(ByRef reporte As Object, ByVal param As String, ByVal valor As String)
        Try
            Dim pvCollection As New CrystalDecisions.Shared.ParameterValues
            Dim pdvCustomerName As New CrystalDecisions.Shared.ParameterDiscreteValue

            ' Set the discreet value to the customers name.
            pdvCustomerName.Value = valor
            ' Add it to the parameter collection.
            pvCollection.Add(pdvCustomerName)

            ' Apply the current parameter values.
            reporte.DataDefinition.ParameterFields(param).ApplyCurrentValues(pvCollection)
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "Error General")

        End Try
    End Sub


    Public Sub imprimir(ByRef oreporte As Object, ByVal impresora As Boolean)
        Try
            Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
            Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo

            For Each tbCurrent In oreporte.Database.Tables
                tliCurrent = tbCurrent.LogOnInfo
                With tliCurrent.ConnectionInfo
                    .ServerName = conn.servidor
                    .UserID = conn.vusuario
                    .Password = conn.vpassword
                    .DatabaseName = conn.bd
                End With
                tbCurrent.ApplyLogOnInfo(tliCurrent)
            Next tbCurrent
            oreporte.SummaryInfo.ReportTitle = My.Settings.institucion
            oreporte.PrintOptions.PrinterName = My.Settings.impresora
            If impresora Then
                oreporte.PrintToPrinter(1, False, 0, 0)
            Else  ' pantalla
                Dim miForma As New frmReporte
                CrystalReportViewer1.ReportSource = oreporte
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = True

        Dim i As Integer
        For i = Date.Now.Year To (Date.Now.Year - 8) Step -1
            ComboBox1.Items.Add(i.ToString)
        Next
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim venta As New frmCobrosMsjCorreo()
        Dim resultado = venta.ShowDialog(Me)
        If resultado = System.Windows.Forms.DialogResult.OK Then
            Dim cob As New rptCobrosNota
            inserta_parametro(cob, "@Adm", venta.admin.Text)
            inserta_parametro(cob, "@mensaje", venta.msj1.Rtf.ToString)

            cob.SummaryInfo.ReportComments = "Teléfono : 2666 0301"
            imprimir(cob, False)
        Else
            venta.Text = "Cancelled"
        End If
        venta.Dispose()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim cob As New rptCobrosMontos
        inserta_parametro(cob, "@ano", ComboBox1.SelectedItem)
        imprimir(cob, False)
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim cob As New rptCobrosMorosos
        inserta_parametro(cob, "@ano", ComboBox1.SelectedItem)
        imprimir(cob, False)
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim cob As New rptGrafPagos
        cob.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        imprimir(cob, False)
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim cob As New rptGrafPagos2
        inserta_parametro(cob, "@ano", ComboBox1.SelectedItem)
        imprimir(cob, False)
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim cob As New rptCobrosMorososClase
        inserta_parametro(cob, "@ano", ComboBox1.SelectedItem)
        imprimir(cob, False)
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Dim cob As New rptListaPagos
        imprimir(cob, False)
    End Sub

  
End Class


