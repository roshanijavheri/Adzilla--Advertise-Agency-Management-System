<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBills
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Service = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPaidBill = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebsiteLink = New System.Windows.Forms.LinkLabel()
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.txtCname = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPaidBill)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtGST)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtCname)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 711)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr, Me.Service, Me.Duration, Me.Charges})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(812, 338)
        Me.DataGridView1.TabIndex = 20
        '
        'Sr
        '
        Me.Sr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sr.DefaultCellStyle = DataGridViewCellStyle5
        Me.Sr.HeaderText = "Sr."
        Me.Sr.Name = "Sr"
        Me.Sr.Width = 45
        '
        'Service
        '
        Me.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Service.DefaultCellStyle = DataGridViewCellStyle6
        Me.Service.HeaderText = "Service"
        Me.Service.Name = "Service"
        '
        'Duration
        '
        Me.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duration.DefaultCellStyle = DataGridViewCellStyle7
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        Me.Duration.Width = 72
        '
        'Charges
        '
        Me.Charges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Charges.DefaultCellStyle = DataGridViewCellStyle8
        Me.Charges.HeaderText = "Charges"
        Me.Charges.Name = "Charges"
        Me.Charges.Width = 71
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(621, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 26)
        Me.DateTimePicker1.TabIndex = 19
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(175, 569)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(196, 26)
        Me.txtBalance.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(98, 572)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Balance"
        '
        'txtPaidBill
        '
        Me.txtPaidBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidBill.Location = New System.Drawing.Point(175, 537)
        Me.txtPaidBill.Name = "txtPaidBill"
        Me.txtPaidBill.Size = New System.Drawing.Size(196, 26)
        Me.txtPaidBill.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Paid Amt :"
        '
        'txtGST
        '
        Me.txtGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGST.Location = New System.Drawing.Point(619, 534)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(196, 26)
        Me.txtGST.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(553, 540)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "GST :"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(619, 566)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(196, 26)
        Me.txtTotal.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(535, 571)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total Bill :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 634)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Thank You for Choosing Us !!!"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.WebsiteLink)
        Me.Panel1.Controls.Add(Me.lblShopName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 88)
        Me.Panel1.TabIndex = 6
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(9, 67)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(145, 20)
        Me.lblTel.TabIndex = 2
        Me.lblTel.Text = "Tel : 021 - 9086374"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "45, XYZ Complex, SBC Road, Mumbai - 400021"
        '
        'WebsiteLink
        '
        Me.WebsiteLink.AutoSize = True
        Me.WebsiteLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebsiteLink.Location = New System.Drawing.Point(264, 67)
        Me.WebsiteLink.Name = "WebsiteLink"
        Me.WebsiteLink.Size = New System.Drawing.Size(284, 18)
        Me.WebsiteLink.TabIndex = 1
        Me.WebsiteLink.TabStop = True
        Me.WebsiteLink.Text = "https://adzillainternationaladvtagency.com/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblShopName
        '
        Me.lblShopName.AutoSize = True
        Me.lblShopName.Font = New System.Drawing.Font("Ebrima", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopName.ForeColor = System.Drawing.Color.Indigo
        Me.lblShopName.Location = New System.Drawing.Point(109, -2)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(635, 50)
        Me.lblShopName.TabIndex = 0
        Me.lblShopName.Text = "Adzilla - International Advt Agency"
        Me.lblShopName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCname
        '
        Me.txtCname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCname.Location = New System.Drawing.Point(68, 158)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.Size = New System.Drawing.Size(464, 26)
        Me.txtCname.TabIndex = 1
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(621, 157)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(190, 26)
        Me.txtContact.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bill To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(542, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact :"
        '
        'txtBno
        '
        Me.txtBno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBno.Location = New System.Drawing.Point(70, 118)
        Me.txtBno.Name = "txtBno"
        Me.txtBno.Size = New System.Drawing.Size(134, 26)
        Me.txtBno.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Bill No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(364, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Invoice"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(858, 417)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 36)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(858, 481)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 34)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(858, 295)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(116, 36)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(858, 354)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(116, 36)
        Me.btnHistory.TabIndex = 17
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(825, 219)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 33)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "select services"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FormBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1063, 711)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBills"
        Me.Text = "Bills"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WebsiteLink As LinkLabel
    Friend WithEvents lblShopName As Label
    Friend WithEvents txtCname As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtPaidBill As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGST As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Sr As DataGridViewTextBoxColumn
    Friend WithEvents Service As DataGridViewTextBoxColumn
    Friend WithEvents Duration As DataGridViewTextBoxColumn
    Friend WithEvents Charges As DataGridViewTextBoxColumn
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
