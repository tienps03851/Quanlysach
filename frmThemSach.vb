Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmThemSach
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=TIEN-PC;Initial Catalog=QL_SACH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("SELECT SACH.MASACH as 'Mã sách', SACH.TENSACH as 'Tên sách', SACH.THELOAI as 'Thể loại', SACH.NOIDUNG as 'Nội dung', SACH.TACGIA as 'Tác giả' FROM SACH", conn)
        db.Clear()
        refesh.Fill(db)
        dgvThemsach.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub reset()
        txtMasach.Text = ""
        cbxTL.Text = "None"
        txtTensach.Text = ""
        txtTenTacGia.Text = ""
        rtxNoidung.Text = ""
        txtMasach.Focus()
    End Sub

    Private Sub frmThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvThemsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThemsach.CellContentClick
        Dim click As Integer = dgvThemsach.CurrentCell.RowIndex
        txtMasach.Text = dgvThemsach.Item(0, click).Value
        txtTensach.Text = dgvThemsach.Item(1, click).Value
        cbxTL.Text = dgvThemsach.Item(2, click).Value
        rtxNoidung.Text = dgvThemsach.Item(3, click).Value
        txtTenTacGia.Text = dgvThemsach.Item(4, click).Value

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTensach.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên sách")
            txtTensach.Focus()
        ElseIf txtMasach.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sách")
            txtMasach.Focus()
        ElseIf cbxTL.Text = "None" Then
            MessageBox.Show("Vui lòng chọn thể loại")
            cbxTL.Focus()
        ElseIf rtxNoidung.Text = "" Then
            MessageBox.Show("Vui lòng nhập nội dung")
            rtxNoidung.Focus()
        ElseIf txtTenTacGia.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên tác giả")
            txtTenTacGia.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SACH (MASACH,THELOAI,TENSACH,NOIDUNG,TACGIA) values(@MASACH,@THELOAI,@TENSACH,@NOIDUNG,@TACGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASACH", txtMasach.Text)
            save.Parameters.AddWithValue("@THELOAI", cbxTL.Text)
            save.Parameters.AddWithValue("@TENSACH", txtTensach.Text)
            save.Parameters.AddWithValue("@NOIDUNG", rtxNoidung.Text)
            save.Parameters.AddWithValue("@TACGIA", txtTenTacGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Thêm thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        reset()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMasach.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sách bạn cần xóa")
            txtMasach.Focus()
        Else
            Dim delquery As String = "delete from SACH where MASACH=@MASACH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)

            conn.Open()
            delete.Parameters.AddWithValue("@MASACH", txtMasach.Text)
            delete.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Xóa thành công")
            LoadData()
        End If
        reset()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "SỬA" Then
            txtMasach.ReadOnly = True
            btnSua.Text = "Update"
            txtTensach.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SACH set THELOAI=@THELOAI, TENSACH=@TENSACH, NOIDUNG=@NOIDUNG, TACGIA=@TACGIA where MASACH=@MASACH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASACH", txtMasach.Text)
            save.Parameters.AddWithValue("@THELOAI", cbxTL.Text)
            save.Parameters.AddWithValue("@TENSACH", txtTensach.Text)
            save.Parameters.AddWithValue("@NOIDUNG", rtxNoidung.Text)
            save.Parameters.AddWithValue("@TACGIA", txtTenTacGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMasach.ReadOnly = False
            btnSua.Text = "SỬA"
            LoadData()
        End If
    End Sub

End Class