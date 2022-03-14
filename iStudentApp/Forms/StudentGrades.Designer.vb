<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentGrades))
        Me.lblStudNo = New System.Windows.Forms.Label()
        Me.panelStudNo = New System.Windows.Forms.Panel()
        Me.cmbStudNo = New System.Windows.Forms.ComboBox()
        Me.lblStudNm = New System.Windows.Forms.Label()
        Me.panelStudNm = New System.Windows.Forms.Panel()
        Me.cmbStudNm = New System.Windows.Forms.ComboBox()
        Me.studentDataBox = New System.Windows.Forms.GroupBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.panelSem = New System.Windows.Forms.Panel()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.panelSubTitle = New System.Windows.Forms.Panel()
        Me.cmbSubTitle = New System.Windows.Forms.ComboBox()
        Me.lblSchoolYr = New System.Windows.Forms.Label()
        Me.panelSchool = New System.Windows.Forms.Panel()
        Me.cmbSchoolYr = New System.Windows.Forms.ComboBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.panelUnits = New System.Windows.Forms.Panel()
        Me.cmbUnits = New System.Windows.Forms.ComboBox()
        Me.lblSubCode = New System.Windows.Forms.Label()
        Me.panelSubCod = New System.Windows.Forms.Panel()
        Me.cmbSubCode = New System.Windows.Forms.ComboBox()
        Me.subjectDataBox = New System.Windows.Forms.GroupBox()
        Me.btnDeleteGrade = New System.Windows.Forms.Button()
        Me.btnUpdateGrade = New System.Windows.Forms.Button()
        Me.btnSaveGrade = New System.Windows.Forms.Button()
        Me.btnAccessGrade = New System.Windows.Forms.Button()
        Me.btnClearGrade = New System.Windows.Forms.Button()
        Me.lblPrelim = New System.Windows.Forms.Label()
        Me.panelPrelims = New System.Windows.Forms.Panel()
        Me.cmbPrelims = New System.Windows.Forms.ComboBox()
        Me.panelMidterms = New System.Windows.Forms.Panel()
        Me.cmbMidterms = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblMidterm = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.panelFinals = New System.Windows.Forms.Panel()
        Me.cmbFinals = New System.Windows.Forms.ComboBox()
        Me.panelAverage = New System.Windows.Forms.Panel()
        Me.cmbAve = New System.Windows.Forms.ComboBox()
        Me.panelGrade = New System.Windows.Forms.Panel()
        Me.cmbGrade = New System.Windows.Forms.ComboBox()
        Me.lblSearchGrade = New System.Windows.Forms.Label()
        Me.txtSearchGrade = New System.Windows.Forms.TextBox()
        Me.studentGradeView = New System.Windows.Forms.DataGridView()
        Me.btnAddGrade = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.panelStudNo.SuspendLayout()
        Me.panelStudNm.SuspendLayout()
        Me.panelSem.SuspendLayout()
        Me.panelSubTitle.SuspendLayout()
        Me.panelSchool.SuspendLayout()
        Me.panelUnits.SuspendLayout()
        Me.panelSubCod.SuspendLayout()
        Me.panelPrelims.SuspendLayout()
        Me.panelMidterms.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelFinals.SuspendLayout()
        Me.panelAverage.SuspendLayout()
        Me.panelGrade.SuspendLayout()
        CType(Me.studentGradeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStudNo
        '
        Me.lblStudNo.AutoSize = True
        Me.lblStudNo.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudNo.Location = New System.Drawing.Point(26, 42)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(122, 19)
        Me.lblStudNo.TabIndex = 58
        Me.lblStudNo.Text = "STUDENT NO.#"
        '
        'panelStudNo
        '
        Me.panelStudNo.Controls.Add(Me.cmbStudNo)
        Me.panelStudNo.Location = New System.Drawing.Point(165, 33)
        Me.panelStudNo.Name = "panelStudNo"
        Me.panelStudNo.Size = New System.Drawing.Size(227, 32)
        Me.panelStudNo.TabIndex = 59
        '
        'cmbStudNo
        '
        Me.cmbStudNo.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudNo.FormattingEnabled = True
        Me.cmbStudNo.Location = New System.Drawing.Point(4, 4)
        Me.cmbStudNo.Name = "cmbStudNo"
        Me.cmbStudNo.Size = New System.Drawing.Size(220, 25)
        Me.cmbStudNo.TabIndex = 44
        '
        'lblStudNm
        '
        Me.lblStudNm.AutoSize = True
        Me.lblStudNm.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNm.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudNm.Location = New System.Drawing.Point(26, 81)
        Me.lblStudNm.Name = "lblStudNm"
        Me.lblStudNm.Size = New System.Drawing.Size(127, 19)
        Me.lblStudNm.TabIndex = 56
        Me.lblStudNm.Text = "STUDENT NAME"
        '
        'panelStudNm
        '
        Me.panelStudNm.Controls.Add(Me.cmbStudNm)
        Me.panelStudNm.Location = New System.Drawing.Point(165, 72)
        Me.panelStudNm.Name = "panelStudNm"
        Me.panelStudNm.Size = New System.Drawing.Size(224, 32)
        Me.panelStudNm.TabIndex = 57
        '
        'cmbStudNm
        '
        Me.cmbStudNm.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudNm.FormattingEnabled = True
        Me.cmbStudNm.Location = New System.Drawing.Point(4, 4)
        Me.cmbStudNm.Name = "cmbStudNm"
        Me.cmbStudNm.Size = New System.Drawing.Size(217, 25)
        Me.cmbStudNm.TabIndex = 44
        '
        'studentDataBox
        '
        Me.studentDataBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentDataBox.ForeColor = System.Drawing.SystemColors.Control
        Me.studentDataBox.Location = New System.Drawing.Point(18, 12)
        Me.studentDataBox.Name = "studentDataBox"
        Me.studentDataBox.Size = New System.Drawing.Size(385, 102)
        Me.studentDataBox.TabIndex = 55
        Me.studentDataBox.TabStop = False
        Me.studentDataBox.Text = "STUDENT "
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSemester.Location = New System.Drawing.Point(26, 185)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(86, 19)
        Me.lblSemester.TabIndex = 70
        Me.lblSemester.Text = "SEMESTER"
        '
        'panelSem
        '
        Me.panelSem.Controls.Add(Me.cmbSemester)
        Me.panelSem.Location = New System.Drawing.Point(165, 176)
        Me.panelSem.Name = "panelSem"
        Me.panelSem.Size = New System.Drawing.Size(227, 32)
        Me.panelSem.TabIndex = 71
        '
        'cmbSemester
        '
        Me.cmbSemester.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Location = New System.Drawing.Point(4, 4)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(220, 25)
        Me.cmbSemester.TabIndex = 44
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubTitle.Location = New System.Drawing.Point(26, 262)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(114, 19)
        Me.lblSubTitle.TabIndex = 68
        Me.lblSubTitle.Text = "SUBJECT TITLE"
        '
        'panelSubTitle
        '
        Me.panelSubTitle.Controls.Add(Me.cmbSubTitle)
        Me.panelSubTitle.Location = New System.Drawing.Point(165, 253)
        Me.panelSubTitle.Name = "panelSubTitle"
        Me.panelSubTitle.Size = New System.Drawing.Size(227, 32)
        Me.panelSubTitle.TabIndex = 69
        '
        'cmbSubTitle
        '
        Me.cmbSubTitle.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubTitle.FormattingEnabled = True
        Me.cmbSubTitle.Location = New System.Drawing.Point(4, 4)
        Me.cmbSubTitle.Name = "cmbSubTitle"
        Me.cmbSubTitle.Size = New System.Drawing.Size(220, 25)
        Me.cmbSubTitle.TabIndex = 44
        '
        'lblSchoolYr
        '
        Me.lblSchoolYr.AutoSize = True
        Me.lblSchoolYr.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYr.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSchoolYr.Location = New System.Drawing.Point(26, 148)
        Me.lblSchoolYr.Name = "lblSchoolYr"
        Me.lblSchoolYr.Size = New System.Drawing.Size(112, 19)
        Me.lblSchoolYr.TabIndex = 65
        Me.lblSchoolYr.Text = "SCHOOL YEAR"
        '
        'panelSchool
        '
        Me.panelSchool.Controls.Add(Me.cmbSchoolYr)
        Me.panelSchool.Location = New System.Drawing.Point(166, 138)
        Me.panelSchool.Name = "panelSchool"
        Me.panelSchool.Size = New System.Drawing.Size(227, 32)
        Me.panelSchool.TabIndex = 67
        '
        'cmbSchoolYr
        '
        Me.cmbSchoolYr.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchoolYr.FormattingEnabled = True
        Me.cmbSchoolYr.Location = New System.Drawing.Point(4, 4)
        Me.cmbSchoolYr.Name = "cmbSchoolYr"
        Me.cmbSchoolYr.Size = New System.Drawing.Size(220, 25)
        Me.cmbSchoolYr.TabIndex = 45
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUnits.Location = New System.Drawing.Point(26, 302)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(54, 19)
        Me.lblUnits.TabIndex = 63
        Me.lblUnits.Text = "UNITS"
        '
        'panelUnits
        '
        Me.panelUnits.Controls.Add(Me.cmbUnits)
        Me.panelUnits.Location = New System.Drawing.Point(165, 292)
        Me.panelUnits.Name = "panelUnits"
        Me.panelUnits.Size = New System.Drawing.Size(227, 32)
        Me.panelUnits.TabIndex = 64
        '
        'cmbUnits
        '
        Me.cmbUnits.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnits.FormattingEnabled = True
        Me.cmbUnits.Location = New System.Drawing.Point(4, 4)
        Me.cmbUnits.Name = "cmbUnits"
        Me.cmbUnits.Size = New System.Drawing.Size(220, 25)
        Me.cmbUnits.TabIndex = 44
        '
        'lblSubCode
        '
        Me.lblSubCode.AutoSize = True
        Me.lblSubCode.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSubCode.Location = New System.Drawing.Point(26, 224)
        Me.lblSubCode.Name = "lblSubCode"
        Me.lblSubCode.Size = New System.Drawing.Size(129, 19)
        Me.lblSubCode.TabIndex = 61
        Me.lblSubCode.Text = "SUBJECT CODE #"
        '
        'panelSubCod
        '
        Me.panelSubCod.Controls.Add(Me.cmbSubCode)
        Me.panelSubCod.Location = New System.Drawing.Point(165, 214)
        Me.panelSubCod.Name = "panelSubCod"
        Me.panelSubCod.Size = New System.Drawing.Size(227, 32)
        Me.panelSubCod.TabIndex = 62
        '
        'cmbSubCode
        '
        Me.cmbSubCode.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubCode.FormattingEnabled = True
        Me.cmbSubCode.Location = New System.Drawing.Point(3, 3)
        Me.cmbSubCode.Name = "cmbSubCode"
        Me.cmbSubCode.Size = New System.Drawing.Size(221, 25)
        Me.cmbSubCode.TabIndex = 43
        '
        'subjectDataBox
        '
        Me.subjectDataBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectDataBox.ForeColor = System.Drawing.SystemColors.Control
        Me.subjectDataBox.Location = New System.Drawing.Point(18, 117)
        Me.subjectDataBox.Name = "subjectDataBox"
        Me.subjectDataBox.Size = New System.Drawing.Size(385, 218)
        Me.subjectDataBox.TabIndex = 60
        Me.subjectDataBox.TabStop = False
        Me.subjectDataBox.Text = "SUBJECT"
        '
        'btnDeleteGrade
        '
        Me.btnDeleteGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnDeleteGrade.FlatAppearance.BorderSize = 0
        Me.btnDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteGrade.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeleteGrade.Location = New System.Drawing.Point(659, 185)
        Me.btnDeleteGrade.Name = "btnDeleteGrade"
        Me.btnDeleteGrade.Size = New System.Drawing.Size(120, 44)
        Me.btnDeleteGrade.TabIndex = 74
        Me.btnDeleteGrade.Text = "DELETE GRADE"
        Me.btnDeleteGrade.UseVisualStyleBackColor = False
        '
        'btnUpdateGrade
        '
        Me.btnUpdateGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdateGrade.FlatAppearance.BorderSize = 0
        Me.btnUpdateGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateGrade.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdateGrade.Location = New System.Drawing.Point(539, 186)
        Me.btnUpdateGrade.Name = "btnUpdateGrade"
        Me.btnUpdateGrade.Size = New System.Drawing.Size(114, 44)
        Me.btnUpdateGrade.TabIndex = 73
        Me.btnUpdateGrade.Text = "UPDATE GRADE"
        Me.btnUpdateGrade.UseVisualStyleBackColor = False
        '
        'btnSaveGrade
        '
        Me.btnSaveGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSaveGrade.FlatAppearance.BorderSize = 0
        Me.btnSaveGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveGrade.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSaveGrade.Location = New System.Drawing.Point(427, 185)
        Me.btnSaveGrade.Name = "btnSaveGrade"
        Me.btnSaveGrade.Size = New System.Drawing.Size(105, 44)
        Me.btnSaveGrade.TabIndex = 72
        Me.btnSaveGrade.Text = "SAVE GRADE"
        Me.btnSaveGrade.UseVisualStyleBackColor = False
        '
        'btnAccessGrade
        '
        Me.btnAccessGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAccessGrade.FlatAppearance.BorderSize = 0
        Me.btnAccessGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccessGrade.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccessGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAccessGrade.Location = New System.Drawing.Point(539, 237)
        Me.btnAccessGrade.Name = "btnAccessGrade"
        Me.btnAccessGrade.Size = New System.Drawing.Size(114, 46)
        Me.btnAccessGrade.TabIndex = 76
        Me.btnAccessGrade.Text = "ACCESS GRADES"
        Me.btnAccessGrade.UseVisualStyleBackColor = False
        '
        'btnClearGrade
        '
        Me.btnClearGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnClearGrade.FlatAppearance.BorderSize = 0
        Me.btnClearGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearGrade.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClearGrade.Location = New System.Drawing.Point(427, 237)
        Me.btnClearGrade.Name = "btnClearGrade"
        Me.btnClearGrade.Size = New System.Drawing.Size(106, 46)
        Me.btnClearGrade.TabIndex = 75
        Me.btnClearGrade.Text = "CLEAR INPUTS"
        Me.btnClearGrade.UseVisualStyleBackColor = False
        '
        'lblPrelim
        '
        Me.lblPrelim.AutoSize = True
        Me.lblPrelim.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrelim.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrelim.Location = New System.Drawing.Point(8, 32)
        Me.lblPrelim.Name = "lblPrelim"
        Me.lblPrelim.Size = New System.Drawing.Size(73, 19)
        Me.lblPrelim.TabIndex = 80
        Me.lblPrelim.Text = "PRELIMS"
        '
        'panelPrelims
        '
        Me.panelPrelims.Controls.Add(Me.cmbPrelims)
        Me.panelPrelims.Location = New System.Drawing.Point(522, 41)
        Me.panelPrelims.Name = "panelPrelims"
        Me.panelPrelims.Size = New System.Drawing.Size(70, 32)
        Me.panelPrelims.TabIndex = 81
        '
        'cmbPrelims
        '
        Me.cmbPrelims.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrelims.FormattingEnabled = True
        Me.cmbPrelims.Items.AddRange(New Object() {"INC", "FA", "DROP", "WOP", "WP", "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50"})
        Me.cmbPrelims.Location = New System.Drawing.Point(3, 2)
        Me.cmbPrelims.Name = "cmbPrelims"
        Me.cmbPrelims.Size = New System.Drawing.Size(64, 28)
        Me.cmbPrelims.TabIndex = 44
        '
        'panelMidterms
        '
        Me.panelMidterms.Controls.Add(Me.cmbMidterms)
        Me.panelMidterms.Location = New System.Drawing.Point(522, 77)
        Me.panelMidterms.Name = "panelMidterms"
        Me.panelMidterms.Size = New System.Drawing.Size(70, 32)
        Me.panelMidterms.TabIndex = 79
        '
        'cmbMidterms
        '
        Me.cmbMidterms.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMidterms.FormattingEnabled = True
        Me.cmbMidterms.Items.AddRange(New Object() {"INC", "FA", "DROP", "WOP", "WP", "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50"})
        Me.cmbMidterms.Location = New System.Drawing.Point(3, 2)
        Me.cmbMidterms.Name = "cmbMidterms"
        Me.cmbMidterms.Size = New System.Drawing.Size(64, 28)
        Me.cmbMidterms.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCompute)
        Me.GroupBox1.Controls.Add(Me.lblPrelim)
        Me.GroupBox1.Controls.Add(Me.lblFinal)
        Me.GroupBox1.Controls.Add(Me.lblMidterm)
        Me.GroupBox1.Controls.Add(Me.lblGrade)
        Me.GroupBox1.Controls.Add(Me.lblAve)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(424, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 155)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GRADES COMPUTATION"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCompute.FlatAppearance.BorderSize = 0
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCompute.Location = New System.Drawing.Point(182, 105)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(152, 35)
        Me.btnCompute.TabIndex = 89
        Me.btnCompute.Text = "COMPUTE GRADE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFinal.Location = New System.Drawing.Point(8, 110)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(62, 19)
        Me.lblFinal.TabIndex = 82
        Me.lblFinal.Text = "FINALS"
        '
        'lblMidterm
        '
        Me.lblMidterm.AutoSize = True
        Me.lblMidterm.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidterm.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMidterm.Location = New System.Drawing.Point(8, 70)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(87, 19)
        Me.lblMidterm.TabIndex = 84
        Me.lblMidterm.Text = "MIDTERMS"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGrade.Location = New System.Drawing.Point(178, 74)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(61, 19)
        Me.lblGrade.TabIndex = 87
        Me.lblGrade.Text = "GRADE"
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAve.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAve.Location = New System.Drawing.Point(177, 31)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(79, 19)
        Me.lblAve.TabIndex = 85
        Me.lblAve.Text = "AVERAGE"
        '
        'panelFinals
        '
        Me.panelFinals.Controls.Add(Me.cmbFinals)
        Me.panelFinals.Location = New System.Drawing.Point(522, 114)
        Me.panelFinals.Name = "panelFinals"
        Me.panelFinals.Size = New System.Drawing.Size(70, 32)
        Me.panelFinals.TabIndex = 83
        '
        'cmbFinals
        '
        Me.cmbFinals.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFinals.FormattingEnabled = True
        Me.cmbFinals.Items.AddRange(New Object() {"INC", "FA", "DROP", "WOP", "WP", "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50"})
        Me.cmbFinals.Location = New System.Drawing.Point(3, 2)
        Me.cmbFinals.Name = "cmbFinals"
        Me.cmbFinals.Size = New System.Drawing.Size(64, 28)
        Me.cmbFinals.TabIndex = 44
        '
        'panelAverage
        '
        Me.panelAverage.Controls.Add(Me.cmbAve)
        Me.panelAverage.Location = New System.Drawing.Point(692, 36)
        Me.panelAverage.Name = "panelAverage"
        Me.panelAverage.Size = New System.Drawing.Size(70, 32)
        Me.panelAverage.TabIndex = 86
        '
        'cmbAve
        '
        Me.cmbAve.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAve.FormattingEnabled = True
        Me.cmbAve.Location = New System.Drawing.Point(4, 3)
        Me.cmbAve.Name = "cmbAve"
        Me.cmbAve.Size = New System.Drawing.Size(62, 28)
        Me.cmbAve.TabIndex = 44
        '
        'panelGrade
        '
        Me.panelGrade.Controls.Add(Me.cmbGrade)
        Me.panelGrade.Location = New System.Drawing.Point(692, 74)
        Me.panelGrade.Name = "panelGrade"
        Me.panelGrade.Size = New System.Drawing.Size(70, 32)
        Me.panelGrade.TabIndex = 88
        '
        'cmbGrade
        '
        Me.cmbGrade.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrade.FormattingEnabled = True
        Me.cmbGrade.Items.AddRange(New Object() {"1.00", "1.25", "1.5", "1.75", "2.00", "2.25", "2.5", "2.75", "3.00", "5.00"})
        Me.cmbGrade.Location = New System.Drawing.Point(3, 2)
        Me.cmbGrade.Name = "cmbGrade"
        Me.cmbGrade.Size = New System.Drawing.Size(65, 28)
        Me.cmbGrade.TabIndex = 44
        '
        'lblSearchGrade
        '
        Me.lblSearchGrade.AutoSize = True
        Me.lblSearchGrade.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearchGrade.Location = New System.Drawing.Point(419, 312)
        Me.lblSearchGrade.Name = "lblSearchGrade"
        Me.lblSearchGrade.Size = New System.Drawing.Size(68, 21)
        Me.lblSearchGrade.TabIndex = 90
        Me.lblSearchGrade.Text = "Search:"
        '
        'txtSearchGrade
        '
        Me.txtSearchGrade.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchGrade.Location = New System.Drawing.Point(490, 312)
        Me.txtSearchGrade.Name = "txtSearchGrade"
        Me.txtSearchGrade.Size = New System.Drawing.Size(291, 23)
        Me.txtSearchGrade.TabIndex = 89
        '
        'studentGradeView
        '
        Me.studentGradeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.studentGradeView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentGradeView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.studentGradeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentGradeView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentGradeView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.studentGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentGradeView.DefaultCellStyle = DataGridViewCellStyle2
        Me.studentGradeView.EnableHeadersVisualStyles = False
        Me.studentGradeView.Location = New System.Drawing.Point(18, 341)
        Me.studentGradeView.Name = "studentGradeView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentGradeView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.studentGradeView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.studentGradeView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.studentGradeView.Size = New System.Drawing.Size(763, 324)
        Me.studentGradeView.TabIndex = 91
        '
        'btnAddGrade
        '
        Me.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddGrade.FlatAppearance.BorderSize = 0
        Me.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddGrade.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGrade.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddGrade.Location = New System.Drawing.Point(659, 237)
        Me.btnAddGrade.Name = "btnAddGrade"
        Me.btnAddGrade.Size = New System.Drawing.Size(120, 46)
        Me.btnAddGrade.TabIndex = 92
        Me.btnAddGrade.Text = "ADD GRADE RECORD"
        Me.btnAddGrade.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExport.Location = New System.Drawing.Point(18, 668)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(248, 29)
        Me.btnExport.TabIndex = 93
        Me.btnExport.Text = "VIEW STUDENT GRADE RECORDS"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'StudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 700)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnAddGrade)
        Me.Controls.Add(Me.studentGradeView)
        Me.Controls.Add(Me.lblSearchGrade)
        Me.Controls.Add(Me.txtSearchGrade)
        Me.Controls.Add(Me.panelGrade)
        Me.Controls.Add(Me.panelAverage)
        Me.Controls.Add(Me.panelFinals)
        Me.Controls.Add(Me.panelPrelims)
        Me.Controls.Add(Me.panelMidterms)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAccessGrade)
        Me.Controls.Add(Me.btnClearGrade)
        Me.Controls.Add(Me.btnDeleteGrade)
        Me.Controls.Add(Me.btnUpdateGrade)
        Me.Controls.Add(Me.btnSaveGrade)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.panelSem)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.panelSubTitle)
        Me.Controls.Add(Me.lblSchoolYr)
        Me.Controls.Add(Me.panelSchool)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.panelUnits)
        Me.Controls.Add(Me.lblSubCode)
        Me.Controls.Add(Me.panelSubCod)
        Me.Controls.Add(Me.subjectDataBox)
        Me.Controls.Add(Me.lblStudNo)
        Me.Controls.Add(Me.panelStudNo)
        Me.Controls.Add(Me.lblStudNm)
        Me.Controls.Add(Me.panelStudNm)
        Me.Controls.Add(Me.studentDataBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentGrades"
        Me.Text = "StudentGrades"
        Me.panelStudNo.ResumeLayout(False)
        Me.panelStudNm.ResumeLayout(False)
        Me.panelSem.ResumeLayout(False)
        Me.panelSubTitle.ResumeLayout(False)
        Me.panelSchool.ResumeLayout(False)
        Me.panelUnits.ResumeLayout(False)
        Me.panelSubCod.ResumeLayout(False)
        Me.panelPrelims.ResumeLayout(False)
        Me.panelMidterms.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelFinals.ResumeLayout(False)
        Me.panelAverage.ResumeLayout(False)
        Me.panelGrade.ResumeLayout(False)
        CType(Me.studentGradeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudNo As Label
    Friend WithEvents panelStudNo As Panel
    Friend WithEvents cmbStudNo As ComboBox
    Friend WithEvents lblStudNm As Label
    Friend WithEvents panelStudNm As Panel
    Friend WithEvents cmbStudNm As ComboBox
    Friend WithEvents studentDataBox As GroupBox
    Friend WithEvents lblSemester As Label
    Friend WithEvents panelSem As Panel
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents panelSubTitle As Panel
    Friend WithEvents cmbSubTitle As ComboBox
    Friend WithEvents lblSchoolYr As Label
    Friend WithEvents panelSchool As Panel
    Friend WithEvents cmbSchoolYr As ComboBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents panelUnits As Panel
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents lblSubCode As Label
    Friend WithEvents panelSubCod As Panel
    Friend WithEvents cmbSubCode As ComboBox
    Friend WithEvents subjectDataBox As GroupBox
    Friend WithEvents btnDeleteGrade As Button
    Friend WithEvents btnUpdateGrade As Button
    Friend WithEvents btnSaveGrade As Button
    Friend WithEvents btnAccessGrade As Button
    Friend WithEvents btnClearGrade As Button
    Friend WithEvents lblPrelim As Label
    Friend WithEvents panelPrelims As Panel
    Friend WithEvents cmbPrelims As ComboBox
    Friend WithEvents panelMidterms As Panel
    Friend WithEvents cmbMidterms As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblFinal As Label
    Friend WithEvents panelFinals As Panel
    Friend WithEvents cmbFinals As ComboBox
    Friend WithEvents lblMidterm As Label
    Friend WithEvents panelAverage As Panel
    Friend WithEvents cmbAve As ComboBox
    Friend WithEvents lblAve As Label
    Friend WithEvents panelGrade As Panel
    Friend WithEvents cmbGrade As ComboBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblSearchGrade As Label
    Friend WithEvents txtSearchGrade As TextBox
    Friend WithEvents studentGradeView As DataGridView
    Friend WithEvents btnAddGrade As Button
    Friend WithEvents btnExport As Button
End Class
