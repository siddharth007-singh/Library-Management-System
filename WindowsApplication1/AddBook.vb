Imports System.Data.OleDb
Public Class AddBook
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bs, p, edition, cat, nameauthor, pyear, status, qty As String

        bs = TextBox1.Text()
        p = TextBox2.Text()
        edition = TextBox3.Text()
        cat = ComboBox1.SelectedItem
        nameauthor = TextBox4.Text()
        pyear = DateTimePicker1.Value()
        status = ComboBox2.SelectedItem
        qty = TextBox5.Text()

        Try
            con = New OleDbConnection("")
            con.Open()
            query = "INSERT INTO [Book_name],[Publisher],[Edition],[Category],[Name_Author],[Publishing_year],[Status],[Quantity] VALUES () "
        Catch ex As Exception

        End Try

    End Sub
End Class