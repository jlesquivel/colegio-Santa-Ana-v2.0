Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.Drawing

Public Class frmDiskette
     Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim conn As New conexionSQL
    Dim aPartes As String()
    Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Dim ultima As Integer

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsDisco1 As colegio.dsDisco
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ActualizaNota As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection4 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlConnection5 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlConnection6 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiskette))
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection5 = New System.Data.SqlClient.SqlConnection()
        Me.SqlConnection6 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ActualizaNota = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection4 = New System.Data.SqlClient.SqlConnection()
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.DsDisco1 = New colegio.dsDisco()
        Me.DataView1 = New System.Data.DataView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDisco1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 304)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(144, 16)
        Me.ProgressBar2.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 282)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(144, 16)
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBox1.Location = New System.Drawing.Point(90, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LinkLabel3.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(170, 22)
        Me.LinkLabel3.TabIndex = 0
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Cambiar Ruta archivos"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LinkLabel2.Location = New System.Drawing.Point(0, 22)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(170, 23)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cargar Archivo Notas"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo Excel ( *.xls) |*.xls"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 336)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(603, 22)
        Me.StatusBar1.TabIndex = 3
        Me.StatusBar1.TabStop = True
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 500
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
    "_BD;persist security info=False;initial catalog=colegio"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "matricula", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection5
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo")})
        '
        'SqlConnection5
        '
        Me.SqlConnection5.ConnectionString = "workstation id=""EG-ZE5547WM"";packet size=4096;integrated security=SSPI;data sourc" & _
    "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        Me.SqlConnection5.FireInfoMessageEventOnUserErrors = False
        '
        'SqlConnection6
        '
        Me.SqlConnection6.ConnectionString = "workstation id=""EG-ZE5547WM"";packet size=4096;integrated security=SSPI;data sourc" & _
    "e=""EG-ZE5547WM"";persist security info=False;initial catalog=colegio"
        Me.SqlConnection6.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materias_nivel", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT materias_nivel.nivel, materia.nombre, materia.materia AS Expr1 FROM materi" & _
    "as_nivel INNER JOIN materia ON materias_nivel.materia = materia.materia WHERE (m" & _
    "aterias_nivel.nivel = @nivel)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel")})
        '
        'ActualizaNota
        '
        Me.ActualizaNota.CommandText = "UPDATE notas SET nota = @nota, profesora = @prof WHERE (id_mat = @id_mat) AND (pe" & _
    "riodo = @periodo) AND (materia = @materia)"
        Me.ActualizaNota.Connection = Me.SqlConnection1
        Me.ActualizaNota.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Money, 4, "nota"), New System.Data.SqlClient.SqlParameter("@prof", System.Data.SqlDbType.VarChar, 15, "profesora"), New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;user id=jose;data source=servidor_b" & _
    "d;persist security info=False;initial catalog=colegio"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("periodo", "periodo"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("materia", "materia")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection5
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, "periodo"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano")})
        '
        'SqlConnection4
        '
        Me.SqlConnection4.ConnectionString = "workstation id=""EG-ZE5547WM"";packet size=4096;integrated security=SSPI;data sourc" & _
    "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        Me.SqlConnection4.FireInfoMessageEventOnUserErrors = False
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;user id=jose;data source=SERVIDOR_B" & _
    "D;persist security info=False;initial catalog=planilla"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_categoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ingreso", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_direccion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_anualidadReconocida", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.SqlConnection3
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 0, "apellidos"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 0, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 0, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 0, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 0, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 0, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 0, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 0, "anualidadReconocida")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 0, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 0, "apellidos"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 0, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 0, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 0, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 0, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 0, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 0, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 0, "anualidadReconocida"), New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_categoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ingreso", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_direccion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_anualidadReconocida", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBox1.Location = New System.Drawing.Point(170, 0)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(433, 336)
        Me.CheckedListBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(170, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(433, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar Archivo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        '
        'DsDisco1
        '
        Me.DsDisco1.DataSetName = "dsDisco"
        Me.DsDisco1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsDisco1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsDisco1.empleados
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBar2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 336)
        Me.Panel1.TabIndex = 0
        '
        'frmDiskette
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(603, 358)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusBar1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiskette"
        Me.Text = "Crea y Carga Archivo Excel"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDisco1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim m_excel As New Excel.Application
    Dim fechaInicioProceso As Date = DateTime.Now()

    Dim datos As System.Object

    Dim objLibroExcel As Excel.Workbook
    Dim objHojaExcel As Excel.Worksheet

    Dim archBase As String = My.Application.Info.DirectoryPath & "\baseNotas.xls"
    Dim hojas As Excel.Sheets

    Private Sub frmDiskette_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlConnection2.ConnectionString = conn.strConn
        Me.SqlConnection5.ConnectionString = conn.strConn

        Dim conn2 As New conexionSQL                    ' llena la tabla empleados
        conn2.bd = "planilla"
        Me.SqlConnection3.ConnectionString = conn2.strConn
        Me.SqlDataAdapter4.Fill(DsDisco1, "empleados")

        Me.ComboBox1.SelectedIndex = 0

        Dim carga As CargarLista = New CargarLista
        carga.DatosLista(DsDisco1.Tables("empleados"), Me.CheckedListBox1, "id_emp", "nombre")

        Me.StatusBar1.Panels(0).Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
    End Sub
    Private Sub frmDiskette_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Marshal.ReleaseComObject(m_excel)
        m_excel = Nothing

    End Sub
    Public Sub crear_grupo(ByVal paPartes As String())
        'Me.OpenFileDialog1.ShowDialog()
        aPartes = paPartes
        archBase = My.Application.Info.DirectoryPath & "\baseNotas.xls"

        objLibroExcel = m_excel.Workbooks.Open(archBase)
        objHojaExcel = objLibroExcel.Worksheets(1)

        llena_hoja(objHojaExcel, aPartes)
        crea_copias(objHojaExcel, aPartes(3))

        For Each hoja As Excel.Worksheet In objLibroExcel.Worksheets
            hoja.Name = hoja.Range("C3").Value
            hoja.Protect()
            hoja.Visible = Excel.XlSheetVisibility.xlSheetVisible
        Next

        hojas = objLibroExcel.Worksheets

        m_excel.DisplayAlerts = False
        hojas("hoja").delete()
        hojas("Tard�as").delete()
        hojas("Ausencias Motivadas").delete()
        hojas("Ausencias Inmotivadas").delete()
        m_excel.DisplayAlerts = True

        hojas(1).select()

        objLibroExcel.SaveAs(Me.StatusBar1.Panels(0).Text & "\" & aPartes(3) & "-" & aPartes(4) & " Trim " & aPartes(2) & " " & aPartes(1) & ".xls")
        objLibroExcel.Close()

    End Sub

    Sub crea_profesor(ByVal pid_emp As Integer, ByVal _periodo As String, ByVal _ano As Integer)
        ReDim aPartes(5)
        objLibroExcel = m_excel.Workbooks.Open(archBase)
        Dim fila, empleado As DataRow

        Me.DsDisco1.Tables("profesores_cursos").Clear()
        Me.SqlDataAdapter3.SelectCommand.Parameters.Item("@id_emp").Value = pid_emp
        Me.SqlDataAdapter3.SelectCommand.Parameters.Item("@periodo").Value = _periodo
        Me.SqlDataAdapter3.SelectCommand.Parameters.Item("@ano").Value = _ano
        Me.SqlDataAdapter3.Fill(Me.DsDisco1, "profesores_cursos")

        empleado = DsDisco1.Tables("empleados").Rows.Find(pid_emp) 'carga el profesor

        Dim paso As Integer = 100 / DsDisco1.Tables("profesores_cursos").Rows.Count
        Dim contador As Integer = 0

        For Each fila In DsDisco1.Tables("profesores_cursos").Rows
            aPartes(1) = fila.Item("ano")       'ano
            aPartes(2) = fila.Item("periodo")   'periodo
            aPartes(3) = fila.Item("nivel")     'nivel
            aPartes(4) = fila.Item("grupo")     'grupo

            objHojaExcel = objLibroExcel.Worksheets("hoja1")
            objHojaExcel.Copy(objHojaExcel)                      'copia Hoja
            objHojaExcel = objLibroExcel.Worksheets("Hoja1 (2)") 'ultima hoja creada

            objHojaExcel.Name = fila.Item("Nombre") & " " & fila.Item("nivel") & "-" & fila.Item("grupo")

            objHojaExcel.Range("A2").Value = pid_emp
            objHojaExcel.Range("C2").Value = empleado.Item("nombre")

            objHojaExcel.Range("A3").Value = aPartes(2)
            objHojaExcel.Range("B3").Value = fila.Item("materia")
            objHojaExcel.Range("C3").Value = fila.Item("nombre")
            objHojaExcel.Range("C1").Value = " Per�odo " & ConvertirRomano(CInt(aPartes(2))) & " - " & aPartes(1)

            llena_hoja(objHojaExcel, aPartes)

            'If CInt(aPartes(3)) > 6 Then      ' oculta columna de asistencia para secundaria
            '    objHojaExcel.Range("K:K").EntireColumn.Hidden = True
            'End If

            objHojaExcel.Range("D7").Select()

            objHojaExcel.Protect()
            contador += paso
            BackgroundWorker1.ReportProgress(contador)
        Next

        hojas = objLibroExcel.Worksheets
        If hojas.Count > 1 Then

            m_excel.DisplayAlerts = False
            hojas("hoja1").delete()
            m_excel.DisplayAlerts = True

            objHojaExcel.Protect()
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible

            hojas = objLibroExcel.Worksheets
            hojas(1).select()
            objLibroExcel.Protect("123", True, False)
            objLibroExcel.SaveAs(Me.StatusBar1.Panels(0).Text & "\" & empleado.Item("nombre") & ".xls")

        End If

        objLibroExcel.Close()

    End Sub

    Sub llena_hoja(ByRef _hoja As Object, ByVal part As String())

        Dim hoja As Excel.Worksheet = _hoja
        Dim anno As String = part(1)
        Dim periodo As String = part(2)
        Dim nivel As String = part(3)
        Dim grupo As String = part(4)

        Me.DsDisco1.Tables("matricula").Clear()
        Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@anno").Value = anno
        Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@nivel").Value = nivel
        Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@grupo").Value = grupo

        Me.SqlDataAdapter1.Fill(DsDisco1, "matricula")

        Dim conta As Integer = 7
        Dim ccp, cnp, cid_mat As String

        For Each estud As DataRow In DsDisco1.Tables("matricula").Rows
            ccp = "B" & conta  'posicion de la columna en hoja excel
            cnp = "C" & conta ' 
            cid_mat = "M" & conta

            hoja.Range(cid_mat).Value = estud.Item("id_mat")
            hoja.Range(ccp).Value = estud.Item("carnet")
            hoja.Range(cnp).Value = estud.Item("apellido1") & " " & estud.Item("apellido2") & " " & estud.Item("Nombre")
            conta += 1
        Next

        hoja.PageSetup.PrintArea = "$A$1:$L$" & conta
    End Sub

    Sub crea_copias(ByVal _objHojaExcel As Object, ByVal nivel As String)

        Dim objHojaExcel As Excel.Worksheet = _objHojaExcel
        Me.DsDisco1.Tables("materias_nivel").Clear()
        Me.SqlDataAdapter2.SelectCommand.Parameters.Item("@nivel").Value = nivel
        Me.SqlDataAdapter2.Fill(DsDisco1, "materias_nivel")

        For Each regis As DataRow In DsDisco1.Tables("materias_nivel").Rows
            objHojaExcel.Name = regis.Item("Nombre")

            objHojaExcel.Range("A3").Value = aPartes(2)
            objHojaExcel.Range("B3").Value = regis.Item("Expr1")
            objHojaExcel.Range("C3").Value = regis.Item("nombre")


            objHojaExcel.Copy(objHojaExcel)
        Next
        objHojaExcel.Name = "hoja"
        objHojaExcel.Range("C3").Value = "hoja"

        ultima = objHojaExcel.Index
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.FolderBrowserDialog1.ShowDialog()
        Me.StatusBar1.Panels(0).Text = Me.FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackgroundWorker2.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        cargar_archivoBD()
    End Sub
    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Sub cargar_archivoBD()
        Try
            Dim arch As String = Me.OpenFileDialog1.FileName
            Dim rutaActual As String = Environment.CurrentDirectory
            Dim objLibroExcel As Excel.Workbook

            Dim conta As Integer = 7

            Dim vid_mat As Integer
            Dim vnota As Decimal

            Dim vPeriodo, vmateria, vProf As String
            Me.SqlConnection1.Open()
            objLibroExcel = m_excel.Workbooks.Open(arch)

            Dim paso1 As Integer = 100 / objLibroExcel.Worksheets.Count
            Dim contador1 As Integer = 0

            For Each hoja As Excel.Worksheet In objLibroExcel.Worksheets
                conta = 7
                hoja.Select()

                vmateria = hoja.Range("B3").Text
                vPeriodo = hoja.Range("A3").Text
                vProf = hoja.Range("A2").Text

                While (hoja.Range("C" & conta).Value() <> "")

                    vnota = m_excel.Evaluate(hoja.Range("L" & conta).Formula)
                    vid_mat = hoja.Range("M" & conta).Value()

                    Me.ActualizaNota.Parameters("@id_mat").Value = vid_mat
                    Me.ActualizaNota.Parameters("@periodo").Value = vPeriodo
                    Me.ActualizaNota.Parameters("@materia").Value = vmateria

                    Me.ActualizaNota.Parameters("@nota").Value = vnota
                    Me.ActualizaNota.Parameters("@prof").Value = vProf

                    If vnota > 0 Then
                        Me.ActualizaNota.ExecuteNonQuery()   'Actualiza en BD
                    End If
                    conta = conta + 1
                End While

                contador1 += paso1
                BackgroundWorker2.ReportProgress(contador1)
            Next
            Me.SqlConnection1.Close()
            objLibroExcel.Close()
            Environment.CurrentDirectory = rutaActual
            MessageBox.Show("Archivo se cargo satisfactoriamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckedListBox1.CheckedItems.Count > 0 Then
            Me.BackgroundWorker1.RunWorkerAsync(ComboBox1.Text)
        Else
            MessageBox.Show(" Seleccione un profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        crea_disco(e.Argument)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If e.ProgressPercentage > 100 Then
            ProgressBar1.Value = e.ProgressPercentage - 100
        Else
            ProgressBar2.Value = e.ProgressPercentage
        End If
    End Sub

    Private Sub crea_disco(ByVal pPeriodo As Object)
        Dim selec As Object
        Dim paso1 As Integer = 100 / CheckedListBox1.CheckedItems.Count
        Dim contador1 As Integer = 0


        For Each selec In CheckedListBox1.CheckedItems
            Me.crea_profesor(selec.codigo, pPeriodo, Now.Year)
            contador1 += paso1
            BackgroundWorker1.ReportProgress(contador1 + 100)
            actualizar_PB1()
        Next
    End Sub

    Private Sub actualizar_PB1()
        Dim myString As String = ((Me.ProgressBar1.Value * 100) \ Me.ProgressBar1.Maximum).ToString() & "%"
        Dim canvas As Graphics = Me.ProgressBar1.CreateGraphics
        Dim x As Integer = (Me.ProgressBar1.Width / 2) - (myString.Length * 4)
        Dim y As Integer = (Me.ProgressBar1.Height / 2) - 7
        Dim fuente As Font = New System.Drawing.Font("Verdana", 8, FontStyle.Bold)

        canvas.DrawString(myString, fuente, Brushes.Black, x, y)
        canvas.Dispose()
    End Sub

    Function ConvertirArabe(ByVal ROMANO As String) As Double
        Dim M As Integer
        Dim k As Integer
        Dim I As Integer
        Dim MiDigito As Integer
        Dim ArabeTmp As Double
        Dim VecAra() As String
        ReDim VecAra(9)
        Dim Vec() As String
        ReDim Vec(9)
        Dim Origen As String
        Origen = ROMANO
        Vec(0) = "I"
        Vec(1) = "V"
        Vec(2) = "X"
        Vec(3) = "L"
        Vec(4) = "C"
        Vec(5) = "D"
        Vec(6) = "M"
        Vec(7) = "Q"
        Vec(8) = "H"
        VecAra(0) = "1"
        VecAra(1) = "5"
        VecAra(2) = "10"
        VecAra(3) = "50"
        VecAra(4) = "100"
        VecAra(5) = "500"
        VecAra(6) = "1000"
        VecAra(7) = "5000"
        VecAra(8) = "10000"
        VecAra(9) = "0"
        ArabeTmp = 0
        MiDigito = 9
        For k = 0 To Len(Origen)
            For I = 0 To 8
                M = InStr(1, ROMANO, Vec(I))
                If M = 1 Then
                    If MiDigito >= I Then
                        ArabeTmp = ArabeTmp + VecAra(I)
                        ROMANO = Microsoft.VisualBasic.Right(ROMANO, Len(ROMANO) - 1)
                        MiDigito = I
                    Else
                        ArabeTmp = ArabeTmp + VecAra(I) - 2 * VecAra(MiDigito)
                        ROMANO = Microsoft.VisualBasic.Right(ROMANO, Len(ROMANO) - 1)
                        MiDigito = I
                    End If
                End If
            Next
        Next
        ConvertirArabe = ArabeTmp

    End Function
    Function ConvertirRomano(ByVal Numero As Integer) As String
        Dim ROMANO As String = ""
        Dim I As Integer, Digito As Integer, X As Integer
        Dim Cadena As String = "", CadenaTmp As String = ""
        Dim Simbolo1 As String = ""
        Dim Simbolo2 As String = ""
        Dim Simbolo3 As String = ""

        Cadena = CStr(Numero)
        For X = 1 To Len(Cadena)
            If Len(Cadena) = 4 Then
                Simbolo1 = "M"
                Simbolo2 = "Q"
                Simbolo3 = "H"
                Digito = CInt(Microsoft.VisualBasic.Left(Cadena, 1))
                Cadena = Microsoft.VisualBasic.Right(Cadena, 3)
            ElseIf Len(Cadena) = 3 Then
                Simbolo1 = "C"
                Simbolo2 = "D"
                Simbolo3 = "M"
                Digito = CInt(Microsoft.VisualBasic.Left(Cadena, 1))
                Cadena = Microsoft.VisualBasic.Right(Cadena, 2)
            ElseIf Len(Cadena) = 2 Then
                Simbolo1 = "X"
                Simbolo2 = "L"
                Simbolo3 = "C"
                Digito = CInt(Microsoft.VisualBasic.Left(Cadena, 1))
                Cadena = Microsoft.VisualBasic.Right(Cadena, 1)
            ElseIf Len(Cadena) = 1 Then
                Simbolo1 = "I"
                Simbolo2 = "V"
                Simbolo3 = "X"
                Digito = CInt(Microsoft.VisualBasic.Left(Cadena, 1))
                Cadena = ""
            End If
            If Digito <= 3 Then
                For I = 1 To Digito
                    CadenaTmp = CadenaTmp & Simbolo1
                Next I
            ElseIf Digito < 5 Then
                CadenaTmp = Simbolo1 & Simbolo2
            ElseIf Digito = 5 Then
                CadenaTmp = Simbolo2
            ElseIf Digito <= 8 Then
                CadenaTmp = Simbolo2
                For I = 1 To Digito - 5
                    CadenaTmp = CadenaTmp & Simbolo1
                Next I
            ElseIf Digito = 9 Then
                CadenaTmp = Simbolo1 & Simbolo3
            End If
            ROMANO = ROMANO & CadenaTmp
            CadenaTmp = ""
        Next X
        ConvertirRomano = ROMANO
    End Function

End Class

