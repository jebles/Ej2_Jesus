Public Class formMenuPpal
    Private Sub formMenuPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etqVarUserMP.Text = login.txtUsNomIn.Text
    End Sub

    Private Sub textOpcionIn_TextChanged(sender As Object, e As EventArgs) Handles textOpcionIn.TextChanged

        Dim opciones As String = textOpcionIn.Text

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
