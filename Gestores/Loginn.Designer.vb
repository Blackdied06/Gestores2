<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginn
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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        Enviar = New Button()
        ct_clave = New TextBox()
        ct_usuario = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Enviar)
        GroupBox1.Controls.Add(ct_clave)
        GroupBox1.Controls.Add(ct_usuario)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(71, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(683, 359)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inicio de sesion"
        ' 
        ' Enviar
        ' 
        Enviar.Location = New Point(197, 209)
        Enviar.Name = "Enviar"
        Enviar.Size = New Size(120, 29)
        Enviar.TabIndex = 4
        Enviar.Text = "Iniciar sesion"
        Enviar.UseVisualStyleBackColor = True
        ' 
        ' ct_clave
        ' 
        ct_clave.Location = New Point(165, 140)
        ct_clave.Name = "ct_clave"
        ct_clave.PasswordChar = "*"c
        ct_clave.Size = New Size(185, 27)
        ct_clave.TabIndex = 3
        ' 
        ' ct_usuario
        ' 
        ct_usuario.Location = New Point(165, 93)
        ct_usuario.Name = "ct_usuario"
        ct_usuario.Size = New Size(185, 27)
        ct_usuario.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 1
        Label2.Text = "Usuario "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 0
        Label1.Text = "Contraseña"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Loginn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Loginn"
        Text = "Loginn"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ct_clave As TextBox
    Friend WithEvents ct_usuario As TextBox
    Friend WithEvents Enviar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
