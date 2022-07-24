Public Class FrmAsignatura
    Private Sub AsignaturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AsignaturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_EstudiantilDataSet1)

    End Sub

    Private Sub FrmAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_EstudiantilDataSet1.asignatura' Puede moverla o quitarla según sea necesario.
        Me.AsignaturaTableAdapter.Fill(Me.Registro_EstudiantilDataSet1.asignatura)

    End Sub

    Private Sub AsignaturaBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Me.AsignaturaTableAdapter.InsertQuery(NombreTextBox.Text, SesionTextBox.Text, AulaTextBox.Text, DateTimePicker1.Text, ProfesorTextBox.Text)
        Me.AsignaturaTableAdapter.Fill(Me.Registro_EstudiantilDataSet1.asignatura)
    End Sub

    Private Sub ProfesorTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfesorTextBox.TextChanged

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click



        Me.AsignaturaTableAdapter.DeleteQuery(IdTextBox.Text)
        Me.AsignaturaTableAdapter.Fill(Me.Registro_EstudiantilDataSet1.asignatura)
    End Sub
End Class