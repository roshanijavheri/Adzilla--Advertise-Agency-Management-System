Public Class FormStaff
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim i As Integer
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Form1.con.Open()
            sql = "insert into Staff(EmpID,EName,Designation,Salary,JoiningDate,Gender,DOB,Contact,Address,Email) values ('" & txtEmpID.Text & "','" & txtEmpName.Text & "','" & txtDesignation.Text & "','" & txtSalary.Text & "','" & dtJoiningDate.Text & "','" & cmbGender.Text & "','" & dtDOB.Text & "','" & txtContact.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "');"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!", vbInformation)

            Else
                MsgBox("No record has been inserted successfully!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
            Load_Data()
        End Try

    End Sub
    Public Sub Load_Data()
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            Form1.con.Open()
            sql = "Select * from Staff"
            cmd.Connection = Form1.con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            StaffDataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()
        End Try

        ' till here Data is Displayed into the Datagridview 
    End Sub
    Private Sub FormStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdzllaDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.AdzllaDataSet.Staff)
        Load_Data()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Form1.con.Open()
            sql = "UPDATE Staff SET EmpID='" & txtEmpID.Text & "', EName ='" & txtEmpName.Text & "', Designation='" & txtDesignation.Text & "',Salary='" & txtSalary.Text & "',JoiningDate='" & dtJoiningDate.Text & "',Gender='" & cmbGender.Text & "',DOB='" & dtDOB.Text & "',Contact='" & txtContact.Text & "',Address='" & txtAddress.Text & "', Email='" & txtEmail.Text & "' WHERE EmpID=" & Val(txtEmpID.Text) & ""
            cmd.Connection = Form1.con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been UPDATED successfully!", vbInformation)

            Else
                MsgBox("No record has been UPDATED!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Form1.con.Close()

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i, confirm As Integer

        confirm = MsgBox("You Want to Delete " & txtEmpName.Text & "?", vbQuestion + vbYesNo, "Please Confirm!!!")
        If (confirm = vbYes) Then
            Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                Form1.con.Open()
                sql = "Delete * from Staff WHERE EmpID=" & (txtEmpID.Text) & ""
                cmd.Connection = Form1.con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record has been deleted successfully!", vbInformation)

                Else
                    MsgBox("No record has been deleted!", vbInformation)
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



    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdzllaDataSet)

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        StaffBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        StaffBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        StaffBindingSource.MoveNext()
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        StaffBindingSource.MoveLast()
    End Sub

    Private Sub StaffDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        txtEmpID.Text = StaffDataGridView.CurrentRow.Cells(0).Value
        txtEmpName.Text = StaffDataGridView.CurrentRow.Cells(1).Value
        txtDesignation.Text = StaffDataGridView.CurrentRow.Cells(2).Value
        txtSalary.Text = StaffDataGridView.CurrentRow.Cells(3).Value
        dtJoiningDate.Value = StaffDataGridView.CurrentRow.Cells(4).Value
        cmbGender.Text = StaffDataGridView.CurrentRow.Cells(5).Value
        dtDOB.Value = StaffDataGridView.CurrentRow.Cells(6).Value
        txtContact.Text = StaffDataGridView.CurrentRow.Cells(7).Value
        txtAddress.Text = StaffDataGridView.CurrentRow.Cells(8).Value
        txtEmail.Text = StaffDataGridView.CurrentRow.Cells(9).Value
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmpID.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtDesignation.Text = ""
        txtEmail.Text = ""
        txtEmpName.Text = ""
        txtSalary.Text = ""


    End Sub
End Class
