Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class TableFormProfiles
   
    Private Sub TableFormProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        fileTxt.Text = ""
        locTxt.Text = ""

        bind1()
    End Sub
    Public Sub FilterData(valueToSearch As String)
        'method to search records in database
        Dim searchQuery As String = "SELECT * From studentProfiles Where Concat(studentNumber,lastName,firstName,gender,studentType,course,year) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim tableFill As New DataTable()

        adapter.Fill(tableFill)
        studentProfileView.DataSource = tableFill
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        FilterData(searchBox.Text)
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
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

            Dim PdfTable As New PdfPTable(studentProfileView.Columns.Count)
            PdfTable.TotalWidth = 500.0F
            PdfTable.LockedWidth = True

            Dim widths(0 To studentProfileView.Columns.Count - 1) As Single
            For i As Integer = 0 To studentProfileView.Columns.Count - 1
                widths(i) = 1.0F
            Next
            PdfTable.SetWidths(widths)
            PdfTable.HorizontalAlignment = 0
            PdfTable.SpacingBefore = 5.0F

            Dim pdfcell As PdfPCell = New PdfPCell

            For i As Integer = 0 To studentProfileView.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(New Chunk(studentProfileView.Columns(i).HeaderText, pTable)))
                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
            For i As Integer = 0 To studentProfileView.Rows.Count - 2
                For j As Integer = 0 To studentProfileView.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(studentProfileView(j, i).Value.ToString(), pTable))
                    PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    PdfTable.AddCell(pdfcell)
                Next
            Next
            PdfFile.Add(PdfTable)
            PdfFile.Close()

            MessageBox.Show("PDF format success exported", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)


            fileTxt.Text = ""
            locTxt.Text = ""

        End If
    End Sub
End Class
