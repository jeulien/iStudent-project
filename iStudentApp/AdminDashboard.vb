Public Class AdminDashboard
    Private currentChildForm As Form

    Private Sub clockLab_Click(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Displays date and time in desktop panel
        clockLab.Text = Format(Now, "MMM-dd-yyyy")
        clockLab2.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only selected form 
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'bring form forward
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(childForm)
        panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        OpenChildForm(New StudentProfile)
    End Sub

    Private Sub btnSubjectsList_Click(sender As Object, e As EventArgs) Handles btnSubjectsList.Click
        OpenChildForm(New SubjectsList)
    End Sub

    Private Sub btnStudentRecords_Click(sender As Object, e As EventArgs) Handles btnStudentRecords.Click
        OpenChildForm(New StudentRecords)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(New Dashboard)
    End Sub

    Private Sub btnStudentGrades_Click(sender As Object, e As EventArgs) Handles btnStudentGrades.Click
        OpenChildForm(New StudentGrades)
    End Sub
    Private Sub btnGWA_Click(sender As Object, e As EventArgs) Handles btnGWA.Click
        OpenChildForm(New GWARecords)
    End Sub
    Private Sub btnManageAdmin_Click(sender As Object, e As EventArgs) Handles btnManageAdmin.Click
        OpenChildForm(New ManageAdmin)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        OpenChildForm(New ManageUsers)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) 
        OpenChildForm(New Users)
    End Sub
End Class