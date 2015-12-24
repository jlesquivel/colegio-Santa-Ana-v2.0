Imports System.Data.SqlClient

Public Class frmGenCobro
     Inherits DevComponents.DotNetBar.Metro.MetroForm

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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents GenCobro1 As colegio.genCobro
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sinMora As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenCobro))
        ComboBox1 = New System.Windows.Forms.ComboBox()
        GenCobro1 = New colegio.genCobro()
        SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Label1 = New System.Windows.Forms.Label()
        Button1 = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        sinMora = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(GenCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'ComboBox1
        '
        ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComboBox1.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        ComboBox1.Location = New System.Drawing.Point(120, 23)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(136, 24)
        ComboBox1.TabIndex = 0
        '
        'GenCobro1
        '
        GenCobro1.DataSetName = "genCobro"
        GenCobro1.Locale = New System.Globalization.CultureInfo("es-CR")
        GenCobro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
    "scritorio;persist security info=False;initial catalog=colegio"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter2
        '
        SqlDataAdapter2.InsertCommand = SqlInsertCommand1
        SqlDataAdapter2.SelectCommand = SqlSelectCommand1
        SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("concepto", "concepto"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat")})})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.VarBinary, 8, "id"), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 15, "concepto"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.VarChar, 31, "id_mat")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT id, carnet, concepto, mes, recibo, fecha_recibo, monto, generado, id_mat F" & _
    "ROM cobros"
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(23, 23)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(91, 23)
        Label1.TabIndex = 4
        Label1.Text = "Mes a cobrar"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.Color.Lime
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.ForeColor = System.Drawing.Color.Black
        Button1.Location = New System.Drawing.Point(120, 89)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(136, 32)
        Button1.TabIndex = 5
        Button1.Text = "Generar"
        Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Button2.BackColor = System.Drawing.Color.Transparent
        Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button2.Location = New System.Drawing.Point(24, 89)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(80, 32)
        Button2.TabIndex = 6
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = "SELECT banco, empresa, convenio, borra, tipo_id, carnet, nombre, moneda, llave, p" & _
    "eriodo, vencimiento, exp_recauda, monto, comision, FACTURA, SELF, RUBROS FROM bn" & _
    "cr"
        SqlSelectCommand2.Connection = SqlConnection1
        '
        'SqlInsertCommand2
        '
        SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        SqlInsertCommand2.Connection = SqlConnection1
        SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 4, "banco"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 3, "empresa"), New System.Data.SqlClient.SqlParameter("@convenio", System.Data.SqlDbType.VarChar, 3, "convenio"), New System.Data.SqlClient.SqlParameter("@borra", System.Data.SqlDbType.VarChar, 1, "borra"), New System.Data.SqlClient.SqlParameter("@tipo_id", System.Data.SqlDbType.VarChar, 3, "tipo_id"), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 30, "carnet"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"), New System.Data.SqlClient.SqlParameter("@moneda", System.Data.SqlDbType.VarChar, 3, "moneda"), New System.Data.SqlClient.SqlParameter("@llave", System.Data.SqlDbType.VarChar, 30, "llave"), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 8, "periodo"), New System.Data.SqlClient.SqlParameter("@vencimiento", System.Data.SqlDbType.VarChar, 8, "vencimiento"), New System.Data.SqlClient.SqlParameter("@exp_recauda", System.Data.SqlDbType.VarChar, 8, "exp_recauda"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.VarChar, 17, "monto"), New System.Data.SqlClient.SqlParameter("@comision", System.Data.SqlDbType.VarChar, 17, "comision"), New System.Data.SqlClient.SqlParameter("@FACTURA", System.Data.SqlDbType.VarChar, 20, "FACTURA"), New System.Data.SqlClient.SqlParameter("@SELF", System.Data.SqlDbType.VarChar, 1, "SELF"), New System.Data.SqlClient.SqlParameter("@RUBROS", System.Data.SqlDbType.VarChar, 2, "RUBROS")})
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.InsertCommand = SqlInsertCommand2
        SqlDataAdapter1.SelectCommand = SqlSelectCommand2
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bncr", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("empresa", "empresa"), New System.Data.Common.DataColumnMapping("convenio", "convenio"), New System.Data.Common.DataColumnMapping("borra", "borra"), New System.Data.Common.DataColumnMapping("tipo_id", "tipo_id"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("moneda", "moneda"), New System.Data.Common.DataColumnMapping("llave", "llave"), New System.Data.Common.DataColumnMapping("periodo", "periodo"), New System.Data.Common.DataColumnMapping("vencimiento", "vencimiento"), New System.Data.Common.DataColumnMapping("exp_recauda", "exp_recauda"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("comision", "comision"), New System.Data.Common.DataColumnMapping("FACTURA", "FACTURA"), New System.Data.Common.DataColumnMapping("SELF", "SELF"), New System.Data.Common.DataColumnMapping("RUBROS", "RUBROS")})})
        '
        'sinMora
        '
        '
        '
        '
        sinMora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        sinMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        sinMora.Location = New System.Drawing.Point(120, 50)
        sinMora.Name = "sinMora"
        sinMora.Size = New System.Drawing.Size(76, 23)
        sinMora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        sinMora.TabIndex = 10
        sinMora.Text = "Sin Mora"
        '
        'frmGenCobro
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        CancelButton = Button2
        ClientSize = New System.Drawing.Size(280, 163)
        Controls.Add(sinMora)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        DoubleBuffered = True
        FlattenMDIBorder = False
        ForeColor = System.Drawing.Color.Black
        Name = "frmGenCobro"
        Text = "Generar Cobro"
        CType(GenCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region
    Dim conn As New conexionSQL
    Dim arch As String

    Private Sub frmGenCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = conn.strConn

        Dim anno As Integer = Now.Year         ' consulta los meses generados del combobox
        Dim commando As String = _
                 "select DISTINCT mes from cobros where year(generado)=" & anno.ToString
        Dim da As New SqlDataAdapter(commando, SqlConnection1)
        GenCobro1.Tables("registros").Clear()
        da.Fill(GenCobro1, "registros")

        ComboBox1.Items.Remove("Enero")
        ComboBox1.Items.Remove("Diciembre")

        Select Case Now.Day
            Case 15 To 28
                Button1.Text = "Genera cobros 15"
                ComboBox1.Text = MonthName(Now.Month, False)
            Case Else
                Button1.Text = "Genera cobros 30"
        End Select

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oCobro As cCobros = New cCobros
        Select Case Now.Day
            Case 15 To 28
                oCobro.cobros_15(ComboBox1.Text, sinMora.Checked)
            Case Else
                oCobro.cobros_30(ComboBox1.Text, sinMora.Checked)
        End Select
    End Sub
End Class
