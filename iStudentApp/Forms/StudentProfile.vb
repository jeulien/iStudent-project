Imports System.Data.SqlClient
Imports System.IO
Public Class StudentProfile

    'Dim con As New SqlConnection("Data Source=DESKTOP-64RJ8U5;Initial Catalog=iStudentDB;Integrated Security=True")
    Dim con As New SqlConnection("Data Source=SQL5107.site4now.net;Initial Catalog=db_a83e48_istudentdb;User Id=db_a83e48_istudentdb_admin;Password=lula0224")

    'COLOR PANEL CHANGES 
    Private Sub txtLastNm_Enter(sender As Object, e As EventArgs) Handles txtLastNm.Enter
        panelLastNm.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtLastNm_Leave(sender As Object, e As EventArgs) Handles txtLastNm.Leave
        panelLastNm.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtFirstNm_Enter(sender As Object, e As EventArgs) Handles txtFirstNm.Enter
        panelFirstNm.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtFirstNm_Leave(sender As Object, e As EventArgs) Handles txtFirstNm.Leave
        panelFirstNm.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtMiddleNm_Enter(sender As Object, e As EventArgs) Handles txtMiddleNm.Enter
        panelMidNm.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtMiddleNm_Leave(sender As Object, e As EventArgs) Handles txtMiddleNm.Leave
        panelMidNm.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub dateBirth_Enter(sender As Object, e As EventArgs) Handles dateBirth.Enter
        panelBirthdate.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub dateBirth_Leave(sender As Object, e As EventArgs) Handles dateBirth.Leave
        panelBirthdate.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbGender_Enter(sender As Object, e As EventArgs) Handles cmbGender.Enter
        panelGender.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbGender_Leave(sender As Object, e As EventArgs) Handles cmbGender.Leave
        panelGender.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtStudContact_Enter(sender As Object, e As EventArgs) Handles txtStudContact.Enter
        panelContact.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtStudContact_Leave(sender As Object, e As EventArgs) Handles txtStudContact.Leave
        panelContact.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtStudAddress_Enter(sender As Object, e As EventArgs) Handles txtStudAddress.Enter
        panelAddress.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtStudAddress_Leave(sender As Object, e As EventArgs) Handles txtStudAddress.Leave
        panelAddress.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtStudNo_Enter(sender As Object, e As EventArgs) Handles txtStudNo.Enter
        panelStudNo.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtStudNo_Leave(sender As Object, e As EventArgs) Handles txtStudNo.Leave
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbStudType_Enter(sender As Object, e As EventArgs) Handles cmbStudType.Enter
        panelStudType.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbStudType_Leave(sender As Object, e As EventArgs) Handles cmbStudType.Leave
        panelStudType.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbCourse_Enter(sender As Object, e As EventArgs) Handles cmbCourse.Enter
        panelCourse.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbCourse_Leave(sender As Object, e As EventArgs) Handles cmbCourse.Leave
        panelCourse.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbYear_Enter(sender As Object, e As EventArgs) Handles cmbYear.Enter
        panelYear.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbYear_Leave(sender As Object, e As EventArgs) Handles cmbYear.Leave
        panelYear.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtGuardNm_Enter(sender As Object, e As EventArgs) Handles txtGuardNm.Enter
        panelName.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtGuardNm_Leave(sender As Object, e As EventArgs) Handles txtGuardNm.Leave
        panelName.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtGuardAddress_Enter(sender As Object, e As EventArgs) Handles txtGuardAddress.Enter
        panelAddress2.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtGuardAddress_Leave(sender As Object, e As EventArgs) Handles txtGuardAddress.Leave
        panelAddress2.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtGuardContact_Enter(sender As Object, e As EventArgs) Handles txtGuardContact.Enter
        panelContact2.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtGuardContact_Leave(sender As Object, e As EventArgs) Handles txtGuardContact.Leave
        panelContact2.BackColor = Color.FromArgb(61, 61, 86)
    End Sub

    Private Sub StudentProfile_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelLastNm.BackColor = Color.FromArgb(61, 61, 86)
        panelFirstNm.BackColor = Color.FromArgb(61, 61, 86)
        panelMidNm.BackColor = Color.FromArgb(61, 61, 86)
        panelBirthdate.BackColor = Color.FromArgb(61, 61, 86)
        panelGender.BackColor = Color.FromArgb(61, 61, 86)
        panelContact.BackColor = Color.FromArgb(61, 61, 86)
        panelAddress.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
        panelStudType.BackColor = Color.FromArgb(61, 61, 86)
        panelCourse.BackColor = Color.FromArgb(61, 61, 86)
        panelYear.BackColor = Color.FromArgb(61, 61, 86)
        panelName.BackColor = Color.FromArgb(61, 61, 86)
        panelAddress2.BackColor = Color.FromArgb(61, 61, 86)
        panelContact2.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub

    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        txtLastNm.Enabled = False
        txtFirstNm.Enabled = False
        txtMiddleNm.Enabled = False
        dateBirth.Enabled = False
        cmbGender.Enabled = False
        txtStudContact.Enabled = False
        txtStudAddress.Enabled = False
        txtStudNo.Enabled = False
        cmbStudType.Enabled = False
        cmbCourse.Enabled = False
        cmbYear.Enabled = False
        txtGuardNm.Enabled = False
        txtGuardAddress.Enabled = False
        txtGuardContact.Enabled = False

        bind1()
    End Sub

    Private Sub bind1()
        'studentProfileView Table
        Dim command As New SqlCommand("Select * from studentProfiles order by studentNumber Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        studentProfileView.AllowUserToAddRows = False
        studentProfileView.RowTemplate.Height = 50
        studentProfileView.DataSource = table
    End Sub

    Private Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From studentProfiles Where Concat(studentNumber,lastName,firstName,gender,studentType,course,year) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        studentProfileView.DataSource = tableFill
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProfile.TextChanged
        FilterData(txtSearchProfile.Text)
    End Sub

    Private Sub studentProfileView_Click(sender As Object, e As EventArgs) Handles studentProfileView.Click
        txtStudNo.Text = studentProfileView.CurrentRow.Cells(0).Value
        txtLastNm.Text = studentProfileView.CurrentRow.Cells(1).Value
        txtFirstNm.Text = studentProfileView.CurrentRow.Cells(2).Value
        txtMiddleNm.Text = studentProfileView.CurrentRow.Cells(3).Value
        dateBirth.Value = studentProfileView.CurrentRow.Cells(4).Value
        cmbGender.Text = studentProfileView.CurrentRow.Cells(5).Value
        txtStudContact.Text = studentProfileView.CurrentRow.Cells(6).Value
        txtStudAddress.Text = studentProfileView.CurrentRow.Cells(7).Value
        cmbStudType.Text = studentProfileView.CurrentRow.Cells(8).Value
        cmbCourse.Text = studentProfileView.CurrentRow.Cells(9).Value
        cmbYear.Text = studentProfileView.CurrentRow.Cells(10).Value
        txtGuardNm.Text = studentProfileView.CurrentRow.Cells(11).Value
        txtGuardContact.Text = studentProfileView.CurrentRow.Cells(12).Value
        txtGuardAddress.Text = studentProfileView.CurrentRow.Cells(13).Value
    End Sub

    Private Sub studentProfileView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentProfileView.CellClick
        txtStudNo.Enabled = False
    End Sub

    Private Sub btnAccessProfile_Click(sender As Object, e As EventArgs) Handles btnAccessProfile.Click
        If txtStudNo.Text = "" Then
            txtLastNm.Enabled = False
            txtFirstNm.Enabled = False
            txtMiddleNm.Enabled = False
            dateBirth.Enabled = False
            cmbGender.Enabled = False
            txtStudContact.Enabled = False
            txtStudAddress.Enabled = False
            txtStudNo.Enabled = False
            cmbStudType.Enabled = False
            cmbCourse.Enabled = False
            cmbYear.Enabled = False
            txtGuardNm.Enabled = False
            txtGuardAddress.Enabled = False
            txtGuardContact.Enabled = False
        Else
            txtLastNm.Enabled = True
            txtFirstNm.Enabled = True
            txtMiddleNm.Enabled = True
            dateBirth.Enabled = True
            cmbGender.Enabled = True
            txtStudContact.Enabled = True
            txtStudAddress.Enabled = True
            txtStudNo.Enabled = False
            cmbStudType.Enabled = True
            cmbCourse.Enabled = True
            cmbYear.Enabled = True
            txtGuardNm.Enabled = True
            txtGuardAddress.Enabled = True
            txtGuardContact.Enabled = True
        End If
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        Dim command As New SqlCommand("Insert into studentProfiles(studentNumber,lastName,firstName,middleName,birthdate,gender,studentContact,address,studentType,course,year,guardianName,guardianContact,guardianAddress)values(@studentNumber,@lastName,@firstName,@middleName,@birthdate,@gender,@studentContact,@address,@studentType,@course,@year,@guardianName,@guardianContact,@guardianAddress)", con)

        command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = txtStudNo.Text
        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = txtLastNm.Text
        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = txtFirstNm.Text
        command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value = txtMiddleNm.Text
        command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = dateBirth.Value.ToShortDateString
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = cmbGender.Text
        command.Parameters.Add("@studentContact", SqlDbType.NVarChar).Value = txtStudContact.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtStudAddress.Text
        command.Parameters.Add("@studentType", SqlDbType.NChar).Value = cmbStudType.Text
        command.Parameters.Add("@course", SqlDbType.NVarChar).Value = cmbCourse.Text
        command.Parameters.Add("@year", SqlDbType.NChar).Value = cmbYear.Text
        command.Parameters.Add("@guardianName", SqlDbType.NVarChar).Value = txtGuardNm.Text
        command.Parameters.Add("@guardianContact", SqlDbType.NVarChar).Value = txtGuardContact.Text
        command.Parameters.Add("@guardianAddress", SqlDbType.NVarChar).Value = txtGuardAddress.Text

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If txtStudNo.Text = "" Then
            MessageBox.Show("Student Number Required.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtLastNm.Text = "" Then
            MessageBox.Show("Please input Last Name.", "Empty Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtFirstNm.Text = "" Then
            MessageBox.Show("Please input First Name.", "Empty Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtMiddleNm.Text = "" Then
            MessageBox.Show("Please input Middle Name.", "Empty Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudType.Text = "" Then
            MessageBox.Show("Please input Student Type.", "Empty Type Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbCourse.Text = "" Then
            MessageBox.Show("Please input Student Course.", "Empty Course Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbYear.Text = "" Then
            MessageBox.Show("Please input Student Year.", "Empty Year Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to save profile?", "Save Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                command.ExecuteNonQuery()
                MessageBox.Show("Student Profile Added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLastNm.Text = ""
                txtFirstNm.Text = ""
                txtMiddleNm.Text = ""
                dateBirth.Text = ""
                cmbGender.Text = ""
                txtStudContact.Text = ""
                txtStudAddress.Text = ""
                txtStudNo.Text = ""
                cmbStudType.Text = ""
                cmbCourse.Text = ""
                cmbYear.Text = ""
                txtGuardNm.Text = ""
                txtGuardContact.Text = ""
                txtGuardAddress.Text = ""
                con.Close()
                bind1()
            Else
                MessageBox.Show("Student Profile Not Saved.", "Not Saved", MessageBoxButtons.OK)
            End If
        Catch ex As SqlException
            If txtStudNo.Enabled = False Then
                MessageBox.Show("Please select UPDATE option to update the current student profile.", "Select UPDATE to Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Student Number Already Exists. Enter new number.", "Duplicate Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudNo.Text = ""
                Exit Try
            End If
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        Dim command As New SqlCommand("UPDATE studentProfiles SET lastName = @lastName,firstName = @firstName,middleName = @middleName,birthdate = @birthdate,gender = @gender,studentContact = @studentContact,address = @address,studentType = @studentType,course = @course,year = @year,guardianName = @guardianName,guardianContact = @guardianContact,guardianAddress = @guardianAddress WHERE studentNumber = @studentNumber", con)

        command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = txtStudNo.Text
        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = txtLastNm.Text
        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = txtFirstNm.Text
        command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value = txtMiddleNm.Text
        command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = dateBirth.Value.ToShortDateString
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = cmbGender.Text
        command.Parameters.Add("@studentContact", SqlDbType.NVarChar).Value = txtStudContact.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtStudAddress.Text
        command.Parameters.Add("@studentType", SqlDbType.NChar).Value = cmbStudType.Text
        command.Parameters.Add("@course", SqlDbType.NVarChar).Value = cmbCourse.Text
        command.Parameters.Add("@year", SqlDbType.NChar).Value = cmbYear.Text
        command.Parameters.Add("@guardianName", SqlDbType.NVarChar).Value = txtGuardNm.Text
        command.Parameters.Add("@guardianContact", SqlDbType.NVarChar).Value = txtGuardContact.Text
        command.Parameters.Add("@guardianAddress", SqlDbType.NVarChar).Value = txtGuardAddress.Text


        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update profile?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Student Profile Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLastNm.Text = ""
            txtFirstNm.Text = ""
            txtMiddleNm.Text = ""
            dateBirth.Text = ""
            cmbGender.Text = ""
            txtStudContact.Text = ""
            txtStudAddress.Text = ""
            txtStudNo.Text = ""
            cmbStudType.Text = ""
            cmbCourse.Text = ""
            cmbYear.Text = ""
            txtGuardNm.Text = ""
            txtGuardAddress.Text = ""
            txtGuardContact.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Student Profile Not Updated.", "Not Updated", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnDeleteProfile_Click(sender As Object, e As EventArgs) Handles btnDeleteProfile.Click
        Dim delete As String = txtStudNo.Text

        Dim command As New SqlCommand("DELETE from studentProfiles WHERE studentNumber = @studentNumber", con)

        command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = txtStudNo.Text

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete profile?", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Student Profile Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLastNm.Text = ""
            txtFirstNm.Text = ""
            txtMiddleNm.Text = ""
            dateBirth.Text = ""
            cmbGender.Text = ""
            txtStudContact.Text = ""
            txtStudAddress.Text = ""
            txtStudNo.Text = ""
            cmbStudType.Text = ""
            cmbCourse.Text = ""
            cmbYear.Text = ""
            txtGuardNm.Text = ""
            txtGuardAddress.Text = ""
            txtGuardContact.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Student Profile Retained.", "Not Deleted", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnAddProfile_Click(sender As Object, e As EventArgs) Handles btnAddProfile.Click
        Dim result As DialogResult = MessageBox.Show("Enter new student profile data? (This will clear inputs if there are any).", "Enter New Student Profile Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtLastNm.Text = ""
            txtFirstNm.Text = ""
            txtMiddleNm.Text = ""
            dateBirth.Text = ""
            cmbGender.Text = ""
            txtStudContact.Text = ""
            txtStudAddress.Text = ""
            txtStudNo.Text = ""
            cmbStudType.Text = ""
            cmbCourse.Text = ""
            cmbYear.Text = ""
            txtGuardNm.Text = ""
            txtGuardAddress.Text = ""
            txtGuardContact.Text = ""
            txtLastNm.Enabled = True
            txtFirstNm.Enabled = True
            txtMiddleNm.Enabled = True
            dateBirth.Enabled = True
            cmbGender.Enabled = True
            txtStudContact.Enabled = True
            txtStudAddress.Enabled = True
            txtStudNo.Enabled = True
            cmbStudType.Enabled = True
            cmbCourse.Enabled = True
            cmbYear.Enabled = True
            txtGuardNm.Enabled = True
            txtGuardAddress.Enabled = True
            txtGuardContact.Enabled = True
        Else
            MessageBox.Show("Inputs and Profile Retained.", "Inputs/Profile", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        TableFormProfiles.Show()
    End Sub
End Class