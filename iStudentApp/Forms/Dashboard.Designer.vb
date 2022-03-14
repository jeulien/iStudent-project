<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPostDescription = New System.Windows.Forms.TextBox()
        Me.btnDeletePost = New System.Windows.Forms.Button()
        Me.btnUpdatePost = New System.Windows.Forms.Button()
        Me.btnSavePost = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSearchPosts = New System.Windows.Forms.Label()
        Me.txtSearchPosts = New System.Windows.Forms.TextBox()
        Me.txtPostTitle = New System.Windows.Forms.TextBox()
        Me.lblTitlePost = New System.Windows.Forms.Label()
        Me.lblTitleInfo = New System.Windows.Forms.Label()
        Me.dashboardView = New System.Windows.Forms.DataGridView()
        Me.postID = New System.Windows.Forms.Label()
        CType(Me.dashboardView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPostDescription
        '
        Me.txtPostDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPostDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPostDescription.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostDescription.ForeColor = System.Drawing.SystemColors.Control
        Me.txtPostDescription.Location = New System.Drawing.Point(99, 95)
        Me.txtPostDescription.Multiline = True
        Me.txtPostDescription.Name = "txtPostDescription"
        Me.txtPostDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPostDescription.Size = New System.Drawing.Size(642, 178)
        Me.txtPostDescription.TabIndex = 1
        '
        'btnDeletePost
        '
        Me.btnDeletePost.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnDeletePost.FlatAppearance.BorderSize = 0
        Me.btnDeletePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePost.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePost.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeletePost.Location = New System.Drawing.Point(639, 279)
        Me.btnDeletePost.Name = "btnDeletePost"
        Me.btnDeletePost.Size = New System.Drawing.Size(99, 35)
        Me.btnDeletePost.TabIndex = 55
        Me.btnDeletePost.Text = "DELETE"
        Me.btnDeletePost.UseVisualStyleBackColor = False
        '
        'btnUpdatePost
        '
        Me.btnUpdatePost.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdatePost.FlatAppearance.BorderSize = 0
        Me.btnUpdatePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePost.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePost.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdatePost.Location = New System.Drawing.Point(534, 279)
        Me.btnUpdatePost.Name = "btnUpdatePost"
        Me.btnUpdatePost.Size = New System.Drawing.Size(99, 35)
        Me.btnUpdatePost.TabIndex = 54
        Me.btnUpdatePost.Text = "UPDATE"
        Me.btnUpdatePost.UseVisualStyleBackColor = False
        '
        'btnSavePost
        '
        Me.btnSavePost.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSavePost.FlatAppearance.BorderSize = 0
        Me.btnSavePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePost.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePost.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSavePost.Location = New System.Drawing.Point(429, 279)
        Me.btnSavePost.Name = "btnSavePost"
        Me.btnSavePost.Size = New System.Drawing.Size(99, 35)
        Me.btnSavePost.TabIndex = 53
        Me.btnSavePost.Text = "POST"
        Me.btnSavePost.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(314, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "      Announcements     "
        '
        'lblSearchPosts
        '
        Me.lblSearchPosts.AutoSize = True
        Me.lblSearchPosts.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchPosts.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearchPosts.Location = New System.Drawing.Point(49, 330)
        Me.lblSearchPosts.Name = "lblSearchPosts"
        Me.lblSearchPosts.Size = New System.Drawing.Size(61, 19)
        Me.lblSearchPosts.TabIndex = 59
        Me.lblSearchPosts.Text = "Search:"
        '
        'txtSearchPosts
        '
        Me.txtSearchPosts.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPosts.Location = New System.Drawing.Point(117, 329)
        Me.txtSearchPosts.Name = "txtSearchPosts"
        Me.txtSearchPosts.Size = New System.Drawing.Size(314, 22)
        Me.txtSearchPosts.TabIndex = 58
        '
        'txtPostTitle
        '
        Me.txtPostTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPostTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPostTitle.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.txtPostTitle.Location = New System.Drawing.Point(99, 57)
        Me.txtPostTitle.Multiline = True
        Me.txtPostTitle.Name = "txtPostTitle"
        Me.txtPostTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPostTitle.Size = New System.Drawing.Size(642, 31)
        Me.txtPostTitle.TabIndex = 60
        '
        'lblTitlePost
        '
        Me.lblTitlePost.AutoSize = True
        Me.lblTitlePost.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePost.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitlePost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitlePost.Location = New System.Drawing.Point(51, 67)
        Me.lblTitlePost.Name = "lblTitlePost"
        Me.lblTitlePost.Size = New System.Drawing.Size(42, 19)
        Me.lblTitlePost.TabIndex = 61
        Me.lblTitlePost.Text = "Title:"
        '
        'lblTitleInfo
        '
        Me.lblTitleInfo.AutoSize = True
        Me.lblTitleInfo.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleInfo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitleInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitleInfo.Location = New System.Drawing.Point(51, 96)
        Me.lblTitleInfo.Name = "lblTitleInfo"
        Me.lblTitleInfo.Size = New System.Drawing.Size(41, 19)
        Me.lblTitleInfo.TabIndex = 62
        Me.lblTitleInfo.Text = "Info:"
        '
        'dashboardView
        '
        Me.dashboardView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dashboardView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dashboardView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dashboardView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dashboardView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dashboardView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dashboardView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dashboardView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dashboardView.EnableHeadersVisualStyles = False
        Me.dashboardView.Location = New System.Drawing.Point(53, 357)
        Me.dashboardView.Name = "dashboardView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dashboardView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dashboardView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dashboardView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dashboardView.Size = New System.Drawing.Size(691, 310)
        Me.dashboardView.TabIndex = 63
        '
        'postID
        '
        Me.postID.AutoSize = True
        Me.postID.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postID.ForeColor = System.Drawing.SystemColors.Control
        Me.postID.Location = New System.Drawing.Point(68, 129)
        Me.postID.Name = "postID"
        Me.postID.Size = New System.Drawing.Size(0, 19)
        Me.postID.TabIndex = 64
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 700)
        Me.Controls.Add(Me.postID)
        Me.Controls.Add(Me.dashboardView)
        Me.Controls.Add(Me.lblTitleInfo)
        Me.Controls.Add(Me.lblTitlePost)
        Me.Controls.Add(Me.txtPostTitle)
        Me.Controls.Add(Me.lblSearchPosts)
        Me.Controls.Add(Me.txtSearchPosts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPostDescription)
        Me.Controls.Add(Me.btnDeletePost)
        Me.Controls.Add(Me.btnUpdatePost)
        Me.Controls.Add(Me.btnSavePost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.dashboardView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPostDescription As TextBox
    Friend WithEvents btnDeletePost As Button
    Friend WithEvents btnUpdatePost As Button
    Friend WithEvents btnSavePost As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSearchPosts As Label
    Friend WithEvents txtSearchPosts As TextBox
    Friend WithEvents txtPostTitle As TextBox
    Friend WithEvents lblTitlePost As Label
    Friend WithEvents lblTitleInfo As Label
    Friend WithEvents dashboardView As DataGridView
    Friend WithEvents postID As Label
End Class
