<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignatura
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim SesionLabel As System.Windows.Forms.Label
        Dim AulaLabel As System.Windows.Forms.Label
        Dim HorarioLabel As System.Windows.Forms.Label
        Dim ProfesorLabel As System.Windows.Forms.Label
        Me.Registro_EstudiantilDataSet1 = New Registro.Registro_EstudiantilDataSet1()
        Me.AsignaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsignaturaTableAdapter = New Registro.Registro_EstudiantilDataSet1TableAdapters.asignaturaTableAdapter()
        Me.TableAdapterManager = New Registro.Registro_EstudiantilDataSet1TableAdapters.TableAdapterManager()
        Me.AsignaturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.SesionTextBox = New System.Windows.Forms.TextBox()
        Me.AulaTextBox = New System.Windows.Forms.TextBox()
        Me.ProfesorTextBox = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        SesionLabel = New System.Windows.Forms.Label()
        AulaLabel = New System.Windows.Forms.Label()
        HorarioLabel = New System.Windows.Forms.Label()
        ProfesorLabel = New System.Windows.Forms.Label()
        CType(Me.Registro_EstudiantilDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(25, 146)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(25, 172)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'SesionLabel
        '
        SesionLabel.AutoSize = True
        SesionLabel.Location = New System.Drawing.Point(25, 198)
        SesionLabel.Name = "SesionLabel"
        SesionLabel.Size = New System.Drawing.Size(42, 13)
        SesionLabel.TabIndex = 5
        SesionLabel.Text = "Sesion:"
        '
        'AulaLabel
        '
        AulaLabel.AutoSize = True
        AulaLabel.Location = New System.Drawing.Point(25, 224)
        AulaLabel.Name = "AulaLabel"
        AulaLabel.Size = New System.Drawing.Size(31, 13)
        AulaLabel.TabIndex = 7
        AulaLabel.Text = "Aula:"
        '
        'HorarioLabel
        '
        HorarioLabel.AutoSize = True
        HorarioLabel.Location = New System.Drawing.Point(25, 250)
        HorarioLabel.Name = "HorarioLabel"
        HorarioLabel.Size = New System.Drawing.Size(42, 13)
        HorarioLabel.TabIndex = 9
        HorarioLabel.Text = "horario:"
        '
        'ProfesorLabel
        '
        ProfesorLabel.AutoSize = True
        ProfesorLabel.Location = New System.Drawing.Point(25, 276)
        ProfesorLabel.Name = "ProfesorLabel"
        ProfesorLabel.Size = New System.Drawing.Size(49, 13)
        ProfesorLabel.TabIndex = 11
        ProfesorLabel.Text = "Profesor:"
        '
        'Registro_EstudiantilDataSet1
        '
        Me.Registro_EstudiantilDataSet1.DataSetName = "Registro_EstudiantilDataSet1"
        Me.Registro_EstudiantilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsignaturaBindingSource
        '
        Me.AsignaturaBindingSource.DataMember = "asignatura"
        Me.AsignaturaBindingSource.DataSource = Me.Registro_EstudiantilDataSet1
        '
        'AsignaturaTableAdapter
        '
        Me.AsignaturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.asignaturaTableAdapter = Me.AsignaturaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Registro.Registro_EstudiantilDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AsignaturaDataGridView
        '
        Me.AsignaturaDataGridView.AutoGenerateColumns = False
        Me.AsignaturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AsignaturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AsignaturaDataGridView.DataSource = Me.AsignaturaBindingSource
        Me.AsignaturaDataGridView.Location = New System.Drawing.Point(267, 102)
        Me.AsignaturaDataGridView.Name = "AsignaturaDataGridView"
        Me.AsignaturaDataGridView.Size = New System.Drawing.Size(797, 366)
        Me.AsignaturaDataGridView.TabIndex = 1
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(80, 143)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(80, 169)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(133, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'SesionTextBox
        '
        Me.SesionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "Sesion", True))
        Me.SesionTextBox.Location = New System.Drawing.Point(80, 195)
        Me.SesionTextBox.Name = "SesionTextBox"
        Me.SesionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SesionTextBox.TabIndex = 6
        '
        'AulaTextBox
        '
        Me.AulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "Aula", True))
        Me.AulaTextBox.Location = New System.Drawing.Point(80, 221)
        Me.AulaTextBox.Name = "AulaTextBox"
        Me.AulaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AulaTextBox.TabIndex = 8
        '
        'ProfesorTextBox
        '
        Me.ProfesorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturaBindingSource, "Profesor", True))
        Me.ProfesorTextBox.Location = New System.Drawing.Point(80, 273)
        Me.ProfesorTextBox.Name = "ProfesorTextBox"
        Me.ProfesorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProfesorTextBox.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(28, 354)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(127, 354)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 14
        Me.btneliminar.Text = "eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 247)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sesion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sesion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Aula"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Aula"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Profesor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Profesor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FrmAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 534)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(SesionLabel)
        Me.Controls.Add(Me.SesionTextBox)
        Me.Controls.Add(AulaLabel)
        Me.Controls.Add(Me.AulaTextBox)
        Me.Controls.Add(HorarioLabel)
        Me.Controls.Add(ProfesorLabel)
        Me.Controls.Add(Me.ProfesorTextBox)
        Me.Controls.Add(Me.AsignaturaDataGridView)
        Me.Name = "FrmAsignatura"
        Me.Text = "FrmAsignatura"
        CType(Me.Registro_EstudiantilDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Registro_EstudiantilDataSet1 As Registro_EstudiantilDataSet1
    Friend WithEvents AsignaturaBindingSource As BindingSource
    Friend WithEvents AsignaturaTableAdapter As Registro_EstudiantilDataSet1TableAdapters.asignaturaTableAdapter
    Friend WithEvents TableAdapterManager As Registro_EstudiantilDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AsignaturaDataGridView As DataGridView
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents SesionTextBox As TextBox
    Friend WithEvents AulaTextBox As TextBox
    Friend WithEvents ProfesorTextBox As TextBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
