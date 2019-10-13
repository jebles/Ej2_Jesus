Public Class formAluDataIn
    Friend regAluCount As Integer = 0


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

        'If CamposValidos() = True Then

        varAlumno(regAluCount).nomAlum = txtNomAlu.Text
        varAlumno(regAluCount).apellAlum = txtApeAlu.Text
        varAlumno(regAluCount).telfAlum = txtTelAlu.Text
        varAlumno(regAluCount).emailAlum = txtMailAlu.Text
        varAlumno(regAluCount).cursoAlum = txtCursoAlu.Text
        'varAlumno(regAluCount).sacarPorMsbox()
        regAluCount += 1 'contador de alumnos registrados [1er alumno -> 0]
        ' Else
        LimpiarCampos()
        ' End If

    End Sub
    Friend Function CamposValidos() As Boolean
        Dim camposAluArrayTxt() As String = {txtNomAlu.Text, txtApeAlu.Text, txtMailAlu.Text, txtCursoAlu.Text}
        Dim tel As String = txtTelAlu.Text
        Dim textosValidos As Boolean
        Dim telefonoValido As Boolean

        For Each campo In camposAluArrayTxt
            If Validar_vacio_esp_nan(campo) = False Then
                MsgBox("Introduce de nuevo los datos")
                textosValidos = False
            End If
        Next
        MsgBox("tel " & tel)
        If Validar_vacio_esp_numeros(tel) = False Then
            MsgBox("Introduce de nuevo el teléfono")
            telefonoValido = False
        End If

        If textosValidos And telefonoValido Then
            CamposValidos = True
        Else
            CamposValidos = False
        End If

    End Function

    Private Function Validar_vacio_esp_numeros(valorCampoNum As String) As Boolean
        If Not IsNumeric(valorCampoNum) Then
            MsgBox("El dato introducido <<" & valorCampoNum & ">> no es válido", MsgBoxStyle.Exclamation)
            Validar_vacio_esp_numeros = False
        Else
            Validar_vacio_esp_numeros = True
        End If
    End Function

    Friend Function Validar_vacio_esp_nan(valorCampoTxt As String) As Boolean
        If IsNumeric(valorCampoTxt) Or valorCampoTxt = " " Or IsNothing(valorCampoTxt) Then
            MsgBox("El dato introducido <<" & valorCampoTxt & ">> no es válido", MsgBoxStyle.Exclamation)
            Validar_vacio_esp_nan = False
        Else
            Validar_vacio_esp_nan = True
        End If
    End Function


    Private Sub BtnLimpiarDatosAluReg_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatosAluReg.Click
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

    Private Sub BtnVolverAluReg_Click(sender As Object, e As EventArgs) Handles btnVolverAluReg.Click
        Me.Hide()
        FormMenuPpal.Show()
    End Sub


    Friend Sub PrepararEntradaNueva()
        LimpiarCampos()
        etqVarUsuario.Text = login.txtUsNomIn.Text
        txtCodAlu.Text = regAluCount
        txtNomAlu.Select()
    End Sub

    Private Sub formAluDataIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepararEntradaNueva()
    End Sub
End Class