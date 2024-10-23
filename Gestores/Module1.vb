Imports MySql.Data.MySqlClient
Module Module1
    Public Function conectar()
        Dim conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;userid=root;password=12345678$;database=inventario;"
            conexion.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido realizar la conexion a la base de datos.")
            End
        End Try
        Return conexion
    End Function
    Function cargar_grid(ByVal sql As String, ByVal conn As MySqlConnection)
        Dim da As New MySqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        'llenar el dataset
        da.Fill(ds)
        Return ds.Tables(0)
    End Function
End Module
