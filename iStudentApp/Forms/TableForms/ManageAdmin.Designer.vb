<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageAdmin))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdminUser = New System.Windows.Forms.TextBox()
        Me.cboxPassword = New System.Windows.Forms.CheckBox()
        Me.btnSaveAcc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panelName = New System.Windows.Forms.Panel()
        Me.txtAdminName = New System.Windows.Forms.TextBox()
        Me.panelRePass = New System.Windows.Forms.Panel()
        Me.txtAdminRe = New System.Windows.Forms.TextBox()
        Me.panelPass = New System.Windows.Forms.Panel()
        Me.txtAdminPass = New System.Windows.Forms.TextBox()
        Me.panelUser = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.adminRecordView = New System.Windows.Forms.DataGridView()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchAccounts = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.panelName.SuspendLayout()
        Me.panelRePass.SuspendLayout()
        Me.panelPass.SuspendLayout()
        Me.panelUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.adminRecordView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(268, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "        Manage Admin Accounts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(87, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(87, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(87, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Re-enter Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(87, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name:"
        '
        'txtAdminUser
        '
        Me.txtAdminUser.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUser.Location = New System.Drawing.Point(7, 4)
        Me.txtAdminUser.Name = "txtAdminUser"
        Me.txtAdminUser.Size = New System.Drawing.Size(174, 26)
        Me.txtAdminUser.TabIndex = 5
        '
        'cboxPassword
        '
        Me.cboxPassword.AutoSize = True
        Me.cboxPassword.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.cboxPassword.Location = New System.Drawing.Point(91, 271)
        Me.cboxPassword.Name = "cboxPassword"
        Me.cboxPassword.Size = New System.Drawing.Size(132, 23)
        Me.cboxPassword.TabIndex = 71
        Me.cboxPassword.Text = "Show Password"
        Me.cboxPassword.UseVisualStyleBackColor = True
        '
        'btnSaveAcc
        '
        Me.btnSaveAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSaveAcc.FlatAppearance.BorderSize = 0
        Me.btnSaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAcc.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAcc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSaveAcc.Location = New System.Drawing.Point(265, 262)
        Me.btnSaveAcc.Name = "btnSaveAcc"
        Me.btnSaveAcc.Size = New System.Drawing.Size(174, 38)
        Me.btnSaveAcc.TabIndex = 72
        Me.btnSaveAcc.Text = "SAVE ADMIN ACCOUNT"
        Me.btnSaveAcc.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.panelName)
        Me.GroupBox1.Controls.Add(Me.panelRePass)
        Me.GroupBox1.Controls.Add(Me.panelPass)
        Me.GroupBox1.Controls.Add(Me.panelUser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSaveAcc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboxPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(132, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 342)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Account"
        '
        'panelName
        '
        Me.panelName.Controls.Add(Me.txtAdminName)
        Me.panelName.Location = New System.Drawing.Point(255, 202)
        Me.panelName.Name = "panelName"
        Me.panelName.Size = New System.Drawing.Size(187, 36)
        Me.panelName.TabIndex = 76
        '
        'txtAdminName
        '
        Me.txtAdminName.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminName.Location = New System.Drawing.Point(7, 5)
        Me.txtAdminName.Name = "txtAdminName"
        Me.txtAdminName.Size = New System.Drawing.Size(174, 26)
        Me.txtAdminName.TabIndex = 5
        '
        'panelRePass
        '
        Me.panelRePass.Controls.Add(Me.txtAdminRe)
        Me.panelRePass.Location = New System.Drawing.Point(255, 158)
        Me.panelRePass.Name = "panelRePass"
        Me.panelRePass.Size = New System.Drawing.Size(187, 36)
        Me.panelRePass.TabIndex = 75
        '
        'txtAdminRe
        '
        Me.txtAdminRe.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminRe.Location = New System.Drawing.Point(7, 5)
        Me.txtAdminRe.Name = "txtAdminRe"
        Me.txtAdminRe.Size = New System.Drawing.Size(174, 26)
        Me.txtAdminRe.TabIndex = 5
        Me.txtAdminRe.UseSystemPasswordChar = True
        '
        'panelPass
        '
        Me.panelPass.Controls.Add(Me.txtAdminPass)
        Me.panelPass.Location = New System.Drawing.Point(256, 113)
        Me.panelPass.Name = "panelPass"
        Me.panelPass.Size = New System.Drawing.Size(187, 36)
        Me.panelPass.TabIndex = 74
        '
        'txtAdminPass
        '
        Me.txtAdminPass.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPass.Location = New System.Drawing.Point(7, 5)
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.Size = New System.Drawing.Size(174, 26)
        Me.txtAdminPass.TabIndex = 5
        Me.txtAdminPass.UseSystemPasswordChar = True
        '
        'panelUser
        '
        Me.panelUser.Controls.Add(Me.txtAdminUser)
        Me.panelUser.Location = New System.Drawing.Point(256, 68)
        Me.panelUser.Name = "panelUser"
        Me.panelUser.Size = New System.Drawing.Size(187, 36)
        Me.panelUser.TabIndex = 73
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.adminRecordView)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(57, 429)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 218)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Admin Accounts"
        '
        'adminRecordView
        '
        Me.adminRecordView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.adminRecordView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.adminRecordView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.adminRecordView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.adminRecordView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.adminRecordView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.adminRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adminRecordView.EnableHeadersVisualStyles = False
        Me.adminRecordView.Location = New System.Drawing.Point(16, 29)
        Me.adminRecordView.Name = "adminRecordView"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.adminRecordView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.adminRecordView.RowHeadersWidth = 45
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.adminRecordView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.adminRecordView.Size = New System.Drawing.Size(622, 171)
        Me.adminRecordView.TabIndex = 65
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearch.Location = New System.Drawing.Point(393, 405)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(68, 21)
        Me.lblSearch.TabIndex = 76
        Me.lblSearch.Text = "Search:"
        '
        'txtSearchAccounts
        '
        Me.txtSearchAccounts.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAccounts.Location = New System.Drawing.Point(467, 405)
        Me.txtSearchAccounts.Name = "txtSearchAccounts"
        Me.txtSearchAccounts.Size = New System.Drawing.Size(244, 23)
        Me.txtSearchAccounts.TabIndex = 75
        '
        'ManageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 659)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearchAccounts)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAdmin"
        Me.Text = "ManageAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelName.ResumeLayout(False)
        Me.panelName.PerformLayout()
        Me.panelRePass.ResumeLayout(False)
        Me.panelRePass.PerformLayout()
        Me.panelPass.ResumeLayout(False)
        Me.panelPass.PerformLayout()
        Me.panelUser.ResumeLayout(False)
        Me.panelUser.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.adminRecordView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAdminUser As TextBox
    Friend WithEvents cboxPassword As CheckBox
    Friend WithEvents btnSaveAcc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchAccounts As TextBox
    Friend WithEvents adminRecordView As DataGridView
    Friend WithEvents panelName As Panel
    Friend WithEvents txtAdminName As TextBox
    Friend WithEvents panelRePass As Panel
    Friend WithEvents txtAdminRe As TextBox
    Friend WithEvents panelPass As Panel
    Friend WithEvents txtAdminPass As TextBox
    Friend WithEvents panelUser As Panel
End Class
