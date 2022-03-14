Imports System.Data.SqlClient
Imports System.IO
Public Class GWARecords

    'Dim con As New SqlConnection("Data Source=DESKTOP-64RJ8U5;Initial Catalog=iStudentDB;Integrated Security=True;MultipleActiveResultSets=true")
    Dim con As New SqlConnection("Data Source=SQL5107.site4now.net;Initial Catalog=db_a83e48_istudentdb;User Id=db_a83e48_istudentdb_admin;Password=lula0224;MultipleActiveResultSets=true")
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
        panelSchoolYr.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbSchoolYr_Leave(sender As Object, e As EventArgs) Handles cmbSchoolYr.Leave
        panelSchoolYr.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub cmbSemester_Enter(sender As Object, e As EventArgs) Handles cmbSemester.Enter
        panelSemester.BackColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub cmbSemester_Leave(sender As Object, e As EventArgs) Handles cmbSemester.Leave
        panelSemester.BackColor = Color.FromArgb(61, 61, 86)
    End Sub
    Private Sub GWARecords_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelSchoolYr.BackColor = Color.FromArgb(61, 61, 86)
        panelSemester.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNo.BackColor = Color.FromArgb(61, 61, 86)
        panelStudNm.BackColor = Color.FromArgb(61, 61, 86)
        'END OF COLOR PANEL CHANGES
    End Sub
    Private Sub GWARecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbStudNo.Enabled = False
        cmbStudNm.Enabled = False
        cmbSchoolYr.Enabled = False
        cmbSemester.Enabled = False

        cod1Cmb.Enabled = False
        cod2Cmb.Enabled = False
        cod3Cmb.Enabled = False
        cod4Cmb.Enabled = False
        cod5Cmb.Enabled = False
        cod6Cmb.Enabled = False
        cod7Cmb.Enabled = False
        cod8Cmb.Enabled = False
        cod9Cmb.Enabled = False
        cod10Cmb.Enabled = False
        cod11Cmb.Enabled = False
        cod12Cmb.Enabled = False

        sub1Cmb.Enabled = False
        sub2Cmb.Enabled = False
        sub3Cmb.Enabled = False
        sub4Cmb.Enabled = False
        sub5Cmb.Enabled = False
        sub6Cmb.Enabled = False
        sub7Cmb.Enabled = False
        sub8Cmb.Enabled = False
        sub9Cmb.Enabled = False
        sub10Cmb.Enabled = False
        sub11Cmb.Enabled = False
        sub12Cmb.Enabled = False

        un1Cmb.Enabled = False
        un2Cmb.Enabled = False
        un3Cmb.Enabled = False
        un4Cmb.Enabled = False
        un5Cmb.Enabled = False
        un6Cmb.Enabled = False
        un7Cmb.Enabled = False
        un8Cmb.Enabled = False
        un9Cmb.Enabled = False
        un10Cmb.Enabled = False
        un11Cmb.Enabled = False
        un12Cmb.Enabled = False

        fin1Cmb.Enabled = False
        fin2Cmb.Enabled = False
        fin3Cmb.Enabled = False
        fin4Cmb.Enabled = False
        fin5Cmb.Enabled = False
        fin6Cmb.Enabled = False
        fin7Cmb.Enabled = False
        fin8Cmb.Enabled = False
        fin9Cmb.Enabled = False
        fin10Cmb.Enabled = False
        fin11Cmb.Enabled = False
        fin12Cmb.Enabled = False

        con.Open()
        Dim strsql As New SqlCommand("select distinct studentNumber from gradeRecord", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbStudNo.Items.Clear()
        While myreader.Read()
            cmbStudNo.Items.Add(myreader("studentNumber"))
        End While
        con.Close()

    End Sub

    Private Sub bind1()
        'studentGWAView Table
        Dim command As New SqlCommand("Select * from gwaRecords order by studentNumber,schoolYear Asc", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        studentGWAView.AllowUserToAddRows = False
        studentGWAView.RowTemplate.Height = 50
        studentGWAView.DataSource = table
    End Sub

    Private Sub cmbStudNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudNo.SelectedIndexChanged
        con.Open()
        Dim strsql2 As New SqlCommand("select distinct studentName from gradeRecord where studentNumber='" + cmbStudNo.Text + "'", con)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbStudNm.Items.Clear()
        While myreader2.Read()
            cmbStudNm.Items.Add(myreader2("studentName"))
        End While
        con.Close()


        con.Open()
        Dim strsql3 As New SqlCommand("select distinct schoolYear from gradeRecord where studentNumber='" + cmbStudNo.Text + "'", con)
        Dim myreader3 As SqlDataReader = strsql3.ExecuteReader
        cmbSchoolYr.Items.Clear()
        While myreader3.Read()
            cmbSchoolYr.Items.Add(myreader3("schoolYear"))
        End While
        con.Close()


        con.Open()
        Dim strsql4 As New SqlCommand("select distinct semester from gradeRecord where studentNumber='" + cmbStudNo.Text + "'", con)
        Dim myreader4 As SqlDataReader = strsql4.ExecuteReader
        cmbSemester.Items.Clear()
        While myreader4.Read()
            cmbSemester.Items.Add(myreader4("semester"))
        End While
        con.Close()


    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        con.Open()
        Dim strsql As New SqlCommand("select distinct subjectCode from gradeRecord where studentNumber='" + cmbStudNo.Text + "' and schoolYear='" + cmbSchoolYr.Text + "' and semester='" + cmbSemester.Text + "'", con)
        Dim myreader As SqlDataReader = strsql.ExecuteReader

        cod1Cmb.Items.Clear()
        While myreader.Read()
            cod1Cmb.Items.Add(myreader("subjectCode"))
            cod2Cmb.Items.Add(myreader("subjectCode"))
            cod3Cmb.Items.Add(myreader("subjectCode"))
            cod4Cmb.Items.Add(myreader("subjectCode"))
            cod5Cmb.Items.Add(myreader("subjectCode"))
            cod6Cmb.Items.Add(myreader("subjectCode"))
            cod7Cmb.Items.Add(myreader("subjectCode"))
            cod8Cmb.Items.Add(myreader("subjectCode"))
            cod9Cmb.Items.Add(myreader("subjectCode"))
            cod10Cmb.Items.Add(myreader("subjectCode"))
            cod11Cmb.Items.Add(myreader("subjectCode"))
            cod12Cmb.Items.Add(myreader("subjectCode"))
        End While
        con.Close()
    End Sub

    Private Sub cod1Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod1Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod1Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub1Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub1Cmb.Items.Clear()
        While myreader.Read()
            sub1Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod2Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod2Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod2Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub2Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub2Cmb.Items.Clear()
        While myreader.Read()
            sub2Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod3Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod3Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod3Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub3Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub3Cmb.Items.Clear()
        While myreader.Read()
            sub3Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod4Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod4Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod4Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub4Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub4Cmb.Items.Clear()
        While myreader.Read()
            sub4Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod5Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod5Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod5Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub5Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub5Cmb.Items.Clear()
        While myreader.Read()
            sub5Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod6Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod6Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod6Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub6Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub6Cmb.Items.Clear()
        While myreader.Read()
            sub6Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod7Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod7Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod7Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub7Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub7Cmb.Items.Clear()
        While myreader.Read()
            sub7Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod8Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod8Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod8Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub8Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub8Cmb.Items.Clear()
        While myreader.Read()
            sub8Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod9Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod9Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod9Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub9Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub9Cmb.Items.Clear()
        While myreader.Read()
            sub9Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod10Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod10Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod10Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub10Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub10Cmb.Items.Clear()
        While myreader.Read()
            sub10Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod11Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod11Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod11Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub11Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub11Cmb.Items.Clear()
        While myreader.Read()
            sub11Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub cod12Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod12Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct subjectTitle from gradeRecord where subjectCode=@subjectCode"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectCode", SqlDbType.NVarChar).Value = cod12Cmb.Text
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub12Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        sub12Cmb.Items.Clear()
        While myreader.Read()
            sub12Cmb.Items.Add(myreader("subjectTitle"))
        End While
        con.Close()
    End Sub
    Private Sub sub1Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub1Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub1Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un1Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un1Cmb.Items.Clear()
        While myreader.Read()
            un1Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub1Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin1Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin1Cmb.Items.Clear()
        While myreader2.Read()
            fin1Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub2Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub2Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub2Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un2Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un2Cmb.Items.Clear()
        While myreader.Read()
            un2Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub2Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin2Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin2Cmb.Items.Clear()
        While myreader2.Read()
            fin2Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub3Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub3Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub3Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un3Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un3Cmb.Items.Clear()
        While myreader.Read()
            un3Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub3Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin3Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin3Cmb.Items.Clear()
        While myreader2.Read()
            fin3Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub4Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub4Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub4Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un4Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un4Cmb.Items.Clear()
        While myreader.Read()
            un4Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub4Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin4Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin4Cmb.Items.Clear()
        While myreader2.Read()
            fin4Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub5Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub5Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub5Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un5Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un5Cmb.Items.Clear()
        While myreader.Read()
            un5Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub5Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin5Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin5Cmb.Items.Clear()
        While myreader2.Read()
            fin5Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub6Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub6Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub6Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un6Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un6Cmb.Items.Clear()
        While myreader.Read()
            un6Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub6Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin6Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin6Cmb.Items.Clear()
        While myreader2.Read()
            fin6Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub7Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub7Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub7Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un7Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un7Cmb.Items.Clear()
        While myreader.Read()
            un7Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub7Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin7Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin7Cmb.Items.Clear()
        While myreader2.Read()
            fin7Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub8Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub8Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub8Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un8Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un8Cmb.Items.Clear()
        While myreader.Read()
            un8Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub8Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin8Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin8Cmb.Items.Clear()
        While myreader2.Read()
            fin8Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub9Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub9Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub9Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un9Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un9Cmb.Items.Clear()
        While myreader.Read()
            un9Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub9Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin9Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin9Cmb.Items.Clear()
        While myreader2.Read()
            fin9Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub10Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub10Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub10Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un10Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un10Cmb.Items.Clear()
        While myreader.Read()
            un10Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub10Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin10Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin10Cmb.Items.Clear()
        While myreader2.Read()
            fin10Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub11Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub11Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub11Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un11Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un11Cmb.Items.Clear()
        While myreader.Read()
            un11Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub11Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin11Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin11Cmb.Items.Clear()
        While myreader2.Read()
            fin11Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub
    Private Sub sub12Cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sub12Cmb.SelectedIndexChanged
        con.Open()
        Dim strsql As String = "select distinct units from gradeRecord where subjectTitle=@subjectTitle"
        Dim command As SqlCommand = New SqlCommand(strsql, con)
        command.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub12Cmb.Text
        command.Parameters.Add("@units", SqlDbType.NVarChar).Value = un12Cmb.Text

        Dim myreader As SqlDataReader = command.ExecuteReader

        un12Cmb.Items.Clear()
        While myreader.Read()
            un12Cmb.Items.Add(myreader("units"))
        End While
        con.Close()


        con.Open()
        Dim strsql2 As String = "select distinct grade from gradeRecord where subjectTitle=@subjectTitle and studentNumber=@studentNumber and semester=@semester"
        Dim command2 As SqlCommand = New SqlCommand(strsql2, con)
        command2.Parameters.Add("@subjectTitle", SqlDbType.NVarChar).Value = sub12Cmb.Text
        command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
        command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
        command2.Parameters.Add("@grade", SqlDbType.NVarChar).Value = fin12Cmb.Text

        Dim myreader2 As SqlDataReader = command2.ExecuteReader

        fin12Cmb.Items.Clear()
        While myreader2.Read()
            fin12Cmb.Items.Add(myreader2("grade"))
        End While
        con.Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        If IsNumeric(fin1Cmb.Text) Then
            Dim fg1 As Double
            fg1 = Val(un1Cmb.Text) * Val(fin1Cmb.Text)
            lb1.Text = fg1
        ElseIf InStr(fin1Cmb.Text, "***") Or InStr(fin1Cmb.Text, "INC") Or InStr(fin1Cmb.Text, "FA") Or InStr(fin1Cmb.Text, "DROP") Then
            Dim fg1 As String
            fg1 = "***"
            lb1.Text = fg1
        Else
            Dim fg1 As Double
            fg1 = Val(un1Cmb.Text) * Val(fin1Cmb.Text)
            lb1.Text = "0"
        End If


        If IsNumeric(fin2Cmb.Text) Then
            Dim fg2 As Double
            fg2 = Val(un2Cmb.Text) * Val(fin2Cmb.Text)
            lb2.Text = fg2
        ElseIf InStr(fin2Cmb.Text, "***") Or InStr(fin1Cmb.Text, "INC") Or InStr(fin1Cmb.Text, "FA") Or InStr(fin1Cmb.Text, "DROP") Then
            Dim fg2 As String
            fg2 = "***"
            lb2.Text = fg2
        Else
            Dim fg2 As Double
            fg2 = Val(un2Cmb.Text) * Val(fin2Cmb.Text)
            lb2.Text = "0"
        End If


        If IsNumeric(fin3Cmb.Text) Then
            Dim fg3 As Double
            fg3 = Val(un3Cmb.Text) * Val(fin3Cmb.Text)
            lb3.Text = fg3
        ElseIf InStr(fin3Cmb.Text, "***") Or InStr(fin1Cmb.Text, "INC") Or InStr(fin1Cmb.Text, "FA") Or InStr(fin1Cmb.Text, "DROP") Then
            Dim fg3 As String
            fg3 = "***"
            lb3.Text = fg3
        Else
            Dim fg3 As Double
            fg3 = Val(un3Cmb.Text) * Val(fin3Cmb.Text)
            lb3.Text = "0"
        End If


        If IsNumeric(fin4Cmb.Text) Then
            Dim fg4 As Double
            fg4 = Val(un4Cmb.Text) * Val(fin4Cmb.Text)
            lb4.Text = fg4
        ElseIf InStr(fin4Cmb.Text, "***") Or InStr(fin1Cmb.Text, "INC") Or InStr(fin1Cmb.Text, "FA") Or InStr(fin1Cmb.Text, "DROP") Then
            Dim fg4 As String
            fg4 = "***"
            lb4.Text = fg4
        Else
            Dim fg4 As Double
            fg4 = Val(un4Cmb.Text) * Val(fin4Cmb.Text)
            lb4.Text = "0"
        End If


        If IsNumeric(fin5Cmb.Text) Then
            Dim fg5 As Double
            fg5 = Val(un5Cmb.Text) * Val(fin5Cmb.Text)
            lb5.Text = fg5
        ElseIf InStr(fin5Cmb.Text, "***") Or InStr(fin5Cmb.Text, "INC") Or InStr(fin5Cmb.Text, "FA") Or InStr(fin5Cmb.Text, "DROP") Then
            Dim fg5 As String
            fg5 = "***"
            lb5.Text = fg5
        Else
            Dim fg5 As Double
            fg5 = Val(un5Cmb.Text) * Val(fin5Cmb.Text)
            lb5.Text = "0"
        End If


        If IsNumeric(fin6Cmb.Text) Then
            Dim fg6 As Double
            fg6 = Val(un6Cmb.Text) * Val(fin6Cmb.Text)
            lb6.Text = fg6
        ElseIf InStr(fin6Cmb.Text, "***") Or InStr(fin6Cmb.Text, "INC") Or InStr(fin6Cmb.Text, "FA") Or InStr(fin6Cmb.Text, "DROP") Then
            Dim fg6 As String
            fg6 = "***"
            lb5.Text = fg6
        Else
            Dim fg6 As Double
            fg6 = Val(un6Cmb.Text) * Val(fin6Cmb.Text)
            lb6.Text = "0"
        End If


        If IsNumeric(fin7Cmb.Text) Then
            Dim fg7 As Double
            fg7 = Val(un7Cmb.Text) * Val(fin7Cmb.Text)
            lb7.Text = fg7
        ElseIf InStr(fin7Cmb.Text, "***") Or InStr(fin7Cmb.Text, "INC") Or InStr(fin7Cmb.Text, "FA") Or InStr(fin7Cmb.Text, "DROP") Then
            Dim fg7 As String
            fg7 = "***"
            lb7.Text = fg7
        Else
            Dim fg7 As Double
            fg7 = Val(un7Cmb.Text) * Val(fin7Cmb.Text)
            lb7.Text = "0"
        End If


        If IsNumeric(fin8Cmb.Text) Then
            Dim fg8 As Double
            fg8 = Val(un8Cmb.Text) * Val(fin8Cmb.Text)
            lb8.Text = fg8
        ElseIf InStr(fin8Cmb.Text, "***") Or InStr(fin8Cmb.Text, "INC") Or InStr(fin8Cmb.Text, "FA") Or InStr(fin8Cmb.Text, "DROP") Then
            Dim fg8 As String
            fg8 = "***"
            lb8.Text = fg8
        Else
            Dim fg8 As Double
            fg8 = Val(un8Cmb.Text) * Val(fin8Cmb.Text)
            lb8.Text = "0"
        End If


        If IsNumeric(fin9Cmb.Text) Then
            Dim fg9 As Double
            fg9 = Val(un9Cmb.Text) * Val(fin9Cmb.Text)
            lb9.Text = fg9
        ElseIf InStr(fin9Cmb.Text, "***") Or InStr(fin9Cmb.Text, "INC") Or InStr(fin9Cmb.Text, "FA") Or InStr(fin9Cmb.Text, "DROP") Then
            Dim fg9 As String
            fg9 = "***"
            lb9.Text = fg9
        Else
            Dim fg9 As Double
            fg9 = Val(un9Cmb.Text) * Val(fin9Cmb.Text)
            lb9.Text = "0"
        End If


        If IsNumeric(fin10Cmb.Text) Then
            Dim fg10 As Double
            fg10 = Val(un10Cmb.Text) * Val(fin10Cmb.Text)
            lb10.Text = fg10
        ElseIf InStr(fin10Cmb.Text, "***") Or InStr(fin10Cmb.Text, "INC") Or InStr(fin10Cmb.Text, "FA") Or InStr(fin10Cmb.Text, "DROP") Then
            Dim fg10 As String
            fg10 = "***"
            lb10.Text = fg10
        Else
            Dim fg10 As Double
            fg10 = Val(un10Cmb.Text) * Val(fin10Cmb.Text)
            lb10.Text = "0"
        End If


        If IsNumeric(fin11Cmb.Text) Then
            Dim fg11 As Double
            fg11 = Val(un11Cmb.Text) * Val(fin11Cmb.Text)
            lb11.Text = fg11
        ElseIf InStr(fin11Cmb.Text, "***") Or InStr(fin11Cmb.Text, "INC") Or InStr(fin11Cmb.Text, "FA") Or InStr(fin11Cmb.Text, "DROP") Then
            Dim fg11 As String
            fg11 = "***"
            lb11.Text = fg11
        Else
            Dim fg11 As Double
            fg11 = Val(un11Cmb.Text) * Val(fin11Cmb.Text)
            lb11.Text = "0"
        End If


        If IsNumeric(fin12Cmb.Text) Then
            Dim fg12 As Double
            fg12 = Val(un12Cmb.Text) * Val(fin12Cmb.Text)
            lb12.Text = fg12
        ElseIf InStr(fin12Cmb.Text, "***") Or InStr(fin12Cmb.Text, "INC") Or InStr(fin12Cmb.Text, "FA") Or InStr(fin12Cmb.Text, "DROP") Then
            Dim fg12 As String
            fg12 = "***"
            lb12.Text = fg12
        Else
            Dim fg12 As Double
            fg12 = Val(un12Cmb.Text) * Val(fin12Cmb.Text)
            lb12.Text = "0"
        End If


        Dim totalUnits As Double = Val(un1Cmb.Text) + Val(un2Cmb.Text) + Val(un3Cmb.Text) + Val(un4Cmb.Text) + Val(un5Cmb.Text) + Val(un6Cmb.Text) + Val(un7Cmb.Text) + Val(un8Cmb.Text) + Val(un9Cmb.Text) + Val(un10Cmb.Text) + Val(un11Cmb.Text) + Val(un12Cmb.Text)
        lblUnit.Text = totalUnits


        If lb1.Text = "***" Or lb2.Text = "***" Or lb3.Text = "***" Or lb4.Text = "***" Or lb5.Text = "***" Or lb6.Text = "***" Or lb7.Text = "***" Or lb8.Text = "***" Or lb9.Text = "***" Or lb10.Text = "***" Or lb11.Text = "***" Or lb12.Text = "***" Then
            lblGwa.Text = "***"
        Else
            Dim fgTot As Double = Val(lb1.Text) + Val(lb2.Text) + Val(lb3.Text) + Val(lb4.Text) + Val(lb5.Text) + Val(lb6.Text) + Val(lb7.Text) + Val(lb8.Text) + Val(lb9.Text) + Val(lb10.Text) + Val(lb11.Text) + Val(lb12.Text)
            Dim gwaFin As Decimal = fgTot / totalUnits
            lblGwa.Text = Decimal.Round(gwaFin, 3)
        End If


        If Val(lblGwa.Text) >= 1 And Val(lblGwa.Text) <= 1.24 Then
            lblequivalent.Text = "EXCELLENT"
        ElseIf Val(lblGwa.Text) >= 1.25 And Val(lblGwa.Text) <= 1.74 Then
            lblequivalent.Text = "VERY GOOD"
        ElseIf Val(lblGwa.Text) >= 1.75 And Val(lblGwa.Text) <= 2.49 Then
            lblequivalent.Text = "GOOD"
        ElseIf Val(lblGwa.Text) >= 2.5 And Val(lblGwa.Text) <= 2.75 Then
            lblequivalent.Text = "FAIR"
        ElseIf Val(lblGwa.Text) >= 2.76 And Val(lblGwa.Text) <= 3 Then
            lblequivalent.Text = "PASSED"
        ElseIf Val(lblGwa.Text) >= 3.1 And Val(lblGwa.Text) <= 5 Then
            lblequivalent.Text = "FAILED"
        Else
            lblequivalent.Text = "***"
        End If




    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
        ElseIf lblGwa.Text = "" Then
            MessageBox.Show("No Student GWA Found. Compute GWA First before saving.", "Empty Student GWA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim query As String = "SELECT * FROM gwaRecords WHERE studentName=@studentName AND studentNumber=@studentNumber AND schoolYear=@schoolYear AND semester=@semester"
            Dim command As SqlCommand = New SqlCommand(query, con)
            command.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = cmbSchoolYr.Text
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
            command.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
            command.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = cmbStudNm.Text


            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    ' User already exists
                    MsgBox("Student GWA Record for input School Year and Semester Already Exists.", MsgBoxStyle.Exclamation, "Existing GWA Record.")
                    cod1Cmb.Items.Clear()
                    cod2Cmb.Items.Clear()
                    cod3Cmb.Items.Clear()
                    cod4Cmb.Items.Clear()
                    cod5Cmb.Items.Clear()
                    cod6Cmb.Items.Clear()
                    cod7Cmb.Items.Clear()
                    cod8Cmb.Items.Clear()
                    cod9Cmb.Items.Clear()
                    cod10Cmb.Items.Clear()
                    cod11Cmb.Items.Clear()
                    cod12Cmb.Items.Clear()
                Else
                    ' User does not exist, add them
                    Dim command2 As New SqlCommand("Insert into gwaRecords(studentNumber,studentName,schoolYear,semester,GWA)values(@studentNumber,@studentName,@schoolYear,@semester,@GWA)", con)

                    command2.Parameters.Add("@studentNumber", SqlDbType.NVarChar).Value = cmbStudNo.Text
                    command2.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = cmbStudNm.Text
                    command2.Parameters.Add("@schoolYear", SqlDbType.NVarChar).Value = cmbSchoolYr.Text
                    command2.Parameters.Add("@semester", SqlDbType.NVarChar).Value = cmbSemester.Text
                    command2.Parameters.Add("@GWA", SqlDbType.NVarChar).Value = lblGwa.Text
                    command2.ExecuteNonQuery()
                    MsgBox("Records Successfully Added.", MsgBoxStyle.Information, "Student Record Added")

                    cod1Cmb.Items.Clear()
                    cod2Cmb.Items.Clear()
                    cod3Cmb.Items.Clear()
                    cod4Cmb.Items.Clear()
                    cod5Cmb.Items.Clear()
                    cod6Cmb.Items.Clear()
                    cod7Cmb.Items.Clear()
                    cod8Cmb.Items.Clear()
                    cod9Cmb.Items.Clear()
                    cod10Cmb.Items.Clear()
                    cod11Cmb.Items.Clear()
                    cod12Cmb.Items.Clear()

                    con.Close()
                    bind1()
                End If
            End Using
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        TableFormGWA.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbStudNo.Text = ""
        cmbStudNm.Text = ""
        cmbSchoolYr.Text = ""
        cmbSemester.Text = ""

        lblUnit.Text = ""
        lblGwa.Text = ""
        lblequivalent.Text = ""

        cod1Cmb.Text = ""
        cod2Cmb.Text = ""
        cod3Cmb.Text = ""
        cod4Cmb.Text = ""
        cod5Cmb.Text = ""
        cod6Cmb.Text = ""
        cod7Cmb.Text = ""
        cod8Cmb.Text = ""
        cod9Cmb.Text = ""
        cod10Cmb.Text = ""
        cod11Cmb.Text = ""
        cod12Cmb.Text = ""

        sub1Cmb.Text = ""
        sub2Cmb.Text = ""
        sub3Cmb.Text = ""
        sub4Cmb.Text = ""
        sub5Cmb.Text = ""
        sub6Cmb.Text = ""
        sub7Cmb.Text = ""
        sub8Cmb.Text = ""
        sub9Cmb.Text = ""
        sub10Cmb.Text = ""
        sub11Cmb.Text = ""
        sub12Cmb.Text = ""

        un1Cmb.Text = ""
        un2Cmb.Text = ""
        un3Cmb.Text = ""
        un4Cmb.Text = ""
        un5Cmb.Text = ""
        un6Cmb.Text = ""
        un7Cmb.Text = ""
        un8Cmb.Text = ""
        un9Cmb.Text = ""
        un10Cmb.Text = ""
        un11Cmb.Text = ""
        un12Cmb.Text = ""

        fin1Cmb.Text = ""
        fin2Cmb.Text = ""
        fin3Cmb.Text = ""
        fin4Cmb.Text = ""
        fin5Cmb.Text = ""
        fin6Cmb.Text = ""
        fin7Cmb.Text = ""
        fin8Cmb.Text = ""
        fin9Cmb.Text = ""
        fin10Cmb.Text = ""
        fin11Cmb.Text = ""
        fin12Cmb.Text = ""

        lb1.Text = ""
        lb2.Text = ""
        lb3.Text = ""
        lb4.Text = ""
        lb5.Text = ""
        lb6.Text = ""
        lb7.Text = ""
        lb8.Text = ""
        lb9.Text = ""
        lb10.Text = ""
        lb11.Text = ""
        lb12.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim result As DialogResult = MessageBox.Show("Enter a student GWA record? (This will clear inputs if there are any).", "Enter Student Class Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            cmbStudNo.Enabled = True
            cmbStudNm.Enabled = True
            cmbSchoolYr.Enabled = True
            cmbSemester.Enabled = True

            cod1Cmb.Enabled = True
            cod2Cmb.Enabled = True
            cod3Cmb.Enabled = True
            cod4Cmb.Enabled = True
            cod5Cmb.Enabled = True
            cod6Cmb.Enabled = True
            cod7Cmb.Enabled = True
            cod8Cmb.Enabled = True
            cod9Cmb.Enabled = True
            cod10Cmb.Enabled = True
            cod11Cmb.Enabled = True
            cod12Cmb.Enabled = True

            sub1Cmb.Enabled = True
            sub2Cmb.Enabled = True
            sub3Cmb.Enabled = True
            sub4Cmb.Enabled = True
            sub5Cmb.Enabled = True
            sub6Cmb.Enabled = True
            sub7Cmb.Enabled = True
            sub8Cmb.Enabled = True
            sub9Cmb.Enabled = True
            sub10Cmb.Enabled = True
            sub11Cmb.Enabled = True
            sub12Cmb.Enabled = True

            un1Cmb.Enabled = True
            un2Cmb.Enabled = True
            un3Cmb.Enabled = True
            un4Cmb.Enabled = True
            un5Cmb.Enabled = True
            un6Cmb.Enabled = True
            un7Cmb.Enabled = True
            un8Cmb.Enabled = True
            un9Cmb.Enabled = True
            un10Cmb.Enabled = True
            un11Cmb.Enabled = True
            un12Cmb.Enabled = True

            fin1Cmb.Enabled = True
            fin2Cmb.Enabled = True
            fin3Cmb.Enabled = True
            fin4Cmb.Enabled = True
            fin5Cmb.Enabled = True
            fin6Cmb.Enabled = True
            fin7Cmb.Enabled = True
            fin8Cmb.Enabled = True
            fin9Cmb.Enabled = True
            fin10Cmb.Enabled = True
            fin11Cmb.Enabled = True
            fin12Cmb.Enabled = True
        Else
            MessageBox.Show("No New Record. Inputs and Profile Retained.", "Inputs/Profile", MessageBoxButtons.OK)
        End If
    End Sub

End Class