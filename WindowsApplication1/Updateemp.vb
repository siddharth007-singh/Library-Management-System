Imports System.Data.OleDb
Public Class Updateemp
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Updateemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "UPDATE signin SET UserID='" & TextBox3.Text & "', Pwd='" & TextBox4.Text & "', FirstName='" & TextBox8.Text & "', LastName='" & TextBox10.Text & "', Confirm='" & TextBox11.Text & "', DateOfJoin='" & TextBox9.Text & "', Post='" & TextBox7.Text & "', Address='" & RichTextBox1.Text & "' WHERE UserID = '" & TextBox1.Text & "' and Phone = '" & TextBox2.Text & "'"

            cmd = New OleDbCommand(query, con)
            Dim res As Integer
            res = cmd.ExecuteNonQuery
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

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select* from signin where UserID='" & TextBox1.Text & "' And Phone='" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                TextBox3.Text = dr("UserID")
                TextBox8.Text = dr("FirstName")
                TextBox10.Text = dr("LastName")
                TextBox4.Text = dr("Pwd")
                TextBox11.Text = dr("Confirm")
                TextBox5.Text = dr("DateOfBirth")
                TextBox6.Text = dr("Phone")
                TextBox7.Text= dr("Post")
                RichTextBox1.Text = dr("Address")
                TextBox9.Text = dr("DateOfJoin")

            Else
                MessageBox.Show("Record Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            query = "Delete from signin where UserID= '" & TextBox1.Text & "' And Phone= '" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            If MessageBox.Show("Are You Sure Watnt To Delete This Record", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox8.Clear()
            TextBox10.Clear()
            TextBox4.Clear()
            TextBox11.Clear()
            TextBox6.Clear()
            RichTextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class