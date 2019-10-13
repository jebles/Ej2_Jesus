Public Class formConsAlu
    Private Sub BtnBuscarNom_Click(sender As Object, e As EventArgs) Handles BtnBuscarNom.Click

        Dim nomAbuscar As String = txtBuscarNom.Text
        formAluDataIn.Validar_vacio_esp_nan(nomAbuscar)
        MsgBox("buscando a " & nomAbuscar)
        Dim cont As Integer = 0

        If IsNothing(formAluDataIn.varAlumno) Then
            MsgBox("La lista de alumnos está vacía")

        ElseIf IsNothing(nomAbuscar) Then
            nomAbuscar = InputBox("Se introdujo sin datos, introduce de nuevo el nombre del alumno", "Buscar", 1)
        Else
            For Each alumno In formAluDataIn.varAlumno
                MsgBox("busco a " & alumno.nomAlum.ToString & " comparo con " & nomAbuscar)
                If alumno.nomAlum.ToString Like nomAbuscar Then
                    MsgBox("encontrado!")
                    MostrarAlumno(alumno)
                    Exit For
                ElseIf cont = formAluDataIn.varAlumno.Length Then
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
End Class