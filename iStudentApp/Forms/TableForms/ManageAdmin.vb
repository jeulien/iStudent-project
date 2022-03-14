Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class ManageAdmin
    Private tripleDes As New TripleDESCryptoServiceProvider
    'Dim con As New SqlConnection("Data Source=DESKTOP-64RJ8U5;Initial Catalog=iStudentDB;Integrated Security=True;MultipleActiveResultSets=true")
    Dim con As New SqlConnection("Data Source=SQL5107.site4now.net;Initial Catalog=db_a83e48_istudentdb;User Id=db_a83e48_istudentdb_admin;Password=lula0224;MultipleActiveResultSets=true")
    Private Sub txtAdminUser_Enter(sender As Object, e As EventArgs) Handles txtAdminUser.Enter
        panelUser.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtAdminUser_Leave(sender As Object, e As EventArgs) Handles txtAdminUser.Leave
        panelUser.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtAdminPass_Enter(sender As Object, e As EventArgs) Handles txtAdminPass.Enter
        panelPass.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtAdminPass_Leave(sender As Object, e As EventArgs) Handles txtAdminPass.Leave
        panelPass.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtAdminRe_Enter(sender As Object, e As EventArgs) Handles txtAdminRe.Enter
        panelRePass.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtAdminRe_Leave(sender As Object, e As EventArgs) Handles txtAdminRe.Leave
        panelRePass.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub txtAdminName_Enter(sender As Object, e As EventArgs) Handles txtAdminName.Enter
        panelName.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub txtAdminName_Leave(sender As Object, e As EventArgs) Handles txtAdminName.Leave
        panelName.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub ManageAdmin_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelUser.BackColor = Color.FromArgb(61, 61, 86)
        panelPass.BackColor = Color.FromArgb(61, 61, 86)
        panelRePass.BackColor = Color.FromArgb(61, 61, 86)
        panelName.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub

    Private Sub bind1()
        'studentAccountView Table
        Dim command As New SqlCommand("Select * from adminAccounts order by Name Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        adminRecordView.AllowUserToAddRows = False
        adminRecordView.RowTemplate.Height = 50
        adminRecordView.DataSource = table

    End Sub
    Private Sub adminRecordView_Click(sender As Object, e As EventArgs) Handles adminRecordView.Click
        txtAdminUser.Text = adminRecordView.CurrentRow.Cells(0).Value
        txtAdminPass.Text = adminRecordView.CurrentRow.Cells(1).Value
        txtAdminName.Text = adminRecordView.CurrentRow.Cells(2).Value
    End Sub
    Private Sub adminRecordView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles adminRecordView.CellClick
        txtAdminUser.Enabled = False
        txtAdminPass.Enabled = False
        txtAdminRe.Enabled = False
        txtAdminName.Enabled = False
    End Sub
    Private Sub ManageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind1()

    End Sub
    Private Sub cboxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboxPassword.CheckedChanged
        If cboxPassword.CheckState = CheckState.Checked Then
            txtAdminPass.UseSystemPasswordChar = False
            txtAdminRe.UseSystemPasswordChar = False
        Else
            txtAdminPass.UseSystemPasswordChar = True
            txtAdminRe.UseSystemPasswordChar = True
        End If
        bind1()
    End Sub

    Private Sub adminRecordView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles adminRecordView.CellFormatting
        If cboxPassword.Checked = False Then
            If e.ColumnIndex = 1 Then
                If e.Value IsNot Nothing Then
                    e.Value = New String("#", e.Value.ToString().Length)
                End If
            End If
        End If
    End Sub

    Private Sub btnSaveAcc_Click(sender As Object, e As EventArgs) Handles btnSaveAcc.Click
        Try
            If txtAdminPass.Text <> txtAdminRe.Text Then
                MsgBox("Re-typed password does not match.", vbExclamation)
            Else
                con.Open()
                Dim querycommand As New SqlCommand("Insert into adminAccounts(username,password,name)values(@username,@password,@name)", con)
                querycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtAdminUser.Text
                querycommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtAdminPass.Text
                querycommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtAdminName.Text
                querycommand.ExecuteNonQuery()

                con.Close()
                MsgBox("Admin Account Added.", vbInformation)
                txtAdminUser.Text = ""
                txtAdminPass.Text = ""
                txtAdminRe.Text = ""
                txtAdminName.Text = ""
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Class