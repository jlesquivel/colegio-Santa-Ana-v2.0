Public Class frmCategoria
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents XpTaskPanel1 As SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPlanilla1 As colegio.dsPlanilla
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents MonedaTextBox1 As colegio.MonedaTextBox
    Friend WithEvents MonedaTextBox2 As colegio.MonedaTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XpTaskPanel1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DsPlanilla1 = New colegio.dsPlanilla
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.UserControl21 = New colegio.UserControl2
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MonedaTextBox1 = New colegio.MonedaTextBox
        Me.MonedaTextBox2 = New colegio.MonedaTextBox
        Me.XpTaskPanel1.SuspendLayout()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XpTaskPanel1
        '
        Me.XpTaskPanel1.AutoScroll = True
        Me.XpTaskPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskPanel1.Controls.Add(Me.ComboBox1)
        Me.XpTaskPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.XpTaskPanel1.DockPadding.Bottom = 8
        Me.XpTaskPanel1.DockPadding.Left = 8
        Me.XpTaskPanel1.DockPadding.Right = 8
        Me.XpTaskPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpTaskPanel1.Name = "XpTaskPanel1"
        Me.XpTaskPanel1.Size = New System.Drawing.Size(136, 176)
        Me.XpTaskPanel1.TabIndex = 0
        Me.XpTaskPanel1.ThemeFormat.BottomColor = System.Drawing.Color.FromArgb(CType(40, Byte), CType(91, Byte), CType(197, Byte))
        Me.XpTaskPanel1.ThemeFormat.TopColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DsPlanilla1.categorias
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.Location = New System.Drawing.Point(8, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 168)
        Me.ComboBox1.TabIndex = 1
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
        "_BD;persist security info=False;initial catalog=planilla"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "categorias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_cat", "id_cat"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("salario_base", "salario_base"), New System.Data.Common.DataColumnMapping("anualidad", "anualidad")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.categorias WHERE (id_cat = @Original_id_cat) AND (anualidad = @Or" & _
        "iginal_anualidad) AND (nombre = @Original_nombre) AND (salario_base = @Original_" & _
        "salario_base)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cat", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anualidad", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_salario_base", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "salario_base", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.categorias(nombre, salario_base, anualidad) VALUES (@nombre, @sal" & _
        "ario_base, @anualidad); SELECT id_cat, nombre, salario_base, anualidad FROM dbo." & _
        "categorias WHERE (id_cat = @@IDENTITY) ORDER BY nombre"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 8, "salario_base"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 8, "anualidad"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_cat, nombre, salario_base, anualidad FROM dbo.categorias ORDER BY nombr" & _
        "e"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.categorias SET nombre = @nombre, salario_base = @salario_base, anualid" & _
        "ad = @anualidad WHERE (id_cat = @Original_id_cat) AND (anualidad = @Original_anu" & _
        "alidad) AND (nombre = @Original_nombre) AND (salario_base = @Original_salario_ba" & _
        "se); SELECT id_cat, nombre, salario_base, anualidad FROM dbo.categorias WHERE (i" & _
        "d_cat = @id_cat) ORDER BY nombre"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 8, "salario_base"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 8, "anualidad"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cat", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anualidad", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_salario_base", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "salario_base", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_cat", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Current, Nothing))
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(136, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(266, 32)
        Me.UserControl21.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "categorias.nombre"))
        Me.TextBox1.Location = New System.Drawing.Point(256, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Salario Base"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(152, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Anualidad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "categorias.salario_base"))
        Me.MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox1.Location = New System.Drawing.Point(256, 96)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.TabIndex = 8
        Me.MonedaTextBox1.Text = "¢0,00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MonedaTextBox2
        '
        Me.MonedaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "categorias.anualidad"))
        Me.MonedaTextBox2.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox2.Location = New System.Drawing.Point(256, 128)
        Me.MonedaTextBox2.Name = "MonedaTextBox2"
        Me.MonedaTextBox2.TabIndex = 9
        Me.MonedaTextBox2.Text = "¢0,00"
        Me.MonedaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCategoria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(402, 176)
        Me.Controls.Add(Me.MonedaTextBox2)
        Me.Controls.Add(Me.MonedaTextBox1)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.XpTaskPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCategoria"
        Me.Text = "Categorias"
        Me.XpTaskPanel1.ResumeLayout(False)
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim bd As String = "categorias"

    Private Sub frmCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim conn As New conexionSQL
            conn.bd = "planilla"
            Me.SqlConnection1.ConnectionString = conn.strConn
            Me.SqlDataAdapter1.Fill(DsPlanilla1, Me.bd)

            Me.UserControl21.ButtonItem4.Visible = False
            Me.UserControl21.ButtonItem5.Visible = False
            Me.UserControl21.ButtonItem6.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Public Sub nuevo()
        Try
            TextBox1.Focus()
            'Borrar las ediciones actuales
            Me.BindingContext(DsPlanilla1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsPlanilla1, Me.bd).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub guardar()
        Try
            Me.BindingContext(DsPlanilla1, Me.bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsPlanilla1, Me.bd)
            DsPlanilla1.AcceptChanges()
            Me.SqlDataAdapter1.Fill(DsPlanilla1, Me.bd)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales
            Dim Registro As Integer
            Registro = Me.BindingContext(DsPlanilla1, Me.bd).Position
            Me.BindingContext(DsPlanilla1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsPlanilla1, Me.bd).RemoveAt(Registro)
            Me.SqlDataAdapter1.Update(DsPlanilla1, Me.bd)
            Me.BindingContext(DsPlanilla1, Me.bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.BindingContext(DsPlanilla1, Me.bd).Position = ComboBox1.SelectedIndex
        Me.BindingContext(DsPlanilla1, Me.bd).EndCurrentEdit()
    End Sub
End Class
