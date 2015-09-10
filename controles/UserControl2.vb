Imports System.Reflection
Imports System.Text


Public Class UserControl2
    Inherits System.Windows.Forms.UserControl
    Dim f As Object

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Try
            f = Parent
        Catch ex As Exception
        End Try
    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents Nuevo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents salvar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Borrar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Buscar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Imprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Salir As DevComponents.DotNetBar.ButtonItem

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl2))
        Bar1 = New DevComponents.DotNetBar.Bar()
        Nuevo = New DevComponents.DotNetBar.ButtonItem()
        salvar = New DevComponents.DotNetBar.ButtonItem()
        Borrar = New DevComponents.DotNetBar.ButtonItem()
        Buscar = New DevComponents.DotNetBar.ButtonItem()
        Imprimir = New DevComponents.DotNetBar.ButtonItem()
        Salir = New DevComponents.DotNetBar.ButtonItem()
        CType(Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'Bar1
        '
        Bar1.AntiAlias = True
        resources.ApplyResources(Bar1, "Bar1")
        Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Nuevo, salvar, Borrar, Buscar, Imprimir, Salir})
        Bar1.Name = "Bar1"
        Bar1.Stretch = True
        Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Bar1.TabStop = False
        '
        'Nuevo
        '
        Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Nuevo.Name = "Nuevo"
        resources.ApplyResources(Nuevo, "Nuevo")
        '
        'salvar
        '
        salvar.Image = CType(resources.GetObject("salvar.Image"), System.Drawing.Image)
        salvar.Name = "salvar"
        resources.ApplyResources(salvar, "salvar")
        '
        'Borrar
        '
        Borrar.Image = CType(resources.GetObject("Borrar.Image"), System.Drawing.Image)
        Borrar.Name = "Borrar"
        resources.ApplyResources(Borrar, "Borrar")
        '
        'Buscar
        '
        Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Buscar.Name = "Buscar"
        resources.ApplyResources(Buscar, "Buscar")
        '
        'Imprimir
        '
        Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Imprimir.Name = "Imprimir"
        resources.ApplyResources(Imprimir, "Imprimir")
        '
        'Salir
        '
        Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Salir.Name = "Salir"
        resources.ApplyResources(Salir, "Salir")
        '
        'UserControl2
        '
        AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Controls.Add(Bar1)
        Name = "UserControl2"
        resources.ApplyResources(Me, "$this")
        CType(Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
#End Region

    Private Sub UserControl2_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    End Sub
    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles Me.Load
        f = Parent
    End Sub
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        If checkField(f, "nuevo") Then
            f.nuevo()
        End If
    End Sub

    Private Sub salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click

        If checkField(f, "guardar") Then
            f.guardar()
        End If
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click

        If checkField(f, "borrar") Then
            f.borrar()
        End If
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click

        If checkField(f, "buscar") Then
            f.buscar()
        End If
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click

        If checkField(f, "imprimir") Then
            f.imprimir()
        End If
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        If checkField(f, "close") Then
            f.close()
        End If
    End Sub

    Public Function checkField(ByVal objectt As Object, ByVal metodo As String) As Boolean
        Dim type As Type = objectt.GetType
        Return type.GetMethod(metodo) IsNot Nothing
    End Function
 
End Class
