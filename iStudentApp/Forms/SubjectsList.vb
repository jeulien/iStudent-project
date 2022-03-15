Imports System.Data.SqlClient
Imports System.IO
Public Class SubjectsList

    'COLOR PANEL CHANGES
    Private Sub txtSubCode_Enter(sender As Object, e As EventArgs) Handles txtSubCode.Enter
        panelSubCode.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtSubCode_Leave(sender As Object, e As EventArgs) Handles txtSubCode.Leave
        panelSubCode.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtSubTitle_Enter(sender As Object, e As EventArgs) Handles txtSubTitle.Enter
        panelSubTitle.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtSubTitle_Leave(sender As Object, e As EventArgs) Handles txtSubTitle.Leave
        panelSubTitle.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtSubUnits_Enter(sender As Object, e As EventArgs) Handles txtSubUnits.Enter
        panelUnits.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtSubUnits_Leave(sender As Object, e As EventArgs) Handles txtSubUnits.Leave
        panelUnits.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtSubDesc_Enter(sender As Object, e As EventArgs) Handles txtSubDesc.Enter
        panelDesc.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtSubDesc_Leave(sender As Object, e As EventArgs) Handles txtSubDesc.Leave
        panelDesc.BackColor = Color.FromArgb(61, 61, 86)
    End Sub

    Private Sub SubjectsList_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelSubCode.BackColor = Color.FromArgb(61, 61, 86)
        panelSubTitle.BackColor = Color.FromArgb(61, 61, 86)
        panelUnits.BackColor = Color.FromArgb(61, 61, 86)
        panelDesc.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub

    Private Sub SubjectsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        txtSubCode.Enabled = False
        txtSubTitle.Enabled = False
        txtSubUnits.Enabled = False
        txtSubDesc.Enabled = False

        bind1()
    End Sub

    Private Sub bind1()
        'subjectListView Table
        Dim command As New SqlCommand("Select * from subjectList order by subjectCode Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        subjectListView.AllowUserToAddRows = False
        subjectListView.RowTemplate.Height = 50
        subjectListView.DataSource = table
    End Sub

    Private Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From subjectList Where Concat(subjectCode, subjectTitle) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        subjectListView.DataSource = tableFill
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSubjects.TextChanged
        FilterData(txtSearchSubjects.Text)
    End Sub

    Private Sub subjectListView_Click(sender As Object, e As EventArgs) Handles subjectListView.Click
        txtSubCode.Text = subjectListView.CurrentRow.Cells(0).Value
        txtSubTitle.Text = subjectListView.CurrentRow.Cells(1).Value
        txtSubUnits.Text = subjectListView.CurrentRow.Cells(2).Value
        txtSubDesc.Text = subjectListView.CurrentRow.Cells(3).Value
    End Sub

    Private Sub subjectListView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectListView.CellClick
        txtSubCode.Enabled = False
    End Sub

    Private Sub btnAccessSubject_Click(sender As Object, e As EventArgs) Handles btnAccessSubject.Click
        If txtSubCode.Text = "" Then
            txtSubCode.Enabled = False
            txtSubTitle.Enabled = False
            txtSubUnits.Enabled = False
            txtSubDesc.Enabled = False
        Else
            txtSubCode.Enabled = False
            txtSubTitle.Enabled = True
            txtSubUnits.Enabled = True
            txtSubDesc.Enabled = True
        End If
    End Sub

    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        Dim command As New SqlCommand("Insert into subjectList(subjectCode,subjectTitle,units,description)values(@subjectCode,@subjectTitle,@units,@description)", con)

        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = txtSubCode.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = txtSubTitle.Text
        command.Parameters.Add("@units", SqlDbType.NChar).Value = txtSubUnits.Text
        command.Parameters.Add("@description", SqlDbType.NVarChar).Value = txtSubDesc.Text


        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If txtSubCode.Text = "" Then
            MessageBox.Show("Subject Code Required.", "Empty Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtSubTitle.Text = "" Then
            MessageBox.Show("Please input Subject Title.", "Empty Subject Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtSubUnits.Text = "" Then
            MessageBox.Show("Please input Subject Units.", "Empty Subject Units", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtSubDesc.Text = "" Then
            MessageBox.Show("Please input some type of Description.", "Empty Description", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to save subject record?", "Save Subject Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                command.ExecuteNonQuery()
                MessageBox.Show("Subject Added.", "Saved", MessageBoxButtons.OK)
                txtSubCode.Text = ""
                txtSubTitle.Text = ""
                txtSubUnits.Text = ""
                txtSubDesc.Text = ""
                con.Close()
                bind1()
            Else
                MessageBox.Show("Subject Not Added.", "Not Added", MessageBoxButtons.OK)
            End If
        Catch ex As SqlException
            MessageBox.Show("Subject Code Already Exists. Enter new code.", "Duplicate Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSubCode.Text = ""
            Exit Try
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        Dim command As New SqlCommand("UPDATE subjectList SET subjectCode = @subjectCode, subjectTitle = @subjectTitle, units = @units, description = @description WHERE subjectCode = @subjectCode", con)

        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = txtSubTitle.Text
        command.Parameters.Add("@units", SqlDbType.NChar).Value = txtSubUnits.Text
        command.Parameters.Add("@description", SqlDbType.NVarChar).Value = txtSubDesc.Text
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = txtSubCode.Text


        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update subject record?", "Update Subject Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Subject Updated.", "Updated", MessageBoxButtons.OK)
            txtSubCode.Text = ""
            txtSubTitle.Text = ""
            txtSubUnits.Text = ""
            txtSubDesc.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Subject Not Added.", "Not Added", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Dim result As DialogResult = MessageBox.Show("Enter new subject record? (This will clear inputs if there are any).", "Enter New Subject Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtSubCode.Text = ""
            txtSubTitle.Text = ""
            txtSubUnits.Text = ""
            txtSubDesc.Text = ""
            txtSubCode.Enabled = True
            txtSubTitle.Enabled = True
            txtSubUnits.Enabled = True
            txtSubDesc.Enabled = True
        Else
            MessageBox.Show("Inputs and Subject Retained.", "Inputs/Subject", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnDeleteSubject_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        Dim delete As String = txtSubCode.Text

        Dim command As New SqlCommand("DELETE from subjectList WHERE subjectCode = @subjectCode", con)

        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = txtSubCode.Text

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete subject record?", "Delete Subject Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Student Profile Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSubCode.Text = ""
            txtSubTitle.Text = ""
            txtSubUnits.Text = ""
            txtSubDesc.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Subject Record Retained.", "Not Deleted", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        TableFormSubjects.Show()
    End Sub
End Class
