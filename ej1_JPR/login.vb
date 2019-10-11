
Public Class login
    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        For pos = 0 To numUsuarios - 1
            'comprobar nombre
            If txtUsNomIn.Text = datos_login(pos, 0) Then
                'comprobar pass
                If txtUsPassIn.Text = datos_login(pos, 1) Then
                    usuario_activo = txtUsNomIn.Text
                    Me.Hide()
                    formMenuPpal.Show()
                    Exit For
                Else
                    MsgBox("error de login")
                    txtUsNomIn.Clear()
                    txtUsPassIn.Clear()
                    Exit For
                End If
            ElseIf pos = numUsuarios - 1 Then
                MsgBox("error de login")
                txtUsNomIn.Clear()
                txtUsPassIn.Clear()
            End If
        Next
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim us As String = "usuario"
        Dim cl As String = "clave"

        For i = 0 To numUsuarios - 1
            datos_login(i, 0) = us & i
            datos_login(i, 1) = cl & i
        Next
    End Sub

    Private Sub btnLoginCXL_Click(sender As Object, e As EventArgs) Handles btnLoginCXL.Click
        End
    End Sub
End Class