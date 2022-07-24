<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim SesionLabel As System.Windows.Forms.Label
        Dim EstudianteLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim HorarioLabel As System.Windows.Forms.Label
        Dim ProfesorLabel As System.Windows.Forms.Label
        Me.Registro_EstudiantilDataSet = New Registro.Registro_EstudiantilDataSet()
        Me.AulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AulaTableAdapter = New Registro.Registro_EstudiantilDataSetTableAdapters.aulaTableAdapter()
        Me.TableAdapterManager = New Registro.Registro_EstudiantilDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.HorarioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProfesorTextBox = New System.Windows.Forms.TextBox()
        Me.AulaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.SesionTextBox = New System.Windows.Forms.ComboBox()
        Me.AulaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsignaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroEstudiantilDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_EstudiantilDataSet1 = New Registro.Registro_EstudiantilDataSet1()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.AsignaturaTableAdapter = New Registro.Registro_EstudiantilDataSet1TableAdapters.asignaturaTableAdapter()
        Me.btnbuscarfecha = New System.Windows.Forms.Button()
        Me.btnbuscaraula = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        SesionLabel = New System.Windows.Forms.Label()
        EstudianteLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        HorarioLabel = New System.Windows.Forms.Label()
        ProfesorLabel = New System.Windows.Forms.Label()
        CType(Me.Registro_EstudiantilDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AulaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AulaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroEstudiantilDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_EstudiantilDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(27, 253)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 15)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'SesionLabel
        '
        SesionLabel.AutoSize = True
        SesionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SesionLabel.Location = New System.Drawing.Point(373, 152)
        SesionLabel.Name = "SesionLabel"
        SesionLabel.Size = New System.Drawing.Size(49, 13)
        SesionLabel.TabIndex = 3
        SesionLabel.Text = "Sesion:"
        '
        'EstudianteLabel
        '
        EstudianteLabel.AutoSize = True
        EstudianteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstudianteLabel.Location = New System.Drawing.Point(27, 282)
        EstudianteLabel.Name = "EstudianteLabel"
        EstudianteLabel.Size = New System.Drawing.Size(71, 13)
        EstudianteLabel.TabIndex = 5
        EstudianteLabel.Text = "Estudiante:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(27, 320)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(50, 13)
        EstadoLabel.TabIndex = 7
        EstadoLabel.Text = "Estado:"
        '
        'HorarioLabel
        '
        HorarioLabel.AutoSize = True
        HorarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HorarioLabel.Location = New System.Drawing.Point(719, 152)
        HorarioLabel.Name = "HorarioLabel"
        HorarioLabel.Size = New System.Drawing.Size(52, 13)
        HorarioLabel.TabIndex = 9
        HorarioLabel.Text = "Horario:"
        '
        'ProfesorLabel
        '
        ProfesorLabel.AutoSize = True
        ProfesorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProfesorLabel.Location = New System.Drawing.Point(27, 347)
        ProfesorLabel.Name = "ProfesorLabel"
        ProfesorLabel.Size = New System.Drawing.Size(58, 13)
        ProfesorLabel.TabIndex = 11
        ProfesorLabel.Text = "Profesor:"
        '
        'Registro_EstudiantilDataSet
        '
        Me.Registro_EstudiantilDataSet.DataSetName = "Registro_EstudiantilDataSet"
        Me.Registro_EstudiantilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AulaBindingSource
        '
        Me.AulaBindingSource.DataMember = "aula"
        Me.AulaBindingSource.DataSource = Me.Registro_EstudiantilDataSet
        '
        'AulaTableAdapter
        '
        Me.AulaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.aulaTableAdapter = Me.AulaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Registro.Registro_EstudiantilDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AulaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(102, 253)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'EstudianteTextBox
        '
        Me.EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AulaBindingSource, "Estudiante", True))
        Me.EstudianteTextBox.Location = New System.Drawing.Point(102, 279)
        Me.EstudianteTextBox.Name = "EstudianteTextBox"
        Me.EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EstudianteTextBox.TabIndex = 6
        '
        'HorarioDateTimePicker
        '
        Me.HorarioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AulaBindingSource, "horario", True))
        Me.HorarioDateTimePicker.Location = New System.Drawing.Point(789, 146)
        Me.HorarioDateTimePicker.Name = "HorarioDateTimePicker"
        Me.HorarioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HorarioDateTimePicker.TabIndex = 10
        '
        'ProfesorTextBox
        '
        Me.ProfesorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AulaBindingSource, "profesor", True))
        Me.ProfesorTextBox.Location = New System.Drawing.Point(102, 340)
        Me.ProfesorTextBox.Name = "ProfesorTextBox"
        Me.ProfesorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProfesorTextBox.TabIndex = 12
        '
        'AulaDataGridView
        '
        Me.AulaDataGridView.AutoGenerateColumns = False
        Me.AulaDataGridView.BackgroundColor = System.Drawing.Color.SeaShell
        Me.AulaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AulaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AulaDataGridView.DataSource = Me.AulaBindingSource
        Me.AulaDataGridView.Location = New System.Drawing.Point(376, 183)
        Me.AulaDataGridView.Name = "AulaDataGridView"
        Me.AulaDataGridView.Size = New System.Drawing.Size(982, 530)
        Me.AulaDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sesion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "sesion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Estudiante"
        Me.DataGridViewTextBoxColumn3.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Estudiante"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn4.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "horario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "horario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "profesor"
        Me.DataGridViewTextBoxColumn6.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "profesor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'estado
        '
        Me.estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.FormattingEnabled = True
        Me.estado.Items.AddRange(New Object() {"Presente", "Ausente", "Excusa Justificada", "Excusa Injustificada"})
        Me.estado.Location = New System.Drawing.Point(102, 312)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(200, 21)
        Me.estado.TabIndex = 15
        Me.estado.Text = "Seleccione"
        '
        'SesionTextBox
        '
        Me.SesionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AulaBindingSource1, "sesion", True))
        Me.SesionTextBox.DataSource = Me.AsignaturaBindingSource
        Me.SesionTextBox.DisplayMember = "Sesion"
        Me.SesionTextBox.FormattingEnabled = True
        Me.SesionTextBox.Location = New System.Drawing.Point(451, 144)
        Me.SesionTextBox.Name = "SesionTextBox"
        Me.SesionTextBox.Size = New System.Drawing.Size(121, 21)
        Me.SesionTextBox.TabIndex = 16
        Me.SesionTextBox.ValueMember = "Sesion"
        '
        'AulaBindingSource1
        '
        Me.AulaBindingSource1.DataMember = "aula"
        Me.AulaBindingSource1.DataSource = Me.Registro_EstudiantilDataSet
        '
        'AsignaturaBindingSource
        '
        Me.AsignaturaBindingSource.DataMember = "asignatura"
        Me.AsignaturaBindingSource.DataSource = Me.RegistroEstudiantilDataSet1BindingSource
        '
        'RegistroEstudiantilDataSet1BindingSource
        '
        Me.RegistroEstudiantilDataSet1BindingSource.DataSource = Me.Registro_EstudiantilDataSet1
        Me.RegistroEstudiantilDataSet1BindingSource.Position = 0
        '
        'Registro_EstudiantilDataSet1
        '
        Me.Registro_EstudiantilDataSet1.DataSetName = "Registro_EstudiantilDataSet1"
        Me.Registro_EstudiantilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(12, 396)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 17
        Me.btnguardar.Text = "AGREGAR"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(127, 396)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 18
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'AsignaturaTableAdapter
        '
        Me.AsignaturaTableAdapter.ClearBeforeFill = True
        '
        'btnbuscarfecha
        '
        Me.btnbuscarfecha.Location = New System.Drawing.Point(789, 115)
        Me.btnbuscarfecha.Name = "btnbuscarfecha"
        Me.btnbuscarfecha.Size = New System.Drawing.Size(156, 23)
        Me.btnbuscarfecha.TabIndex = 19
        Me.btnbuscarfecha.Text = "BUSCAR POR FECHA"
        Me.btnbuscarfecha.UseVisualStyleBackColor = True
        '
        'btnbuscaraula
        '
        Me.btnbuscaraula.Location = New System.Drawing.Point(376, 115)
        Me.btnbuscaraula.Name = "btnbuscaraula"
        Me.btnbuscaraula.Size = New System.Drawing.Size(168, 23)
        Me.btnbuscaraula.TabIndex = 20
        Me.btnbuscaraula.Text = "BUSCAR AULA"
        Me.btnbuscaraula.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(254, 396)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 21
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 681)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "©Jose Maria Suero Cuevas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(515, 85)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Control de Asistencia"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Registro.My.Resources.Resources._55a73b00412513b6596c4536beff3152
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnbuscaraula)
        Me.Controls.Add(Me.btnbuscarfecha)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.SesionTextBox)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.AulaDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(SesionLabel)
        Me.Controls.Add(EstudianteLabel)
        Me.Controls.Add(Me.EstudianteTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(HorarioLabel)
        Me.Controls.Add(Me.HorarioDateTimePicker)
        Me.Controls.Add(ProfesorLabel)
        Me.Controls.Add(Me.ProfesorTextBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Registro_EstudiantilDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AulaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AulaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroEstudiantilDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_EstudiantilDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Registro_EstudiantilDataSet As Registro_EstudiantilDataSet
    Friend WithEvents AulaBindingSource As BindingSource
    Friend WithEvents AulaTableAdapter As Registro_EstudiantilDataSetTableAdapters.aulaTableAdapter
    Friend WithEvents TableAdapterManager As Registro_EstudiantilDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents EstudianteTextBox As TextBox
    Friend WithEvents HorarioDateTimePicker As DateTimePicker
    Friend WithEvents ProfesorTextBox As TextBox
    Friend WithEvents AulaDataGridView As DataGridView
    Friend WithEvents estado As ComboBox
    Friend WithEvents SesionTextBox As ComboBox
    Friend WithEvents AulaBindingSource1 As BindingSource
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents RegistroEstudiantilDataSet1BindingSource As BindingSource
    Friend WithEvents Registro_EstudiantilDataSet1 As Registro_EstudiantilDataSet1
    Friend WithEvents AsignaturaBindingSource As BindingSource
    Friend WithEvents AsignaturaTableAdapter As Registro_EstudiantilDataSet1TableAdapters.asignaturaTableAdapter
    Friend WithEvents btnbuscarfecha As Button
    Friend WithEvents btnbuscaraula As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
