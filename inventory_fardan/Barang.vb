Imports System.Data.Odbc
Public Class Barang
    Sub kosongkan()
        txtid.Text = ""
        txtnm.Text = ""
        txthrg.Text = ""
        txtstok.Text = ""
        txtjb.Text = ""
        txtnmsp.Text = ""
    End Sub
    Sub tampilDGV()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM barang", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang")
        DGV.DataSource = (ds.Tables("barang"))
        Gridvw()
    End Sub
    Sub AturKolom()
        DGV.Columns(0).Width = 45
        DGV.Columns(1).Width = 180
        DGV.Columns(2).Width = 180
        DGV.Columns(3).Width = 140
        DGV.Columns(4).Width = 180
        DGV.Columns(5).Width = 140
        DGV.Columns(6).Width = 180
    End Sub
    Sub Gridvw()
        DGV.Columns(0).HeaderText = "ID"
        DGV.Columns(1).HeaderText = "NAMA"
        DGV.Columns(2).HeaderText = "HARGA"
        DGV.Columns(3).HeaderText = "STOK"
        DGV.Columns(4).HeaderText = "JENIS BARANG"
        DGV.Columns(5).HeaderText = "ID SUPPLIER"
        DGV.Columns(6).HeaderText = "NAMA SUPPLIER"
        Call AturKolom()
    End Sub

    Sub Aktifkan()
        txtid.Enabled = True
        txtnm.Enabled = True
        txthrg.Enabled = True
        txtstok.Enabled = True
        txtjb.Enabled = True
        txtidsp.Enabled = True
        txtnmsp.Enabled = True

        bsn.Enabled = True
        buh.Enabled = True
        bhs.Enabled = True
        bbl.Enabled = True
    End Sub

    Sub Nonaktifkan()
        txtid.Enabled = False
        txtnm.Enabled = False
        txthrg.Enabled = False
        txtstok.Enabled = False
        txtjb.Enabled = False
        txtidsp.Enabled = False
        txtnmsp.Enabled = False

        bsn.Enabled = False
        buh.Enabled = False
        bhs.Enabled = False
        bbl.Enabled = False
    End Sub
    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilDGV()
        Call koneksi()
        kosongkan()
        txtid.Focus()
        Nonaktifkan()

        cmd = New OdbcCommand("select * from supplier", Conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtidsp.Items.Add(dr.GetString(0))
        Loop
    End Sub

    Private Sub bth_Click(sender As Object, e As EventArgs) Handles bth.Click
        Aktifkan()
    End Sub

    Private Sub btp_Click(sender As Object, e As EventArgs) Handles btp.Click
        Close()
    End Sub

    Private Sub bsn_Click(sender As Object, e As EventArgs) Handles bsn.Click
        Call koneksi()
        sql1 = "Insert Into barang () Values (" +
            "'" & txtid.Text & "'," +
            "'" & txtnm.Text & "'," +
            "'" & txthrg.Text & "'," +
            "'" & txtstok.Text & "'," +
            "'" & txtjb.Text & "'," +
            "'" & txtidsp.Text & "'," +
            "'" & txtnmsp.Text & "')"
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
        sql1 = "delete from barang where id='" & txtid.Text & "';"
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
        txthrg.Text = DGV.Item(2, i).Value
        txtstok.Text = DGV.Item(3, i).Value
        txtjb.Text = DGV.Item(4, i).Value
        txtidsp.Text = DGV.Item(5, i).Value
        txtnmsp.Text = DGV.Item(6, i).Value

        Aktifkan()
        txtid.Enabled = False
    End Sub
    Private Sub bbl_Click(sender As Object, e As EventArgs) Handles bbl.Click
        kosongkan()
    End Sub

    Private Sub buh_Click(sender As Object, e As EventArgs) Handles buh.Click
        Call koneksi()
        sql1 = "Update barang set nama='" & txtnm.Text & "', harga='" & txthrg.Text & "', stok='" & txtstok.Text & "', jenis_barang='" & txtjb.Text & "', id_supplier ='" & txtidsp.Text & "', nama_supplier='" & txtnmsp.Text & "' where id ='" & txtid.Text & "'"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        tampilDGV()
        kosongkan()
        Nonaktifkan()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        If CBFILTER.SelectedIndex = 0 Then
            da = New OdbcDataAdapter("select * from barang where jenis_barang like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        Else
            da = New OdbcDataAdapter("select * from barang where nama like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub txtidsp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtidsp.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from supplier where id_supplier='" & txtidsp.Text & "'", Conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            txtnmsp.Text = dr.GetString(1)
        End If

        txtnmsp.Enabled = False
    End Sub
End Class