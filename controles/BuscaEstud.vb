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
    Dim conn As conexionSQL

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
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        TextBox1 = New System.Windows.Forms.TextBox()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        ListBox1 = New System.Windows.Forms.ListBox()
        Panel1 = New System.Windows.Forms.Panel()
        SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(7, 27)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 16)
        Label2.TabIndex = 3
        Label2.Text = "Valor"
        Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(7, 4)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 16)
        Label1.TabIndex = 2
        Label1.Text = "Campo"
        Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        TextBox1.Location = New System.Drawing.Point(55, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(96, 20)
        TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        ComboBox1.Location = New System.Drawing.Point(55, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(112, 21)
        ComboBox1.TabIndex = 1
        '
        'ListBox1
        '
        ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        ListBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListBox1.ItemHeight = 15
        ListBox1.Location = New System.Drawing.Point(0, 74)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New System.Drawing.Size(181, 300)
        ListBox1.TabIndex = 4
        '
        'Panel1
        '
        Panel1.Controls.Add(SwitchButton1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(181, 74)
        Panel1.TabIndex = 2
        '
        'SwitchButton1
        '
        '
        '
        '
        SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        SwitchButton1.Location = New System.Drawing.Point(55, 51)
        SwitchButton1.Name = "SwitchButton1"
        SwitchButton1.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        SwitchButton1.OffText = "Matriculados"
        SwitchButton1.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        SwitchButton1.OnText = "Todos"
        SwitchButton1.OnTextColor = System.Drawing.Color.Black
        SwitchButton1.Size = New System.Drawing.Size(96, 22)
        SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        SwitchButton1.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        SwitchButton1.SwitchWidth = 20
        SwitchButton1.TabIndex = 4
        '
        'BuscaEstud
        '
        BackColor = System.Drawing.SystemColors.Control
        Controls.Add(ListBox1)
        Controls.Add(Panel1)
        Name = "BuscaEstud"
        Size = New System.Drawing.Size(181, 374)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

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

            tabla = IIf(SwitchButton1.Value, tabla_todos, tabla_activos)

            Dim conexion As New SqlConnection
            conexion = conn.conexion

            If Not (conexion Is Nothing) Then

                conexion = conn.conexion

                Dim ds As New DataSet             'Definimos el dataset y el dataadapter
                Dim da As New SqlDataAdapter("select " & campos & " from " & tabla & _
                    IIf(orden.Length > 0, " order by " & orden, ""), conexion)

                da.SelectCommand.Connection.ConnectionString = conn.strConn

                'Llenamos al dataset con el resultado de la consulta
                da.Fill(ds)
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
        If Not primero Or ListBox1.SelectedItem IsNot Nothing Then
            seleccionado = ListBox1.SelectedValue
            nombre = ListBox1.SelectedItem.Row.itemarray(1)
            OnSeleccion(New SeleccionadoEventArgs(seleccionado))
        Else
            primero = False
        End If
    End Sub

    Private Sub BuscaEstudiante_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not (DesignMode) Then ' The component is in run mode
            conn = New conexionSQL
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