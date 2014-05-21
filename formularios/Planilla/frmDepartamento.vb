Public Class frmDepartamento
    Inherits System.Windows.Forms.Form
    Dim departamento As String
    Dim borra As Boolean = False
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    Public Sub New(ByVal dpto As String, ByVal pborra As Boolean)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.departamento = dpto
        Me.borra = pborra
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsPlanilla1 As colegio.dsPlanilla
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataView1 = New System.Data.DataView
        Me.DsPlanilla1 = New colegio.dsPlanilla
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "nombre"))
        Me.TextBox1.Location = New System.Drawing.Point(104, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsPlanilla1.departamento
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "descripcion"))
        Me.TextBox2.Location = New System.Drawing.Point(104, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Planilla"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SERVIDOR_BD;packet size=4096;user id=marlene;data source=SERVIDOR_" & _
        "BD;persist security info=True;initial catalog=planilla;password=123"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "departamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_dpto", "id_dpto"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.departamento WHERE (id_dpto = @Original_id_dpto) AND (descripcion" & _
        " = @Original_descripcion OR @Original_descripcion IS NULL AND descripcion IS NUL" & _
        "L) AND (nombre = @Original_nombre)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.departamento(nombre, descripcion) VALUES (@nombre, @descripcion);" & _
        " SELECT id_dpto, nombre, descripcion FROM dbo.departamento WHERE (id_dpto = @@ID" & _
        "ENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 255, "descripcion"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_dpto, nombre, descripcion FROM dbo.departamento"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.departamento SET nombre = @nombre, descripcion = @descripcion WHERE (i" & _
        "d_dpto = @Original_id_dpto) AND (descripcion = @Original_descripcion OR @Origina" & _
        "l_descripcion IS NULL AND descripcion IS NULL) AND (nombre = @Original_nombre); " & _
        "SELECT id_dpto, nombre, descripcion FROM dbo.departamento WHERE (id_dpto = @id_d" & _
        "pto)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 255, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(184, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        '
        'frmDepartamento
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(272, 110)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmDepartamento"
        Me.Text = "Planilla"
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDepartamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlDataAdapter1.Fill(DsPlanilla1, "departamento")
        If departamento = "" Then
            Me.BindingContext(Me.DataView1).AddNew()
        Else
            Me.buscar(departamento)
            If borra Then
                Dim registro As Integer = Me.BindingContext(DataView1).Position
                Me.BindingContext(Me.DataView1).RemoveAt(registro)
                Me.SqlDataAdapter1.Update(Me.DsPlanilla1, "departamento")
                'Me.Close()
            Else
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingContext(DataView1).EndCurrentEdit()
        Me.SqlDataAdapter1.Update(Me.DsPlanilla1, "departamento")
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub buscar(ByVal nombre As String)
        Me.DataView1.RowFilter = "nombre = '" & nombre & "'"
    End Sub
End Class
