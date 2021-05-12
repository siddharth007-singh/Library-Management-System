Imports System.Data.OleDb
Public Class BookDues
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Private Sub BookDues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Employee

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select * from bookissue where Book_id = '" & TextBox11.Text & "'"
            cmd = New OleDbCommand(query, con)
            rd = cmd.ExecuteReader
            If (rd.Read) Then
                TextBox2.Text = rd("Book_id")
                TextBox3.Text = rd("Book_name")
                TextBox4.Text = rd("Author_name")
                TextBox5.Text = rd("Department")
                TextBox6.Text = rd("Edition")
                TextBox7.Text = rd("Book_price")
                TextBox8.Text = rd("Member_name")
                TextBox9.Text = rd("Contact")
                DateTimePicker2.Value = rd("Publishing_year")
            Else
                MsgBox("Some Issue!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tnx, due, due_date, b_id, b_name, a_name, dep, edi, b_price, mem_name, contact, issue_date As String

        tnx = TextBox1.Text
        b_id = TextBox2.Text
        b_name = TextBox3.Text
        a_name = TextBox4.Text
        dep = TextBox5.Text
        edi = TextBox6.Text
        b_price = TextBox7.Text
        mem_name = TextBox8.Text
        contact = TextBox9.Text
        due = TextBox10.Text
        due_date = DateTimePicker1.Value
        issue_date = DateTimePicker2.Value

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "insert into bookdues ([TNXID],[Book_id],[Book_name],[Author_name],[Department],[Edition],[Book_price],[Member_name],[Contact],[Due_amount],[Due_date],[Issue_date]) values ('" & tnx & "','" & b_id & "','" & b_name & "','" & a_name & "','" & dep & "','" & edi & "','" & b_price & "','" & mem_name & "','" & contact & "','" & due & "','" & due_date & "','" & issue_date & "')"
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Dues Are Collected Successfully")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "UPDATE bookissue SET Due_price = '" & TextBox10.Text & "' + 5 WHERE Book_id = '" & TextBox11.Text & "' "
            cmd = New OleDbCommand(query, con)
            Dim res As Integer
            res = cmd.ExecuteNonQuery()
            If (res > 0) Then
                MessageBox.Show("Data Updated !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Some Issues")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


    End Sub
End Class