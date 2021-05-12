Imports System.Data.OleDb
Public Class Employeereg
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LineShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gen As String = ""

        Dim Fname As String
        Dim Lname As String
        Dim UserName As String

        Dim Pwd As String
        Dim dob As String
        Dim doj As String
        Dim post As String
        Dim phone As String
        Dim adrs As String
        Dim usertype As String
        Dim confirm As String

        If RadioButton1.Checked Then
            gen = "Male"

        End If

        If RadioButton2.Checked Then
            gen = "Female"
        End If



        Fname = TextBox1.Text
        Lname = TextBox2.Text
        UserName = TextBox3.Text
        Pwd = TextBox4.Text
        dob = DateTimePicker1.Text
        doj = DateTimePicker2.Text
        phone = TextBox6.Text
        post = ComboBox1.SelectedItem
        adrs = RichTextBox1.Text
        usertype = ComboBox2.SelectedItem
        confirm = TextBox5.Text


        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "insert into signin([UserID],[Pwd],[UserType],[FirstName],[LastName],[Gender],[Confirm],[DateOfBirth],[DateOfjoin],[Post],[Phone],[Address])values('" & UserName & "' ,'" & Pwd & "','" & usertype & "','" & Fname & "','" & Lname & "','" & gen & "','" & confirm & "','" & dob & "','" & doj & "','" & post & "','" & phone & "','" & adrs & "')"
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try



    End Sub

    Private Sub Employeereg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin

    End Sub
End Class