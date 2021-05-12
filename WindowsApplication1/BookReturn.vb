Imports System.Data.OleDb
Public Class BookReturn

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim rd As OleDbDataReader

    Private Sub BookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Employee
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select * from bookrecord where Book_id = '" & TextBox2.Text & "' "
            cmd = New OleDbCommand(query, con)
            rd = cmd.ExecuteReader()
            If (rd.Read) Then
                TextBox5.Text = rd("Book_name")
                TextBox6.Text = rd("Author_name")
                TextBox7.Text = rd("Department")
                TextBox8.Text = rd("Edition")
                DateTimePicker1.Value = rd("Publishing_year")
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
            query = "UPDATE bookrecord SET Status = 0 WHERE Book_id = '" & TextBox2.Text & "'"
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

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "UPDATE bookissue SET Status = 0 WHERE Book_id = '" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            Dim ress As Integer
            ress = cmd.ExecuteNonQuery()
            If (ress > 0) Then
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