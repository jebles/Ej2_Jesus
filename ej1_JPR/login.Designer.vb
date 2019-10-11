<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txtUsNomIn = New System.Windows.Forms.TextBox()
        Me.etqNomUsIn = New System.Windows.Forms.Label()
        Me.etqUsPassIn = New System.Windows.Forms.Label()
        Me.txtUsPassIn = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLoginCXL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsNomIn
        '
        Me.txtUsNomIn.Location = New System.Drawing.Point(98, 57)
        Me.txtUsNomIn.Name = "txtUsNomIn"
        Me.txtUsNomIn.Size = New System.Drawing.Size(100, 20)
        Me.txtUsNomIn.TabIndex = 0
        '
        'etqNomUsIn
        '
        Me.etqNomUsIn.AutoSize = True
        Me.etqNomUsIn.Location = New System.Drawing.Point(52, 61)
        Me.etqNomUsIn.Name = "etqNomUsIn"
        Me.etqNomUsIn.Size = New System.Drawing.Size(44, 13)
        Me.etqNomUsIn.TabIndex = 2
        Me.etqNomUsIn.Text = "Nombre"
        '
        'etqUsPassIn
        '
        Me.etqUsPassIn.AutoSize = True
        Me.etqUsPassIn.Location = New System.Drawing.Point(35, 102)
        Me.etqUsPassIn.Name = "etqUsPassIn"
        Me.etqUsPassIn.Size = New System.Drawing.Size(61, 13)
        Me.etqUsPassIn.TabIndex = 4
        Me.etqUsPassIn.Text = "Contraseña"
        '
        'txtUsPassIn
        '
        Me.txtUsPassIn.Location = New System.Drawing.Point(99, 98)
        Me.txtUsPassIn.Name = "txtUsPassIn"
        Me.txtUsPassIn.Size = New System.Drawing.Size(100, 20)
        Me.txtUsPassIn.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(135, 147)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(64, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Loguear"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnLoginCXL
        '
        Me.btnLoginCXL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLoginCXL.Location = New System.Drawing.Point(43, 147)
        Me.btnLoginCXL.Name = "btnLoginCXL"
        Me.btnLoginCXL.Size = New System.Drawing.Size(63, 23)
        Me.btnLoginCXL.TabIndex = 6
        Me.btnLoginCXL.Text = "Cancelar"
        Me.btnLoginCXL.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnLoginCXL
        Me.ClientSize = New System.Drawing.Size(254, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLoginCXL)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.etqUsPassIn)
        Me.Controls.Add(Me.txtUsPassIn)
        Me.Controls.Add(Me.etqNomUsIn)
        Me.Controls.Add(Me.txtUsNomIn)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsNomIn As TextBox
    Friend WithEvents etqNomUsIn As Label
    Friend WithEvents etqUsPassIn As Label
    Friend WithEvents txtUsPassIn As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnLoginCXL As Button
End Class
