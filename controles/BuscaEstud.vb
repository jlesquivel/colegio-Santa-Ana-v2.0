Imports System.Data.SqlClient

Public Class BuscaEstud
    Inherits System.Windows.Forms.UserControl

    Private tabla_todos = "estudiantes"
    Private tabla_activos = "estudiantes_activos"

    Private tabla As String = tabla_activos
    Private campos As String = "carnet, apellido1 +' '+ apellido2 +' '+ nombre  as nombres"
    Private orden As String = "nombres"
    Dim filtro As String
    Dim comboIndex As Integer = 1
    Dim dv As DataView
    Public seleccionado As String
    Public nombre As String
    Dim primero As Boolean = True

    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton

#Region "Eventos"
    Public Event selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs)

    Protected Friend Overridable Sub OnSeleccion(ByVal e As SeleccionadoEventArgs)
        RaiseEvent selecionado(Me, e)
    End Sub
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Campo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(55, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 22)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(55, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(0, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(181, 300)
        Me.ListBox1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SwitchButton1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 74)
        Me.Panel1.TabIndex = 2
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Location = New System.Drawing.Point(55, 51)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SwitchButton1.OffText = "Matriculados"
        Me.SwitchButton1.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchButton1.OnText = "Todos"
        Me.SwitchButton1.OnTextColor = System.Drawing.Color.Black
        Me.SwitchButton1.Size = New System.Drawing.Size(96, 22)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton1.SwitchWidth = 20
        Me.SwitchButton1.TabIndex = 4
        '
        'BuscaEstud
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BuscaEstud"
        Me.Size = New System.Drawing.Size(181, 374)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'Realizar la búsqueda según la columna
        If dv.Table.Columns(ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = ComboBox1.Text & " like '" & TextBox1.Text & "%'"
        Else
            If TextBox1.Text.Trim.Length > 0 Then
                filtro = ComboBox1.Text & " = " & TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
    End Sub

    Sub cargar()
        If Not (DesignMode) Then

            Dim conn As New conexionSQL
            tabla = IIf(SwitchButton1.Value, tabla_todos, tabla_activos)

            If Not (conn.conexion Is Nothing) Then


                Dim da As New SqlDataAdapter("select " & campos & " from " & tabla &
                    IIf(orden.Length > 0, " order by " & orden, ""), conn.conexion)

                Dim ds As New DataSet             'Definimos el dataset y el dataadapter
                Dim dsPubs As New DataSet("Estud")
                da.FillSchema(ds, SchemaType.Source, "Estud")
                da.Fill(ds, "Estud")

                'Asignamos la tabla que utiliza el dataview
                dv = ds.Tables(0).DefaultView

                ListBox1.DisplayMember = "nombres"
                ListBox1.ValueMember = "carnet"
                ListBox1.DataSource = dv

                'Llenamos el combo con el listado de campos
                ComboBox1.Items.Clear()
                Dim c As DataColumn
                For Each c In ds.Tables(0).Columns
                    ComboBox1.Items.Add(c.ColumnName)
                Next

                ComboBox1.SelectedIndex = comboIndex 'Asignar el primer elemento como seleccionado
                dv.RowFilter = ComboBox1.Text & " like '" & TextBox1.Text & "%'"

            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If dv.Table.Columns(ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = ComboBox1.Text & " like '" & TextBox1.Text & "%'"
        Else
            If TextBox1.Text.Trim.Length > 0 Then
                filtro = ComboBox1.Text & " = " & TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
        comboIndex = ComboBox1.SelectedIndex
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        '' If Not primero Or ListBox1.SelectedItem IsNot Nothing Then

        If ListBox1.SelectedItem IsNot Nothing Then
            seleccionado = ListBox1.SelectedValue
            nombre = ListBox1.SelectedItem.Row.itemarray(1)
            OnSeleccion(New SeleccionadoEventArgs(seleccionado))
        Else
            primero = False
        End If
    End Sub

    Private Sub BuscaEstudiante_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not (DesignMode) Then ' The component is in run mode
            cargar()
        End If
    End Sub

   
    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged
        cargar()
        'Realizar la búsqueda según la columna
        If dv.Table.Columns(ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = ComboBox1.Text & " like '" & TextBox1.Text & "%'"
        Else
            If TextBox1.Text.Trim.Length > 0 Then
                filtro = ComboBox1.Text & " = " & TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
    End Sub
End Class

Public Class SeleccionadoEventArgs
    Inherits EventArgs

    Private ivalor As String

    Public Sub New(ByVal pval As String)
        ivalor = pval
    End Sub

    Public Property Valor() As String
        Get
            Return ivalor
        End Get
        Set(ByVal Value As String)
            ivalor = Value
        End Set
    End Property

End Class