Public Class FormReports
    Private Sub btnShowCustRepo_Click(sender As Object, e As EventArgs) Handles btnShowCustRepo.Click
        If rdAllCust.Checked = True Then
            FormCustomerReports.Show()
        ElseIf rdCustByName.Checked = True Then
            CustByName.Show()
        ElseIf rdCustAmtReceivable.Checked = True Then
            CustbyAmt.Show()
        End If
    End Sub


    Private Sub btnShowBillRepo_Click(sender As Object, e As EventArgs) Handles btnShowBillRepo.Click
        If rdAllBills.Checked = True Then
            BillRepo.Show()
        ElseIf rdBillbyBno.Checked = True Then
            BillByBno.Show()
        ElseIf rdBillAbove.Checked = True Then
            BillAboveAmt.Show()
        End If
    End Sub

    Private Sub btnShowStaffRepo_Click(sender As Object, e As EventArgs) Handles btnShowStaffRepo.Click
        If rdAllEmp.Checked = True Then
            StaffRepo.Show()
        ElseIf rdByDesignation.Checked = True Then
            StaffDesignationRepo.Show()
        ElseIf rdBySalary.Checked = True Then
            StaffbySalary.Show()
        End If
    End Sub

    Private Sub btnShowServiceRepo_Click(sender As Object, e As EventArgs) Handles btnShowServiceRepo.Click
        If rdAllServices.Checked = True Then
            ServiceRepo.Show()
        ElseIf rdServicesUnder.Checked = True Then
            ServicesUnder.Show()
        End If
    End Sub
End Class