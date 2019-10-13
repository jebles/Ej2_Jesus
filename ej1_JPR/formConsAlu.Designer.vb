<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConsAlu
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
        Me.txtCursoAlu = New System.Windows.Forms.TextBox()
        Me.etqCursoAlu = New System.Windows.Forms.Label()
        Me.txtMailAlu = New System.Windows.Forms.TextBox()
        Me.etqMailAlu = New System.Windows.Forms.Label()
        Me.txtTelAlu = New System.Windows.Forms.TextBox()
        Me.etqTlfAlu = New System.Windows.Forms.Label()
        Me.txtApeAlu = New System.Windows.Forms.TextBox()
        Me.etqApeAlu = New System.Windows.Forms.Label()
        Me.txtNomAlu = New System.Windows.Forms.TextBox()
        Me.etqNomAlu = New System.Windows.Forms.Label()
        Me.txtCodAlu = New System.Windows.Forms.TextBox()
        Me.etqCodAlu = New System.Windows.Forms.Label()
        Me.txtBuscarNom = New System.Windows.Forms.TextBox()
        Me.BtnBuscarNom = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnCxlConsulta = New System.Windows.Forms.Button()
        Me.GbBuscar = New System.Windows.Forms.GroupBox()
        Me.GbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCursoAlu
        '
        Me.txtCursoAlu.Location = New System.Drawing.Point(279, 193)
        Me.txtCursoAlu.Name = "txtCursoAlu"
        Me.txtCursoAlu.Size = New System.Drawing.Size(146, 20)
        Me.txtCursoAlu.TabIndex = 25
        '
        'etqCursoAlu
        '
        Me.etqCursoAlu.AutoSize = True
        Me.etqCursoAlu.Location = New System.Drawing.Point(243, 196)
        Me.etqCursoAlu.Name = "etqCursoAlu"
        Me.etqCursoAlu.Size = New System.Drawing.Size(34, 13)
        Me.etqCursoAlu.TabIndex = 24
        Me.etqCursoAlu.Text = "Curso"
        Me.etqCursoAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMailAlu
        '
        Me.txtMailAlu.Location = New System.Drawing.Point(279, 160)
        Me.txtMailAlu.Name = "txtMailAlu"
        Me.txtMailAlu.Size = New System.Drawing.Size(146, 20)
        Me.txtMailAlu.TabIndex = 23
        '
        'etqMailAlu
        '
        Me.etqMailAlu.AutoSize = True
        Me.etqMailAlu.Location = New System.Drawing.Point(251, 163)
        Me.etqMailAlu.Name = "etqMailAlu"
        Me.etqMailAlu.Size = New System.Drawing.Size(26, 13)
        Me.etqMailAlu.TabIndex = 22
        Me.etqMailAlu.Text = "Mail"
        Me.etqMailAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelAlu
        '
        Me.txtTelAlu.Location = New System.Drawing.Point(279, 127)
        Me.txtTelAlu.Name = "txtTelAlu"
        Me.txtTelAlu.Size = New System.Drawing.Size(100, 20)
        Me.txtTelAlu.TabIndex = 21
        '
        'etqTlfAlu
        '
        Me.etqTlfAlu.AutoSize = True
        Me.etqTlfAlu.Location = New System.Drawing.Point(228, 130)
        Me.etqTlfAlu.Name = "etqTlfAlu"
        Me.etqTlfAlu.Size = New System.Drawing.Size(49, 13)
        Me.etqTlfAlu.TabIndex = 20
        Me.etqTlfAlu.Text = "Teléfono"
        Me.etqTlfAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApeAlu
        '
        Me.txtApeAlu.Location = New System.Drawing.Point(279, 94)
        Me.txtApeAlu.Name = "txtApeAlu"
        Me.txtApeAlu.Size = New System.Drawing.Size(146, 20)
        Me.txtApeAlu.TabIndex = 19
        '
        'etqApeAlu
        '
        Me.etqApeAlu.AutoSize = True
        Me.etqApeAlu.Location = New System.Drawing.Point(228, 97)
        Me.etqApeAlu.Name = "etqApeAlu"
        Me.etqApeAlu.Size = New System.Drawing.Size(49, 13)
        Me.etqApeAlu.TabIndex = 18
        Me.etqApeAlu.Text = "Apellidos"
        Me.etqApeAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNomAlu
        '
        Me.txtNomAlu.Location = New System.Drawing.Point(279, 61)
        Me.txtNomAlu.Name = "txtNomAlu"
        Me.txtNomAlu.Size = New System.Drawing.Size(100, 20)
        Me.txtNomAlu.TabIndex = 17
        '
        'etqNomAlu
        '
        Me.etqNomAlu.AutoSize = True
        Me.etqNomAlu.Location = New System.Drawing.Point(233, 64)
        Me.etqNomAlu.Name = "etqNomAlu"
        Me.etqNomAlu.Size = New System.Drawing.Size(44, 13)
        Me.etqNomAlu.TabIndex = 16
        Me.etqNomAlu.Text = "Nombre"
        Me.etqNomAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodAlu
        '
        Me.txtCodAlu.Enabled = False
        Me.txtCodAlu.Location = New System.Drawing.Point(279, 28)
        Me.txtCodAlu.Name = "txtCodAlu"
        Me.txtCodAlu.Size = New System.Drawing.Size(34, 20)
        Me.txtCodAlu.TabIndex = 15
        '
        'etqCodAlu
        '
        Me.etqCodAlu.AutoSize = True
        Me.etqCodAlu.Location = New System.Drawing.Point(237, 31)
        Me.etqCodAlu.Name = "etqCodAlu"
        Me.etqCodAlu.Size = New System.Drawing.Size(40, 13)
        Me.etqCodAlu.TabIndex = 14
        Me.etqCodAlu.Text = "Código"
        Me.etqCodAlu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBuscarNom
        '
        Me.txtBuscarNom.Location = New System.Drawing.Point(33, 28)
        Me.txtBuscarNom.Name = "txtBuscarNom"
        Me.txtBuscarNom.Size = New System.Drawing.Size(136, 20)
        Me.txtBuscarNom.TabIndex = 27
        '
        'BtnBuscarNom
        '
        Me.BtnBuscarNom.Location = New System.Drawing.Point(33, 55)
        Me.BtnBuscarNom.Name = "BtnBuscarNom"
        Me.BtnBuscarNom.Size = New System.Drawing.Size(136, 23)
        Me.BtnBuscarNom.TabIndex = 28
        Me.BtnBuscarNom.Text = "Buscar"
        Me.BtnBuscarNom.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(279, 233)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 23)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(39, 186)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(136, 23)
        Me.btnLimpiarCampos.TabIndex = 30
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'btnCxlConsulta
        '
        Me.btnCxlConsulta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCxlConsulta.Location = New System.Drawing.Point(39, 233)
        Me.btnCxlConsulta.Name = "btnCxlConsulta"
        Me.btnCxlConsulta.Size = New System.Drawing.Size(136, 23)
        Me.btnCxlConsulta.TabIndex = 31
        Me.btnCxlConsulta.Text = "Volver"
        Me.btnCxlConsulta.UseVisualStyleBackColor = True
        '
        'GbBuscar
        '
        Me.GbBuscar.Controls.Add(Me.BtnBuscarNom)
        Me.GbBuscar.Controls.Add(Me.txtBuscarNom)
        Me.GbBuscar.Location = New System.Drawing.Point(12, 28)
        Me.GbBuscar.Name = "GbBuscar"
        Me.GbBuscar.Size = New System.Drawing.Size(200, 100)
        Me.GbBuscar.TabIndex = 32
        Me.GbBuscar.TabStop = False
        Me.GbBuscar.Text = "Buscar alumno por nombre: "
        '
        'formConsAlu
        '
        Me.AcceptButton = Me.BtnBuscarNom
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCxlConsulta
        Me.ClientSize = New System.Drawing.Size(474, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.GbBuscar)
        Me.Controls.Add(Me.btnCxlConsulta)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnGuardar)
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
        Me.Name = "formConsAlu"
        Me.Text = "Consulta de Alumno"
        Me.GbBuscar.ResumeLayout(False)
        Me.GbBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCursoAlu As TextBox
    Friend WithEvents etqCursoAlu As Label
    Friend WithEvents txtMailAlu As TextBox
    Friend WithEvents etqMailAlu As Label
    Friend WithEvents txtTelAlu As TextBox
    Friend WithEvents etqTlfAlu As Label
    Friend WithEvents txtApeAlu As TextBox
    Friend WithEvents etqApeAlu As Label
    Friend WithEvents txtNomAlu As TextBox
    Friend WithEvents etqNomAlu As Label
    Friend WithEvents txtCodAlu As TextBox
    Friend WithEvents etqCodAlu As Label
    Friend WithEvents txtBuscarNom As TextBox
    Friend WithEvents BtnBuscarNom As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnCxlConsulta As Button
    Friend WithEvents GbBuscar As GroupBox
End Class
