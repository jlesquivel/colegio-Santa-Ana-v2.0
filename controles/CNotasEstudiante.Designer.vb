<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CNotasEstudiante
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer


    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColegioDataSet = New colegio.colegioDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MatriculaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculaTableAdapter = New colegio.colegioDataSetTableAdapters.matriculaTableAdapter
        Me.NotasTableAdapter = New colegio.colegioDataSetTableAdapters.notasTableAdapter
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nota = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(139, 190)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(289, 54)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.periodo, Me.NombreDataGridViewTextBoxColumn, Me.nota})
        Me.DataGridView1.DataSource = Me.NotasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(139, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(289, 151)
        Me.DataGridView1.TabIndex = 2
        '
        'NotasBindingSource
        '
        Me.NotasBindingSource.DataMember = "notas"
        Me.NotasBindingSource.DataSource = Me.ColegioDataSet
        '
        'ColegioDataSet
        '
        Me.ColegioDataSet.DataSetName = "colegioDataSet"
        Me.ColegioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Comentario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Años"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Notas"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnoDataGridViewTextBoxColumn, Me.NivelDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView2.DataSource = Me.MatriculaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(14, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 21
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(115, 220)
        Me.DataGridView2.TabIndex = 6
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "ano"
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        Me.AnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnoDataGridViewTextBoxColumn.Width = 40
        '
        'NivelDataGridViewTextBoxColumn
        '
        Me.NivelDataGridViewTextBoxColumn.DataPropertyName = "nivel"
        Me.NivelDataGridViewTextBoxColumn.HeaderText = "nivel"
        Me.NivelDataGridViewTextBoxColumn.Name = "NivelDataGridViewTextBoxColumn"
        Me.NivelDataGridViewTextBoxColumn.ReadOnly = True
        Me.NivelDataGridViewTextBoxColumn.Width = 35
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrupoDataGridViewTextBoxColumn.Width = 35
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_mat"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'MatriculaBindingSource
        '
        Me.MatriculaBindingSource.DataMember = "matricula"
        Me.MatriculaBindingSource.DataSource = Me.ColegioDataSet
        '
        'MatriculaTableAdapter
        '
        Me.MatriculaTableAdapter.ClearBeforeFill = True
        '
        'NotasTableAdapter
        '
        Me.NotasTableAdapter.ClearBeforeFill = True
        '
        'periodo
        '
        Me.periodo.DataPropertyName = "periodo"
        Me.periodo.HeaderText = "periodo"
        Me.periodo.Name = "periodo"
        Me.periodo.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'nota
        '
        Me.nota.DataPropertyName = "nota"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.nota.DefaultCellStyle = DataGridViewCellStyle1
        Me.nota.HeaderText = "nota"
        Me.nota.Name = "nota"
        Me.nota.Width = 80
        '
        'CNotasEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "CNotasEstudiante"
        Me.Size = New System.Drawing.Size(448, 251)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MatriculaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColegioDataSet As colegio.colegioDataSet
    Friend WithEvents MatriculaTableAdapter As colegio.colegioDataSetTableAdapters.matriculaTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NotasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasTableAdapter As colegio.colegioDataSetTableAdapters.notasTableAdapter
    Friend WithEvents AnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nota As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
