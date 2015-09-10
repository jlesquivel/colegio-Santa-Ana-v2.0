Imports System.IO
Imports System.Data.SqlClient

Public Class CMatricula
    Inherits System.Windows.Forms.UserControl
    Dim bd As String = "matricula"
    Dim carnet As String
    Public dsNiveles As New DataSet
    Dim conn As New conexionSQL

    Dim datosCobros As New ArrayList

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
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet21 As colegio.DataSet2
    Friend WithEvents DsCuotas1 As colegio.dsCuotas
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonedaTextBox2 As colegio.MonedaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents poliza As colegio.MonedaTextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents matricula As colegio.MonedaTextBox
    Friend WithEvents bingo As colegio.MonedaTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TextBox8 As colegio.MonedaTextBox
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cuaderno As colegio.MonedaTextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMatricula))
        DataSet21 = New colegio.DataSet2()
        SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        DsCuotas1 = New colegio.dsCuotas()
        TextBox10 = New System.Windows.Forms.TextBox()
        poliza = New colegio.MonedaTextBox()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        ComboBox2 = New System.Windows.Forms.ComboBox()
        Label9 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        TextBox5 = New System.Windows.Forms.TextBox()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        Button2 = New System.Windows.Forms.Button()
        TextBox1 = New System.Windows.Forms.TextBox()
        TextBox2 = New System.Windows.Forms.TextBox()
        TextBox3 = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        MonedaTextBox2 = New colegio.MonedaTextBox()
        Label4 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        TextBox4 = New System.Windows.Forms.TextBox()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        TextBox7 = New System.Windows.Forms.TextBox()
        matricula = New colegio.MonedaTextBox()
        bingo = New colegio.MonedaTextBox()
        ErrorProvider1 = New System.Windows.Forms.ErrorProvider(components)
        ImageList1 = New System.Windows.Forms.ImageList(components)
        TextBox8 = New colegio.MonedaTextBox()
        cuaderno = New colegio.MonedaTextBox()
        Label5 = New System.Windows.Forms.Label()
        CType(DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DsCuotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'DataSet21
        '
        DataSet21.DataSetName = "DataSet2"
        DataSet21.Locale = New System.Globalization.CultureInfo("es-CR")
        DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;Integrated Security=True"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand2
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "matricula", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("poliza", "poliza"), New System.Data.Common.DataColumnMapping("beca", "beca"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("bingo", "bingo"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("cuaderno", "cuaderno")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand1
        '
        'SqlDeleteCommand2
        '
        SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        SqlDeleteCommand2.Connection = SqlConnection2
        SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ano", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_grupo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_poliza", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "poliza", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_recibo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bingo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bingo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cuaderno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cuaderno", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        SqlConnection2.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;Integrated Security=True"
        SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        SqlInsertCommand1.Connection = SqlConnection2
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 0, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 0, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 0, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 0, "grupo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 0, "monto"), New System.Data.SqlClient.SqlParameter("@poliza", System.Data.SqlDbType.Money, 0, "poliza"), New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.Money, 0, "beca"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 0, "recibo"), New System.Data.SqlClient.SqlParameter("@bingo", System.Data.SqlDbType.Money, 0, "bingo"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 0, "fecha"), New System.Data.SqlClient.SqlParameter("@cuaderno", System.Data.SqlDbType.Money, 0, "cuaderno")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT  carnet, ano, nivel, grupo, monto, poliza, beca, id_mat, recibo, bingo, fe" & _
    "cha, cuaderno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     matricula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE  (carnet = @carnet) AND (ano = @ano)"
        SqlSelectCommand1.Connection = SqlConnection2
        SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano")})
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection2
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 0, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 0, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 0, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 0, "grupo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 0, "monto"), New System.Data.SqlClient.SqlParameter("@poliza", System.Data.SqlDbType.Money, 0, "poliza"), New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.Money, 0, "beca"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 0, "recibo"), New System.Data.SqlClient.SqlParameter("@bingo", System.Data.SqlDbType.Money, 0, "bingo"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 0, "fecha"), New System.Data.SqlClient.SqlParameter("@cuaderno", System.Data.SqlDbType.Money, 0, "cuaderno"), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ano", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_grupo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_poliza", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "poliza", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_recibo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bingo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bingo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cuaderno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cuaderno", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter3
        '
        SqlDataAdapter3.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter3.InsertCommand = SqlInsertCommand3
        SqlDataAdapter3.SelectCommand = SqlSelectCommand5
        SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        SqlDataAdapter3.UpdateCommand = SqlUpdateCommand5
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        SqlInsertCommand3.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" & _
    "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" & _
    "E (nivel = @nivel)"
        SqlInsertCommand3.Connection = SqlConnection1
        SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion")})
        '
        'SqlSelectCommand5
        '
        SqlSelectCommand5.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        SqlSelectCommand5.Connection = SqlConnection1
        '
        'SqlUpdateCommand5
        '
        SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        SqlUpdateCommand5.Connection = SqlConnection1
        SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DsCuotas1
        '
        DsCuotas1.DataSetName = "dsCuotas"
        DsCuotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        DsCuotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox10
        '
        TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.carnet", True))
        TextBox10.Enabled = False
        TextBox10.Location = New System.Drawing.Point(24, 144)
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New System.Drawing.Size(56, 20)
        TextBox10.TabIndex = 53
        TextBox10.Visible = False
        '
        'poliza
        '
        poliza.BackColor = System.Drawing.SystemColors.Info
        poliza.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.poliza", True))
        poliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        poliza.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        poliza.Location = New System.Drawing.Point(208, 100)
        poliza.Name = "poliza"
        poliza.ReadOnly = True
        poliza.Size = New System.Drawing.Size(80, 20)
        poliza.TabIndex = 8
        poliza.Text = "¢0,00"
        poliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Label11.Location = New System.Drawing.Point(152, 103)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(56, 11)
        Label11.TabIndex = 52
        Label11.Text = "Poliza"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Label10.Location = New System.Drawing.Point(207, 8)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(56, 16)
        Label10.TabIndex = 51
        Label10.Text = "Beca"
        '
        'ComboBox2
        '
        ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.grupo", True))
        ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComboBox2.ItemHeight = 15
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox2.Location = New System.Drawing.Point(144, 48)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New System.Drawing.Size(56, 23)
        ComboBox2.TabIndex = 1
        '
        'Label9
        '
        Label9.Location = New System.Drawing.Point(144, 8)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(48, 16)
        Label9.TabIndex = 50
        Label9.Text = "Grupo"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(72, 8)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(32, 16)
        Label7.TabIndex = 49
        Label7.Text = "Nivel"
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(24, 8)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(40, 16)
        Label6.TabIndex = 48
        Label6.Text = "Año"
        '
        'TextBox5
        '
        TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.ano", True))
        TextBox5.Enabled = False
        TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox5.Location = New System.Drawing.Point(24, 48)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New System.Drawing.Size(40, 21)
        TextBox5.TabIndex = 0
        '
        'ComboBox1
        '
        ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DataSet21, "matricula.nivel", True))
        ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.nivel", True))
        ComboBox1.DataSource = DataSet21.niveles
        ComboBox1.DisplayMember = "nivel"
        ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComboBox1.ItemHeight = 15
        ComboBox1.Location = New System.Drawing.Point(72, 48)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(64, 23)
        ComboBox1.TabIndex = 0
        ComboBox1.ValueMember = "nivel"
        '
        'Button2
        '
        Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Button2.Location = New System.Drawing.Point(296, 80)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(79, 80)
        Button2.TabIndex = 6
        Button2.Visible = False
        '
        'TextBox1
        '
        TextBox1.Location = New System.Drawing.Point(72, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New System.Drawing.Size(64, 20)
        TextBox1.TabIndex = 56
        '
        'TextBox2
        '
        TextBox2.Location = New System.Drawing.Point(24, 24)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New System.Drawing.Size(40, 20)
        TextBox2.TabIndex = 57
        '
        'TextBox3
        '
        TextBox3.Location = New System.Drawing.Point(144, 24)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New System.Drawing.Size(56, 20)
        TextBox3.TabIndex = 58
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(304, 24)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 16)
        Label1.TabIndex = 59
        Label1.Text = "<- Actual"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(304, 48)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(56, 16)
        Label2.TabIndex = 60
        Label2.Text = "<- Nueva"
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(152, 123)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(56, 13)
        Label3.TabIndex = 62
        Label3.Text = "Bingo"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonedaTextBox2
        '
        MonedaTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MonedaTextBox2.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        MonedaTextBox2.Location = New System.Drawing.Point(62, 122)
        MonedaTextBox2.Name = "MonedaTextBox2"
        MonedaTextBox2.Size = New System.Drawing.Size(82, 20)
        MonedaTextBox2.TabIndex = 5
        MonedaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(21, 124)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 11)
        Label4.TabIndex = 64
        Label4.Text = "Monto"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.Location = New System.Drawing.Point(152, 83)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(56, 11)
        Label8.TabIndex = 66
        Label8.Text = "Matricula"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.recibo", True))
        TextBox4.Location = New System.Drawing.Point(62, 101)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New System.Drawing.Size(82, 20)
        TextBox4.TabIndex = 4
        '
        'Label12
        '
        Label12.Location = New System.Drawing.Point(3, 106)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(58, 14)
        Label12.TabIndex = 68
        Label12.Text = "Recibo"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Label13.Location = New System.Drawing.Point(21, 88)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(40, 11)
        Label13.TabIndex = 70
        Label13.Text = "Fecha"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.fecha", True))
        DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        DateTimePicker1.Location = New System.Drawing.Point(62, 80)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New System.Drawing.Size(82, 20)
        DateTimePicker1.TabIndex = 3
        '
        'TextBox7
        '
        TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.id_mat", True))
        TextBox7.Location = New System.Drawing.Point(80, 144)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New System.Drawing.Size(64, 20)
        TextBox7.TabIndex = 71
        TextBox7.Visible = False
        '
        'matricula
        '
        matricula.BackColor = System.Drawing.SystemColors.Info
        matricula.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.monto", True))
        matricula.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        matricula.Location = New System.Drawing.Point(208, 80)
        matricula.Name = "matricula"
        matricula.ReadOnly = True
        matricula.Size = New System.Drawing.Size(80, 20)
        matricula.TabIndex = 7
        matricula.Text = "¢0,00"
        matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bingo
        '
        bingo.BackColor = System.Drawing.SystemColors.Info
        bingo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.bingo", True))
        bingo.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        bingo.Location = New System.Drawing.Point(208, 120)
        bingo.Name = "bingo"
        bingo.ReadOnly = True
        bingo.Size = New System.Drawing.Size(80, 20)
        bingo.TabIndex = 9
        bingo.Text = "¢0,00"
        bingo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrorProvider1
        '
        ErrorProvider1.ContainerControl = Me
        '
        'ImageList1
        '
        ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        ImageList1.ImageSize = New System.Drawing.Size(48, 48)
        ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox8
        '
        TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.beca", True))
        TextBox8.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        TextBox8.Location = New System.Drawing.Point(208, 48)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New System.Drawing.Size(80, 20)
        TextBox8.TabIndex = 72
        TextBox8.Text = "¢0,00"
        TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cuaderno
        '
        cuaderno.BackColor = System.Drawing.SystemColors.Info
        cuaderno.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet21, "matricula.cuaderno", True))
        cuaderno.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        cuaderno.Location = New System.Drawing.Point(208, 140)
        cuaderno.Name = "cuaderno"
        cuaderno.ReadOnly = True
        cuaderno.Size = New System.Drawing.Size(80, 20)
        cuaderno.TabIndex = 73
        cuaderno.Text = "¢0,00"
        cuaderno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(152, 143)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 11)
        Label5.TabIndex = 74
        Label5.Text = "Cuaderno"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CMatricula
        '
        BackColor = System.Drawing.SystemColors.Control
        Controls.Add(cuaderno)
        Controls.Add(Label5)
        Controls.Add(TextBox8)
        Controls.Add(bingo)
        Controls.Add(matricula)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(MonedaTextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(poliza)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(ComboBox2)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox10)
        Controls.Add(TextBox7)
        Name = "CMatricula"
        Size = New System.Drawing.Size(400, 176)
        CType(DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DsCuotas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private Sub controlesAbre(ByVal abre As Boolean)
        Dim i As Integer
        For i = 0 To Controls.Count - 1
            Controls(i).Enabled = abre
        Next i
    End Sub

   
    Sub limpia_controles()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""

        poliza.Text = ""
        matricula.Text = ""
        bingo.Text = ""
        MonedaTextBox2.Text = ""

        ErrorProvider1.SetError(ComboBox1, "")
        ErrorProvider1.SetError(ComboBox2, "")
        ErrorProvider1.SetError(MonedaTextBox2, "")
        ErrorProvider1.SetError(TextBox4, "")
        'Me.controlesAbre(False)
    End Sub

    Private Sub CMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not DesignMode Then
            SqlConnection1.ConnectionString = conn.strConn
            SqlConnection2.ConnectionString = conn.strConn
            SqlDataAdapter3.Fill(DataSet21, "niveles")
            conn.llena(DsCuotas1, "cuotas", "Select * from cuotas")
        End If

    End Sub

    Public Sub guardar()
        Try
            Dim afectadas As Integer
            BindingContext(DataSet21, "matricula").EndCurrentEdit()
            afectadas = SqlDataAdapter1.Update(DataSet21, "matricula")
            limpia_controles()
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub imprimir()
        Try
            Dim mi_reporte As New DataSet1
            SqlDataAdapter1.Fill(mi_reporte, "matricula")
            ' Dim mi_rptEst As New rptEstudiantes
            'mi_rptEst.SetDataSource(mi_reporte)
            Dim miForma As New frmReporte
            'miForma.CrystalReportViewer1.ReportSource = mi_rptEst
            miForma.Text = "Reporte de Matricula"
            miForma.MdiParent = ParentForm
            miForma.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub buscar(ByVal pcarnet As String, ByVal pano As String)
        Try
            limpia_controles()
            Dim val As Integer
            carnet = pcarnet
            DataSet21.Tables("matricula").Clear()
            SqlDataAdapter1.SelectCommand.Parameters.Item("@carnet").Value = carnet
            SqlDataAdapter1.SelectCommand.Parameters.Item("@ano").Value = pano
            val = SqlDataAdapter1.Fill(DataSet21, "matricula")
            If val = 0 Then   ' en el caso de que NO se haya matriculado este ano
                Dim anterior As Integer = 1
                While (val = 0) And (anterior <= 7) ' busca si se ha matriculado en años anteriores
                    DataSet21.Tables("matricula").Clear()
                    SqlDataAdapter1.SelectCommand.Parameters.Item("@carnet").Value = carnet
                    SqlDataAdapter1.SelectCommand.Parameters.Item("@ano").Value = pano - anterior
                    val = SqlDataAdapter1.Fill(DataSet21, "matricula")
                    anterior += 1
                End While
                If val <> 0 Then  ' si se matriculo anterior mente carga los datos anteriores
                    Dim Vdatos As Object = DataSet21.Tables("matricula").Rows(0).ItemArray
                    TextBox1.Text = DataSet21.Tables("matricula").Rows(0).Item("nivel")
                    TextBox2.Text = DataSet21.Tables("matricula").Rows(0).Item("ano")
                    TextBox3.Text = DataSet21.Tables("matricula").Rows(0).Item("grupo")

                    Dim r2 As DataRow
                    Dim regNiveles As DataRowCollection = DataSet21.Tables("niveles").Rows
                    Dim datos As DataRow = regNiveles.Find(TextBox1.Text)
                    BindingContext(DataSet21.Tables("niveles")).Position += 1
                    r2 = regNiveles.Item(BindingContext(DataSet21.Tables("niveles")).Position)

                    Dim Obind As BindingManagerBase = BindingContext(DataSet21.Tables("matricula"))

                    DataSet21.Tables("matricula").Clear()

                    BindingContext(DataSet21.Tables("matricula")).AddNew()
                    Dim nuevo As DataRowView = Obind.Current
                    nuevo.Row.ItemArray = Vdatos

                    nuevo.Item("ano") = pano
                    nuevo.Item("fecha") = Now.Date
                    nuevo.Item("nivel") = r2.Item("nivel")

                    BindingContext(DataSet21.Tables("matricula")).EndCurrentEdit()
                    BindingContext(DataSet21.Tables("matricula")).ResumeBinding()
                Else
                    Dim Obind As BindingManagerBase = BindingContext(DataSet21.Tables("matricula"))
                    BindingContext(DataSet21.Tables("matricula")).AddNew()
                    Dim nuevo As DataRowView = Obind.Current

                    nuevo.Item("carnet") = pcarnet
                    nuevo.Item("ano") = pano
                    nuevo.Item("beca") = 0
                    nuevo.Item("monto") = 0
                    nuevo.Item("poliza") = 0
                    nuevo.Item("bingo") = 0
                    nuevo.Item("nivel") = "00"
                    nuevo.Item("grupo") = "1"

                    BindingContext(DataSet21.Tables("matricula")).EndCurrentEdit()
                    BindingContext(DataSet21.Tables("matricula")).ResumeBinding()
                End If
                'ojojojojojojojojo
                CargarPagoMatricula(pcarnet, pano)
                If Not (datosCobros Is Nothing) Then
                    If Not (datosCobros(0)(5) Is DBNull.Value) Then
                        TextBox4.Text = datosCobros(0)(5)
                        DateTimePicker1.Value = datosCobros(0)(6)
                        MonedaTextBox2.Text = datosCobros(0)(7)
                    Else
                        TextBox4.Text = ""
                        DateTimePicker1.Value = Date.Now
                        MonedaTextBox2.Text = 0
                    End If
                End If
            Else
                If MsgBox("Ya esta Matriculado ,Desea modificar ?", MsgBoxStyle.YesNo) _
                            = MsgBoxResult.Yes Then  ' en el caso de modificar
                    Dim regis As DataRow = DataSet21.Tables("matricula").Rows(0)
                    MonedaTextBox2.Text = noNull(regis.Item("bingo")) _
                                             + noNull(regis.Item("poliza")) _
                                             + noNull(regis.Item("cuaderno")) _
                                             + noNull(regis.Item("monto"))
                Else
                    limpia_controles()
                End If
            End If
        Catch ecepcion As Exception
            MsgBox(ecepcion.Message, MsgBoxStyle.Critical, "Error en Cmatricula, buscar")
        End Try
    End Sub

    Function noNull(ByVal valor As Object) As Object
        If IsDBNull(valor) Then
            noNull = 0
        Else
            noNull = valor
        End If
    End Function
    Function error_blanco(ByVal control As Object) As Boolean
        If control.Text = "" Then
            ErrorProvider1.SetError(control, "llenar por favor")
            Return False
        Else
            ErrorProvider1.SetError(control, "")
            Return True
        End If
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (error_blanco(ComboBox1) And error_blanco(ComboBox2) And _
            error_blanco(MonedaTextBox2) And error_blanco(TextBox4)) Then
            guardar()
            Enabled = False
        End If
    End Sub

    Private Sub MonedaTextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MonedaTextBox2.Validating

        Dim Rmatri As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("MATRICULA")
        Dim Rcuad As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("CUADERNO")
        Dim Rbingo As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("BINGO")
        Dim mat, bin, pol, cua, monto As Decimal
        If IsNumeric(MonedaTextBox2.Text) Then

            monto = MonedaTextBox2.Text

            If monto >= Rmatri.Item("monto") Then
                mat = Rmatri.Item("monto")
                cua = Rcuad.Item("monto")
                monto -= (mat + cua)
                If MessageBox.Show("Paga Bingo ?", "Bingo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If monto >= Rbingo.Item("monto") Then
                        cua = Rcuad.Item("monto")
                        bin = Rbingo.Item("monto")
                        pol = monto - bin
                    End If
                Else
                    bin = 0
                    pol = monto
                End If
            End If

            If pol >= 0 And bin >= 0 And mat >= 0 Then
                poliza.Text = pol
                bingo.Text = bin
                matricula.Text = mat
                cuaderno.Text = cua

                Dim Obind As BindingManagerBase = BindingContext(DataSet21.Tables("matricula"))
                Dim nuevo As DataRowView = Obind.Current
                nuevo.Item("monto") = mat
                nuevo.Item("poliza") = pol
                nuevo.Item("bingo") = bin
                nuevo.Item("cuaderno") = cua
                ErrorProvider1.SetError(MonedaTextBox2, "")
            Else
                e.Cancel = True
                MonedaTextBox2.Select(0, MonedaTextBox2.Text.Length)
                ' Set the ErrorProvider error with the text to display. 
                ErrorProvider1.SetError(MonedaTextBox2, "monto inferior al mínimo")
            End If
        Else
            e.Cancel = True
            MonedaTextBox2.Text = 0
            ErrorProvider1.SetError(MonedaTextBox2, "No es un valor")
        End If
        Button2.Visible = True
    End Sub


    Sub CargarPagoMatricula(ByVal pcarnet As String, ByVal pano As String)
        Dim connCobros As New conexionSQL
        datosCobros = connCobros.llena("EXEC cobroMatriculaConsulta '" & pcarnet & "' ," & pano)

        If datosCobros.Count > 0 Then
            If (datosCobros(0)(5) Is DBNull.Value) Then
                MessageBox.Show("Estudiante sin cancelar Matricula")
            End If
        Else
            MessageBox.Show("Estudiante sin cobro Matricula, posible aplazado")
            datosCobros = Nothing
        End If

    End Sub

End Class
