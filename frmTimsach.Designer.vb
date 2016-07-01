<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimsach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMasach = New System.Windows.Forms.TextBox()
        Me.txtTensach = New System.Windows.Forms.TextBox()
        Me.DgvTimSach = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dong = New System.Windows.Forms.Button()
        Me.btnTimTatca = New System.Windows.Forms.Button()
        Me.btnTimTensach = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxTL = New System.Windows.Forms.ComboBox()
        Me.btnTimMasach = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvTimSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(194, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên sách"
        '
        'txtMasach
        '
        Me.txtMasach.Location = New System.Drawing.Point(81, 18)
        Me.txtMasach.Name = "txtMasach"
        Me.txtMasach.Size = New System.Drawing.Size(107, 20)
        Me.txtMasach.TabIndex = 2
        '
        'txtTensach
        '
        Me.txtTensach.Location = New System.Drawing.Point(275, 18)
        Me.txtTensach.Name = "txtTensach"
        Me.txtTensach.Size = New System.Drawing.Size(274, 20)
        Me.txtTensach.TabIndex = 3
        '
        'DgvTimSach
        '
        Me.DgvTimSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTimSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTimSach.Location = New System.Drawing.Point(10, 264)
        Me.DgvTimSach.Name = "DgvTimSach"
        Me.DgvTimSach.Size = New System.Drawing.Size(726, 220)
        Me.DgvTimSach.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(285, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "THÔNG TIN SÁCH"
        '
        'Dong
        '
        Me.Dong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong.Image = Global.QLY_SACH.My.Resources.Resources.icon_close2
        Me.Dong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Dong.Location = New System.Drawing.Point(583, 44)
        Me.Dong.Name = "Dong"
        Me.Dong.Size = New System.Drawing.Size(145, 53)
        Me.Dong.TabIndex = 8
        Me.Dong.Text = "Đóng"
        Me.Dong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Dong.UseVisualStyleBackColor = True
        '
        'btnTimTatca
        '
        Me.btnTimTatca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimTatca.Image = Global.QLY_SACH.My.Resources.Resources.plus
        Me.btnTimTatca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTimTatca.Location = New System.Drawing.Point(583, 152)
        Me.btnTimTatca.Name = "btnTimTatca"
        Me.btnTimTatca.Size = New System.Drawing.Size(145, 54)
        Me.btnTimTatca.TabIndex = 7
        Me.btnTimTatca.Text = "Xem tất cả"
        Me.btnTimTatca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTimTatca.UseVisualStyleBackColor = True
        '
        'btnTimTensach
        '
        Me.btnTimTensach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimTensach.Image = Global.QLY_SACH.My.Resources.Resources.icon_search
        Me.btnTimTensach.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTimTensach.Location = New System.Drawing.Point(348, 48)
        Me.btnTimTensach.Name = "btnTimTensach"
        Me.btnTimTensach.Size = New System.Drawing.Size(138, 49)
        Me.btnTimTensach.TabIndex = 6
        Me.btnTimTensach.Text = "Tìm kiếm tên sách"
        Me.btnTimTensach.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTimTensach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTimTensach.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(93, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Thể loại"
        '
        'cbxTL
        '
        Me.cbxTL.FormattingEnabled = True
        Me.cbxTL.Items.AddRange(New Object() {"Giáo trình", "Khoa học", "Kinh tế", "Nấu ăn", "Trinh thám"})
        Me.cbxTL.Location = New System.Drawing.Point(197, 130)
        Me.cbxTL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbxTL.Name = "cbxTL"
        Me.cbxTL.Size = New System.Drawing.Size(209, 21)
        Me.cbxTL.TabIndex = 51
        Me.cbxTL.Text = "None"
        '
        'btnTimMasach
        '
        Me.btnTimMasach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimMasach.Image = Global.QLY_SACH.My.Resources.Resources.icon_search
        Me.btnTimMasach.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTimMasach.Location = New System.Drawing.Point(41, 46)
        Me.btnTimMasach.Name = "btnTimMasach"
        Me.btnTimMasach.Size = New System.Drawing.Size(147, 51)
        Me.btnTimMasach.TabIndex = 5
        Me.btnTimMasach.Text = "Tìm kiếm mã sách"
        Me.btnTimMasach.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTimMasach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTimMasach.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.QLY_SACH.My.Resources.Resources.icon_search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(148, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 49)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Tìm kiếm theo thể loại"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTimsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 496)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxTL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dong)
        Me.Controls.Add(Me.btnTimTatca)
        Me.Controls.Add(Me.btnTimTensach)
        Me.Controls.Add(Me.btnTimMasach)
        Me.Controls.Add(Me.DgvTimSach)
        Me.Controls.Add(Me.txtTensach)
        Me.Controls.Add(Me.txtMasach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTimsach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tra cứu thông tin sách"
        CType(Me.DgvTimSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMasach As TextBox
    Friend WithEvents txtTensach As TextBox
    Friend WithEvents DgvTimSach As DataGridView
    Friend WithEvents btnTimTensach As Button
    Friend WithEvents btnTimTatca As Button
    Friend WithEvents Dong As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxTL As ComboBox
    Friend WithEvents btnTimMasach As Button
    Friend WithEvents Button1 As Button
End Class
