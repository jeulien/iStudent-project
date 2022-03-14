<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectsList))
        Me.subjectInfoBox = New System.Windows.Forms.GroupBox()
        Me.lblSubjectUnits = New System.Windows.Forms.Label()
        Me.txtSubTitle = New System.Windows.Forms.TextBox()
        Me.txtSubCode = New System.Windows.Forms.TextBox()
        Me.lblSubjectTitle = New System.Windows.Forms.Label()
        Me.panelSubTitle = New System.Windows.Forms.Panel()
        Me.lblSubjectCode = New System.Windows.Forms.Label()
        Me.panelSubCode = New System.Windows.Forms.Panel()
        Me.txtSubUnits = New System.Windows.Forms.TextBox()
        Me.panelUnits = New System.Windows.Forms.Panel()
        Me.txtSubDesc = New System.Windows.Forms.TextBox()
        Me.lblSubjectDesc = New System.Windows.Forms.Label()
        Me.panelDesc = New System.Windows.Forms.Panel()
        Me.btnSaveSubject = New System.Windows.Forms.Button()
        Me.btnUpdateSubject = New System.Windows.Forms.Button()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.btnDeleteSubject = New System.Windows.Forms.Button()
        Me.btnAccessSubject = New System.Windows.Forms.Button()
        Me.lblSearchSubjects = New System.Windows.Forms.Label()
        Me.txtSearchSubjects = New System.Windows.Forms.TextBox()
        Me.subjectListView = New System.Windows.Forms.DataGridView()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.subjectListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subjectInfoBox
        '
        Me.subjectInfoBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectInfoBox.ForeColor = System.Drawing.SystemColors.Control
        Me.subjectInfoBox.Location = New System.Drawing.Point(55, 34)
        Me.subjectInfoBox.Name = "subjectInfoBox"
        Me.subjectInfoBox.Size = New System.Drawing.Size(683, 218)
        Me.subjectInfoBox.TabIndex = 20
        Me.subjectInfoBox.TabStop = False
        Me.subjectInfoBox.Text = "SUBJECT INFORMATION"
        '
        'lblSubjectUnits
        '
        Me.lblSubjectUnits.AutoSize = True
        Me.lblSubjectUnits.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectUnits.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubjectUnits.Location = New System.Drawing.Point(504, 64)
        Me.lblSubjectUnits.Name = "lblSubjectUnits"
        Me.lblSubjectUnits.Size = New System.Drawing.Size(54, 19)
        Me.lblSubjectUnits.TabIndex = 43
        Me.lblSubjectUnits.Text = "UNITS"
        '
        'txtSubTitle
        '
        Me.txtSubTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTitle.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTitle.Location = New System.Drawing.Point(196, 98)
        Me.txtSubTitle.Name = "txtSubTitle"
        Me.txtSubTitle.Size = New System.Drawing.Size(528, 23)
        Me.txtSubTitle.TabIndex = 41
        '
        'txtSubCode
        '
        Me.txtSubCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubCode.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCode.Location = New System.Drawing.Point(197, 60)
        Me.txtSubCode.Name = "txtSubCode"
        Me.txtSubCode.Size = New System.Drawing.Size(287, 23)
        Me.txtSubCode.TabIndex = 38
        '
        'lblSubjectTitle
        '
        Me.lblSubjectTitle.AutoSize = True
        Me.lblSubjectTitle.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubjectTitle.Location = New System.Drawing.Point(58, 102)
        Me.lblSubjectTitle.Name = "lblSubjectTitle"
        Me.lblSubjectTitle.Size = New System.Drawing.Size(114, 19)
        Me.lblSubjectTitle.TabIndex = 40
        Me.lblSubjectTitle.Text = "SUBJECT TITLE"
        '
        'panelSubTitle
        '
        Me.panelSubTitle.Location = New System.Drawing.Point(192, 93)
        Me.panelSubTitle.Name = "panelSubTitle"
        Me.panelSubTitle.Size = New System.Drawing.Size(536, 32)
        Me.panelSubTitle.TabIndex = 42
        '
        'lblSubjectCode
        '
        Me.lblSubjectCode.AutoSize = True
        Me.lblSubjectCode.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectCode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubjectCode.Location = New System.Drawing.Point(58, 65)
        Me.lblSubjectCode.Name = "lblSubjectCode"
        Me.lblSubjectCode.Size = New System.Drawing.Size(129, 19)
        Me.lblSubjectCode.TabIndex = 37
        Me.lblSubjectCode.Text = "SUBJECT CODE #"
        '
        'panelSubCode
        '
        Me.panelSubCode.Location = New System.Drawing.Point(192, 55)
        Me.panelSubCode.Name = "panelSubCode"
        Me.panelSubCode.Size = New System.Drawing.Size(296, 32)
        Me.panelSubCode.TabIndex = 39
        '
        'txtSubUnits
        '
        Me.txtSubUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubUnits.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubUnits.Location = New System.Drawing.Point(571, 60)
        Me.txtSubUnits.Name = "txtSubUnits"
        Me.txtSubUnits.Size = New System.Drawing.Size(153, 23)
        Me.txtSubUnits.TabIndex = 44
        '
        'panelUnits
        '
        Me.panelUnits.Location = New System.Drawing.Point(567, 55)
        Me.panelUnits.Name = "panelUnits"
        Me.panelUnits.Size = New System.Drawing.Size(161, 32)
        Me.panelUnits.TabIndex = 45
        '
        'txtSubDesc
        '
        Me.txtSubDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubDesc.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubDesc.Location = New System.Drawing.Point(197, 144)
        Me.txtSubDesc.Multiline = True
        Me.txtSubDesc.Name = "txtSubDesc"
        Me.txtSubDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSubDesc.Size = New System.Drawing.Size(527, 92)
        Me.txtSubDesc.TabIndex = 47
        '
        'lblSubjectDesc
        '
        Me.lblSubjectDesc.AutoSize = True
        Me.lblSubjectDesc.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectDesc.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubjectDesc.Location = New System.Drawing.Point(58, 144)
        Me.lblSubjectDesc.Name = "lblSubjectDesc"
        Me.lblSubjectDesc.Size = New System.Drawing.Size(108, 19)
        Me.lblSubjectDesc.TabIndex = 46
        Me.lblSubjectDesc.Text = "DESCRIPTION"
        '
        'panelDesc
        '
        Me.panelDesc.Location = New System.Drawing.Point(192, 141)
        Me.panelDesc.Name = "panelDesc"
        Me.panelDesc.Size = New System.Drawing.Size(536, 100)
        Me.panelDesc.TabIndex = 48
        '
        'btnSaveSubject
        '
        Me.btnSaveSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSaveSubject.FlatAppearance.BorderSize = 0
        Me.btnSaveSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSubject.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSubject.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSaveSubject.Location = New System.Drawing.Point(55, 267)
        Me.btnSaveSubject.Name = "btnSaveSubject"
        Me.btnSaveSubject.Size = New System.Drawing.Size(132, 35)
        Me.btnSaveSubject.TabIndex = 49
        Me.btnSaveSubject.Text = "SAVE SUBJECT"
        Me.btnSaveSubject.UseVisualStyleBackColor = False
        '
        'btnUpdateSubject
        '
        Me.btnUpdateSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdateSubject.FlatAppearance.BorderSize = 0
        Me.btnUpdateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSubject.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSubject.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdateSubject.Location = New System.Drawing.Point(197, 267)
        Me.btnUpdateSubject.Name = "btnUpdateSubject"
        Me.btnUpdateSubject.Size = New System.Drawing.Size(141, 35)
        Me.btnUpdateSubject.TabIndex = 50
        Me.btnUpdateSubject.Text = "UPDATE SUBJECT"
        Me.btnUpdateSubject.UseVisualStyleBackColor = False
        '
        'btnAddSubject
        '
        Me.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddSubject.FlatAppearance.BorderSize = 0
        Me.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubject.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddSubject.Location = New System.Drawing.Point(586, 301)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(152, 35)
        Me.btnAddSubject.TabIndex = 51
        Me.btnAddSubject.Text = "ADD SUBJECT"
        Me.btnAddSubject.UseVisualStyleBackColor = False
        '
        'btnDeleteSubject
        '
        Me.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnDeleteSubject.FlatAppearance.BorderSize = 0
        Me.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSubject.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSubject.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeleteSubject.Location = New System.Drawing.Point(347, 267)
        Me.btnDeleteSubject.Name = "btnDeleteSubject"
        Me.btnDeleteSubject.Size = New System.Drawing.Size(140, 35)
        Me.btnDeleteSubject.TabIndex = 52
        Me.btnDeleteSubject.Text = "DELETE SUBJECT"
        Me.btnDeleteSubject.UseVisualStyleBackColor = False
        '
        'btnAccessSubject
        '
        Me.btnAccessSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAccessSubject.FlatAppearance.BorderSize = 0
        Me.btnAccessSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccessSubject.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccessSubject.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAccessSubject.Location = New System.Drawing.Point(586, 258)
        Me.btnAccessSubject.Name = "btnAccessSubject"
        Me.btnAccessSubject.Size = New System.Drawing.Size(152, 35)
        Me.btnAccessSubject.TabIndex = 54
        Me.btnAccessSubject.Text = "ACCESS SUBJECTS"
        Me.btnAccessSubject.UseVisualStyleBackColor = False
        '
        'lblSearchSubjects
        '
        Me.lblSearchSubjects.AutoSize = True
        Me.lblSearchSubjects.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchSubjects.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearchSubjects.Location = New System.Drawing.Point(54, 349)
        Me.lblSearchSubjects.Name = "lblSearchSubjects"
        Me.lblSearchSubjects.Size = New System.Drawing.Size(68, 21)
        Me.lblSearchSubjects.TabIndex = 56
        Me.lblSearchSubjects.Text = "Search:"
        '
        'txtSearchSubjects
        '
        Me.txtSearchSubjects.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSubjects.Location = New System.Drawing.Point(122, 348)
        Me.txtSearchSubjects.Name = "txtSearchSubjects"
        Me.txtSearchSubjects.Size = New System.Drawing.Size(366, 23)
        Me.txtSearchSubjects.TabIndex = 55
        '
        'subjectListView
        '
        Me.subjectListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.subjectListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.subjectListView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.subjectListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjectListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subjectListView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.subjectListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.subjectListView.DefaultCellStyle = DataGridViewCellStyle2
        Me.subjectListView.EnableHeadersVisualStyles = False
        Me.subjectListView.Location = New System.Drawing.Point(55, 383)
        Me.subjectListView.Name = "subjectListView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subjectListView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.subjectListView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.subjectListView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.subjectListView.Size = New System.Drawing.Size(686, 286)
        Me.subjectListView.TabIndex = 57
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExport.Location = New System.Drawing.Point(508, 342)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(230, 35)
        Me.btnExport.TabIndex = 58
        Me.btnExport.Text = "VIEW SUBJECT LIST RECORDS"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'SubjectsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 700)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblSubjectUnits)
        Me.Controls.Add(Me.subjectListView)
        Me.Controls.Add(Me.lblSearchSubjects)
        Me.Controls.Add(Me.txtSearchSubjects)
        Me.Controls.Add(Me.btnAccessSubject)
        Me.Controls.Add(Me.btnDeleteSubject)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Controls.Add(Me.btnUpdateSubject)
        Me.Controls.Add(Me.btnSaveSubject)
        Me.Controls.Add(Me.txtSubDesc)
        Me.Controls.Add(Me.lblSubjectDesc)
        Me.Controls.Add(Me.panelDesc)
        Me.Controls.Add(Me.txtSubUnits)
        Me.Controls.Add(Me.panelUnits)
        Me.Controls.Add(Me.txtSubTitle)
        Me.Controls.Add(Me.txtSubCode)
        Me.Controls.Add(Me.lblSubjectTitle)
        Me.Controls.Add(Me.panelSubTitle)
        Me.Controls.Add(Me.lblSubjectCode)
        Me.Controls.Add(Me.panelSubCode)
        Me.Controls.Add(Me.subjectInfoBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubjectsList"
        Me.Text = "SubjectsList"
        CType(Me.subjectListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subjectInfoBox As GroupBox
    Friend WithEvents txtSubTitle As TextBox
    Friend WithEvents txtSubCode As TextBox
    Friend WithEvents lblSubjectTitle As Label
    Friend WithEvents panelSubTitle As Panel
    Friend WithEvents lblSubjectCode As Label
    Friend WithEvents panelSubCode As Panel
    Friend WithEvents txtSubUnits As TextBox
    Friend WithEvents lblSubjectUnits As Label
    Friend WithEvents panelUnits As Panel
    Friend WithEvents txtSubDesc As TextBox
    Friend WithEvents lblSubjectDesc As Label
    Friend WithEvents panelDesc As Panel
    Friend WithEvents btnSaveSubject As Button
    Friend WithEvents btnUpdateSubject As Button
    Friend WithEvents btnAddSubject As Button
    Friend WithEvents btnDeleteSubject As Button
    Friend WithEvents btnAccessSubject As Button
    Friend WithEvents lblSearchSubjects As Label
    Friend WithEvents txtSearchSubjects As TextBox
    Friend WithEvents subjectListView As DataGridView
    Friend WithEvents btnExport As Button
End Class
