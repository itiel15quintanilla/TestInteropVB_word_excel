Public Class Form1
    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        Dim word = New Microsoft.Office.Interop.Word.Application
        Dim wordApp = word.Application()

        Dim ruta, dato As String

        If (SaveFileDialog1.ShowDialog() <> DialogResult.OK) Then

        End If

        ruta = SaveFileDialog1.FileName
        wordApp.Visible = True
        wordApp.Documents.Add()
        dato = TxtDato.Text

        wordApp.Selection.TypeText(dato)
        wordApp.ActiveDocument.SaveAs2(ruta)

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim excel = New Microsoft.Office.Interop.Excel.Application
        Dim excelApp = excel.Application()

        Dim ruta As String

        If (SaveFileDialog1.ShowDialog() <> DialogResult.OK) Then

            Return

        End If

        ruta = SaveFileDialog1.FileName
        excelApp.Visible = True

        Dim workbook = excelApp.Workbooks.Add()
        Dim worksheet = workbook.ActiveSheet


        worksheet.cells(1, 1) = "Hola Mundo"
        worksheet.cells(2, 1) = TxtDatoE.Text


        workbook.SaveAs(ruta)

    End Sub
End Class
