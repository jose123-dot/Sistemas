Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_EstudiantilDataSet1.asignatura' Puede moverla o quitarla según sea necesario.
        Me.AsignaturaTableAdapter.Fill(Me.Registro_EstudiantilDataSet1.asignatura)
        'TODO: esta línea de código carga datos en la tabla 'Registro_EstudiantilDataSet.aula' Puede moverla o quitarla según sea necesario.
        Me.AulaTableAdapter.Fill(Me.Registro_EstudiantilDataSet.aula)

    End Sub

    Private Sub AulaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AulaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Registro_EstudiantilDataSet)

    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SesionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SesionLabel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub IdLabel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Me.AulaTableAdapter.InsertQuery(SesionTextBox.Text, EstudianteTextBox.Text, estado.Text, HorarioDateTimePicker.Text, ProfesorTextBox.Text)
        Me.AulaTableAdapter.Fill(Me.Registro_EstudiantilDataSet.aula)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Me.AulaTableAdapter.borrar(IdTextBox.Text)
        Me.AulaTableAdapter.Fill(Me.Registro_EstudiantilDataSet.aula)


    End Sub

    Private Sub SesionTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SesionTextBox.SelectedIndexChanged

    End Sub

    Private Sub btnbuscarfecha_Click(sender As Object, e As EventArgs) Handles btnbuscarfecha.Click

        Me.AulaTableAdapter.FillBy(Me.Registro_EstudiantilDataSet.aula, HorarioDateTimePicker.Text)
    End Sub

    Private Sub btnbuscaraula_Click(sender As Object, e As EventArgs) Handles btnbuscaraula.Click
        Me.AulaTableAdapter.FillBy1(Registro_EstudiantilDataSet.aula, SesionTextBox.Text, HorarioDateTimePicker.Text)
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Me.AulaTableAdapter.ectualizar(SesionTextBox.Text, EstudianteTextBox.Text, estado.Text, HorarioDateTimePicker.Text, ProfesorTextBox.Text, IdTextBox.Text, IdTextBox.Text)
        Me.AulaTableAdapter.Fill(Me.Registro_EstudiantilDataSet.aula)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class