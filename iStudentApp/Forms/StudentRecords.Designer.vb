<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRecords))
        Me.subjectDataBox = New System.Windows.Forms.GroupBox()
        Me.lblSchoolYr = New System.Windows.Forms.Label()
        Me.lblSubCode = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.panelUnits = New System.Windows.Forms.Panel()
        Me.cmbUnits = New System.Windows.Forms.ComboBox()
        Me.panelSubCod = New System.Windows.Forms.Panel()
        Me.cmbSubCode = New System.Windows.Forms.ComboBox()
        Me.txtSchoolYr = New System.Windows.Forms.TextBox()
        Me.panelSchool = New System.Windows.Forms.Panel()
        Me.studentDataBox = New System.Windows.Forms.GroupBox()
        Me.lblStudNo = New System.Windows.Forms.Label()
        Me.lblStudNm = New System.Windows.Forms.Label()
        Me.panelSubTitle = New System.Windows.Forms.Panel()
        Me.cmbSubTitle = New System.Windows.Forms.ComboBox()
        Me.panelSem = New System.Windows.Forms.Panel()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.panelStudNo = New System.Windows.Forms.Panel()
        Me.cmbStudNo = New System.Windows.Forms.ComboBox()
        Me.panelStudNm = New System.Windows.Forms.Panel()
        Me.cmbStudNm = New System.Windows.Forms.ComboBox()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.btnAccessRecord = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.lblSearchRecord = New System.Windows.Forms.Label()
        Me.txtSearchRecord = New System.Windows.Forms.TextBox()
        Me.studentRecordView = New System.Windows.Forms.DataGridView()
        Me.btnClearSub = New System.Windows.Forms.Button()
        Me.btnClearStud = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.subjectDataBox.SuspendLayout()
        Me.panelUnits.SuspendLayout()
        Me.panelSubCod.SuspendLayout()
        Me.studentDataBox.SuspendLayout()
        Me.panelSubTitle.SuspendLayout()
        Me.panelSem.SuspendLayout()
        Me.panelStudNo.SuspendLayout()
        Me.panelStudNm.SuspendLayout()
        CType(Me.studentRecordView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subjectDataBox
        '
        Me.subjectDataBox.Controls.Add(Me.lblSchoolYr)
        Me.subjectDataBox.Controls.Add(Me.lblSubCode)
        Me.subjectDataBox.Controls.Add(Me.lblUnits)
        Me.subjectDataBox.Controls.Add(Me.lblSubTitle)
        Me.subjectDataBox.Controls.Add(Me.lblSemester)
        Me.subjectDataBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectDataBox.ForeColor = System.Drawing.SystemColors.Control
        Me.subjectDataBox.Location = New System.Drawing.Point(25, 10)
        Me.subjectDataBox.Name = "subjectDataBox"
        Me.subjectDataBox.Size = New System.Drawing.Size(373, 229)
        Me.subjectDataBox.TabIndex = 21
        Me.subjectDataBox.TabStop = False
        Me.subjectDataBox.Text = "SUBJECT DATA"
        '
        'lblSchoolYr
        '
        Me.lblSchoolYr.AutoSize = True
        Me.lblSchoolYr.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYr.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSchoolYr.Location = New System.Drawing.Point(11, 26)
        Me.lblSchoolYr.Name = "lblSchoolYr"
        Me.lblSchoolYr.Size = New System.Drawing.Size(112, 19)
        Me.lblSchoolYr.TabIndex = 43
        Me.lblSchoolYr.Text = "SCHOOL YEAR"
        '
        'lblSubCode
        '
        Me.lblSubCode.AutoSize = True
        Me.lblSubCode.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubCode.Location = New System.Drawing.Point(11, 110)
        Me.lblSubCode.Name = "lblSubCode"
        Me.lblSubCode.Size = New System.Drawing.Size(129, 19)
        Me.lblSubCode.TabIndex = 37
        Me.lblSubCode.Text = "SUBJECT CODE #"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUnits.Location = New System.Drawing.Point(11, 195)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(54, 19)
        Me.lblUnits.TabIndex = 40
        Me.lblUnits.Text = "UNITS"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubTitle.Location = New System.Drawing.Point(11, 154)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(114, 19)
        Me.lblSubTitle.TabIndex = 47
        Me.lblSubTitle.Text = "SUBJECT TITLE"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSemester.Location = New System.Drawing.Point(11, 66)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(86, 19)
        Me.lblSemester.TabIndex = 49
        Me.lblSemester.Text = "SEMESTER"
        '
        'panelUnits
        '
        Me.panelUnits.Controls.Add(Me.cmbUnits)
        Me.panelUnits.Location = New System.Drawing.Point(179, 196)
        Me.panelUnits.Name = "panelUnits"
        Me.panelUnits.Size = New System.Drawing.Size(207, 37)
        Me.panelUnits.TabIndex = 42
        '
        'cmbUnits
        '
        Me.cmbUnits.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnits.FormattingEnabled = True
        Me.cmbUnits.Location = New System.Drawing.Point(4, 5)
        Me.cmbUnits.Name = "cmbUnits"
        Me.cmbUnits.Size = New System.Drawing.Size(199, 28)
        Me.cmbUnits.TabIndex = 44
        '
        'panelSubCod
        '
        Me.panelSubCod.Controls.Add(Me.cmbSubCode)
        Me.panelSubCod.Location = New System.Drawing.Point(179, 110)
        Me.panelSubCod.Name = "panelSubCod"
        Me.panelSubCod.Size = New System.Drawing.Size(207, 37)
        Me.panelSubCod.TabIndex = 39
        '
        'cmbSubCode
        '
        Me.cmbSubCode.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubCode.FormattingEnabled = True
        Me.cmbSubCode.Location = New System.Drawing.Point(3, 4)
        Me.cmbSubCode.Name = "cmbSubCode"
        Me.cmbSubCode.Size = New System.Drawing.Size(199, 28)
        Me.cmbSubCode.TabIndex = 43
        '
        'txtSchoolYr
        '
        Me.txtSchoolYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSchoolYr.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolYr.Location = New System.Drawing.Point(183, 31)
        Me.txtSchoolYr.Name = "txtSchoolYr"
        Me.txtSchoolYr.Size = New System.Drawing.Size(199, 26)
        Me.txtSchoolYr.TabIndex = 44
        '
        'panelSchool
        '
        Me.panelSchool.Location = New System.Drawing.Point(179, 28)
        Me.panelSchool.Name = "panelSchool"
        Me.panelSchool.Size = New System.Drawing.Size(207, 32)
        Me.panelSchool.TabIndex = 45
        '
        'studentDataBox
        '
        Me.studentDataBox.Controls.Add(Me.lblStudNo)
        Me.studentDataBox.Controls.Add(Me.lblStudNm)
        Me.studentDataBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentDataBox.ForeColor = System.Drawing.SystemColors.Control
        Me.studentDataBox.Location = New System.Drawing.Point(404, 10)
        Me.studentDataBox.Name = "studentDataBox"
        Me.studentDataBox.Size = New System.Drawing.Size(375, 115)
        Me.studentDataBox.TabIndex = 46
        Me.studentDataBox.TabStop = False
        Me.studentDataBox.Text = "STUDENT DATA"
        '
        'lblStudNo
        '
        Me.lblStudNo.AutoSize = True
        Me.lblStudNo.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudNo.Location = New System.Drawing.Point(15, 25)
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
        Me.lblStudNm.Location = New System.Drawing.Point(14, 63)
        Me.lblStudNm.Name = "lblStudNm"
        Me.lblStudNm.Size = New System.Drawing.Size(127, 19)
        Me.lblStudNm.TabIndex = 51
        Me.lblStudNm.Text = "STUDENT NAME"
        '
        'panelSubTitle
        '
        Me.panelSubTitle.Controls.Add(Me.cmbSubTitle)
        Me.panelSubTitle.Location = New System.Drawing.Point(179, 152)
        Me.panelSubTitle.Name = "panelSubTitle"
        Me.panelSubTitle.Size = New System.Drawing.Size(207, 39)
        Me.panelSubTitle.TabIndex = 48
        '
        'cmbSubTitle
        '
        Me.cmbSubTitle.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubTitle.FormattingEnabled = True
        Me.cmbSubTitle.Location = New System.Drawing.Point(4, 5)
        Me.cmbSubTitle.Name = "cmbSubTitle"
        Me.cmbSubTitle.Size = New System.Drawing.Size(199, 28)
        Me.cmbSubTitle.TabIndex = 44
        '
        'panelSem
        '
        Me.panelSem.Controls.Add(Me.cmbSemester)
        Me.panelSem.Location = New System.Drawing.Point(179, 68)
        Me.panelSem.Name = "panelSem"
        Me.panelSem.Size = New System.Drawing.Size(207, 35)
        Me.panelSem.TabIndex = 50
        '
        'cmbSemester
        '
        Me.cmbSemester.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"FIRST", "SECOND"})
        Me.cmbSemester.Location = New System.Drawing.Point(4, 3)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(199, 28)
        Me.cmbSemester.TabIndex = 44
        '
        'panelStudNo
        '
        Me.panelStudNo.Controls.Add(Me.cmbStudNo)
        Me.panelStudNo.Location = New System.Drawing.Point(581, 26)
        Me.panelStudNo.Name = "panelStudNo"
        Me.panelStudNo.Size = New System.Drawing.Size(180, 38)
        Me.panelStudNo.TabIndex = 54
        '
        'cmbStudNo
        '
        Me.cmbStudNo.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudNo.FormattingEnabled = True
        Me.cmbStudNo.Location = New System.Drawing.Point(4, 4)
        Me.cmbStudNo.Name = "cmbStudNo"
        Me.cmbStudNo.Size = New System.Drawing.Size(173, 28)
        Me.cmbStudNo.TabIndex = 44
        '
        'panelStudNm
        '
        Me.panelStudNm.Controls.Add(Me.cmbStudNm)
        Me.panelStudNm.Location = New System.Drawing.Point(581, 71)
        Me.panelStudNm.Name = "panelStudNm"
        Me.panelStudNm.Size = New System.Drawing.Size(180, 35)
        Me.panelStudNm.TabIndex = 52
        '
        'cmbStudNm
        '
        Me.cmbStudNm.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudNm.FormattingEnabled = True
        Me.cmbStudNm.Location = New System.Drawing.Point(4, 4)
        Me.cmbStudNm.Name = "cmbStudNm"
        Me.cmbStudNm.Size = New System.Drawing.Size(173, 28)
        Me.cmbStudNm.TabIndex = 44
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnDeleteRecord.FlatAppearance.BorderSize = 0
        Me.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRecord.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeleteRecord.Location = New System.Drawing.Point(655, 136)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(124, 35)
        Me.btnDeleteRecord.TabIndex = 58
        Me.btnDeleteRecord.Text = "DELETE RECORD"
        Me.btnDeleteRecord.UseVisualStyleBackColor = False
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdateRecord.FlatAppearance.BorderSize = 0
        Me.btnUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateRecord.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdateRecord.Location = New System.Drawing.Point(520, 136)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(129, 35)
        Me.btnUpdateRecord.TabIndex = 57
        Me.btnUpdateRecord.Text = "UPDATE RECORD"
        Me.btnUpdateRecord.UseVisualStyleBackColor = False
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSaveRecord.FlatAppearance.BorderSize = 0
        Me.btnSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRecord.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSaveRecord.Location = New System.Drawing.Point(404, 136)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(110, 35)
        Me.btnSaveRecord.TabIndex = 56
        Me.btnSaveRecord.Text = "SAVE RECORD"
        Me.btnSaveRecord.UseVisualStyleBackColor = False
        '
        'btnAccessRecord
        '
        Me.btnAccessRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAccessRecord.FlatAppearance.BorderSize = 0
        Me.btnAccessRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccessRecord.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccessRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAccessRecord.Location = New System.Drawing.Point(453, 177)
        Me.btnAccessRecord.Name = "btnAccessRecord"
        Me.btnAccessRecord.Size = New System.Drawing.Size(129, 35)
        Me.btnAccessRecord.TabIndex = 60
        Me.btnAccessRecord.Text = "ACCESS RECORD"
        Me.btnAccessRecord.UseVisualStyleBackColor = False
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddRecord.FlatAppearance.BorderSize = 0
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddRecord.Location = New System.Drawing.Point(589, 177)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(129, 35)
        Me.btnAddRecord.TabIndex = 59
        Me.btnAddRecord.Text = "ADD RECORD"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'lblSearchRecord
        '
        Me.lblSearchRecord.AutoSize = True
        Me.lblSearchRecord.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearchRecord.Location = New System.Drawing.Point(353, 262)
        Me.lblSearchRecord.Name = "lblSearchRecord"
        Me.lblSearchRecord.Size = New System.Drawing.Size(68, 21)
        Me.lblSearchRecord.TabIndex = 62
        Me.lblSearchRecord.Text = "Search:"
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchRecord.Location = New System.Drawing.Point(418, 261)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(353, 23)
        Me.txtSearchRecord.TabIndex = 61
        '
        'studentRecordView
        '
        Me.studentRecordView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.studentRecordView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentRecordView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.studentRecordView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentRecordView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentRecordView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.studentRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentRecordView.DefaultCellStyle = DataGridViewCellStyle2
        Me.studentRecordView.EnableHeadersVisualStyles = False
        Me.studentRecordView.Location = New System.Drawing.Point(25, 291)
        Me.studentRecordView.Name = "studentRecordView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentRecordView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.studentRecordView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.studentRecordView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.studentRecordView.Size = New System.Drawing.Size(746, 382)
        Me.studentRecordView.TabIndex = 63
        '
        'btnClearSub
        '
        Me.btnClearSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnClearSub.FlatAppearance.BorderSize = 0
        Me.btnClearSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSub.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSub.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClearSub.Location = New System.Drawing.Point(25, 246)
        Me.btnClearSub.Name = "btnClearSub"
        Me.btnClearSub.Size = New System.Drawing.Size(152, 35)
        Me.btnClearSub.TabIndex = 64
        Me.btnClearSub.Text = "CLEAR SUBJECT DATA"
        Me.btnClearSub.UseVisualStyleBackColor = False
        '
        'btnClearStud
        '
        Me.btnClearStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnClearStud.FlatAppearance.BorderSize = 0
        Me.btnClearStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearStud.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearStud.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClearStud.Location = New System.Drawing.Point(183, 246)
        Me.btnClearStud.Name = "btnClearStud"
        Me.btnClearStud.Size = New System.Drawing.Size(162, 35)
        Me.btnClearStud.TabIndex = 65
        Me.btnClearStud.Text = "CLEAR STUDENT DATA"
        Me.btnClearStud.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExport.Location = New System.Drawing.Point(453, 218)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(265, 35)
        Me.btnExport.TabIndex = 66
        Me.btnExport.Text = "VIEW STUDENT RECORDS LIST"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'StudentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 700)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClearStud)
        Me.Controls.Add(Me.btnClearSub)
        Me.Controls.Add(Me.studentRecordView)
        Me.Controls.Add(Me.lblSearchRecord)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.btnAccessRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnUpdateRecord)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.panelStudNo)
        Me.Controls.Add(Me.panelStudNm)
        Me.Controls.Add(Me.panelSem)
        Me.Controls.Add(Me.panelSubTitle)
        Me.Controls.Add(Me.studentDataBox)
        Me.Controls.Add(Me.txtSchoolYr)
        Me.Controls.Add(Me.panelSchool)
        Me.Controls.Add(Me.panelUnits)
        Me.Controls.Add(Me.panelSubCod)
        Me.Controls.Add(Me.subjectDataBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentRecords"
        Me.Text = "StudentRecords"
        Me.subjectDataBox.ResumeLayout(False)
        Me.subjectDataBox.PerformLayout()
        Me.panelUnits.ResumeLayout(False)
        Me.panelSubCod.ResumeLayout(False)
        Me.studentDataBox.ResumeLayout(False)
        Me.studentDataBox.PerformLayout()
        Me.panelSubTitle.ResumeLayout(False)
        Me.panelSem.ResumeLayout(False)
        Me.panelStudNo.ResumeLayout(False)
        Me.panelStudNm.ResumeLayout(False)
        CType(Me.studentRecordView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subjectDataBox As GroupBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents panelUnits As Panel
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents lblSubCode As Label
    Friend WithEvents panelSubCod As Panel
    Friend WithEvents cmbSubCode As ComboBox
    Friend WithEvents txtSchoolYr As TextBox
    Friend WithEvents lblSchoolYr As Label
    Friend WithEvents panelSchool As Panel
    Friend WithEvents studentDataBox As GroupBox
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents panelSubTitle As Panel
    Friend WithEvents cmbSubTitle As ComboBox
    Friend WithEvents lblSemester As Label
    Friend WithEvents panelSem As Panel
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents lblStudNo As Label
    Friend WithEvents panelStudNo As Panel
    Friend WithEvents cmbStudNo As ComboBox
    Friend WithEvents lblStudNm As Label
    Friend WithEvents panelStudNm As Panel
    Friend WithEvents cmbStudNm As ComboBox
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents btnUpdateRecord As Button
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents btnAccessRecord As Button
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents lblSearchRecord As Label
    Friend WithEvents txtSearchRecord As TextBox
    Friend WithEvents studentRecordView As DataGridView
    Friend WithEvents btnClearSub As Button
    Friend WithEvents btnClearStud As Button
    Friend WithEvents btnExport As Button
End Class
