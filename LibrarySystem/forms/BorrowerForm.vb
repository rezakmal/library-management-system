Imports System.IO

Public Class BorrowerForm
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            If txt_bid.Text = "" Or txt_fname.Text = "" _
            Or txt_lname.Text = "" Or txt_mname.Text = "" Then
                emptymessage()
            Else
                ''conditionin the gender of a borrower
                Dim gender As String
                If rdio_female.Checked = True Then
                    gender = "Female"
                Else
                    gender = "Male"
                End If

                sql = "SELECT * FROM `tblborrower` WHERE `BorrowerId`=" & txt_bid.Text

                sqladd = "insert into tblborrower (`BorrowerId`, `Firstname`, `Lastname`, `MiddleName`, `Address`, " _
                       & "`Sex`, `ContactNo`, `BorrowerType`)" _
                       & "values ('" & txt_bid.Text & "','" & txt_fname.Text & "','" & txt_lname.Text _
                       & "','" & txt_mname.Text & "','" & rch_address.Text _
                       & "','" & gender & "','" & txtContact.Text & "','Student')"

                sqledit = "update  tblborrower set  `Firstname`='" & txt_fname.Text _
                      & "', `Lastname`='" & txt_lname.Text & "', `MiddleName`='" & txt_mname.Text _
                      & "', `Address`='" & rch_address.Text & "', `Sex`='" & gender _
                      & "', `ContactNo` ='" & txtContact.Text & "', `BorrowerType`='Student' where `BorrowerId`='" & txt_bid.Text & "'"

                save_or_update(sql, sqladd, sqledit, "Borrower has been updated in the database.", "New borrower has been added in the database.")


                'Call BorrowerForm_Load(sender, e)
                'txt_bid.Clear()
                Call btn_New_Click(sender, e)
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_bid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bid.TextChanged
        reloadtxt("SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" & txt_bid.Text & "'")

        If dt.Rows.Count > 0 Then
            txt_fname.Text = dt.Rows(0).Item("Firstname")
            txt_lname.Text = dt.Rows(0).Item("Lastname")
            txt_mname.Text = dt.Rows(0).Item("MiddleName")
            rch_address.Text = dt.Rows(0).Item("Address")
            txtContact.Text = dt.Rows(0).Item("ContactNo")

            If dt.Rows(0).Item("Sex") = "Female" Then
                rdio_female.Checked = True
            Else
                rdio_male.Checked = True
            End If

            btn_delete.Enabled = True
        Else
            clearme()
            btn_delete.Enabled = False
        End If
    End Sub

    Public Sub clearme()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_mname.Clear()
        rch_address.Clear()
        txtContact.Clear()
    End Sub

    Private Sub BorrowerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT BorrowerId, `Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo` FROM `tblborrower`"
        reloadDtg(sql, dtg_ABorrowLists)

        select_navigation("select BorrowerId from tblborrower")
        btn_delete.Enabled = False
    End Sub

    Private Sub dtg_ABorrowLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_ABorrowLists.Click
        Try
            txt_bid.Text = dtg_ABorrowLists.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        cleartext(Me)
        sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo` FROM `tblborrower`"
        reloadDtg(sql, dtg_ABorrowLists)
        btn_delete.Enabled = False
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        select_navigation("select BorrowerId from tblborrower")
        If inc <> maxrows - 1 Then
            inc = inc + 1
            navagate_records(txt_bid)
        Else
            If inc = maxrows - 1 Then
                MsgBox("No more rows", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btn_prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prev.Click
        select_navigation("select BorrowerId from tblborrower")
        If inc > 0 Then
            inc = inc - 1
            navagate_records(txt_bid)
        Else
            If inc - 1 Then
                MsgBox("First records", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            select_navigation("select BorrowerId from tblborrower")
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                navagate_records(txt_bid)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        Try
            select_navigation("select BorrowerId from tblborrower")
            inc = 0
            navagate_records(txt_bid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        If MessageBox.Show("Are you sure you want to delete this borrower?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            sql = "DELETE FROM `tblborrower` WHERE `BorrowerId` ='" & dtg_ABorrowLists.CurrentRow.Cells(0).Value & "'"
            result = deletes(sql)
            If result = True Then
                MessageBox.Show("Borrower has been deleted in the database.", "Success", MessageBoxButtons.OK)
            End If
            'Call frm_adduser_Load(sender, e)
            'cleartext(Me)
            Call btn_New_Click(sender, e)
        End If
    End Sub
End Class