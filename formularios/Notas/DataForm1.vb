Public Class DataForm1
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objdsMaterias As colegio.dsMaterias
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblmateria As System.Windows.Forms.Label
    Friend WithEvents editmateria As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents editnombre As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objdsMaterias = New colegio.dsMaterias
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lblmateria = New System.Windows.Forms.Label
        Me.editmateria = New System.Windows.Forms.TextBox
        Me.lblnombre = New System.Windows.Forms.Label
        Me.editnombre = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.objdsMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT materia, nombre FROM materia"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO materia(materia, nombre) VALUES (?, ?); SELECT materia, nombre FROM m" & _
        "ateria WHERE (materia = ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("materia", System.Data.OleDb.OleDbType.VarChar, 15, "materia"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nombre", System.Data.OleDb.OleDbType.VarChar, 30, "nombre"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_materia", System.Data.OleDb.OleDbType.VarChar, 15, "materia"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE materia SET materia = ?, nombre = ? WHERE (materia = ?) AND (nombre = ? OR" & _
        " ? IS NULL AND nombre IS NULL); SELECT materia, nombre FROM materia WHERE (mater" & _
        "ia = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("materia", System.Data.OleDb.OleDbType.VarChar, 15, "materia"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("nombre", System.Data.OleDb.OleDbType.VarChar, 30, "nombre"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_materia", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nombre", System.Data.OleDb.OleDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nombre1", System.Data.OleDb.OleDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Select_materia", System.Data.OleDb.OleDbType.VarChar, 15, "materia"))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM materia WHERE (materia = ?) AND (nombre = ? OR ? IS NULL AND nombre I" & _
        "S NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_materia", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nombre", System.Data.OleDb.OleDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_nombre1", System.Data.OleDb.OleDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Integrated Security=SSPI;Packet Size=4096;Data Source=escritorio;Tag with column " & _
        "collation when possible=False;Initial Catalog=colegio;Use Procedure for Prepare=" & _
        "1;Auto Translate=True;Persist Security Info=False;Provider=""SQLOLEDB.1"";Workstat" & _
        "ion ID=ESCRITORIO;Use Encryption for Data=False"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objdsMaterias
        '
        Me.objdsMaterias.DataSetName = "dsMaterias"
        Me.objdsMaterias.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(106, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Carga&r"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(334, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Act&ualizar"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(334, 43)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Size = New System.Drawing.Size(106, 23)
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncelar todo"
        '
        'lblmateria
        '
        Me.lblmateria.Location = New System.Drawing.Point(10, 76)
        Me.lblmateria.Name = "lblmateria"
        Me.lblmateria.TabIndex = 3
        Me.lblmateria.Text = "materia"
        '
        'editmateria
        '
        Me.editmateria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsMaterias, "materia.materia"))
        Me.editmateria.Location = New System.Drawing.Point(120, 76)
        Me.editmateria.Name = "editmateria"
        Me.editmateria.TabIndex = 4
        Me.editmateria.Text = ""
        '
        'lblnombre
        '
        Me.lblnombre.Location = New System.Drawing.Point(230, 76)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "nombre"
        '
        'editnombre
        '
        Me.editnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsMaterias, "materia.nombre"))
        Me.editnombre.Location = New System.Drawing.Point(340, 76)
        Me.editnombre.Name = "editnombre"
        Me.editnombre.TabIndex = 6
        Me.editnombre.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(195, 109)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 7
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(235, 109)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 8
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(270, 109)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 9
        Me.lblNavLocation.Text = "Sin registros"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(365, 109)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 10
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(400, 109)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 11
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 142)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "&Agregar"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(280, 142)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Eliminar"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancelar"
        '
        'DataForm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(442, 214)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lblmateria)
        Me.Controls.Add(Me.editmateria)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.editnombre)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "DataForm1"
        Me.Text = "DataForm1"
        CType(Me.objdsMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdsMaterias, "materia").CancelCurrentEdit()
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdsMaterias, "materia").Count > 0) Then
            Me.BindingContext(objdsMaterias, "materia").RemoveAt(Me.BindingContext(objdsMaterias, "materia").Position)
            Me.objdsMaterias_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Borrar las ediciones actuales
            Me.BindingContext(objdsMaterias, "materia").EndCurrentEdit()
            Me.BindingContext(objdsMaterias, "materia").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Intente actualizar el origen de datos.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Agregar aquí el código de control de errores.
            'Mostrar mensaje de error, si hay alguno.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            'Intente cargar el conjunto de datos.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Agregar aquí el código de control de errores.
            'Mostrar mensaje de error, si hay alguno.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdsMaterias, "materia").Position = 0
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdsMaterias, "materia").Position = (Me.objdsMaterias.Tables("materia").Rows.Count - 1)
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdsMaterias, "materia").Position = (Me.BindingContext(objdsMaterias, "materia").Position - 1)
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdsMaterias, "materia").Position = (Me.BindingContext(objdsMaterias, "materia").Position + 1)
        Me.objdsMaterias_PositionChanged()

    End Sub
    Private Sub objdsMaterias_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdsMaterias, "materia").Position + 1).ToString + " de  ") _
                    + Me.BindingContext(objdsMaterias, "materia").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdsMaterias.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
        Dim objDataSetChanges As colegio.dsMaterias = New colegio.dsMaterias
        'Detener las ediciones actuales.
        Me.BindingContext(objdsMaterias, "materia").EndCurrentEdit()
        'Obtener los cambios realizados en el conjunto de datos principal.
        objDataSetChanges = CType(objdsMaterias.GetChanges, colegio.dsMaterias)
        'Comprobar si se han realizado cambios.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                'llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                Me.UpdateDataSource(objDataSetChanges)
                objdsMaterias.Merge(objDataSetChanges)
                objdsMaterias.AcceptChanges()
            Catch eUpdate As System.Exception
                'Agregar aquí el código de control de errores.
                Throw eUpdate
            End Try
            'Agregar código para comprobar en el conjunto de datos devuelto los errores que se puedan haber
            'introducido en el error del objeto de fila.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Crear un conjunto de datos para alojar los registros devueltos de la llamada a FillDataSet.
        'Se utiliza un conjunto de datos temporal porque el relleno del conjunto de datos existente
        'requeriría que se volvieran a enlazar los enlaces de datos.
        Dim objDataSetTemp As colegio.dsMaterias
        objDataSetTemp = New colegio.dsMaterias
        Try
            'Intente rellenar el conjunto de datos temporal.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Agregar aquí el código de control de errores.
            Throw eFillDataSet
        End Try
        Try
            'Vaciar los registros obsoletos del conjunto de datos.
            objdsMaterias.Clear()
            'Combinar los registros en el conjunto de datos principal.
            objdsMaterias.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Agregar aquí el código de control de errores.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As colegio.dsMaterias)
        Try
            'Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
            If (Not (ChangedRows) Is Nothing) Then
                'Abra la conexión.
                Me.OleDbConnection1.Open()
                'Intente actualizar el origen de datos.
                OleDbDataAdapter1.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Agregar aquí el código de control de errores.
            Throw updateException
        Finally
            'Cerrar la conexión independientemente de si se inició una excepción o no.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As colegio.dsMaterias)
        'Desactive la comprobación de restricciones antes de rellenar el conjunto de datos.
        'De esta forma los adaptadores pueden rellenar el conjunto de datos sin preocuparse
        'de las dependencias entre las tablas.
        dataSet.EnforceConstraints = False
        Try
            'Abra la conexión.
            Me.OleDbConnection1.Open()
            'Intente rellenar el conjunto de datos a través de OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
        Catch fillException As System.Exception
            'Agregar aquí el código de control de errores.
            Throw fillException
        Finally
            'Volver a activar la comprobación de restricciones.
            dataSet.EnforceConstraints = True
            'Cerrar la conexión independientemente de si se inició una excepción o no.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
End Class
