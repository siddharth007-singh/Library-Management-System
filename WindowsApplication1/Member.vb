Imports System.Data.OleDb
Public Class Member
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gen As String = ""
        Dim firstname As String
        Dim lastname As String
        Dim username As String
        Dim dob As String
        Dim doj As String
        Dim phone As String
        Dim adrs As String

        If RadioButton1.Checked Then
            gen = "Male"

        End If

        If RadioButton2.Checked Then
            gen = "Female"
        End If


        firstname = TextBox1.Text
        lastname = TextBox2.Text
        username = TextBox3.Text
        dob = DateTimePicker1.Text
        doj = DateTimePicker2.Text
        phone = TextBox6.Text
        adrs = RichTextBox1.Text

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "insert into member([firstname],[lastname],[username],[gender],[dateofbirth],[phone],[dateofjoin],[address])values('" & firstname & "' ,'" & lastname & "' ,'" & username & "' ,'" & gen & "' ,'" & dob & "' ,'" & phone & "' ,'" & doj & "' ,'" & adrs & "')"

            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try



    End Sub

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin
    End Sub
End Class