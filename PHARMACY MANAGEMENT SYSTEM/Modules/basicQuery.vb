Imports MySql.Data.MySqlClient

Module basicQuery

    Public Sub bQuery(ByVal query As String)
        Dim cmd As New MySqlCommand(query, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
End Module
