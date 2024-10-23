Imports MySql.Data.MySqlClient

Public Class Catalogo_clientes
    Dim conn As New MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from clientes order by id_cliente"
        DataGridView_cliente.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo_cliente.Click
        Me.ct_idcliente.Text = ""
        Me.ct_nombre_cliente.Text = ""
        Me.ct_direccion_cliente.Text = ""
        Me.Ct_telefono_cliente.Text = ""
        Me.Ct_correo_cliente.Text = ""
        Me.ct_nombre_cliente.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar_cliente.Click
        If ct_nombre_cliente.Text = "" Then
            MessageBox.Show("Digite el nombre del cliente")
            ct_nombre_cliente.Focus()
            Exit Sub
        End If
        If ct_direccion_cliente.Text = "" Then
            MessageBox.Show("Digite la dirección")
            ct_direccion_cliente.Focus()
            Exit Sub
        End If
        If Ct_telefono_cliente.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            Ct_telefono_cliente.Focus()
            Exit Sub
        End If
        If Ct_correo_cliente.Text = "" Then
            MessageBox.Show("Digite el correo")
            Ct_correo_cliente.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL, var As String
        SQL = "select id_cliente from clientes WHERE id_cliente = '" &
        ct_idcliente.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE clientes set nombre='" & ct_nombre_cliente.Text & "' " &
            ",direccion='" & ct_direccion_cliente.Text &
            "',telefono='" & Ct_telefono_cliente.Text &
            "',email='" & Ct_correo_cliente.Text &
            "' where id_clientes='" & ct_idcliente.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO clientes values(null,'" & ct_nombre_cliente.Text & "','" &
            ct_direccion_cliente.Text & "','" & Ct_telefono_cliente.Text & "','" & Ct_correo_cliente.Text & "')"
        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from clientes order by nombre"
        DataGridView_cliente.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar_cliente.Click
        If ct_idcliente.Text = "" Then
            MessageBox.Show("Seleccione un cliente")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) =
        Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from clientes WHERE id_cliente = '" &
        ct_idcliente.Text & "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from clientes order by nombre"
        DataGridView_cliente.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir_cliente.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_cliente.CellContentClick
        Dim cliente As String
        cliente = DataGridView_cliente.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "SELECT * FROM clientes WHERE id_cliente = '" & cliente &
        "'"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            Me.ct_idcliente.Text = lectura("id_cliente").ToString
            Me.ct_nombre_cliente.Text = lectura("nombre").ToString
            Me.ct_direccion_cliente.Text = lectura("direccion").ToString
            Me.Ct_telefono_cliente.Text = lectura("telefono").ToString
            Me.Ct_correo_cliente.Text = lectura("email").ToString
        End If
        lectura.Close()
    End Sub

    Private Sub ct_nombre_cliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ct_nombre_cliente.Validating
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(ct_nombre_cliente.Text) Then
            ErrorProvider1.SetError(ct_nombre_cliente, "El campo Nombre del cliente es obligatorio")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(ct_nombre_cliente, "")
        End If

    End Sub

    Private Sub ct_direccion_cliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ct_direccion_cliente.Validating
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(ct_direccion_cliente.Text) Then
            ErrorProvider1.SetError(ct_direccion_cliente, "El campo direccion del cliente es obligatorio")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(ct_direccion_cliente, "")
        End If
    End Sub

    Private Sub Ct_correo_cliente_TextChanged(sender As Object, e As EventArgs) Handles Ct_correo_cliente.TextChanged
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(Ct_correo_cliente.Text) Then
            ErrorProvider1.SetError(Ct_correo_cliente, "El campo Nombre del cliente es obligatorio")

        Else
            ErrorProvider1.SetError(Ct_correo_cliente, "")
        End If
    End Sub
End Class