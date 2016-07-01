Imports System.IO

Public Class frmDangNhap
    Dim login As New List(Of Login)

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        openlogin()


        For Each u As Login In login
            If u.user = txtUser.Text Then
                If u.pass = txtPass.Text Then
                    MessageBox.Show("Chúc mừng đăng nhập thành công", "Thông báo")
                    frmQuanLySach.ShowDialog()
                    Me.Close()
                Else
                    MessageBox.Show("Xin lỗi. Bạn đã nhập sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End If
        Next

        MessageBox.Show("Xin lỗi. Bạn đã nhập sai tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        savelogin()
    End Sub

    Sub openlogin()
        login.Clear()

        Dim input As New StreamReader("data/login.txt")
        While Not input.EndOfStream
            Dim line() As String = input.ReadLine.Split(vbTab)

            Dim lg As New Login
            lg.user = line(0)
            lg.pass = line(1)

            login.Add(lg)
        End While
        input.Close()
    End Sub

    Sub savelogin()
        Dim output As New StreamWriter("data/login.txt")
        For Each us As Login In login
            output.Write(us.user)
            output.Write(vbTab)

            output.WriteLine(us.pass)
        Next
        output.Close()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
        txtPass.Focus()
    End Sub
End Class