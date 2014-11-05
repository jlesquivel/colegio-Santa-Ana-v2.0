<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvenios
     Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvenios))
        Dim COD_RECAUDADORLabel As System.Windows.Forms.Label
        Dim COD_CONVENIOLabel As System.Windows.Forms.Label
        Dim DSC_CONVENIOLabel As System.Windows.Forms.Label
        Dim COD_MONEDALabel As System.Windows.Forms.Label
        Dim CTA_BANCARIALabel As System.Windows.Forms.Label
        Dim COD_COMISIONLabel As System.Windows.Forms.Label
        Me.DataSet1 = New colegio.DataSet1
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConveniosTableAdapter = New colegio.DataSet1TableAdapters.conveniosTableAdapter
        Me.ConveniosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ConveniosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.COD_RECAUDADORTextBox = New System.Windows.Forms.TextBox
        Me.COD_CONVENIOTextBox = New System.Windows.Forms.TextBox
        Me.DSC_CONVENIOTextBox = New System.Windows.Forms.TextBox
        Me.COD_MONEDATextBox = New System.Windows.Forms.TextBox
        Me.CTA_BANCARIATextBox = New System.Windows.Forms.TextBox
        Me.COD_COMISIONTextBox = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        COD_RECAUDADORLabel = New System.Windows.Forms.Label
        COD_CONVENIOLabel = New System.Windows.Forms.Label
        DSC_CONVENIOLabel = New System.Windows.Forms.Label
        COD_MONEDALabel = New System.Windows.Forms.Label
        CTA_BANCARIALabel = New System.Windows.Forms.Label
        COD_COMISIONLabel = New System.Windows.Forms.Label
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConveniosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConveniosBindingSource
        '
        Me.ConveniosBindingSource.DataMember = "convenios"
        Me.ConveniosBindingSource.DataSource = Me.DataSet1
        '
        'ConveniosTableAdapter
        '
        Me.ConveniosTableAdapter.ClearBeforeFill = True
        '
        'ConveniosBindingNavigator
        '
        Me.ConveniosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConveniosBindingNavigator.BindingSource = Me.ConveniosBindingSource
        Me.ConveniosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConveniosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConveniosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConveniosBindingNavigatorSaveItem})
        Me.ConveniosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConveniosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConveniosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConveniosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConveniosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConveniosBindingNavigator.Name = "ConveniosBindingNavigator"
        Me.ConveniosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConveniosBindingNavigator.Size = New System.Drawing.Size(437, 25)
        Me.ConveniosBindingNavigator.TabIndex = 0
        Me.ConveniosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ConveniosBindingNavigatorSaveItem
        '
        Me.ConveniosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConveniosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConveniosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConveniosBindingNavigatorSaveItem.Name = "ConveniosBindingNavigatorSaveItem"
        Me.ConveniosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConveniosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'COD_RECAUDADORLabel
        '
        COD_RECAUDADORLabel.AutoSize = True
        COD_RECAUDADORLabel.Location = New System.Drawing.Point(128, 53)
        COD_RECAUDADORLabel.Name = "COD_RECAUDADORLabel"
        COD_RECAUDADORLabel.Size = New System.Drawing.Size(102, 13)
        COD_RECAUDADORLabel.TabIndex = 1
        COD_RECAUDADORLabel.Text = "Código Recaudador"
        COD_RECAUDADORLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'COD_RECAUDADORTextBox
        '
        Me.COD_RECAUDADORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "COD_RECAUDADOR", True))
        Me.COD_RECAUDADORTextBox.Location = New System.Drawing.Point(246, 50)
        Me.COD_RECAUDADORTextBox.Name = "COD_RECAUDADORTextBox"
        Me.COD_RECAUDADORTextBox.Size = New System.Drawing.Size(165, 20)
        Me.COD_RECAUDADORTextBox.TabIndex = 2
        '
        'COD_CONVENIOLabel
        '
        COD_CONVENIOLabel.AutoSize = True
        COD_CONVENIOLabel.Location = New System.Drawing.Point(143, 79)
        COD_CONVENIOLabel.Name = "COD_CONVENIOLabel"
        COD_CONVENIOLabel.Size = New System.Drawing.Size(87, 13)
        COD_CONVENIOLabel.TabIndex = 3
        COD_CONVENIOLabel.Text = "Código convenio"
        COD_CONVENIOLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'COD_CONVENIOTextBox
        '
        Me.COD_CONVENIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "COD_CONVENIO", True))
        Me.COD_CONVENIOTextBox.Location = New System.Drawing.Point(246, 76)
        Me.COD_CONVENIOTextBox.Name = "COD_CONVENIOTextBox"
        Me.COD_CONVENIOTextBox.Size = New System.Drawing.Size(165, 20)
        Me.COD_CONVENIOTextBox.TabIndex = 4
        '
        'DSC_CONVENIOLabel
        '
        DSC_CONVENIOLabel.AutoSize = True
        DSC_CONVENIOLabel.Location = New System.Drawing.Point(120, 105)
        DSC_CONVENIOLabel.Name = "DSC_CONVENIOLabel"
        DSC_CONVENIOLabel.Size = New System.Drawing.Size(110, 13)
        DSC_CONVENIOLabel.TabIndex = 5
        DSC_CONVENIOLabel.Text = "Descripción convenio"
        DSC_CONVENIOLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DSC_CONVENIOTextBox
        '
        Me.DSC_CONVENIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "DSC_CONVENIO", True))
        Me.DSC_CONVENIOTextBox.Location = New System.Drawing.Point(246, 102)
        Me.DSC_CONVENIOTextBox.Name = "DSC_CONVENIOTextBox"
        Me.DSC_CONVENIOTextBox.Size = New System.Drawing.Size(165, 20)
        Me.DSC_CONVENIOTextBox.TabIndex = 6
        '
        'COD_MONEDALabel
        '
        COD_MONEDALabel.AutoSize = True
        COD_MONEDALabel.Location = New System.Drawing.Point(148, 131)
        COD_MONEDALabel.Name = "COD_MONEDALabel"
        COD_MONEDALabel.Size = New System.Drawing.Size(82, 13)
        COD_MONEDALabel.TabIndex = 7
        COD_MONEDALabel.Text = "Código Moneda"
        COD_MONEDALabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'COD_MONEDATextBox
        '
        Me.COD_MONEDATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "COD_MONEDA", True))
        Me.COD_MONEDATextBox.Location = New System.Drawing.Point(246, 128)
        Me.COD_MONEDATextBox.Name = "COD_MONEDATextBox"
        Me.COD_MONEDATextBox.Size = New System.Drawing.Size(165, 20)
        Me.COD_MONEDATextBox.TabIndex = 8
        '
        'CTA_BANCARIALabel
        '
        CTA_BANCARIALabel.AutoSize = True
        CTA_BANCARIALabel.Location = New System.Drawing.Point(145, 157)
        CTA_BANCARIALabel.Name = "CTA_BANCARIALabel"
        CTA_BANCARIALabel.Size = New System.Drawing.Size(85, 13)
        CTA_BANCARIALabel.TabIndex = 9
        CTA_BANCARIALabel.Text = "Cuenta bancaria"
        CTA_BANCARIALabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CTA_BANCARIATextBox
        '
        Me.CTA_BANCARIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "CTA_BANCARIA", True))
        Me.CTA_BANCARIATextBox.Location = New System.Drawing.Point(246, 154)
        Me.CTA_BANCARIATextBox.Name = "CTA_BANCARIATextBox"
        Me.CTA_BANCARIATextBox.Size = New System.Drawing.Size(165, 20)
        Me.CTA_BANCARIATextBox.TabIndex = 10
        '
        'COD_COMISIONLabel
        '
        COD_COMISIONLabel.AutoSize = True
        COD_COMISIONLabel.Location = New System.Drawing.Point(146, 183)
        COD_COMISIONLabel.Name = "COD_COMISIONLabel"
        COD_COMISIONLabel.Size = New System.Drawing.Size(84, 13)
        COD_COMISIONLabel.TabIndex = 11
        COD_COMISIONLabel.Text = "Código comisión"
        COD_COMISIONLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'COD_COMISIONTextBox
        '
        Me.COD_COMISIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveniosBindingSource, "COD_COMISION", True))
        Me.COD_COMISIONTextBox.Location = New System.Drawing.Point(246, 180)
        Me.COD_COMISIONTextBox.Name = "COD_COMISIONTextBox"
        Me.COD_COMISIONTextBox.Size = New System.Drawing.Size(165, 20)
        Me.COD_COMISIONTextBox.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ConveniosBindingSource
        Me.ListBox1.DisplayMember = "COD_CONVENIO"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(93, 160)
        Me.ListBox1.TabIndex = 13
        '
        'frmConvenios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 245)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(COD_RECAUDADORLabel)
        Me.Controls.Add(Me.COD_RECAUDADORTextBox)
        Me.Controls.Add(COD_CONVENIOLabel)
        Me.Controls.Add(Me.COD_CONVENIOTextBox)
        Me.Controls.Add(DSC_CONVENIOLabel)
        Me.Controls.Add(Me.DSC_CONVENIOTextBox)
        Me.Controls.Add(COD_MONEDALabel)
        Me.Controls.Add(Me.COD_MONEDATextBox)
        Me.Controls.Add(CTA_BANCARIALabel)
        Me.Controls.Add(Me.CTA_BANCARIATextBox)
        Me.Controls.Add(COD_COMISIONLabel)
        Me.Controls.Add(Me.COD_COMISIONTextBox)
        Me.Controls.Add(Me.ConveniosBindingNavigator)
        Me.Name = "frmConvenios"
        Me.Text = "Convenios"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConveniosBindingNavigator.ResumeLayout(False)
        Me.ConveniosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As colegio.DataSet1
    Friend WithEvents ConveniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConveniosTableAdapter As colegio.DataSet1TableAdapters.conveniosTableAdapter
    Friend WithEvents ConveniosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ConveniosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents COD_RECAUDADORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COD_CONVENIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DSC_CONVENIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COD_MONEDATextBox As System.Windows.Forms.TextBox
    Friend WithEvents CTA_BANCARIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents COD_COMISIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
