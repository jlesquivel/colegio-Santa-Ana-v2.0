Imports System.Data.SqlClient
Imports colegioReportes

Public Class frmRepNotas
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents ExplorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar
        Me.ExplorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExplorerBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 438)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(146, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(622, 438)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ExplorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2
        Me.ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.ExplorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground
        Me.ExplorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBar1.Controls.Add(Me.ComboBox1)
        Me.ExplorerBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExplorerBar1.GroupImages = Nothing
        Me.ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ExplorerBarGroupItem1})
        Me.ExplorerBar1.Images = Nothing
        Me.ExplorerBar1.Location = New System.Drawing.Point(3, 0)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(143, 438)
        Me.ExplorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBar1.TabIndex = 4
        Me.ExplorerBar1.Text = "ExplorerBar1"
        '
        'ExplorerBarGroupItem1
        '
        '
        '
        '
        Me.ExplorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItem1.Expanded = True
        Me.ExplorerBarGroupItem1.Name = "ExplorerBarGroupItem1"
        Me.ExplorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3, Me.ControlContainerItem1})
        Me.ExplorerBarGroupItem1.Text = "Listados"
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItem1.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItem1.HotFontUnderline = True
        Me.ButtonItem1.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonItem1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Notas Estudiantes"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItem2.HotFontUnderline = True
        Me.ButtonItem2.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonItem2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Notas Grupo x periodo"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonItem3.HotFontUnderline = True
        Me.ButtonItem3.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonItem3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Notas Grupo Anual"
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = True
        Me.ControlContainerItem1.Control = Me.ComboBox1
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        Me.ControlContainerItem1.Text = "ControlContainerItem1"
        '
        'frmRepNotas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 438)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ExplorerBar1)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "frmRepNotas"
        Me.Text = "Reporte Notas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExplorerBar1.ResumeLayout(False)
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
                    If conn.vusuario <> "" Then
                        .IntegratedSecurity = False
                    End If
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
        Dim i As Integer
        For i = Date.Now.Year To (Date.Now.Year - 8) Step -1
            Me.ComboBox1.Items.Add(i.ToString)
        Next
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        conn.ejecuta("EXEC CargarAusenciaNotas 1")
        conn.ejecuta("EXEC CargarAusenciaNotas 2")
        conn.ejecuta("EXEC CargarAusenciaNotas 3")

        Dim cob As New colegioReportes.rptNotas()
        inserta_parametro(cob, "@ano", CInt(Me.ComboBox1.SelectedItem))
        imprimir(cob, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim cob As New rptNotasGrupoConcentrado
        inserta_parametro(cob, "@ano", CInt(Me.ComboBox1.SelectedItem))
        cob.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        cob.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
        cob.SummaryInfo.ReportComments = "Reporte Acádemico"
        imprimir(cob, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim cob As New rptNotasGrupoAnual
        inserta_parametro(cob, "@ano", CInt(Me.ComboBox1.SelectedItem))
        cob.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        cob.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
        cob.SummaryInfo.ReportComments = "Reporte Acádemico Anual"
        imprimir(cob, False, Me.ParentForm)
    End Sub
End Class


