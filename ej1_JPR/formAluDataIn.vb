Public Class formAluDataIn
    Private maxAlumnos As Integer = 3
    Friend varAlumno(maxAlumnos - 1) As alumno
    Private regAluCount As Integer = 0

    Private Sub btnCXLregAlu_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub btnRegAlu_Click(sender As Object, e As EventArgs) Handles btnRegAlu.Click

        If regAluCount < maxAlumnos Then

            varAlumno(regAluCount).codAlum = regAluCount
            varAlumno(regAluCount).nomAlum = txtNomAlu.Text
            varAlumno(regAluCount).apellAlum = txtApeAlu.Text
            varAlumno(regAluCount).telfAlum = txtTelAlu.Text
            varAlumno(regAluCount).emailAlum = txtMailAlu.Text
            varAlumno(regAluCount).cursoAlum = txtCursoAlu.Text
            varAlumno(regAluCount).sacarPorMsbox()
            regAluCount += 1
            etqCtrlPlazas.Text -= 1
        Else
            MsgBox("Se ha alcanzado el máximo de alumnos")
            limpiarCampos()
        End If
    End Sub

    Private Sub btnLimpiarDatosAluReg_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatosAluReg.Click
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtApeAlu.Clear()
        txtCodAlu.Clear()
        txtCursoAlu.Clear()
        txtMailAlu.Clear()
        txtNomAlu.Clear()
        txtTelAlu.Clear()
    End Sub

    Private Sub btnVolverAluReg_Click(sender As Object, e As EventArgs) Handles btnVolverAluReg.Click
        Me.Hide()
        formMenuPpal.Show()
    End Sub

    Private Sub mostrar(alu As alumno)
        txtCodAlu.Text = alu.codAlum.ToString()
        txtNomAlu.Text = alu.nomAlum.ToString()
        txtApeAlu.Text = alu.apellAlum.ToString()
        txtTelAlu.Text = alu.telfAlum.ToString()
        txtMailAlu.Text = alu.emailAlum.ToString()
        txtCursoAlu.Text = alu.cursoAlum.ToString()
    End Sub


    Private Sub formAluDataIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etqCtrlPlazas.Text = maxAlumnos - (regAluCount)
        etqVarUsuario.Text = login.txtUsNomIn.Text
        txtCodAlu.Text = regAluCount
        btnRegAlu.Focus()
    End Sub

End Class