Public Class formAluList
    Private Sub btnFinList_Click(sender As Object, e As EventArgs) Handles btnFinList.Click
        End
    End Sub

    Private Sub btnSalirList_Click(sender As Object, e As EventArgs) Handles btnSalirList.Click
        Me.Hide()
        txtListaAlu.Clear()
        FormMenuPpal.Show()
    End Sub

    Private Sub formAluList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Friend Sub actualizarListaPantalla()
        Dim listaAlu As String
        If IsNothing(varAlumno) Then
            MsgBox("array vacio!")
        End If
        For Each alu In varAlumno
            listaAlu +=
            "Código: " & alu.codAlum & vbCrLf &
            "Nombre: " & alu.nomAlum.ToString() & vbCrLf &
            "Apellidos: " & alu.apellAlum.ToString() & vbCrLf &
            "Teléfono: " & alu.telfAlum.ToString & vbCrLf &
            "Mail: " & alu.emailAlum.ToString & vbCrLf &
            "Curso: " & alu.cursoAlum.ToString & vbCrLf & vbCrLf
        Next
        txtListaAlu.Text = listaAlu
    End Sub

    Private Sub formAluList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        actualizarListaPantalla()
    End Sub
End Class