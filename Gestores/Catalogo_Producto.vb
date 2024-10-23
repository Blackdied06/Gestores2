Imports MySql.Data.MySqlClient

Public Class Catalogo_Producto
    Dim conn As New MySqlConnection
    Private Sub Catalogo_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from productos order by id_producto"
        DataGridView_Producto.DataSource = cargar_grid(SQL, conn)

        SQL = "select * from proveedores order by nombre"
        Dim da1 As New MySqlDataAdapter(SQL, conn)
        Dim ds1 As New DataSet
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            With Me.ct_idproveedor
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = ds1.Tables(0)
                .DisplayMember = "nombre"
                .ValueMember = "id_proveedor"
                .SelectedIndex = -1
            End With
        End If
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo_producto.Click
        Me.ct_idproducto.Text = ""
        Me.Ct_nombre_producto.Text = ""
        Me.Ct_descripcion_producto.Text = ""
        Me.Ct_precio_producto.Text = ""
        Me.Ct_producto_porcentaje.Text = ""
        Me.Ct_precio_ventas.Text = ""
        Me.Ct_producto_stock.Text = ""
        Me.Ct_stock_minimo.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar_producto.Click
        If Ct_nombre_producto.Text = "" Then
            MessageBox.Show("Digite el nombre del Producto")
            Ct_nombre_producto.Focus()
            Exit Sub
        End If
        If Ct_descripcion_producto.Text = "" Then
            MessageBox.Show("Digite la descripcion")
            Ct_descripcion_producto.Focus()
            Exit Sub
        End If
        If Ct_precio_producto.Text = "" And Ct_precio_producto.Text = "-" Then
            MessageBox.Show("Digite bien el precio")
            Ct_precio_producto.Focus()
            Exit Sub
        End If
        If Ct_producto_porcentaje.Text = "" Then
            MessageBox.Show("Digite el porcentaje de Ganancia")
            Ct_producto_porcentaje.Focus()
            Exit Sub
        End If
        If Ct_precio_ventas.Text = "" Then
            MessageBox.Show("No se ha calculado el precio venta")
            Ct_precio_ventas.Focus()
            Exit Sub
        End If

        If Ct_producto_stock.Text = "" Then
            MessageBox.Show("Ingrese bien el stock")
            Ct_producto_stock.Focus()
            Exit Sub
        End If
        If Ct_stock_minimo.Text = "" Then
            MessageBox.Show("ingrese el stock minimo")
            Ct_stock_minimo.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        SQL = "select id_producto from productos WHERE id_producto = '" &
        ct_idproducto.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE productos set nombre='" & Ct_nombre_producto.Text & "' " &
            ",descripcion='" & Ct_descripcion_producto.Text &
            ",precio_compra=" & Ct_precio_producto.Text &
            ",porcentaje_ganancia=" & Ct_producto_porcentaje.Text &
            ",precio_venta=" & Ct_precio_ventas.Text &
            ",stock=" & Ct_producto_stock.Text &
            ",stock_minimo=" & Ct_stock_minimo.Text &
            ",id_proveedor=" & ct_idproveedor.SelectedValue &
            "' where id_producto =" & ct_idproducto.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO productos values(null,'" & Ct_nombre_producto.Text & "','" &
            Ct_descripcion_producto.Text & "'," & Ct_precio_producto.Text & "," & Ct_producto_porcentaje.Text & "," & Ct_precio_ventas.Text & "," & Ct_producto_stock.Text & "," & Ct_stock_minimo.Text & "," & ct_idproveedor.SelectedValue & ")"
        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from productos order by nombre"
        DataGridView_Producto.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar_producto.Click
        If ct_idproducto.Text = "" Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) =
        Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from producto WHERE id_producto = '" &
        ct_idproducto.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from productos order by nombre"
        DataGridView_Producto.DataSource = cargar_grid(SQL, conn)
    End Sub
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir_producto.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_producto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Producto.CellContentClick
        Dim Producto As String
        Producto = DataGridView_Producto.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "SELECT * FROM productos WHERE id_producto = '" & Producto &
        "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            Me.ct_idproducto.Text = lectura("id_producto").ToString
            Me.Ct_nombre_producto.Text = lectura("nombre").ToString
            Me.Ct_descripcion_producto.Text = lectura("descripcion").ToString
            Me.Ct_precio_producto.Text = lectura("precio_compra").ToString
            Me.Ct_producto_porcentaje.Text = lectura("porcentaje_ganancia").ToString
            Me.Ct_precio_ventas.Text = lectura("precio_venta").ToString
            Me.Ct_producto_stock.Text = lectura("Stock").ToString
            Me.Ct_stock_minimo.Text = lectura("stock_minimo".ToString)
        End If
        lectura.Close()
    End Sub


    Private Sub Ct_producto_porcentaje_LostFocus(sender As Object, e As EventArgs) Handles Ct_producto_porcentaje.LostFocus
        Dim precio, porcentaje, ganancia, venta As Double

        ' Validar que Ct_precio_producto y Ct_producto_porcentaje contengan solo números y sean mayores a 0
        If IsNumeric(Ct_precio_producto.Text) AndAlso IsNumeric(Ct_producto_porcentaje.Text) Then
            precio = Double.Parse(Ct_precio_producto.Text)
            porcentaje = Double.Parse(Ct_producto_porcentaje.Text)

            ' Verificar que los valores no sean negativos ni cero
            If precio > 0 AndAlso porcentaje >= 0 Then
                porcentaje = porcentaje / 100 ' Convertir porcentaje a decimal
                ganancia = porcentaje * precio
                venta = precio + ganancia
                Ct_precio_ventas.Text = venta.ToString()
            Else
                MessageBox.Show("El precio y el porcentaje deben ser mayores a 0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, ingrese solo números válidos en los campos de precio y porcentaje.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class