<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfile))
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastNm = New System.Windows.Forms.TextBox()
        Me.txtFirstNm = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.txtMiddleNm = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.panelLastNm = New System.Windows.Forms.Panel()
        Me.panelFirstNm = New System.Windows.Forms.Panel()
        Me.panelMidNm = New System.Windows.Forms.Panel()
        Me.dateBirth = New System.Windows.Forms.DateTimePicker()
        Me.panelBirthdate = New System.Windows.Forms.Panel()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.panelGender = New System.Windows.Forms.Panel()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtStudContact = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.panelContact = New System.Windows.Forms.Panel()
        Me.studInfoBox1 = New System.Windows.Forms.GroupBox()
        Me.guardianInfoBox = New System.Windows.Forms.GroupBox()
        Me.txtGuardContact = New System.Windows.Forms.TextBox()
        Me.lblGuardContact = New System.Windows.Forms.Label()
        Me.panelContact2 = New System.Windows.Forms.Panel()
        Me.txtGuardAddress = New System.Windows.Forms.TextBox()
        Me.txtGuardNm = New System.Windows.Forms.TextBox()
        Me.panelAddress2 = New System.Windows.Forms.Panel()
        Me.lblGuardian = New System.Windows.Forms.Label()
        Me.panelName = New System.Windows.Forms.Panel()
        Me.lblAddressGuardian = New System.Windows.Forms.Label()
        Me.txtStudAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.panelAddress = New System.Windows.Forms.Panel()
        Me.lblStudType = New System.Windows.Forms.Label()
        Me.panelStudType = New System.Windows.Forms.Panel()
        Me.cmbStudType = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.panelCourse = New System.Windows.Forms.Panel()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.panelYear = New System.Windows.Forms.Panel()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.studInfoBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStudNo = New System.Windows.Forms.Label()
        Me.studentProfileView = New System.Windows.Forms.DataGridView()
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.btnUpdateProfile = New System.Windows.Forms.Button()
        Me.btnDeleteProfile = New System.Windows.Forms.Button()
        Me.btnAccessProfile = New System.Windows.Forms.Button()
        Me.txtSearchProfile = New System.Windows.Forms.TextBox()
        Me.lblSearchProfile = New System.Windows.Forms.Label()
        Me.txtStudNo = New System.Windows.Forms.TextBox()
        Me.panelStudNo = New System.Windows.Forms.Panel()
        Me.btnAddProfile = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.panelGender.SuspendLayout()
        Me.guardianInfoBox.SuspendLayout()
        Me.panelStudType.SuspendLayout()
        Me.panelCourse.SuspendLayout()
        Me.panelYear.SuspendLayout()
        Me.studInfoBox2.SuspendLayout()
        CType(Me.studentProfileView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLastName.Location = New System.Drawing.Point(31, 32)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(95, 19)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "LAST NAME"
        '
        'txtLastNm
        '
        Me.txtLastNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastNm.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNm.Location = New System.Drawing.Point(153, 28)
        Me.txtLastNm.Name = "txtLastNm"
        Me.txtLastNm.Size = New System.Drawing.Size(212, 23)
        Me.txtLastNm.TabIndex = 1
        '
        'txtFirstNm
        '
        Me.txtFirstNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstNm.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNm.Location = New System.Drawing.Point(154, 67)
        Me.txtFirstNm.Name = "txtFirstNm"
        Me.txtFirstNm.Size = New System.Drawing.Size(210, 23)
        Me.txtFirstNm.TabIndex = 3
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFirstName.Location = New System.Drawing.Point(31, 73)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(97, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "FIRST NAME"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.ForeColor = System.Drawing.SystemColors.Control
        Me.lblBirthdate.Location = New System.Drawing.Point(31, 149)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(92, 19)
        Me.lblBirthdate.TabIndex = 6
        Me.lblBirthdate.Text = "BIRTHDATE"
        '
        'txtMiddleNm
        '
        Me.txtMiddleNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleNm.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleNm.Location = New System.Drawing.Point(155, 108)
        Me.txtMiddleNm.Name = "txtMiddleNm"
        Me.txtMiddleNm.Size = New System.Drawing.Size(209, 23)
        Me.txtMiddleNm.TabIndex = 5
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMiddleName.Location = New System.Drawing.Point(31, 112)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(114, 19)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.Text = "MIDDLE NAME"
        '
        'panelLastNm
        '
        Me.panelLastNm.Location = New System.Drawing.Point(147, 23)
        Me.panelLastNm.Name = "panelLastNm"
        Me.panelLastNm.Size = New System.Drawing.Size(223, 32)
        Me.panelLastNm.TabIndex = 8
        '
        'panelFirstNm
        '
        Me.panelFirstNm.Location = New System.Drawing.Point(147, 62)
        Me.panelFirstNm.Name = "panelFirstNm"
        Me.panelFirstNm.Size = New System.Drawing.Size(223, 32)
        Me.panelFirstNm.TabIndex = 9
        '
        'panelMidNm
        '
        Me.panelMidNm.Location = New System.Drawing.Point(147, 103)
        Me.panelMidNm.Name = "panelMidNm"
        Me.panelMidNm.Size = New System.Drawing.Size(223, 32)
        Me.panelMidNm.TabIndex = 10
        '
        'dateBirth
        '
        Me.dateBirth.CustomFormat = "mm/dd/yyyy"
        Me.dateBirth.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBirth.Location = New System.Drawing.Point(155, 145)
        Me.dateBirth.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
        Me.dateBirth.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateBirth.Name = "dateBirth"
        Me.dateBirth.Size = New System.Drawing.Size(209, 23)
        Me.dateBirth.TabIndex = 11
        Me.dateBirth.Value = New Date(2021, 10, 19, 0, 0, 0, 0)
        '
        'panelBirthdate
        '
        Me.panelBirthdate.Location = New System.Drawing.Point(147, 141)
        Me.panelBirthdate.Name = "panelBirthdate"
        Me.panelBirthdate.Size = New System.Drawing.Size(223, 32)
        Me.panelBirthdate.TabIndex = 12
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGender.Location = New System.Drawing.Point(31, 193)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(71, 19)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "GENDER"
        '
        'panelGender
        '
        Me.panelGender.Controls.Add(Me.cmbGender)
        Me.panelGender.Location = New System.Drawing.Point(147, 181)
        Me.panelGender.Name = "panelGender"
        Me.panelGender.Size = New System.Drawing.Size(223, 34)
        Me.panelGender.TabIndex = 15
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(8, 4)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(209, 25)
        Me.cmbGender.TabIndex = 0
        '
        'txtStudContact
        '
        Me.txtStudContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudContact.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudContact.Location = New System.Drawing.Point(155, 227)
        Me.txtStudContact.Name = "txtStudContact"
        Me.txtStudContact.Size = New System.Drawing.Size(209, 23)
        Me.txtStudContact.TabIndex = 17
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContact.Location = New System.Drawing.Point(31, 233)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(93, 19)
        Me.lblContact.TabIndex = 16
        Me.lblContact.Text = "CONTACT #"
        '
        'panelContact
        '
        Me.panelContact.Location = New System.Drawing.Point(147, 222)
        Me.panelContact.Name = "panelContact"
        Me.panelContact.Size = New System.Drawing.Size(223, 32)
        Me.panelContact.TabIndex = 18
        '
        'studInfoBox1
        '
        Me.studInfoBox1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studInfoBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.studInfoBox1.Location = New System.Drawing.Point(23, 1)
        Me.studInfoBox1.Name = "studInfoBox1"
        Me.studInfoBox1.Size = New System.Drawing.Size(364, 333)
        Me.studInfoBox1.TabIndex = 19
        Me.studInfoBox1.TabStop = False
        Me.studInfoBox1.Text = "STUDENT INFORMATION"
        '
        'guardianInfoBox
        '
        Me.guardianInfoBox.Controls.Add(Me.txtGuardContact)
        Me.guardianInfoBox.Controls.Add(Me.lblGuardContact)
        Me.guardianInfoBox.Controls.Add(Me.panelContact2)
        Me.guardianInfoBox.Controls.Add(Me.txtGuardAddress)
        Me.guardianInfoBox.Controls.Add(Me.txtGuardNm)
        Me.guardianInfoBox.Controls.Add(Me.panelAddress2)
        Me.guardianInfoBox.Controls.Add(Me.lblGuardian)
        Me.guardianInfoBox.Controls.Add(Me.panelName)
        Me.guardianInfoBox.Controls.Add(Me.lblAddressGuardian)
        Me.guardianInfoBox.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardianInfoBox.ForeColor = System.Drawing.SystemColors.Control
        Me.guardianInfoBox.Location = New System.Drawing.Point(411, 174)
        Me.guardianInfoBox.Name = "guardianInfoBox"
        Me.guardianInfoBox.Size = New System.Drawing.Size(358, 135)
        Me.guardianInfoBox.TabIndex = 20
        Me.guardianInfoBox.TabStop = False
        Me.guardianInfoBox.Text = "GUARDIAN INFORMATION"
        '
        'txtGuardContact
        '
        Me.txtGuardContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuardContact.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardContact.Location = New System.Drawing.Point(167, 63)
        Me.txtGuardContact.Name = "txtGuardContact"
        Me.txtGuardContact.Size = New System.Drawing.Size(169, 23)
        Me.txtGuardContact.TabIndex = 38
        '
        'lblGuardContact
        '
        Me.lblGuardContact.AutoSize = True
        Me.lblGuardContact.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardContact.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGuardContact.Location = New System.Drawing.Point(10, 65)
        Me.lblGuardContact.Name = "lblGuardContact"
        Me.lblGuardContact.Size = New System.Drawing.Size(93, 19)
        Me.lblGuardContact.TabIndex = 37
        Me.lblGuardContact.Text = "CONTACT #"
        '
        'panelContact2
        '
        Me.panelContact2.Location = New System.Drawing.Point(161, 58)
        Me.panelContact2.Name = "panelContact2"
        Me.panelContact2.Size = New System.Drawing.Size(180, 32)
        Me.panelContact2.TabIndex = 39
        '
        'txtGuardAddress
        '
        Me.txtGuardAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuardAddress.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardAddress.Location = New System.Drawing.Point(167, 97)
        Me.txtGuardAddress.Name = "txtGuardAddress"
        Me.txtGuardAddress.Size = New System.Drawing.Size(169, 23)
        Me.txtGuardAddress.TabIndex = 35
        '
        'txtGuardNm
        '
        Me.txtGuardNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuardNm.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardNm.Location = New System.Drawing.Point(167, 26)
        Me.txtGuardNm.Name = "txtGuardNm"
        Me.txtGuardNm.Size = New System.Drawing.Size(169, 23)
        Me.txtGuardNm.TabIndex = 10
        '
        'panelAddress2
        '
        Me.panelAddress2.Location = New System.Drawing.Point(161, 93)
        Me.panelAddress2.Name = "panelAddress2"
        Me.panelAddress2.Size = New System.Drawing.Size(180, 32)
        Me.panelAddress2.TabIndex = 36
        '
        'lblGuardian
        '
        Me.lblGuardian.AutoSize = True
        Me.lblGuardian.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardian.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGuardian.Location = New System.Drawing.Point(10, 30)
        Me.lblGuardian.Name = "lblGuardian"
        Me.lblGuardian.Size = New System.Drawing.Size(54, 19)
        Me.lblGuardian.TabIndex = 9
        Me.lblGuardian.Text = "NAME"
        '
        'panelName
        '
        Me.panelName.Location = New System.Drawing.Point(161, 22)
        Me.panelName.Name = "panelName"
        Me.panelName.Size = New System.Drawing.Size(180, 32)
        Me.panelName.TabIndex = 11
        '
        'lblAddressGuardian
        '
        Me.lblAddressGuardian.AutoSize = True
        Me.lblAddressGuardian.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressGuardian.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAddressGuardian.Location = New System.Drawing.Point(10, 101)
        Me.lblAddressGuardian.Name = "lblAddressGuardian"
        Me.lblAddressGuardian.Size = New System.Drawing.Size(79, 19)
        Me.lblAddressGuardian.TabIndex = 34
        Me.lblAddressGuardian.Text = "ADDRESS"
        '
        'txtStudAddress
        '
        Me.txtStudAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudAddress.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudAddress.Location = New System.Drawing.Point(155, 268)
        Me.txtStudAddress.Multiline = True
        Me.txtStudAddress.Name = "txtStudAddress"
        Me.txtStudAddress.Size = New System.Drawing.Size(209, 57)
        Me.txtStudAddress.TabIndex = 22
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAddress.Location = New System.Drawing.Point(31, 278)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(79, 19)
        Me.lblAddress.TabIndex = 21
        Me.lblAddress.Text = "ADDRESS"
        '
        'panelAddress
        '
        Me.panelAddress.Location = New System.Drawing.Point(147, 264)
        Me.panelAddress.Name = "panelAddress"
        Me.panelAddress.Size = New System.Drawing.Size(223, 64)
        Me.panelAddress.TabIndex = 23
        '
        'lblStudType
        '
        Me.lblStudType.AutoSize = True
        Me.lblStudType.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudType.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudType.Location = New System.Drawing.Point(10, 64)
        Me.lblStudType.Name = "lblStudType"
        Me.lblStudType.Size = New System.Drawing.Size(119, 19)
        Me.lblStudType.TabIndex = 24
        Me.lblStudType.Text = "STUDENT TYPE"
        '
        'panelStudType
        '
        Me.panelStudType.Controls.Add(Me.cmbStudType)
        Me.panelStudType.Location = New System.Drawing.Point(574, 59)
        Me.panelStudType.Name = "panelStudType"
        Me.panelStudType.Size = New System.Drawing.Size(177, 32)
        Me.panelStudType.TabIndex = 26
        '
        'cmbStudType
        '
        Me.cmbStudType.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudType.FormattingEnabled = True
        Me.cmbStudType.Items.AddRange(New Object() {"OLD", "NEW"})
        Me.cmbStudType.Location = New System.Drawing.Point(6, 4)
        Me.cmbStudType.Name = "cmbStudType"
        Me.cmbStudType.Size = New System.Drawing.Size(166, 25)
        Me.cmbStudType.TabIndex = 33
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCourse.Location = New System.Drawing.Point(12, 99)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(69, 19)
        Me.lblCourse.TabIndex = 27
        Me.lblCourse.Text = "COURSE"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.SystemColors.Control
        Me.lblYear.Location = New System.Drawing.Point(12, 136)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(49, 19)
        Me.lblYear.TabIndex = 30
        Me.lblYear.Text = "YEAR"
        '
        'panelCourse
        '
        Me.panelCourse.Controls.Add(Me.cmbCourse)
        Me.panelCourse.Location = New System.Drawing.Point(574, 95)
        Me.panelCourse.Name = "panelCourse"
        Me.panelCourse.Size = New System.Drawing.Size(177, 32)
        Me.panelCourse.TabIndex = 31
        '
        'cmbCourse
        '
        Me.cmbCourse.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Items.AddRange(New Object() {"A.B. Mass Communication", "B.S. Computer Science", "B.S. Hotel and Restaurant Management", "B.S. Commerce in Management", "B.S. Tourism Management", "B.S. Psychology", "B.S. Nursing", "B.S. Physical Therapy"})
        Me.cmbCourse.Location = New System.Drawing.Point(6, 3)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(166, 25)
        Me.cmbCourse.TabIndex = 33
        '
        'panelYear
        '
        Me.panelYear.Controls.Add(Me.cmbYear)
        Me.panelYear.Location = New System.Drawing.Point(574, 132)
        Me.panelYear.Name = "panelYear"
        Me.panelYear.Size = New System.Drawing.Size(177, 32)
        Me.panelYear.TabIndex = 32
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"FIRST", "SECOND", "THIRD", "FOURTH"})
        Me.cmbYear.Location = New System.Drawing.Point(6, 3)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(166, 25)
        Me.cmbYear.TabIndex = 33
        '
        'studInfoBox2
        '
        Me.studInfoBox2.Controls.Add(Me.lblStudNo)
        Me.studInfoBox2.Controls.Add(Me.lblStudType)
        Me.studInfoBox2.Controls.Add(Me.lblCourse)
        Me.studInfoBox2.Controls.Add(Me.lblYear)
        Me.studInfoBox2.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studInfoBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.studInfoBox2.Location = New System.Drawing.Point(411, 3)
        Me.studInfoBox2.Name = "studInfoBox2"
        Me.studInfoBox2.Size = New System.Drawing.Size(358, 171)
        Me.studInfoBox2.TabIndex = 33
        Me.studInfoBox2.TabStop = False
        Me.studInfoBox2.Text = "STUDENT INFORMATION"
        '
        'lblStudNo
        '
        Me.lblStudNo.AutoSize = True
        Me.lblStudNo.Font = New System.Drawing.Font("Corbel", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStudNo.Location = New System.Drawing.Point(10, 28)
        Me.lblStudNo.Name = "lblStudNo"
        Me.lblStudNo.Size = New System.Drawing.Size(125, 19)
        Me.lblStudNo.TabIndex = 42
        Me.lblStudNo.Text = "STUDENT NO. #"
        '
        'studentProfileView
        '
        Me.studentProfileView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.studentProfileView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentProfileView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.studentProfileView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentProfileView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentProfileView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.studentProfileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentProfileView.DefaultCellStyle = DataGridViewCellStyle2
        Me.studentProfileView.EnableHeadersVisualStyles = False
        Me.studentProfileView.Location = New System.Drawing.Point(22, 383)
        Me.studentProfileView.Name = "studentProfileView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.471698!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentProfileView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.studentProfileView.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.studentProfileView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.studentProfileView.Size = New System.Drawing.Size(748, 274)
        Me.studentProfileView.TabIndex = 34
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSaveProfile.FlatAppearance.BorderSize = 0
        Me.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProfile.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSaveProfile.Location = New System.Drawing.Point(411, 314)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(111, 35)
        Me.btnSaveProfile.TabIndex = 35
        Me.btnSaveProfile.Text = "SAVE PROFILE"
        Me.btnSaveProfile.UseVisualStyleBackColor = False
        '
        'btnUpdateProfile
        '
        Me.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdateProfile.FlatAppearance.BorderSize = 0
        Me.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateProfile.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdateProfile.Location = New System.Drawing.Point(528, 314)
        Me.btnUpdateProfile.Name = "btnUpdateProfile"
        Me.btnUpdateProfile.Size = New System.Drawing.Size(122, 35)
        Me.btnUpdateProfile.TabIndex = 36
        Me.btnUpdateProfile.Text = "UPDATE PROFILE"
        Me.btnUpdateProfile.UseVisualStyleBackColor = False
        '
        'btnDeleteProfile
        '
        Me.btnDeleteProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnDeleteProfile.FlatAppearance.BorderSize = 0
        Me.btnDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteProfile.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeleteProfile.Location = New System.Drawing.Point(656, 314)
        Me.btnDeleteProfile.Name = "btnDeleteProfile"
        Me.btnDeleteProfile.Size = New System.Drawing.Size(112, 35)
        Me.btnDeleteProfile.TabIndex = 37
        Me.btnDeleteProfile.Text = "DELETE PROFILE"
        Me.btnDeleteProfile.UseVisualStyleBackColor = False
        '
        'btnAccessProfile
        '
        Me.btnAccessProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAccessProfile.FlatAppearance.BorderSize = 0
        Me.btnAccessProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccessProfile.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccessProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAccessProfile.Location = New System.Drawing.Point(22, 342)
        Me.btnAccessProfile.Name = "btnAccessProfile"
        Me.btnAccessProfile.Size = New System.Drawing.Size(180, 35)
        Me.btnAccessProfile.TabIndex = 39
        Me.btnAccessProfile.Text = "ACCESS PROFILES"
        Me.btnAccessProfile.UseVisualStyleBackColor = False
        '
        'txtSearchProfile
        '
        Me.txtSearchProfile.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProfile.Location = New System.Drawing.Point(473, 355)
        Me.txtSearchProfile.Name = "txtSearchProfile"
        Me.txtSearchProfile.Size = New System.Drawing.Size(297, 23)
        Me.txtSearchProfile.TabIndex = 40
        '
        'lblSearchProfile
        '
        Me.lblSearchProfile.AutoSize = True
        Me.lblSearchProfile.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSearchProfile.Location = New System.Drawing.Point(405, 357)
        Me.lblSearchProfile.Name = "lblSearchProfile"
        Me.lblSearchProfile.Size = New System.Drawing.Size(68, 21)
        Me.lblSearchProfile.TabIndex = 41
        Me.lblSearchProfile.Text = "Search:"
        '
        'txtStudNo
        '
        Me.txtStudNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudNo.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudNo.Location = New System.Drawing.Point(578, 27)
        Me.txtStudNo.Name = "txtStudNo"
        Me.txtStudNo.Size = New System.Drawing.Size(169, 23)
        Me.txtStudNo.TabIndex = 43
        '
        'panelStudNo
        '
        Me.panelStudNo.Location = New System.Drawing.Point(572, 23)
        Me.panelStudNo.Name = "panelStudNo"
        Me.panelStudNo.Size = New System.Drawing.Size(180, 32)
        Me.panelStudNo.TabIndex = 44
        '
        'btnAddProfile
        '
        Me.btnAddProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAddProfile.FlatAppearance.BorderSize = 0
        Me.btnAddProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProfile.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProfile.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddProfile.Location = New System.Drawing.Point(207, 342)
        Me.btnAddProfile.Name = "btnAddProfile"
        Me.btnAddProfile.Size = New System.Drawing.Size(180, 35)
        Me.btnAddProfile.TabIndex = 45
        Me.btnAddProfile.Text = "ADD PROFILE"
        Me.btnAddProfile.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExport.Location = New System.Drawing.Point(23, 660)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(204, 35)
        Me.btnExport.TabIndex = 46
        Me.btnExport.Text = "VIEW STUDENT PROFILES LIST"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 700)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnAddProfile)
        Me.Controls.Add(Me.txtStudNo)
        Me.Controls.Add(Me.panelStudNo)
        Me.Controls.Add(Me.lblSearchProfile)
        Me.Controls.Add(Me.txtSearchProfile)
        Me.Controls.Add(Me.btnAccessProfile)
        Me.Controls.Add(Me.btnDeleteProfile)
        Me.Controls.Add(Me.btnUpdateProfile)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.studentProfileView)
        Me.Controls.Add(Me.panelYear)
        Me.Controls.Add(Me.panelCourse)
        Me.Controls.Add(Me.panelStudType)
        Me.Controls.Add(Me.txtStudAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.panelAddress)
        Me.Controls.Add(Me.guardianInfoBox)
        Me.Controls.Add(Me.txtStudContact)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.panelContact)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.panelGender)
        Me.Controls.Add(Me.dateBirth)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.txtMiddleNm)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.txtFirstNm)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastNm)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.panelLastNm)
        Me.Controls.Add(Me.panelFirstNm)
        Me.Controls.Add(Me.panelMidNm)
        Me.Controls.Add(Me.panelBirthdate)
        Me.Controls.Add(Me.studInfoBox2)
        Me.Controls.Add(Me.studInfoBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentProfile"
        Me.Text = "StudentProfile"
        Me.panelGender.ResumeLayout(False)
        Me.guardianInfoBox.ResumeLayout(False)
        Me.guardianInfoBox.PerformLayout()
        Me.panelStudType.ResumeLayout(False)
        Me.panelCourse.ResumeLayout(False)
        Me.panelYear.ResumeLayout(False)
        Me.studInfoBox2.ResumeLayout(False)
        Me.studInfoBox2.PerformLayout()
        CType(Me.studentProfileView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastNm As TextBox
    Friend WithEvents txtFirstNm As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents txtMiddleNm As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents panelLastNm As Panel
    Friend WithEvents panelFirstNm As Panel
    Friend WithEvents panelMidNm As Panel
    Friend WithEvents dateBirth As DateTimePicker
    Friend WithEvents panelBirthdate As Panel
    Friend WithEvents lblGender As Label
    Friend WithEvents panelGender As Panel
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtStudContact As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents panelContact As Panel
    Friend WithEvents studInfoBox1 As GroupBox
    Friend WithEvents guardianInfoBox As GroupBox
    Friend WithEvents txtGuardAddress As TextBox
    Friend WithEvents txtGuardNm As TextBox
    Friend WithEvents lblAddressGuardian As Label
    Friend WithEvents panelAddress2 As Panel
    Friend WithEvents lblGuardian As Label
    Friend WithEvents panelName As Panel
    Friend WithEvents txtStudAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents panelAddress As Panel
    Friend WithEvents lblStudType As Label
    Friend WithEvents panelStudType As Panel
    Friend WithEvents cmbStudType As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents panelCourse As Panel
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents panelYear As Panel
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents studInfoBox2 As GroupBox
    Friend WithEvents studentProfileView As DataGridView
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnUpdateProfile As Button
    Friend WithEvents btnDeleteProfile As Button
    Friend WithEvents btnAccessProfile As Button
    Friend WithEvents txtSearchProfile As TextBox
    Friend WithEvents lblSearchProfile As Label
    Friend WithEvents txtStudNo As TextBox
    Friend WithEvents lblStudNo As Label
    Friend WithEvents panelStudNo As Panel
    Friend WithEvents txtGuardContact As TextBox
    Friend WithEvents lblGuardContact As Label
    Friend WithEvents panelContact2 As Panel
    Friend WithEvents btnAddProfile As Button
    Friend WithEvents btnExport As Button
End Class
