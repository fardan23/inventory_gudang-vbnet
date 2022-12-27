<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnm = New System.Windows.Forms.TextBox()
        Me.txtusn = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.txttlp = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.bsn = New System.Windows.Forms.Button()
        Me.bhs = New System.Windows.Forms.Button()
        Me.buh = New System.Windows.Forms.Button()
        Me.bbl = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBFILTER = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.bth = New System.Windows.Forms.Button()
        Me.btp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 213)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email"
        '
        'txtnm
        '
        Me.txtnm.Location = New System.Drawing.Point(368, 79)
        Me.txtnm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(301, 22)
        Me.txtnm.TabIndex = 6
        '
        'txtusn
        '
        Me.txtusn.Location = New System.Drawing.Point(368, 123)
        Me.txtusn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusn.Name = "txtusn"
        Me.txtusn.Size = New System.Drawing.Size(301, 22)
        Me.txtusn.TabIndex = 7
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(368, 165)
        Me.txtpw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(301, 22)
        Me.txtpw.TabIndex = 8
        '
        'txttlp
        '
        Me.txttlp.Location = New System.Drawing.Point(368, 253)
        Me.txttlp.Margin = New System.Windows.Forms.Padding(4)
        Me.txttlp.Name = "txttlp"
        Me.txttlp.Size = New System.Drawing.Size(301, 22)
        Me.txttlp.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(368, 210)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(301, 22)
        Me.txtemail.TabIndex = 10
        '
        'bsn
        '
        Me.bsn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bsn.FlatAppearance.BorderSize = 0
        Me.bsn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsn.Location = New System.Drawing.Point(28, 176)
        Me.bsn.Margin = New System.Windows.Forms.Padding(4)
        Me.bsn.Name = "bsn"
        Me.bsn.Size = New System.Drawing.Size(109, 28)
        Me.bsn.TabIndex = 11
        Me.bsn.Text = "SIMPAN"
        Me.bsn.UseVisualStyleBackColor = False
        '
        'bhs
        '
        Me.bhs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bhs.FlatAppearance.BorderSize = 0
        Me.bhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bhs.Location = New System.Drawing.Point(28, 212)
        Me.bhs.Margin = New System.Windows.Forms.Padding(4)
        Me.bhs.Name = "bhs"
        Me.bhs.Size = New System.Drawing.Size(109, 28)
        Me.bhs.TabIndex = 12
        Me.bhs.Text = "HAPUS"
        Me.bhs.UseVisualStyleBackColor = False
        '
        'buh
        '
        Me.buh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buh.FlatAppearance.BorderSize = 0
        Me.buh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buh.Location = New System.Drawing.Point(28, 247)
        Me.buh.Margin = New System.Windows.Forms.Padding(4)
        Me.buh.Name = "buh"
        Me.buh.Size = New System.Drawing.Size(109, 28)
        Me.buh.TabIndex = 13
        Me.buh.Text = "UBAH"
        Me.buh.UseVisualStyleBackColor = False
        '
        'bbl
        '
        Me.bbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bbl.FlatAppearance.BorderSize = 0
        Me.bbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbl.Location = New System.Drawing.Point(28, 283)
        Me.bbl.Margin = New System.Windows.Forms.Padding(4)
        Me.bbl.Name = "bbl"
        Me.bbl.Size = New System.Drawing.Size(109, 28)
        Me.bbl.TabIndex = 14
        Me.bbl.Text = "BATAL"
        Me.bbl.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(0, 363)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(721, 176)
        Me.DGV.TabIndex = 15
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(368, 35)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(204, 22)
        Me.txtid.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(196, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CBFILTER)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcari)
        Me.GroupBox1.Controls.Add(Me.bth)
        Me.GroupBox1.Controls.Add(Me.btp)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtpw)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.bbl)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.buh)
        Me.GroupBox1.Controls.Add(Me.bhs)
        Me.GroupBox1.Controls.Add(Me.bsn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtnm)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtusn)
        Me.GroupBox1.Controls.Add(Me.txttlp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 539)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HALAMAN ADMIN"
        '
        'CBFILTER
        '
        Me.CBFILTER.FormattingEnabled = True
        Me.CBFILTER.Location = New System.Drawing.Point(471, 325)
        Me.CBFILTER.Name = "CBFILTER"
        Me.CBFILTER.Size = New System.Drawing.Size(121, 24)
        Me.CBFILTER.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 328)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(599, 325)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(107, 22)
        Me.txtcari.TabIndex = 22
        '
        'bth
        '
        Me.bth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bth.FlatAppearance.BorderSize = 0
        Me.bth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bth.Location = New System.Drawing.Point(28, 140)
        Me.bth.Margin = New System.Windows.Forms.Padding(4)
        Me.bth.Name = "bth"
        Me.bth.Size = New System.Drawing.Size(109, 28)
        Me.bth.TabIndex = 20
        Me.bth.Text = "TAMBAH"
        Me.bth.UseVisualStyleBackColor = False
        '
        'btp
        '
        Me.btp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btp.FlatAppearance.BorderSize = 0
        Me.btp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btp.Location = New System.Drawing.Point(28, 319)
        Me.btp.Margin = New System.Windows.Forms.Padding(4)
        Me.btp.Name = "btp"
        Me.btp.Size = New System.Drawing.Size(109, 28)
        Me.btp.TabIndex = 19
        Me.btp.Text = "TUTUP"
        Me.btp.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.inventory_fardan.My.Resources.Resources.admin
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(28, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 97)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(747, 566)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnm As System.Windows.Forms.TextBox
    Friend WithEvents txtusn As System.Windows.Forms.TextBox
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents txttlp As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents bsn As System.Windows.Forms.Button
    Friend WithEvents bhs As System.Windows.Forms.Button
    Friend WithEvents buh As System.Windows.Forms.Button
    Friend WithEvents bbl As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bth As System.Windows.Forms.Button
    Friend WithEvents btp As System.Windows.Forms.Button
    Friend WithEvents CBFILTER As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
End Class
