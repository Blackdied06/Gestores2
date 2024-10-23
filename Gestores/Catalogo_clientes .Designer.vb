<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogo_clientes
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
        btborrar_cliente = New Button()
        btguardar_cliente = New Button()
        btnuevo_cliente = New Button()
        Ct_telefono_cliente = New TextBox()
        ct_direccion_cliente = New TextBox()
        ct_nombre_cliente = New TextBox()
        ct_idcliente = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView_cliente = New DataGridView()
        btSalir_cliente = New Button()
        Ct_correo_cliente = New TextBox()
        Label4 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(DataGridView_cliente, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btborrar_cliente
        ' 
        btborrar_cliente.Location = New Point(573, 423)
        btborrar_cliente.Margin = New Padding(3, 4, 3, 4)
        btborrar_cliente.Name = "btborrar_cliente"
        btborrar_cliente.Size = New Size(97, 39)
        btborrar_cliente.TabIndex = 23
        btborrar_cliente.Text = "Borrar"
        btborrar_cliente.UseVisualStyleBackColor = True
        ' 
        ' btguardar_cliente
        ' 
        btguardar_cliente.Location = New Point(573, 367)
        btguardar_cliente.Margin = New Padding(3, 4, 3, 4)
        btguardar_cliente.Name = "btguardar_cliente"
        btguardar_cliente.Size = New Size(97, 39)
        btguardar_cliente.TabIndex = 22
        btguardar_cliente.Text = "Guardar"
        btguardar_cliente.UseVisualStyleBackColor = True
        ' 
        ' btnuevo_cliente
        ' 
        btnuevo_cliente.Location = New Point(573, 311)
        btnuevo_cliente.Margin = New Padding(3, 4, 3, 4)
        btnuevo_cliente.Name = "btnuevo_cliente"
        btnuevo_cliente.Size = New Size(97, 39)
        btnuevo_cliente.TabIndex = 21
        btnuevo_cliente.Text = "Nuevo"
        btnuevo_cliente.UseVisualStyleBackColor = True
        ' 
        ' Ct_telefono_cliente
        ' 
        Ct_telefono_cliente.Location = New Point(274, 416)
        Ct_telefono_cliente.Margin = New Padding(3, 4, 3, 4)
        Ct_telefono_cliente.Name = "Ct_telefono_cliente"
        Ct_telefono_cliente.Size = New Size(250, 27)
        Ct_telefono_cliente.TabIndex = 20
        ' 
        ' ct_direccion_cliente
        ' 
        ct_direccion_cliente.Location = New Point(274, 364)
        ct_direccion_cliente.Margin = New Padding(3, 4, 3, 4)
        ct_direccion_cliente.Name = "ct_direccion_cliente"
        ct_direccion_cliente.Size = New Size(250, 27)
        ct_direccion_cliente.TabIndex = 19
        ' 
        ' ct_nombre_cliente
        ' 
        ct_nombre_cliente.Location = New Point(274, 317)
        ct_nombre_cliente.Margin = New Padding(3, 4, 3, 4)
        ct_nombre_cliente.Name = "ct_nombre_cliente"
        ct_nombre_cliente.Size = New Size(250, 27)
        ct_nombre_cliente.TabIndex = 18
        ' 
        ' ct_idcliente
        ' 
        ct_idcliente.Location = New Point(274, 282)
        ct_idcliente.Margin = New Padding(3, 4, 3, 4)
        ct_idcliente.Name = "ct_idcliente"
        ct_idcliente.Size = New Size(250, 27)
        ct_idcliente.TabIndex = 17
        ct_idcliente.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 423)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 16
        Label3.Text = "Telefono:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 367)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 15
        Label2.Text = "Direccion:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(178, 316)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 14
        Label1.Text = "Nombre:"
        ' 
        ' DataGridView_cliente
        ' 
        DataGridView_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_cliente.Location = New Point(123, 23)
        DataGridView_cliente.Margin = New Padding(3, 4, 3, 4)
        DataGridView_cliente.Name = "DataGridView_cliente"
        DataGridView_cliente.RowHeadersWidth = 51
        DataGridView_cliente.RowTemplate.Height = 25
        DataGridView_cliente.Size = New Size(523, 225)
        DataGridView_cliente.TabIndex = 13
        ' 
        ' btSalir_cliente
        ' 
        btSalir_cliente.Location = New Point(573, 476)
        btSalir_cliente.Margin = New Padding(3, 4, 3, 4)
        btSalir_cliente.Name = "btSalir_cliente"
        btSalir_cliente.Size = New Size(97, 39)
        btSalir_cliente.TabIndex = 26
        btSalir_cliente.Text = "Salir"
        btSalir_cliente.UseVisualStyleBackColor = True
        ' 
        ' Ct_correo_cliente
        ' 
        Ct_correo_cliente.Location = New Point(264, 485)
        Ct_correo_cliente.Margin = New Padding(3, 4, 3, 4)
        Ct_correo_cliente.Name = "Ct_correo_cliente"
        Ct_correo_cliente.Size = New Size(250, 27)
        Ct_correo_cliente.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(178, 485)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 24
        Label4.Text = "Correo:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Catalogo_clientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 559)
        Controls.Add(btSalir_cliente)
        Controls.Add(Ct_correo_cliente)
        Controls.Add(Label4)
        Controls.Add(btborrar_cliente)
        Controls.Add(btguardar_cliente)
        Controls.Add(btnuevo_cliente)
        Controls.Add(Ct_telefono_cliente)
        Controls.Add(ct_direccion_cliente)
        Controls.Add(ct_nombre_cliente)
        Controls.Add(ct_idcliente)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView_cliente)
        Name = "Catalogo_clientes"
        Text = "Catalogo_clientes"
        CType(DataGridView_cliente, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btborrar_cliente As Button
    Friend WithEvents btguardar_cliente As Button
    Friend WithEvents btnuevo_cliente As Button
    Friend WithEvents Ct_telefono_cliente As TextBox
    Friend WithEvents ct_direccion_cliente As TextBox
    Friend WithEvents ct_nombre_cliente As TextBox
    Friend WithEvents ct_idcliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_cliente As DataGridView
    Friend WithEvents btSalir_cliente As Button
    Friend WithEvents Ct_correo_cliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
