Public Class frmListBooks

    Private Sub frmListBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
        ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub txtSerach_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
         ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If dtgList.CurrentRow.Cells(6).Value = "Available" Then
                BorrowForm.txtAccesionNumBorrow.Text = dtgList.CurrentRow.Cells(0).Value
                Me.Close()
            Else
                MsgBox("The book is already borrowed.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class