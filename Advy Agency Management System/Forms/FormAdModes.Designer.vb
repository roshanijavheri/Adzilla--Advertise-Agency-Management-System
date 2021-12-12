<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdModes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdModes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdID = New System.Windows.Forms.TextBox()
        Me.ServicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtScope = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdzllaDataSet = New Advy_Agency_Management_System.AdzllaDataSet()
        Me.ServicesTableAdapter = New Advy_Agency_Management_System.AdzllaDataSetTableAdapters.ServicesTableAdapter()
        Me.TableAdapterManager = New Advy_Agency_Management_System.AdzllaDataSetTableAdapters.TableAdapterManager()
        Me.ServicesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ServicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServicesBindingNavigator.SuspendLayout()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdzllaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Advt ID :"
        '
        'txtAdID
        '
        Me.txtAdID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "AdID", True))
        Me.txtAdID.Location = New System.Drawing.Point(173, 71)
        Me.txtAdID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAdID.Name = "txtAdID"
        Me.txtAdID.Size = New System.Drawing.Size(260, 29)
        Me.txtAdID.TabIndex = 1
        '
        'ServicesBindingNavigator
        '
        Me.ServicesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ServicesBindingNavigator.BindingSource = Me.ServicesBindingSource
        Me.ServicesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ServicesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ServicesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ServicesBindingNavigatorSaveItem})
        Me.ServicesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServicesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ServicesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ServicesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ServicesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ServicesBindingNavigator.Name = "ServicesBindingNavigator"
        Me.ServicesBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ServicesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ServicesBindingNavigator.Size = New System.Drawing.Size(1036, 25)
        Me.ServicesBindingNavigator.TabIndex = 2
        Me.ServicesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(80, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        'ServicesBindingNavigatorSaveItem
        '
        Me.ServicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ServicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServicesBindingNavigatorSaveItem.Name = "ServicesBindingNavigatorSaveItem"
        Me.ServicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ServicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Advt Name :"
        '
        'txtAdName
        '
        Me.txtAdName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "AdName", True))
        Me.txtAdName.Location = New System.Drawing.Point(173, 115)
        Me.txtAdName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAdName.Name = "txtAdName"
        Me.txtAdName.Size = New System.Drawing.Size(775, 29)
        Me.txtAdName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Duration :"
        '
        'txtDuration
        '
        Me.txtDuration.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "DurationofAdvt", True))
        Me.txtDuration.Location = New System.Drawing.Point(173, 159)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(328, 29)
        Me.txtDuration.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Charges :"
        '
        'txtCharges
        '
        Me.txtCharges.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Charges", True))
        Me.txtCharges.Location = New System.Drawing.Point(173, 203)
        Me.txtCharges.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(328, 29)
        Me.txtCharges.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(518, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mode :"
        '
        'txtMode
        '
        Me.txtMode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Mode", True))
        Me.txtMode.Location = New System.Drawing.Point(608, 159)
        Me.txtMode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMode.Name = "txtMode"
        Me.txtMode.Size = New System.Drawing.Size(340, 29)
        Me.txtMode.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Scope :"
        '
        'txtScope
        '
        Me.txtScope.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Scope", True))
        Me.txtScope.Location = New System.Drawing.Point(608, 204)
        Me.txtScope.Margin = New System.Windows.Forms.Padding(5)
        Me.txtScope.Name = "txtScope"
        Me.txtScope.Size = New System.Drawing.Size(340, 29)
        Me.txtScope.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Details :"
        '
        'txtDetails
        '
        Me.txtDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Details", True))
        Me.txtDetails.Location = New System.Drawing.Point(173, 247)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(775, 132)
        Me.txtDetails.TabIndex = 1
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(438, 403)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(129, 36)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(581, 403)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 36)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(691, 403)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 36)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(801, 403)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 36)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(370, 403)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(54, 36)
        Me.btnLast.TabIndex = 5
        Me.btnLast.Text = ">>|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(302, 403)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(54, 36)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(234, 403)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(54, 36)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(166, 403)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(54, 36)
        Me.btnFirst.TabIndex = 5
        Me.btnFirst.Text = "|<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.AdzllaDataSet
        '
        'AdzllaDataSet
        '
        Me.AdzllaDataSet.DataSetName = "AdzllaDataSet"
        Me.AdzllaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Me.ServicesTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Advy_Agency_Management_System.AdzllaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ServicesDataGridView
        '
        Me.ServicesDataGridView.AutoGenerateColumns = False
        Me.ServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ServicesDataGridView.DataSource = Me.ServicesBindingSource
        Me.ServicesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ServicesDataGridView.Location = New System.Drawing.Point(0, 464)
        Me.ServicesDataGridView.Name = "ServicesDataGridView"
        Me.ServicesDataGridView.Size = New System.Drawing.Size(1036, 180)
        Me.ServicesDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AdID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AdID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AdName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AdName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DurationofAdvt"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DurationofAdvt"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 153
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Charges"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Charges"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Mode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Scope"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Scope"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 81
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Details"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 86
        '
        'FormAdModes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1036, 644)
        Me.Controls.Add(Me.ServicesDataGridView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.ServicesBindingNavigator)
        Me.Controls.Add(Me.txtScope)
        Me.Controls.Add(Me.txtMode)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtAdName)
        Me.Controls.Add(Me.txtAdID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormAdModes"
        Me.Text = "FormAdModes"
        CType(Me.ServicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServicesBindingNavigator.ResumeLayout(False)
        Me.ServicesBindingNavigator.PerformLayout()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdzllaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdID As TextBox
    Friend WithEvents AdzllaDataSet As AdzllaDataSet
    Friend WithEvents ServicesBindingSource As BindingSource
    Friend WithEvents ServicesTableAdapter As AdzllaDataSetTableAdapters.ServicesTableAdapter
    Friend WithEvents TableAdapterManager As AdzllaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServicesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ServicesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCharges As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtScope As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ServicesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
