Public Class FormCustomers
    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdzllaDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.AdzllaDataSet.Customer)
        'TODO: This line of code loads data into the 'AdzillaDataSet.Customer' table. You can move, or remove it, as needed.
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Customer"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            CustomerDataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
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
            sql = "insert into Customer(CustID,Cname,Contact,Email,PaymentReceivable,EmpID) values ('" & txtCustID.Text & "','" & txtCustName.Text & "','" & txtContact.Text & "','" & txtEmail.Text & "','" & txtPayment.Text & "','" & txtEmpID.Text & "');"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!", vbInformation)
                CustomerDataGridView.Refresh()
            Else
                MsgBox("No record has been inserted successfully!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
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
            sql = "UPDATE Customer SET CustID='" & txtCustID.Text & "',CName ='" & txtCustName.Text & "', Contact='" & txtContact.Text & "', Email='" & txtEmail.Text & "', PaymentReceivable='" & txtPayment.Text & "', EmpID='" & txtEmpID.Text & "' WHERE CustID=" & Val(txtCustID.Text) & ""
            cmd.Connection = Form1.con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!", vbInformation)

            Else
                MsgBox("No record has been UPDATED!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Form1.con.Close()

        End Try

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer
        Dim confirm As Boolean
        confirm = MsgBox("Are you sure? You Want to Delete " & txtCustName.Text & "?", vbQuestion + vbYesNo)
        If (confirm = vbYes) Then
            Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                Form1.con.Open()
                sql = "Delete * from Customer WHERE CustID=" & (txtCustID.Text) & ""
                cmd.Connection = Form1.con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record has been deleted successfully!", vbInformation)

                Else
                    MsgBox("No record has been deleted!", vbInformation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                Form1.con.Close()

            End Try
        Else
            MsgBox("No Record Deleted", vbInformation)
            Exit Sub
        End If
    End Sub


    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdzllaDataSet)

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CustomerBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CustomerBindingSource.MoveNext()
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        CustomerBindingSource.MoveLast()
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        txtCustID.Text = CustomerDataGridView.CurrentRow.Cells(0).Value
        txtCustName.Text = CustomerDataGridView.CurrentRow.Cells(1).Value
        txtContact.Text = CustomerDataGridView.CurrentRow.Cells(2).Value
        txtEmail.Text = CustomerDataGridView.CurrentRow.Cells(3).Value
        txtPayment.Text = CustomerDataGridView.CurrentRow.Cells(4).Value
        txtEmpID.Text = CustomerDataGridView.CurrentRow.Cells(5).Value

        ' Above Code will add the data to the textboxes through datagridview
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustID.Text = ""
        txtCustName.Text = ""
        txtContact.Text = ""
        txtDetails.Text = ""
        txtEmail.Text = ""
        txtEmpID.Text = ""
        txtPayment.Text = ""
    End Sub
End Class
