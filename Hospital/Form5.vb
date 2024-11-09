Imports MySql.Data.MySqlClient

Public Class Form5
    Public Function agEmpleado() As Boolean
        Dim query As String = "INSERT INTO persona(numIdentidad, nombre, apellido, correo, genero, telefono, direccion, fechaNac) VALUES(@numIdentidad, @nombre, @apellido, @correo, @genero, @telefono, @direccion, @fechaNac)"
        Dim personaO As New C_pesona()
        personaO.numIdentidad = mskIdentEmp.Text
        personaO.nombre = txtNombEmp.Text
        personaO.apellido = txtApeEmp.Text
        personaO.correo = txtCorreoEmp.Text
        personaO.genero = If(rdbFemeninoEmp.Checked, 0, 1)
        personaO.telefono = mskTelEmp.Text
        personaO.direccion = txtDirecEmp.Text
        personaO.fechaNac = "2002-01-14"

        Dim resultado As Boolean = consultaGeneral(query, personaO)

        If resultado Then
            MsgBox("Empleado agregado correctamente.")
        Else
            MsgBox("Error al agregar empleado.")
        End If
        Return resultado

    End Function



    Private Sub btnAgregarEmp_Click(sender As Object, e As EventArgs) Handles btnAgregarEmp.Click
        agEmpleado()


    End Sub
End Class
