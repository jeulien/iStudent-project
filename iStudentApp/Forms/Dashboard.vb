Imports System.Data.SqlClient
Imports System.IO

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        bind1()
    End Sub

    Private Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From dashboardPost Where postTitle like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        dashboardView.DataSource = tableFill
    End Sub

    Private Sub bind1()
        'dashboardView Table
        Dim command As New SqlCommand("Select * from dashboardPost", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        dashboardView.AllowUserToAddRows = False
        dashboardView.RowTemplate.Height = 50
        dashboardView.DataSource = table

        dashboardView.Columns("postID").Visible = False
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPosts.TextChanged
        FilterData(txtSearchPosts.Text)
    End Sub

    Private Sub studentProfileView_Click(sender As Object, e As EventArgs) Handles dashboardView.Click
        txtPostTitle.Text = dashboardView.CurrentRow.Cells(1).Value
        txtPostDescription.Text = dashboardView.CurrentRow.Cells(2).Value
    End Sub
    Private Sub btnSavePost_Click(sender As Object, e As EventArgs) Handles btnSavePost.Click
        Dim command As New SqlCommand("Insert into dashboardPost(postTitle,postDescription)values(@postTitle,@postDescription)", con)

        command.Parameters.Add("@postTitle", SqlDbType.NVarChar).Value = txtPostTitle.Text
        command.Parameters.Add("@postDescription", SqlDbType.NVarChar).Value = txtpostDescription.Text


        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If txtPostTitle.Text = "" Then
            MessageBox.Show("Post Title must be placed before posting on the Dashboard.", "Empty Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtpostDescription.Text = "" Then
            MessageBox.Show("Information must be placed before posting on the Dashboard.", "Empty Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to post the information?", "Post Information to Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Dashboard Post Added.", "Information Posted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPostTitle.Text = ""
            txtpostDescription.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Dashboard Post Not Added.", "Not Posted", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnUpdatePost_Click(sender As Object, e As EventArgs) Handles btnUpdatePost.Click
        Dim command As New SqlCommand("UPDATE dashboardPost SET postTitle = @postTitle,postDescription = @postDescription WHERE postID=@postID", con)
        command.Parameters.Add("@postID", SqlDbType.NVarChar).Value = postID.Text
        command.Parameters.Add("@postTitle", SqlDbType.NVarChar).Value = txtPostTitle.Text
        command.Parameters.Add("@postDescription", SqlDbType.NVarChar).Value = txtPostDescription.Text

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update post?", "Update Post", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Dashboard Post Updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPostTitle.Text = ""
            txtpostDescription.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Dashboard Post Not Updated.", "Not Updated", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnDeletePost_Click(sender As Object, e As EventArgs) Handles btnDeletePost.Click

        Dim command As New SqlCommand("DELETE from dashboardPost WHERE postID = @postID", con)

        command.Parameters.Add("@postID", SqlDbType.NVarChar).Value = postID.Text

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete post?", "Delete Post", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Dashboard Post Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPostTitle.Text = ""
            txtpostDescription.Text = ""
            con.Close()
            bind1()
        Else
            MessageBox.Show("Dashboard Post Retained.", "Not Deleted", MessageBoxButtons.OK)
        End If
    End Sub
End Class
