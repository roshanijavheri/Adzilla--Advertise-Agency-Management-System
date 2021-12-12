<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomers
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdzllaDataSet = New Advy_Agency_Management_System.AdzllaDataSet()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New Advy_Agency_Management_System.AdzllaDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Advy_Agency_Management_System.AdzllaDataSetTableAdapters.TableAdapterManager()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdzllaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(748, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 36)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(638, 395)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 36)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(113, 395)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(54, 36)
        Me.btnFirst.TabIndex = 25
        Me.btnFirst.Text = "|<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(181, 395)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(54, 36)
        Me.btnPrevious.TabIndex = 24
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(249, 395)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(54, 36)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(317, 395)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(54, 36)
        Me.btnLast.TabIndex = 22
        Me.btnLast.Text = ">>|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(528, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 36)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(385, 395)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(129, 36)
        Me.btnAddNew.TabIndex = 20
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'txtPayment
        '
        Me.txtPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PaymentReceivable", True))
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(614, 167)
        Me.txtPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(213, 29)
        Me.txtPayment.TabIndex = 19
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.AdzllaDataSet
        '
        'AdzllaDataSet
        '
        Me.AdzllaDataSet.DataSetName = "AdzllaDataSet"
        Me.AdzllaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDetails
        '
        Me.txtDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Details", True))
        Me.txtDetails.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(181, 234)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(646, 132)
        Me.txtDetails.TabIndex = 17
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(181, 190)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(243, 29)
        Me.txtEmail.TabIndex = 16
        '
        'txtContact
        '
        Me.txtContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Contact", True))
        Me.txtContact.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(181, 146)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(243, 29)
        Me.txtContact.TabIndex = 15
        '
        'txtCustName
        '
        Me.txtCustName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cname", True))
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(181, 102)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(646, 29)
        Me.txtCustName.TabIndex = 14
        '
        'txtCustID
        '
        Me.txtCustID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustID", True))
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(181, 58)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(175, 29)
        Me.txtCustID.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 69)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Payment Receivable :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Details :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contact :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cust Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cust ID :"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Advy_Agency_Management_System.AdzllaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(560, 58)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Emp ID :"
        '
        'txtEmpID
        '
        Me.txtEmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "EmpID", True))
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(663, 58)
        Me.txtEmpID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(164, 29)
        Me.txtEmpID.TabIndex = 13
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(946, 25)
        Me.CustomerBindingNavigator.TabIndex = 28
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CustomerDataGridView.Location = New System.Drawing.Point(0, 450)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(946, 135)
        Me.CustomerDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustID"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cname"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Contact"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PaymentReceivable"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "PaymentReceivable"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EmpID"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Details"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 585)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCustomers"
        Me.Text = "FormCustomers"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdzllaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AdzllaDataSet As AdzllaDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As AdzllaDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As AdzllaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
