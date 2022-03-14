Imports System.Data.SqlClient
Imports System.IO
Public Class ManageUsers

    'Dim con As New SqlConnection("Data Source=DESKTOP-64RJ8U5;Initial Catalog=iStudentDB;Integrated Security=True;MultipleActiveResultSets=true")
    Dim con As New SqlConnection("Data Source=SQL5107.site4now.net;Initial Catalog=db_a83e48_istudentdb;User Id=db_a83e48_istudentdb_admin;Password=lula0224;MultipleActiveResultSets=true")

    Private Sub cmbStudNo_Enter(sender As Object, e As EventArgs) Handles cmbStudNo.Enter
        panelStudNo.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbStudNo_Leave(sender As Object, e As EventArgs) Handles cmbStudNo.Leave
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        panelPassword.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        panelPassword.BackColor = Color.FromArgb(61, 61, 86)
    End Sub

    Private Sub ManageUsers_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
        panelPassword.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub

    Private Sub bind1()
        'studentAccountView Table
        Dim command As New SqlCommand("Select * from studentAccounts order by studentAccount Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        studentAccountView.AllowUserToAddRows = False
        studentAccountView.RowTemplate.Height = 50
        studentAccountView.DataSource = table

    End Sub


    Private Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From studentAccounts Where studentAccount like '%" & valueToSearch & "%' order by studentAccount"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        studentAccountView.DataSource = tableFill
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAccounts.TextChanged
        FilterData(txtSearchAccounts.Text)
    End Sub

    Private Sub studentAccountView_Click(sender As Object, e As EventArgs) Handles studentAccountView.Click
        cmbStudNo.Text = studentAccountView.CurrentRow.Cells(0).Value
        txtPassword.Text = studentAccountView.CurrentRow.Cells(1).Value
    End Sub

    Private Sub studentAccountView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentAccountView.CellClick
        cmbStudNo.Enabled = False
        txtPassword.Enabled = False
    End Sub
    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        cmbStudNo.Enabled = False
        txtPassword.Enabled = False

        bind1()

        Dim command As New SqlCommand("Select * From studentProfiles", con)
        Dim adapter As New SqlDataAdapter(command)


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
    Private Sub studentAccountView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles studentAccountView.CellFormatting
        If CheckBox1.Checked = False Then
            If e.ColumnIndex = 1 Then
                If e.Value IsNot Nothing Then
                    e.Value = New String("#", e.Value.ToString().Length)
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        bind1()
    End Sub

    Private Sub btnAddAcc_Click(sender As Object, e As EventArgs) Handles btnAddAcc.Click
        Dim result As DialogResult = MessageBox.Show("Create student account? (This will clear inputs if there are any).", "Enter New Student Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            cmbStudNo.Text = ""
            txtPassword.Text = ""
            cmbStudNo.Enabled = True
            txtPassword.Enabled = True
        Else
            MessageBox.Show("Student Creation Cancelled.", "Student Accounts Retained.", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnSaveAcc_Click(sender As Object, e As EventArgs) Handles btnSaveAcc.Click

        con.Open()
        If cmbStudNo.Text = "" Then
            MessageBox.Show("Student Number Required.", "Empty Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim query As String = "SELECT * FROM studentAccounts WHERE studentAccount=@studentAccount"
            Dim command As SqlCommand = New SqlCommand(query, con)
            command.Parameters.Add("@studentAccount", SqlDbType.NVarChar).Value = cmbStudNo.Text


            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    ' User already exists
                    MsgBox("Student Record Already Exists.", MsgBoxStyle.Exclamation, "Already Exists.")
                ElseIf txtPassword.Enabled = False Then
                    MessageBox.Show("Please select UPDATE option to update the current password.", "Select UPDATE to Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' User does not exist, add them
                    Dim command2 As New SqlCommand("Insert into studentAccounts(studentAccount,studentPassword)values(@studentAccount,@studentPassword)", con)

                    command2.Parameters.Add("@studentAccount", SqlDbType.NVarChar).Value = cmbStudNo.Text
                    command2.Parameters.Add("@studentPassword", SqlDbType.NVarChar).Value = txtPassword.Text

                    command2.ExecuteNonQuery()
                    MsgBox("Student Account Successfully Created.", MsgBoxStyle.Information, "Student Account Added")
                    cmbStudNo.Text = ""
                    txtPassword.Text = ""
                    con.Close()
                    bind1()

                End If
            End Using
            con.Close()
        End If

    End Sub


End Class