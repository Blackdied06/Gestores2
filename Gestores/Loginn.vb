Imports MySql.Data.MySqlClient

Public Class Loginn
    Dim conn As New MySqlConnection
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click
        Dim SQL As String
        If ct_usuario.Text = "" Then
            MsgBox("Digite el usuario")
            ct_usuario.Focus()
            Exit Sub
        End If
        If ct_clave.Text = "" Then
            MsgBox("Digite la clave")
            ct_clave.Focus()
            Exit Sub
        End If
        SQL = "select * from usuarios WHERE username = '" & ct_usuario.Text &
       "' and password=md5('" & ct_clave.Text & "');"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            principall.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o clave invalido")
            ct_usuario.Text = ""
            ct_clave.Text = ""
            ct_usuario.Focus()
        End If
        lectura.Close()
    End Sub

    Private Sub ct_usuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ct_usuario.Validating
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(ct_usuario.Text) Then
            ErrorProvider1.SetError(ct_usuario, "El campo Nombre del cliente es obligatorio")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(ct_usuario, "")
        End If
    End Sub

    Private Sub ct_clave_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ct_clave.Validating
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(ct_clave.Text) Then
            ErrorProvider1.SetError(ct_clave, "El campo Nombre del cliente es obligatorio")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(ct_clave, "")
        End If
    End Sub
End Class