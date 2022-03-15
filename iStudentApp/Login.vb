Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Private tripleDes As New TripleDESCryptoServiceProvider
   
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.BackColor = Color.White
        loginPanel.BackColor = Color.White
        passwordPanel.BackColor = SystemColors.Control
        txtPassword.BackColor = SystemColors.Control
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.BackColor = Color.White
        passwordPanel.BackColor = Color.White
        txtUsername.BackColor = SystemColors.Control
        loginPanel.BackColor = SystemColors.Control
    End Sub

    Private Sub cboxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboxPassword.CheckedChanged
        If cboxPassword.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim found As Boolean = False
            Dim strname As String = ""
            con.Open()
            Dim query As String = "SELECT * FROM adminAccounts"
            Dim command As SqlCommand = New SqlCommand(query, con)

            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read
                    If txtUsername.Text = reader.Item("username").ToString And txtPassword.Text = reader.Item("password").ToString Then
                        found = True
                        strname = reader.Item("name").ToString
                    End If
                End While
                reader.Close()
                con.Close()
                If found = True Then
                    MsgBox("Welcome, " & strname, vbInformation)
                    Me.Hide()
                    AdminDashboard.Show()
                Else
                    MsgBox("Invalid Admin username or password.", vbExclamation)
                End If
            End Using
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Class
