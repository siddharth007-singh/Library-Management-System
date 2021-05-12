Imports System.Data.OleDb
Public Class Admin

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim rd As OleDbDataReader


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Employeereg.Show()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "SELECT COUNT(*) FROM signin"
            cmd = New OleDbCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label4.Text = count
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "SELECT COUNT(*) FROM member"
            cmd = New OleDbCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label5.Text = count
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


        Try
            con.Open()
            query = "SELECT COUNT(*) FROM bookrecord"
            cmd = New OleDbCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label6.Text = count
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Member.Show()
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Employeereg.Show()

    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        Member.Show()




    End Sub

    Private Sub RemoveEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Updateemp.Show()

    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        updatemem.Show()
    End Sub

    Private Sub RemoveMemberToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
        ShowEmp.Show()

    End Sub

    Private Sub SalaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryReportToolStripMenuItem.Click
        salaryreport.Show()
    End Sub

    Private Sub SearchToolStripMenuItemAdmin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem1.Click
        Showmem.Show()
    End Sub

    Private Sub MemberPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberPaymentToolStripMenuItem.Click
        AdminMempay.Show()
    End Sub

    Private Sub ShowAllToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem2.Click
        AdminBookRecord.Show()
    End Sub

    Private Sub SalaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem1.Click
        AdminSalary.Show()
    End Sub
End Class