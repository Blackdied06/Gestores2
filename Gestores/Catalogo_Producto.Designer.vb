<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogo_Producto
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
        btSalir_producto = New Button()
        Ct_stock_minimo = New TextBox()
        Label4 = New Label()
        btborrar_producto = New Button()
        btguardar_producto = New Button()
        btnuevo_producto = New Button()
        Ct_precio_producto = New TextBox()
        Ct_descripcion_producto = New TextBox()
        Ct_nombre_producto = New TextBox()
        ct_idproducto = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView_Producto = New DataGridView()
        Label5 = New Label()
        Ct_producto_porcentaje = New TextBox()
        Label6 = New Label()
        Ct_producto_stock = New TextBox()
        Label7 = New Label()
        Ct_precio_ventas = New TextBox()
        ct_idproveedor = New ComboBox()
        Label8 = New Label()
        CType(DataGridView_Producto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btSalir_producto
        ' 
        btSalir_producto.Location = New Point(576, 466)
        btSalir_producto.Margin = New Padding(3, 4, 3, 4)
        btSalir_producto.Name = "btSalir_producto"
        btSalir_producto.Size = New Size(97, 39)
        btSalir_producto.TabIndex = 40
        btSalir_producto.Text = "Salir"
        btSalir_producto.UseVisualStyleBackColor = True
        ' 
        ' Ct_stock_minimo
        ' 
        Ct_stock_minimo.Location = New Point(277, 624)
        Ct_stock_minimo.Margin = New Padding(3, 4, 3, 4)
        Ct_stock_minimo.Name = "Ct_stock_minimo"
        Ct_stock_minimo.Size = New Size(250, 27)
        Ct_stock_minimo.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(222, 584)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 38
        Label4.Text = "stock"
        ' 
        ' btborrar_producto
        ' 
        btborrar_producto.Location = New Point(576, 413)
        btborrar_producto.Margin = New Padding(3, 4, 3, 4)
        btborrar_producto.Name = "btborrar_producto"
        btborrar_producto.Size = New Size(97, 39)
        btborrar_producto.TabIndex = 37
        btborrar_producto.Text = "Borrar"
        btborrar_producto.UseVisualStyleBackColor = True
        ' 
        ' btguardar_producto
        ' 
        btguardar_producto.Location = New Point(576, 357)
        btguardar_producto.Margin = New Padding(3, 4, 3, 4)
        btguardar_producto.Name = "btguardar_producto"
        btguardar_producto.Size = New Size(97, 39)
        btguardar_producto.TabIndex = 36
        btguardar_producto.Text = "Guardar"
        btguardar_producto.UseVisualStyleBackColor = True
        ' 
        ' btnuevo_producto
        ' 
        btnuevo_producto.Location = New Point(576, 301)
        btnuevo_producto.Margin = New Padding(3, 4, 3, 4)
        btnuevo_producto.Name = "btnuevo_producto"
        btnuevo_producto.Size = New Size(97, 39)
        btnuevo_producto.TabIndex = 35
        btnuevo_producto.Text = "Nuevo"
        btnuevo_producto.UseVisualStyleBackColor = True
        ' 
        ' Ct_precio_producto
        ' 
        Ct_precio_producto.Location = New Point(277, 406)
        Ct_precio_producto.Margin = New Padding(3, 4, 3, 4)
        Ct_precio_producto.Name = "Ct_precio_producto"
        Ct_precio_producto.Size = New Size(250, 27)
        Ct_precio_producto.TabIndex = 34
        ' 
        ' Ct_descripcion_producto
        ' 
        Ct_descripcion_producto.Location = New Point(277, 354)
        Ct_descripcion_producto.Margin = New Padding(3, 4, 3, 4)
        Ct_descripcion_producto.Name = "Ct_descripcion_producto"
        Ct_descripcion_producto.Size = New Size(250, 27)
        Ct_descripcion_producto.TabIndex = 33
        ' 
        ' Ct_nombre_producto
        ' 
        Ct_nombre_producto.Location = New Point(277, 307)
        Ct_nombre_producto.Margin = New Padding(3, 4, 3, 4)
        Ct_nombre_producto.Name = "Ct_nombre_producto"
        Ct_nombre_producto.Size = New Size(250, 27)
        Ct_nombre_producto.TabIndex = 32
        ' 
        ' ct_idproducto
        ' 
        ct_idproducto.Location = New Point(277, 272)
        ct_idproducto.Margin = New Padding(3, 4, 3, 4)
        ct_idproducto.Name = "ct_idproducto"
        ct_idproducto.Size = New Size(250, 27)
        ct_idproducto.TabIndex = 31
        ct_idproducto.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(165, 413)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 30
        Label3.Text = "precio compra:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 357)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 29
        Label2.Text = "Descripcion :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(204, 307)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 28
        Label1.Text = "Nombre:"
        ' 
        ' DataGridView_Producto
        ' 
        DataGridView_Producto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView_Producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Producto.Location = New Point(25, 13)
        DataGridView_Producto.Margin = New Padding(3, 4, 3, 4)
        DataGridView_Producto.Name = "DataGridView_Producto"
        DataGridView_Producto.RowHeadersWidth = 51
        DataGridView_Producto.RowTemplate.Height = 25
        DataGridView_Producto.Size = New Size(933, 241)
        DataGridView_Producto.TabIndex = 27
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(104, 479)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 20)
        Label5.TabIndex = 41
        Label5.Text = "Porcentaje de Ganancia:"
        ' 
        ' Ct_producto_porcentaje
        ' 
        Ct_producto_porcentaje.Location = New Point(277, 469)
        Ct_producto_porcentaje.Name = "Ct_producto_porcentaje"
        Ct_producto_porcentaje.Size = New Size(250, 27)
        Ct_producto_porcentaje.TabIndex = 42
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(165, 627)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 20)
        Label6.TabIndex = 43
        Label6.Text = "Stock minimo"
        ' 
        ' Ct_producto_stock
        ' 
        Ct_producto_stock.Location = New Point(277, 577)
        Ct_producto_stock.Margin = New Padding(3, 4, 3, 4)
        Ct_producto_stock.Name = "Ct_producto_stock"
        Ct_producto_stock.Size = New Size(250, 27)
        Ct_producto_stock.TabIndex = 44
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(174, 539)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 20)
        Label7.TabIndex = 45
        Label7.Text = "Precio Venta"
        ' 
        ' Ct_precio_ventas
        ' 
        Ct_precio_ventas.Location = New Point(280, 529)
        Ct_precio_ventas.Name = "Ct_precio_ventas"
        Ct_precio_ventas.ReadOnly = True
        Ct_precio_ventas.Size = New Size(253, 27)
        Ct_precio_ventas.TabIndex = 46
        ' 
        ' ct_idproveedor
        ' 
        ct_idproveedor.FormattingEnabled = True
        ct_idproveedor.Location = New Point(287, 679)
        ct_idproveedor.Name = "ct_idproveedor"
        ct_idproveedor.Size = New Size(240, 28)
        ct_idproveedor.TabIndex = 48
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(123, 687)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 20)
        Label8.TabIndex = 49
        Label8.Text = "Nombre de proveedor"
        ' 
        ' Catalogo_Producto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(970, 731)
        Controls.Add(Label8)
        Controls.Add(ct_idproveedor)
        Controls.Add(Ct_precio_ventas)
        Controls.Add(Label7)
        Controls.Add(Ct_producto_stock)
        Controls.Add(Label6)
        Controls.Add(Ct_producto_porcentaje)
        Controls.Add(Label5)
        Controls.Add(btSalir_producto)
        Controls.Add(Ct_stock_minimo)
        Controls.Add(Label4)
        Controls.Add(btborrar_producto)
        Controls.Add(btguardar_producto)
        Controls.Add(btnuevo_producto)
        Controls.Add(Ct_precio_producto)
        Controls.Add(Ct_descripcion_producto)
        Controls.Add(Ct_nombre_producto)
        Controls.Add(ct_idproducto)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView_Producto)
        Name = "Catalogo_Producto"
        Text = "Catalogo_Producto"
        CType(DataGridView_Producto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btSalir_producto As Button
    Friend WithEvents Ct_stock_minimo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btborrar_producto As Button
    Friend WithEvents btguardar_producto As Button
    Friend WithEvents btnuevo_producto As Button
    Friend WithEvents Ct_precio_producto As TextBox
    Friend WithEvents Ct_descripcion_producto As TextBox
    Friend WithEvents Ct_nombre_producto As TextBox
    Friend WithEvents ct_idproducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_Producto As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Ct_producto_porcentaje As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Ct_producto_stock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Ct_precio_ventas As TextBox
    Friend WithEvents ct_idproveedor As ComboBox
    Friend WithEvents Label8 As Label
End Class
