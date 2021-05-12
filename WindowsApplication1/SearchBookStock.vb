Imports System.Data.OleDb
Public Class SearchBookStock
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        If TextBox1.Text = "" Then
            MessageBox.Show("Blank Data could not Submited !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                con.Open()
                query = "select * from bookrecord where Department = '" & TextBox1.Text & "' "
                da = New OleDbDataAdapter(query, con)
                da.Fill(ds, "bookrecord")
                DataGridView1.DataSource = ds
                DataGridView1.DataMember = "bookrecord"
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class