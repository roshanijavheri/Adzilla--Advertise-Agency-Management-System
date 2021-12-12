Public Class FormAdModes
    Private Sub ServicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServicesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ServicesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AdzllaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FormAdModes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdzillaDataSet.Services' table. You can move, or remove it, as needed.
        Me.ServicesTableAdapter.Fill(Me.AdzllaDataSet.Services)
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Services"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            ServicesDataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
        End Try

        ' till here Data is Displayed into the Datagridview 


    End Sub



    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim i As Integer
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Form1.con.Open()
            sql = "insert into Services(AdID,AdName,DurationofAdvt,Charges,Mode,Scope,Details) values ('" & txtAdID.Text & "','" & txtAdName.Text & "','" & txtDuration.Text & "','" & txtCharges.Text & "','" & txtMode.Text & "','" & txtScope.Text & "','" & txtDetails.Text & "');"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                ServicesDataGridView.Refresh()
            Else
                MsgBox("No record has been inserted successfully!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Form1.con.Open()
            sql = "UPDATE Services SET AdID='" & txtAdID.Text & "',AdName ='" & txtAdName.Text & "', DurationofAdvt='" & txtDuration.Text & "', Charges='" & txtCharges.Text & "', Mode='" & txtMode.Text & "', Scope='" & txtScope.Text & "', Details='" & txtDetails.Text & "' WHERE AdID=" & Val(txtAdID.Text) & ""
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()

        End Try

    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer
        Dim confirm As Integer
        confirm = MsgBox("You Want to Delete " & txtAdName.Text & "?", vbYesNo + vbCritical)
        If (confirm = vbYes) Then
            Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                Form1.con.Open()
                sql = "Delete * from Services WHERE AdID=" & (txtAdID.Text) & ""
                cmd.Connection = Form1.con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record has been deleted successfully!")

                Else
                    MsgBox("No record has been deleted!")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Form1.con.Close()

            End Try
        Else
            MsgBox("No Record Deleted")
        End If
    End Sub


    Private Sub ServicesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        txtAdID.Text = ServicesDataGridView.CurrentRow.Cells(0).Value
        txtAdName.Text = ServicesDataGridView.CurrentRow.Cells(1).Value
        txtDuration.Text = ServicesDataGridView.CurrentRow.Cells(2).Value
        txtCharges.Text = ServicesDataGridView.CurrentRow.Cells(3).Value
        txtMode.Text = ServicesDataGridView.CurrentRow.Cells(4).Value
        txtScope.Text = ServicesDataGridView.CurrentRow.Cells(5).Value
        txtDetails.Text = ServicesDataGridView.CurrentRow.Cells(6).Value

        ' Above Code will add the data to the textboxes through datagridview
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        ServicesBindingSource.MoveLast()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ServicesBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ServicesBindingSource.MovePrevious()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        ServicesBindingSource.MoveFirst()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdID.Text = ""
        txtAdName.Text = ""
        txtCharges.Text = ""
        txtDetails.Text = ""
        txtDuration.Text = ""
        txtMode.Text = ""
        txtScope.Text = ""
    End Sub


End Class
