Imports MySql.Data.MySqlClient

Module connection
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("Server=localhost; Database=pemvis; User=root; Password=password;")
    End Function

    Public con As MySqlConnection = mysqldb()
End Module
