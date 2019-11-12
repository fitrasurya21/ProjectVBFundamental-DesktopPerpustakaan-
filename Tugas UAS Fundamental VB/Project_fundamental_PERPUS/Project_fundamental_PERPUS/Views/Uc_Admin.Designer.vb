<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uc_Admin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_btl_admin = New System.Windows.Forms.Button()
        Me.btn_simpan_admin = New System.Windows.Forms.Button()
        Me.cbx_admin_status = New System.Windows.Forms.ComboBox()
        Me.btn_admin_carigambar = New System.Windows.Forms.Button()
        Me.pct_gbr_admin = New System.Windows.Forms.PictureBox()
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
        Me.txt_admin_alamat = New System.Windows.Forms.TextBox()
        Me.txt_admin_pass = New System.Windows.Forms.TextBox()
        Me.txt_admin_user = New System.Windows.Forms.TextBox()
        Me.txt_admin_nama = New System.Windows.Forms.TextBox()
        Me.txt_admin_id = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_pustakawan = New System.Windows.Forms.DataGridView()
        Me.dgv_admin = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pct_gbr_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pustakawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btn_btl_admin)
        Me.GroupBox1.Controls.Add(Me.btn_simpan_admin)
        Me.GroupBox1.Controls.Add(Me.cbx_admin_status)
        Me.GroupBox1.Controls.Add(Me.btn_admin_carigambar)
        Me.GroupBox1.Controls.Add(Me.pct_gbr_admin)
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
        Me.GroupBox1.Controls.Add(Me.txt_admin_alamat)
        Me.GroupBox1.Controls.Add(Me.txt_admin_pass)
        Me.GroupBox1.Controls.Add(Me.txt_admin_user)
        Me.GroupBox1.Controls.Add(Me.txt_admin_nama)
        Me.GroupBox1.Controls.Add(Me.txt_admin_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Perpetua", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 521)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Petugas"
        '
        'btn_btl_admin
        '
        Me.btn_btl_admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_btl_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_btl_admin.Location = New System.Drawing.Point(332, 376)
        Me.btn_btl_admin.Name = "btn_btl_admin"
        Me.btn_btl_admin.Size = New System.Drawing.Size(102, 35)
        Me.btn_btl_admin.TabIndex = 31
        Me.btn_btl_admin.Text = "Keluar"
        Me.btn_btl_admin.UseVisualStyleBackColor = True
        '
        'btn_simpan_admin
        '
        Me.btn_simpan_admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_admin.Location = New System.Drawing.Point(224, 376)
        Me.btn_simpan_admin.Name = "btn_simpan_admin"
        Me.btn_simpan_admin.Size = New System.Drawing.Size(102, 35)
        Me.btn_simpan_admin.TabIndex = 27
        Me.btn_simpan_admin.Text = "Simpan"
        Me.btn_simpan_admin.UseVisualStyleBackColor = True
        '
        'cbx_admin_status
        '
        Me.cbx_admin_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_admin_status.FormattingEnabled = True
        Me.cbx_admin_status.Location = New System.Drawing.Point(210, 220)
        Me.cbx_admin_status.Name = "cbx_admin_status"
        Me.cbx_admin_status.Size = New System.Drawing.Size(236, 24)
        Me.cbx_admin_status.TabIndex = 26
        Me.cbx_admin_status.Text = "- - - - Pilih - - - -"
        '
        'btn_admin_carigambar
        '
        Me.btn_admin_carigambar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_admin_carigambar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin_carigambar.Location = New System.Drawing.Point(344, 278)
        Me.btn_admin_carigambar.Name = "btn_admin_carigambar"
        Me.btn_admin_carigambar.Size = New System.Drawing.Size(102, 23)
        Me.btn_admin_carigambar.TabIndex = 25
        Me.btn_admin_carigambar.Text = "Cari Gambar"
        Me.btn_admin_carigambar.UseVisualStyleBackColor = True
        '
        'pct_gbr_admin
        '
        Me.pct_gbr_admin.BackColor = System.Drawing.Color.White
        Me.pct_gbr_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_gbr_admin.Location = New System.Drawing.Point(470, 110)
        Me.pct_gbr_admin.Name = "pct_gbr_admin"
        Me.pct_gbr_admin.Size = New System.Drawing.Size(169, 191)
        Me.pct_gbr_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_gbr_admin.TabIndex = 24
        Me.pct_gbr_admin.TabStop = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(20, 194)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(167, 22)
        Me.TextBox11.TabIndex = 23
        Me.TextBox11.Text = "Password"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(20, 166)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(167, 22)
        Me.TextBox12.TabIndex = 22
        Me.TextBox12.Text = "Username"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(20, 250)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(167, 22)
        Me.TextBox9.TabIndex = 21
        Me.TextBox9.Text = "Alamat Gambar"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(20, 222)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(167, 22)
        Me.TextBox10.TabIndex = 20
        Me.TextBox10.Text = "Status"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(20, 138)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(167, 22)
        Me.TextBox8.TabIndex = 19
        Me.TextBox8.Text = "Nama Lengkap"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(20, 110)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(167, 22)
        Me.TextBox7.TabIndex = 18
        Me.TextBox7.Text = "No. Identitas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(193, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(193, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(193, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(193, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(193, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(193, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ":"
        '
        'txt_admin_alamat
        '
        Me.txt_admin_alamat.BackColor = System.Drawing.Color.White
        Me.txt_admin_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admin_alamat.Location = New System.Drawing.Point(210, 250)
        Me.txt_admin_alamat.Name = "txt_admin_alamat"
        Me.txt_admin_alamat.ReadOnly = True
        Me.txt_admin_alamat.Size = New System.Drawing.Size(236, 22)
        Me.txt_admin_alamat.TabIndex = 11
        '
        'txt_admin_pass
        '
        Me.txt_admin_pass.BackColor = System.Drawing.Color.White
        Me.txt_admin_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admin_pass.Location = New System.Drawing.Point(210, 194)
        Me.txt_admin_pass.MaxLength = 15
        Me.txt_admin_pass.Name = "txt_admin_pass"
        Me.txt_admin_pass.Size = New System.Drawing.Size(236, 22)
        Me.txt_admin_pass.TabIndex = 9
        '
        'txt_admin_user
        '
        Me.txt_admin_user.BackColor = System.Drawing.Color.White
        Me.txt_admin_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admin_user.Location = New System.Drawing.Point(210, 166)
        Me.txt_admin_user.MaxLength = 20
        Me.txt_admin_user.Name = "txt_admin_user"
        Me.txt_admin_user.Size = New System.Drawing.Size(236, 22)
        Me.txt_admin_user.TabIndex = 8
        '
        'txt_admin_nama
        '
        Me.txt_admin_nama.BackColor = System.Drawing.Color.White
        Me.txt_admin_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admin_nama.Location = New System.Drawing.Point(210, 138)
        Me.txt_admin_nama.MaxLength = 20
        Me.txt_admin_nama.Name = "txt_admin_nama"
        Me.txt_admin_nama.Size = New System.Drawing.Size(236, 22)
        Me.txt_admin_nama.TabIndex = 7
        '
        'txt_admin_id
        '
        Me.txt_admin_id.BackColor = System.Drawing.Color.DarkGray
        Me.txt_admin_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_admin_id.Location = New System.Drawing.Point(210, 110)
        Me.txt_admin_id.Name = "txt_admin_id"
        Me.txt_admin_id.ReadOnly = True
        Me.txt_admin_id.Size = New System.Drawing.Size(236, 22)
        Me.txt_admin_id.TabIndex = 6
        Me.txt_admin_id.Text = "Tidak perlu di isi !!!"
        Me.txt_admin_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgv_pustakawan)
        Me.GroupBox2.Controls.Add(Me.dgv_admin)
        Me.GroupBox2.Font = New System.Drawing.Font("Perpetua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(666, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(702, 520)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Pustakawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Admin"
        '
        'dgv_pustakawan
        '
        Me.dgv_pustakawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pustakawan.Location = New System.Drawing.Point(5, 305)
        Me.dgv_pustakawan.Name = "dgv_pustakawan"
        Me.dgv_pustakawan.Size = New System.Drawing.Size(692, 200)
        Me.dgv_pustakawan.TabIndex = 1
        '
        'dgv_admin
        '
        Me.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_admin.Location = New System.Drawing.Point(5, 48)
        Me.dgv_admin.Name = "dgv_admin"
        Me.dgv_admin.Size = New System.Drawing.Size(692, 200)
        Me.dgv_admin.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Uc_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Uc_Admin"
        Me.Size = New System.Drawing.Size(1370, 527)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pct_gbr_admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_pustakawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_admin As System.Windows.Forms.DataGridView
    Friend WithEvents pct_gbr_admin As System.Windows.Forms.PictureBox
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
    Friend WithEvents txt_admin_alamat As System.Windows.Forms.TextBox
    Friend WithEvents txt_admin_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_admin_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_admin_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_admin_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_pustakawan As System.Windows.Forms.DataGridView
    Friend WithEvents cbx_admin_status As System.Windows.Forms.ComboBox
    Friend WithEvents btn_admin_carigambar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_simpan_admin As System.Windows.Forms.Button
    Friend WithEvents btn_btl_admin As System.Windows.Forms.Button

End Class
