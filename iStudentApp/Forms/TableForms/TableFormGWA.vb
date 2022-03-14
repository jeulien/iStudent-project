﻿Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class TableFormGWA
    'Dim con As New SqlConnection("Data Source=DESKTOP-64RJ8U5;Initial Catalog=iStudentDB;Integrated Security=True;MultipleActiveResultSets=true")
    Dim con As New SqlConnection("Data Source=SQL5107.site4now.net;Initial Catalog=db_a83e48_istudentdb;User Id=db_a83e48_istudentdb_admin;Password=lula0224;MultipleActiveResultSets=true")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub TableFormGWA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        fileTxt.Text = ""
        locTxt.Text = ""

        Dim checkboxcol As New DataGridViewCheckBoxColumn
        checkboxcol.Width = 65
        checkboxcol.Name = "checkboxcol"
        checkboxcol.HeaderText = "Checked"
        studentGWAView.Columns.Insert(0, checkboxcol)

        bind1()
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From gwaRecords Where 
        Concat(studentNumber,studentName) 
        like '%" & valueToSearch & "%'"
        Dim comm As New SqlCommand(searchQuery, con)
        Dim adap As New SqlDataAdapter(comm)
        Dim tableFil As New DataTable()

        adap.Fill(tableFil)
        studentGWAView.DataSource = tableFil
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        FilterData(searchBox.Text)
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

    Private Sub browseBtn_Click(sender As Object, e As EventArgs) Handles browseBtn.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            locTxt.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub expBtn_Click(sender As Object, e As EventArgs) Handles expBtn.Click
        If locTxt.Text = "" Then
            MessageBox.Show("Save File Location Empty.", "Empty Save Destination", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf fileTxt.Text = "" Then
            MessageBox.Show("PDF Filed Header Title Empty.", "Empty PDF Header Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            studentGWAView.Columns.RemoveAt(0)

            Dim Paragraph As New Paragraph
            Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
            PdfFile.AddTitle(fileTxt.Text)
            Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(locTxt.Text, FileMode.Create))
            PdfFile.Open()

            Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

            Paragraph = New Paragraph(New Chunk(fileTxt.Text, pTitle))
            Paragraph.Alignment = Element.ALIGN_CENTER
            Paragraph.SpacingAfter = 5.0F

            PdfFile.Add(Paragraph)

            Dim PdfTable As New PdfPTable(studentGWAView.Columns.Count)
            PdfTable.TotalWidth = 500.0F
            PdfTable.LockedWidth = True

            Dim widths(0 To studentGWAView.Columns.Count - 1) As Single
            For i As Integer = 0 To studentGWAView.Columns.Count - 1
                widths(i) = 1.0F
            Next
            PdfTable.SetWidths(widths)
            PdfTable.HorizontalAlignment = 0
            PdfTable.SpacingBefore = 5.0F

            Dim pdfcell As PdfPCell = New PdfPCell

            For i As Integer = 0 To studentGWAView.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(New Chunk(studentGWAView.Columns(i).HeaderText, pTable)))
                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
            For i As Integer = 0 To studentGWAView.Rows.Count - 2
                For j As Integer = 0 To studentGWAView.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(studentGWAView(j, i).Value.ToString(), pTable))
                    PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    PdfTable.AddCell(pdfcell)
                Next
            Next
            PdfFile.Add(PdfTable)
            PdfFile.Close()

            MessageBox.Show("PDF format success exported", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim checkboxcol As New DataGridViewCheckBoxColumn
            checkboxcol.Width = 65
            checkboxcol.Name = "checkboxcol"
            checkboxcol.HeaderText = "Checked"
            studentGWAView.Columns.Insert(0, checkboxcol)

            fileTxt.Text = ""
            locTxt.Text = ""

        End If
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete checked records?", "GWA Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            For Each row As DataGridViewRow In studentGWAView.Rows
                Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)
                If select1 Then
                    Dim cmd2 As New SqlCommand("Delete from gwaRecords where studentNumber=@studentNumber AND schoolYear = @schoolYear AND semester = @semester", con)
                    cmd2.Parameters.AddWithValue("@studentNumber", row.Cells("studentNumber").Value)
                    cmd2.Parameters.AddWithValue("@schoolYear", row.Cells("schoolYear").Value)
                    cmd2.Parameters.AddWithValue("@semester", row.Cells("semester").Value)
                    con.Open()
                    cmd2.ExecuteNonQuery()
                    con.Close()
                End If
            Next
            con.Open()
            Dim cmd1 As New SqlCommand("Select studentNumber, studentName, schoolYear, semester, GWA From gwaRecords", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd1
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            studentGWAView.DataSource = dt
            con.Close()
            da.Dispose()
        Else
            MessageBox.Show("Grade Records Maintained.", "GWA Record", MessageBoxButtons.OK)
        End If
    End Sub
End Class