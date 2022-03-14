<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnGWA = New System.Windows.Forms.Button()
        Me.btnManageAdmin = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnStudentGrades = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStudentRecords = New System.Windows.Forms.Button()
        Me.btnSubjectsList = New System.Windows.Forms.Button()
        Me.btnStudentProfile = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.clockLab2 = New System.Windows.Forms.Label()
        Me.clockLab = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnManageUsers)
        Me.panelMenu.Controls.Add(Me.btnGWA)
        Me.panelMenu.Controls.Add(Me.btnManageAdmin)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.btnStudentGrades)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.btnStudentRecords)
        Me.panelMenu.Controls.Add(Me.btnSubjectsList)
        Me.panelMenu.Controls.Add(Me.btnStudentProfile)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(230, 700)
        Me.panelMenu.TabIndex = 0
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnManageUsers.FlatAppearance.BorderSize = 0
        Me.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUsers.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnManageUsers.Image = CType(resources.GetObject("btnManageUsers.Image"), System.Drawing.Image)
        Me.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageUsers.Location = New System.Drawing.Point(0, 550)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnManageUsers.Size = New System.Drawing.Size(230, 50)
        Me.btnManageUsers.TabIndex = 10
        Me.btnManageUsers.Text = "   Manage Users"
        Me.btnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnGWA
        '
        Me.btnGWA.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGWA.FlatAppearance.BorderSize = 0
        Me.btnGWA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGWA.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGWA.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGWA.Image = CType(resources.GetObject("btnGWA.Image"), System.Drawing.Image)
        Me.btnGWA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGWA.Location = New System.Drawing.Point(0, 330)
        Me.btnGWA.Name = "btnGWA"
        Me.btnGWA.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnGWA.Size = New System.Drawing.Size(230, 50)
        Me.btnGWA.TabIndex = 9
        Me.btnGWA.Text = "   GWA Calculator"
        Me.btnGWA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGWA.UseVisualStyleBackColor = True
        '
        'btnManageAdmin
        '
        Me.btnManageAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnManageAdmin.FlatAppearance.BorderSize = 0
        Me.btnManageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageAdmin.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAdmin.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnManageAdmin.Image = CType(resources.GetObject("btnManageAdmin.Image"), System.Drawing.Image)
        Me.btnManageAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageAdmin.Location = New System.Drawing.Point(0, 600)
        Me.btnManageAdmin.Name = "btnManageAdmin"
        Me.btnManageAdmin.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnManageAdmin.Size = New System.Drawing.Size(230, 50)
        Me.btnManageAdmin.TabIndex = 7
        Me.btnManageAdmin.Text = "   Manage Admin"
        Me.btnManageAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageAdmin.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 650)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(230, 50)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "   Logout Admin"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnStudentGrades
        '
        Me.btnStudentGrades.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentGrades.FlatAppearance.BorderSize = 0
        Me.btnStudentGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentGrades.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentGrades.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStudentGrades.Image = CType(resources.GetObject("btnStudentGrades.Image"), System.Drawing.Image)
        Me.btnStudentGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentGrades.Location = New System.Drawing.Point(0, 280)
        Me.btnStudentGrades.Name = "btnStudentGrades"
        Me.btnStudentGrades.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnStudentGrades.Size = New System.Drawing.Size(230, 50)
        Me.btnStudentGrades.TabIndex = 5
        Me.btnStudentGrades.Text = "   Student Grades"
        Me.btnStudentGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudentGrades.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 230)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(230, 50)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnStudentRecords
        '
        Me.btnStudentRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentRecords.FlatAppearance.BorderSize = 0
        Me.btnStudentRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentRecords.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentRecords.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStudentRecords.Image = CType(resources.GetObject("btnStudentRecords.Image"), System.Drawing.Image)
        Me.btnStudentRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentRecords.Location = New System.Drawing.Point(0, 180)
        Me.btnStudentRecords.Name = "btnStudentRecords"
        Me.btnStudentRecords.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnStudentRecords.Size = New System.Drawing.Size(230, 50)
        Me.btnStudentRecords.TabIndex = 3
        Me.btnStudentRecords.Text = "   Student Records"
        Me.btnStudentRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudentRecords.UseVisualStyleBackColor = True
        '
        'btnSubjectsList
        '
        Me.btnSubjectsList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubjectsList.FlatAppearance.BorderSize = 0
        Me.btnSubjectsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjectsList.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjectsList.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubjectsList.Image = CType(resources.GetObject("btnSubjectsList.Image"), System.Drawing.Image)
        Me.btnSubjectsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubjectsList.Location = New System.Drawing.Point(0, 130)
        Me.btnSubjectsList.Name = "btnSubjectsList"
        Me.btnSubjectsList.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSubjectsList.Size = New System.Drawing.Size(230, 50)
        Me.btnSubjectsList.TabIndex = 2
        Me.btnSubjectsList.Text = "   Subjects List"
        Me.btnSubjectsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubjectsList.UseVisualStyleBackColor = True
        '
        'btnStudentProfile
        '
        Me.btnStudentProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentProfile.FlatAppearance.BorderSize = 0
        Me.btnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentProfile.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentProfile.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStudentProfile.Image = CType(resources.GetObject("btnStudentProfile.Image"), System.Drawing.Image)
        Me.btnStudentProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentProfile.Location = New System.Drawing.Point(0, 80)
        Me.btnStudentProfile.Name = "btnStudentProfile"
        Me.btnStudentProfile.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnStudentProfile.Size = New System.Drawing.Size(230, 50)
        Me.btnStudentProfile.TabIndex = 1
        Me.btnStudentProfile.Text = "   Student Profiles"
        Me.btnStudentProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudentProfile.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelLogo.Controls.Add(Me.PictureBox1)
        Me.panelLogo.Controls.Add(Me.Label2)
        Me.panelLogo.Controls.Add(Me.Label1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(230, 80)
        Me.panelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(136, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.30189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(86, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "iStudent"
        '
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panelDesktop.Controls.Add(Me.clockLab2)
        Me.panelDesktop.Controls.Add(Me.clockLab)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(230, 0)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(794, 700)
        Me.panelDesktop.TabIndex = 1
        '
        'clockLab2
        '
        Me.clockLab2.AutoSize = True
        Me.clockLab2.Font = New System.Drawing.Font("Century Gothic", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockLab2.ForeColor = System.Drawing.SystemColors.Control
        Me.clockLab2.Location = New System.Drawing.Point(558, 619)
        Me.clockLab2.Name = "clockLab2"
        Me.clockLab2.Size = New System.Drawing.Size(58, 23)
        Me.clockLab2.TabIndex = 1
        Me.clockLab2.Text = "Time "
        '
        'clockLab
        '
        Me.clockLab.AutoSize = True
        Me.clockLab.Font = New System.Drawing.Font("Century Gothic", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockLab.ForeColor = System.Drawing.SystemColors.Control
        Me.clockLab.Location = New System.Drawing.Point(558, 582)
        Me.clockLab.Name = "clockLab"
        Me.clockLab.Size = New System.Drawing.Size(54, 23)
        Me.clockLab.TabIndex = 0
        Me.clockLab.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iStudent Administrator"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        Me.panelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnStudentProfile As Button
    Friend WithEvents btnSubjectsList As Button
    Friend WithEvents btnStudentGrades As Button
    Friend WithEvents btnStudentRecords As Button
    Friend WithEvents btnManageAdmin As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents clockLab As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents clockLab2 As Label
    Friend WithEvents btnGWA As Button
    Friend WithEvents btnManageUsers As Button
End Class
