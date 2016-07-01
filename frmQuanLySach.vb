Public Class frmQuanLySach
    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        frmTimsach.ShowDialog()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        frmThemSach.ShowDialog()
    End Sub

    Private Sub BtnDangky_Click(sender As Object, e As EventArgs) Handles BtnDangky.Click
        frmHoaDon.ShowDialog()
    End Sub
End Class