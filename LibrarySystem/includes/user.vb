Imports MySql.Data.MySqlClient

Module user
    Public con As MySqlConnection = mysqldb()

    Public Sub visibleMenu()
        With MainForm
            .btnBooks.Enabled = False
            .btnBorrower.Enabled = False
            .btnUser.Enabled = False
            .btnCategories.Enabled = False
            .btnLogs.Enabled = False
            .btnBorrow.Enabled = False
            .btnOverdue.Enabled = False
            .btnReports.Enabled = False
            .btnReturn.Enabled = False
            .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/logo/login.png")
        End With
    End Sub

    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM `tbluser` WHERE User_name= '" & username & "' and Pass = sha1('" & pass & "')")

            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("UserRole") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))

                    With MainForm
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        .btnUser.Enabled = True
                        .btnCategories.Enabled = True
                        .btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                    End With

                ElseIf dt.Rows(0).Item("UserRole") = "Manager" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))

                    With MainForm
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        .btnUser.Enabled = True
                        .btnCategories.Enabled = True
                        .btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                    End With

                ElseIf dt.Rows(0).Item("UserRole") = "Assistant" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))

                    With MainForm
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        '.btnUser.Enabled = True
                        '.btnCategories.Enabled = True
                        '.btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                    End With

                End If

                LoginForm.Close()

                With MainForm
                    .tsLogin.Text = "Keluar"
                    .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/logo/logout.png")
                End With

                MainForm.UserIdToolStripStatus.Text = dt.Rows(0).Item("UserId")
                MainForm.UserToolStripStatus.Text = dt.Rows(0).Item("Fullname")
                MainForm.StatusStrip1.Visible = True

                'Inserting logs
                sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " &
                   " VALUES ('" & dt.Rows(0).Item("UserId") & "',Now(),'Logged in')"
                create(sql)

            Else
                MsgBox("Data yang Anda masukkan tidak valid!", MsgBoxStyle.Exclamation, "Kesalahan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
