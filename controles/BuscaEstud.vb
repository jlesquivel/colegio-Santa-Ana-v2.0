Imports System.Data.SqlClient

Public Class BuscaEstud
    Inherits System.Windows.Forms.UserControl

    Private tabla As String = "estudiantes"
    Private campos As String = "carnet, apellido1 +' '+ apellido2 +' '+ nombre  as nombres"
    Private orden As String = "nombres"
    Dim filtro As String
    Dim comboIndex As Integer = 1
    Dim dv As DataView
    Public seleccionado As String
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Dim primero As Boolean = True


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
        Me.TextBox1.Location = New System.Drawing.Point(55, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
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
        Me.ListBox1.Location = New System.Drawing.Point(0, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(181, 320)
        Me.ListBox1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 54)
        Me.Panel1.TabIndex = 2
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
        If dv.Table.Columns(Me.ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = Me.ComboBox1.Text & " like '" & Me.TextBox1.Text & "%'"
        Else
            If Me.TextBox1.Text.Trim.Length > 0 Then
                filtro = Me.ComboBox1.Text & " = " & Me.TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
    End Sub

    Sub cargar()
        'Parámetros para la consulta
        Dim conn As New conexionSQL

        If conn.conexionOK Then
            Dim ds As New DataSet             'Definimos el dataset y el dataadapter

            Dim someCommand As New SqlCommand()
            If orden.Length > 0 Then
                someCommand.CommandText = "SELECT carnet, apellido1 +' '+ apellido2 +' '+ nombre  as nombres FROM estudiantes order by nombres"
            Else
                someCommand.CommandText = "SELECT carnet, apellido1 +' '+ apellido2 +' '+ nombre  as nombres FROM estudiantes"
            End If
            'Dim da As New SqlDataAdapter("select " & campos & " from " & tabla & _
            '    IIf(orden.Length > 0, " order by " & orden, ""), conexion)

            Dim da As New SqlDataAdapter(someCommand.CommandText, conn.conexion)

            'Llenamos al dataset con el resultado de la consulta
            da.Fill(ds)
            'Asignamos la tabla que utiliza el dataview
            dv = ds.Tables(0).DefaultView

            Me.ListBox1.DisplayMember = "nombres"
            Me.ListBox1.ValueMember = "carnet"
            Me.ListBox1.DataSource = dv

            'Llenamos el combo con el listado de campos
            Me.ComboBox1.Items.Clear()
            Dim c As DataColumn
            For Each c In ds.Tables(0).Columns
                Me.ComboBox1.Items.Add(c.ColumnName)
            Next

            Me.ComboBox1.SelectedIndex = comboIndex 'Asignar el primer elemento como seleccionado

            'dv.RowFilter = Me.ComboBox1.Text & " like '" & Me.TextBox1.Text & "%'"
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If dv.Table.Columns(Me.ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = Me.ComboBox1.Text & " like '" & Me.TextBox1.Text & "%'"
        Else
            If Me.TextBox1.Text.Trim.Length > 0 Then
                filtro = Me.ComboBox1.Text & " = " & Me.TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
        comboIndex = ComboBox1.SelectedIndex
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not primero Then
            seleccionado = ListBox1.SelectedValue
            OnSeleccion(New SeleccionadoEventArgs(seleccionado))
        Else
            primero = False
        End If

    End Sub

    Private Sub BuscaEstudiante_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not (Me.DesignMode) Then ' The component is in run mode
            cargar()
        End If
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