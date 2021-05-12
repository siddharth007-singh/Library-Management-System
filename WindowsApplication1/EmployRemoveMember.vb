Imports System.Data.OleDb
Public Class EmployRemoveMember
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub EmployRemoveMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Employee
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "update member set firstname='" & TextBox8.Text & "', lastname='" & TextBox10.Text & "', username='" & TextBox3.Text & "', dateofbirth='" & TextBox4.Text & "', phone='" & TextBox6.Text & "', dateofjoin='" & TextBox5.Text & "', address='" & RichTextBox1.Text & "'WHERE username = '" & TextBox1.Text & "' And phone = '" & TextBox2.Text & "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select* from member where username='" & TextBox1.Text & "' And phone='" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                TextBox3.Text = dr("username")
                TextBox8.Text = dr("firstname")
                TextBox10.Text = dr("lastname")

                TextBox4.Text = dr("dateofbirth")
                TextBox5.Text = dr("dateofjoin")
                TextBox6.Text = dr("Phone")


                RichTextBox1.Text = dr("address")
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
            query = "Delete from member where username= '" & TextBox1.Text & "' And phone= '" & TextBox2.Text & "'"
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