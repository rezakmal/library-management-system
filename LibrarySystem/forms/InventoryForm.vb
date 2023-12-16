Public Class InventoryForm

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            Dim datePublish As String = Format(dtpDatePublish.Value, "yyyy-MM-dd")
            Dim remarks As String = ""



            If txtAccessionNo.Text = "" Or txtTitle.Text = "" Or txtDesc.Text = "" Or txtPublisher.Text = "" Then
                MsgBox("All fields are required to be filled up.", MsgBoxStyle.Exclamation)
            Else
                remarks = "Donate"

                sql = "SELECT * FROM `tblinventory` WHERE `AccessionNo` = " & txtAccessionNo.Text
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then
                    MsgBox("Accession number is already in used.", MsgBoxStyle.Exclamation)
                    Return
                End If

                sql = "SELECT * FROM `tblinventory` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"

                'Adding inventory
                sqladd = "INSERT INTO `tblinventory` " &
                " (`AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `CategoryId`, Status ,Remark) " &
                " VALUES ('" & txtAccessionNo.Text & "', '" & txtTitle.Text & "', '" & txtDesc.Text & "', '" & datePublish & "','" & txtPublisher.Text & "','" & cboCategory.SelectedValue & "', 'Available', '" & remarks & "')"

                'Updating inventory
                sqledit = "UPDATE `tblinventory` SET `Title`='" & txtTitle.Text &
                "', `Description`='" & txtDesc.Text & "', `PublishDate`='" & datePublish &
                "', `Vendor`='" & txtPublisher.Text & "', `CategoryId`='" & cboCategory.SelectedValue &
                "',Remark='" & remarks & " WHERE `AccessionNo`='" & txtAccessionNo.Text & "'"

                save_or_update(sql, sqladd, sqledit, "Inventory has been updated in the database.", "New inventory has been saved in the database.")

                Call InventoryForm_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InventoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call btnNew_Click(sender, e)

        sql = "SELECT * FROM `tblcategory` WHERE `CategoryId`=" & cboCategory.SelectedValue
        reloadtxt(sql)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        cleartext(Me)
        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`, Remark, Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
        cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory WHERE Category !='ALL'  ORDER BY CATEGORY ASC")

        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT `AccessionNo`, `Title`, `Description`, `PublishDate`, `Vendor`, `Category`, Remark, Status FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND (`Title` Like '%" & txtSearch.Text & "%' OR `AccessionNo`  Like '%" & txtSearch.Text & "%')"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub dtgList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgList.Click
        Try
            With dtgList
                txtAccessionNo.Text = .CurrentRow.Cells(0).Value
                txtTitle.Text = .CurrentRow.Cells(1).Value
                txtDesc.Text = .CurrentRow.Cells(2).Value
                dtpDatePublish.Value = Format(.CurrentRow.Cells(3).Value, "dd/MM/yyyy")
                txtPublisher.Text = .CurrentRow.Cells(4).Value
                cboCategory.Text = .CurrentRow.Cells(5).Value

                btnUpdate.Enabled = True
                btnSave.Enabled = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgList.DoubleClick
        Try

            sql = "SELECT * FROM `tblinventory` WHERE `AccessionNo` = " & txtAccessionNo.Text
            reloadtxt(sql)

            If dt.Rows.Count > 0 Then
                If MessageBox.Show("Accession number is already in used. Are you sure you want to proceed and update this book?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    With dtgList
                        txtAccessionNo.Text = .CurrentRow.Cells(0).Value
                        txtTitle.Text = .CurrentRow.Cells(1).Value
                        txtDesc.Text = .CurrentRow.Cells(2).Value
                        dtpDatePublish.Value = Format(.CurrentRow.Cells(3).Value, "dd/MM/yyyy")
                        txtPublisher.Text = .CurrentRow.Cells(4).Value
                        cboCategory.Text = .CurrentRow.Cells(5).Value
                        'txtPrice.Text = .CurrentRow.Cells(7).Value

                    End With
                Else
                    txtAccessionNo.Clear()
                    txtAccessionNo.Clear()
                    txtTitle.Clear()
                    txtDesc.Clear()
                    txtPublisher.Clear()
                    'txtPrice.Clear()
                    cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory")

                    'rdoDonate.Checked = True
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#Region "Numbers only"


    Private Sub txtAccessionNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccessionNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        Try
            sql = "SELECT * FROM `tblcategory` WHERE  `CategoryId`=" & cboCategory.SelectedValue
            reloadtxt(sql)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAccessionNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccessionNo.TextChanged
        Try
            sql = "SELECT `AccessionNo`, `Title`, `Description` , `PublishDate`, `Vendor`, `Category`, Remark  FROM `tblinventory` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND  `AccessionNo`= '" & txtAccessionNo.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtTitle.Text = .Item(1)
                    txtDesc.Text = .Item(2)
                    dtpDatePublish.Value = Format(.Item(3), "yyyy-MM-dd")
                    txtPublisher.Text = .Item(4)
                    cboCategory.Text = .Item(5)

                    btnUpdate.Enabled = True
                    btnSave.Enabled = False
                    btnDelete.Enabled = True
                End With
            Else
                txtTitle.Clear()
                txtDesc.Clear()
                txtPublisher.Clear()
                dtpDatePublish.Value = Format(Now(), "yyyy-MM-dd")
                cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory")

                btnUpdate.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'Try

        '    'If txtAccessionNo.Text = "" Then
        '    'Else

        '    '    sql = "SELECT * FROM `tblinventory` WHERE `AccessionNo` = " & txtAccessionNo.Text
        '    '    reloadtxt(sql)

        '    '    If dt.Rows.Count > 0 Then
        '    '        If MessageBox.Show("Accession number is already in used. Are you sure you want to proceed and update this book?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

        '    '        Else
        '    '            txtAccessionNo.Clear()
        '    '            cleartext(Me)

        '    '        End If
        '    '    End If

        '    'End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cboCategory_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            Dim datePublish As String = Format(dtpDatePublish.Value, "yyyy-MM-dd")
            Dim remarks As String = ""



            If txtAccessionNo.Text = "" Or txtTitle.Text = "" Or txtDesc.Text = "" Or txtPublisher.Text = "" Then
                MsgBox("All fields are required to filled up.", MsgBoxStyle.Exclamation)
            Else
                'If rdoDonate.Checked = True Then
                remarks = "Donate"
                'ElseIf rdoPurchased.Checked = True Then
                'remarks = "Purchased"
                'End If


                sql = "SELECT * FROM `tblinventory` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then

                    sqledit = "Update `tblinventory` Set `Title`='" & txtTitle.Text &
                    "', `Description`='" & txtDesc.Text & "', `PublishDate`='" & datePublish &
                    "', `Vendor`='" & txtPublisher.Text & "', `CategoryId`='" & cboCategory.SelectedValue &
                    "',Remark='" & remarks & "' WHERE `AccessionNo`='" & txtAccessionNo.Text & "'"


                    save_or_update(sql, sqladd, sqledit, "Books has been updated in the database.", "New books has been saved in the database.")

                    Call InventoryForm_Load(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        sql = "DELETE FROM `tblinventory` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"

        deletes(sql)

        MsgBox("Book has been deleted!", MsgBoxStyle.Information)
        Call btnNew_Click(sender, e)
    End Sub
End Class
