Public Class frmTrasladoGrupo
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim lista As ArrayList
    Dim partes As String()
    Dim ds As New DataSet
    Dim conn As New conexionSQL


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
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.CambiaGrupo = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nuevo"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(88, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 23)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "ComboBox1"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(88, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Trasladar"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "grupos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("grupo", "grupo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO grupos(grupo) VALUES (@grupo); SELECT grupo FROM grupos"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT grupo FROM grupos WHERE (ano = @ano) AND (nivel = @nivel)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        '
        'CambiaGrupo
        '
        Me.CambiaGrupo.CommandText = "UPDATE matricula SET grupo = @grupo2 WHERE (carnet = @carnet) AND (ano = @ano) AN" & _
        "D (nivel = @nivel) AND (grupo = @grupo)"
        Me.CambiaGrupo.Connection = Me.SqlConnection1
        Me.CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo2", System.Data.SqlDbType.VarChar, 2, "grupo"))
        Me.CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ano", System.Data.DataRowVersion.Original, Nothing))
        Me.CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.CambiaGrupo.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "grupo", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmTrasladoGrupo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 118)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmTrasladoGrupo"
        Me.Text = "Traslado Grupo"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmTrasladoGrupo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = conn.strConn

            ds.Tables.Add("tabla1")
            Me.SqlDataAdapter1.SelectCommand.Parameters("@ano").Value = partes(1)
            Me.SqlDataAdapter1.SelectCommand.Parameters("@nivel").Value = partes(2)
            Me.SqlDataAdapter1.Fill(ds.Tables("tabla1"))

            Me.ComboBox1.DataSource = ds.Tables("tabla1")
            Me.ComboBox1.DisplayMember = "grupo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim i As Integer = 0
            For i = 0 To lista.Count - 1
                Me.CambiaGrupo.Parameters("@carnet").Value = lista(i)
                Me.CambiaGrupo.Parameters("@ano").Value = partes(1)
                Me.CambiaGrupo.Parameters("@nivel").Value = partes(2)
                Me.CambiaGrupo.Parameters("@grupo").Value = partes(3)
                Me.CambiaGrupo.Parameters("@grupo2").Value = Me.ComboBox1.Text

                Me.SqlConnection1.Open()
                Me.CambiaGrupo.ExecuteNonQuery()
                Me.SqlConnection1.Close()

                Me.Close()

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
