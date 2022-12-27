Imports System.Data.Odbc
Public Class Admin
    Sub kosongkan()
        txtid.Text = ""
        txtnm.Text = ""
        txtusn.Text = ""
        txtpw.Text = ""
        txtemail.Text = ""
        txttlp.Text = ""
    End Sub
    Sub tampilDGV()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM admin", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "admin")
        DGV.DataSource = (ds.Tables("admin"))
        Gridvw()
    End Sub
    Sub AturKolom()
        DGV.Columns(0).Width = 45
        DGV.Columns(1).Width = 180
        DGV.Columns(2).Width = 180
        DGV.Columns(3).Width = 180
        DGV.Columns(4).Width = 180
        DGV.Columns(5).Width = 180
    End Sub
    Sub Gridvw()
        DGV.Columns(0).HeaderText = "ID"
        DGV.Columns(1).HeaderText = "NAMA"
        DGV.Columns(2).HeaderText = "USERNAME"
        DGV.Columns(3).HeaderText = "PASSWORD"
        DGV.Columns(4).HeaderText = "EMAIL"
        DGV.Columns(5).HeaderText = "TELEPON"
        Call AturKolom()
    End Sub

    Sub Aktifkan()
        txtid.Enabled = True
        txtnm.Enabled = True
        txtusn.Enabled = True
        txtpw.Enabled = True
        txtemail.Enabled = True
        txttlp.Enabled = True

        bsn.Enabled = True
        buh.Enabled = True
        bhs.Enabled = True
        bbl.Enabled = True
    End Sub

    Sub Nonaktifkan()
        txtid.Enabled = False
        txtnm.Enabled = False
        txtusn.Enabled = False
        txtpw.Enabled = False
        txtemail.Enabled = False
        txttlp.Enabled = False

        bsn.Enabled = False
        buh.Enabled = False
        bhs.Enabled = False
        bbl.Enabled = False
    End Sub
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        kosongkan()
        Nonaktifkan()
        tampilDGV()
    End Sub
    Private Sub bth_Click(sender As Object, e As EventArgs) Handles bth.Click
        Aktifkan()
    End Sub

    Private Sub btp_Click(sender As Object, e As EventArgs) Handles btp.Click
        Close()
    End Sub

    Private Sub bsn_Click(sender As Object, e As EventArgs) Handles bsn.Click
        Call koneksi()
        sql1 = "Insert Into admin () Values (" +
            "'" & txtid.Text & "'," +
            "'" & txtnm.Text & "'," +
            "'" & txtusn.Text & "'," +
            "'" & txtpw.Text & "'," +
            "'" & txtemail.Text & "'," +
            "'" & txttlp.Text & "')"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()
        Conn.Close()

        kosongkan()
        tampilDGV()
        Nonaktifkan()
    End Sub

    Private Sub bhs_Click(sender As Object, e As EventArgs) Handles bhs.Click
        Call koneksi()
        sql1 = "delete from admin where id_admin='" & txtid.Text & "';"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        kosongkan()
        tampilDGV()
        Nonaktifkan()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        txtid.Text = DGV.Item(0, i).Value
        txtnm.Text = DGV.Item(1, i).Value
        txtusn.Text = DGV.Item(2, i).Value
        txtpw.Text = DGV.Item(3, i).Value
        txtemail.Text = DGV.Item(4, i).Value
        txttlp.Text = DGV.Item(5, i).Value

        Aktifkan()
        txtid.Enabled = False
    End Sub
    Private Sub bbl_Click(sender As Object, e As EventArgs) Handles bbl.Click
        kosongkan()
    End Sub

    Private Sub buh_Click(sender As Object, e As EventArgs) Handles buh.Click
        Call koneksi()
        sql1 = "Update admin set nama='" & txtnm.Text & "', username='" & txtusn.Text & "', password='" & txtpw.Text & "', email='" & txtemail.Text & "', telepon='" & txttlp.Text & "' where id_admin ='" & txtid.Text & "'"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        tampilDGV()
        kosongkan()
        Nonaktifkan()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        If CBFILTER.SelectedIndex = 0 Then
            da = New OdbcDataAdapter("select * from admin where username like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        Else
            da = New OdbcDataAdapter("select * from admin where nama like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        End If
    End Sub
End Class