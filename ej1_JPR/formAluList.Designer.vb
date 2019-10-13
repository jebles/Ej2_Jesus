<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAluList
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSalirList = New System.Windows.Forms.Button()
        Me.btnFinList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 429)
        Me.TextBox1.TabIndex = 0
        '
        'btnSalirList
        '
        Me.btnSalirList.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalirList.Location = New System.Drawing.Point(22, 458)
        Me.btnSalirList.Name = "btnSalirList"
        Me.btnSalirList.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirList.TabIndex = 1
        Me.btnSalirList.Text = "Salir"
        Me.btnSalirList.UseVisualStyleBackColor = True
        '
        'btnFinList
        '
        Me.btnFinList.Location = New System.Drawing.Point(163, 458)
        Me.btnFinList.Name = "btnFinList"
        Me.btnFinList.Size = New System.Drawing.Size(75, 23)
        Me.btnFinList.TabIndex = 2
        Me.btnFinList.Text = "Fin"
        Me.btnFinList.UseVisualStyleBackColor = True
        '
        'formAluList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalirList
        Me.ClientSize = New System.Drawing.Size(267, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFinList)
        Me.Controls.Add(Me.btnSalirList)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "formAluList"
        Me.Text = "Listado de Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSalirList As Button
    Friend WithEvents btnFinList As Button
End Class
