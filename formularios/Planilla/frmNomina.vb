Imports System.Threading

Public Class frmNomina
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TreeViewSQL1 As colegio.TreeViewSQL
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Sqltree As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsPlanilla1 As colegio.dsPlanilla
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents old_ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents old_MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents old_MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents old_MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents SandBarManager1 As TD.SandBar.SandBarManager
    Friend WithEvents leftSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents rightSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents bottomSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents topSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents MenuBarItem1 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem2 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem3 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem4 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem5 As TD.SandBar.MenuBarItem
    Friend WithEvents ToolBar1 As TD.SandBar.ToolBar
    Friend WithEvents ButtonItem1 As TD.SandBar.ButtonItem
    Friend WithEvents ButtonItem2 As TD.SandBar.ButtonItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ButtonItem3 As TD.SandBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNomina))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Planillas", 1, 1)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeViewSQL1 = New colegio.TreeViewSQL
        Me.old_ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.old_MenuItem1 = New System.Windows.Forms.MenuItem
        Me.old_MenuItem2 = New System.Windows.Forms.MenuItem
        Me.old_MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Sqltree = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DsPlanilla1 = New colegio.dsPlanilla
        Me.SandBarManager1 = New TD.SandBar.SandBarManager
        Me.leftSandBarDock = New TD.SandBar.ToolBarContainer
        Me.rightSandBarDock = New TD.SandBar.ToolBarContainer
        Me.bottomSandBarDock = New TD.SandBar.ToolBarContainer
        Me.topSandBarDock = New TD.SandBar.ToolBarContainer
        Me.ToolBar1 = New TD.SandBar.ToolBar
        Me.ButtonItem1 = New TD.SandBar.ButtonItem
        Me.ButtonItem2 = New TD.SandBar.ButtonItem
        Me.ButtonItem3 = New TD.SandBar.ButtonItem
        Me.MenuBarItem1 = New TD.SandBar.MenuBarItem
        Me.MenuBarItem2 = New TD.SandBar.MenuBarItem
        Me.MenuBarItem3 = New TD.SandBar.MenuBarItem
        Me.MenuBarItem4 = New TD.SandBar.MenuBarItem
        Me.MenuBarItem5 = New TD.SandBar.MenuBarItem
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.topSandBarDock.SuspendLayout()
        Me.SuspendLayout()
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
        'TreeViewSQL1
        '
        Me.TreeViewSQL1.ContextMenu = Me.old_ContextMenu1
        Me.TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeViewSQL1.Etiquetas = "Planillas,,,"
        Me.TreeViewSQL1.ImageIndex = 1
        Me.TreeViewSQL1.ImageList = Me.ImageList1
        Me.TreeViewSQL1.InstruccionSQL = Me.Sqltree
        Me.TreeViewSQL1.Location = New System.Drawing.Point(0, 24)
        Me.TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Planillas"
        Me.TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewSQL1.SelectedImageIndex = 0
        Me.TreeViewSQL1.Size = New System.Drawing.Size(200, 418)
        Me.TreeViewSQL1.TabIndex = 0
        '
        'old_ContextMenu1
        '
        Me.old_ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.old_MenuItem1, Me.old_MenuItem2, Me.old_MenuItem3, Me.MenuItem2, Me.MenuItem1})
        '
        'old_MenuItem1
        '
        Me.old_MenuItem1.Index = 0
        Me.old_MenuItem1.Text = "Insertar"
        '
        'old_MenuItem2
        '
        Me.old_MenuItem2.Index = 1
        Me.old_MenuItem2.OwnerDraw = True
        Me.old_MenuItem2.Text = "Modificar"
        '
        'old_MenuItem3
        '
        Me.old_MenuItem3.Index = 2
        Me.old_MenuItem3.Text = "Borrar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = False
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Genera Planilla"
        '
        'Sqltree
        '
        Me.Sqltree.CommandText = resources.GetString("Sqltree.CommandText")
        Me.Sqltree.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""SERVIDOR-BD"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=""SERVIDOR-BD"";persist security info=False;initial catalog=planilla"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Location = New System.Drawing.Point(200, 24)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(6, 418)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.LargeImageList = Me.ImageList2
        Me.ListView1.Location = New System.Drawing.Point(206, 24)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(422, 418)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SandBarManager1
        '
        Me.SandBarManager1.OwnerForm = Me
        Me.SandBarManager1.Renderer = New TD.SandBar.WhidbeyRenderer
        '
        'leftSandBarDock
        '
        Me.leftSandBarDock.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftSandBarDock.Guid = New System.Guid("596a31b6-c38f-4aea-98b5-207ba522469c")
        Me.leftSandBarDock.Location = New System.Drawing.Point(0, 24)
        Me.leftSandBarDock.Manager = Me.SandBarManager1
        Me.leftSandBarDock.Name = "leftSandBarDock"
        Me.leftSandBarDock.Size = New System.Drawing.Size(0, 418)
        Me.leftSandBarDock.TabIndex = 3
        '
        'rightSandBarDock
        '
        Me.rightSandBarDock.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightSandBarDock.Guid = New System.Guid("65fbd354-240f-411c-8dca-3e9688a5d1b9")
        Me.rightSandBarDock.Location = New System.Drawing.Point(628, 24)
        Me.rightSandBarDock.Manager = Me.SandBarManager1
        Me.rightSandBarDock.Name = "rightSandBarDock"
        Me.rightSandBarDock.Size = New System.Drawing.Size(0, 418)
        Me.rightSandBarDock.TabIndex = 4
        '
        'bottomSandBarDock
        '
        Me.bottomSandBarDock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomSandBarDock.Guid = New System.Guid("1c3ce2d3-bbc5-4948-9b0a-6f69e07ae044")
        Me.bottomSandBarDock.Location = New System.Drawing.Point(0, 442)
        Me.bottomSandBarDock.Manager = Me.SandBarManager1
        Me.bottomSandBarDock.Name = "bottomSandBarDock"
        Me.bottomSandBarDock.Size = New System.Drawing.Size(628, 0)
        Me.bottomSandBarDock.TabIndex = 5
        '
        'topSandBarDock
        '
        Me.topSandBarDock.Controls.Add(Me.ToolBar1)
        Me.topSandBarDock.Dock = System.Windows.Forms.DockStyle.Top
        Me.topSandBarDock.Guid = New System.Guid("0ae0507f-3e4a-4c70-9205-d2b0ffb7fd38")
        Me.topSandBarDock.Location = New System.Drawing.Point(0, 0)
        Me.topSandBarDock.Manager = Me.SandBarManager1
        Me.topSandBarDock.Name = "topSandBarDock"
        Me.topSandBarDock.Size = New System.Drawing.Size(628, 24)
        Me.topSandBarDock.TabIndex = 6
        '
        'ToolBar1
        '
        Me.ToolBar1.DockLine = 1
        Me.ToolBar1.Guid = New System.Guid("4c587c79-6f3b-4f00-9974-254750daa30e")
        Me.ToolBar1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3})
        Me.ToolBar1.Location = New System.Drawing.Point(2, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Renderer = New TD.SandBar.WhidbeyRenderer
        Me.ToolBar1.Size = New System.Drawing.Size(242, 24)
        Me.ToolBar1.TabIndex = 1
        Me.ToolBar1.Text = "ToolBar1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Text = "Categorias"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Text = "Perfiles de Rubros"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Text = "Rubros"
        '
        'MenuBarItem1
        '
        Me.MenuBarItem1.Text = "&File"
        '
        'MenuBarItem2
        '
        Me.MenuBarItem2.Text = "&Edit"
        '
        'MenuBarItem3
        '
        Me.MenuBarItem3.Text = "&View"
        '
        'MenuBarItem4
        '
        Me.MenuBarItem4.MdiWindowList = True
        Me.MenuBarItem4.Text = "&Window"
        '
        'MenuBarItem5
        '
        Me.MenuBarItem5.Text = "&Help"
        '
        'frmNomina
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(628, 442)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.TreeViewSQL1)
        Me.Controls.Add(Me.leftSandBarDock)
        Me.Controls.Add(Me.rightSandBarDock)
        Me.Controls.Add(Me.bottomSandBarDock)
        Me.Controls.Add(Me.topSandBarDock)
        Me.Name = "frmNomina"
        Me.Text = "Nomina"
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.topSandBarDock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim niveles As String()
    Dim llave As String
    Private mHiloArch As Thread
    Dim vnt As New Ventanas

    Private Sub frmNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mHiloArch = New Thread(AddressOf cargar_datos)
        mHiloArch.Start()
    End Sub

    Private Sub cargar_datos()
        Try
            Dim conn As New conexionSQL
            conn.bd = "planilla"
            Me.SqlConnection1.ConnectionString = conn.strConn
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
    End Sub

    Private Sub llenar_list(ByRef pnodo As TreeNode)
        Dim nodo As TreeNode
        Me.ListView1.Clear()
        For Each nodo In pnodo.Nodes
            Dim nuevo As New ListViewItem
            nuevo.Text = nodo.Text
            nuevo.ImageIndex = nodo.ImageIndex
            nuevo.Tag = nodo.Tag
            Me.ListView1.Items.Add(nuevo)
        Next
    End Sub
    Private Sub TreeViewSQL1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSQL1.AfterSelect
        niveles = Me.TreeViewSQL1.ruta(e.Node.FullPath)
        llenar_list(e.Node)
        If niveles.Length = 4 Then
            llave = e.Node.Tag(0)
            'Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
            'cargarVentana(New frmEmpleado(pto, llave, False))
        End If
    End Sub
    ' on right click 
    Private Sub TreeViewSQL1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeViewSQL1.MouseDown
        Dim nodo As TreeNode = TreeViewSQL1.GetNodeAt(e.X, e.Y)
        TreeViewSQL1.SelectedNode = nodo
        If nodo Is Nothing Then
            Array.Clear(niveles, 0, niveles.Length)
        Else
            niveles = Me.TreeViewSQL1.ruta(nodo.FullPath)
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles old_MenuItem1.Click
        Select Case niveles.Length
            Case 1 ' inserta departamento
                vnt.cargarVentana(New frmDepartamento, Me.ParentForm)
            Case 2
                Dim dpto As Integer = BID_dpto(niveles(1))
                vnt.cargarVentana(New frmPuesto(dpto), Me.ParentForm)
            Case 3  ' contrata empleado
                Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                vnt.cargarVentana(New frmContrataEmpleado(pto), Me.ParentForm) '(pto, "", False))
            Case Else
        End Select
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles old_MenuItem2.Click
        Select Case niveles.Length - 1
            Case 1 ' actualiza departamento
                vnt.cargarVentana(New frmDepartamento(niveles(niveles.Length - 1), False), Me.ParentForm)
            Case 2
                vnt.cargarVentana(New frmPuesto(niveles(niveles.Length - 1), False), Me.ParentForm)
            Case 3
                Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                vnt.cargarVentana(New frmContrato(pto, llave, False), Me.ParentForm)
            Case Else
        End Select
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles old_MenuItem3.Click
        Select Case niveles.Length - 1
            Case 1 ' borra departamento
                vnt.cargarVentana(New frmDepartamento(niveles(niveles.Length - 1), True), Me.ParentForm)
            Case 2
                Dim puesto As frmPuesto = New frmPuesto(niveles(niveles.Length - 1), True)
                puesto.borrap()
                puesto.Close()
                puesto = Nothing
            Case 3
                Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                vnt.cargarVentana(New frmContrato(pto, llave, True), Me.ParentForm)
            Case Else
        End Select
    End Sub

    Private Sub TreeViewSQL1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeViewSQL1.GotFocus
        Me.TreeViewSQL1.llenar("planilla")
    End Sub

    Private Function BID_dpto(ByVal nombre As String) As Integer
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Dim ds As New DataSet
        ds.Tables.Add(New DataTable("una"))
        Dim instruccion As String = "Select * from departamento where nombre='" & nombre & "'"
        conn.llena(ds, "una", instruccion)
        If ds.Tables("una").Rows.Count > 0 Then
            Return ds.Tables("una").Rows(0).Item("id_dpto")
        Else
            Return 0
        End If
    End Function

    Private Function BID_pto(ByVal depto As String, ByVal nombre As String) As Integer
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Dim ds As New DataSet
        ds.Tables.Add(New DataTable("una"))
        Dim SQLinst As String = "Select * from puestos where nombre='" & nombre & "' and id_dpto =" & depto
        conn.llena(ds, "una", SQLinst)
        If ds.Tables("una").Rows.Count > 0 Then
            Return ds.Tables("una").Rows(0).Item("id_puesto")
        Else
            Return 0
        End If
    End Function
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim item As String = ListView1.SelectedItems(0).Text
            Dim llavel As String = ListView1.SelectedItems(0).Tag(0)
            Select Case niveles.Length
                Case 1 ' actualiza departamento
                    vnt.cargarVentana(New frmDepartamento(item, False), Me.ParentForm)
                Case 2
                    vnt.cargarVentana(New frmPuesto(item, False), Me.ParentForm)
                Case 3
                    Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                    vnt.cargarVentana(New frmContrato(pto, llavel, False), Me.ParentForm)
                Case Else
            End Select
        End If
    End Sub

    Private Sub ButtonItem1_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Activate
        vnt.cargarVentana(New frmCategoria, Me.ParentForm)
    End Sub

    Private Sub ButtonItem2_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Activate
        vnt.cargarVentana(New frmPerfiles, Me.ParentForm)
    End Sub

    Private Sub old_ContextMenu1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles old_ContextMenu1.Popup
        Me.MenuItem1.Enabled = False
        Select Case niveles.Length
            Case 2 ' actualiza departamento
                Me.MenuItem1.Enabled = True
        End Select
    End Sub

    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim id_departamento As Integer = BID_dpto(Me.TreeViewSQL1.SelectedNode.Text)
        vnt.cargarVentana(New frmPlanilla(id_departamento), Me.ParentForm)
    End Sub

    Private Sub ButtonItem3_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Activate
        vnt.cargarVentana(New frmRubros, Me.ParentForm)
    End Sub
End Class
