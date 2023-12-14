<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btn_Bsave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchAccesion = New System.Windows.Forms.Button()
        Me.txtAccesionNumBorrow = New System.Windows.Forms.TextBox()
        Me.lblAccessionNumBorrow = New System.Windows.Forms.Label()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.txtDatePublish = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_Bgroup = New System.Windows.Forms.GroupBox()
        Me.txtBorrowerId = New System.Windows.Forms.TextBox()
        Me.btnSearchBorrower = New System.Windows.Forms.Button()
        Me.cboPurpose = New System.Windows.Forms.ComboBox()
        Me.txtdue = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.dtg_BlistOfBooks = New System.Windows.Forms.DataGridView()
        Me.check_due = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_Bgroup.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dtg_BlistOfBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(13, 13)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1119, 384)
        Me.TabControl2.TabIndex = 21
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnNew)
        Me.TabPage3.Controls.Add(Me.btn_Bsave)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.grp_Bgroup)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(1111, 355)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Pinjam"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(948, 297)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(155, 48)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "Clear"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btn_Bsave
        '
        Me.btn_Bsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bsave.Location = New System.Drawing.Point(787, 297)
        Me.btn_Bsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Bsave.Name = "btn_Bsave"
        Me.btn_Bsave.Size = New System.Drawing.Size(155, 48)
        Me.btn_Bsave.TabIndex = 17
        Me.btn_Bsave.Text = "Borrow"
        Me.btn_Bsave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchAccesion)
        Me.GroupBox1.Controls.Add(Me.txtAccesionNumBorrow)
        Me.GroupBox1.Controls.Add(Me.lblAccessionNumBorrow)
        Me.GroupBox1.Controls.Add(Me.txtpublisher)
        Me.GroupBox1.Controls.Add(Me.txtDatePublish)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(521, 281)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Inventaris"
        '
        'btnSearchAccesion
        '
        Me.btnSearchAccesion.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAccesion.Location = New System.Drawing.Point(400, 60)
        Me.btnSearchAccesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchAccesion.Name = "btnSearchAccesion"
        Me.btnSearchAccesion.Size = New System.Drawing.Size(76, 31)
        Me.btnSearchAccesion.TabIndex = 24
        Me.btnSearchAccesion.Text = "Find"
        Me.btnSearchAccesion.UseVisualStyleBackColor = True
        '
        'txtAccesionNumBorrow
        '
        Me.txtAccesionNumBorrow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAccesionNumBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAccesionNumBorrow.Location = New System.Drawing.Point(157, 62)
        Me.txtAccesionNumBorrow.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccesionNumBorrow.Name = "txtAccesionNumBorrow"
        Me.txtAccesionNumBorrow.Size = New System.Drawing.Size(233, 29)
        Me.txtAccesionNumBorrow.TabIndex = 17
        '
        'lblAccessionNumBorrow
        '
        Me.lblAccessionNumBorrow.AutoSize = True
        Me.lblAccessionNumBorrow.Location = New System.Drawing.Point(20, 64)
        Me.lblAccessionNumBorrow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccessionNumBorrow.Name = "lblAccessionNumBorrow"
        Me.lblAccessionNumBorrow.Size = New System.Drawing.Size(125, 23)
        Me.lblAccessionNumBorrow.TabIndex = 16
        Me.lblAccessionNumBorrow.Text = "Accession No. :"
        '
        'txtpublisher
        '
        Me.txtpublisher.Enabled = False
        Me.txtpublisher.Location = New System.Drawing.Point(157, 178)
        Me.txtpublisher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(332, 29)
        Me.txtpublisher.TabIndex = 14
        '
        'txtDatePublish
        '
        Me.txtDatePublish.Enabled = False
        Me.txtDatePublish.Location = New System.Drawing.Point(157, 140)
        Me.txtDatePublish.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatePublish.Name = "txtDatePublish"
        Me.txtDatePublish.Size = New System.Drawing.Size(332, 29)
        Me.txtDatePublish.TabIndex = 14
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(157, 103)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(332, 29)
        Me.txtTitle.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Vendor :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 143)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 23)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Date Acquired :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title :"
        '
        'grp_Bgroup
        '
        Me.grp_Bgroup.Controls.Add(Me.txtBorrowerId)
        Me.grp_Bgroup.Controls.Add(Me.btnSearchBorrower)
        Me.grp_Bgroup.Controls.Add(Me.cboPurpose)
        Me.grp_Bgroup.Controls.Add(Me.txtdue)
        Me.grp_Bgroup.Controls.Add(Me.txtName)
        Me.grp_Bgroup.Controls.Add(Me.Label15)
        Me.grp_Bgroup.Controls.Add(Me.Label7)
        Me.grp_Bgroup.Controls.Add(Me.Label17)
        Me.grp_Bgroup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Bgroup.Location = New System.Drawing.Point(537, 8)
        Me.grp_Bgroup.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_Bgroup.Name = "grp_Bgroup"
        Me.grp_Bgroup.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_Bgroup.Size = New System.Drawing.Size(566, 281)
        Me.grp_Bgroup.TabIndex = 15
        Me.grp_Bgroup.TabStop = False
        Me.grp_Bgroup.Text = "Peminjam"
        '
        'txtBorrowerId
        '
        Me.txtBorrowerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBorrowerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBorrowerId.Location = New System.Drawing.Point(149, 74)
        Me.txtBorrowerId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBorrowerId.Name = "txtBorrowerId"
        Me.txtBorrowerId.Size = New System.Drawing.Size(233, 29)
        Me.txtBorrowerId.TabIndex = 24
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrower.Location = New System.Drawing.Point(391, 74)
        Me.btnSearchBorrower.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(76, 31)
        Me.btnSearchBorrower.TabIndex = 23
        Me.btnSearchBorrower.Text = "Find"
        Me.btnSearchBorrower.UseVisualStyleBackColor = True
        '
        'cboPurpose
        '
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.Items.AddRange(New Object() {"Overnight", "Research"})
        Me.cboPurpose.Location = New System.Drawing.Point(149, 149)
        Me.cboPurpose.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(327, 29)
        Me.cboPurpose.TabIndex = 22
        Me.cboPurpose.Text = "Select"
        '
        'txtdue
        '
        Me.txtdue.Location = New System.Drawing.Point(391, 149)
        Me.txtdue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdue.Name = "txtdue"
        Me.txtdue.Size = New System.Drawing.Size(52, 29)
        Me.txtdue.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(149, 112)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(327, 29)
        Me.txtName.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(57, 153)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 23)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Purpose :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Borrower Id :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(75, 116)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 23)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Name :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(1111, 355)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Inventaris yang Dipinjam"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txt_Search)
        Me.GroupBox6.Controls.Add(Me.dtg_BlistOfBooks)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(1092, 340)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "List Of Borrowed Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(571, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search :"
        '
        'txt_Search
        '
        Me.txt_Search.BackColor = System.Drawing.Color.White
        Me.txt_Search.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(676, 30)
        Me.txt_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(407, 36)
        Me.txt_Search.TabIndex = 1
        '
        'dtg_BlistOfBooks
        '
        Me.dtg_BlistOfBooks.AllowUserToAddRows = False
        Me.dtg_BlistOfBooks.AllowUserToDeleteRows = False
        Me.dtg_BlistOfBooks.AllowUserToResizeColumns = False
        Me.dtg_BlistOfBooks.AllowUserToResizeRows = False
        Me.dtg_BlistOfBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_BlistOfBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_BlistOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_BlistOfBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_BlistOfBooks.Location = New System.Drawing.Point(8, 76)
        Me.dtg_BlistOfBooks.Margin = New System.Windows.Forms.Padding(4)
        Me.dtg_BlistOfBooks.Name = "dtg_BlistOfBooks"
        Me.dtg_BlistOfBooks.RowHeadersVisible = False
        Me.dtg_BlistOfBooks.RowHeadersWidth = 51
        Me.dtg_BlistOfBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_BlistOfBooks.Size = New System.Drawing.Size(1076, 256)
        Me.dtg_BlistOfBooks.TabIndex = 0
        '
        'check_due
        '
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 412)
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_Bgroup.ResumeLayout(False)
        Me.grp_Bgroup.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dtg_BlistOfBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Bsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchAccesion As System.Windows.Forms.Button
    Friend WithEvents txtAccesionNumBorrow As System.Windows.Forms.TextBox
    Friend WithEvents lblAccessionNumBorrow As System.Windows.Forms.Label
    Friend WithEvents txtDatePublish As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grp_Bgroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtBorrowerId As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchBorrower As System.Windows.Forms.Button
    Friend WithEvents cboPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtdue As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents dtg_BlistOfBooks As System.Windows.Forms.DataGridView
    Friend WithEvents txtpublisher As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents check_due As System.Windows.Forms.Timer
End Class
