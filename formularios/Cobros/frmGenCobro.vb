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
    Private WithEvents sinMora As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenCobro))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GenCobro1 = New colegio.genCobro()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.sinMora = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(Me.GenCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBox1.Location = New System.Drawing.Point(144, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 28)
        Me.ComboBox1.TabIndex = 0
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mes a cobrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(144, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(29, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
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
        'sinMora
        '
        '
        '
        '
        Me.sinMora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sinMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinMora.Location = New System.Drawing.Point(144, 58)
        Me.sinMora.Name = "sinMora"
        Me.sinMora.Size = New System.Drawing.Size(91, 26)
        Me.sinMora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sinMora.TabIndex = 10
        Me.sinMora.Text = "Sin Mora"
        '
        'frmGenCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(348, 184)
        Me.Controls.Add(Me.sinMora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.FlattenMDIBorder = False
        Me.Name = "frmGenCobro"
        Me.Text = "Generar Cobro"
        CType(Me.GenCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
