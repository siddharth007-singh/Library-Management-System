Imports System.Data.OleDb

Public Class BookIssue
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim rd As OleDbDataReader


    Private Sub BookIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Employee
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select * from member,bookrecord where  username = '" & TextBox3.Text & "' And phone = '" & TextBox4.Text & "' And Book_id = '" & TextBox2.Text & "' And Book_name = '" & TextBox1.Text & "' "
            cmd = New OleDbCommand(query, con)
            rd = cmd.ExecuteReader()
            If (rd.Read) Then
                TextBox9.Text = rd("Book_id")
                TextBox5.Text = rd("Book_name")
                TextBox6.Text = rd("Department")
                TextBox7.Text = rd("Edition")
                TextBox8.Text = rd("Author_name")
                DateTimePicker1.Value = rd("Publishing_year")
                TextBox10.Text = rd("firstname")
                TextBox11.Text = rd("phone")
                TextBox12.Text = rd("Book_price")
            Else
                MsgBox("error")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "UPDATE bookrecord SET Status = 1 WHERE Book_id = '" & TextBox9.Text & "' and Book_name = '" & TextBox5.Text & "'"
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

        Dim bid, bname, aname, dep, edi, pyear, memname, mcontact, price As String

        bid = TextBox9.Text
        bname = TextBox5.Text
        aname = TextBox8.Text
        dep = TextBox6.Text
        edi = TextBox7.Text
        pyear = DateTimePicker1.Value
        memname = TextBox10.Text
        mcontact = TextBox11.Text
        price = TextBox12.Text


        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try            con.Open()
            query = "INSERT INTO bookissue ([Book_id],[Book_name],[Author_name],[Department],[Edition],[Publishing_year],[Status],[Member_name],[Contact],[Due_price],[Book_price]) VALUES ('" & bid & "' ,'" & bname & "','" & aname & "','" & dep & "','" & edi & "','" & pyear & "', 1, '" & memname & "' , '" & mcontact & "', 0 , '" & price & "') "
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Issued Successfully")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub
End Class