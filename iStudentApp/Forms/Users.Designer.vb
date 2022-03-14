<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cBoxPassword = New System.Windows.Forms.CheckBox()
        Me.btnUpdateAcc = New System.Windows.Forms.Button()
        Me.btnAddAcc = New System.Windows.Forms.Button()
        Me.btnDeleteAcc = New System.Windows.Forms.Button()
        Me.btnSaveAcc = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.studentAccountView = New System.Windows.Forms.DataGridView()
        Me.txtSearchAccounts = New System.Windows.Forms.TextBox()
        Me.studentDataBox = New System.Windows.Forms.GroupBox()
        Me.panelStudNo = New System.Windows.Forms.Panel()
        Me.cmbStudNo = New System.Windows.Forms.ComboBox()
        Me.panelPassword = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblStudNo = New System.Windows.Forms.Label()
        Me.lblStudNm = New System.Windows.Forms.Label()
        CType(Me.studentAccountView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentDataBox.SuspendLayout()
        Me.panelStudNo.SuspendLayout()
        Me.panelPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'cBoxPassword
        '
        Me.cBoxPassword.AutoSize = True
        Me.cBoxPassword.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.cBoxPassword.Location = New System.Drawing.Point(44, 171)
        Me.cBoxPassword.Name = "cBoxPassword"
        Me.cBoxPassword.Size = New System.Drawing.Size(147, 25)
        Me.cBoxPassword.TabIndex = 79
        Me.cBoxPassword.Text = "Show Password"
        Me.cBoxPassword.UseVisualStyleBackColor = True
        '
        'btnUpdateAcc
        '
        Me.btnUpdateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdateAcc.FlatAppearance.BorderSize = 0
        Me.btnUpdateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAcc.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAcc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdateAcc.Location = New System.Drawing.Point(597, 100)
        Me.btnUpdateAcc.Name = "btnUpdateAcc"
        Me.btnUpdateAcc.Size = New System.Drawing.Size(141, 51)
        Me.btnUpdateAcc.TabIndex = 78
        Me.btnUpdateAcc.Text = "UPDATE PASSWORD"
        Me.btnUpdateAcc.UseVisualStyleBackColor = False
        '
        'btnAddAcc
        '
        Me.btnAddAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddAcc.FlatAppearance.BorderSize = 0
        Me.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAcc.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAcc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddAcc.Location = New System.Drawing.Point(446, 99)
        Me.btnAddAcc.Name = "btnAddAcc"
        Me.btnAddAcc.Size = New System.Drawing.Size(141, 51)
        Me.btnAddAcc.TabIndex = 77
        Me.btnAddAcc.Text = "ADD ACCOUNT"
        Me.btnAddAcc.UseVisualStyleBackColor = False
        '
        'btnDeleteAcc
        '
        Me.btnDeleteAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnDeleteAcc.FlatAppearance.BorderSize = 0
        Me.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAcc.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAcc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeleteAcc.Location = New System.Drawing.Point(597, 41)
        Me.btnDeleteAcc.Name = "btnDeleteAcc"
        Me.btnDeleteAcc.Size = New System.Drawing.Size(141, 51)
        Me.btnDeleteAcc.TabIndex = 76
        Me.btnDeleteAcc.Text = "DELETE ACCOUNT"
        Me.btnDeleteAcc.UseVisualStyleBackColor = False
        '
        'btnSaveAcc
        '
        Me.btnSaveAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSaveAcc.FlatAppearance.BorderSize = 0
        Me.btnSaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAcc.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAcc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSaveAcc.Location = New System.Drawing.Point(446, 41)
        Me.btnSaveAcc.Name = "btnSaveAcc"
        Me.btnSaveAcc.Size = New System.Drawing.Size(141, 51)
        Me.btnSaveAcc.TabIndex = 75
        Me.btnSaveAcc.Text = "SAVE ACCOUNT"
        Me.btnSaveAcc.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearch.Location = New System.Drawing.Point(420, 170)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(68, 21)
        Me.lblSearch.TabIndex = 74
        Me.lblSearch.Text = "Search:"
        '
        'studentAccountView
        '
        Me.studentAccountView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentAccountView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentAccountView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.studentAccountView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentAccountView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentAccountView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.studentAccountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentAccountView.DefaultCellStyle = DataGridViewCellStyle2
        Me.studentAccountView.EnableHeadersVisualStyles = False
        Me.studentAccountView.Location = New System.Drawing.Point(40, 238)
        Me.studentAccountView.Name = "studentAccountView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentAccountView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.studentAccountView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.studentAccountView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.studentAccountView.Size = New System.Drawing.Size(698, 387)
        Me.studentAccountView.TabIndex = 73
        '
        'txtSearchAccounts
        '
        Me.txtSearchAccounts.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAccounts.Location = New System.Drawing.Point(494, 170)
        Me.txtSearchAccounts.Name = "txtSearchAccounts"
        Me.txtSearchAccounts.Size = New System.Drawing.Size(244, 23)
        Me.txtSearchAccounts.TabIndex = 72
        '
        'studentDataBox
        '
        Me.studentDataBox.Controls.Add(Me.panelStudNo)
        Me.studentDataBox.Controls.Add(Me.panelPassword)
        Me.studentDataBox.Controls.Add(Me.lblStudNo)
        Me.studentDataBox.Controls.Add(Me.lblStudNm)
        Me.studentDataBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentDataBox.ForeColor = System.Drawing.SystemColors.Control
        Me.studentDataBox.Location = New System.Drawing.Point(44, 33)
        Me.studentDataBox.Name = "studentDataBox"
        Me.studentDataBox.Size = New System.Drawing.Size(354, 117)
        Me.studentDataBox.TabIndex = 71
        Me.studentDataBox.TabStop = False
        Me.studentDataBox.Text = "STUDENT DATA"
        '
        'panelStudNo
        '
        Me.panelStudNo.Controls.Add(Me.cmbStudNo)
        Me.panelStudNo.Location = New System.Drawing.Point(150, 22)
        Me.panelStudNo.Name = "panelStudNo"
        Me.panelStudNo.Size = New System.Drawing.Size(185, 38)
        Me.panelStudNo.TabIndex = 56
        '
        'cmbStudNo
        '
        Me.cmbStudNo.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudNo.FormattingEnabled = True
        Me.cmbStudNo.Location = New System.Drawing.Point(6, 4)
        Me.cmbStudNo.Name = "cmbStudNo"
        Me.cmbStudNo.Size = New System.Drawing.Size(173, 28)
        Me.cmbStudNo.TabIndex = 44
        '
        'panelPassword
        '
        Me.panelPassword.Controls.Add(Me.txtPassword)
        Me.panelPassword.Location = New System.Drawing.Point(150, 67)
        Me.panelPassword.Name = "panelPassword"
        Me.panelPassword.Size = New System.Drawing.Size(185, 35)
        Me.panelPassword.TabIndex = 55
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(6, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(173, 26)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblStudNo
        '
        Me.lblStudNo.AutoSize = True
        Me.lblStudNo.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudNo.Location = New System.Drawing.Point(15, 34)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(122, 19)
        Me.lblStudNo.TabIndex = 53
        Me.lblStudNo.Text = "STUDENT NO.#"
        '
        'lblStudNm
        '
        Me.lblStudNm.AutoSize = True
        Me.lblStudNm.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNm.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudNm.Location = New System.Drawing.Point(16, 76)
        Me.lblStudNm.Name = "lblStudNm"
        Me.lblStudNm.Size = New System.Drawing.Size(95, 19)
        Me.lblStudNm.TabIndex = 51
        Me.lblStudNm.Text = "PASSWORD"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 659)
        Me.Controls.Add(Me.cBoxPassword)
        Me.Controls.Add(Me.btnUpdateAcc)
        Me.Controls.Add(Me.btnAddAcc)
        Me.Controls.Add(Me.btnDeleteAcc)
        Me.Controls.Add(Me.btnSaveAcc)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.studentAccountView)
        Me.Controls.Add(Me.txtSearchAccounts)
        Me.Controls.Add(Me.studentDataBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.Text = "p"
        CType(Me.studentAccountView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentDataBox.ResumeLayout(False)
        Me.studentDataBox.PerformLayout()
        Me.panelStudNo.ResumeLayout(False)
        Me.panelPassword.ResumeLayout(False)
        Me.panelPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cBoxPassword As CheckBox
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnAddAcc As Button
    Friend WithEvents btnDeleteAcc As Button
    Friend WithEvents btnSaveAcc As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents studentAccountView As DataGridView
    Friend WithEvents txtSearchAccounts As TextBox
    Friend WithEvents studentDataBox As GroupBox
    Friend WithEvents panelStudNo As Panel
    Friend WithEvents cmbStudNo As ComboBox
    Friend WithEvents panelPassword As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblStudNo As Label
    Friend WithEvents lblStudNm As Label
End Class
