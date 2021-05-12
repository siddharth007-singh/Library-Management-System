Imports System.Data.OleDb
Public Class AdminBookRecord
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Private Sub AdminBookRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "select* from bookrecord"
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds, "bookrecord")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "bookrecord"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class