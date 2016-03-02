Imports System.Data.SqlClient
Imports SteepValley.Windows.Forms.ThemedControls

Public Class BuscaEstudiante
    Inherits System.Windows.Forms.UserControl

    Private tabla As String = "estudiantes"
    Private campos As String = "carnet, apellido1 +' '+ apellido2 +' '+ nombre  as nombres"
    Private orden As String = "nombres"
    Dim filtro As String
    Dim comboIndex As Integer = 1
    Dim dv As DataView
    Public seleccionado As String
    Dim conn1 As New conexionSQL
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
    Friend WithEvents XpTaskPanel1 As SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
    Friend WithEvents XpTaskBox1 As SteepValley.Windows.Forms.ThemedControls.XPTaskBox
    Friend WithEvents XpTaskBox2 As SteepValley.Windows.Forms.ThemedControls.XPTaskBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BuscaEstudiante))
        Me.XpTaskPanel1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
        Me.XpTaskBox2 = New SteepValley.Windows.Forms.ThemedControls.XPTaskBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.XpTaskBox1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.XpTaskPanel1.SuspendLayout()
        Me.XpTaskBox2.SuspendLayout()
        Me.XpTaskBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpTaskPanel1
        '
        Me.XpTaskPanel1.AutoScroll = True
        Me.XpTaskPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskPanel1.Controls.Add(Me.XpTaskBox2)
        Me.XpTaskPanel1.Controls.Add(Me.XpTaskBox1)
        Me.XpTaskPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpTaskPanel1.DockPadding.Bottom = 8
        Me.XpTaskPanel1.DockPadding.Left = 8
        Me.XpTaskPanel1.DockPadding.Right = 8
        Me.XpTaskPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpTaskPanel1.Name = "XpTaskPanel1"
        Me.XpTaskPanel1.Size = New System.Drawing.Size(184, 264)
        Me.XpTaskPanel1.TabIndex = 0
        Me.XpTaskPanel1.Theme = SteepValley.Windows.Forms.ThemedControls.ThemeStyle.Unthemed
        Me.XpTaskPanel1.ThemeFormat.BottomColor = System.Drawing.SystemColors.ControlLight
        Me.XpTaskPanel1.ThemeFormat.TopColor = System.Drawing.SystemColors.ControlLight
        '
        'XpTaskBox2
        '
        Me.XpTaskBox2.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskBox2.Controls.Add(Me.ListBox1)
        Me.XpTaskBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpTaskBox2.DockPadding.Bottom = 4
        Me.XpTaskBox2.DockPadding.Left = 4
        Me.XpTaskBox2.DockPadding.Right = 4
        Me.XpTaskBox2.DockPadding.Top = 44
        Me.XpTaskBox2.HeaderText = "Resultado"
        Me.XpTaskBox2.Icon = CType(resources.GetObject("XpTaskBox2.Icon"), System.Drawing.Icon)
        Me.XpTaskBox2.Location = New System.Drawing.Point(8, 88)
        Me.XpTaskBox2.Name = "XpTaskBox2"
        Me.XpTaskBox2.Size = New System.Drawing.Size(168, 168)
        Me.XpTaskBox2.TabIndex = 1
        Me.XpTaskBox2.Theme = SteepValley.Windows.Forms.ThemedControls.ThemeStyle.Unthemed
        Me.XpTaskBox2.ThemeFormat.BodyColor = System.Drawing.SystemColors.ControlLightLight
        Me.XpTaskBox2.ThemeFormat.BodyFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.XpTaskBox2.ThemeFormat.BodyTextColor = System.Drawing.SystemColors.WindowText
        Me.XpTaskBox2.ThemeFormat.BorderColor = System.Drawing.Color.White
        Me.XpTaskBox2.ThemeFormat.ChevronDown = CType(resources.GetObject("resource.ChevronDown"), System.Drawing.Bitmap)
        Me.XpTaskBox2.ThemeFormat.ChevronDownHighlight = CType(resources.GetObject("resource.ChevronDownHighlight"), System.Drawing.Bitmap)
        Me.XpTaskBox2.ThemeFormat.ChevronUp = CType(resources.GetObject("resource.ChevronUp"), System.Drawing.Bitmap)
        Me.XpTaskBox2.ThemeFormat.ChevronUpHighlight = CType(resources.GetObject("resource.ChevronUpHighlight"), System.Drawing.Bitmap)
        Me.XpTaskBox2.ThemeFormat.HeaderFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.XpTaskBox2.ThemeFormat.HeaderTextColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.XpTaskBox2.ThemeFormat.HeaderTextHighlightColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XpTaskBox2.ThemeFormat.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption
        Me.XpTaskBox2.ThemeFormat.RightHeaderColor = System.Drawing.SystemColors.InactiveCaption
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(4, 44)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(160, 116)
        Me.ListBox1.TabIndex = 0
        '
        'XpTaskBox1
        '
        Me.XpTaskBox1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskBox1.Controls.Add(Me.Label2)
        Me.XpTaskBox1.Controls.Add(Me.Label1)
        Me.XpTaskBox1.Controls.Add(Me.TextBox1)
        Me.XpTaskBox1.Controls.Add(Me.ComboBox1)
        Me.XpTaskBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpTaskBox1.DockPadding.Bottom = 4
        Me.XpTaskBox1.DockPadding.Left = 4
        Me.XpTaskBox1.DockPadding.Right = 4
        Me.XpTaskBox1.DockPadding.Top = 44
        Me.XpTaskBox1.HeaderText = "Búsqueda"
        Me.XpTaskBox1.Icon = CType(resources.GetObject("XpTaskBox1.Icon"), System.Drawing.Icon)
        Me.XpTaskBox1.Location = New System.Drawing.Point(8, 0)
        Me.XpTaskBox1.Name = "XpTaskBox1"
        Me.XpTaskBox1.Size = New System.Drawing.Size(168, 88)
        Me.XpTaskBox1.TabIndex = 0
        Me.XpTaskBox1.Theme = SteepValley.Windows.Forms.ThemedControls.ThemeStyle.Unthemed
        Me.XpTaskBox1.ThemeFormat.BodyColor = System.Drawing.SystemColors.ControlLightLight
        Me.XpTaskBox1.ThemeFormat.BodyFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.XpTaskBox1.ThemeFormat.BodyTextColor = System.Drawing.SystemColors.WindowText
        Me.XpTaskBox1.ThemeFormat.BorderColor = System.Drawing.Color.White
        Me.XpTaskBox1.ThemeFormat.ChevronDown = CType(resources.GetObject("resource.ChevronDown1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronDownHighlight = CType(resources.GetObject("resource.ChevronDownHighlight1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronUp = CType(resources.GetObject("resource.ChevronUp1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronUpHighlight = CType(resources.GetObject("resource.ChevronUpHighlight1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.HeaderFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.XpTaskBox1.ThemeFormat.HeaderTextColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.XpTaskBox1.ThemeFormat.HeaderTextHighlightColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.XpTaskBox1.ThemeFormat.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption
        Me.XpTaskBox1.ThemeFormat.RightHeaderColor = System.Drawing.SystemColors.InactiveCaption
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Campo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(48, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'BuscaEstudiante
        '
        Me.Controls.Add(Me.XpTaskPanel1)
        Me.Name = "BuscaEstudiante"
        Me.Size = New System.Drawing.Size(184, 264)
        Me.XpTaskPanel1.ResumeLayout(False)
        Me.XpTaskBox2.ResumeLayout(False)
        Me.XpTaskBox1.ResumeLayout(False)
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
        Dim conexion As New SqlConnection
        conexion = conn1.conexion
        conexion.ConnectionString = conn1.strConn

        conexion.Open()

        Dim ds As New DataSet             'Definimos el dataset y el dataadapter
        Dim da As New SqlDataAdapter("select " & campos & " from " & tabla & _
            IIf(orden.Length > 0, " order by " & orden, ""), conexion)

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
        conexion.Close()
        dv.RowFilter = Me.ComboBox1.Text & " like '" & Me.TextBox1.Text & "%'"
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
        Try

            seleccionado = ListBox1.SelectedValue
            Dim ventana As Object = Me.Parent ' Me.ParentForm
            ventana.buscar(seleccionado)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BuscaEstudiante_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub
End Class
