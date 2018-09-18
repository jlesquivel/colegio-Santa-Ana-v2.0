Imports colegioReportes

Public Class frmCarneCobros
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim anno As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal panno As String)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        anno = panno
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
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsCarnet1 As colegio.dsCarnet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        DsCarnet1 = New colegio.dsCarnet
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Button1 = New System.Windows.Forms.Button
        Button2 = New System.Windows.Forms.Button
        Button3 = New System.Windows.Forms.Button
        CType(DsCarnet1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'CheckedListBox1
        '
        CheckedListBox1.CheckOnClick = True
        CheckedListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", DsCarnet1, "estudiantes.familia"))
        CheckedListBox1.Location = New System.Drawing.Point(136, 24)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New System.Drawing.Size(224, 259)
        CheckedListBox1.TabIndex = 0
        CheckedListBox1.ThreeDCheckBoxes = True
        '
        'DsCarnet1
        '
        DsCarnet1.DataSetName = "dsCarnet"
        DsCarnet1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
        "_BD;persist security info=True;initial catalog=colegio;password=123"
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("familia", "familia")})})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT DISTINCT dbo.estudiantes.familia FROM dbo.estudiantes INNER JOIN dbo.matri" & _
        "cula ON dbo.estudiantes.carnet = dbo.matricula.carnet WHERE (dbo.matricula.ano =" & _
        " @anno)"
        SqlSelectCommand1.Connection = SqlConnection1
        SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.VarChar, 4, "ano"))
        '
        'Button1
        '
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button1.Location = New System.Drawing.Point(40, 32)
        Button1.Name = "Button1"
        Button1.TabIndex = 1
        Button1.Text = "Todos"
        '
        'Button2
        '
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button2.Location = New System.Drawing.Point(40, 64)
        Button2.Name = "Button2"
        Button2.TabIndex = 2
        Button2.Text = "Ninguno"
        '
        'Button3
        '
        Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button3.Location = New System.Drawing.Point(40, 136)
        Button3.Name = "Button3"
        Button3.TabIndex = 3
        Button3.Text = "Imprimir"
        '
        'frmCarneCobros
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(376, 299)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CheckedListBox1)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCarneCobros"
        Text = "Confecciona Carnet"
        CType(DsCarnet1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCarneCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New ConexionSQL
        SqlConnection1.ConnectionString = conn.strConn
        SqlDataAdapter1.SelectCommand.Parameters.Item("@anno").Value = anno

        SqlDataAdapter1.Fill(DsCarnet1)
        Dim registro As DataRow

        For Each registro In DsCarnet1.Tables("estudiantes").Rows
            CheckedListBox1.Items.Add(registro.ItemArray(0), False)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Litem As Integer
        For Litem = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(Litem, True)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Litem As Integer
        For Litem = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(Litem, False)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim familias As String = ""
            Dim i As Integer
            For i = 0 To CheckedListBox1.CheckedIndices.Count - 1
                familias &= """"
                familias &= CheckedListBox1.CheckedItems.Item(i)
                familias &= """"
                familias &= ","

            Next
            familias = "[" & familias.Substring(0, familias.Length - 1) & "]"

            Dim oImprimir As New Reportes
            Dim rep As New rptTarjetaFamilia
            oImprimir.inserta_parametro(rep, "@ano", anno)
            oImprimir.inserta_parametro(rep, "@familias", familias)
            rep.SummaryInfo.ReportComments = "CARNETS " & anno
            oImprimir.imprimir(rep, False, ParentForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
