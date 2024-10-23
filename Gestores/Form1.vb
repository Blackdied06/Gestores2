Imports MySql.Data.MySqlClient
Imports MySql

Public Class Form1
    Dim conn As New MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from proveedores order by id_proveedor"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.ct_idproveedor.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.Ct_telefono.Text = ""
        Me.Ct_correo.Text = ""
        Me.ct_nombre.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del proveedor")
            ct_nombre.Focus()
            Exit Sub
        End If
        If ct_direccion.Text = "" Then
            MessageBox.Show("Digite la dirección")
            ct_direccion.Focus()
            Exit Sub
        End If
        If Ct_telefono.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            Ct_telefono.Focus()
            Exit Sub
        End If
        If Ct_correo.Text = "" Then
            MessageBox.Show("Digite el correo")
            Ct_correo.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        SQL = "select id_proveedor from proveedores WHERE id_proveedor = '" &
        ct_idproveedor.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE proveedores set nombre='" & ct_nombre.Text & "' " &
            ",direccion='" & ct_direccion.Text &
            "',telefono='" & Ct_telefono.Text &
            "',email='" & Ct_correo.Text &
            "' where id_proveedor='" & ct_idproveedor.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO proveedores values(null,'" & ct_nombre.Text & "','" &
            ct_direccion.Text & "','" & Ct_telefono.Text & "','" & Ct_correo.Text & "')"
        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from proveedores order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idproveedor.Text = "" Then
            MessageBox.Show("Seleccione un proveedor")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) =
        Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from producto WHERE cod_producto = '" &
        ct_idproveedor.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from proveedores order by nombre"
        DataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim proveedor As String
        proveedor = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "SELECT * FROM proveedores WHERE id_proveedor = '" & proveedor &
        "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            Me.ct_idproveedor.Text = lectura("id_proveedor").ToString
            Me.ct_nombre.Text = lectura("nombre").ToString
            Me.ct_direccion.Text = lectura("direccion").ToString
            Me.Ct_telefono.Text = lectura("telefono").ToString
            Me.Ct_correo.Text = lectura("email").ToString
        End If
        lectura.Close()
    End Sub
End Class
