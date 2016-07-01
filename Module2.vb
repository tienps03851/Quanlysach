Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function LoadSach() As DataSet
        Dim chuoiketnoi As String = "Data Source=TIEN-PC;Initial Catalog=QL_SACH;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadS As New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI as 'Thể loại', TENSACH as 'Tên sách', NOIDUNG as 'Nội dung', TACGIA as 'Tác giả' from SACH", conn)
        Dim db As New DataSet
        conn.Open()
        LoadS.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
