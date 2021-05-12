Imports System.Data.OleDb
Public Class Form1
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String

    Dim userName As String
    Dim password As String
    Dim userType As String
    Dim rd As OleDbDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userName = TextBox1.Text
        password = TextBox2.Text
        userType = ComboBox1.SelectedItem

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")


            con.Open()
            query = "select * from signin where UserID = '" & userName & "' And Pwd = '" & password & "'"

            cmd = New OleDbCommand(query, con)
            rd = cmd.ExecuteReader
            If (rd.Read) Then
                If userName = rd("userID") And password = rd("Pwd") And userType = "ADMIN" Then
                    Admin.Show()


                    Me.Hide()

                ElseIf userName = rd("userID") And password = rd("Pwd") And userType = "EMPLOYEE" Then
                    Employee.Show()

                    Me.Hide()

                Else
                    MessageBox.Show("Invalid UserName or Password", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                MessageBox.Show("This Record Doesn't Match", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            con.Close()
        End Try


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        


    End Sub


  

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(120, 250, 252, 240)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
