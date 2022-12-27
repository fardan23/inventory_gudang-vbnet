Imports System.Data.Odbc
Module KoneksiMOD
    Public Conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public strcon As String
    Public sql1 As String

    Sub koneksi()
        strcon = "Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;database=inventory_desktop_rpl1_fardan;port=3306"
        Conn = New OdbcConnection(strcon)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

End Module
