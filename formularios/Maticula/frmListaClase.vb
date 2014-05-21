Imports colegioReportes

Public Class frmListaClase
    Inherits System.Windows.Forms.Form
    Dim dvLista As DataView
    Dim partes As String()
    Public conn As New conexionSQL
    Public frmReporte As New frmReporte()


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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsArbol1 As colegio.dsArbol
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsListaClase1 As colegio.dsListaClase
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Imprimir As System.Windows.Forms.MenuItem
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents TreeViewSQL1 As colegio.TreeViewSQL
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents SqlFamiliaApellidos As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaClase))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Años", 1, 1)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.Imprimir = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.DsArbol1 = New colegio.dsArbol
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DsListaClase1 = New colegio.dsListaClase
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlFamiliaApellidos = New System.Data.SqlClient.SqlCommand
        Me.TreeViewSQL1 = New colegio.TreeViewSQL
        CType(Me.DsArbol1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListaClase1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.Imprimir, Me.MenuItem3, Me.MenuItem12, Me.MenuItem4})
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Editar"
        '
        'Imprimir
        '
        Me.Imprimir.Index = 1
        Me.Imprimir.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem10, Me.MenuItem11})
        Me.Imprimir.Text = "Imprimir"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Lista de Clase"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Listado General"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "Lista para INS"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Ingresos X matricula"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "Lista Bingo"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Text = "Lista de Familias"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 6
        Me.MenuItem10.Text = "Carnet de Familia"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 7
        Me.MenuItem11.Text = "Becados"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "Trasaldo de Grupo"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Borrar Estudiante"
        Me.MenuItem4.Visible = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=PORTATIL;initial catalog=colegio;integrated security=SSPI;persist sec" & _
            "urity info=False;workstation id=PORTATIL;packet size=4096"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "matricula", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ano", "ano"), New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("grupo", "grupo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT ano, nivel, grupo FROM matricula ORDER BY ano DESC, nivel, grupo"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
            "scritorio;persist security info=False;initial catalog=colegio"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'DsArbol1
        '
        Me.DsArbol1.DataSetName = "dsArbol"
        Me.DsArbol1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsArbol1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.AliceBlue
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid1.CaptionText = "Alumnos :"
        Me.DataGrid1.ContextMenu = Me.ContextMenu1
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DsListaClase1.estudiantes
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(184, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.RowHeaderWidth = 21
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Info
        Me.DataGrid1.Size = New System.Drawing.Size(463, 468)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsListaClase1
        '
        Me.DsListaClase1.DataSetName = "dsListaClase"
        Me.DsListaClase1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsListaClase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.AliceBlue
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "estudiantes"
        Me.DataGridTableStyle1.PreferredColumnWidth = 100
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Carnet"
        Me.DataGridTextBoxColumn1.MappingName = "carnet"
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Apellido1"
        Me.DataGridTextBoxColumn2.MappingName = "apellido1"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Apellido2"
        Me.DataGridTextBoxColumn3.MappingName = "apellido2"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn4.MappingName = "nombre"
        Me.DataGridTextBoxColumn4.Width = 130
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("Nuevo", "Nuevo")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO estudiantes(carnet, apellido1, apellido2, nombre) VALUES (@carnet, @a" & _
            "pellido1, @apellido2, @nombre)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection3
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection3
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo")})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO estudiantes(carnet, apellido1, apellido2, nombre) VALUES (@carnet, @a" & _
            "pellido1, @apellido2, @nombre)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano"), New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 2, "grupo")})
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(184, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 468)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        '
        'SqlFamiliaApellidos
        '
        Me.SqlFamiliaApellidos.CommandText = "SELECT DISTINCT estudiantes.familia FROM matricula LEFT OUTER JOIN estudiantes ON" & _
            " matricula.carnet = estudiantes.carnet WHERE (matricula.ano = @ano) ORDER BY est" & _
            "udiantes.familia"
        Me.SqlFamiliaApellidos.Connection = Me.SqlConnection2
        Me.SqlFamiliaApellidos.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano")})
        '
        'TreeViewSQL1
        '
        Me.TreeViewSQL1.ContextMenu = Me.ContextMenu1
        Me.TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeViewSQL1.Etiquetas = "Años,,Nivel ,Grupo "
        Me.TreeViewSQL1.HotTracking = True
        Me.TreeViewSQL1.ImageIndex = 0
        Me.TreeViewSQL1.ImageList = Me.ImageList1
        Me.TreeViewSQL1.InstruccionSQL = Me.SqlSelectCommand1
        Me.TreeViewSQL1.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Años"
        Me.TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewSQL1.SelectedImageIndex = 0
        Me.TreeViewSQL1.Size = New System.Drawing.Size(184, 468)
        Me.TreeViewSQL1.TabIndex = 3
        '
        'frmListaClase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(647, 468)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.TreeViewSQL1)
        Me.MaximizeBox = False
        Me.Name = "frmListaClase"
        Me.Text = "Lista Clase"
        CType(Me.DsArbol1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListaClase1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmListaClas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim conn As New conexionSQL()
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlConnection2.ConnectionString = conn.strConn
        Me.SqlConnection3.ConnectionString = conn.strConn
        Me.TreeViewSQL1.llenar("colegio")
        Me.TreeViewSQL1.TopNode.Expand()
    End Sub

    Private Sub TreeViewSQL1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSQL1.AfterSelect

        partes = TreeViewSQL1.ruta(e.Node.FullPath)
        Dim afectadas As Integer
        If partes.Length = 4 Then
            afectadas = llenar_grid()
            DataGrid1.CaptionText = "Alumnos :" & afectadas & "          " & e.Node.FullPath
        Else
            DsListaClase1.Clear()
            DataGrid1.CaptionText = ""
        End If
    End Sub

    Private Sub ContextMenu1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenu1.Popup
        Imprimir.Enabled = False
        MenuItem1.Enabled = False  ' lista clase
        MenuItem2.Enabled = False   'listado general p' matricula
        MenuItem4.Enabled = False   'borra estudiantes
        MenuItem5.Enabled = False   'lista para INS
        MenuItem6.Enabled = False   'Editar
        MenuItem7.Enabled = False   'ingresos x matricula
        MenuItem8.Enabled = False   'Lista bingo
        MenuItem9.Enabled = False   'Lista x familia
        MenuItem10.Enabled = False   'Lista becados
        MenuItem11.Enabled = False   'Lista becados
        MenuItem12.Enabled = False

        Select Case partes.Length
            Case 2
                Imprimir.Enabled = True
                MenuItem1.Enabled = True
                MenuItem2.Enabled = True
                MenuItem5.Enabled = True
                MenuItem7.Enabled = True   'ingresos x matricula
                MenuItem8.Enabled = True   'Lista bingo
                MenuItem9.Enabled = True   'Lista x familia
                MenuItem10.Enabled = True   'Lista becados
                MenuItem11.Enabled = True   'Lista becados
            Case 4
                Imprimir.Enabled = True
                MenuItem1.Enabled = True  ' lista clase
                MenuItem12.Enabled = True

        End Select


        If DataGrid1.CurrentRowIndex >= 0 Then
            If Me.DataGrid1.IsSelected(DataGrid1.CurrentRowIndex) Then
                MenuItem4.Enabled = True
                MenuItem6.Enabled = True
            End If
            MenuItem1.Enabled = True
        End If
    End Sub

    Private Sub Imp_lista(ByVal partes() As String)
        ' Imprime lista de clase
        Try
            
            Dim oImprimir As New Reportes
            Dim rep As New rptListaClase2

            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            oImprimir.inserta_parametro(rep, "@nivel", partes(2))
            oImprimir.inserta_parametro(rep, "@grupo", partes(3))
            rep.SummaryInfo.ReportComments = " Lista Clase " & partes(1)

            oImprimir.imprimir(rep, False, Me.ParentForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim t As TreeNode = Me.TreeViewSQL1.SelectedNode

        Dim partes As String() = TreeViewSQL1.ruta(t.FullPath)

        Select Case partes.Length - 1
            Case Is = 1

                Dim oImprimir As New Reportes
                Dim rep As New rptListaClaseAno
                oImprimir.inserta_parametro(rep, "@ano", partes(1))
                rep.SummaryInfo.ReportComments = " Lista Clase " & partes(1)
                oImprimir.imprimir(rep, False, Me.ParentForm)

            Case Is = 2
                Dim oImprimir As New Reportes
                Dim rep As New rptListaClase2
                oImprimir.inserta_parametro(rep, "@ano", partes(1))
                oImprimir.inserta_parametro(rep, "@nivel", partes(2))
                rep.SummaryInfo.ReportComments = " Lista Clase " & partes(1)
                oImprimir.imprimir(rep, False, Me.ParentForm)

            Case Is = 3
                Imp_lista(partes)
        End Select
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If partes.Length = 4 Then
            Dim pcarnet As String = "carnet = '" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & "' "
            Dim pano As String = "AND ano = '" & partes(1) & "' "
            Dim pnivel As String = "AND nivel = '" & partes(2) & "' "
            Dim pgrupo As String = "AND grupo = '" & partes(3) & "' "
            Dim condicion As String = "(" & pcarnet & pano & pnivel & pgrupo & ")"

            Dim comando As String = "DELETE FROM matricula  WHERE " & condicion
            Dim conn As New conexionSQL
            conn.ejecuta(comando)           ' borrar registro
            llenar_grid()                   ' actualiza grid
        End If
    End Sub

    Private Function llenar_grid() As Integer
        Try
            ' llena el grid con los estudiantes 
            SqlDataAdapter2.SelectCommand.Parameters("@ano").Value = partes(1)
            SqlDataAdapter2.SelectCommand.Parameters("@nivel").Value = partes(2)
            SqlDataAdapter2.SelectCommand.Parameters("@grupo").Value = partes(3)
            DsListaClase1.Clear()
            llenar_grid = SqlDataAdapter2.Fill(DsListaClase1, "estudiantes")
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim carnet As String = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        Dim ventana As New frmEstudiantes(carnet)

        ventana.MdiParent = Me.ParentForm
        ventana.Estudiantes1.BuscarVisible = False
        ventana.Show()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'reporte listado general
        Try
            Dim oImprimir As New Reportes
            Dim rep As New rptGeneral
            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            rep.SummaryInfo.ReportComments = " Reporte General " & partes(1)
            oImprimir.imprimir(rep, False, Me.ParentForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'reporte  listado INS Polizas
        Try
            Dim oImprimir As New Reportes
            Dim rep As New rptPolizasINS
            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            rep.SummaryInfo.ReportComments = " Reporte Polizas INS " & partes(1)
            oImprimir.imprimir(rep, False, Me.ParentForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        'reporte ingresos x matricula
        Try
            Dim oImprimir As New Reportes
            Dim rep As New rptMatricula
            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            rep.SummaryInfo.ReportComments = " Reporte Ingreso Matricula " & partes(1)
            oImprimir.imprimir(rep, False, Me.ParentForm)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        ' reporte Bingo
        Try
            Dim oImprimir As New Reportes
            Dim rep As New rptBingo
            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            rep.SummaryInfo.ReportComments = "REPORTE BINGO " & partes(1)
            oImprimir.imprimir(rep, False, Me.ParentForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        ' reporte de familias
        Try
            Dim oImprimir As New Reportes
            Dim rep As New rptFamilia
            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            rep.SummaryInfo.ReportComments = "REPORTE FAMILIA " & partes(1)
            oImprimir.imprimir(rep, False, Me.ParentForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        ' reporte Carnet de familias

        Dim panta As New frmCarneCobros(partes(1))
        panta.MdiParent = Me.ParentForm
        panta.Show()

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        ' reporte Carnet de familias
        Try
            Dim oImprimir As New Reportes
            Dim rep As New rptBecados
            oImprimir.inserta_parametro(rep, "@ano", partes(1))
            rep.SummaryInfo.ReportComments = " BECADOS " & partes(1)
            oImprimir.imprimir(rep, False, Me.ParentForm)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim carnets As ArrayList = GetSelectedRows(DataGrid1)

        If carnets.Count > 0 Then
            Dim ventana As New frmTrasladoGrupo(carnets, partes)
            ventana.MdiParent = Me.ParentForm
            ventana.Show()
        Else
            MessageBox.Show("Debe seleccionar algún estudiante")
        End If
    End Sub

    Public Function GetSelectedRows(ByVal dg As DataGrid) As System.Collections.ArrayList

        Dim al As New ArrayList
        Dim cm As CurrencyManager = Me.BindingContext(dg.DataSource, dg.DataMember)
        Dim dv As DataView = CType(cm.List, DataView)
        Dim i As Integer

        For i = 0 To dv.Count - 1
            If dg.IsSelected(i) Then
                al.Add(dg.Item(i, 0))
            End If
        Next
        Return al
    End Function 'GetSelectedRows 

    Private Sub frmListaClase_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        If Not (partes Is Nothing) Then
            If partes.Length = 3 Then
                If partes(3) <> "" Then
                    llenar_grid()
                End If
            End If
        End If
    End Sub
End Class
