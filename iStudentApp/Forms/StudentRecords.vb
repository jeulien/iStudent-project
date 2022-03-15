Imports System.Data.SqlClient
Imports System.IO
Public Class StudentRecords

    'COLOR PANEL CHANGES
    Private Sub txtSchoolYr_Enter(sender As Object, e As EventArgs) Handles txtSchoolYr.Enter
        panelSchool.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtSchoolYr_Leave(sender As Object, e As EventArgs) Handles txtSchoolYr.Leave
        panelSchool.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbSemester_Enter(sender As Object, e As EventArgs) Handles cmbSemester.Enter
        panelSem.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbSemester_Leave(sender As Object, e As EventArgs) Handles cmbSemester.Leave
        panelSem.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbSubCode_Enter(sender As Object, e As EventArgs) Handles cmbSubCode.Enter
        panelSubCod.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbSubCode_Leave(sender As Object, e As EventArgs) Handles cmbSubCode.Leave
        panelSubCod.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbSubTitle_Enter(sender As Object, e As EventArgs) Handles cmbSubTitle.Enter
        panelSubTitle.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbSubTitle_Leave(sender As Object, e As EventArgs) Handles cmbSubTitle.Leave
        panelSubTitle.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbUnits_Enter(sender As Object, e As EventArgs) Handles cmbUnits.Enter
        panelUnits.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbUnits_Leave(sender As Object, e As EventArgs) Handles cmbUnits.Leave
        panelUnits.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbStudNo_Enter(sender As Object, e As EventArgs) Handles cmbStudNo.Enter
        panelStudNo.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbStudNo_Leave(sender As Object, e As EventArgs) Handles cmbStudNo.Leave
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbStudNm_Enter(sender As Object, e As EventArgs) Handles cmbStudNm.Enter
        panelStudNm.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbStudNm_Leave(sender As Object, e As EventArgs) Handles cmbStudNm.Leave
        panelStudNm.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub StudentRecords_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelSchool.BackColor = Color.FromArgb(61, 61, 86)
        panelSem.BackColor = Color.FromArgb(61, 61, 86)
        panelSubCod.BackColor = Color.FromArgb(61, 61, 86)
        panelSubTitle.BackColor = Color.FromArgb(61, 61, 86)
        panelUnits.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNm.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub

    Private Sub StudentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        txtSchoolYr.Enabled = False
        cmbSemester.Enabled = False
        cmbSubCode.Enabled = False
        cmbSubTitle.Enabled = False
        cmbUnits.Enabled = False
        cmbStudNo.Enabled = False
        cmbStudNm.Enabled = False

        bind1()

        Dim command As New SqlCommand("Select * From subjectList", con)
        Dim adapter As New SqlDataAdapter(command)

        con.Open()
        Dim strsql As New SqlCommand("Select distinct subjectCode from subjectList", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSubCode.Items.Clear()
        While myreader.Read()
            cmbSubCode.Items.Add(myreader("subjectCode"))
        End While
        con.Close()

        Dim READER As SqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "Select Distinct [studentNumber] From studentProfiles"
            command = New SqlCommand(query, con)
            READER = command.ExecuteReader
            While READER.Read
                Dim sSub = READER.GetString(0)
                cmbStudNo.Items.Add(sSub)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbSubCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubCode.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("Select Distinct subjectTitle From subjectList Where subjectCode='" + cmbSubCode.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSubTitle.Items.Clear()
        While myreader.Read()
            cmbSubTitle.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()

        con.Open()
        Dim strsql2 As New SqlCommand("Select Distinct Units from subjectList Where subjectCode='" + cmbSubCode.Text + "'", con)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbUnits.Items.Clear()
        While myreader2.Read()
            cmbUnits.Items.Add(myreader2("units"))
        End While
        con.Close()
    End Sub
    Private Sub bind1()
        'studentRecordView Table
        Dim command As New SqlCommand("Select * from studentRecord order by schoolyear,studentNumber Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        studentRecordView.AllowUserToAddRows = False
        studentRecordView.RowTemplate.Height = 50
        studentRecordView.DataSource = table
    End Sub

    Private Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From studentRecord Where Concat(studentNumber,subjectCode,schoolYear,semester,subjectTitle,studentName) like '%" & valueToSearch & "%' order by schoolYear,studentNumber"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        studentRecordView.DataSource = tableFill
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRecord.TextChanged
        FilterData(txtSearchRecord.Text)
    End Sub

    Private Sub studentRecordView_Click(sender As Object, e As EventArgs) Handles studentRecordView.Click
        txtSchoolYr.Text = studentRecordView.CurrentRow.Cells(0).Value
        cmbSemester.Text = studentRecordView.CurrentRow.Cells(1).Value
        cmbStudNo.Text = studentRecordView.CurrentRow.Cells(2).Value
        cmbStudNm.Text = studentRecordView.CurrentRow.Cells(3).Value
        cmbSubCode.Text = studentRecordView.CurrentRow.Cells(4).Value
        cmbSubTitle.Text = studentRecordView.CurrentRow.Cells(5).Value
        cmbUnits.Text = studentRecordView.CurrentRow.Cells(6).Value
    End Sub

    Private Sub studentRecordView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentRecordView.CellClick
        txtSchoolYr.Enabled = False
        cmbSemester.Enabled = False
        cmbSubCode.Enabled = False
        cmbSubTitle.Enabled = False
        cmbUnits.Enabled = False
        cmbStudNo.Enabled = False
        cmbStudNm.Enabled = False
    End Sub

    Private Sub btnAccessRecord_Click(sender As Object, e As EventArgs) Handles btnAccessRecord.Click
        If cmbSubCode.Text = "" And cmbStudNo.Text = "" Then
            txtSchoolYr.Enabled = False
            cmbSemester.Enabled = False
            cmbSubCode.Enabled = False
            cmbSubTitle.Enabled = False
            cmbUnits.Enabled = False
            cmbStudNo.Enabled = False
            cmbStudNm.Enabled = False
        Else
            txtSchoolYr.Enabled = False
            cmbSemester.Enabled = True
            cmbSubCode.Enabled = False
            cmbSubTitle.Enabled = False
            cmbUnits.Enabled = False
            cmbStudNo.Enabled = False
            cmbStudNm.Enabled = False
        End If
    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        con.Open()

        If txtSchoolYr.Text = "" Then
            MessageBox.Show("School Year Required.", "Empty School Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubCode.Text = "" Then
            MessageBox.Show("Please input Subject Code.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNo.Text = "" Then
            MessageBox.Show("Please input Student Number.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Please input the Semester.", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNm.Text = "" Then
            MessageBox.Show("Please input Student Name.", "Empty Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim query As String = "SELECT * FROM studentRecord WHERE subjectCode=@subjectCode AND studentNumber=@studentNumber AND schoolYear=@schoolYear AND semester=@semester"
            Dim command As SqlCommand = New SqlCommand(query, con)
            command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = txtSchoolYr.Text
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text


            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    ' User already exists
                    MsgBox("Student Record Already Exists.", MsgBoxStyle.Exclamation, "Already Exists.")
                ElseIf cmbStudNm.Enabled = False Then
                    MessageBox.Show("Please select UPDATE option to update the current student record.", "Select UPDATE to Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' User does not exist, add them
                    Dim command2 As New SqlCommand("Insert into studentRecord(schoolYear,semester,studentNumber,studentName,subjectCode,subjectTitle,units)values(@schoolYear,@semester,@studentNumber,@studentName,@subjectCode,@subjectTitle,@units)", con)

                    command2.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = txtSchoolYr.Text
                    command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
                    command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
                    command2.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = cmbStudNm.Text
                    command2.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
                    command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = cmbSubTitle.Text
                    command2.Parameters.Add("@units", SqlDbType.NVarChar).Value = cmbUnits.Text
                    command2.ExecuteNonQuery()
                    MsgBox("Records Successfully Added.", MsgBoxStyle.Information, "Student Record Added")
                    bind1()

                End If
            End Using

            con.Close()

        End If
    End Sub

    Private Sub cmbStudNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudNo.SelectedIndexChanged
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        con.Open()

        command = New SqlCommand("Select Distinct lastName,firstName from studentProfiles Where studentNumber='" + cmbStudNo.Text + "'", con)
        reader = command.ExecuteReader

        cmbStudNm.Items.Clear()
        While reader.Read
            cmbStudNm.Items.Add("" & reader(0) & "" & " , " & "" & reader(1) & "")
            cmbStudNm.ValueMember = reader(0)
        End While
        con.Close()
    End Sub

    Private Sub btnClearSub_Click(sender As Object, e As EventArgs) Handles btnClearSub.Click
        cmbSubCode.Text = ""
        cmbSubTitle.Text = ""
        cmbUnits.Text = ""
    End Sub

    Private Sub btnClearStud_Click(sender As Object, e As EventArgs) Handles btnClearStud.Click
        cmbStudNo.Text = ""
        cmbStudNm.Text = ""
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim result As DialogResult = MessageBox.Show("Enter new student class record? (This will clear inputs if there are any).", "Enter New Student Class Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtSchoolYr.Text = ""
            cmbSemester.Text = ""
            cmbSubCode.Text = ""
            cmbSubTitle.Text = ""
            cmbUnits.Text = ""
            cmbStudNo.Text = ""
            cmbStudNm.Text = ""
            txtSchoolYr.Enabled = True
            cmbSemester.Enabled = True
            cmbSubCode.Enabled = True
            cmbSubTitle.Enabled = True
            cmbUnits.Enabled = True
            cmbStudNo.Enabled = True
            cmbStudNm.Enabled = True
        Else
            MessageBox.Show("Inputs and Profile Retained.", "Inputs/Profile", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        If txtSchoolYr.Text = "" Then
            MessageBox.Show("School Year Required.", "Empty School Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubCode.Text = "" Then
            MessageBox.Show("Please input Subject Code.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNo.Text = "" Then
            MessageBox.Show("Please input Student Number.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Please input the Semester.", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNm.Text = "" Then
            MessageBox.Show("Please input Student Name.", "Empty Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            Dim command As New SqlCommand("UPDATE studentRecord SET semester = @semester WHERE studentNumber = @studentNumber AND subjectCode = @subjectCode AND schoolYear = @schoolYear", con)

            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
            command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = txtSchoolYr.Text

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update student record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                command.ExecuteNonQuery()
                MessageBox.Show("Student Record Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSchoolYr.Text = ""
                cmbSemester.Text = ""
                cmbSubCode.Text = ""
                cmbSubTitle.Text = ""
                cmbUnits.Text = ""
                cmbStudNo.Text = ""
                cmbStudNm.Text = ""
                con.Close()
                bind1()
            Else
                MessageBox.Show("Student Record Not Updated.", "Not Updated", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        If txtSchoolYr.Text = "" Then
            MessageBox.Show("School Year Required.", "Empty School Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubCode.Text = "" Then
            MessageBox.Show("Please input Subject Code.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNo.Text = "" Then
            MessageBox.Show("Please input Student Number.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Please input the Semester.", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNm.Text = "" Then
            MessageBox.Show("Please input Student Name.", "Empty Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            Dim delete As String = cmbStudNo.Text

            Dim command As New SqlCommand("DELETE from studentRecord WHERE studentNumber = @studentNumber AND subjectCode = @subjectCode AND schoolYear = @schoolYear AND semester = @semester", con)

            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
            command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = txtSchoolYr.Text

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                command.ExecuteNonQuery()
                MessageBox.Show("Student Record Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSchoolYr.Text = ""
                cmbSemester.Text = ""
                cmbSubCode.Text = ""
                cmbSubTitle.Text = ""
                cmbUnits.Text = ""
                cmbStudNo.Text = ""
                cmbStudNm.Text = ""
                con.Close()
                bind1()
            Else
                MessageBox.Show("Student Record Retained.", "Not Deleted", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        TableFormStudentRecords.Show()
    End Sub
End Class
