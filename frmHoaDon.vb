Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmHoaDon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=TIEN-PC;Initial Catalog=QL_SACH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim hoadon As SqlDataAdapter = New SqlDataAdapter("SELECT HOADONMUON.MAHD as 'Mã hóa đơn', CHITIETHD.MASACH as 'Mã sách', KHACHHANG.MAKH as 'Mã khách hàng', KHACHHANG.TENKH as 'Họ tên', CHITIETHD.NGAYMUON as 'Ngày mượn', CHITIETHD.NGAYTRA as 'Ngày trả'
FROM KHACHHANG INNER JOIN HOADONMUON ON KHACHHANG.MAKH = HOADONMUON.MAKH 
AND KHACHHANG.MAKH = HOADONMUON.MAKH INNER JOIN CHITIETHD ON HOADONMUON.MAHD = CHITIETHD.MAHD", conn)
        db.Clear()
        hoadon.Fill(db)
        dgvHoaDon.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub btnXacNhanDK_Click(sender As Object, e As EventArgs) Handles btnXacNhanDK.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "Insert Into KHACHHANG values (@MAKH,@TENKH,@NGAYSINH,@DIACHI,@SDT) Insert Into HOADONMUON values (@MAHD,@MAKH,@NGAYLAP) Insert Into CHITIETHD values (@MAHD,@MASACH,@NGAYMUON,@NGAYTRA) "
        Dim query2 As String = "Insert Into HOADONMUON values (@MAHD,@MAKH,@NGAYLAP) Insert Into CHITIETHD values (@MAHD,@MASACH,@NGAYMUON,@NGAYTRA) "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Dim save2 As SqlCommand = New SqlCommand(query2, conn)
        conn.Open()
        'áp dụng cho khách hàng đã có mã khách hàng
        If cbMaKH.Checked = True Then
            Try
                If txtMaKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMaKH.Focus()
                    If txtMaHD.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save2.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                        save2.Parameters.AddWithValue("@MAHD", txtMaHD.Text)
                        save2.Parameters.AddWithValue("@NGAYLAP", dtbNgayDK.Text)
                        save2.Parameters.AddWithValue("@MASACH", txtMaSach.Text)
                        save2.Parameters.AddWithValue("@NGAYMUON", dtbNgayDK.Text)
                        save2.Parameters.AddWithValue("@NGAYTRA", dtbNgayTra.Text)
                        save2.ExecuteNonQuery()
                        conn.Close() 'đóng kết nối
                        MessageBox.Show("Đăng kí thành công")
                        txtMaHD.Text = "HD"
                        txtMaKH.Text = "KH"
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Mã khách hàng không đúng hoặc không tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtMaHD.Text = "HD"
                txtMaKH.Text = "KH"
            End Try
            Me.Close()
        Else         'áp dụng cho khách hàng lần đầu đăng kí
            Try
                txtHoTen.Focus()
                If txtHoTen.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtHoTen.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDiaChi.Focus()
                        If txtSoDienThoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập SĐT", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSoDienThoai.Focus()
                            If txtMaKH.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtMaKH.Focus()
                                If txtMaHD.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                    save.Parameters.AddWithValue("@TENKH", txtHoTen.Text)
                                    save.Parameters.AddWithValue("@NGAYSINH", dtbNgaySinh.Text)
                                    save.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
                                    save.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text)
                                    save.Parameters.AddWithValue("@MAHD", txtMaHD.Text)
                                    save.Parameters.AddWithValue("@NGAYLAP", dtbNgayDK.Text)
                                    save.Parameters.AddWithValue("@MASACH", txtMaSach.Text)
                                    save.Parameters.AddWithValue("@NGAYMUON", dtbNgayDK.Text)
                                    save.Parameters.AddWithValue("@NGAYTRA", dtbNgayTra.Text)
                                    save.ExecuteNonQuery()
                                    conn.Close() 'đóng kết nối
                                    MessageBox.Show("Đăng kí thành công")
                                    txtMaHD.Text = "HD"
                                    txtMaKH.Text = "KH"
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtMaHD.Text = "HD"
                txtMaKH.Text = "KH"
            End Try
            Me.Close()
        End If
        LoadData()
    End Sub

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvHoaDon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick
        Dim click As Integer = dgvHoaDon.CurrentCell.RowIndex
        txtMaHD.Text = dgvHoaDon.Item(0, click).Value
        txtMaSach.Text = dgvHoaDon.Item(1, click).Value
        txtMaKH.Text = dgvHoaDon.Item(2, click).Value
        txtHoTen.Text = dgvHoaDon.Item(3, click).Value
        dtbNgayDK.Text = dgvHoaDon.Item(4, click).Value
        dtbNgayTra.Text = dgvHoaDon.Item(5, click).Value
    End Sub

    Private Sub btnNhapLaiDK_Click(sender As Object, e As EventArgs) Handles btnNhapLaiDK.Click
        txtMaHD.Clear()
        txtMaSach.Clear()
        txtMaKH.Clear()
        txtHoTen.Clear()
        txtDiaChi.Clear()
        txtSoDienThoai.Clear()

    End Sub
End Class