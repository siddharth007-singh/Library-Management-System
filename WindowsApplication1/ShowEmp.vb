Imports System.Data.OleDb
Public Class ShowEmp
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "select* from signin"
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds, "signin")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "signin"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class