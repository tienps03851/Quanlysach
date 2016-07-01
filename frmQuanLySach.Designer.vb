<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySach
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDangky = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(115, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(515, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CHÀO MỪNG BẠN TỚI THƯ VIỆN ĐIỆN TỬ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(29, 435)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Bạn muốn đăng ký mượn sách từ thư viện?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(29, 360)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bạn muốn thêm sách vào thư viện?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(29, 280)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = " Bạn muốn tìm sách gì?"
        '
        'BtnDangky
        '
        Me.BtnDangky.Image = Global.QLY_SACH.My.Resources.Resources.Register_Icon
        Me.BtnDangky.Location = New System.Drawing.Point(515, 417)
        Me.BtnDangky.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BtnDangky.Name = "BtnDangky"
        Me.BtnDangky.Size = New System.Drawing.Size(153, 60)
        Me.BtnDangky.TabIndex = 18
        Me.BtnDangky.Text = "Đăng ký mượn"
        Me.BtnDangky.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDangky.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.QLY_SACH.My.Resources.Resources.DieFLY_Plus_icon
        Me.btnThem.Location = New System.Drawing.Point(515, 342)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(153, 60)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm sách"
        Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Image = Global.QLY_SACH.My.Resources.Resources.seo_icon
        Me.btnTim.Location = New System.Drawing.Point(515, 262)
        Me.btnTim.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(153, 60)
        Me.btnTim.TabIndex = 12
        Me.btnTim.Text = "Tìm kiếm"
        Me.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLY_SACH.My.Resources.Resources.contemporary_home_library_design_with_white_painted_wooden_wall_open_storage_bookshelves_and_double_white_gloss_acrylic_lounge_chairs_on_glazed_white_lami1
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(749, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmQuanLySach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 490)
        Me.Controls.Add(Me.BtnDangky)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "frmQuanLySach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý sách"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTim As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents BtnDangky As Button
End Class
