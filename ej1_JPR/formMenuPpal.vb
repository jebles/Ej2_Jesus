Public Class formMenuPpal
    Private Sub formMenuPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etqVarUserMP.Text = login.txtUsNomIn.Text
    End Sub

    Private Sub tbOpcionIn_TextChanged(sender As Object, e As EventArgs) Handles tbOpcionIn.TextChanged
        Dim opciones As String
        Select Case opciones
            Case 1
                'introducir alumnos
                Me.Hide()
                formAluDataIn.Show()
            Case 2
                'consultar alumnos

            Case 3
                'ordenar array de alumnos
            Case 4
                'listar array
            Case 5
                'salir
                End
        End Select
    End Sub
End Class
