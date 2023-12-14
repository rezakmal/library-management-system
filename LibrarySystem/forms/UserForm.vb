Public Class UserForm

    Private Sub frm_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbo_type.Text = "Administrator"
            reloadDtg("SELECT UserId as 'ID', Fullname as 'Name', User_name as 'UserName', UserRole as 'Type' FROM tbluser", dtg_listUser)
            dtg_listUser.Columns(0).Visible = False
            If lbl_id.Text = "id" Then
                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True
            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        lbl_id.Text = "id"
        Call frm_adduser_Load(sender, e)
        cleartext(Me)
    End Sub

    Private Sub btn_saveuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveuser.Click

        If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
            emptymessage()
        Else
            result = create("INSERT INTO tbluser (`Fullname`, `User_name`, `Pass`, `UserRole`) " _
             & "VALUES('" & txt_name.Text & "','" & txt_username.Text _
             & "',sha1('" & txt_pass.Text & "'),'" & cbo_type.Text _
             & "')")
            If result = True Then
                MsgBox("User has been saved in the database.")
            End If
            Call btn_close_Click(sender, e)
            cleartext(Me)
        End If

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Try
            If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
                emptymessage()
            Else
                result = updates("UPDATE tbluser SET Fullname = '" & txt_name.Text & "',User_name= '" & txt_username.Text _
                            & "',Pass= sha1('" & txt_pass.Text & "'),UserRole= '" & cbo_type.Text _
                            & "' where UserId = " & lbl_id.Text)
                If result = True Then
                    MsgBox("User has been updated in the database.")
                End If

                Call btn_close_Click(sender, e)
                cleartext(Me)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try

            If MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                'result = deletes("delete from tbluser where UserId = '" & lbl_id.Text & "'")
                result = updates("DELETE FROM tbluser WHERE UserId = " & lbl_id.Text)
                If result = True Then
                    MessageBox.Show("User has been deleted in the database.", "Success", MessageBoxButtons.OK)
                End If
                'Call frm_adduser_Load(sender, e)
                cleartext(Me)
                Call btn_close_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtg_listUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listUser.Click
        Try
            With dtg_listUser.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_username.Text = .Cells(2).Value
                cbo_type.Text = .Cells(3).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtg_listUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listUser.DoubleClick
        Try
            With dtg_listUser.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_username.Text = .Cells(2).Value
                cbo_type.Text = .Cells(3).Value
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub lbl_id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_id.TextChanged
        Try
            If lbl_id.Text = "id" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class