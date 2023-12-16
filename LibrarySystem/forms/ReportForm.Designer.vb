<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportForm
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnListBooks = New System.Windows.Forms.Button()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_strtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_endDate = New System.Windows.Forms.DateTimePicker()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(215, 607)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnListBooks)
        Me.GroupBox1.Controls.Add(Me.rdoMonthly)
        Me.GroupBox1.Controls.Add(Me.rdoWeekly)
        Me.GroupBox1.Controls.Add(Me.rdoDaily)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(203, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventaris"
        '
        'btnListBooks
        '
        Me.btnListBooks.Location = New System.Drawing.Point(12, 31)
        Me.btnListBooks.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListBooks.Name = "btnListBooks"
        Me.btnListBooks.Size = New System.Drawing.Size(177, 27)
        Me.btnListBooks.TabIndex = 2
        Me.btnListBooks.Text = "Daftar Inventaris"
        Me.btnListBooks.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Location = New System.Drawing.Point(12, 193)
        Me.rdoMonthly.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(118, 20)
        Me.rdoMonthly.TabIndex = 2
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly Report"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'rdoWeekly
        '
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Location = New System.Drawing.Point(12, 165)
        Me.rdoWeekly.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(118, 20)
        Me.rdoWeekly.TabIndex = 2
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly Report"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'rdoDaily
        '
        Me.rdoDaily.AutoSize = True
        Me.rdoDaily.Location = New System.Drawing.Point(12, 137)
        Me.rdoDaily.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(103, 20)
        Me.rdoDaily.TabIndex = 2
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Text = "Daily Report"
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status :"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Borrowed", "Returned", "Overdue"})
        Me.cboStatus.Location = New System.Drawing.Point(12, 96)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(177, 24)
        Me.cboStatus.TabIndex = 0
        Me.cboStatus.Text = "Borrowed"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_strtDate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtp_endDate)
        Me.GroupBox2.Controls.Add(Me.btn_preview)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 233)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(203, 186)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Filter"
        '
        'dtp_strtDate
        '
        Me.dtp_strtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_strtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_strtDate.Location = New System.Drawing.Point(12, 50)
        Me.dtp_strtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_strtDate.Name = "dtp_strtDate"
        Me.dtp_strtDate.Size = New System.Drawing.Size(175, 22)
        Me.dtp_strtDate.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Start Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "End Date :"
        '
        'dtp_endDate
        '
        Me.dtp_endDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_endDate.Location = New System.Drawing.Point(12, 110)
        Me.dtp_endDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_endDate.Name = "dtp_endDate"
        Me.dtp_endDate.Size = New System.Drawing.Size(175, 22)
        Me.dtp_endDate.TabIndex = 17
        '
        'btn_preview
        '
        Me.btn_preview.Location = New System.Drawing.Point(83, 140)
        Me.btn_preview.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(104, 34)
        Me.btn_preview.TabIndex = 15
        Me.btn_preview.Text = "Preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(215, 0)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1032, 607)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 607)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReportForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Inventaris"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents rdoMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWeekly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDaily As System.Windows.Forms.RadioButton
    Friend WithEvents btnListBooks As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_strtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_endDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_preview As System.Windows.Forms.Button
End Class
