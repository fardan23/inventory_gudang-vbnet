Imports System.Data.Odbc
Public Class Supplier
    Sub kosongkan()
        txtid.Text = ""
        txtnm.Text = ""
        txtalmt.Text = ""
        txttlp.Text = ""
        txtemail.Text = ""
        txtkntk.Text = ""
    End Sub
    Sub tampilDGV()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM supplier", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "supplier")
        DGV.DataSource = (ds.Tables("supplier"))
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
        DGV.Columns(2).HeaderText = "ALAMAT"
        DGV.Columns(3).HeaderText = "TELEPON"
        DGV.Columns(4).HeaderText = "EMAIL"
        DGV.Columns(5).HeaderText = "KONTAK"
        Call AturKolom()
    End Sub

    Sub Aktifkan()
        txtid.Enabled = True
        txtnm.Enabled = True
        txtalmt.Enabled = True
        txttlp.Enabled = True
        txtemail.Enabled = True
        txtkntk.Enabled = True

        bsn.Enabled = True
        buh.Enabled = True
        bhs.Enabled = True
        bbl.Enabled = True
    End Sub

    Sub Nonaktifkan()
        txtid.Enabled = False
        txtnm.Enabled = False
        txtalmt.Enabled = False
        txttlp.Enabled = False
        txtemail.Enabled = False
        txtkntk.Enabled = False

        bsn.Enabled = False
        buh.Enabled = False
        bhs.Enabled = False
        bbl.Enabled = False
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilDGV()
        Call koneksi()
        kosongkan()
        Nonaktifkan()
    End Sub

    Private Sub bth_Click(sender As Object, e As EventArgs) Handles bth.Click
        Aktifkan()
    End Sub

    Private Sub btp_Click(sender As Object, e As EventArgs) Handles btp.Click
        Close()
    End Sub

    Private Sub bsn_Click(sender As Object, e As EventArgs) Handles bsn.Click
        Call koneksi()
        sql1 = "Insert Into supplier () Values (" +
            "'" & txtid.Text & "'," +
            "'" & txtnm.Text & "'," +
            "'" & txtalmt.Text & "'," +
            "'" & txttlp.Text & "'," +
            "'" & txtemail.Text & "'," +
            "'" & txtkntk.Text & "')"
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
        sql1 = "delete from supplier where id_supplier='" & txtid.Text & "';"
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
        txtalmt.Text = DGV.Item(2, i).Value
        txttlp.Text = DGV.Item(3, i).Value
        txtemail.Text = DGV.Item(4, i).Value
        txtkntk.Text = DGV.Item(5, i).Value

        Aktifkan()
        txtid.Enabled = False
    End Sub
    Private Sub bbl_Click(sender As Object, e As EventArgs) Handles bbl.Click
        kosongkan()
    End Sub

    Private Sub buh_Click(sender As Object, e As EventArgs) Handles buh.Click
        Call koneksi()
        sql1 = "Update supplier set nama='" & txtnm.Text & "', alamat='" & txtalmt.Text & "', telepon='" & txttlp.Text & "', email='" & txtemail.Text & "', kontak='" & txtkntk.Text & "' where id_supplier ='" & txtid.Text & "'"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        tampilDGV()
        kosongkan()
        Nonaktifkan()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        If CBFILTER.SelectedIndex = 0 Then
            da = New OdbcDataAdapter("select * from supplier where alamat like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        Else
            da = New OdbcDataAdapter("select * from supplier where nama like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        End If
    End Sub
End Class