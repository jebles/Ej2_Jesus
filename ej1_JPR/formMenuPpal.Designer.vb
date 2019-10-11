<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenuPpal
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
        Me.components = New System.ComponentModel.Container()
        Me.etqOpc1 = New System.Windows.Forms.Label()
        Me.etqOpc2 = New System.Windows.Forms.Label()
        Me.etqOpc3 = New System.Windows.Forms.Label()
        Me.etqOpc4 = New System.Windows.Forms.Label()
        Me.etqOpc5 = New System.Windows.Forms.Label()
        Me.etqIntroOpc = New System.Windows.Forms.Label()
        Me.etqBvda = New System.Windows.Forms.Label()
        Me.etqVarUserMP = New System.Windows.Forms.Label()
        Me.textOpcionIn = New System.Windows.Forms.TextBox()
        Me.FormAluDataInBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormAluDataInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.FormAluDataInBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormAluDataInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etqOpc1
        '
        Me.etqOpc1.AutoSize = True
        Me.etqOpc1.Location = New System.Drawing.Point(41, 43)
        Me.etqOpc1.Name = "etqOpc1"
        Me.etqOpc1.Size = New System.Drawing.Size(106, 13)
        Me.etqOpc1.TabIndex = 0
        Me.etqOpc1.Text = "1. Introducir Alumnos"
        '
        'etqOpc2
        '
        Me.etqOpc2.AutoSize = True
        Me.etqOpc2.Location = New System.Drawing.Point(41, 76)
        Me.etqOpc2.Name = "etqOpc2"
        Me.etqOpc2.Size = New System.Drawing.Size(101, 13)
        Me.etqOpc2.TabIndex = 1
        Me.etqOpc2.Text = "2. Consultar Alumno"
        '
        'etqOpc3
        '
        Me.etqOpc3.AutoSize = True
        Me.etqOpc3.Location = New System.Drawing.Point(41, 109)
        Me.etqOpc3.Name = "etqOpc3"
        Me.etqOpc3.Size = New System.Drawing.Size(100, 13)
        Me.etqOpc3.TabIndex = 2
        Me.etqOpc3.Text = "3. Ordenar Alumnos"
        '
        'etqOpc4
        '
        Me.etqOpc4.AutoSize = True
        Me.etqOpc4.Location = New System.Drawing.Point(41, 142)
        Me.etqOpc4.Name = "etqOpc4"
        Me.etqOpc4.Size = New System.Drawing.Size(71, 13)
        Me.etqOpc4.TabIndex = 3
        Me.etqOpc4.Text = "4. Listar Array"
        '
        'etqOpc5
        '
        Me.etqOpc5.AutoSize = True
        Me.etqOpc5.Location = New System.Drawing.Point(41, 175)
        Me.etqOpc5.Name = "etqOpc5"
        Me.etqOpc5.Size = New System.Drawing.Size(33, 13)
        Me.etqOpc5.TabIndex = 4
        Me.etqOpc5.Text = "5. Fin"
        '
        'etqIntroOpc
        '
        Me.etqIntroOpc.AutoSize = True
        Me.etqIntroOpc.Location = New System.Drawing.Point(41, 228)
        Me.etqIntroOpc.Name = "etqIntroOpc"
        Me.etqIntroOpc.Size = New System.Drawing.Size(86, 13)
        Me.etqIntroOpc.TabIndex = 5
        Me.etqIntroOpc.Text = "Introducir opción"
        '
        'etqBvda
        '
        Me.etqBvda.AutoSize = True
        Me.etqBvda.Location = New System.Drawing.Point(150, 7)
        Me.etqBvda.Name = "etqBvda"
        Me.etqBvda.Size = New System.Drawing.Size(32, 13)
        Me.etqBvda.TabIndex = 7
        Me.etqBvda.Text = "Hola "
        '
        'etqVarUserMP
        '
        Me.etqVarUserMP.AutoSize = True
        Me.etqVarUserMP.Location = New System.Drawing.Point(176, 7)
        Me.etqVarUserMP.Name = "etqVarUserMP"
        Me.etqVarUserMP.Size = New System.Drawing.Size(32, 13)
        Me.etqVarUserMP.TabIndex = 8
        Me.etqVarUserMP.Text = "Hola "
        '
        'textOpcionIn
        '
        Me.textOpcionIn.Location = New System.Drawing.Point(133, 225)
        Me.textOpcionIn.Name = "textOpcionIn"
        Me.textOpcionIn.Size = New System.Drawing.Size(27, 20)
        Me.textOpcionIn.TabIndex = 9
        '
        'FormAluDataInBindingSource1
        '
        Me.FormAluDataInBindingSource1.DataSource = GetType(ej1_JPR.formAluDataIn)
        '
        'FormAluDataInBindingSource
        '
        Me.FormAluDataInBindingSource.DataSource = GetType(ej1_JPR.formAluDataIn)
        '
        'formMenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.textOpcionIn)
        Me.Controls.Add(Me.etqVarUserMP)
        Me.Controls.Add(Me.etqBvda)
        Me.Controls.Add(Me.etqIntroOpc)
        Me.Controls.Add(Me.etqOpc5)
        Me.Controls.Add(Me.etqOpc4)
        Me.Controls.Add(Me.etqOpc3)
        Me.Controls.Add(Me.etqOpc2)
        Me.Controls.Add(Me.etqOpc1)
        Me.Name = "formMenuPpal"
        Me.Text = "Alumnos"
        CType(Me.FormAluDataInBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormAluDataInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etqOpc1 As Label
    Friend WithEvents etqOpc2 As Label
    Friend WithEvents etqOpc3 As Label
    Friend WithEvents etqOpc4 As Label
    Friend WithEvents etqOpc5 As Label
    Friend WithEvents etqIntroOpc As Label
    Friend WithEvents etqBvda As Label
    Friend WithEvents etqVarUserMP As Label
    Friend WithEvents FormAluDataInBindingSource1 As BindingSource
    Friend WithEvents FormAluDataInBindingSource As BindingSource
    Friend WithEvents textOpcionIn As TextBox
End Class
