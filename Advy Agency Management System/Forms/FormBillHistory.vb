Public Class FormBillHistory
    Private Sub FormBillHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Bill"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.btnBills.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Bill Where Cname is like'" & (TextBox1.Text) & "';"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Bill"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
        End Try
    End Sub
End Class