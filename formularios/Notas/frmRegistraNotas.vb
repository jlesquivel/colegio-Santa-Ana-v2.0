Imports System.Data.SqlClient
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistraNotas))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notas")
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tree = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DsNotas1 = New colegio.dsNotas()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataView1 = New System.Data.DataView()
        Me.DataView2 = New System.Data.DataView()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.TreeViewSQL1 = New colegio.TreeViewSQL()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(256, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 511)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Crea/Carga Disco"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Reporte Notas"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Asigna Profesor"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Lista Profesores"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1-tray.gif")
        Me.ImageList1.Images.SetKeyName(1, "2-calendar.gif")
        Me.ImageList1.Images.SetKeyName(2, "3-list.gif")
        Me.ImageList1.Images.SetKeyName(3, "4-list.gif")
        Me.ImageList1.Images.SetKeyName(4, "5-notes.gif")
        Me.ImageList1.Images.SetKeyName(5, "6-users.gif")
        Me.ImageList1.Images.SetKeyName(6, "")
        '
        'tree
        '
        Me.tree.CommandText = "SELECT      ano, periodo, nivel, grupo, nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          grupo_periodo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDE" & _
    "R BY ano DESC, periodo, nivel, grupo, materia"
        Me.tree.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;User ID=sa"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nota", "nota"), New System.Data.Common.DataColumnMapping("id", "id")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM notas WHERE (id = @Original_id) AND (nota = @Original_nota OR @Origin" & _
    "al_nota IS NULL AND nota IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Money, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO notas(nota) VALUES (@nota); SELECT nota, id FROM notas WHERE (id = @@" & _
    "IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Money, 4, "nota")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT nota, id FROM notas"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE notas SET nota = @nota WHERE (id = @Original_id) AND (nota = @Original_not" & _
    "a OR @Original_nota IS NULL AND nota IS NULL); SELECT nota, id FROM notas WHERE " & _
    "(id = @id)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Money, 4, "nota"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Money, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.VarBinary, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_nota", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_profesora", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "profesora", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO notas(nota, id, profesora, fecha_nota) VALUES (@nota, @id, @profesora" & _
    ", @fecha_nota); SELECT nota, id, profesora, fecha_nota FROM notas WHERE (id = @i" & _
    "d)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Int, 4, "nota"), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.VarBinary, 8, "id"), New System.Data.SqlClient.SqlParameter("@profesora", System.Data.SqlDbType.VarChar, 15, "profesora"), New System.Data.SqlClient.SqlParameter("@fecha_nota", System.Data.SqlDbType.DateTime, 8, "fecha_nota")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT nota, id, profesora, fecha_nota FROM notas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Int, 4, "nota"), New System.Data.SqlClient.SqlParameter("@profesora", System.Data.SqlDbType.VarChar, 15, "profesora"), New System.Data.SqlClient.SqlParameter("@fecha_nota", System.Data.SqlDbType.DateTime, 8, "fecha_nota"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.VarBinary, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_nota", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nota", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nota", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_profesora", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "profesora", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.VarBinary, 8, "id")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT materia, nombre FROM materia"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO materia(materia, nombre) VALUES (@materia, @nombre); SELECT materia, " & _
    "nombre FROM materia WHERE (materia = @materia)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM materia WHERE (materia = @Original_materia) AND (nombre = @Original_n" & _
    "ombre OR @Original_nombre IS NULL AND nombre IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, "periodo")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT      ano, periodo, nivel, grupo, materia, cedula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          profesores" & _
    "_cursos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY ano DESC"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;User ID=sa"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, "periodo"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "profesores_cursos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("periodo", "periodo"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo"), New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("cedula", "cedula")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id_emp, cedula, apellidos, nombre, categoria, nacimiento, cuenta, ingreso," & _
    " banco, direccion, telefono, celular, sexo, anualidadReconocida FROM dbo.emplead" & _
    "os"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection3
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;User ID=sa"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection3
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida"), New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand5
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand4
        '
        'BackgroundWorker1
        '
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DsNotas1.notas
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(259, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RowHeadersVisible = False
        Me.DataGrid1.Size = New System.Drawing.Size(475, 511)
        Me.DataGrid1.TabIndex = 3
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsNotas1
        '
        Me.DsNotas1.DataSetName = "dsNotas"
        Me.DsNotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsNotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridTableStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "notas"
        Me.DataGridTableStyle1.PreferredColumnWidth = 100
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "carnet"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "nombre"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "apellido1"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 110
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "apellido2"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "f2"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "nota"
        Me.DataGridTextBoxColumn5.Width = 45
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsNotas1.materia
        '
        'DataView2
        '
        Me.DataView2.Table = Me.DsNotas1.profesores_cursos
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Guardar"
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.LabelItem1})
        Me.Bar1.Location = New System.Drawing.Point(259, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(475, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 10
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItem1.ForeColor = System.Drawing.Color.Black
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "     "
        '
        'TreeViewSQL1
        '
        Me.TreeViewSQL1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TreeViewSQL1.ContextMenu = Me.ContextMenu1
        Me.TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeViewSQL1.Etiquetas = ",Año ,Periodo ,Nivel ,Grupo "
        Me.TreeViewSQL1.FullRowSelect = True
        Me.TreeViewSQL1.ImageIndex = 0
        Me.TreeViewSQL1.ImageList = Me.ImageList1
        Me.TreeViewSQL1.InstruccionSQL = Me.tree
        Me.TreeViewSQL1.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.Name = ""
        TreeNode1.Text = "Notas"
        Me.TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewSQL1.SelectedImageIndex = 6
        Me.TreeViewSQL1.Size = New System.Drawing.Size(256, 511)
        Me.TreeViewSQL1.TabIndex = 4
        '
        'frmRegistraNotas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.TreeViewSQL1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(650, 499)
        Me.Name = "frmRegistraNotas"
        Me.Text = "Registra Notas"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNotas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim conn As New conexionSQL
    Protected Friend WithEvents txtbox5 As New TextBox
    Dim partes As String()
    Dim asigno As Boolean = False       ' bandera para controlar si asigno profesor y actualizar lista
    Private mHiloArch As Thread
    Dim oVentana As New Ventanas


    Private Sub frmRegistraNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackgroundWorker1.RunWorkerAsync() 'Carga Datos en un Hilo 
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Me.SqlConnection1.ConnectionString = conn.strConn
            Me.SqlConnection2.ConnectionString = conn.strConn

            Me.SqlDataAdapter3.Fill(DsNotas1, "profesores_cursos")
            Me.SqlDataAdapter1.SelectCommand = Me.SqlCommand1
            Me.SqlDataAdapter2.Fill(DsNotas1, "materia")

            Dim conn2 As New conexionSQL
            conn2.bd = "planilla"

            Me.SqlConnection3.ConnectionString = conn2.strConn
            Me.SqlDataAdapter4.Fill(DsNotas1, "empleados")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.TreeViewSQL1.llenar("colegio")

        Me.DataGridTextBoxColumn5.TextBox.BackColor = Color.Red
        ' txtbox5 = DataGridTextBoxColumn5.TextBox
        TreeViewSQL1.Nodes(0).Expand()
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
            Me.SqlDataAdapter3.Fill(DsNotas1, "profesores_cursos")
            asigno = False
        End If

        If partes.Length = 6 Then

            Dim filtro As String = "ano = '" & partes(1) & "' and periodo = '" & partes(2) & _
                                "' and nivel = '" & partes(3) & "' and grupo = '" & partes(4) & _
                                "' and materia = '" & partes(5) & "'"

            DataView2.RowFilter() = filtro                  ' Muestra Nombre de Profesor
            Me.LabelItem1.Text = "Prof :"
            If DataView2.Count > 0 Then
                If Not (DataView2(0)("cedula") Is DBNull.Value) Then
                    Dim empleado As Object = DsNotas1.Tables("empleados").Rows.Find(DataView2(0)("cedula"))
                    Me.LabelItem1.Text = "Prof :" & empleado("Nombre") & " " & empleado("apellidos")
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
        Me.BindingContext(Me.DsNotas1, "notas").EndCurrentEdit()
        Me.SqlDataAdapter1.Update(DsNotas1.Tables("notas"))
    End Sub
    Private Sub ContextMenu1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup
        Me.MenuItem1.Visible = False
        Me.MenuItem2.Visible = False
        Me.MenuItem3.Visible = False
        Me.MenuItem4.Visible = False

        Select Case partes.Length
            Case Is = 2
                Me.MenuItem2.Visible = True
            Case Is = 3
                Me.MenuItem4.Visible = True
            Case Is = 5
                Me.MenuItem1.Visible = True
            Case Is = 6
                Me.MenuItem3.Visible = True
        End Select

    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim disco As frmDiskette = New frmDiskette
        disco.crear_grupo(partes)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim t As TreeNode = Me.TreeViewSQL1.SelectedNode
        Dim partes As String() = TreeViewSQL1.ruta(t.FullPath)

        Dim oImprimir As New Reportes
        Dim rep As New rptNotas

        oImprimir.inserta_parametro(rep, "@ano", partes(1))
        rep.SummaryInfo.ReportComments = " Reporte Académico "

        oImprimir.imprimir(rep, False, Me.ParentForm)
    End Sub


    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Try
            oVentana.cargarVentana(New frmAsignaProfesor(partes), Me.ParentForm)
            asigno = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim t As TreeNode = Me.TreeViewSQL1.SelectedNode
        Dim partes As String() = TreeViewSQL1.ruta(t.FullPath)

        Dim oImprimir As New Reportes
        Dim rep As New rptProfesoresMateria

        oImprimir.inserta_parametro(rep, "@ano", partes(1))
        oImprimir.inserta_parametro(rep, "@periodo", partes(2))
        rep.SummaryInfo.ReportComments = " Lista de Profesores por Nivel "

        oImprimir.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub TreeViewSQL1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeViewSQL1.GotFocus
        If asigno Then
            actualiza_lista()
        End If
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Me.BindingContext(Me.DsNotas1, "notas").EndCurrentEdit()
        Me.SqlDataAdapter1.Update(DsNotas1.Tables("notas"))
    End Sub
End Class
