Imports System.Data.SqlClient
Imports System.IO
Public Class StudentGrades

    'COLOR PANEL CHANGES
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
    Private Sub cmbSchoolYr_Enter(sender As Object, e As EventArgs) Handles cmbSchoolYr.Enter
        panelSchool.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbSchoolYr_Leave(sender As Object, e As EventArgs) Handles cmbSchoolYr.Leave
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
    Private Sub cmbPrelims_Enter(sender As Object, e As EventArgs) Handles cmbPrelims.Enter
        panelPrelims.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbPrelims_Leave(sender As Object, e As EventArgs) Handles cmbPrelims.Leave
        panelPrelims.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbMidterms_Enter(sender As Object, e As EventArgs) Handles cmbMidterms.Enter
        panelMidterms.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbMidterms_Leave(sender As Object, e As EventArgs) Handles cmbMidterms.Leave
        panelMidterms.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbFinals_Enter(sender As Object, e As EventArgs) Handles cmbFinals.Enter
        panelFinals.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbFinals_Leave(sender As Object, e As EventArgs) Handles cmbFinals.Leave
        panelFinals.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbAve_Enter(sender As Object, e As EventArgs) Handles cmbAve.Enter
        panelAverage.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbAve_Leave(sender As Object, e As EventArgs) Handles cmbAve.Leave
        panelAverage.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbGrade_Enter(sender As Object, e As EventArgs) Handles cmbGrade.Enter
        panelGrade.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbGrade_Leave(sender As Object, e As EventArgs) Handles cmbGrade.Leave
        panelGrade.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub StudentGrades_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelSchool.BackColor = Color.FromArgb(61, 61, 86)
        panelSem.BackColor = Color.FromArgb(61, 61, 86)
        panelSubCod.BackColor = Color.FromArgb(61, 61, 86)
        panelSubTitle.BackColor = Color.FromArgb(61, 61, 86)
        panelUnits.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNm.BackColor = Color.FromArgb(61, 61, 86)
        panelPrelims.BackColor = Color.FromArgb(61, 61, 86)
        panelMidterms.BackColor = Color.FromArgb(61, 61, 86)
        panelFinals.BackColor = Color.FromArgb(61, 61, 86)
        panelAverage.BackColor = Color.FromArgb(61, 61, 86)
        panelGrade.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub
    Private Sub StudentGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        cmbStudNo.Enabled = False
        cmbStudNm.Enabled = False
        cmbSchoolYr.Enabled = False
        cmbSemester.Enabled = False
        cmbSubCode.Enabled = False
        cmbSubTitle.Enabled = False
        cmbUnits.Enabled = False
        cmbPrelims.Enabled = False
        cmbMidterms.Enabled = False
        cmbFinals.Enabled = False
        cmbAve.Enabled = False
        cmbGrade.Enabled = False

        bind1()

        con.Open()
        Dim strsql As New SqlCommand("select distinct studentNumber from studentRecord", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbStudNo.Items.Clear()
        While myreader.Read()
            cmbStudNo.Items.Add(myreader("studentNumber"))
        End While
        con.Close()

    End Sub

    Private Sub bind1()
        'studentGradeView Table
        Dim command As New SqlCommand("Select * from gradeRecord order by studentNumber Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        studentGradeView.AllowUserToAddRows = False
        studentGradeView.RowTemplate.Height = 50
        studentGradeView.DataSource = table
    End Sub

    Private Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From gradeRecords Where Concat(studentNumber,subjectCode,schoolYear,semester,subjectTitle) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        studentGradeView.DataSource = tableFill
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchGrade.TextChanged
        FilterData(txtSearchGrade.Text)
    End Sub

    Private Sub studentGradeView_Click(sender As Object, e As EventArgs) Handles studentGradeView.Click
        cmbSchoolYr.Text = studentGradeView.CurrentRow.Cells(0).Value
        cmbSemester.Text = studentGradeView.CurrentRow.Cells(1).Value
        cmbSubTitle.Text = studentGradeView.CurrentRow.Cells(2).Value
        cmbUnits.Text = studentGradeView.CurrentRow.Cells(3).Value
        cmbSubCode.Text = studentGradeView.CurrentRow.Cells(4).Value
        cmbStudNo.Text = studentGradeView.CurrentRow.Cells(5).Value
        cmbStudNm.Text = studentGradeView.CurrentRow.Cells(6).Value

        cmbPrelims.Text = studentGradeView.CurrentRow.Cells(7).Value
        cmbMidterms.Text = studentGradeView.CurrentRow.Cells(8).Value
        cmbFinals.Text = studentGradeView.CurrentRow.Cells(9).Value
        cmbAve.Text = studentGradeView.CurrentRow.Cells(10).Value
        cmbGrade.Text = studentGradeView.CurrentRow.Cells(11).Value
    End Sub

    Private Sub studentGradeView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentGradeView.CellClick
        cmbSchoolYr.Enabled = False
        cmbSemester.Enabled = False
        cmbSubCode.Enabled = False
        cmbSubTitle.Enabled = False
        cmbUnits.Enabled = False
        cmbStudNo.Enabled = False
        cmbStudNm.Enabled = False
        cmbPrelims.Enabled = False
        cmbMidterms.Enabled = False
        cmbFinals.Enabled = False
        cmbAve.Enabled = False
        cmbGrade.Enabled = False
    End Sub

    Private Sub btnAccessGrade_Click(sender As Object, e As EventArgs) Handles btnAccessGrade.Click
        If cmbStudNm.Text = "" Then
            cmbStudNo.Enabled = False
            cmbStudNm.Enabled = False
            cmbSchoolYr.Enabled = False
            cmbSemester.Enabled = False
            cmbSubCode.Enabled = False
            cmbSubTitle.Enabled = False
            cmbUnits.Enabled = False
            cmbPrelims.Enabled = False
            cmbMidterms.Enabled = False
            cmbFinals.Enabled = False
            cmbAve.Enabled = False
            cmbGrade.Enabled = False
        Else
            cmbStudNo.Enabled = False
            cmbStudNm.Enabled = False
            cmbSchoolYr.Enabled = False
            cmbSemester.Enabled = False
            cmbSubCode.Enabled = False
            cmbSubTitle.Enabled = False
            cmbUnits.Enabled = False
            cmbPrelims.Enabled = True
            cmbMidterms.Enabled = True
            cmbFinals.Enabled = True
            cmbAve.Enabled = True
            cmbGrade.Enabled = True
        End If
    End Sub

    Private Sub btnAddGrade_Click(sender As Object, e As EventArgs) Handles btnAddGrade.Click
        Dim result As DialogResult = MessageBox.Show("Enter a student grade record? (This will clear inputs if there are any).", "Enter Student Class Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            cmbSchoolYr.Text = ""
            cmbSemester.Text = ""
            cmbSubCode.Text = ""
            cmbSubTitle.Text = ""
            cmbUnits.Text = ""
            cmbStudNo.Text = ""
            cmbStudNm.Text = ""
            cmbUnits.Text = ""
            cmbPrelims.Text = ""
            cmbMidterms.Text = ""
            cmbFinals.Text = ""
            cmbAve.Text = ""
            cmbGrade.Text = ""
            cmbSchoolYr.Enabled = True
            cmbSemester.Enabled = True
            cmbSubCode.Enabled = True
            cmbSubTitle.Enabled = True
            cmbUnits.Enabled = True
            cmbStudNo.Enabled = True
            cmbStudNm.Enabled = True
            cmbUnits.Enabled = True
            cmbPrelims.Enabled = True
            cmbMidterms.Enabled = True
            cmbFinals.Enabled = True
            cmbAve.Enabled = True
            cmbGrade.Enabled = True
        Else
            MessageBox.Show("No New Record. Inputs and Profile Retained.", "Inputs/Profile", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmbStudNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudNo.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("select distinct studentName from studentRecord where studentNumber='" + cmbStudNo.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbStudNm.Items.Clear()
        While myreader.Read()
            cmbStudNm.Items.Add(myreader("studentName"))
        End While
        con.Close()

        con.Open()
        Dim strsql2 As New SqlCommand("select distinct schoolYear from studentRecord where studentNumber='" + cmbStudNo.Text + "'", con)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbSchoolYr.Items.Clear()
        While myreader2.Read()
            cmbSchoolYr.Items.Add(myreader2("schoolYear"))
        End While
        con.Close()
    End Sub

    Private Sub cmbSchoolYr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchoolYr.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("select distinct semester from studentRecord where studentNumber='" + cmbStudNo.Text + "' and schoolYear='" + cmbSchoolYr.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSemester.Items.Clear()
        While myreader.Read()
            cmbSemester.Items.Add(myreader("semester"))
        End While
        con.Close()
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("select distinct subjectCode from studentRecord where studentNumber='" + cmbStudNo.Text + "' and schoolYear='" + cmbSchoolYr.Text + "' and semester='" + cmbSemester.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSubCode.Items.Clear()
        While myreader.Read()
            cmbSubCode.Items.Add(myreader("subjectCode"))
        End While
        con.Close()
    End Sub

    Private Sub cmbSubCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubCode.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("select distinct subjectTitle from studentRecord where subjectCode='" + cmbSubCode.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSubTitle.Items.Clear()
        While myreader.Read()
            cmbSubTitle.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub

    Private Sub cmbSubTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubTitle.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("select distinct units from studentRecord where subjectCode='" + cmbSubCode.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbUnits.Items.Clear()
        While myreader.Read()
            cmbUnits.Items.Add(myreader("units"))
        End While
        con.Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        If cmbPrelims.Text = "INC" Or cmbPrelims.Text = "FA" Or cmbPrelims.Text = "DROP" Or cmbPrelims.Text = "WOP" Or cmbPrelims.Text = "WP" Then
            Dim sum As Double = Val(cmbMidterms.Text) + Val(cmbFinals.Text)
            Dim ave As Decimal = sum / 2
            Dim holder As Decimal
            holder = Decimal.Round(ave, 2)
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        ElseIf cmbMidterms.Text = "INC" Or cmbMidterms.Text = "FA" Or cmbMidterms.Text = "DROP" Or cmbPrelims.Text = "WOP" Or cmbPrelims.Text = "WP" Then
            Dim sum As Double = Val(cmbPrelims.Text) + Val(cmbFinals.Text)
            Dim ave As Decimal = sum / 2
            Dim holder As Decimal
            holder = Decimal.Round(ave, 2)
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        ElseIf cmbFinals.Text = "INC" Or cmbFinals.Text = "FA" Or cmbFinals.Text = "DROP" Or cmbPrelims.Text = "WOP" Or cmbPrelims.Text = "WP" Then
            Dim sum As Double = Val(cmbPrelims.Text) + Val(cmbMidterms.Text)
            Dim ave As Decimal = sum / 2
            Dim holder As Decimal
            holder = Decimal.Round(ave, 2)
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        ElseIf Not IsNumeric(cmbPrelims.Text) Then
            Dim sum As Double = Val(cmbMidterms.Text) + Val(cmbFinals.Text)
            Dim ave As Decimal = sum / 2
            Dim holder As Decimal
            holder = Decimal.Round(ave, 2)
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        ElseIf Not IsNumeric(cmbMidterms.Text) Then
            Dim sum As Double = Val(cmbPrelims.Text) + Val(cmbFinals.Text)
            Dim ave As Decimal = sum / 2
            Dim holder As Decimal
            holder = Decimal.Round(ave, 2)
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        ElseIf Not IsNumeric(cmbFinals.Text) Then
            Dim sum As Double = Val(cmbPrelims.Text) + Val(cmbMidterms.Text)
            Dim ave As Decimal = sum / 2
            Dim holder As Decimal
            holder = Decimal.Round(ave, 2)
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        Else

            Dim sum As Double = Val(cmbPrelims.Text) + Val(cmbMidterms.Text) + Val(cmbFinals.Text)
            Dim ave As Decimal = sum / 3
            cmbAve.Text = Decimal.Round(ave, 2)

            If cmbAve.Text >= 98 Then
                cmbGrade.Text = "1.00"
                'cmbRemark.Text = "EXCELLENT"
            ElseIf cmbAve.Text >= 95 Then
                cmbGrade.Text = "1.25"
                'cmbRemark.Text = "VERY GOOD"
            ElseIf cmbAve.Text >= 92 Then
                cmbGrade.Text = "1.5"
                ' cmbRemark.Text = "VERY GOOD"
            ElseIf cmbAve.Text >= 89 Then
                cmbGrade.Text = "1.75"
                ' cmbRemark.Text = "VERY GOOD"
            ElseIf cmbAve.Text >= 86 Then
                cmbGrade.Text = "2.00"
                ' cmbRemark.Text = "VERY GOOD"
            ElseIf cmbAve.Text >= 83 Then
                cmbGrade.Text = "2.25"
                'cmbRemark.Text = "GOOD"
            ElseIf cmbAve.Text >= 80 Then
                cmbGrade.Text = "2.5"
                ' cmbRemark.Text = "FAIR"
            ElseIf cmbAve.Text >= 77 Then
                cmbGrade.Text = "2.75"
                ' cmbRemark.Text = "FAIR"
            ElseIf cmbAve.Text >= 75 Then
                cmbGrade.Text = "3.00"
                ' cmbRemark.Text = "PASSED"
            Else
                cmbGrade.Text = "5.00"
                ' cmbRemark.Text = "FAILED"
            End If

        End If


        If cmbPrelims.Text = "INC" Or cmbPrelims.Text = "FA" Or cmbPrelims.Text = "DROP" And cmbMidterms.Text = "INC" Or cmbMidterms.Text = "FA" Or cmbMidterms.Text = "DROP" Then
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        End If


        If cmbMidterms.Text = "INC" Or cmbMidterms.Text = "FA" Or cmbMidterms.Text = "DROP" And cmbFinals.Text = "INC" Or cmbFinals.Text = "FA" Or cmbFinals.Text = "DROP" Then
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        End If


        If cmbPrelims.Text = "INC" Or cmbPrelims.Text = "FA" Or cmbPrelims.Text = "DROP" And cmbFinals.Text = "INC" Or cmbFinals.Text = "FA" Or cmbFinals.Text = "DROP" Then
            cmbAve.Text = "***"
            cmbGrade.Text = "***"
        End If



    End Sub

    Private Sub btnClearGrade_Click(sender As Object, e As EventArgs) Handles btnClearGrade.Click
        Dim result As DialogResult = MessageBox.Show("Clear current grades input?", "Clear Grades Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            cmbPrelims.Text = ""
            cmbMidterms.Text = ""
            cmbFinals.Text = ""
            cmbAve.Text = ""
            cmbGrade.Text = ""
        Else
            MessageBox.Show("Current inputs retained.", "Grades Input Retained", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSaveGrade_Click(sender As Object, e As EventArgs) Handles btnSaveGrade.Click
        con.Open()

        If cmbStudNo.Text = "" Then
            MessageBox.Show("Student Number Required.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNm.Text = "" Then
            MessageBox.Show("Please input Student Name.", "Empty Student Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSchoolYr.Text = "" Then
            MessageBox.Show("Please input School Year.", "Empty School Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Please input the Semester.", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubCode.Text = "" Then
            MessageBox.Show("Please input Subject Code.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbPrelims.Text = "" Then
            MessageBox.Show("Please input at least one grade record.", "Empty Grade Record Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim query As String = "SELECT * FROM gradeRecord WHERE subjectCode=@subjectCode AND studentNumber=@studentNumber AND schoolYear=@schoolYear AND semester=@semester"
            Dim command As SqlCommand = New SqlCommand(query, con)
            command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = cmbSchoolYr.Text
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text


            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    ' User already exists
                    MsgBox("Student Grade Record Already Exists.", MsgBoxStyle.Exclamation, "Existing Grade Record.")
                ElseIf cmbStudNm.Enabled = False Then
                    MessageBox.Show("Please select UPDATE option to update the current grade record.", "Select UPDATE to Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' User does not exist, add them
                    Dim command2 As New SqlCommand("Insert into gradeRecord(schoolYear,semester,subjectCode,units,subjectTitle,studentNumber,studentName,prelims,midterms,finals,average,grade)values(@schoolYear,@semester,@subjectCode,@units,@subjectTitle,@studentNumber,@studentName,@prelims,@midterms,@finals,@average,@grade)", con)

                    command2.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = cmbSchoolYr.Text
                    command2.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
                    command2.Parameters.Add("@units", SqlDbType.NVarChar).Value = cmbUnits.Text
                    command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = cmbSubTitle.Text
                    command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
                    command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
                    command2.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = cmbStudNm.Text
                    command2.Parameters.Add("@prelims", SqlDbType.NVarChar).Value = cmbPrelims.Text
                    command2.Parameters.Add("@midterms", SqlDbType.NVarChar).Value = cmbMidterms.Text
                    command2.Parameters.Add("@finals", SqlDbType.NVarChar).Value = cmbFinals.Text
                    command2.Parameters.Add("@average", SqlDbType.NVarChar).Value = cmbAve.Text
                    command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = cmbGrade.Text
                    command2.ExecuteNonQuery()
                    MsgBox("Records Successfully Added.", MsgBoxStyle.Information, "Student Record Added")
                    con.Close()
                    bind1()

                End If
            End Using

            con.Close()

        End If

        con.Close()
    End Sub

    Private Sub btnUpdateGrade_Click(sender As Object, e As EventArgs) Handles btnUpdateGrade.Click
        If cmbStudNo.Text = "" Then
            MessageBox.Show("Student Number Required.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNm.Text = "" Then
            MessageBox.Show("Please input Student Name.", "Empty Student Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSchoolYr.Text = "" Then
            MessageBox.Show("Please input School Year.", "Empty School Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Please input the Semester.", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubCode.Text = "" Then
            MessageBox.Show("Please input Subject Code.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbPrelims.Text = "" Then
            MessageBox.Show("Please input at least one grade record.", "Empty Grade Record Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            Dim command As New SqlCommand("UPDATE gradeRecord SET schoolYear = @schoolYear,semester = @semester,subjectCode = @subjectCode,units = @units,subjectTitle = @subjectTitle,studentName = @studentName,prelims = @prelims,midterms = @midterms,finals = @finals,average = @average,grade = @grade WHERE studentNumber = @studentNumber", con)

            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = cmbSchoolYr.Text
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
            command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
            command.Parameters.Add("@units", SqlDbType.NVarChar).Value = cmbUnits.Text
            command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = cmbSubTitle.Text
            command.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = cmbStudNm.Text
            command.Parameters.Add("@prelims", SqlDbType.NVarChar).Value = cmbPrelims.Text
            command.Parameters.Add("@midterms", SqlDbType.NChar).Value = cmbMidterms.Text
            command.Parameters.Add("@finals", SqlDbType.NVarChar).Value = cmbFinals.Text
            command.Parameters.Add("@average", SqlDbType.NChar).Value = cmbAve.Text
            command.Parameters.Add("@grade", SqlDbType.NVarChar).Value = cmbGrade.Text
            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text


            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update profile?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                command.ExecuteNonQuery()
                MessageBox.Show("Student Profile Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)


                con.Close()
                bind1()
            Else
                MessageBox.Show("Student Profile Not Updated.", "Not Updated", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnDeleteGrade_Click(sender As Object, e As EventArgs) Handles btnDeleteGrade.Click
        If cmbStudNo.Text = "" Then
            MessageBox.Show("Student Number Required.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbStudNm.Text = "" Then
            MessageBox.Show("Please input Student Name.", "Empty Student Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSchoolYr.Text = "" Then
            MessageBox.Show("Please input School Year.", "Empty School Year", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Please input the Semester.", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubCode.Text = "" Then
            MessageBox.Show("Please input Subject Code.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf cmbPrelims.Text = "" Then
            MessageBox.Show("Please input at least one grade record.", "Empty Grade Record Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            Dim delete As String = cmbStudNo.Text

            Dim command As New SqlCommand("DELETE from gradeRecord WHERE studentNumber = @studentNumber AND subjectCode = @subjectCode AND schoolYear = @schoolYear AND semester = @semester", con)

            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
            command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cmbSubCode.Text
            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = cmbSchoolYr.Text

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete grade record?", "Delete Grade Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                command.ExecuteNonQuery()
                MessageBox.Show("Student Grade Record Deleted.", "Grade Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbSchoolYr.Text = ""
                cmbSemester.Text = ""
                cmbSubCode.Text = ""
                cmbSubTitle.Text = ""
                cmbUnits.Text = ""
                cmbStudNo.Text = ""
                cmbStudNm.Text = ""
                cmbPrelims.Text = ""
                cmbMidterms.Text = ""
                cmbFinals.Text = ""
                con.Close()
                bind1()
            Else
                MessageBox.Show("Student Grade Record Retained.", "Not Deleted", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        TableFormGrades.Show()
    End Sub
End Class
