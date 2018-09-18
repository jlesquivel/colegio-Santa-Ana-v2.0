Public Class frmTrasladoGrupo
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim lista As ArrayList
    Dim partes As String()
    Dim ds As New DataSet
    Dim conn As New ConexionSQL


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal pLista As ArrayList, ByVal pPartes As String())
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        lista = pLista
        partes = pPartes
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CambiaGrupo As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Label2 = New System.Windows.Forms.Label
        ComboBox1 = New System.Windows.Forms.ComboBox
        Button1 = New System.Windows.Forms.Button
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CambiaGrupo = New System.Data.SqlClient.SqlCommand
        SuspendLayout()
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(24, 32)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 23)
        Label2.TabIndex = 3
        Label2.Text = "Nuevo"
        '
        'ComboBox1
        '
        ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComboBox1.Location = New System.Drawing.Point(88, 32)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(104, 23)
        ComboBox1.TabIndex = 4
        ComboBox1.Text = "ComboBox1"
        '
        'Button1
        '
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.Location = New System.Drawing.Point(88, 64)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(104, 24)
        Button1.TabIndex = 6
        Button1.Text = "Trasladar"
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "grupos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("grupo", "grupo")})})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO grupos(grupo) VALUES (@grupo); SELECT grupo FROM grupos"
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"))
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT grupo FROM grupos WHERE (ano = @ano) AND (nivel = @nivel)"
        SqlSelectCommand1.Connection = SqlConnection1
        SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"))
        SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        '
        'CambiaGrupo
        '
        CambiaGrupo.CommandText = "UPDATE matricula SET grupo = @grupo2 WHERE (carnet = @carnet) AND (ano = @ano) AN" & _
        "D (nivel = @nivel) AND (grupo = @grupo)"
        CambiaGrupo.Connection = SqlConnection1
        CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo2", System.Data.SqlDbType.VarChar, 2, "grupo"))
        CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing))
        CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmTrasladoGrupo
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(224, 118)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Name = "frmTrasladoGrupo"
        Text = "Traslado Grupo"
        ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmTrasladoGrupo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = conn.strConn

            ds.Tables.Add("tabla1")
            SqlDataAdapter1.SelectCommand.Parameters("@ano").Value = partes(1)
            SqlDataAdapter1.SelectCommand.Parameters("@nivel").Value = partes(2)
            SqlDataAdapter1.Fill(ds.Tables("tabla1"))

            ComboBox1.DataSource = ds.Tables("tabla1")
            ComboBox1.DisplayMember = "grupo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim i As Integer = 0
            For i = 0 To lista.Count - 1
                CambiaGrupo.Parameters("@carnet").Value = lista(i)
                CambiaGrupo.Parameters("@ano").Value = partes(1)
                CambiaGrupo.Parameters("@nivel").Value = partes(2)
                CambiaGrupo.Parameters("@grupo").Value = partes(3)
                CambiaGrupo.Parameters("@grupo2").Value = ComboBox1.Text

                SqlConnection1.Open()
                CambiaGrupo.ExecuteNonQuery()
                SqlConnection1.Close()

                Close()

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
