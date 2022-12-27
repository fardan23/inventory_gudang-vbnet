<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txthrg = New System.Windows.Forms.TextBox()
        Me.txtnm = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidsp = New System.Windows.Forms.ComboBox()
        Me.CBFILTER = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.bth = New System.Windows.Forms.Button()
        Me.btp = New System.Windows.Forms.Button()
        Me.bbl = New System.Windows.Forms.Button()
        Me.buh = New System.Windows.Forms.Button()
        Me.bhs = New System.Windows.Forms.Button()
        Me.bsn = New System.Windows.Forms.Button()
        Me.txtjb = New System.Windows.Forms.ComboBox()
        Me.txtnmsp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(0, 378)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(741, 192)
        Me.DGV.TabIndex = 31
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(324, 159)
        Me.txtstok.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(357, 22)
        Me.txtstok.TabIndex = 25
        '
        'txthrg
        '
        Me.txthrg.Location = New System.Drawing.Point(324, 119)
        Me.txthrg.Margin = New System.Windows.Forms.Padding(4)
        Me.txthrg.Name = "txthrg"
        Me.txthrg.Size = New System.Drawing.Size(357, 22)
        Me.txthrg.TabIndex = 24
        '
        'txtnm
        '
        Me.txtnm.Location = New System.Drawing.Point(324, 80)
        Me.txtnm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(357, 22)
        Me.txtnm.TabIndex = 23
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(324, 40)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(227, 22)
        Me.txtid.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtidsp)
        Me.GroupBox1.Controls.Add(Me.CBFILTER)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcari)
        Me.GroupBox1.Controls.Add(Me.bth)
        Me.GroupBox1.Controls.Add(Me.btp)
        Me.GroupBox1.Controls.Add(Me.bbl)
        Me.GroupBox1.Controls.Add(Me.buh)
        Me.GroupBox1.Controls.Add(Me.bhs)
        Me.GroupBox1.Controls.Add(Me.bsn)
        Me.GroupBox1.Controls.Add(Me.txtjb)
        Me.GroupBox1.Controls.Add(Me.txtnmsp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtstok)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txthrg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 571)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HALAMAN BARANG"
        '
        'txtidsp
        '
        Me.txtidsp.FormattingEnabled = True
        Me.txtidsp.Location = New System.Drawing.Point(324, 239)
        Me.txtidsp.Name = "txtidsp"
        Me.txtidsp.Size = New System.Drawing.Size(96, 24)
        Me.txtidsp.TabIndex = 52
        '
        'CBFILTER
        '
        Me.CBFILTER.FormattingEnabled = True
        Me.CBFILTER.Location = New System.Drawing.Point(487, 339)
        Me.CBFILTER.Name = "CBFILTER"
        Me.CBFILTER.Size = New System.Drawing.Size(121, 24)
        Me.CBFILTER.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 342)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(615, 339)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(107, 22)
        Me.txtcari.TabIndex = 50
        '
        'bth
        '
        Me.bth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bth.FlatAppearance.BorderSize = 0
        Me.bth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bth.Location = New System.Drawing.Point(22, 146)
        Me.bth.Margin = New System.Windows.Forms.Padding(4)
        Me.bth.Name = "bth"
        Me.bth.Size = New System.Drawing.Size(109, 28)
        Me.bth.TabIndex = 42
        Me.bth.Text = "TAMBAH"
        Me.bth.UseVisualStyleBackColor = False
        '
        'btp
        '
        Me.btp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btp.FlatAppearance.BorderSize = 0
        Me.btp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btp.Location = New System.Drawing.Point(22, 325)
        Me.btp.Margin = New System.Windows.Forms.Padding(4)
        Me.btp.Name = "btp"
        Me.btp.Size = New System.Drawing.Size(109, 28)
        Me.btp.TabIndex = 41
        Me.btp.Text = "TUTUP"
        Me.btp.UseVisualStyleBackColor = False
        '
        'bbl
        '
        Me.bbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bbl.FlatAppearance.BorderSize = 0
        Me.bbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbl.Location = New System.Drawing.Point(22, 289)
        Me.bbl.Margin = New System.Windows.Forms.Padding(4)
        Me.bbl.Name = "bbl"
        Me.bbl.Size = New System.Drawing.Size(109, 28)
        Me.bbl.TabIndex = 40
        Me.bbl.Text = "BATAL"
        Me.bbl.UseVisualStyleBackColor = False
        '
        'buh
        '
        Me.buh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buh.FlatAppearance.BorderSize = 0
        Me.buh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buh.Location = New System.Drawing.Point(22, 253)
        Me.buh.Margin = New System.Windows.Forms.Padding(4)
        Me.buh.Name = "buh"
        Me.buh.Size = New System.Drawing.Size(109, 28)
        Me.buh.TabIndex = 39
        Me.buh.Text = "UBAH"
        Me.buh.UseVisualStyleBackColor = False
        '
        'bhs
        '
        Me.bhs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bhs.FlatAppearance.BorderSize = 0
        Me.bhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bhs.Location = New System.Drawing.Point(22, 218)
        Me.bhs.Margin = New System.Windows.Forms.Padding(4)
        Me.bhs.Name = "bhs"
        Me.bhs.Size = New System.Drawing.Size(109, 28)
        Me.bhs.TabIndex = 38
        Me.bhs.Text = "HAPUS"
        Me.bhs.UseVisualStyleBackColor = False
        '
        'bsn
        '
        Me.bsn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bsn.FlatAppearance.BorderSize = 0
        Me.bsn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsn.Location = New System.Drawing.Point(22, 182)
        Me.bsn.Margin = New System.Windows.Forms.Padding(4)
        Me.bsn.Name = "bsn"
        Me.bsn.Size = New System.Drawing.Size(109, 28)
        Me.bsn.TabIndex = 37
        Me.bsn.Text = "SIMPAN"
        Me.bsn.UseVisualStyleBackColor = False
        '
        'txtjb
        '
        Me.txtjb.FormattingEnabled = True
        Me.txtjb.Items.AddRange(New Object() {"barang ekonomi", "barang bebas", "barang subtitusi", "barang komplementer", "barang pribadi", "barang publik", "barang mentah", "barang setengah jadi", "barang jadi", "barang esensial", "barang normal", "barang inferior", "barang mewah", "barang bergerak", "barang tetap"})
        Me.txtjb.Location = New System.Drawing.Point(324, 200)
        Me.txtjb.Name = "txtjb"
        Me.txtjb.Size = New System.Drawing.Size(227, 24)
        Me.txtjb.TabIndex = 36
        '
        'txtnmsp
        '
        Me.txtnmsp.Location = New System.Drawing.Point(427, 239)
        Me.txtnmsp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnmsp.Name = "txtnmsp"
        Me.txtnmsp.Size = New System.Drawing.Size(254, 22)
        Me.txtnmsp.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Nama supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Jenis barang"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.inventory_fardan.My.Resources.Resources.rak_buku
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(22, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 97)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtstok As System.Windows.Forms.TextBox
    Friend WithEvents txthrg As System.Windows.Forms.TextBox
    Friend WithEvents txtnm As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtnmsp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtjb As System.Windows.Forms.ComboBox
    Friend WithEvents bth As System.Windows.Forms.Button
    Friend WithEvents btp As System.Windows.Forms.Button
    Friend WithEvents bbl As System.Windows.Forms.Button
    Friend WithEvents buh As System.Windows.Forms.Button
    Friend WithEvents bhs As System.Windows.Forms.Button
    Friend WithEvents bsn As System.Windows.Forms.Button
    Friend WithEvents CBFILTER As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtidsp As System.Windows.Forms.ComboBox
End Class
