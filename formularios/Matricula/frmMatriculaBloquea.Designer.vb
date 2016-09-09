<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatriculaBloquea
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Bloqueados_verDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id_mat_bloq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bloqueados_verBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New colegio.DataSet2()
        Me.Matricula_bloqueadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Matricula_bloqueadosTableAdapter = New colegio.DataSet2TableAdapters.matricula_bloqueadosTableAdapter()
        Me.Bloqueados_verTableAdapter = New colegio.DataSet2TableAdapters.bloqueados_verTableAdapter()
        Me.BuscaEstud1 = New colegio.BuscaEstud()
        CType(Me.Bloqueados_verDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bloqueados_verBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Matricula_bloqueadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(274, 33)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(225, 38)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Bloquear matricula"
        Me.ButtonX1.TextColor = System.Drawing.Color.AliceBlue
        '
        'Bloqueados_verDataGridViewX
        '
        Me.Bloqueados_verDataGridViewX.AllowUserToAddRows = False
        Me.Bloqueados_verDataGridViewX.AllowUserToDeleteRows = False
        Me.Bloqueados_verDataGridViewX.AllowUserToResizeColumns = False
        Me.Bloqueados_verDataGridViewX.AllowUserToResizeRows = False
        Me.Bloqueados_verDataGridViewX.AutoGenerateColumns = False
        Me.Bloqueados_verDataGridViewX.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bloqueados_verDataGridViewX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bloqueados_verDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Bloqueados_verDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_mat_bloq, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Bloqueados_verDataGridViewX.DataSource = Me.Bloqueados_verBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Bloqueados_verDataGridViewX.DefaultCellStyle = DataGridViewCellStyle1
        Me.Bloqueados_verDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Bloqueados_verDataGridViewX.Location = New System.Drawing.Point(274, 77)
        Me.Bloqueados_verDataGridViewX.Name = "Bloqueados_verDataGridViewX"
        Me.Bloqueados_verDataGridViewX.Size = New System.Drawing.Size(582, 402)
        Me.Bloqueados_verDataGridViewX.TabIndex = 2
        '
        'id_mat_bloq
        '
        Me.id_mat_bloq.DataPropertyName = "id_mat_bloq"
        Me.id_mat_bloq.HeaderText = "id_mat_bloq"
        Me.id_mat_bloq.Name = "id_mat_bloq"
        Me.id_mat_bloq.ReadOnly = True
        Me.id_mat_bloq.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "carnet"
        Me.DataGridViewTextBoxColumn4.HeaderText = "carnet"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "apellido1"
        Me.DataGridViewTextBoxColumn1.HeaderText = "apellido1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "apellido2"
        Me.DataGridViewTextBoxColumn2.HeaderText = "apellido2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Comentario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Comentario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha_bloqueo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha_bloqueo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Bloqueados_verBindingSource
        '
        Me.Bloqueados_verBindingSource.DataMember = "bloqueados_ver"
        Me.Bloqueados_verBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Matricula_bloqueadosBindingSource
        '
        Me.Matricula_bloqueadosBindingSource.DataMember = "matricula_bloqueados"
        Me.Matricula_bloqueadosBindingSource.DataSource = Me.DataSet2
        '
        'Matricula_bloqueadosTableAdapter
        '
        Me.Matricula_bloqueadosTableAdapter.ClearBeforeFill = True
        '
        'Bloqueados_verTableAdapter
        '
        Me.Bloqueados_verTableAdapter.ClearBeforeFill = True
        '
        'BuscaEstud1
        '
        Me.BuscaEstud1.BackColor = System.Drawing.SystemColors.Control
        Me.BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        Me.BuscaEstud1.Name = "BuscaEstud1"
        Me.BuscaEstud1.Size = New System.Drawing.Size(246, 491)
        Me.BuscaEstud1.TabIndex = 0
        '
        'frmMatriculaBloquea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 491)
        Me.Controls.Add(Me.Bloqueados_verDataGridViewX)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.BuscaEstud1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMatriculaBloquea"
        Me.Text = "Matricula Denegada"
        CType(Me.Bloqueados_verDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bloqueados_verBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Matricula_bloqueadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BuscaEstud1 As BuscaEstud
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents Matricula_bloqueadosBindingSource As BindingSource
    Friend WithEvents Matricula_bloqueadosTableAdapter As DataSet2TableAdapters.matricula_bloqueadosTableAdapter
    Friend WithEvents Matricula_bloqueadosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Matricula_bloqueadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Bloqueados_verBindingSource As BindingSource
    Friend WithEvents Bloqueados_verTableAdapter As DataSet2TableAdapters.bloqueados_verTableAdapter
    Friend WithEvents Bloqueados_verDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents id_mat_bloq As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
