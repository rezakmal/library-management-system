﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserIdToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.tsSearch = New System.Windows.Forms.ToolStripButton()
        Me.lblTime = New System.Windows.Forms.ToolStripLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripLabel()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBorrower = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnOverdue = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.btnLogs = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.UserIdToolStripStatus, Me.ToolStripStatusLabel3, Me.UserToolStripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1144, 30)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(27, 24)
        Me.ToolStripStatusLabel1.Text = "ID:"
        '
        'UserIdToolStripStatus
        '
        Me.UserIdToolStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.UserIdToolStripStatus.Name = "UserIdToolStripStatus"
        Me.UserIdToolStripStatus.Size = New System.Drawing.Size(17, 24)
        Me.UserIdToolStripStatus.Text = " "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(41, 24)
        Me.ToolStripStatusLabel3.Text = "User:"
        '
        'UserToolStripStatus
        '
        Me.UserToolStripStatus.Name = "UserToolStripStatus"
        Me.UserToolStripStatus.Size = New System.Drawing.Size(13, 24)
        Me.UserToolStripStatus.Text = " "
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLogin, Me.tsSearch, Me.lblTime, Me.lblDate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1144, 59)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsLogin
        '
        Me.tsLogin.BackColor = System.Drawing.Color.Transparent
        Me.tsLogin.Image = CType(resources.GetObject("tsLogin.Image"), System.Drawing.Image)
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(55, 56)
        Me.tsLogin.Text = "Masuk"
        Me.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSearch
        '
        Me.tsSearch.BackColor = System.Drawing.Color.Transparent
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(39, 56)
        Me.tsSearch.Text = "Cari"
        Me.tsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblTime
        '
        Me.lblTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(35, 56)
        Me.lblTime.Text = "Jam"
        '
        'lblDate
        '
        Me.lblDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(61, 56)
        Me.lblDate.Text = "Tanggal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.btnBorrower)
        Me.GroupBox2.Controls.Add(Me.btnBooks)
        Me.GroupBox2.Location = New System.Drawing.Point(107, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 194)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(246, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnBorrower
        '
        Me.btnBorrower.Location = New System.Drawing.Point(246, 148)
        Me.btnBorrower.Name = "btnBorrower"
        Me.btnBorrower.Size = New System.Drawing.Size(167, 25)
        Me.btnBorrower.TabIndex = 1
        Me.btnBorrower.Text = "Peminjam"
        Me.btnBorrower.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Location = New System.Drawing.Point(20, 148)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(167, 25)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Inventaris"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.PictureBox6)
        Me.GroupBox3.Controls.Add(Me.btnOverdue)
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.btnReturn)
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Controls.Add(Me.btnBorrow)
        Me.GroupBox3.Location = New System.Drawing.Point(587, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 194)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sirkulasi"
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(315, 43)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(123, 78)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'btnOverdue
        '
        Me.btnOverdue.Location = New System.Drawing.Point(315, 127)
        Me.btnOverdue.Name = "btnOverdue"
        Me.btnOverdue.Size = New System.Drawing.Size(124, 25)
        Me.btnOverdue.TabIndex = 8
        Me.btnOverdue.Text = "Keterlambatan"
        Me.btnOverdue.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(156, 43)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(123, 78)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(156, 127)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(124, 25)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Pengembalian"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(20, 43)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(123, 78)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(20, 127)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(124, 25)
        Me.btnBorrow.TabIndex = 4
        Me.btnBorrow.Text = "Peminjaman"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.PictureBox7)
        Me.GroupBox4.Controls.Add(Me.PictureBox8)
        Me.GroupBox4.Controls.Add(Me.btnCategories)
        Me.GroupBox4.Controls.Add(Me.btnUser)
        Me.GroupBox4.Location = New System.Drawing.Point(107, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(434, 193)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pengaturan"
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(246, 43)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(20, 43)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'btnCategories
        '
        Me.btnCategories.Location = New System.Drawing.Point(246, 148)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(167, 25)
        Me.btnCategories.TabIndex = 1
        Me.btnCategories.Text = "Kategori"
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(20, 148)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(167, 25)
        Me.btnUser.TabIndex = 0
        Me.btnUser.Text = "Pengguna"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox5.Controls.Add(Me.PictureBox9)
        Me.GroupBox5.Controls.Add(Me.PictureBox10)
        Me.GroupBox5.Controls.Add(Me.btnLogs)
        Me.GroupBox5.Controls.Add(Me.btnReports)
        Me.GroupBox5.Location = New System.Drawing.Point(587, 266)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(458, 193)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Laporan"
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(273, 43)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 3
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(20, 43)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(166, 99)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox10.TabIndex = 2
        Me.PictureBox10.TabStop = False
        '
        'btnLogs
        '
        Me.btnLogs.Location = New System.Drawing.Point(273, 148)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(167, 25)
        Me.btnLogs.TabIndex = 1
        Me.btnLogs.Text = "Audit"
        Me.btnLogs.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(19, 148)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(167, 25)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Inventaris"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1144, 497)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Manajemen Inventaris"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserIdToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsLogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBorrower As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnOverdue As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents btnLogs As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents tsSearch As ToolStripButton
    Friend WithEvents lblTime As ToolStripLabel
    Friend WithEvents lblDate As ToolStripLabel
End Class
