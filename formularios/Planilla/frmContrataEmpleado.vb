Public Class frmContrataEmpleado
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal pto As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        puesto = pto
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MonedaTextBox1 As colegio.MonedaTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Ds2planilla1 As colegio.ds2planilla
    Friend WithEvents CEmpleado1 As colegio.CEmpleado
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrataEmpleado))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.MonedaTextBox1 = New colegio.MonedaTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds2planilla1 = New colegio.ds2planilla
        Me.CEmpleado1 = New colegio.CEmpleado
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Info
        Me.ListBox1.Location = New System.Drawing.Point(16, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(232, 303)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleado"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Puesto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha Inicio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Fin"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Horas o lecciones "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(112, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "ComboBox1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Categoria"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "TextBox1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(112, 72)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Numero
        Me.MonedaTextBox1.Location = New System.Drawing.Point(112, 96)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.Size = New System.Drawing.Size(88, 20)
        Me.MonedaTextBox1.TabIndex = 12
        Me.MonedaTextBox1.Text = "0,00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.MonedaTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(256, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 152)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contrato"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(216, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Contratar"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""SERVIDOR-BD"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=""SERVIDOR-BD"";persist security info=False;initial catalog=planilla"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v_empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO v_empleados(nombre) VALUES (@nombre); SELECT id_emp, nombre FROM v_em" & _
            "pleados"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 51, "nombre")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_emp, nombre FROM v_empleados"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Ds2planilla1
        '
        Me.Ds2planilla1.DataSetName = "ds2planilla"
        Me.Ds2planilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.Ds2planilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CEmpleado1
        '
        Me.CEmpleado1.BackColor = System.Drawing.SystemColors.Control
        Me.CEmpleado1.Location = New System.Drawing.Point(256, 32)
        Me.CEmpleado1.Name = "CEmpleado1"
        Me.CEmpleado1.Size = New System.Drawing.Size(304, 152)
        Me.CEmpleado1.TabIndex = 14
        '
        'frmContrataEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 358)
        Me.Controls.Add(Me.CEmpleado1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmContrataEmpleado"
        Me.Text = "frmContrataEmpleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim puesto As Integer
    Dim cargar As New CargarLista
    Dim conn As New conexionSQL("planilla")

    Private Sub frmContrataEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlDataAdapter1.Fill(Me.Ds2planilla1, "v_empleados")
        cargar.DatosLista(Me.Ds2planilla1.Tables("v_empleados"), Me.ListBox1, "id_emp", "nombre")

        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today

        Me.TextBox1.Text = puesto
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.CEmpleado1.buscar(ListBox1.SelectedItem.codigo)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
