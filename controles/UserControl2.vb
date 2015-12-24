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
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.Nuevo = New DevComponents.DotNetBar.ButtonItem()
        Me.salvar = New DevComponents.DotNetBar.ButtonItem()
        Me.Borrar = New DevComponents.DotNetBar.ButtonItem()
        Me.Buscar = New DevComponents.DotNetBar.ButtonItem()
        Me.Imprimir = New DevComponents.DotNetBar.ButtonItem()
        Me.Salir = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        resources.ApplyResources(Me.Bar1, "Bar1")
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Nuevo, Me.salvar, Me.Borrar, Me.Buscar, Me.Imprimir, Me.Salir})
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabStop = False
        '
        'Nuevo
        '
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.Name = "Nuevo"
        resources.ApplyResources(Me.Nuevo, "Nuevo")
        '
        'salvar
        '
        Me.salvar.Image = CType(resources.GetObject("salvar.Image"), System.Drawing.Image)
        Me.salvar.Name = "salvar"
        resources.ApplyResources(Me.salvar, "salvar")
        '
        'Borrar
        '
        Me.Borrar.Image = CType(resources.GetObject("Borrar.Image"), System.Drawing.Image)
        Me.Borrar.Name = "Borrar"
        resources.ApplyResources(Me.Borrar, "Borrar")
        '
        'Buscar
        '
        Me.Buscar.Image = CType(resources.GetObject("Buscar.Image"), System.Drawing.Image)
        Me.Buscar.Name = "Buscar"
        resources.ApplyResources(Me.Buscar, "Buscar")
        '
        'Imprimir
        '
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.Name = "Imprimir"
        resources.ApplyResources(Me.Imprimir, "Imprimir")
        '
        'Salir
        '
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.Name = "Salir"
        resources.ApplyResources(Me.Salir, "Salir")
        '
        'UserControl2
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Controls.Add(Me.Bar1)
        Me.Name = "UserControl2"
        resources.ApplyResources(Me, "$this")
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
        Dim info As Object = type.GetMethod(metodo)
        Return (info IsNot Nothing)
    End Function
 
End Class
