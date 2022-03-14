<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableFormGWA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableFormGWA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.studentGWAView = New System.Windows.Forms.DataGridView()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.expBtn = New System.Windows.Forms.Button()
        Me.browseBtn = New System.Windows.Forms.Button()
        Me.locTxt = New System.Windows.Forms.TextBox()
        Me.fileTxt = New System.Windows.Forms.TextBox()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.studentGWAView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.studentGWAView)
        Me.GroupBox1.Controls.Add(Me.delBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.expBtn)
        Me.GroupBox1.Controls.Add(Me.browseBtn)
        Me.GroupBox1.Controls.Add(Me.locTxt)
        Me.GroupBox1.Controls.Add(Me.fileTxt)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(950, 550)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GWA Student Results"
        '
        'studentGWAView
        '
        Me.studentGWAView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentGWAView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentGWAView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.studentGWAView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentGWAView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentGWAView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.studentGWAView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentGWAView.DefaultCellStyle = DataGridViewCellStyle2
        Me.studentGWAView.EnableHeadersVisualStyles = False
        Me.studentGWAView.Location = New System.Drawing.Point(6, 46)
        Me.studentGWAView.Name = "studentGWAView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentGWAView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.studentGWAView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.studentGWAView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.studentGWAView.Size = New System.Drawing.Size(938, 424)
        Me.studentGWAView.TabIndex = 92
        '
        'delBtn
        '
        Me.delBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delBtn.Location = New System.Drawing.Point(219, 505)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(128, 26)
        Me.delBtn.TabIndex = 3
        Me.delBtn.Text = "Delete GWA Record"
        Me.delBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Title of File:"
        '
        'expBtn
        '
        Me.expBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.expBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expBtn.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.expBtn.Location = New System.Drawing.Point(491, 505)
        Me.expBtn.Name = "expBtn"
        Me.expBtn.Size = New System.Drawing.Size(421, 26)
        Me.expBtn.TabIndex = 4
        Me.expBtn.Text = "Export to PDF"
        Me.expBtn.UseVisualStyleBackColor = False
        '
        'browseBtn
        '
        Me.browseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browseBtn.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.browseBtn.Location = New System.Drawing.Point(354, 505)
        Me.browseBtn.Name = "browseBtn"
        Me.browseBtn.Size = New System.Drawing.Size(115, 26)
        Me.browseBtn.TabIndex = 3
        Me.browseBtn.Text = "Browse"
        Me.browseBtn.UseVisualStyleBackColor = False
        '
        'locTxt
        '
        Me.locTxt.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locTxt.Location = New System.Drawing.Point(346, 476)
        Me.locTxt.Name = "locTxt"
        Me.locTxt.Size = New System.Drawing.Size(568, 23)
        Me.locTxt.TabIndex = 2
        '
        'fileTxt
        '
        Me.fileTxt.Location = New System.Drawing.Point(357, 20)
        Me.fileTxt.Name = "fileTxt"
        Me.fileTxt.Size = New System.Drawing.Size(557, 20)
        Me.fileTxt.TabIndex = 0
        '
        'searchBox
        '
        Me.searchBox.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(152, 575)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(362, 22)
        Me.searchBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(31, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search Record:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(769, 568)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(167, 29)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back to GWA Calculator"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TableFormGWA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 609)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TableFormGWA"
        Me.Text = "View / Export - Student GWA Records"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.studentGWAView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents delBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents expBtn As Button
    Friend WithEvents browseBtn As Button
    Friend WithEvents locTxt As TextBox
    Friend WithEvents fileTxt As TextBox
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents studentGWAView As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
