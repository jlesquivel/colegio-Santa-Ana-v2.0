Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Threading
Imports colegioReportes

Public Class frmRegistraNotas
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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TreeViewSQL1 As colegio.TreeViewSQL
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DsNotas1 As colegio.dsNotas
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tree As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataView2 As System.Data.DataView
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistraNotas))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notas")
        Splitter1 = New System.Windows.Forms.Splitter()
        ContextMenu1 = New System.Windows.Forms.ContextMenu()
        MenuItem1 = New System.Windows.Forms.MenuItem()
        MenuItem2 = New System.Windows.Forms.MenuItem()
        MenuItem3 = New System.Windows.Forms.MenuItem()
        MenuItem4 = New System.Windows.Forms.MenuItem()
        ImageList1 = New System.Windows.Forms.ImageList(components)
        tree = New System.Data.SqlClient.SqlCommand()
        SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        SqlConnection3 = New System.Data.SqlClient.SqlConnection()
        SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        DataGrid1 = New System.Windows.Forms.DataGrid()
        DsNotas1 = New colegio.dsNotas()
        DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        DataView1 = New System.Data.DataView()
        DataView2 = New System.Data.DataView()
        ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Bar1 = New DevComponents.DotNetBar.Bar()
        LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        TreeViewSQL1 = New colegio.TreeViewSQL()
        CType(DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DsNotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'Splitter1
        '
        Splitter1.Location = New System.Drawing.Point(256, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New System.Drawing.Size(3, 511)
        Splitter1.TabIndex = 2
        Splitter1.TabStop = False
        '
        'ContextMenu1
        '
        ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MenuItem1, MenuItem2, MenuItem3, MenuItem4})
        '
        'MenuItem1
        '
        MenuItem1.Index = 0
        MenuItem1.Text = "Crea/Carga Disco"
        '
        'MenuItem2
        '
        MenuItem2.Index = 1
        MenuItem2.Text = "Reporte Notas"
        '
        'MenuItem3
        '
        MenuItem3.Index = 2
        MenuItem3.Text = "Asigna Profesor"
        '
        'MenuItem4
        '
        MenuItem4.Index = 3
        MenuItem4.Text = "Lista Profesores"
        '
        'ImageList1
        '
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        ImageList1.TransparentColor = System.Drawing.Color.Transparent
        ImageList1.Images.SetKeyName(0, "1-tray.gif")
        ImageList1.Images.SetKeyName(1, "2-calendar.gif")
        ImageList1.Images.SetKeyName(2, "3-list.gif")
        ImageList1.Images.SetKeyName(3, "4-list.gif")
        ImageList1.Images.SetKeyName(4, "5-notes.gif")
        ImageList1.Images.SetKeyName(5, "6-users.gif")
        ImageList1.Images.SetKeyName(6, "")
        '
        'tree
        '
        tree.CommandText = "SELECT        ano, periodo, nivel, grupo, nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            lista_anos_peri" &
    "odos_niveles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY ano DESC, periodo, nivel, grupo, nombre"
        tree.Connection = SqlConnection1
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;User ID=sa"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand3
        SqlDataAdapter1.InsertCommand = SqlInsertCommand3
        SqlDataAdapter1.SelectCommand = SqlSelectCommand3
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nota", "nota"), New System.Data.Common.DataColumnMapping("id", "id")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        SqlDeleteCommand3.CommandText = "DELETE FROM notas WHERE (id = @Original_id) AND (nota = @Original_nota OR @Origin" &
    "al_nota IS NULL AND nota IS NULL)"
        SqlDeleteCommand3.Connection = SqlConnection1
        SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Money, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        SqlInsertCommand3.CommandText = "INSERT INTO notas(nota) VALUES (@nota); SELECT nota, id FROM notas WHERE (id = @@" &
    "IDENTITY)"
        SqlInsertCommand3.Connection = SqlConnection1
        SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Money, 4, "nota")})
        '
        'SqlSelectCommand3
        '
        SqlSelectCommand3.CommandText = "SELECT nota, id FROM notas"
        SqlSelectCommand3.Connection = SqlConnection1
        '
        'SqlUpdateCommand3
        '
        SqlUpdateCommand3.CommandText = "UPDATE notas SET nota = @nota WHERE (id = @Original_id) AND (nota = @Original_not" &
    "a OR @Original_nota IS NULL AND nota IS NULL); SELECT nota, id FROM notas WHERE " &
    "(id = @id)"
        SqlUpdateCommand3.Connection = SqlConnection1
        SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Money, 4, "nota"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Money, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.VarBinary, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_nota", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_profesora", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "profesora", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO notas(nota, id, profesora, fecha_nota) VALUES (@nota, @id, @profesora" &
    ", @fecha_nota); SELECT nota, id, profesora, fecha_nota FROM notas WHERE (id = @i" &
    "d)"
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Int, 4, "nota"), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.VarBinary, 8, "id"), New System.Data.SqlClient.SqlParameter("@profesora", System.Data.SqlDbType.VarChar, 15, "profesora"), New System.Data.SqlClient.SqlParameter("@fecha_nota", System.Data.SqlDbType.DateTime, 8, "fecha_nota")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT nota, id, profesora, fecha_nota FROM notas"
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Int, 4, "nota"), New System.Data.SqlClient.SqlParameter("@profesora", System.Data.SqlDbType.VarChar, 15, "profesora"), New System.Data.SqlClient.SqlParameter("@fecha_nota", System.Data.SqlDbType.DateTime, 8, "fecha_nota"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.VarBinary, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_nota", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_profesora", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "profesora", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.VarBinary, 8, "id")})
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = "SELECT materia, nombre FROM materia"
        SqlSelectCommand2.Connection = SqlConnection1
        '
        'SqlInsertCommand2
        '
        SqlInsertCommand2.CommandText = "INSERT INTO materia(materia, nombre) VALUES (@materia, @nombre); SELECT materia, " &
    "nombre FROM materia WHERE (materia = @materia)"
        SqlInsertCommand2.Connection = SqlConnection1
        SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlUpdateCommand2
        '
        SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        SqlUpdateCommand2.Connection = SqlConnection1
        SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        SqlDeleteCommand2.CommandText = "DELETE FROM materia WHERE (materia = @Original_materia) AND (nombre = @Original_n" &
    "ombre OR @Original_nombre IS NULL AND nombre IS NULL)"
        SqlDeleteCommand2.Connection = SqlConnection1
        SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        SqlDataAdapter2.DeleteCommand = SqlDeleteCommand2
        SqlDataAdapter2.InsertCommand = SqlInsertCommand2
        SqlDataAdapter2.SelectCommand = SqlSelectCommand2
        SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        SqlDataAdapter2.UpdateCommand = SqlUpdateCommand2
        '
        'SqlCommand1
        '
        SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        SqlCommand1.Connection = SqlConnection1
        SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, "periodo")})
        '
        'SqlSelectCommand4
        '
        SqlSelectCommand4.CommandText = "SELECT      ano, periodo, nivel, grupo, materia, cedula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          profesores" &
    "_cursos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY ano DESC"
        SqlSelectCommand4.Connection = SqlConnection2
        '
        'SqlConnection2
        '
        SqlConnection2.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;User ID=sa"
        SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand4
        '
        SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        SqlInsertCommand4.Connection = SqlConnection2
        SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, "periodo"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter3
        '
        SqlDataAdapter3.InsertCommand = SqlInsertCommand4
        SqlDataAdapter3.SelectCommand = SqlSelectCommand4
        SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "profesores_cursos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("periodo", "periodo"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo"), New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("cedula", "cedula")})})
        '
        'SqlSelectCommand5
        '
        SqlSelectCommand5.CommandText = "SELECT id_emp, cedula, apellidos, nombre, categoria, nacimiento, cuenta, ingreso," &
    " banco, direccion, telefono, celular, sexo, anualidadReconocida FROM dbo.emplead" &
    "os"
        SqlSelectCommand5.Connection = SqlConnection3
        '
        'SqlConnection3
        '
        SqlConnection3.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;User ID=sa"
        SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand5
        '
        SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        SqlInsertCommand5.Connection = SqlConnection3
        SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida")})
        '
        'SqlUpdateCommand4
        '
        SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        SqlUpdateCommand4.Connection = SqlConnection3
        SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida"), New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDeleteCommand4
        '
        SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        SqlDeleteCommand4.Connection = SqlConnection3
        SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        SqlDataAdapter4.DeleteCommand = SqlDeleteCommand4
        SqlDataAdapter4.InsertCommand = SqlInsertCommand5
        SqlDataAdapter4.SelectCommand = SqlSelectCommand5
        SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida")})})
        SqlDataAdapter4.UpdateCommand = SqlUpdateCommand4
        '
        'BackgroundWorker1
        '
        '
        'DataGrid1
        '
        DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGrid1.DataMember = ""
        DataGrid1.DataSource = DsNotas1.notas
        DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        DataGrid1.Location = New System.Drawing.Point(259, 0)
        DataGrid1.Name = "DataGrid1"
        DataGrid1.RowHeadersVisible = False
        DataGrid1.Size = New System.Drawing.Size(475, 511)
        DataGrid1.TabIndex = 3
        DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {DataGridTableStyle1})
        '
        'DsNotas1
        '
        DsNotas1.DataSetName = "dsNotas"
        DsNotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        DsNotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridTableStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridTableStyle1.DataGrid = DataGrid1
        DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {DataGridTextBoxColumn1, DataGridTextBoxColumn2, DataGridTextBoxColumn3, DataGridTextBoxColumn4, DataGridTextBoxColumn5})
        DataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        DataGridTableStyle1.MappingName = "notas"
        DataGridTableStyle1.PreferredColumnWidth = 100
        DataGridTableStyle1.RowHeadersVisible = False
        DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        '
        'DataGridTextBoxColumn1
        '
        DataGridTextBoxColumn1.Format = ""
        DataGridTextBoxColumn1.FormatInfo = Nothing
        DataGridTextBoxColumn1.MappingName = "carnet"
        DataGridTextBoxColumn1.ReadOnly = True
        DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        DataGridTextBoxColumn2.Format = ""
        DataGridTextBoxColumn2.FormatInfo = Nothing
        DataGridTextBoxColumn2.MappingName = "nombre"
        DataGridTextBoxColumn2.ReadOnly = True
        DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        DataGridTextBoxColumn3.Format = ""
        DataGridTextBoxColumn3.FormatInfo = Nothing
        DataGridTextBoxColumn3.MappingName = "apellido1"
        DataGridTextBoxColumn3.ReadOnly = True
        DataGridTextBoxColumn3.Width = 110
        '
        'DataGridTextBoxColumn4
        '
        DataGridTextBoxColumn4.Format = ""
        DataGridTextBoxColumn4.FormatInfo = Nothing
        DataGridTextBoxColumn4.MappingName = "apellido2"
        DataGridTextBoxColumn4.ReadOnly = True
        DataGridTextBoxColumn4.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        DataGridTextBoxColumn5.Format = "f2"
        DataGridTextBoxColumn5.FormatInfo = Nothing
        DataGridTextBoxColumn5.MappingName = "nota"
        DataGridTextBoxColumn5.Width = 45
        '
        'DataView1
        '
        DataView1.Table = DsNotas1.materia
        '
        'DataView2
        '
        DataView2.Table = DsNotas1.profesores_cursos
        '
        'ButtonItem2
        '
        ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        ButtonItem2.Name = "ButtonItem2"
        ButtonItem2.Text = "Guardar"
        '
        'Bar1
        '
        Bar1.AntiAlias = True
        Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {ButtonItem2, LabelItem1})
        Bar1.Location = New System.Drawing.Point(259, 0)
        Bar1.Name = "Bar1"
        Bar1.Size = New System.Drawing.Size(475, 25)
        Bar1.Stretch = True
        Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Bar1.TabIndex = 10
        Bar1.TabStop = False
        Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        LabelItem1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelItem1.ForeColor = System.Drawing.Color.Black
        LabelItem1.Name = "LabelItem1"
        LabelItem1.Text = "     "
        '
        'TreeViewSQL1
        '
        TreeViewSQL1.BackColor = System.Drawing.SystemColors.ControlLightLight
        TreeViewSQL1.BorderStyle = System.Windows.Forms.BorderStyle.None
        TreeViewSQL1.ContextMenu = ContextMenu1
        TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Left
        TreeViewSQL1.Etiquetas = ",Año ,Periodo ,Nivel ,Grupo "
        TreeViewSQL1.FullRowSelect = True
        TreeViewSQL1.ImageIndex = 0
        TreeViewSQL1.ImageList = ImageList1
        TreeViewSQL1.InstruccionSQL = tree
        TreeViewSQL1.Location = New System.Drawing.Point(0, 0)
        TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.Name = ""
        TreeNode1.Text = "Notas"
        TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        TreeViewSQL1.SelectedImageIndex = 6
        TreeViewSQL1.Size = New System.Drawing.Size(256, 511)
        TreeViewSQL1.TabIndex = 4
        '
        'frmRegistraNotas
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(734, 511)
        Controls.Add(Bar1)
        Controls.Add(DataGrid1)
        Controls.Add(Splitter1)
        Controls.Add(TreeViewSQL1)
        DoubleBuffered = True
        MaximizeBox = False
        MaximumSize = New System.Drawing.Size(800, 700)
        MinimumSize = New System.Drawing.Size(650, 499)
        Name = "frmRegistraNotas"
        Text = "Registra Notas"
        CType(DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DsNotas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region
    Dim conn As New conexionSQL
    Protected Friend WithEvents txtbox5 As New TextBox
    Dim partes As String()
    Dim asigno As Boolean = False       ' bandera para controlar si asigno profesor y actualizar lista
    Private mHiloArch As Thread
    Dim oVentana As New Ventanas

    Private Sub frmRegistraNotas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TreeViewSQL1.BackColor = BackColor
    End Sub
    Private Sub frmRegistraNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BackgroundWorker1.RunWorkerAsync() 'Carga Datos en un Hilo 
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            SqlConnection1.ConnectionString = conn.strConn
            SqlConnection2.ConnectionString = conn.strConn

            SqlDataAdapter3.Fill(DsNotas1, "profesores_cursos")
            SqlDataAdapter1.SelectCommand = SqlCommand1
            SqlDataAdapter2.Fill(DsNotas1, "materia")

            Dim conn2 As New conexionSQL
            conn2.bd = "planilla"

            SqlConnection3.ConnectionString = conn2.strConn
            SqlDataAdapter4.Fill(DsNotas1, "empleados")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        TreeViewSQL1.llenar("colegio")

        DataGridTextBoxColumn5.TextBox.BackColor = Color.Red
        ' txtbox5 = DataGridTextBoxColumn5.TextBox
        TreeViewSQL1.Nodes(0).Expand()
        TreeViewSQL1.Nodes(0).Nodes(0).Expand()
    End Sub

    Private Sub TreeViewSQL1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSQL1.AfterSelect
        partes = TreeViewSQL1.ruta(e.Node.FullPath)

        If partes.Length = 6 Then
            DataView1.RowFilter = "nombre = '" & partes(5) & "'"
            partes(5) = DataView1(0)("materia")

            actualiza_lista()
        End If
    End Sub

    Sub actualiza_lista()
        DsNotas1.Tables("notas").Clear()

        If asigno Then
            DsNotas1.Tables("profesores_cursos").Clear()
            SqlDataAdapter3.Fill(DsNotas1, "profesores_cursos")
            asigno = False
        End If

        If partes.Length = 6 Then

            Dim filtro As String = "ano = '" & partes(1) & "' and periodo = '" & partes(2) &
                                "' and nivel = '" & partes(3) & "' and grupo = '" & partes(4) &
                                "' and materia = '" & partes(5) & "'"

            DataView2.RowFilter() = filtro                  ' Muestra Nombre de Profesor
            LabelItem1.Text = "Prof :"
            If DataView2.Count > 0 Then
                If Not (DataView2(0)("cedula") Is DBNull.Value) Then
                    Dim empleado As Object = DsNotas1.Tables("empleados").Rows.Find(DataView2(0)("cedula"))
                    LabelItem1.Text = "Prof :" & empleado("Nombre") & " " & empleado("apellidos")
                End If
            End If

            ' Carga Lista de Alumnos
            SqlDataAdapter1.SelectCommand.Parameters("@ano").Value = partes(1)
            SqlDataAdapter1.SelectCommand.Parameters("@periodo").Value = partes(2)
            SqlDataAdapter1.SelectCommand.Parameters("@nivel").Value = partes(3)
            SqlDataAdapter1.SelectCommand.Parameters("@grupo").Value = partes(4)
            SqlDataAdapter1.SelectCommand.Parameters("@materia").Value = partes(5)
            SqlDataAdapter1.Fill(DsNotas1, "notas")
        End If
    End Sub
    Private Sub DataGrid1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DataGrid1.Validating
        If DataGrid1.CurrentCell.ColumnNumber = 4 Then
            Dim valor As Integer = DataGrid1.Item(DataGrid1.CurrentCell)

            If Not ((valor >= 0) And (valor <= 100)) Then
                MessageBox.Show("Digite un valor entre 0 y 100")
            End If
        End If
    End Sub
    Private Sub ButtonItem1_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingContext(DsNotas1, "notas").EndCurrentEdit()
        SqlDataAdapter1.Update(DsNotas1.Tables("notas"))
    End Sub
    Private Sub ContextMenu1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup
        MenuItem1.Visible = False
        MenuItem2.Visible = False
        MenuItem3.Visible = False
        MenuItem4.Visible = False

        Select Case partes.Length
            Case Is = 2
                MenuItem2.Visible = True
            Case Is = 3
                MenuItem4.Visible = True
            Case Is = 5
                MenuItem1.Visible = True
            Case Is = 6
                MenuItem3.Visible = True
        End Select

    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim disco As frmDiskette = New frmDiskette
        disco.crear_grupo(partes)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim t As TreeNode = TreeViewSQL1.SelectedNode
        Dim partes As String() = TreeViewSQL1.ruta(t.FullPath)

        Dim oImprimir As New Reportes
        Dim rep As New rptNotas

        oImprimir.inserta_parametro(rep, "@ano", partes(1))
        rep.SummaryInfo.ReportComments = " Reporte Académico "

        oImprimir.imprimir(rep, False, ParentForm)
    End Sub


    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Try
            oVentana.cargarVentana(New frmAsignaProfesor(partes), ParentForm)
            asigno = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim t As TreeNode = TreeViewSQL1.SelectedNode
        Dim partes As String() = TreeViewSQL1.ruta(t.FullPath)

        Dim oImprimir As New Reportes
        Dim rep As New rptProfesoresMateria

        oImprimir.inserta_parametro(rep, "@ano", partes(1))
        oImprimir.inserta_parametro(rep, "@periodo", partes(2))
        rep.SummaryInfo.ReportComments = " Lista de Profesores por Nivel "

        oImprimir.imprimir(rep, False, ParentForm)
    End Sub

    Private Sub TreeViewSQL1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeViewSQL1.GotFocus
        If asigno Then
            actualiza_lista()
        End If
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        BindingContext(DsNotas1, "notas").EndCurrentEdit()
        SqlDataAdapter1.Update(DsNotas1.Tables("notas"))
    End Sub


End Class
