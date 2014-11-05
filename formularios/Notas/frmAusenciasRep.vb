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
        Me.BuscaEstud1 = New colegio.BuscaEstud
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.PanelEx1.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BuscaEstud1
        '
        Me.BuscaEstud1.BackColor = System.Drawing.Color.Transparent
        Me.BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuscaEstud1.Location = New System.Drawing.Point(0, 111)
        Me.BuscaEstud1.Name = "BuscaEstud1"
        Me.BuscaEstud1.Size = New System.Drawing.Size(200, 375)
        Me.BuscaEstud1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inicio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(123, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(107, 80)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 33)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(192, 23)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "por grupo"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 486)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(677, 486)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.BuscaEstud1)
        Me.PanelEx1.Controls.Add(Me.ExpandablePanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx1.Location = New System.Drawing.Point(3, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(200, 486)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        Me.PanelEx1.Text = "PanelEx1"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.LinkLabel1)
        Me.ExpandablePanel1.Controls.Add(Me.Label2)
        Me.ExpandablePanel1.Controls.Add(Me.Label1)
        Me.ExpandablePanel1.Controls.Add(Me.DateTimePicker1)
        Me.ExpandablePanel1.Controls.Add(Me.DateTimePicker2)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExpandablePanel1.HideControlsWhenCollapsed = True
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(200, 111)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 0
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Periodo"
        '
        'frmAusenciasRep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 486)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "frmAusenciasRep"
        Me.Text = "Reporte Ausencias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(False)
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

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
                Me.CrystalReportViewer1.ReportSource = oreporte
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = True
        Me.DateTimePicker2.Value = DateAdd(DateInterval.Day, 30, Me.DateTimePicker1.Value)
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim rpAu As New rptAusenciaGrupo
        inserta_parametro(rpAu, "@ini1", CStr(Year(Me.DateTimePicker1.Value)))
        inserta_parametro(rpAu, "@ini", Me.DateTimePicker1.Value.Date)
        inserta_parametro(rpAu, "@fin", Me.DateTimePicker2.Value.Date)
        rpAu.SummaryInfo.ReportComments = "Reporte de Asistencia"
        imprimir(rpAu, False, Me.ParentForm)
    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        Dim rpAu As New rptAusenciaEst
        rpAu.SummaryInfo.ReportComments = "Reporte de Asistencia"
        Me.inserta_parametro(rpAu, "@carnet", BuscaEstud1.seleccionado)
        imprimir(rpAu, False, Me.ParentForm)
    End Sub

End Class


