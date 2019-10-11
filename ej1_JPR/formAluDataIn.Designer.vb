<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAluDataIn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.etqInfoPlazas = New System.Windows.Forms.Label()
        Me.etqCtrlPlazas = New System.Windows.Forms.Label()
        Me.etqCodAlu = New System.Windows.Forms.Label()
        Me.txtCodAlu = New System.Windows.Forms.TextBox()
        Me.txtNomAlu = New System.Windows.Forms.TextBox()
        Me.etqNomAlu = New System.Windows.Forms.Label()
        Me.txtApeAlu = New System.Windows.Forms.TextBox()
        Me.etqApeAlu = New System.Windows.Forms.Label()
        Me.txtTelAlu = New System.Windows.Forms.TextBox()
        Me.etqTlfAlu = New System.Windows.Forms.Label()
        Me.txtMailAlu = New System.Windows.Forms.TextBox()
        Me.etqMailAlu = New System.Windows.Forms.Label()
        Me.txtCursoAlu = New System.Windows.Forms.TextBox()
        Me.etqCursoAlu = New System.Windows.Forms.Label()
        Me.btnRegAlu = New System.Windows.Forms.Button()
        Me.etqBienvenida = New System.Windows.Forms.Label()
        Me.etqVarUsuario = New System.Windows.Forms.Label()
        Me.btnLimpiarDatosAluReg = New System.Windows.Forms.Button()
        Me.btnVolverAluReg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'etqInfoPlazas
        '
        Me.etqInfoPlazas.AutoSize = True
        Me.etqInfoPlazas.Location = New System.Drawing.Point(24, 20)
        Me.etqInfoPlazas.Name = "etqInfoPlazas"
        Me.etqInfoPlazas.Size = New System.Drawing.Size(68, 13)
        Me.etqInfoPlazas.TabIndex = 0
        Me.etqInfoPlazas.Text = "Plazas libres:"
        '
        'etqCtrlPlazas
        '
        Me.etqCtrlPlazas.AutoSize = True
        Me.etqCtrlPlazas.Location = New System.Drawing.Point(91, 20)
        Me.etqCtrlPlazas.Name = "etqCtrlPlazas"
        Me.etqCtrlPlazas.Size = New System.Drawing.Size(0, 13)
        Me.etqCtrlPlazas.TabIndex = 1
        '
        'etqCodAlu
        '
        Me.etqCodAlu.AutoSize = True
        Me.etqCodAlu.Location = New System.Drawing.Point(52, 68)
        Me.etqCodAlu.Name = "etqCodAlu"
        Me.etqCodAlu.Size = New System.Drawing.Size(40, 13)
        Me.etqCodAlu.TabIndex = 2
        Me.etqCodAlu.Text = "Código"
        Me.etqCodAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodAlu
        '
        Me.txtCodAlu.Enabled = False
        Me.txtCodAlu.Location = New System.Drawing.Point(94, 65)
        Me.txtCodAlu.Name = "txtCodAlu"
        Me.txtCodAlu.Size = New System.Drawing.Size(34, 20)
        Me.txtCodAlu.TabIndex = 3
        '
        'txtNomAlu
        '
        Me.txtNomAlu.Location = New System.Drawing.Point(94, 98)
        Me.txtNomAlu.Name = "txtNomAlu"
        Me.txtNomAlu.Size = New System.Drawing.Size(100, 20)
        Me.txtNomAlu.TabIndex = 5
        '
        'etqNomAlu
        '
        Me.etqNomAlu.AutoSize = True
        Me.etqNomAlu.Location = New System.Drawing.Point(48, 101)
        Me.etqNomAlu.Name = "etqNomAlu"
        Me.etqNomAlu.Size = New System.Drawing.Size(44, 13)
        Me.etqNomAlu.TabIndex = 4
        Me.etqNomAlu.Text = "Nombre"
        Me.etqNomAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApeAlu
        '
        Me.txtApeAlu.Location = New System.Drawing.Point(94, 131)
        Me.txtApeAlu.Name = "txtApeAlu"
        Me.txtApeAlu.Size = New System.Drawing.Size(146, 20)
        Me.txtApeAlu.TabIndex = 7
        '
        'etqApeAlu
        '
        Me.etqApeAlu.AutoSize = True
        Me.etqApeAlu.Location = New System.Drawing.Point(43, 134)
        Me.etqApeAlu.Name = "etqApeAlu"
        Me.etqApeAlu.Size = New System.Drawing.Size(49, 13)
        Me.etqApeAlu.TabIndex = 6
        Me.etqApeAlu.Text = "Apellidos"
        Me.etqApeAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelAlu
        '
        Me.txtTelAlu.Location = New System.Drawing.Point(94, 164)
        Me.txtTelAlu.Name = "txtTelAlu"
        Me.txtTelAlu.Size = New System.Drawing.Size(100, 20)
        Me.txtTelAlu.TabIndex = 9
        '
        'etqTlfAlu
        '
        Me.etqTlfAlu.AutoSize = True
        Me.etqTlfAlu.Location = New System.Drawing.Point(43, 167)
        Me.etqTlfAlu.Name = "etqTlfAlu"
        Me.etqTlfAlu.Size = New System.Drawing.Size(49, 13)
        Me.etqTlfAlu.TabIndex = 8
        Me.etqTlfAlu.Text = "Teléfono"
        Me.etqTlfAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMailAlu
        '
        Me.txtMailAlu.Location = New System.Drawing.Point(94, 197)
        Me.txtMailAlu.Name = "txtMailAlu"
        Me.txtMailAlu.Size = New System.Drawing.Size(146, 20)
        Me.txtMailAlu.TabIndex = 11
        '
        'etqMailAlu
        '
        Me.etqMailAlu.AutoSize = True
        Me.etqMailAlu.Location = New System.Drawing.Point(66, 200)
        Me.etqMailAlu.Name = "etqMailAlu"
        Me.etqMailAlu.Size = New System.Drawing.Size(26, 13)
        Me.etqMailAlu.TabIndex = 10
        Me.etqMailAlu.Text = "Mail"
        Me.etqMailAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCursoAlu
        '
        Me.txtCursoAlu.Location = New System.Drawing.Point(94, 230)
        Me.txtCursoAlu.Name = "txtCursoAlu"
        Me.txtCursoAlu.Size = New System.Drawing.Size(146, 20)
        Me.txtCursoAlu.TabIndex = 13
        '
        'etqCursoAlu
        '
        Me.etqCursoAlu.AutoSize = True
        Me.etqCursoAlu.Location = New System.Drawing.Point(58, 233)
        Me.etqCursoAlu.Name = "etqCursoAlu"
        Me.etqCursoAlu.Size = New System.Drawing.Size(34, 13)
        Me.etqCursoAlu.TabIndex = 12
        Me.etqCursoAlu.Text = "Curso"
        Me.etqCursoAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRegAlu
        '
        Me.btnRegAlu.Location = New System.Drawing.Point(218, 277)
        Me.btnRegAlu.Name = "btnRegAlu"
        Me.btnRegAlu.Size = New System.Drawing.Size(69, 37)
        Me.btnRegAlu.TabIndex = 14
        Me.btnRegAlu.Text = "Registrar Alumno"
        Me.btnRegAlu.UseVisualStyleBackColor = True
        '
        'etqBienvenida
        '
        Me.etqBienvenida.AutoSize = True
        Me.etqBienvenida.Location = New System.Drawing.Point(191, 20)
        Me.etqBienvenida.Name = "etqBienvenida"
        Me.etqBienvenida.Size = New System.Drawing.Size(29, 13)
        Me.etqBienvenida.TabIndex = 15
        Me.etqBienvenida.Text = "Hola"
        '
        'etqVarUsuario
        '
        Me.etqVarUsuario.AutoSize = True
        Me.etqVarUsuario.Location = New System.Drawing.Point(226, 20)
        Me.etqVarUsuario.Name = "etqVarUsuario"
        Me.etqVarUsuario.Size = New System.Drawing.Size(41, 13)
        Me.etqVarUsuario.TabIndex = 16
        Me.etqVarUsuario.Text = "usuario"
        '
        'btnLimpiarDatosAluReg
        '
        Me.btnLimpiarDatosAluReg.Location = New System.Drawing.Point(73, 277)
        Me.btnLimpiarDatosAluReg.Name = "btnLimpiarDatosAluReg"
        Me.btnLimpiarDatosAluReg.Size = New System.Drawing.Size(69, 37)
        Me.btnLimpiarDatosAluReg.TabIndex = 17
        Me.btnLimpiarDatosAluReg.Text = "Limpiar Campos"
        Me.btnLimpiarDatosAluReg.UseVisualStyleBackColor = True
        '
        'btnVolverAluReg
        '
        Me.btnVolverAluReg.Location = New System.Drawing.Point(13, 277)
        Me.btnVolverAluReg.Name = "btnVolverAluReg"
        Me.btnVolverAluReg.Size = New System.Drawing.Size(54, 37)
        Me.btnVolverAluReg.TabIndex = 18
        Me.btnVolverAluReg.Text = "Volver"
        Me.btnVolverAluReg.UseVisualStyleBackColor = True
        '
        'formAluDataIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolverAluReg)
        Me.Controls.Add(Me.btnLimpiarDatosAluReg)
        Me.Controls.Add(Me.etqVarUsuario)
        Me.Controls.Add(Me.etqBienvenida)
        Me.Controls.Add(Me.btnRegAlu)
        Me.Controls.Add(Me.txtCursoAlu)
        Me.Controls.Add(Me.etqCursoAlu)
        Me.Controls.Add(Me.txtMailAlu)
        Me.Controls.Add(Me.etqMailAlu)
        Me.Controls.Add(Me.txtTelAlu)
        Me.Controls.Add(Me.etqTlfAlu)
        Me.Controls.Add(Me.txtApeAlu)
        Me.Controls.Add(Me.etqApeAlu)
        Me.Controls.Add(Me.txtNomAlu)
        Me.Controls.Add(Me.etqNomAlu)
        Me.Controls.Add(Me.txtCodAlu)
        Me.Controls.Add(Me.etqCodAlu)
        Me.Controls.Add(Me.etqCtrlPlazas)
        Me.Controls.Add(Me.etqInfoPlazas)
        Me.Name = "formAluDataIn"
        Me.Text = "Introducir Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etqInfoPlazas As Label
    Friend WithEvents etqCtrlPlazas As Label
    Friend WithEvents etqCodAlu As Label
    Friend WithEvents txtCodAlu As TextBox
    Friend WithEvents txtNomAlu As TextBox
    Friend WithEvents etqNomAlu As Label
    Friend WithEvents txtApeAlu As TextBox
    Friend WithEvents etqApeAlu As Label
    Friend WithEvents txtTelAlu As TextBox
    Friend WithEvents etqTlfAlu As Label
    Friend WithEvents txtMailAlu As TextBox
    Friend WithEvents etqMailAlu As Label
    Friend WithEvents txtCursoAlu As TextBox
    Friend WithEvents etqCursoAlu As Label
    Friend WithEvents btnRegAlu As Button
    Friend WithEvents etqBienvenida As Label
    Friend WithEvents etqVarUsuario As Label
    Friend WithEvents btnLimpiarDatosAluReg As Button
    Friend WithEvents btnVolverAluReg As Button
End Class
