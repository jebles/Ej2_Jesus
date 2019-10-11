Public Class formAluDataIn
    Friend regAluCount As Integer = 0
    Friend varAlumno() As alumno

    Private Sub BtnCXLregAlu_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub BtnRegAlu_Click(sender As Object, e As EventArgs) Handles btnRegAlu.Click

        AddAlumno()

        Dim respuesta As Integer = MsgBox("¿Desea añadir otro alumno?", vbYesNoCancel, "Registro de Alumnos") '6=sí; 7=no; 2=clx
        Select Case respuesta
            Case 6
                'sí
                PrepararEntradaNueva()
            Case Else
                'no

                LimpiarCampos()
                Me.Hide()
                FormMenuPpal.textOpcionIn.Clear()
                FormMenuPpal.Show()
        End Select

    End Sub

    Private Sub AddAlumno()

        ReDim Preserve varAlumno(regAluCount) 'actualiza el tamaño de la matriz según num de alumnos en registro

        varAlumno(regAluCount).codAlum = regAluCount
        ValidarCampos()
        varAlumno(regAluCount).nomAlum = txtNomAlu.Text
        varAlumno(regAluCount).apellAlum = txtApeAlu.Text
        varAlumno(regAluCount).telfAlum = txtTelAlu.Text
        varAlumno(regAluCount).emailAlum = txtMailAlu.Text
        varAlumno(regAluCount).cursoAlum = txtCursoAlu.Text

        'varAlumno(regAluCount).sacarPorMsbox()

        regAluCount += 1 'contador de alumnos registrados [1er alumno -> 0]
    End Sub
    Private Sub ValidarCampos()
        Dim camposAluArrayTxt() As String = {txtNomAlu.Text, txtApeAlu.Text, txtMailAlu.Text, txtCursoAlu.Text}
        Dim camposAluArrayNum() As Integer = {txtTelAlu.Text}


        For Each campo In camposAluArrayTxt
            Validar_vacio_esp_nan(campo)
        Next

    End Sub

    Private Function Validar_vacio_esp_nan(campo As String) As Boolean
        If campo = "" Or IsNumeric(campo) Or campo = " " Then
            MsgBox("El dato introducido <<" & campo & ">> no es válido", MsgBoxStyle.Exclamation)
            Validar_vacio_esp_nan = False
        Else
            Validar_vacio_esp_nan = True
        End If
    End Function


    Private Sub BtnLimpiarDatosAluReg_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatosAluReg.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtApeAlu.Clear()
        txtCodAlu.Clear()
        txtCursoAlu.Clear()
        txtMailAlu.Clear()
        txtNomAlu.Clear()
        txtTelAlu.Clear()
    End Sub

    Private Sub BtnVolverAluReg_Click(sender As Object, e As EventArgs) Handles btnVolverAluReg.Click
        Me.Hide()
        FormMenuPpal.Show()
    End Sub


    'TODO: reusar para mostrar en form de resultado de busqueda
    'Private Sub Mostrar(alu As alumno)
    '    txtCodAlu.Text = alu.codAlum.ToString()
    '    txtNomAlu.Text = alu.nomAlum.ToString()
    '    txtApeAlu.Text = alu.apellAlum.ToString()
    '    txtTelAlu.Text = alu.telfAlum.ToString()
    '    txtMailAlu.Text = alu.emailAlum.ToString()
    '    txtCursoAlu.Text = alu.cursoAlum.ToString()
    'End Sub


    Private Sub FormAluDataIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararEntradaNueva()
    End Sub

    Private Sub PrepararEntradaNueva()
        LimpiarCampos()
        etqVarUsuario.Text = login.txtUsNomIn.Text
        txtCodAlu.Text = regAluCount
        btnRegAlu.Select()
    End Sub
End Class