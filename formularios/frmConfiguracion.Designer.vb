<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
     Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.ColegioDataSet = New colegio.colegioDataSet
        Me.ValoresConfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValoresConfiguracionTableAdapter = New colegio.colegioDataSetTableAdapters.ValoresConfiguracionTableAdapter
        Me.ValoresConfiguracionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ValoresConfiguracionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ValoresConfiguracionDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValoresConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValoresConfiguracionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ValoresConfiguracionBindingNavigator.SuspendLayout()
        CType(Me.ValoresConfiguracionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColegioDataSet
        '
        Me.ColegioDataSet.DataSetName = "colegioDataSet"
        Me.ColegioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ValoresConfiguracionBindingSource
        '
        Me.ValoresConfiguracionBindingSource.DataMember = "ValoresConfiguracion"
        Me.ValoresConfiguracionBindingSource.DataSource = Me.ColegioDataSet
        '
        'ValoresConfiguracionTableAdapter
        '
        Me.ValoresConfiguracionTableAdapter.ClearBeforeFill = True
        '
        'ValoresConfiguracionBindingNavigator
        '
        Me.ValoresConfiguracionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ValoresConfiguracionBindingNavigator.BindingSource = Me.ValoresConfiguracionBindingSource
        Me.ValoresConfiguracionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ValoresConfiguracionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ValoresConfiguracionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ValoresConfiguracionBindingNavigatorSaveItem})
        Me.ValoresConfiguracionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ValoresConfiguracionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ValoresConfiguracionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ValoresConfiguracionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ValoresConfiguracionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ValoresConfiguracionBindingNavigator.Name = "ValoresConfiguracionBindingNavigator"
        Me.ValoresConfiguracionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ValoresConfiguracionBindingNavigator.Size = New System.Drawing.Size(496, 25)
        Me.ValoresConfiguracionBindingNavigator.TabIndex = 0
        Me.ValoresConfiguracionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ValoresConfiguracionBindingNavigatorSaveItem
        '
        Me.ValoresConfiguracionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ValoresConfiguracionBindingNavigatorSaveItem.Image = CType(resources.GetObject("ValoresConfiguracionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ValoresConfiguracionBindingNavigatorSaveItem.Name = "ValoresConfiguracionBindingNavigatorSaveItem"
        Me.ValoresConfiguracionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ValoresConfiguracionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ValoresConfiguracionDataGridView
        '
        Me.ValoresConfiguracionDataGridView.AutoGenerateColumns = False
        Me.ValoresConfiguracionDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ValoresConfiguracionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ValoresConfiguracionDataGridView.DataSource = Me.ValoresConfiguracionBindingSource
        Me.ValoresConfiguracionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValoresConfiguracionDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ValoresConfiguracionDataGridView.Name = "ValoresConfiguracionDataGridView"
        Me.ValoresConfiguracionDataGridView.RowHeadersWidth = 21
        Me.ValoresConfiguracionDataGridView.Size = New System.Drawing.Size(496, 344)
        Me.ValoresConfiguracionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "llave"
        Me.DataGridViewTextBoxColumn1.HeaderText = "llave"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 369)
        Me.Controls.Add(Me.ValoresConfiguracionDataGridView)
        Me.Controls.Add(Me.ValoresConfiguracionBindingNavigator)
        Me.Name = "frmConfiguracion"
        Me.Text = "Configuracion"
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValoresConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValoresConfiguracionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ValoresConfiguracionBindingNavigator.ResumeLayout(False)
        Me.ValoresConfiguracionBindingNavigator.PerformLayout()
        CType(Me.ValoresConfiguracionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColegioDataSet As colegio.colegioDataSet
    Friend WithEvents ValoresConfiguracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValoresConfiguracionTableAdapter As colegio.colegioDataSetTableAdapters.ValoresConfiguracionTableAdapter
    Friend WithEvents ValoresConfiguracionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ValoresConfiguracionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ValoresConfiguracionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
