<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSoHD = New System.Windows.Forms.Label()
        Me.cbMaKH = New System.Windows.Forms.CheckBox()
        Me.dtbNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.dtbNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.dtbNgayDK = New System.Windows.Forms.DateTimePicker()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lblNgayTra = New System.Windows.Forms.Label()
        Me.lblNgayDK = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.lblMaSachDK = New System.Windows.Forms.Label()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblTenNguoiMuon = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.btnNhapLaiDK = New System.Windows.Forms.Button()
        Me.btnXacNhanDK = New System.Windows.Forms.Button()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSoHD
        '
        Me.lblSoHD.AutoSize = True
        Me.lblSoHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoHD.Location = New System.Drawing.Point(396, 26)
        Me.lblSoHD.Name = "lblSoHD"
        Me.lblSoHD.Size = New System.Drawing.Size(87, 15)
        Me.lblSoHD.TabIndex = 48
        Me.lblSoHD.Text = "Mã hóa đơn:"
        '
        'cbMaKH
        '
        Me.cbMaKH.AutoSize = True
        Me.cbMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaKH.Location = New System.Drawing.Point(127, 49)
        Me.cbMaKH.Name = "cbMaKH"
        Me.cbMaKH.Size = New System.Drawing.Size(165, 19)
        Me.cbMaKH.TabIndex = 47
        Me.cbMaKH.Text = "Đã có mã khách hàng"
        Me.cbMaKH.UseVisualStyleBackColor = True
        '
        'dtbNgayTra
        '
        Me.dtbNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbNgayTra.Location = New System.Drawing.Point(500, 153)
        Me.dtbNgayTra.Name = "dtbNgayTra"
        Me.dtbNgayTra.Size = New System.Drawing.Size(239, 20)
        Me.dtbNgayTra.TabIndex = 40
        Me.dtbNgayTra.Value = New Date(2016, 2, 27, 5, 0, 0, 0)
        '
        'dtbNgaySinh
        '
        Me.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbNgaySinh.Location = New System.Drawing.Point(127, 192)
        Me.dtbNgaySinh.Name = "dtbNgaySinh"
        Me.dtbNgaySinh.Size = New System.Drawing.Size(239, 20)
        Me.dtbNgaySinh.TabIndex = 35
        Me.dtbNgaySinh.Value = New Date(2016, 2, 26, 23, 12, 43, 0)
        '
        'dtbNgayDK
        '
        Me.dtbNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbNgayDK.Location = New System.Drawing.Point(500, 117)
        Me.dtbNgayDK.Name = "dtbNgayDK"
        Me.dtbNgayDK.Size = New System.Drawing.Size(239, 20)
        Me.dtbNgayDK.TabIndex = 38
        Me.dtbNgayDK.Value = New Date(2016, 2, 27, 4, 24, 33, 0)
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgaySinh.Location = New System.Drawing.Point(12, 196)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(74, 15)
        Me.lbNgaySinh.TabIndex = 43
        Me.lbNgaySinh.Text = "Ngày sinh:"
        '
        'lblNgayTra
        '
        Me.lblNgayTra.AutoSize = True
        Me.lblNgayTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgayTra.Location = New System.Drawing.Point(396, 157)
        Me.lblNgayTra.Name = "lblNgayTra"
        Me.lblNgayTra.Size = New System.Drawing.Size(64, 15)
        Me.lblNgayTra.TabIndex = 41
        Me.lblNgayTra.Text = "Ngày trả:"
        '
        'lblNgayDK
        '
        Me.lblNgayDK.AutoSize = True
        Me.lblNgayDK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgayDK.Location = New System.Drawing.Point(396, 122)
        Me.lblNgayDK.Name = "lblNgayDK"
        Me.lblNgayDK.Size = New System.Drawing.Size(94, 15)
        Me.lblNgayDK.TabIndex = 45
        Me.lblNgayDK.Text = "Ngày đăng kí:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(127, 156)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(239, 20)
        Me.txtDiaChi.TabIndex = 34
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(127, 119)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(239, 20)
        Me.txtSoDienThoai.TabIndex = 33
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(127, 82)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(239, 20)
        Me.txtHoTen.TabIndex = 30
        '
        'lblMaSachDK
        '
        Me.lblMaSachDK.AutoSize = True
        Me.lblMaSachDK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSachDK.Location = New System.Drawing.Point(396, 82)
        Me.lblMaSachDK.Name = "lblMaSachDK"
        Me.lblMaSachDK.Size = New System.Drawing.Size(65, 15)
        Me.lblMaSachDK.TabIndex = 26
        Me.lblMaSachDK.Text = "Mã sách:"
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiachi.Location = New System.Drawing.Point(12, 157)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(56, 15)
        Me.lblDiachi.TabIndex = 29
        Me.lblDiachi.Text = "Địa chỉ:"
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoDienThoai.Location = New System.Drawing.Point(12, 120)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(96, 15)
        Me.lblSoDienThoai.TabIndex = 28
        Me.lblSoDienThoai.Text = "Số điện thoại:"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKH.Location = New System.Drawing.Point(12, 26)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(109, 15)
        Me.lblMaKH.TabIndex = 31
        Me.lblMaKH.Text = "Mã khách hàng:"
        '
        'lblTenNguoiMuon
        '
        Me.lblTenNguoiMuon.AutoSize = True
        Me.lblTenNguoiMuon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNguoiMuon.Location = New System.Drawing.Point(12, 82)
        Me.lblTenNguoiMuon.Name = "lblTenNguoiMuon"
        Me.lblTenNguoiMuon.Size = New System.Drawing.Size(71, 15)
        Me.lblTenNguoiMuon.TabIndex = 32
        Me.lblTenNguoiMuon.Text = "Họ và tên:"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(500, 23)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(239, 20)
        Me.txtMaHD.TabIndex = 49
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(127, 23)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(239, 20)
        Me.txtMaKH.TabIndex = 50
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(500, 81)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(239, 20)
        Me.txtMaSach.TabIndex = 51
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(12, 243)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.Size = New System.Drawing.Size(727, 217)
        Me.dgvHoaDon.TabIndex = 52
        '
        'btnNhapLaiDK
        '
        Me.btnNhapLaiDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhapLaiDK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhapLaiDK.Image = Global.QLY_SACH.My.Resources.Resources.refresh_icon1
        Me.btnNhapLaiDK.Location = New System.Drawing.Point(609, 190)
        Me.btnNhapLaiDK.Name = "btnNhapLaiDK"
        Me.btnNhapLaiDK.Size = New System.Drawing.Size(103, 40)
        Me.btnNhapLaiDK.TabIndex = 44
        Me.btnNhapLaiDK.Text = "Hủy"
        Me.btnNhapLaiDK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNhapLaiDK.UseVisualStyleBackColor = True
        '
        'btnXacNhanDK
        '
        Me.btnXacNhanDK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXacNhanDK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhanDK.Image = Global.QLY_SACH.My.Resources.Resources.plus1
        Me.btnXacNhanDK.Location = New System.Drawing.Point(466, 190)
        Me.btnXacNhanDK.Name = "btnXacNhanDK"
        Me.btnXacNhanDK.Size = New System.Drawing.Size(103, 40)
        Me.btnXacNhanDK.TabIndex = 46
        Me.btnXacNhanDK.Text = "Xác nhận"
        Me.btnXacNhanDK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnXacNhanDK.UseVisualStyleBackColor = True
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 472)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.lblSoHD)
        Me.Controls.Add(Me.cbMaKH)
        Me.Controls.Add(Me.dtbNgayTra)
        Me.Controls.Add(Me.dtbNgaySinh)
        Me.Controls.Add(Me.dtbNgayDK)
        Me.Controls.Add(Me.btnNhapLaiDK)
        Me.Controls.Add(Me.btnXacNhanDK)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lblNgayTra)
        Me.Controls.Add(Me.lblNgayDK)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.lblMaSachDK)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.lblTenNguoiMuon)
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phiếu mượn sách"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSoHD As Label
    Friend WithEvents cbMaKH As CheckBox
    Friend WithEvents dtbNgayTra As DateTimePicker
    Friend WithEvents dtbNgaySinh As DateTimePicker
    Friend WithEvents dtbNgayDK As DateTimePicker
    Friend WithEvents btnNhapLaiDK As Button
    Friend WithEvents btnXacNhanDK As Button
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lblNgayTra As Label
    Friend WithEvents lblNgayDK As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents lblMaSachDK As Label
    Friend WithEvents lblDiachi As Label
    Friend WithEvents lblSoDienThoai As Label
    Friend WithEvents lblMaKH As Label
    Friend WithEvents lblTenNguoiMuon As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents dgvHoaDon As DataGridView
End Class
