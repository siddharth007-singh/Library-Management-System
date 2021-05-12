Imports System.Data.OleDb
Public Class Employee

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim query As String
    Dim rd As OleDbDataReader

    Private Sub Back_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntryToolStripMenuItem.Click
        BookEntry.Show()
    End Sub

    Private Sub IssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueToolStripMenuItem.Click
        BookIssue.Show()
    End Sub

    Private Sub DuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuesToolStripMenuItem.Click
        BookReturn.Show()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        BookUpdate.Show()
    End Sub

    Private Sub DuesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DuesToolStripMenuItem1.Click
        BookDues.Show()
    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        EmployeeAddMem.Show()
    End Sub

    Private Sub RemoveMemeberToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        EmployeeMemPay.Show()
    End Sub

    Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
        EmpMemberShow.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        EmpBookStock.Show()
    End Sub

    Private Sub UpdateRemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRemoveToolStripMenuItem.Click
        EmployRemoveMember.Show()
    End Sub

    Private Sub BookStockSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookStockSearchToolStripMenuItem.Click
        SearchBookStock.Show()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "SELECT COUNT(*) FROM bookrecord"
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
            query = "SELECT COUNT(*) FROM member"
            cmd = New OleDbCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label6.Text = count
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


        Try
            con.Open()
            query = "SELECT COUNT(*) FROM bookissue"
            cmd = New OleDbCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label7.Text = count
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


        Try
            con.Open()
            query = "SELECT COUNT(*) FROM bookdues"
            cmd = New OleDbCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label8.Text = count
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub
End Class