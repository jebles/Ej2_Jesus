Public Class formAluDataIn
    Friend regAluCount As Integer = 0
    Friend varAlumno() As alumno

    Private Sub btnCXLregAlu_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub btnRegAlu_Click(sender As Object, e As EventArgs) Handles btnRegAlu.Click
        Dim cont As Boolean = True

        addAlumno()

        Dim respuesta As Integer = MsgBox("¿Desea añadir otro alumno?", vbYesNoCancel, "Registro de Alumnos") '6=sí; 7=no; 2=clx
            Select Case respuesta
            Case 6
                'sí
                limpiarCampos()
                prepararEntradanueva()
            Case Else
                    'no

                    limpiarCampos()
                    Me.Hide()
                    formMenuPpal.textOpcionIn.Clear()
                    formMenuPpal.Show()
                    cont = False
            End Select

    End Sub

    Private Sub addAlumno()

        ReDim Preserve varAlumno(regAluCount) 'actualiza el tamaño de la matriz según num de alumnos en registro

        varAlumno(regAluCount).codAlum = regAluCount
        ' validarCampos()
        varAlumno(regAluCount).nomAlum = txtNomAlu.Text
        varAlumno(regAluCount).apellAlum = txtApeAlu.Text
        varAlumno(regAluCount).telfAlum = txtTelAlu.Text
        varAlumno(regAluCount).emailAlum = txtMailAlu.Text
        varAlumno(regAluCount).cursoAlum = txtCursoAlu.Text

        'varAlumno(regAluCount).sacarPorMsbox()

        regAluCount += 1 'contador de alumnos registrados
    End Sub
    Private Sub validarCampos()
        Dim camposAluArrayTxt(3) As String
        Dim camposAluArrayNum(0) As Integer
        Dim validoTxts As Boolean = False
        Dim validoNums As Boolean = False

        camposAluArrayTxt(0) = txtNomAlu.Text
        camposAluArrayTxt(1) = txtApeAlu.Text
        camposAluArrayTxt(2) = txtMailAlu.Text
        camposAluArrayTxt(3) = txtCursoAlu.Text

        camposAluArrayNum(0) = txtTelAlu.Text

        For Each campo In camposAluArrayTxt
            validar_vacio_esp_nan(campo)
        Next
    End Sub

    Private Function validar_vacio_esp_nan(campo As String) As Boolean
        If campo = "" Or IsNumeric(campo) Or campo = " " Then
            MsgBox("El dato introducido <<" & campo & ">> no es válido", MsgBoxStyle.Exclamation)
            validar_vacio_esp_nan = False
        Else
            validar_vacio_esp_nan = True
        End If
    End Function


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
        prepararEntradanueva()
    End Sub

    Private Sub prepararEntradanueva()
        etqVarUsuario.Text = login.txtUsNomIn.Text
        txtCodAlu.Text = regAluCount
        btnRegAlu.Focus()
    End Sub
End Class