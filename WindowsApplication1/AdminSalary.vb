Imports System.Data.OleDb

Public Class AdminSalary
    Dim con As OleDbConnection
    Dim query As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub AdminSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Admin

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
        Try
            con.Open()
            query = "select * from signin where UserID = '" & TextBox2.Text & "'"
            cmd = New OleDbCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                TextBox4.Text = dr("FirstName")
                TextBox1.Text = dr("Phone")
                DateTimePicker2.Value = dr("DateOfJoin")
            Else
                MessageBox.Show("Record Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tnid, fname, contact, doj, salary_m, att_day, pay_amt, da, hra, pay_date As String

        tnid = TextBox8.Text
        fname = TextBox4.Text
        contact = TextBox1.Text
        pay_amt = TextBox3.Text
        pay_date = DateTimePicker1.Value
        att_day = TextBox5.Text
        da = TextBox7.Text
        hra = TextBox6.Text
        doj = DateTimePicker2.Value
        salary_m = TextBox9.Text

        Dim total_pay As String

        total_pay = pay_amt / 30 + da + hra - att_day

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DBVB\Modern database\Librarymanagement.accdb")
            con.Open()
            query = "insert into emp_payment([TranID],[FirstName],[Contact],[DateOfJoin],[salary_month],[attend_day],[pay_amt],[Da],[Hra],[payment_date],[Total_Amount_Paid]) values('" & tnid & "' ,'" & fname & "','" & contact & "','" & doj & "','" & salary_m & "','" & att_day & "','" & pay_amt & "','" & da & "','" & hra & "','" & pay_date & "', '" & total_pay & "')"
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class