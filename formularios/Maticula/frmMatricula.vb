Imports System.IO
Imports System.Data.SqlClient

Public Class frmMatricula
    Inherits System.Windows.Forms.Form
    Dim bd As String = "matricula"
    Public dsNiveles As New DataSet()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox9 As colegio.MonedaTextBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSet21 As colegio.DataSet2
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsCuotas1 As colegio.dsCuotas
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMatricula))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.DataSet21 = New colegio.DataSet2
        Me.TextBox9 = New colegio.MonedaTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.UserControl21 = New colegio.UserControl2
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsCuotas1 = New colegio.dsCuotas
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCuotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 311)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Matricular"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(216, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.carnet"))
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(296, 224)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(112, 20)
        Me.TextBox10.TabIndex = 21
        Me.TextBox10.Text = ""
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.poliza"))
        Me.TextBox9.Enabled = False
        Me.TextBox9.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.TextBox9.Location = New System.Drawing.Point(288, 104)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(64, 20)
        Me.TextBox9.TabIndex = 6
        Me.TextBox9.Text = "¢0,00"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(288, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Poliza"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(224, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Beca"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.beca"))
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(224, 104)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(48, 20)
        Me.TextBox8.TabIndex = 5
        Me.TextBox8.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.id_mat"))
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(296, 200)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(112, 20)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.Text = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.grupo"))
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(280, 56)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(280, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Grupo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Carnet"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(200, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nivel"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(136, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Encargado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.encargado"))
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(24, 104)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(192, 20)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.ano"))
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(136, 56)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 20)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(272, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Periodo"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet21, "matricula.nivel"))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "matricula.nivel"))
        Me.ComboBox1.DataSource = Me.DataSet21.niveles
        Me.ComboBox1.DisplayMember = "nivel"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(200, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "nivel"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(144, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "estudiantes.apellido2"))
        Me.TextBox4.Location = New System.Drawing.Point(40, 216)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(136, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "estudiantes.apellido1"))
        Me.TextBox3.Location = New System.Drawing.Point(40, 192)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(136, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet21, "estudiantes.nombre"))
        Me.TextBox2.Location = New System.Drawing.Point(40, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(136, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(40, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carnet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(24, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(0, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(378, 40)
        Me.UserControl21.TabIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
        "scritorio;persist security info=False;initial catalog=colegio"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "matricula", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("encargado", "encargado"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("poliza", "poliza"), New System.Data.Common.DataColumnMapping("beca", "beca"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM matricula WHERE (id_mat = @Original_id_mat) AND (ano = @Original_ano " & _
        "OR @Original_ano IS NULL AND ano IS NULL) AND (beca = @Original_beca OR @Origina" & _
        "l_beca IS NULL AND beca IS NULL) AND (carnet = @Original_carnet OR @Original_car" & _
        "net IS NULL AND carnet IS NULL) AND (encargado = @Original_encargado OR @Origina" & _
        "l_encargado IS NULL AND encargado IS NULL) AND (fecha = @Original_fecha OR @Orig" & _
        "inal_fecha IS NULL AND fecha IS NULL) AND (grupo = @Original_grupo OR @Original_" & _
        "grupo IS NULL AND grupo IS NULL) AND (monto = @Original_monto OR @Original_monto" & _
        " IS NULL AND monto IS NULL) AND (nivel = @Original_nivel OR @Original_nivel IS N" & _
        "ULL AND nivel IS NULL) AND (poliza = @Original_poliza OR @Original_poliza IS NUL" & _
        "L AND poliza IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.VarChar, 31, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ano", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_encargado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_grupo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_poliza", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "poliza", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO matricula (carnet, ano, encargado, nivel, grupo, monto, fecha, poliza" & _
        ", beca, id_mat) VALUES (@carnet, @ano, @encargado, @nivel, @grupo, @monto, @fech" & _
        "a, @poliza, @beca); SELECT carnet, ano, encargado, nivel, grupo, monto, fecha, p" & _
        "oliza, beca FROM matricula"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@encargado", System.Data.SqlDbType.VarChar, 50, "encargado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@poliza", System.Data.SqlDbType.Money, 8, "poliza"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT carnet, ano, encargado, nivel, grupo, monto, fecha, poliza, beca, id_mat F" & _
        "ROM matricula WHERE (carnet = @carnet) AND (ano = @ano)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE matricula SET carnet = @carnet, ano = @ano, encargado = @encargado, nivel " & _
        "= @nivel, grupo = @grupo, monto = @monto, fecha = @fecha, poliza = @poliza, beca" & _
        " = @beca, id_mat = @id_mat WHERE (id_mat = @Original_id_mat) AND (ano = @Origina" & _
        "l_ano OR @Original_ano IS NULL AND ano IS NULL) AND (beca = @Original_beca OR @O" & _
        "riginal_beca IS NULL AND beca IS NULL) AND (carnet = @Original_carnet OR @Origin" & _
        "al_carnet IS NULL AND carnet IS NULL) AND (encargado = @Original_encargado OR @O" & _
        "riginal_encargado IS NULL AND encargado IS NULL) AND (fecha = @Original_fecha OR" & _
        " @Original_fecha IS NULL AND fecha IS NULL) AND (grupo = @Original_grupo OR @Ori" & _
        "ginal_grupo IS NULL AND grupo IS NULL) AND (monto = @Original_monto OR @Original" & _
        "_monto IS NULL AND monto IS NULL) AND (nivel = @Original_nivel OR @Original_nive" & _
        "l IS NULL AND nivel IS NULL) AND (poliza = @Original_poliza OR @Original_poliza " & _
        "IS NULL AND poliza IS NULL); SELECT carnet, ano, encargado, nivel, grupo, monto," & _
        " fecha, poliza, beca, id_mat FROM matricula WHERE (id_mat = @id_mat)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@encargado", System.Data.SqlDbType.VarChar, 50, "encargado"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@poliza", System.Data.SqlDbType.Money, 8, "poliza"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.VarChar, 31, "id_mat"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.VarChar, 31, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ano", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_encargado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_grupo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_poliza", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "poliza", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("encargado1", "encargado1"), New System.Data.Common.DataColumnMapping("relacion", "relacion"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("encargado2", "encargado2"), New System.Data.Common.DataColumnMapping("relacion2", "relacion2"), New System.Data.Common.DataColumnMapping("direccion2", "direccion2"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("email2", "email2"), New System.Data.Common.DataColumnMapping("foto", "foto"), New System.Data.Common.DataColumnMapping("estado", "estado")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM estudiantes WHERE (carnet = @Original_carnet) AND (apellido1 = @Origi" & _
        "nal_apellido1 OR @Original_apellido1 IS NULL AND apellido1 IS NULL) AND (apellid" & _
        "o2 = @Original_apellido2 OR @Original_apellido2 IS NULL AND apellido2 IS NULL) A" & _
        "ND (direccion = @Original_direccion OR @Original_direccion IS NULL AND direccion" & _
        " IS NULL) AND (direccion2 = @Original_direccion2 OR @Original_direccion2 IS NULL" & _
        " AND direccion2 IS NULL) AND (email = @Original_email OR @Original_email IS NULL" & _
        " AND email IS NULL) AND (email2 = @Original_email2 OR @Original_email2 IS NULL A" & _
        "ND email2 IS NULL) AND (encargado1 = @Original_encargado1 OR @Original_encargado" & _
        "1 IS NULL AND encargado1 IS NULL) AND (encargado2 = @Original_encargado2 OR @Ori" & _
        "ginal_encargado2 IS NULL AND encargado2 IS NULL) AND (estado = @Original_estado " & _
        "OR @Original_estado IS NULL AND estado IS NULL) AND (nombre = @Original_nombre O" & _
        "R @Original_nombre IS NULL AND nombre IS NULL) AND (relacion = @Original_relacio" & _
        "n OR @Original_relacion IS NULL AND relacion IS NULL) AND (relacion2 = @Original" & _
        "_relacion2 OR @Original_relacion2 IS NULL AND relacion2 IS NULL) AND (telefono =" & _
        " @Original_telefono OR @Original_telefono IS NULL AND telefono IS NULL) AND (tel" & _
        "efono2 = @Original_telefono2 OR @Original_telefono2 IS NULL AND telefono2 IS NUL" & _
        "L)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_apellido1", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_apellido2", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_encargado1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_encargado2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_relacion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_relacion2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO estudiantes(carnet, nombre, apellido1, apellido2, encargado1, relacio" & _
        "n, direccion, telefono, email, encargado2, relacion2, direccion2, telefono2, ema" & _
        "il2, foto, estado) VALUES (@carnet, @nombre, @apellido1, @apellido2, @encargado1" & _
        ", @relacion, @direccion, @telefono, @email, @encargado2, @relacion2, @direccion2" & _
        ", @telefono2, @email2, @foto, @estado); SELECT carnet, nombre, apellido1, apelli" & _
        "do2, encargado1, relacion, direccion, telefono, email, encargado2, relacion2, di" & _
        "reccion2, telefono2, email2, foto, estado FROM estudiantes WHERE (carnet = @carn" & _
        "et)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@encargado1", System.Data.SqlDbType.VarChar, 50, "encargado1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@relacion", System.Data.SqlDbType.VarChar, 10, "relacion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@encargado2", System.Data.SqlDbType.VarChar, 50, "encargado2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@relacion2", System.Data.SqlDbType.VarChar, 10, "relacion2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion2", System.Data.SqlDbType.VarChar, 50, "direccion2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.VarChar, 10, "telefono2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email2", System.Data.SqlDbType.VarChar, 50, "email2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@foto", System.Data.SqlDbType.VarBinary, 2147483647, "foto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 10, "estado"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT carnet, nombre, apellido1, apellido2, encargado1, relacion, direccion, tel" & _
        "efono, email, encargado2, relacion2, direccion2, telefono2, email2, foto, estado" & _
        " FROM estudiantes WHERE (carnet = @carnet)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE estudiantes SET carnet = @carnet, nombre = @nombre, apellido1 = @apellido1" & _
        ", apellido2 = @apellido2, encargado1 = @encargado1, relacion = @relacion, direcc" & _
        "ion = @direccion, telefono = @telefono, email = @email, encargado2 = @encargado2" & _
        ", relacion2 = @relacion2, direccion2 = @direccion2, telefono2 = @telefono2, emai" & _
        "l2 = @email2, foto = @foto, estado = @estado WHERE (carnet = @Original_carnet) A" & _
        "ND (apellido1 = @Original_apellido1 OR @Original_apellido1 IS NULL AND apellido1" & _
        " IS NULL) AND (apellido2 = @Original_apellido2 OR @Original_apellido2 IS NULL AN" & _
        "D apellido2 IS NULL) AND (direccion = @Original_direccion OR @Original_direccion" & _
        " IS NULL AND direccion IS NULL) AND (direccion2 = @Original_direccion2 OR @Origi" & _
        "nal_direccion2 IS NULL AND direccion2 IS NULL) AND (email = @Original_email OR @" & _
        "Original_email IS NULL AND email IS NULL) AND (email2 = @Original_email2 OR @Ori" & _
        "ginal_email2 IS NULL AND email2 IS NULL) AND (encargado1 = @Original_encargado1 " & _
        "OR @Original_encargado1 IS NULL AND encargado1 IS NULL) AND (encargado2 = @Origi" & _
        "nal_encargado2 OR @Original_encargado2 IS NULL AND encargado2 IS NULL) AND (esta" & _
        "do = @Original_estado OR @Original_estado IS NULL AND estado IS NULL) AND (nombr" & _
        "e = @Original_nombre OR @Original_nombre IS NULL AND nombre IS NULL) AND (relaci" & _
        "on = @Original_relacion OR @Original_relacion IS NULL AND relacion IS NULL) AND " & _
        "(relacion2 = @Original_relacion2 OR @Original_relacion2 IS NULL AND relacion2 IS" & _
        " NULL) AND (telefono = @Original_telefono OR @Original_telefono IS NULL AND tele" & _
        "fono IS NULL) AND (telefono2 = @Original_telefono2 OR @Original_telefono2 IS NUL" & _
        "L AND telefono2 IS NULL); SELECT carnet, nombre, apellido1, apellido2, encargado" & _
        "1, relacion, direccion, telefono, email, encargado2, relacion2, direccion2, tele" & _
        "fono2, email2, foto, estado FROM estudiantes WHERE (carnet = @carnet)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@encargado1", System.Data.SqlDbType.VarChar, 50, "encargado1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@relacion", System.Data.SqlDbType.VarChar, 10, "relacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@encargado2", System.Data.SqlDbType.VarChar, 50, "encargado2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@relacion2", System.Data.SqlDbType.VarChar, 10, "relacion2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion2", System.Data.SqlDbType.VarChar, 50, "direccion2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.VarChar, 10, "telefono2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email2", System.Data.SqlDbType.VarChar, 50, "email2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@foto", System.Data.SqlDbType.VarBinary, 2147483647, "foto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 10, "estado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_apellido1", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_apellido2", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_encargado1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_encargado2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_relacion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_relacion2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM niveles WHERE (nivel = @Original_nivel) AND (ciclo = @Original_ciclo " & _
        "OR @Original_ciclo IS NULL AND ciclo IS NULL) AND (cobros = @Original_cobros OR " & _
        "@Original_cobros IS NULL AND cobros IS NULL) AND (descripcion = @Original_descri" & _
        "pcion OR @Original_descripcion IS NULL AND descripcion IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" & _
        "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" & _
        "E (nivel = @nivel)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.VarChar, 50, "cobros"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE niveles SET nivel = @nivel, ciclo = @ciclo, cobros = @cobros, descripcion " & _
        "= @descripcion WHERE (nivel = @Original_nivel) AND (ciclo = @Original_ciclo OR @" & _
        "Original_ciclo IS NULL AND ciclo IS NULL) AND (cobros = @Original_cobros OR @Ori" & _
        "ginal_cobros IS NULL AND cobros IS NULL) AND (descripcion = @Original_descripcio" & _
        "n OR @Original_descripcion IS NULL AND descripcion IS NULL); SELECT nivel, ciclo" & _
        ", cobros, descripcion FROM niveles WHERE (nivel = @nivel)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.VarChar, 50, "cobros"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsCuotas1
        '
        Me.DsCuotas1.DataSetName = "dsCuotas"
        Me.DsCuotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'frmMatricula
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(378, 311)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMatricula"
        Me.Text = "Matricula"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCuotas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Sub carga_datos()
        Try

            DataSet21.Tables("estudiantes").Clear()
            SqlSelectCommand2.Parameters.Item("@carnet").Value = TextBox1.Text
            Me.SqlDataAdapter2.Fill(DataSet21, "estudiantes")
            Me.BindingContext(DataSet21, "estudiantes").EndCurrentEdit()

            If Me.BindingContext(DataSet21, "estudiantes").Count > 0 Then
                Me.ComboBox1.Enabled = True
                Me.ComboBox2.Enabled = True
                Me.TextBox5.Enabled = True
                Me.TextBox6.Enabled = True
                Me.TextBox8.Enabled = True
                Me.TextBox9.Enabled = True
                Me.TextBox5.Text = Now.Year

                Dim DataRowView1 As DataRowView
                DataRowView1 = CType(Me.BindingContext(DataSet21, "estudiantes").Current, DataRowView)
                Dim bytBLOBData() As Byte = CType(DataRowView1("foto"), Byte())
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                PictureBox1.Image = Image.FromStream(stmBLOBData)
            Else
                MessageBox.Show("Estudiante no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PictureBox1.Image = Nothing
                Me.ComboBox1.Enabled = False
                Me.ComboBox2.Enabled = False
                Me.TextBox5.Enabled = False
                Me.TextBox6.Enabled = False
                Me.TextBox8.Enabled = False
                Me.TextBox9.Enabled = False

            End If
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub frmMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UserControl21.ButtonItem4.Visible = False
        Me.UserControl21.ButtonItem3.Visible = False
        Me.UserControl21.ButtonItem5.Visible = False
        Me.TextBox1.Focus()

        Dim conn As New conexionSQL()
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlDataAdapter3.Fill(DataSet21, "niveles")
    End Sub

    Public Sub nuevo()
        Try
            'Me.BindingContext(DataSet21, "matricula").EndCurrentEdit()
            'Me.BindingContext(DataSet21, "matricula").AddNew()
            PictureBox1.Image = Nothing
            Me.ComboBox1.Enabled = False
            Me.ComboBox2.Enabled = False
            Me.TextBox5.Enabled = False
            Me.TextBox6.Enabled = False
            Me.TextBox1.Enabled = True
            Me.TextBox8.Enabled = False
            Me.TextBox9.Enabled = False
            Me.TextBox1.Focus()
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub guardar()
        Try
            Me.BindingContext(DataSet21, "matricula").EndCurrentEdit()
            Me.SqlDataAdapter1.Update(DataSet21, "matricula")
            DataSet21.AcceptChanges()
            Me.ComboBox1.Enabled = False
            Me.ComboBox2.Enabled = False
            Me.TextBox5.Enabled = False
            Me.TextBox6.Enabled = False
            Me.TextBox1.Enabled = False
            Me.TextBox8.Enabled = False
            Me.TextBox9.Enabled = False
            PictureBox1.Image = Nothing
            Me.UserControl21.Focus()
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub imprimir()
        Try
            Dim mi_reporte As New DataSet1()
            Me.SqlDataAdapter1.Fill(mi_reporte, "matricula")
            Dim mi_rptEst As New rptEstudiantes()
            mi_rptEst.SetDataSource(mi_reporte)
            Dim miForma As New frmReporte()
            miForma.CrystalReportViewer1.ReportSource = mi_rptEst
            miForma.Text = "Reporte de Matricula"
            miForma.MdiParent = Me.ParentForm
            miForma.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        Try

            Dim val As Integer
            Dim tempo As String
            DataSet21.Tables("matricula").Clear()
            tempo = TextBox1.Text
            SqlSelectCommand1.Parameters.Item("@carnet").Value = TextBox1.Text
            SqlSelectCommand1.Parameters.Item("@ano").Value = Now.Year.ToString
            val = SqlDataAdapter1.Fill(DataSet21, "matricula")
            If val = 0 Then   ' en el caso de que NO se haya matriculado este ano
                Me.BindingContext(DataSet21, "matricula").EndCurrentEdit()
                Me.BindingContext(DataSet21, "matricula").AddNew()
                TextBox1.Text = tempo
                Me.carga_datos()
                ComboBox1.Focus()
            Else
                Dim resp = MsgBox("Ya esta Matriculado ,Desea modificar ?", MsgBoxStyle.YesNo)
                If resp = MsgBoxResult.Yes Then  ' en el caso de modificar
                    Me.carga_datos()
                    ComboBox1.Focus()
                Else
                    TextBox1.Focus()
                End If
            End If
        Catch ecepcion As Exception
            MsgBox(ecepcion.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown

        Dim data As IDataObject = Clipboard.GetDataObject()
        If (data.GetDataPresent(DataFormats.Text)) Then
            Me.TextBox1.Text = data.GetData(DataFormats.Text).ToString()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

   
    Private Sub TextBox9_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox9.Validating
        ' Dim cadena As String = Me.ComboBox1.Text        
        TextBox7.Text = TextBox5.Text & ComboBox1.Text & ComboBox2.Text & TextBox1.Text
        TextBox10.Text = TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.guardar()
        ' Me.Close()
    End Sub
End Class
