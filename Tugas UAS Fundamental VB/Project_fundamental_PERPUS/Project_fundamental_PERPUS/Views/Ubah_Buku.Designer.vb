<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_Buku
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_alamatgbr_ubah = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_stok_buku = New System.Windows.Forms.TextBox()
        Me.txt_harga_buku = New System.Windows.Forms.TextBox()
        Me.dtpc_tgl_buku = New System.Windows.Forms.DateTimePicker()
        Me.txt_lokasi_buku = New System.Windows.Forms.TextBox()
        Me.txt_thun_buku = New System.Windows.Forms.TextBox()
        Me.txt_penerbit_buku = New System.Windows.Forms.TextBox()
        Me.txt_pngrng_buku = New System.Windows.Forms.TextBox()
        Me.txt_judul_buku = New System.Windows.Forms.TextBox()
        Me.cbx_ktg_buku = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_btl_buku = New System.Windows.Forms.Button()
        Me.btn_simpan_buku = New System.Windows.Forms.Button()
        Me.btn_carigbr_buku = New System.Windows.Forms.Button()
        Me.pct_gbr_buku = New System.Windows.Forms.PictureBox()
        Me.txt_kode_buku = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pct_gbr_buku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txt_alamatgbr_ubah)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_stok_buku)
        Me.GroupBox1.Controls.Add(Me.txt_harga_buku)
        Me.GroupBox1.Controls.Add(Me.dtpc_tgl_buku)
        Me.GroupBox1.Controls.Add(Me.txt_lokasi_buku)
        Me.GroupBox1.Controls.Add(Me.txt_thun_buku)
        Me.GroupBox1.Controls.Add(Me.txt_penerbit_buku)
        Me.GroupBox1.Controls.Add(Me.txt_pngrng_buku)
        Me.GroupBox1.Controls.Add(Me.txt_judul_buku)
        Me.GroupBox1.Controls.Add(Me.cbx_ktg_buku)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_btl_buku)
        Me.GroupBox1.Controls.Add(Me.btn_simpan_buku)
        Me.GroupBox1.Controls.Add(Me.btn_carigbr_buku)
        Me.GroupBox1.Controls.Add(Me.pct_gbr_buku)
        Me.GroupBox1.Controls.Add(Me.txt_kode_buku)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Perpetua", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 489)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Buku"
        '
        'txt_alamatgbr_ubah
        '
        Me.txt_alamatgbr_ubah.BackColor = System.Drawing.Color.White
        Me.txt_alamatgbr_ubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamatgbr_ubah.Location = New System.Drawing.Point(209, 344)
        Me.txt_alamatgbr_ubah.Name = "txt_alamatgbr_ubah"
        Me.txt_alamatgbr_ubah.ReadOnly = True
        Me.txt_alamatgbr_ubah.Size = New System.Drawing.Size(233, 22)
        Me.txt_alamatgbr_ubah.TabIndex = 74
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(19, 344)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(167, 22)
        Me.TextBox7.TabIndex = 73
        Me.TextBox7.Text = "Alamat Gambar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 16)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = ":"
        '
        'txt_stok_buku
        '
        Me.txt_stok_buku.BackColor = System.Drawing.Color.White
        Me.txt_stok_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stok_buku.Location = New System.Drawing.Point(209, 316)
        Me.txt_stok_buku.Name = "txt_stok_buku"
        Me.txt_stok_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_stok_buku.TabIndex = 71
        '
        'txt_harga_buku
        '
        Me.txt_harga_buku.BackColor = System.Drawing.Color.White
        Me.txt_harga_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_harga_buku.Location = New System.Drawing.Point(209, 288)
        Me.txt_harga_buku.Name = "txt_harga_buku"
        Me.txt_harga_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_harga_buku.TabIndex = 70
        '
        'dtpc_tgl_buku
        '
        Me.dtpc_tgl_buku.CustomFormat = "yyyy-MM-dd"
        Me.dtpc_tgl_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpc_tgl_buku.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpc_tgl_buku.Location = New System.Drawing.Point(209, 260)
        Me.dtpc_tgl_buku.Name = "dtpc_tgl_buku"
        Me.dtpc_tgl_buku.Size = New System.Drawing.Size(233, 22)
        Me.dtpc_tgl_buku.TabIndex = 69
        Me.dtpc_tgl_buku.Value = New Date(2015, 3, 6, 0, 0, 0, 0)
        '
        'txt_lokasi_buku
        '
        Me.txt_lokasi_buku.BackColor = System.Drawing.Color.White
        Me.txt_lokasi_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lokasi_buku.Location = New System.Drawing.Point(209, 232)
        Me.txt_lokasi_buku.Name = "txt_lokasi_buku"
        Me.txt_lokasi_buku.ReadOnly = True
        Me.txt_lokasi_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_lokasi_buku.TabIndex = 68
        '
        'txt_thun_buku
        '
        Me.txt_thun_buku.BackColor = System.Drawing.Color.White
        Me.txt_thun_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_thun_buku.Location = New System.Drawing.Point(209, 204)
        Me.txt_thun_buku.MaxLength = 4
        Me.txt_thun_buku.Name = "txt_thun_buku"
        Me.txt_thun_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_thun_buku.TabIndex = 67
        '
        'txt_penerbit_buku
        '
        Me.txt_penerbit_buku.BackColor = System.Drawing.Color.White
        Me.txt_penerbit_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_penerbit_buku.Location = New System.Drawing.Point(209, 176)
        Me.txt_penerbit_buku.MaxLength = 15
        Me.txt_penerbit_buku.Name = "txt_penerbit_buku"
        Me.txt_penerbit_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_penerbit_buku.TabIndex = 66
        '
        'txt_pngrng_buku
        '
        Me.txt_pngrng_buku.BackColor = System.Drawing.Color.White
        Me.txt_pngrng_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pngrng_buku.Location = New System.Drawing.Point(209, 148)
        Me.txt_pngrng_buku.MaxLength = 20
        Me.txt_pngrng_buku.Name = "txt_pngrng_buku"
        Me.txt_pngrng_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_pngrng_buku.TabIndex = 65
        '
        'txt_judul_buku
        '
        Me.txt_judul_buku.BackColor = System.Drawing.Color.White
        Me.txt_judul_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_judul_buku.Location = New System.Drawing.Point(209, 120)
        Me.txt_judul_buku.MaxLength = 30
        Me.txt_judul_buku.Name = "txt_judul_buku"
        Me.txt_judul_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_judul_buku.TabIndex = 64
        '
        'cbx_ktg_buku
        '
        Me.cbx_ktg_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_ktg_buku.FormattingEnabled = True
        Me.cbx_ktg_buku.Location = New System.Drawing.Point(209, 92)
        Me.cbx_ktg_buku.Name = "cbx_ktg_buku"
        Me.cbx_ktg_buku.Size = New System.Drawing.Size(233, 24)
        Me.cbx_ktg_buku.TabIndex = 63
        Me.cbx_ktg_buku.Text = "- - - - Pilih - - - -"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(19, 288)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(167, 22)
        Me.TextBox2.TabIndex = 62
        Me.TextBox2.Text = "Harga"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(19, 316)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(167, 22)
        Me.TextBox4.TabIndex = 61
        Me.TextBox4.Text = "Stok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = ":"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(19, 260)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(167, 22)
        Me.TextBox5.TabIndex = 58
        Me.TextBox5.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = ":"
        '
        'btn_btl_buku
        '
        Me.btn_btl_buku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_btl_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_btl_buku.Location = New System.Drawing.Point(332, 389)
        Me.btn_btl_buku.Name = "btn_btl_buku"
        Me.btn_btl_buku.Size = New System.Drawing.Size(102, 35)
        Me.btn_btl_buku.TabIndex = 55
        Me.btn_btl_buku.Text = "Hapus"
        Me.btn_btl_buku.UseVisualStyleBackColor = True
        '
        'btn_simpan_buku
        '
        Me.btn_simpan_buku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_buku.Location = New System.Drawing.Point(224, 389)
        Me.btn_simpan_buku.Name = "btn_simpan_buku"
        Me.btn_simpan_buku.Size = New System.Drawing.Size(102, 35)
        Me.btn_simpan_buku.TabIndex = 54
        Me.btn_simpan_buku.Text = "Ubah"
        Me.btn_simpan_buku.UseVisualStyleBackColor = True
        '
        'btn_carigbr_buku
        '
        Me.btn_carigbr_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carigbr_buku.Location = New System.Drawing.Point(477, 287)
        Me.btn_carigbr_buku.Name = "btn_carigbr_buku"
        Me.btn_carigbr_buku.Size = New System.Drawing.Size(162, 23)
        Me.btn_carigbr_buku.TabIndex = 53
        Me.btn_carigbr_buku.Text = "Cari Gambar"
        Me.btn_carigbr_buku.UseVisualStyleBackColor = True
        '
        'pct_gbr_buku
        '
        Me.pct_gbr_buku.BackColor = System.Drawing.Color.White
        Me.pct_gbr_buku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_gbr_buku.Location = New System.Drawing.Point(477, 64)
        Me.pct_gbr_buku.Name = "pct_gbr_buku"
        Me.pct_gbr_buku.Size = New System.Drawing.Size(162, 215)
        Me.pct_gbr_buku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_gbr_buku.TabIndex = 52
        Me.pct_gbr_buku.TabStop = False
        '
        'txt_kode_buku
        '
        Me.txt_kode_buku.BackColor = System.Drawing.Color.White
        Me.txt_kode_buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode_buku.Location = New System.Drawing.Point(209, 64)
        Me.txt_kode_buku.Name = "txt_kode_buku"
        Me.txt_kode_buku.ReadOnly = True
        Me.txt_kode_buku.Size = New System.Drawing.Size(233, 22)
        Me.txt_kode_buku.TabIndex = 43
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(19, 204)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(167, 22)
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.Text = "Tahun Terbit"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(19, 232)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(167, 22)
        Me.TextBox3.TabIndex = 39
        Me.TextBox3.Text = "Lokasi Rak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = ":"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(19, 120)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(167, 22)
        Me.TextBox11.TabIndex = 35
        Me.TextBox11.Text = "Judul"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(19, 92)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(167, 22)
        Me.TextBox12.TabIndex = 34
        Me.TextBox12.Text = "Kategori"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(19, 176)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(167, 22)
        Me.TextBox9.TabIndex = 33
        Me.TextBox9.Text = "Penerbit"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(19, 148)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(167, 22)
        Me.TextBox10.TabIndex = 32
        Me.TextBox10.Text = "Pengarang"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(19, 64)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(167, 22)
        Me.TextBox8.TabIndex = 31
        Me.TextBox8.Text = "Kode Buku"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(192, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(192, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(192, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = ":"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Ubah_Buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Ubah_Buku"
        Me.Text = "Ubah_Buku"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pct_gbr_buku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_stok_buku As System.Windows.Forms.TextBox
    Friend WithEvents txt_harga_buku As System.Windows.Forms.TextBox
    Friend WithEvents dtpc_tgl_buku As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_lokasi_buku As System.Windows.Forms.TextBox
    Friend WithEvents txt_thun_buku As System.Windows.Forms.TextBox
    Friend WithEvents txt_penerbit_buku As System.Windows.Forms.TextBox
    Friend WithEvents txt_pngrng_buku As System.Windows.Forms.TextBox
    Friend WithEvents txt_judul_buku As System.Windows.Forms.TextBox
    Friend WithEvents cbx_ktg_buku As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_btl_buku As System.Windows.Forms.Button
    Friend WithEvents btn_simpan_buku As System.Windows.Forms.Button
    Friend WithEvents btn_carigbr_buku As System.Windows.Forms.Button
    Friend WithEvents pct_gbr_buku As System.Windows.Forms.PictureBox
    Friend WithEvents txt_kode_buku As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_alamatgbr_ubah As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
