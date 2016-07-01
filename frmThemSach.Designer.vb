<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemSach
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
        Me.cbxTL = New System.Windows.Forms.ComboBox()
        Me.lblTheLoai = New System.Windows.Forms.Label()
        Me.txtMasach = New System.Windows.Forms.TextBox()
        Me.txtTenTacGia = New System.Windows.Forms.TextBox()
        Me.txtTensach = New System.Windows.Forms.TextBox()
        Me.lblMaTDS = New System.Windows.Forms.Label()
        Me.lblTenTacGia = New System.Windows.Forms.Label()
        Me.lblTenTDS = New System.Windows.Forms.Label()
        Me.dgvThemsach = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtxNoidung = New System.Windows.Forms.RichTextBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvThemsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxTL
        '
        Me.cbxTL.FormattingEnabled = True
        Me.cbxTL.Items.AddRange(New Object() {"Giáo trình", "Khoa học", "Kinh tế", "Nấu ăn", "Trinh thám"})
        Me.cbxTL.Location = New System.Drawing.Point(87, 49)
        Me.cbxTL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbxTL.Name = "cbxTL"
        Me.cbxTL.Size = New System.Drawing.Size(209, 23)
        Me.cbxTL.TabIndex = 50
        Me.cbxTL.Text = "None"
        '
        'lblTheLoai
        '
        Me.lblTheLoai.AutoSize = True
        Me.lblTheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheLoai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTheLoai.Location = New System.Drawing.Point(10, 52)
        Me.lblTheLoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTheLoai.Name = "lblTheLoai"
        Me.lblTheLoai.Size = New System.Drawing.Size(59, 15)
        Me.lblTheLoai.TabIndex = 56
        Me.lblTheLoai.Text = "Thể loại"
        '
        'txtMasach
        '
        Me.txtMasach.Location = New System.Drawing.Point(533, 6)
        Me.txtMasach.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMasach.MaxLength = 15
        Me.txtMasach.Name = "txtMasach"
        Me.txtMasach.Size = New System.Drawing.Size(153, 21)
        Me.txtMasach.TabIndex = 44
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(463, 49)
        Me.txtTenTacGia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(223, 21)
        Me.txtTenTacGia.TabIndex = 45
        '
        'txtTensach
        '
        Me.txtTensach.Location = New System.Drawing.Point(87, 6)
        Me.txtTensach.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTensach.Name = "txtTensach"
        Me.txtTensach.Size = New System.Drawing.Size(367, 21)
        Me.txtTensach.TabIndex = 43
        '
        'lblMaTDS
        '
        Me.lblMaTDS.AutoSize = True
        Me.lblMaTDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaTDS.Location = New System.Drawing.Point(462, 9)
        Me.lblMaTDS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaTDS.Name = "lblMaTDS"
        Me.lblMaTDS.Size = New System.Drawing.Size(63, 15)
        Me.lblMaTDS.TabIndex = 42
        Me.lblMaTDS.Text = "Mã Sách"
        '
        'lblTenTacGia
        '
        Me.lblTenTacGia.AutoSize = True
        Me.lblTenTacGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenTacGia.Location = New System.Drawing.Point(400, 52)
        Me.lblTenTacGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTenTacGia.Name = "lblTenTacGia"
        Me.lblTenTacGia.Size = New System.Drawing.Size(54, 15)
        Me.lblTenTacGia.TabIndex = 39
        Me.lblTenTacGia.Text = "Tác giả"
        '
        'lblTenTDS
        '
        Me.lblTenTDS.AutoSize = True
        Me.lblTenTDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenTDS.Location = New System.Drawing.Point(10, 9)
        Me.lblTenTDS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTenTDS.Name = "lblTenTDS"
        Me.lblTenTDS.Size = New System.Drawing.Size(65, 15)
        Me.lblTenTDS.TabIndex = 38
        Me.lblTenTDS.Text = "Tên sách"
        '
        'dgvThemsach
        '
        Me.dgvThemsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThemsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThemsach.Location = New System.Drawing.Point(13, 227)
        Me.dgvThemsach.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvThemsach.Name = "dgvThemsach"
        Me.dgvThemsach.Size = New System.Drawing.Size(824, 242)
        Me.dgvThemsach.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Nội dung:"
        '
        'rtxNoidung
        '
        Me.rtxNoidung.Location = New System.Drawing.Point(87, 101)
        Me.rtxNoidung.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rtxNoidung.Name = "rtxNoidung"
        Me.rtxNoidung.Size = New System.Drawing.Size(601, 74)
        Me.rtxNoidung.TabIndex = 62
        Me.rtxNoidung.Text = ""
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.Image = Global.QLY_SACH.My.Resources.Resources.refresh_icon
        Me.btnHuy.Location = New System.Drawing.Point(725, 149)
        Me.btnHuy.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(100, 42)
        Me.btnHuy.TabIndex = 63
        Me.btnHuy.Text = "HỦY"
        Me.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Image = Global.QLY_SACH.My.Resources.Resources.edit_icon
        Me.btnSua.Location = New System.Drawing.Point(725, 101)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 42)
        Me.btnSua.TabIndex = 60
        Me.btnSua.Text = "SỬA"
        Me.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = Global.QLY_SACH.My.Resources.Resources.icon_x2
        Me.btnXoa.Location = New System.Drawing.Point(725, 54)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 41)
        Me.btnXoa.TabIndex = 59
        Me.btnXoa.Text = "XÓA"
        Me.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = Global.QLY_SACH.My.Resources.Resources.plus_icon
        Me.btnThem.Location = New System.Drawing.Point(725, 6)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 42)
        Me.btnThem.TabIndex = 58
        Me.btnThem.Text = "THÊM"
        Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(331, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 26)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "DANH MỤC SÁCH"
        '
        'frmThemSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 523)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.rtxNoidung)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvThemsach)
        Me.Controls.Add(Me.cbxTL)
        Me.Controls.Add(Me.lblTheLoai)
        Me.Controls.Add(Me.txtMasach)
        Me.Controls.Add(Me.txtTenTacGia)
        Me.Controls.Add(Me.txtTensach)
        Me.Controls.Add(Me.lblMaTDS)
        Me.Controls.Add(Me.lblTenTacGia)
        Me.Controls.Add(Me.lblTenTDS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmThemSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm sách"
        CType(Me.dgvThemsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxTL As ComboBox
    Friend WithEvents lblTheLoai As Label
    Friend WithEvents txtMasach As TextBox
    Friend WithEvents txtTenTacGia As TextBox
    Friend WithEvents txtTensach As TextBox
    Friend WithEvents lblMaTDS As Label
    Friend WithEvents lblTenTacGia As Label
    Friend WithEvents lblTenTDS As Label
    Friend WithEvents dgvThemsach As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rtxNoidung As RichTextBox
    Friend WithEvents btnHuy As Button
    Friend WithEvents Label2 As Label
End Class
