Public Class frmAsignaProfesor
     Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim partes As String()
    Dim primero As Boolean = True
    Dim lista As Object

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal pPartes As String())
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        partes = pPartes

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
    Friend WithEvents DsEmpleados1 As colegio.dsEmpleados
    Friend WithEvents ActualizaProfesor As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignaProfesor))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsEmpleados1 = New colegio.dsEmpleados
        Me.ActualizaProfesor = New System.Data.SqlClient.SqlCommand
        Me.DataView1 = New System.Data.DataView
        Me.ListBox1 = New System.Windows.Forms.ListBox
        CType(Me.DsEmpleados1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;user id=jose;data source=servidor_b" & _
            "d;persist security info=True;initial catalog=colegio;password=123"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida")})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;user id=jose;data source=SERVIDOR_B" & _
            "D;persist security info=False;initial catalog=planilla"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'DsEmpleados1
        '
        Me.DsEmpleados1.DataSetName = "dsEmpleados"
        Me.DsEmpleados1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActualizaProfesor
        '
        Me.ActualizaProfesor.CommandText = "UPDATE profesores_cursos SET cedula = @cedula WHERE (ano = @ano) AND (periodo = @" & _
            "periodo) AND (nivel = @nivel) AND (grupo = @grupo) AND (materia = @materia)"
        Me.ActualizaProfesor.Connection = Me.SqlConnection1
        Me.ActualizaProfesor.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 15, "cedula"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsEmpleados1.empleados
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DsEmpleados1.empleados
        Me.ListBox1.DisplayMember = "nombre"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 407)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "id_emp"
        '
        'frmAsignaProfesor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(248, 414)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAsignaProfesor"
        Me.Text = "Asigna Profesor"
        CType(Me.DsEmpleados1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAsignaProfesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            Dim connPlani As New conexionSQL
            connPlani.bd = "planilla"

            Dim connCol As New conexionSQL
            connCol.bd = "colegio"

            connCol.ejecuta("EXEC listaProfesores " & Now.Year)

            Me.SqlConnection1.ConnectionString = connCol.strConn
            Me.SqlConnection2.ConnectionString = connPlani.strConn

            Me.SqlDataAdapter1.Fill(DsEmpleados1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim actualizo As Integer

        'If Not primero Then
        Me.ActualizaProfesor.Parameters("@ano").Value = partes(1)
        Me.ActualizaProfesor.Parameters("@periodo").Value = partes(2)
        Me.ActualizaProfesor.Parameters("@nivel").Value = partes(3)
        Me.ActualizaProfesor.Parameters("@grupo").Value = partes(4)
        Me.ActualizaProfesor.Parameters("@materia").Value = partes(5)

        Me.ActualizaProfesor.Parameters("@cedula").Value = ListBox1.SelectedValue

        Dim conx As New conexionSQL
        Me.ActualizaProfesor.Connection.ConnectionString = conx.strConn

        ActualizaProfesor.Connection.Open()
        actualizo = Me.ActualizaProfesor.ExecuteNonQuery()
        ActualizaProfesor.Connection.Close()

        If actualizo < 1 Then
            MessageBox.Show("error")
        End If

        Me.Close()
        '  Else
        ' primero = False
        'End If
    End Sub
End Class
