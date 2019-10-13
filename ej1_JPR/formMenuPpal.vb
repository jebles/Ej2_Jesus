Public Class FormMenuPpal
    Private Sub FormMenuPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etqVarUserMP.Text = login.txtUsNomIn.Text

    End Sub

    Private Sub TextOpcionIn_TextChanged(sender As Object, e As EventArgs) Handles textOpcionIn.TextChanged

        Dim opciones As String = textOpcionIn.Text

        Select Case opciones
            Case 1
                'introducir alumnos
                Me.Hide()
                formAluDataIn.Show()

            Case 2
                'consultar alumnos
                Dim cod As Integer = InputBox("Introduce el código del alumno", "Buscar", 1)
                Dim cont As Integer = 0

                If IsNothing(formAluDataIn.varAlumno) Then
                    MsgBox("La lista de alumnos está vacía")
                Else
                    For Each alumno In formAluDataIn.varAlumno

                        If alumno.codAlum.ToString = cod Then
                            MostrarAlumno(alumno)
                        ElseIf cont = formAluDataIn.varAlumno.Length Then
                            MsgBox("El código de alumno " & cod & " no ha sido encontrado ")

                        End If
                        cont += 1
                    Next
                End If


            Case 3
                'ordenar array de alumnos
            Case 4
                'listar array
            Case 5
                'salir
                End
        End Select
    End Sub

    Private Shared Sub MostrarAlumno(alu As alumno)
        formAluDataIn.txtCodAlu.Text = alu.codAlum.ToString()
        formAluDataIn.txtNomAlu.Text = alu.nomAlum.ToString()
        formAluDataIn.txtApeAlu.Text = alu.apellAlum.ToString()
        formAluDataIn.txtTelAlu.Text = alu.telfAlum.ToString()
        formAluDataIn.txtMailAlu.Text = alu.emailAlum.ToString()
        formAluDataIn.txtCursoAlu.Text = alu.cursoAlum.ToString()
    End Sub
End Class
