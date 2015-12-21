Imports System.IO
Imports System.Data.SqlClient

Public Class CMatricula
    Inherits System.Windows.Forms.UserControl
    Dim bd As String = "matricula"
    Dim carnet As String
    Public dsNiveles As New DataSet
    Dim conn As New conexionSQL

    Dim datosCobros As New ArrayList
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListBoxAdv1 As DevComponents.DotNetBar.ListBoxAdv
    Dim datosCobrosTotal As New ArrayList

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
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonedaTextBox2 As colegio.MonedaTextBox
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMatricula))
        Me.DataSet21 = New colegio.DataSet2()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.DsCuotas1 = New colegio.dsCuotas()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.poliza = New colegio.MonedaTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonedaTextBox2 = New colegio.MonedaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.matricula = New colegio.MonedaTextBox()
        Me.bingo = New colegio.MonedaTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cuaderno = New colegio.MonedaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ListBoxAdv1 = New DevComponents.DotNetBar.ListBoxAdv()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCuotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "matricula", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("poliza", "poliza"), New System.Data.Common.DataColumnMapping("beca", "beca"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("bingo", "bingo"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("cuaderno", "cuaderno")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ano", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_grupo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_poliza", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "poliza", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_recibo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bingo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bingo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cuaderno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cuaderno", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;Integrated Security=True"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 0, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 0, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 0, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 0, "grupo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 0, "monto"), New System.Data.SqlClient.SqlParameter("@poliza", System.Data.SqlDbType.Money, 0, "poliza"), New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.Money, 0, "beca"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 0, "recibo"), New System.Data.SqlClient.SqlParameter("@bingo", System.Data.SqlDbType.Money, 0, "bingo"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 0, "fecha"), New System.Data.SqlClient.SqlParameter("@cuaderno", System.Data.SqlDbType.Money, 0, "cuaderno")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT  carnet, ano, nivel, grupo, monto, poliza, beca, id_mat, recibo, bingo, fe" &
    "cha, cuaderno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     matricula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE  (carnet = @carnet) AND (ano = @ano)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 0, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 0, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 0, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 0, "grupo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 0, "monto"), New System.Data.SqlClient.SqlParameter("@poliza", System.Data.SqlDbType.Money, 0, "poliza"), New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.Money, 0, "beca"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 0, "recibo"), New System.Data.SqlClient.SqlParameter("@bingo", System.Data.SqlDbType.Money, 0, "bingo"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 0, "fecha"), New System.Data.SqlClient.SqlParameter("@cuaderno", System.Data.SqlDbType.Money, 0, "cuaderno"), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ano", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_grupo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_poliza", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "poliza", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_recibo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_bingo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bingo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cuaderno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cuaderno", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuaderno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" &
    "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" &
    "E (nivel = @nivel)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DsCuotas1
        '
        Me.DsCuotas1.DataSetName = "dsCuotas"
        Me.DsCuotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsCuotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.carnet", True))
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(377, 68)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(56, 20)
        Me.TextBox10.TabIndex = 53
        Me.TextBox10.Visible = False
        '
        'poliza
        '
        Me.poliza.BackColor = System.Drawing.SystemColors.Info
        Me.poliza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.poliza", True))
        Me.poliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poliza.FormatoText = colegio.MonedaTextBox.formatos.Numero
        Me.poliza.Location = New System.Drawing.Point(72, 97)
        Me.poliza.Name = "poliza"
        Me.poliza.ReadOnly = True
        Me.poliza.Size = New System.Drawing.Size(64, 20)
        Me.poliza.TabIndex = 8
        Me.poliza.Text = "0,00"
        Me.poliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(16, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 11)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Poliza"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.grupo", True))
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ItemHeight = 15
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(144, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(56, 23)
        Me.ComboBox2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(144, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Grupo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(72, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nivel"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(24, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Año"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.ano", True))
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(24, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(40, 21)
        Me.TextBox5.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet21, "matricula.nivel", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.nivel", True))
        Me.ComboBox1.DataSource = Me.DataSet21.niveles
        Me.ComboBox1.DisplayMember = "nivel"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ItemHeight = 15
        Me.ComboBox1.Location = New System.Drawing.Point(72, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "nivel"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 56
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(24, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(40, 20)
        Me.TextBox2.TabIndex = 57
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(56, 20)
        Me.TextBox3.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Bingo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonedaTextBox2
        '
        Me.MonedaTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonedaTextBox2.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox2.Location = New System.Drawing.Point(142, 136)
        Me.MonedaTextBox2.Name = "MonedaTextBox2"
        Me.MonedaTextBox2.Size = New System.Drawing.Size(82, 20)
        Me.MonedaTextBox2.TabIndex = 5
        Me.MonedaTextBox2.Text = "₡0,00"
        Me.MonedaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 11)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Matricula"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.recibo", True))
        Me.TextBox4.Location = New System.Drawing.Point(415, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(82, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(356, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 14)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Recibo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(374, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 11)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Fecha"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.fecha", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(415, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(82, 20)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.id_mat", True))
        Me.TextBox7.Location = New System.Drawing.Point(433, 68)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(64, 20)
        Me.TextBox7.TabIndex = 71
        Me.TextBox7.Visible = False
        '
        'matricula
        '
        Me.matricula.BackColor = System.Drawing.SystemColors.Info
        Me.matricula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.monto", True))
        Me.matricula.FormatoText = colegio.MonedaTextBox.formatos.Numero
        Me.matricula.Location = New System.Drawing.Point(72, 77)
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
        Me.matricula.Size = New System.Drawing.Size(64, 20)
        Me.matricula.TabIndex = 7
        Me.matricula.Text = "0,00"
        Me.matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bingo
        '
        Me.bingo.BackColor = System.Drawing.SystemColors.Info
        Me.bingo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.bingo", True))
        Me.bingo.FormatoText = colegio.MonedaTextBox.formatos.Numero
        Me.bingo.Location = New System.Drawing.Point(72, 117)
        Me.bingo.Name = "bingo"
        Me.bingo.ReadOnly = True
        Me.bingo.Size = New System.Drawing.Size(64, 20)
        Me.bingo.TabIndex = 9
        Me.bingo.Text = "0,00"
        Me.bingo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cuaderno
        '
        Me.cuaderno.BackColor = System.Drawing.SystemColors.Info
        Me.cuaderno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.cuaderno", True))
        Me.cuaderno.FormatoText = colegio.MonedaTextBox.formatos.Numero
        Me.cuaderno.Location = New System.Drawing.Point(72, 137)
        Me.cuaderno.Name = "cuaderno"
        Me.cuaderno.ReadOnly = True
        Me.cuaderno.Size = New System.Drawing.Size(64, 20)
        Me.cuaderno.TabIndex = 73
        Me.cuaderno.Text = "0,00"
        Me.cuaderno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 11)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Cuaderno"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(419, 93)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 68)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 48.0!
        Me.ButtonX1.TabIndex = 75
        Me.ButtonX1.Visible = False
        '
        'ListBoxAdv1
        '
        Me.ListBoxAdv1.AutoScroll = True
        Me.ListBoxAdv1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ListBoxAdv1.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxAdv1.CheckStateMember = Nothing
        Me.ListBoxAdv1.ContainerControlProcessDialogKey = True
        Me.ListBoxAdv1.DragDropSupport = True
        Me.ListBoxAdv1.Location = New System.Drawing.Point(249, 24)
        Me.ListBoxAdv1.Name = "ListBoxAdv1"
        Me.ListBoxAdv1.Size = New System.Drawing.Size(160, 136)
        Me.ListBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ListBoxAdv1.TabIndex = 76
        Me.ListBoxAdv1.Text = "ListBoxAdv1"
        '
        'CMatricula
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.ListBoxAdv1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.cuaderno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bingo)
        Me.Controls.Add(Me.matricula)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MonedaTextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.poliza)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox7)
        Me.Name = "CMatricula"
        Me.Size = New System.Drawing.Size(500, 175)
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCuotas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

        poliza.Text = ""
        matricula.Text = ""
        bingo.Text = ""
        MonedaTextBox2.Text = "0,00"
        cuaderno.Text = ""

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
            MessageBox.Show(ex.Message, "Imprimir",
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

                    nuevo.Row.ItemArray = Vdatos           'ojoo caraga datos año anterior

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
                        MonedaTextBox2.Text = datosCobrosTotal(0)(0)
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

                    ButtonX1.Visible = True
                Else
                    limpia_controles()
                End If
            End If
        Catch ecepcion As Exception
            MsgBox(ecepcion.Message, MsgBoxStyle.Critical, "Error en Cmatricula, buscar")
        End Try
    End Sub
    Sub CargarPagoMatricula(ByVal pcarnet As String, ByVal pano As String)
        Try

            Dim connCobros As New conexionSQL
        datosCobrosTotal = connCobros.llena("EXEC cobroMatriculaTotal '" & pcarnet & "' ," & pano)
            datosCobros = connCobros.llena("EXEC cobroMatriculaConsulta '" & pcarnet & "' ," & pano)
            If datosCobros.Count > 0 Then   '' cobros generados
                Dim pendiente As Decimal = datosCobrosTotal(0)(0) - datosCobrosTotal(0)(1)
                If (pendiente = 0) Then
                    MonedaTextBox2.Text = datosCobrosTotal(0)(0)

                    ButtonX1.Visible = True
                Else
                    'MessageBox.Show("Estudiante sin cancelar recibo(s)")
                    limpia_controles()
                    datosCobros = Nothing

                    ButtonX1.Visible = False
                End If
            Else
                MessageBox.Show("Estudiante sin cobro Matricula, posible aplazado")

                datosCobros = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en Cmatricula|CargarPagoMatricula")
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


    'Private Sub MonedaTextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MonedaTextBox2.Validating

    '    Dim Rmatri As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("MATRICULA")
    '    Dim Rcuad As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("CUADERNO")
    '    Dim Rbingo As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("BINGO")
    '    Dim mat, bin, pol, cua, monto As Decimal
    '    If IsNumeric(MonedaTextBox2.Text) Then

    '        monto = MonedaTextBox2.Text

    '        If monto >= Rmatri.Item("monto") Then
    '            mat = Rmatri.Item("monto")
    '            cua = Rcuad.Item("monto")
    '            monto -= (mat + cua)
    '            If MessageBox.Show("Paga Bingo ?", "Bingo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '                If monto >= Rbingo.Item("monto") Then
    '                    cua = Rcuad.Item("monto")
    '                    bin = Rbingo.Item("monto")
    '                    pol = monto - bin
    '                End If
    '            Else
    '                bin = 0
    '                pol = monto
    '            End If
    '        End If

    '        If pol >= 0 And bin >= 0 And mat >= 0 Then
    '            poliza.Text = pol
    '            bingo.Text = bin
    '            matricula.Text = mat
    '            cuaderno.Text = cua

    '            Dim Obind As BindingManagerBase = BindingContext(DataSet21.Tables("matricula"))
    '            Dim nuevo As DataRowView = Obind.Current
    '            nuevo.Item("monto") = mat
    '            nuevo.Item("poliza") = pol
    '            nuevo.Item("bingo") = bin
    '            nuevo.Item("cuaderno") = cua
    '            ErrorProvider1.SetError(MonedaTextBox2, "")
    '        Else
    '            e.Cancel = True
    '            MonedaTextBox2.Select(0, MonedaTextBox2.Text.Length)
    '            ' Set the ErrorProvider error with the text to display. 
    '            ErrorProvider1.SetError(MonedaTextBox2, "monto inferior al mínimo")
    '        End If
    '    Else
    '        e.Cancel = True
    '        MonedaTextBox2.Text = 0
    '        ErrorProvider1.SetError(MonedaTextBox2, "No es un valor")
    '    End If
    '    Button2.Visible = True
    'End Sub

    Private Sub MonedaTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MonedaTextBox2.TextChanged
        Try
            If carnet IsNot Nothing Then


                Dim Rmatri As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("MATRICULA")
                Dim Rcuad As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("CUADERNO")
                Dim Rbingo As DataRow = DsCuotas1.Tables("cuotas").Rows.Find("BINGO")
                Dim mat, bin, pol, cua, monto As Decimal


                monto = MonedaTextBox2.Text

                If monto >= Rmatri.Item("monto") Then
                    mat = Rmatri.Item("monto")
                    cua = Rcuad.Item("monto")
                    monto -= (mat + cua)

                    cua = Rcuad.Item("monto")
                    bin = Rbingo.Item("monto")
                    pol = monto - bin
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

                    MonedaTextBox2.Select(0, MonedaTextBox2.Text.Length)
                    ' Set the ErrorProvider error with the text to display. 
                    ErrorProvider1.SetError(MonedaTextBox2, "monto inferior al mínimo")
                End If

            End If
        Catch ex As Exception
            MsgBox("Errror  " & Me.Name)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If (error_blanco(ComboBox1) And error_blanco(ComboBox2) And
           error_blanco(MonedaTextBox2)) Then
            guardar()
            Enabled = False
        End If
    End Sub
End Class
