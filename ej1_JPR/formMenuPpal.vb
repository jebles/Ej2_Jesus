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
                formAluDataIn.PrepararEntradaNueva()
                formAluDataIn.Show()
                textOpcionIn.Clear()
            Case 2
                'consultar alumnos
                formConsAlu.Show()
                textOpcionIn.Clear()
            Case 3
                'ordenar array de alumnos
                Dim alusOrdenados = From alumno In varAlumno
                                    Order By alumno.apellAlum
                varAlumno = alusOrdenados.ToArray
                MsgBox("Alumnos ordenados por apellidos")
                textOpcionIn.Clear()
            Case 4
                'listar array
                formAluList.Show()
                textOpcionIn.Clear()
            Case 5
                'salir
                End
        End Select
    End Sub


End Class
