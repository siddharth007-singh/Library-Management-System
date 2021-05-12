
Imports System.Data.OleDb
Public Class EmployeeMemPay
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Private Sub EmployeeMemPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Employee
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim phone As String
        Dim amount As String
        Dim dt As String
        Dim name As String


        username = TextBox2.Text
        phone = TextBox4.Text
        amount = TextBox3.Text
        dt = DateTimePicker1.Value
        name = TextBox1.Text

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "insert into memberpayment([userid],[name],[amount],[date],[phone]) values('" & username & "' ,'" & name & "','" & amount & "','" & dt & "','" & phone & "')"
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        Dim da As OleDbDataAdapter

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "select* from memberpayment"
            da = New OleDbDataAdapter(query, con)
            da.Fill(ds, "memberpayment")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "memberpayment"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class