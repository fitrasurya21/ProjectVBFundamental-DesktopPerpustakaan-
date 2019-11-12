<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uc_Anggota
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_alamatgbr_anggota = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_btl_anggota = New System.Windows.Forms.Button()
        Me.btn_simpan_anggota = New System.Windows.Forms.Button()
        Me.btn_gbr_anggota = New System.Windows.Forms.Button()
        Me.pct_anggota = New System.Windows.Forms.PictureBox()
        Me.txt_no_anggota = New System.Windows.Forms.TextBox()
        Me.txt_alamat_anggota = New System.Windows.Forms.TextBox()
        Me.cbx_jurusan_anggota = New System.Windows.Forms.ComboBox()
        Me.dtpc_tgl_anggota = New System.Windows.Forms.DateTimePicker()
        Me.rdio_prm_anggota = New System.Windows.Forms.RadioButton()
        Me.rdio_lk_anggota = New System.Windows.Forms.RadioButton()
        Me.txt_nama_anggota = New System.Windows.Forms.TextBox()
        Me.txt_nis_anggota = New System.Windows.Forms.TextBox()
        Me.txt_id_anggota = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_cari_anggota = New System.Windows.Forms.TextBox()
        Me.btn_cari_anggota = New System.Windows.Forms.Button()
        Me.dgv_anggota = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pct_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txt_alamatgbr_anggota)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_btl_anggota)
        Me.GroupBox1.Controls.Add(Me.btn_simpan_anggota)
        Me.GroupBox1.Controls.Add(Me.btn_gbr_anggota)
        Me.GroupBox1.Controls.Add(Me.pct_anggota)
        Me.GroupBox1.Controls.Add(Me.txt_no_anggota)
        Me.GroupBox1.Controls.Add(Me.txt_alamat_anggota)
        Me.GroupBox1.Controls.Add(Me.cbx_jurusan_anggota)
        Me.GroupBox1.Controls.Add(Me.dtpc_tgl_anggota)
        Me.GroupBox1.Controls.Add(Me.rdio_prm_anggota)
        Me.GroupBox1.Controls.Add(Me.rdio_lk_anggota)
        Me.GroupBox1.Controls.Add(Me.txt_nama_anggota)
        Me.GroupBox1.Controls.Add(Me.txt_nis_anggota)
        Me.GroupBox1.Controls.Add(Me.txt_id_anggota)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Perpetua", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 521)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Anggota"
        '
        'txt_alamatgbr_anggota
        '
        Me.txt_alamatgbr_anggota.BackColor = System.Drawing.Color.White
        Me.txt_alamatgbr_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamatgbr_anggota.Location = New System.Drawing.Point(216, 321)
        Me.txt_alamatgbr_anggota.Name = "txt_alamatgbr_anggota"
        Me.txt_alamatgbr_anggota.ReadOnly = True
        Me.txt_alamatgbr_anggota.Size = New System.Drawing.Size(233, 22)
        Me.txt_alamatgbr_anggota.TabIndex = 77
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(26, 321)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(167, 22)
        Me.TextBox2.TabIndex = 76
        Me.TextBox2.Text = "Alamat Gambar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(199, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = ":"
        '
        'btn_btl_anggota
        '
        Me.btn_btl_anggota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_btl_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_btl_anggota.Location = New System.Drawing.Point(332, 388)
        Me.btn_btl_anggota.Name = "btn_btl_anggota"
        Me.btn_btl_anggota.Size = New System.Drawing.Size(102, 35)
        Me.btn_btl_anggota.TabIndex = 55
        Me.btn_btl_anggota.Text = "Keluar"
        Me.btn_btl_anggota.UseVisualStyleBackColor = True
        '
        'btn_simpan_anggota
        '
        Me.btn_simpan_anggota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_anggota.Location = New System.Drawing.Point(224, 388)
        Me.btn_simpan_anggota.Name = "btn_simpan_anggota"
        Me.btn_simpan_anggota.Size = New System.Drawing.Size(102, 35)
        Me.btn_simpan_anggota.TabIndex = 54
        Me.btn_simpan_anggota.Text = "Simpan"
        Me.btn_simpan_anggota.UseVisualStyleBackColor = True
        '
        'btn_gbr_anggota
        '
        Me.btn_gbr_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gbr_anggota.Location = New System.Drawing.Point(478, 293)
        Me.btn_gbr_anggota.Name = "btn_gbr_anggota"
        Me.btn_gbr_anggota.Size = New System.Drawing.Size(155, 23)
        Me.btn_gbr_anggota.TabIndex = 53
        Me.btn_gbr_anggota.Text = "Cari Gambar"
        Me.btn_gbr_anggota.UseVisualStyleBackColor = True
        '
        'pct_anggota
        '
        Me.pct_anggota.BackColor = System.Drawing.Color.White
        Me.pct_anggota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_anggota.Location = New System.Drawing.Point(478, 97)
        Me.pct_anggota.Name = "pct_anggota"
        Me.pct_anggota.Size = New System.Drawing.Size(155, 190)
        Me.pct_anggota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_anggota.TabIndex = 52
        Me.pct_anggota.TabStop = False
        Me.pct_anggota.Tag = ""
        '
        'txt_no_anggota
        '
        Me.txt_no_anggota.BackColor = System.Drawing.Color.White
        Me.txt_no_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_anggota.Location = New System.Drawing.Point(216, 293)
        Me.txt_no_anggota.MaxLength = 13
        Me.txt_no_anggota.Name = "txt_no_anggota"
        Me.txt_no_anggota.Size = New System.Drawing.Size(233, 22)
        Me.txt_no_anggota.TabIndex = 50
        '
        'txt_alamat_anggota
        '
        Me.txt_alamat_anggota.BackColor = System.Drawing.Color.White
        Me.txt_alamat_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamat_anggota.Location = New System.Drawing.Point(216, 265)
        Me.txt_alamat_anggota.Name = "txt_alamat_anggota"
        Me.txt_alamat_anggota.Size = New System.Drawing.Size(233, 22)
        Me.txt_alamat_anggota.TabIndex = 49
        '
        'cbx_jurusan_anggota
        '
        Me.cbx_jurusan_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_jurusan_anggota.FormattingEnabled = True
        Me.cbx_jurusan_anggota.Location = New System.Drawing.Point(216, 235)
        Me.cbx_jurusan_anggota.Name = "cbx_jurusan_anggota"
        Me.cbx_jurusan_anggota.Size = New System.Drawing.Size(233, 24)
        Me.cbx_jurusan_anggota.TabIndex = 48
        Me.cbx_jurusan_anggota.Text = "- - - - Pilih - - - -"
        '
        'dtpc_tgl_anggota
        '
        Me.dtpc_tgl_anggota.CustomFormat = "yyyy-MM-dd"
        Me.dtpc_tgl_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpc_tgl_anggota.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpc_tgl_anggota.Location = New System.Drawing.Point(216, 209)
        Me.dtpc_tgl_anggota.Name = "dtpc_tgl_anggota"
        Me.dtpc_tgl_anggota.Size = New System.Drawing.Size(233, 22)
        Me.dtpc_tgl_anggota.TabIndex = 47
        Me.dtpc_tgl_anggota.Value = New Date(1997, 1, 1, 0, 0, 0, 0)
        '
        'rdio_prm_anggota
        '
        Me.rdio_prm_anggota.AutoSize = True
        Me.rdio_prm_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_prm_anggota.Location = New System.Drawing.Point(353, 182)
        Me.rdio_prm_anggota.Name = "rdio_prm_anggota"
        Me.rdio_prm_anggota.Size = New System.Drawing.Size(96, 20)
        Me.rdio_prm_anggota.TabIndex = 46
        Me.rdio_prm_anggota.TabStop = True
        Me.rdio_prm_anggota.Text = "Perempuan"
        Me.rdio_prm_anggota.UseVisualStyleBackColor = True
        '
        'rdio_lk_anggota
        '
        Me.rdio_lk_anggota.AutoSize = True
        Me.rdio_lk_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_lk_anggota.Location = New System.Drawing.Point(216, 182)
        Me.rdio_lk_anggota.Name = "rdio_lk_anggota"
        Me.rdio_lk_anggota.Size = New System.Drawing.Size(82, 20)
        Me.rdio_lk_anggota.TabIndex = 45
        Me.rdio_lk_anggota.TabStop = True
        Me.rdio_lk_anggota.Text = "Laki - laki"
        Me.rdio_lk_anggota.UseVisualStyleBackColor = True
        '
        'txt_nama_anggota
        '
        Me.txt_nama_anggota.BackColor = System.Drawing.Color.White
        Me.txt_nama_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_anggota.Location = New System.Drawing.Point(216, 153)
        Me.txt_nama_anggota.MaxLength = 20
        Me.txt_nama_anggota.Name = "txt_nama_anggota"
        Me.txt_nama_anggota.Size = New System.Drawing.Size(233, 22)
        Me.txt_nama_anggota.TabIndex = 44
        '
        'txt_nis_anggota
        '
        Me.txt_nis_anggota.BackColor = System.Drawing.Color.White
        Me.txt_nis_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nis_anggota.Location = New System.Drawing.Point(216, 125)
        Me.txt_nis_anggota.MaxLength = 11
        Me.txt_nis_anggota.Name = "txt_nis_anggota"
        Me.txt_nis_anggota.Size = New System.Drawing.Size(233, 22)
        Me.txt_nis_anggota.TabIndex = 43
        '
        'txt_id_anggota
        '
        Me.txt_id_anggota.BackColor = System.Drawing.Color.DarkGray
        Me.txt_id_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_anggota.Location = New System.Drawing.Point(216, 97)
        Me.txt_id_anggota.Name = "txt_id_anggota"
        Me.txt_id_anggota.ReadOnly = True
        Me.txt_id_anggota.Size = New System.Drawing.Size(233, 22)
        Me.txt_id_anggota.TabIndex = 42
        Me.txt_id_anggota.Text = "Tidak perlu di isi !!!"
        Me.txt_id_anggota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(26, 265)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(167, 22)
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.Text = "Alamat"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(26, 293)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(167, 22)
        Me.TextBox3.TabIndex = 39
        Me.TextBox3.Text = "No Hp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = ":"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(26, 181)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(167, 22)
        Me.TextBox11.TabIndex = 35
        Me.TextBox11.Text = "Jenis Kelamin"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(26, 153)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(167, 22)
        Me.TextBox12.TabIndex = 34
        Me.TextBox12.Text = "Nama Siswa"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(26, 237)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(167, 22)
        Me.TextBox9.TabIndex = 33
        Me.TextBox9.Text = "Jurusan"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(26, 209)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(167, 22)
        Me.TextBox10.TabIndex = 32
        Me.TextBox10.Text = "Tanggal Lahir"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(26, 125)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(167, 22)
        Me.TextBox8.TabIndex = 31
        Me.TextBox8.Text = "NIS/NISN"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(26, 97)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(167, 22)
        Me.TextBox7.TabIndex = 30
        Me.TextBox7.Text = "ID Kartu Anggota"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(199, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(199, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(199, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(199, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(199, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txt_cari_anggota)
        Me.GroupBox2.Controls.Add(Me.btn_cari_anggota)
        Me.GroupBox2.Controls.Add(Me.dgv_anggota)
        Me.GroupBox2.Font = New System.Drawing.Font("Perpetua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(666, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(702, 521)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Anggota"
        '
        'txt_cari_anggota
        '
        Me.txt_cari_anggota.BackColor = System.Drawing.Color.White
        Me.txt_cari_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari_anggota.ForeColor = System.Drawing.Color.Black
        Me.txt_cari_anggota.Location = New System.Drawing.Point(368, 102)
        Me.txt_cari_anggota.MaxLength = 10
        Me.txt_cari_anggota.Name = "txt_cari_anggota"
        Me.txt_cari_anggota.Size = New System.Drawing.Size(221, 20)
        Me.txt_cari_anggota.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.txt_cari_anggota, "NIS/NISN , nama , jurusan , alamat . . .")
        '
        'btn_cari_anggota
        '
        Me.btn_cari_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_anggota.Location = New System.Drawing.Point(595, 102)
        Me.btn_cari_anggota.Name = "btn_cari_anggota"
        Me.btn_cari_anggota.Size = New System.Drawing.Size(102, 22)
        Me.btn_cari_anggota.TabIndex = 60
        Me.btn_cari_anggota.Text = "Cari Data"
        Me.btn_cari_anggota.UseVisualStyleBackColor = True
        '
        'dgv_anggota
        '
        Me.dgv_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_anggota.Location = New System.Drawing.Point(5, 130)
        Me.dgv_anggota.Name = "dgv_anggota"
        Me.dgv_anggota.Size = New System.Drawing.Size(692, 295)
        Me.dgv_anggota.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Uc_Anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Uc_Anggota"
        Me.Size = New System.Drawing.Size(1370, 527)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pct_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_gbr_anggota As System.Windows.Forms.Button
    Friend WithEvents pct_anggota As System.Windows.Forms.PictureBox
    Friend WithEvents txt_no_anggota As System.Windows.Forms.TextBox
    Friend WithEvents txt_alamat_anggota As System.Windows.Forms.TextBox
    Friend WithEvents cbx_jurusan_anggota As System.Windows.Forms.ComboBox
    Friend WithEvents dtpc_tgl_anggota As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdio_prm_anggota As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_lk_anggota As System.Windows.Forms.RadioButton
    Friend WithEvents txt_nama_anggota As System.Windows.Forms.TextBox
    Friend WithEvents txt_nis_anggota As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_anggota As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_anggota As System.Windows.Forms.DataGridView
    Friend WithEvents btn_btl_anggota As System.Windows.Forms.Button
    Friend WithEvents btn_simpan_anggota As System.Windows.Forms.Button
    Friend WithEvents txt_cari_anggota As System.Windows.Forms.TextBox
    Friend WithEvents btn_cari_anggota As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_alamatgbr_anggota As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
