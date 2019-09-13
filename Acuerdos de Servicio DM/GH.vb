Public Class GH
    Private Access As New DBControl
    Public AreaProveedora As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Access.ExecQuery("SELECT * FROM Produccion WHERE Personas IS NOT NULL")
        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()
        AreaProveedora = "PRODUCCION"
        For Each R As DataRow In Access.DBDT.Rows
            ComboBox1.Items.Add(R("Personas"))
        Next
        Access.ExecQuery("SELECT * FROM Produccion WHERE GH IS NOT NULL")
        For Each D As DataRow In Access.DBDT.Rows
            ListBox1.Items.Add(D("GH"))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Access.ExecQuery("SELECT * FROM Calidad WHERE Personas IS NOT NULL")
        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()
        AreaProveedora = "CALIDAD"
        For Each R As DataRow In Access.DBDT.Rows
            ComboBox1.Items.Add(R("Personas"))
        Next
        Access.ExecQuery("SELECT * FROM Calidad WHERE GH IS NOT NULL")
        For Each D As DataRow In Access.DBDT.Rows
            ListBox1.Items.Add(D("GH"))
        Next
    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click
        Dim Usuario As String
        Dim Fecha As Date
        Dim AreaEvaluadora As String
        Dim Acuerdo As String
        Dim Evaluado As String
        Dim Calificacion As String
        Dim Comentario As String
        AreaEvaluadora = Area.Text
        Usuario = Principal.Tag
        Fecha = Format(Now, "Short Date")
        Acuerdo = ListBox1.Text
        Evaluado = ComboBox1.Text
        Comentario = Comentarios.Text
        If RadioButton1.Checked = True Then
            Calificacion = "ME GUSTA"
        Else
            Calificacion = "NO ME GUSTA"
        End If

        If Comentario = "" Or Acuerdo = "" Or Evaluado = "" Or RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("RECUERDA SELECCIONAR TODOS LOS CAMPOS")
        Else
            Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
            Dim Libro = ExcelApp.Workbooks.Open("S:\Calidad\S.I.G.C\INDICADORES\DBExcel.xlsx")
            Dim Final As Long
            Final = nReg(Libro.Worksheets("Base de Datos"), 1, 1)
            Libro.Worksheets("Base de Datos").Cells(Final, 1) = Usuario
            Libro.Worksheets("Base de Datos").Cells(Final, 2) = Fecha
            Libro.Worksheets("Base de Datos").Cells(Final, 3) = Acuerdo
            Libro.Worksheets("Base de Datos").Cells(Final, 4) = AreaEvaluadora
            Libro.Worksheets("Base de Datos").Cells(Final, 5) = AreaProveedora
            Libro.Worksheets("Base de Datos").Cells(Final, 6) = Evaluado
            Libro.Worksheets("Base de Datos").Cells(Final, 7) = Calificacion
            Libro.Worksheets("Base de Datos").Cells(Final, 8) = Comentario

            MsgBox("GRACIAS POR TU VALORACION")

            Libro.Save()
            ExcelApp.Quit()
            Libro = Nothing
            ExcelApp = Nothing
            ComboBox1.Items.Clear()
            ListBox1.Items.Clear()
            Comentarios.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        End If
    End Sub
End Class
