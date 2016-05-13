Imports System.ComponentModel
Imports System.Data.SqlClient
Imports colegio

Public Class frmGenCobroMatricula
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    '  Public WithEvents listener As New ThemeListener(Me)

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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents GenCobro1 As colegio.genCobro
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents CEstadoCuenta1 As CEstadoCuenta
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BuscaEstud1 As BuscaEstud
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenCobroMatricula))
        Me.GenCobro1 = New colegio.genCobro()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.CEstadoCuenta1 = New colegio.CEstadoCuenta()
        Me.BuscaEstud1 = New colegio.BuscaEstud()
        CType(Me.GenCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenCobro1
        '
        Me.GenCobro1.DataSetName = "genCobro"
        Me.GenCobro1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.GenCobro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" &
    "scritorio;persist security info=False;initial catalog=colegio"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("concepto", "concepto"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.VarBinary, 8, "id"), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 15, "concepto"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.VarChar, 31, "id_mat")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id, carnet, concepto, mes, recibo, fecha_recibo, monto, generado, id_mat F" &
    "ROM cobros"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(64, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Monto Matricula"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(158, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT banco, empresa, convenio, borra, tipo_id, carnet, nombre, moneda, llave, p" &
    "eriodo, vencimiento, exp_recauda, monto, comision, FACTURA, SELF, RUBROS FROM bn" &
    "cr"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 4, "banco"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 3, "empresa"), New System.Data.SqlClient.SqlParameter("@convenio", System.Data.SqlDbType.VarChar, 3, "convenio"), New System.Data.SqlClient.SqlParameter("@borra", System.Data.SqlDbType.VarChar, 1, "borra"), New System.Data.SqlClient.SqlParameter("@tipo_id", System.Data.SqlDbType.VarChar, 3, "tipo_id"), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 30, "carnet"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"), New System.Data.SqlClient.SqlParameter("@moneda", System.Data.SqlDbType.VarChar, 3, "moneda"), New System.Data.SqlClient.SqlParameter("@llave", System.Data.SqlDbType.VarChar, 30, "llave"), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 8, "periodo"), New System.Data.SqlClient.SqlParameter("@vencimiento", System.Data.SqlDbType.VarChar, 8, "vencimiento"), New System.Data.SqlClient.SqlParameter("@exp_recauda", System.Data.SqlDbType.VarChar, 8, "exp_recauda"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.VarChar, 17, "monto"), New System.Data.SqlClient.SqlParameter("@comision", System.Data.SqlDbType.VarChar, 17, "comision"), New System.Data.SqlClient.SqlParameter("@FACTURA", System.Data.SqlDbType.VarChar, 20, "FACTURA"), New System.Data.SqlClient.SqlParameter("@SELF", System.Data.SqlDbType.VarChar, 1, "SELF"), New System.Data.SqlClient.SqlParameter("@RUBROS", System.Data.SqlDbType.VarChar, 2, "RUBROS")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bncr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("empresa", "empresa"), New System.Data.Common.DataColumnMapping("convenio", "convenio"), New System.Data.Common.DataColumnMapping("borra", "borra"), New System.Data.Common.DataColumnMapping("tipo_id", "tipo_id"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("moneda", "moneda"), New System.Data.Common.DataColumnMapping("llave", "llave"), New System.Data.Common.DataColumnMapping("periodo", "periodo"), New System.Data.Common.DataColumnMapping("vencimiento", "vencimiento"), New System.Data.Common.DataColumnMapping("exp_recauda", "exp_recauda"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("comision", "comision"), New System.Data.Common.DataColumnMapping("FACTURA", "FACTURA"), New System.Data.Common.DataColumnMapping("SELF", "SELF"), New System.Data.Common.DataColumnMapping("RUBROS", "RUBROS")})})
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(158, 41)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(98, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(64, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Año"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(44, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Monto Pre -matricula"
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(790, 409)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 11
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.NumericUpDown1)
        Me.SuperTabControlPanel1.Controls.Add(Me.TextBox2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Button1)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label1)
        Me.SuperTabControlPanel1.Controls.Add(Me.TextBox1)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label3)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 23)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(790, 386)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Generar Anual"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.CEstadoCuenta1)
        Me.SuperTabControlPanel2.Controls.Add(Me.ButtonX1)
        Me.SuperTabControlPanel2.Controls.Add(Me.BuscaEstud1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 23)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(790, 386)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Location = New System.Drawing.Point(286, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(111, 31)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Genera Cobros"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Genera x Estudiante"
        '
        'CEstadoCuenta1
        '
        Me.CEstadoCuenta1.BackColor = System.Drawing.Color.Transparent
        Me.CEstadoCuenta1.Location = New System.Drawing.Point(274, 40)
        Me.CEstadoCuenta1.Name = "CEstadoCuenta1"
        Me.CEstadoCuenta1.Size = New System.Drawing.Size(513, 332)
        Me.CEstadoCuenta1.TabIndex = 2
        '
        'BuscaEstud1
        '
        Me.BuscaEstud1.BackColor = System.Drawing.SystemColors.Control
        Me.BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        Me.BuscaEstud1.Name = "BuscaEstud1"
        Me.BuscaEstud1.Size = New System.Drawing.Size(268, 386)
        Me.BuscaEstud1.TabIndex = 0
        '
        'frmGenCobroMatricula
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 409)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.DoubleBuffered = True
        Me.Name = "frmGenCobroMatricula"
        Me.Text = "Generar Cobros de Matricula"
        CType(Me.GenCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim conn As New conexionSQL
    Dim arch As String

    Private Sub frmGenCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TextBox1.Text = My.Settings.matricula.ToString("N2")
        Me.TextBox2.Text = My.Settings.prematricula.ToString("N2")

        SqlConnection1.ConnectionString = conn.strConn
        NumericUpDown1.Value = Now.Year
        NumericUpDown1.Maximum = Now.Year

        Select Case Now.Month
            Case 1, 2, 3, 4, 5, 6, 7
                NumericUpDown1.Value = Now.Year - 1
            Case Else
                NumericUpDown1.Value = Now.Year
        End Select

        Dim anno As Integer = NumericUpDown1.Value         ' consulta los meses generados del combobox
        Dim commando As String =
                 "select DISTINCT mes from cobros where year(generado)=" & anno.ToString
        Dim da As New SqlDataAdapter(commando, SqlConnection1)
        GenCobro1.Tables("registros").Clear()
        da.Fill(GenCobro1, "registros")


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim val1, val2 As Decimal
        Dim anno As String

        val1 = CDec(TextBox1.Text)
        val2 = CDec(TextBox2.Text)
        anno = CStr(NumericUpDown1.Value)
        Dim cob As New cCobros
        Dim anno_descrip As String = CStr((CInt(anno) + 1))

        cob.cobros_Matricula(anno, val1, ("Matricula " & anno_descrip), 2)
        cob.cobros_Matricula(anno, val2, ("Prematricula " & anno_descrip), 3)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim val1, val2 As Decimal
        Dim anno As String

        val1 = CDec(TextBox1.Text)
        val2 = CDec(TextBox2.Text)
        anno = CStr(NumericUpDown1.Value)
        Dim cob As New cCobros
        Dim anno_descrip As String = CStr((CInt(anno) + 1))

        cob.cobros_Matricula(anno, val1, ("Matricula " & anno_descrip), 2, BuscaEstud1.seleccionado)
        cob.cobros_Matricula(anno, val2, ("Prematricula " & anno_descrip), 3, BuscaEstud1.seleccionado)

        CEstadoCuenta1.buscar(BuscaEstud1.seleccionado)
    End Sub

    Private Sub BuscaEstud1_selecionado(sender As Object, e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        CEstadoCuenta1.buscar(BuscaEstud1.seleccionado)
    End Sub

    Private Sub frmGenCobroMatricula_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.matricula = CDec(TextBox1.Text)
        My.Settings.prematricula = CDec(TextBox2.Text)
    End Sub
End Class
