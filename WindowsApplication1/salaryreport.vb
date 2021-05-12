Imports System.Data.OleDb
Public Class salaryreport
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub salaryreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "select* from salary "
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds, "salary")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "salary"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class