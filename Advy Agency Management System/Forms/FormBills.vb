Public Class FormBills
    Private Sub FormBills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dr As OleDb.OleDbDataReader
            Form1.con.Open()
            sql = "Select * from Services"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBox1.Items.Add(dr.GetString(1))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Form1.con.Close()
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Exists As Boolean
        For Each item As DataGridViewRow In DataGridView1.Rows
            If item.Cells(1).Value = ComboBox1.Text Then
                Exists = True
            End If
        Next
        If DataGridView1.Rows.Count > 0 AndAlso Exists = True Then
            MsgBox("Service Already Exist in Bill")
            Exit Sub
        Else
            Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                Dim dr As OleDb.OleDbDataReader
                Form1.con.Open()
                sql = "Select * from Services Where AdName = '" & (ComboBox1.Text) & "' "
                cmd.Connection = Form1.con
                cmd.CommandText = sql
                dr = cmd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count, dr.GetString(1), dr.GetString(2), dr.GetValue(3))
                End While
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                Form1.con.Close()
            End Try
        End If
        'DataGridView1.Rows.Add(DataGridView1.Rows.Count, ComboBox1.SelectedItem.ToString)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Form1.OpenChildForm(New FormBillHistory)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim index As Integer
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Total As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            Total += DataGridView1.Rows(i).Cells(3).Value
        Next
        If (txtGST.Text <> "") Then
            Total += Val(txtGST.Text)
            txtTotal.Text = Total
        Else
            MsgBox("GST is not Included")
            txtTotal.Text = Total
        End If
    End Sub



    Private Sub txtPaidBill_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaidBill.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            txtBalance.Text = Val(txtTotal.Text) - Val(txtPaidBill.Text)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim i As Integer
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Form1.con.Open()
            sql = "insert into Bill values ('" & txtBno.Text & "','" & txtCname.Text & "','" & txtTotal.Text & "','" & txtPaidBill.Text & "','" & txtBalance.Text & "','" + DateTimePicker1.Value.Date + "');"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                PrintDialog1.Document = PrintDocument1
                PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
                PrintDialog1.AllowSomePages = True
                If PrintDialog1.ShowDialog = DialogResult.OK Then
                    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintDocument1.Print()
                End If
            Else
                MsgBox("No record has been inserted successfully!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
        End Try

    End Sub

End Class