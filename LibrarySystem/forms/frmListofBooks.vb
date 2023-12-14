Public Class frmListofBooks
    Private Sub frmListofBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category` " &
      ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
        cbo_fill(cboCategories, "Category", "CategoryId", "tblcategory  ORDER BY CATEGORY ASC")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Try
        '    If cboCategories.Text = "All" Then
        '        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
        '           ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
        '    Else
        '        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
        '           ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND c.`CategoryId` ='" & cboCategories.SelectedValue & "' AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
        '    End If
        '    reloadDtg(sql, dtgList)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cboCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategories.SelectedIndexChanged
        Try
            'If cboCategories.Text = "All" Then
            '    sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
            '       ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            'Else
            '    sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
            '       ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND c.`CategoryId` = '" & cboCategories.SelectedValue & "' AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            'End If
            'reloadDtg(sql, dtgList)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCategories_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategories.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cboCategories.Text = "ALL" Then
                sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
                   ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            Else
                sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`" &
                   ", Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND c.`CategoryId` ='" & cboCategories.SelectedValue & "' AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            End If
            reloadDtg(sql, dtgList)
        Catch ex As Exception

        End Try
    End Sub
End Class