Imports System.Data.OleDb
Public Class BookUpdate
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub BookUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Employee
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "update bookrecord set Book_id='" & TextBox6.Text & "', Book_name='" & TextBox5.Text & "', Author_name='" & TextBox3.Text & "', Department='" & TextBox4.Text & "' WHERE Book_id = '" & TextBox1.Text & "' And Book_name = '" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            Dim res As Integer
            res = cmd.ExecuteNonQuery
            If (res > 0) Then
                MessageBox.Show("Data Updated Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Some Issues")
            End If
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select* from bookrecord where book_id='" & TextBox1.Text & "' And Book_name='" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                TextBox6.Text = dr("book_id")
                TextBox5.Text = dr("Book_name")
                TextBox3.Text = dr("Author_name")
                TextBox4.Text = dr("department")
                DateTimePicker1.Value = dr("Publishing_year")

            Else
                MessageBox.Show("Record Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "Delete from bookrecord where book_id= '" & TextBox1.Text & "' And Book_name= '" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            If MessageBox.Show("Are You Sure Watnt To Delete This Record", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class