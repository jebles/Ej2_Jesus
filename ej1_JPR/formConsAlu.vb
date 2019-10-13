Public Class formConsAlu
    Private Sub BtnBuscarNom_Click(sender As Object, e As EventArgs) Handles BtnBuscarNom.Click

        Dim nomAbuscar As String = txtBuscarNom.Text
        formAluDataIn.Validar_vacio_esp_nan(nomAbuscar)
        MsgBox("buscando a " & nomAbuscar)
        Dim cont As Integer = 0

        If IsNothing(varAlumno) Then
            MsgBox("La lista de alumnos está vacía")

        ElseIf IsNothing(nomAbuscar) Then
            MsgBox("Se introdujo sin datos, introduce de nuevo el nombre del alumno", "Buscar")
            txtBuscarNom().Clear()
            txtBuscarNom().Select()
        Else
            For Each alumno In varAlumno
                MsgBox("busco a " & alumno.nomAlum.ToString & " comparo con " & nomAbuscar)
                If alumno.nomAlum.ToString Like nomAbuscar Then
                    MsgBox("encontrado!")
                    MostrarAlumno(alumno)
                    txtBuscarNom.Clear()
                    Exit For
                ElseIf cont = varAlumno.Length - 1 Then
                    MsgBox("El alumno de nombre " & nomAbuscar & " no ha sido encontrado ")
                End If
                cont += 1
            Next
        End If
    End Sub
    Private Shared Sub MostrarAlumno(alu As alumno)
        formConsAlu.txtCodAlu.Text = alu.codAlum.ToString()
        formConsAlu.txtNomAlu.Text = alu.nomAlum.ToString()
        formConsAlu.txtApeAlu.Text = alu.apellAlum.ToString()
        formConsAlu.txtTelAlu.Text = alu.telfAlum.ToString()
        formConsAlu.txtMailAlu.Text = alu.emailAlum.ToString()
        formConsAlu.txtCursoAlu.Text = alu.cursoAlum.ToString()
    End Sub

    Private Sub btnCxlConsulta_Click(sender As Object, e As EventArgs) Handles btnCxlConsulta.Click
        Me.Hide()
        FormMenuPpal.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        varAlumno(txtCodAlu.Text).nomAlum = txtNomAlu.Text
        varAlumno(txtCodAlu.Text).apellAlum = txtApeAlu.Text
        varAlumno(txtCodAlu.Text).emailAlum = txtMailAlu.Text
        varAlumno(txtCodAlu.Text).telfAlum = txtTelAlu.Text
        varAlumno(txtCodAlu.Text).cursoAlum = txtCursoAlu.Text
    End Sub

    Private Sub formConsAlu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBuscarNom().Select()
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos()
    End Sub
    Friend Sub LimpiarCampos()
        txtApeAlu.Clear()
        txtCodAlu.Clear()
        txtCursoAlu.Clear()
        txtMailAlu.Clear()
        txtNomAlu.Clear()
        txtTelAlu.Clear()
    End Sub
End Class