Imports colegioReportes
Imports System.Data.SqlClient

Public Class frmAusenciasRep
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BuscaEstud1 As colegio.BuscaEstud
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        BuscaEstud1 = New colegio.BuscaEstud
        Label2 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        LinkLabel1 = New System.Windows.Forms.LinkLabel
        Splitter1 = New System.Windows.Forms.Splitter
        CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        PanelEx1 = New DevComponents.DotNetBar.PanelEx
        ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        PanelEx1.SuspendLayout()
        ExpandablePanel1.SuspendLayout()
        SuspendLayout()
        '
        'BuscaEstud1
        '
        BuscaEstud1.BackColor = System.Drawing.Color.Transparent
        BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Fill
        BuscaEstud1.Location = New System.Drawing.Point(0, 111)
        BuscaEstud1.Name = "BuscaEstud1"
        BuscaEstud1.Size = New System.Drawing.Size(200, 375)
        BuscaEstud1.TabIndex = 0
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(27, 64)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(56, 16)
        Label2.TabIndex = 4
        Label2.Text = "Inicio"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(123, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 16)
        Label1.TabIndex = 3
        Label1.Text = "Fin"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        DateTimePicker2.Location = New System.Drawing.Point(107, 80)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        DateTimePicker1.Location = New System.Drawing.Point(11, 80)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        DateTimePicker1.TabIndex = 1
        '
        'LinkLabel1
        '
        LinkLabel1.BackColor = System.Drawing.Color.Transparent
        LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LinkLabel1.Location = New System.Drawing.Point(3, 33)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New System.Drawing.Size(192, 23)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "por grupo"
        LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Splitter1.Location = New System.Drawing.Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New System.Drawing.Size(3, 486)
        Splitter1.TabIndex = 2
        Splitter1.TabStop = False
        '
        'CrystalReportViewer1
        '
        CrystalReportViewer1.ActiveViewIndex = -1
        CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        CrystalReportViewer1.Location = New System.Drawing.Point(3, 0)
        CrystalReportViewer1.Name = "CrystalReportViewer1"
        CrystalReportViewer1.SelectionFormula = ""
        CrystalReportViewer1.Size = New System.Drawing.Size(677, 486)
        CrystalReportViewer1.TabIndex = 3
        CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PanelEx1
        '
        PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        PanelEx1.Controls.Add(BuscaEstud1)
        PanelEx1.Controls.Add(ExpandablePanel1)
        PanelEx1.Dock = System.Windows.Forms.DockStyle.Left
        PanelEx1.Location = New System.Drawing.Point(3, 0)
        PanelEx1.Name = "PanelEx1"
        PanelEx1.Size = New System.Drawing.Size(200, 486)
        PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        PanelEx1.Style.GradientAngle = 90
        PanelEx1.TabIndex = 4
        PanelEx1.Text = "PanelEx1"
        '
        'ExpandablePanel1
        '
        ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        ExpandablePanel1.Controls.Add(LinkLabel1)
        ExpandablePanel1.Controls.Add(Label2)
        ExpandablePanel1.Controls.Add(Label1)
        ExpandablePanel1.Controls.Add(DateTimePicker1)
        ExpandablePanel1.Controls.Add(DateTimePicker2)
        ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Top
        ExpandablePanel1.HideControlsWhenCollapsed = True
        ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        ExpandablePanel1.Name = "ExpandablePanel1"
        ExpandablePanel1.Size = New System.Drawing.Size(200, 111)
        ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        ExpandablePanel1.Style.GradientAngle = 90
        ExpandablePanel1.TabIndex = 0
        ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        ExpandablePanel1.TitleStyle.GradientAngle = 90
        ExpandablePanel1.TitleText = "Periodo"
        '
        'frmAusenciasRep
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(680, 486)
        Controls.Add(PanelEx1)
        Controls.Add(CrystalReportViewer1)
        Controls.Add(Splitter1)
        Name = "frmAusenciasRep"
        Text = "Reporte Ausencias"
        WindowState = System.Windows.Forms.FormWindowState.Maximized
        PanelEx1.ResumeLayout(False)
        ExpandablePanel1.ResumeLayout(False)
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

    Public Sub imprimir(ByRef oreporte As Object, ByVal impresora As Boolean, ByRef padre As frmPrincipal2)
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
            oreporte.SummaryInfo.ReportTitle = padre.organizacion
            oreporte.PrintOptions.PrinterName = padre.impresora.PrinterName
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
        DateTimePicker2.Value = DateAdd(DateInterval.Day, 30, DateTimePicker1.Value)
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim rpAu As New rptAusenciaGrupo
        inserta_parametro(rpAu, "@ini1", CStr(Year(DateTimePicker1.Value)))
        inserta_parametro(rpAu, "@ini", DateTimePicker1.Value.Date)
        inserta_parametro(rpAu, "@fin", DateTimePicker2.Value.Date)
        rpAu.SummaryInfo.ReportComments = "Reporte de Asistencia"
        imprimir(rpAu, False, ParentForm)
    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        Dim rpAu As New rptAusenciaEst
        rpAu.SummaryInfo.ReportComments = "Reporte de Asistencia"
        inserta_parametro(rpAu, "@carnet", BuscaEstud1.seleccionado)
        imprimir(rpAu, False, ParentForm)
    End Sub

End Class


