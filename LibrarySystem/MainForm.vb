Public Class MainForm
    Dim blneCancel As Boolean = False

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Select Case ((m.WParam.ToInt64() And &HFFFF) And &HFFF0)
            Case &HF060 ' The user chose to close the form.
                If tsLogin.Text = "Keluar" Then
                    MsgBox("Mohon keluar dari sesi sebelum menutup aplikasi!", MsgBoxStyle.Information, "Peringatan")
                    Me.CausesValidation = True
                    blneCancel = True
                Else
                    Me.CausesValidation = False
                    blneCancel = False
                End If
        End Select

        MyBase.WndProc(m)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        visibleMenu()
        Timer1.Start()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If blneCancel = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = "Jam: " & Format(Now(), "HH:mm:ss")
        lblDate.Text = "Tanggal: " & Format(Now(), "dd/MM/yyyy")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Masuk" Then
            LoginForm.Show()
            LoginForm.Focus()

        Else
            tsLogin.Text = "Masuk"
            visibleMenu()
            sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " &
               " VALUES ('" & UserIdToolStripStatus.Text & "',Now(),'Logged out')"
            create(sql)

            UserIdToolStripStatus.Text = ""
            UserToolStripStatus.Text = ""
            formClose()
        End If
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles tsSearch.Click
        With frmListofBooks
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        With InventoryForm
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnBorrower_Click(sender As Object, e As EventArgs) Handles btnBorrower.Click
        With BorrowerForm
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        With UserForm
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        With CategoryForm
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        With BorrowForm
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        With frmReturn
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnOverdue_Click(sender As Object, e As EventArgs) Handles btnOverdue.Click
        With frmPayments
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        With frmReport
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        With frmUserlogs
            .Show()
            .Focus()
        End With
    End Sub
End Class
