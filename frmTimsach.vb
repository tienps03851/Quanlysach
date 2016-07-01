Imports System.Data.SqlClient
Imports System.Data.DataSet

Public Class frmTimsach
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=TIEN-PC;Initial Catalog=QL_SACH;Integrated Security=True"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnTimTatca_Click(sender As Object, e As EventArgs) Handles btnTimTatca.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("SELECT SACH.MASACH as 'Mã sách', SACH.TENSACH as 'Tên sách', SACH.THELOAI as 'Thể loại', SACH.NOIDUNG as 'Nội dung', SACH.TACGIA as 'Tác giả' FROM SACH", connect)
        Try
            db.Clear()
            DgvTimSach.DataSource = Nothing
            timkiem.Fill(db)
            If db.Rows.Count > 0 Then
                DgvTimSach.DataSource = db.DefaultView
                txtMasach.Text = Nothing
            Else
                MessageBox.Show("Không tìm thấy")
                txtMasach.Text = Nothing
            End If

            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTimMasach_Click(sender As Object, e As EventArgs) Handles btnTimMasach.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("SELECT SACH.MASACH as 'Mã sách', SACH.TENSACH as 'Tên sách', SACH.THELOAI as 'Thể loại', SACH.NOIDUNG as 'Nội dung', SACH.TACGIA as 'Tác giả' FROM SACH where SACH.MASACH ='" & txtMasach.Text & "' ", connect)
        Try
            If txtMasach.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sách", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                DgvTimSach.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    DgvTimSach.DataSource = db.DefaultView
                    txtMasach.Text = Nothing
                Else
                    MessageBox.Show("Mã sách không tồn tại")
                    txtMasach.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTimTensach_Click(sender As Object, e As EventArgs) Handles btnTimTensach.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("SELECT SACH.MASACH as 'Mã sách', SACH.TENSACH as 'Tên sách', SACH.THELOAI as 'Thể loại', SACH.NOIDUNG as 'Nội dung', SACH.TACGIA as 'Tác giả' FROM SACH where SACH.TENSACH like N'%" & txtTensach.Text & "%' ", connect)
        Try
            If txtTensach.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sách", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                DgvTimSach.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    DgvTimSach.DataSource = db.DefaultView
                    txtTensach.Text = Nothing
                Else
                    MessageBox.Show("Tên sách không tồn tại")
                    txtTensach.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Dong_Click(sender As Object, e As EventArgs) Handles Dong.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbxTL.Text = "None" Then
            MessageBox.Show("Bạn cần chọn thể loại sách", "Chưa chọn thể loại", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cbxTL.Text = "Khoa học" Then
            connect.Open()
            Dim danhsach As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả' from SACH WHERE (THELOAI = N'Khoa học')", connect)
            DgvTimSach.DataSource = db.DefaultView
            db.Clear()
            danhsach.Fill(db)
            connect.Close()
        ElseIf cbxTL.Text = "Giáo trình" Then
            connect.Open()
            Dim danhsach As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả' from SACH WHERE (THELOAI = N'Giáo trình')", connect)
            DgvTimSach.DataSource = db.DefaultView
            db.Clear()
            danhsach.Fill(db)
            connect.Close()
        ElseIf cbxTL.Text = "Kinh tế" Then
            connect.Open()
            Dim danhsach As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả' from SACH WHERE (THELOAI = N'Kinh tế')", connect)
            DgvTimSach.DataSource = db.DefaultView
            db.Clear()
            danhsach.Fill(db)
            connect.Close()
        ElseIf cbxTL.Text = "Nấu ăn" Then
            connect.Open()
            Dim danhsach As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả' from SACH WHERE (THELOAI = N'Nấu ăn')", connect)
            DgvTimSach.DataSource = db.DefaultView
            db.Clear()
            danhsach.Fill(db)
            connect.Close()
        ElseIf cbxTL.Text = "Trinh thám" Then
            connect.Open()
            Dim danhsach As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả' from SACH WHERE (THELOAI = N'Trinh thám')", connect)
            DgvTimSach.DataSource = db.DefaultView
            db.Clear()
            danhsach.Fill(db)
            connect.Close()
        End If
    End Sub
End Class