<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdCustAmtReceivable = New System.Windows.Forms.RadioButton()
        Me.rdCustByName = New System.Windows.Forms.RadioButton()
        Me.rdAllCust = New System.Windows.Forms.RadioButton()
        Me.btnShowCustRepo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdBillbyBno = New System.Windows.Forms.RadioButton()
        Me.rdBillAbove = New System.Windows.Forms.RadioButton()
        Me.rdAllBills = New System.Windows.Forms.RadioButton()
        Me.btnShowBillRepo = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdServicesUnder = New System.Windows.Forms.RadioButton()
        Me.rdAllServices = New System.Windows.Forms.RadioButton()
        Me.btnShowServiceRepo = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdBySalary = New System.Windows.Forms.RadioButton()
        Me.rdByDesignation = New System.Windows.Forms.RadioButton()
        Me.rdAllEmp = New System.Windows.Forms.RadioButton()
        Me.btnShowStaffRepo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rdCustAmtReceivable)
        Me.Panel1.Controls.Add(Me.rdCustByName)
        Me.Panel1.Controls.Add(Me.rdAllCust)
        Me.Panel1.Controls.Add(Me.btnShowCustRepo)
        Me.Panel1.Location = New System.Drawing.Point(89, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 246)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customers Reports"
        '
        'rdCustAmtReceivable
        '
        Me.rdCustAmtReceivable.AutoSize = True
        Me.rdCustAmtReceivable.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCustAmtReceivable.Location = New System.Drawing.Point(39, 148)
        Me.rdCustAmtReceivable.Name = "rdCustAmtReceivable"
        Me.rdCustAmtReceivable.Size = New System.Drawing.Size(184, 25)
        Me.rdCustAmtReceivable.TabIndex = 1
        Me.rdCustAmtReceivable.TabStop = True
        Me.rdCustAmtReceivable.Text = "Cust Amt Receivable"
        Me.rdCustAmtReceivable.UseVisualStyleBackColor = True
        '
        'rdCustByName
        '
        Me.rdCustByName.AutoSize = True
        Me.rdCustByName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCustByName.Location = New System.Drawing.Point(39, 108)
        Me.rdCustByName.Name = "rdCustByName"
        Me.rdCustByName.Size = New System.Drawing.Size(136, 25)
        Me.rdCustByName.TabIndex = 1
        Me.rdCustByName.TabStop = True
        Me.rdCustByName.Text = "Cust By Name"
        Me.rdCustByName.UseVisualStyleBackColor = True
        '
        'rdAllCust
        '
        Me.rdAllCust.AutoSize = True
        Me.rdAllCust.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAllCust.Location = New System.Drawing.Point(39, 66)
        Me.rdAllCust.Name = "rdAllCust"
        Me.rdAllCust.Size = New System.Drawing.Size(133, 25)
        Me.rdAllCust.TabIndex = 1
        Me.rdAllCust.TabStop = True
        Me.rdAllCust.Text = "All Customers"
        Me.rdAllCust.UseVisualStyleBackColor = True
        '
        'btnShowCustRepo
        '
        Me.btnShowCustRepo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnShowCustRepo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCustRepo.Location = New System.Drawing.Point(0, 202)
        Me.btnShowCustRepo.Name = "btnShowCustRepo"
        Me.btnShowCustRepo.Size = New System.Drawing.Size(256, 44)
        Me.btnShowCustRepo.TabIndex = 0
        Me.btnShowCustRepo.Text = "Show Report"
        Me.btnShowCustRepo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.rdBillbyBno)
        Me.Panel2.Controls.Add(Me.rdBillAbove)
        Me.Panel2.Controls.Add(Me.rdAllBills)
        Me.Panel2.Controls.Add(Me.btnShowBillRepo)
        Me.Panel2.Location = New System.Drawing.Point(410, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 246)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Billing Reports"
        '
        'rdBillbyBno
        '
        Me.rdBillbyBno.AutoSize = True
        Me.rdBillbyBno.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBillbyBno.Location = New System.Drawing.Point(54, 111)
        Me.rdBillbyBno.Name = "rdBillbyBno"
        Me.rdBillbyBno.Size = New System.Drawing.Size(128, 25)
        Me.rdBillbyBno.TabIndex = 1
        Me.rdBillbyBno.TabStop = True
        Me.rdBillbyBno.Text = "Bill by Bill No"
        Me.rdBillbyBno.UseVisualStyleBackColor = True
        '
        'rdBillAbove
        '
        Me.rdBillAbove.AutoSize = True
        Me.rdBillAbove.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBillAbove.Location = New System.Drawing.Point(54, 152)
        Me.rdBillAbove.Name = "rdBillAbove"
        Me.rdBillAbove.Size = New System.Drawing.Size(140, 25)
        Me.rdBillAbove.TabIndex = 1
        Me.rdBillAbove.TabStop = True
        Me.rdBillAbove.Text = "Bill Above Amt"
        Me.rdBillAbove.UseVisualStyleBackColor = True
        '
        'rdAllBills
        '
        Me.rdAllBills.AutoSize = True
        Me.rdAllBills.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAllBills.Location = New System.Drawing.Point(56, 70)
        Me.rdAllBills.Name = "rdAllBills"
        Me.rdAllBills.Size = New System.Drawing.Size(81, 25)
        Me.rdAllBills.TabIndex = 1
        Me.rdAllBills.TabStop = True
        Me.rdAllBills.Text = "All Bills"
        Me.rdAllBills.UseVisualStyleBackColor = True
        '
        'btnShowBillRepo
        '
        Me.btnShowBillRepo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnShowBillRepo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowBillRepo.Location = New System.Drawing.Point(0, 202)
        Me.btnShowBillRepo.Name = "btnShowBillRepo"
        Me.btnShowBillRepo.Size = New System.Drawing.Size(256, 44)
        Me.btnShowBillRepo.TabIndex = 0
        Me.btnShowBillRepo.Text = "Show Report"
        Me.btnShowBillRepo.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.rdServicesUnder)
        Me.Panel3.Controls.Add(Me.rdAllServices)
        Me.Panel3.Controls.Add(Me.btnShowServiceRepo)
        Me.Panel3.Location = New System.Drawing.Point(410, 286)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 246)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Services Reports"
        '
        'rdServicesUnder
        '
        Me.rdServicesUnder.AutoSize = True
        Me.rdServicesUnder.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdServicesUnder.Location = New System.Drawing.Point(49, 133)
        Me.rdServicesUnder.Name = "rdServicesUnder"
        Me.rdServicesUnder.Size = New System.Drawing.Size(142, 25)
        Me.rdServicesUnder.TabIndex = 1
        Me.rdServicesUnder.TabStop = True
        Me.rdServicesUnder.Text = "Under Amount"
        Me.rdServicesUnder.UseVisualStyleBackColor = True
        '
        'rdAllServices
        '
        Me.rdAllServices.AutoSize = True
        Me.rdAllServices.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAllServices.Location = New System.Drawing.Point(49, 77)
        Me.rdAllServices.Name = "rdAllServices"
        Me.rdAllServices.Size = New System.Drawing.Size(112, 25)
        Me.rdAllServices.TabIndex = 1
        Me.rdAllServices.TabStop = True
        Me.rdAllServices.Text = "All Services"
        Me.rdAllServices.UseVisualStyleBackColor = True
        '
        'btnShowServiceRepo
        '
        Me.btnShowServiceRepo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnShowServiceRepo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowServiceRepo.Location = New System.Drawing.Point(0, 202)
        Me.btnShowServiceRepo.Name = "btnShowServiceRepo"
        Me.btnShowServiceRepo.Size = New System.Drawing.Size(256, 44)
        Me.btnShowServiceRepo.TabIndex = 0
        Me.btnShowServiceRepo.Text = "Show Report"
        Me.btnShowServiceRepo.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.rdBySalary)
        Me.Panel4.Controls.Add(Me.rdByDesignation)
        Me.Panel4.Controls.Add(Me.rdAllEmp)
        Me.Panel4.Controls.Add(Me.btnShowStaffRepo)
        Me.Panel4.Location = New System.Drawing.Point(89, 286)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(256, 246)
        Me.Panel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Staff Reports"
        '
        'rdBySalary
        '
        Me.rdBySalary.AutoSize = True
        Me.rdBySalary.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBySalary.Location = New System.Drawing.Point(39, 148)
        Me.rdBySalary.Name = "rdBySalary"
        Me.rdBySalary.Size = New System.Drawing.Size(96, 25)
        Me.rdBySalary.TabIndex = 1
        Me.rdBySalary.TabStop = True
        Me.rdBySalary.Text = "By Salary"
        Me.rdBySalary.UseVisualStyleBackColor = True
        '
        'rdByDesignation
        '
        Me.rdByDesignation.AutoSize = True
        Me.rdByDesignation.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdByDesignation.Location = New System.Drawing.Point(39, 108)
        Me.rdByDesignation.Name = "rdByDesignation"
        Me.rdByDesignation.Size = New System.Drawing.Size(142, 25)
        Me.rdByDesignation.TabIndex = 1
        Me.rdByDesignation.TabStop = True
        Me.rdByDesignation.Text = "By Designation"
        Me.rdByDesignation.UseVisualStyleBackColor = True
        '
        'rdAllEmp
        '
        Me.rdAllEmp.AutoSize = True
        Me.rdAllEmp.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAllEmp.Location = New System.Drawing.Point(39, 66)
        Me.rdAllEmp.Name = "rdAllEmp"
        Me.rdAllEmp.Size = New System.Drawing.Size(133, 25)
        Me.rdAllEmp.TabIndex = 1
        Me.rdAllEmp.TabStop = True
        Me.rdAllEmp.Text = "All Employees"
        Me.rdAllEmp.UseVisualStyleBackColor = True
        '
        'btnShowStaffRepo
        '
        Me.btnShowStaffRepo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnShowStaffRepo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowStaffRepo.Location = New System.Drawing.Point(0, 202)
        Me.btnShowStaffRepo.Name = "btnShowStaffRepo"
        Me.btnShowStaffRepo.Size = New System.Drawing.Size(256, 44)
        Me.btnShowStaffRepo.TabIndex = 0
        Me.btnShowStaffRepo.Text = "Show Report"
        Me.btnShowStaffRepo.UseVisualStyleBackColor = True
        '
        'FormReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 556)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormReports"
        Me.Text = "Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdCustAmtReceivable As RadioButton
    Friend WithEvents rdCustByName As RadioButton
    Friend WithEvents rdAllCust As RadioButton
    Friend WithEvents btnShowCustRepo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents rdBillbyBno As RadioButton
    Friend WithEvents rdBillAbove As RadioButton
    Friend WithEvents rdAllBills As RadioButton
    Friend WithEvents btnShowBillRepo As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents rdServicesUnder As RadioButton
    Friend WithEvents rdAllServices As RadioButton
    Friend WithEvents btnShowServiceRepo As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents rdBySalary As RadioButton
    Friend WithEvents rdByDesignation As RadioButton
    Friend WithEvents rdAllEmp As RadioButton
    Friend WithEvents btnShowStaffRepo As Button
End Class
