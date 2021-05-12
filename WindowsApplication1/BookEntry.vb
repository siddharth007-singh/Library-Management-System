Imports System.Data.OleDb
Public Class BookEntry
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bid, bname, aname, dep, edi, pyear, price, status As String

        bid = TextBox6.Text
        bname = TextBox1.Text
        aname = TextBox4.Text
        dep = ComboBox2.SelectedItem
        edi = TextBox3.Text
        pyear = DateTimePicker1.Value
        price = TextBox2.Text

        If TextBox1.Text = "" Then
            MsgBox("Blank Data Could Not be Pass!!")
        Else
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
                con.Open()
                query = "INSERT INTO bookrecord ([Book_id],[Book_name],[Author_name],[Department],[Edition],[Publishing_year],[Status],[Due_price],[Book_price]) VALUES ('" & bid & "' ,'" & bname & "','" & aname & "','" & dep & "','" & edi & "','" & pyear & "',0,0, '" & price & "') "
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox6.Clear()
                TextBox1.Clear()
                TextBox4.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                ComboBox2.SelectedItem.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class