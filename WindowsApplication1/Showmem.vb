
Imports System.Data.OleDb
Public Class Showmem
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Showmem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "select * from member "
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds, "member")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "member"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class