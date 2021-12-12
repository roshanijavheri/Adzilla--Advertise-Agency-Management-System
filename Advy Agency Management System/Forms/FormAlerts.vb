Public Class FormAlerts
    Private Sub FormAlerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Customer Where PaymentReceivable > 0"
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