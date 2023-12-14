Public Class CategoryForm
    Dim categoryid = 0
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtCategory.Text = "" Then
            MsgBox("Field is required.", MsgBoxStyle.Exclamation)
        Else
            sql = "SELECT * FROM tblcategory WHERE CategoryId = " & categoryid

            sqladd = "INSERT INTO `tblcategory` (`Category`) VALUES ('" & txtCategory.Text & "')"

            sqledit = "UPDATE `tblcategory` SET `Category`='" & txtCategory.Text & "' WHERE CategoryId=" & categoryid

            save_or_update(sql, sqladd, sqledit, "Category has been updated in the database.", "New category has been saved in the database.")

            Call frmCategory_Load(sender, e)

        End If
    End Sub

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call btnnew_Click(sender, e)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            With dtglist
                categoryid = .CurrentRow.Cells(0).Value
                txtCategory.Text = .CurrentRow.Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        categoryid = 0
        txtCategory.Clear()
        sql = "SELECT CategoryId,`Category` FROM tblcategory WHERE Category !='ALL'"
        reloadDtg(sql, dtglist)
        btndelete.Enabled = False

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT CategoryId,`Category` FROM tblcategory WHERE Category !='ALL' AND  Category Like '%" & txtSearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.Click
        Try
            With dtglist
                categoryid = .CurrentRow.Cells(0).Value
                txtCategory.Text = .CurrentRow.Cells(1).Value

                btndelete.Enabled = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE From tblcategory WHERE CategoryId = " & dtglist.CurrentRow.Cells(0).Value
            deletes(sql)
            MsgBox("Data has been deleted", MsgBoxStyle.Exclamation)
            Call btnnew_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class