<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnAbout = New FontAwesome.Sharp.IconButton()
        Me.btnAlerts = New FontAwesome.Sharp.IconButton()
        Me.btnBills = New FontAwesome.Sharp.IconButton()
        Me.btnReports = New FontAwesome.Sharp.IconButton()
        Me.btnStaff = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnAdModes = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAbout)
        Me.PanelMenu.Controls.Add(Me.btnAlerts)
        Me.PanelMenu.Controls.Add(Me.btnBills)
        Me.PanelMenu.Controls.Add(Me.btnReports)
        Me.PanelMenu.Controls.Add(Me.btnStaff)
        Me.PanelMenu.Controls.Add(Me.btnCustomers)
        Me.PanelMenu.Controls.Add(Me.btnAdModes)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(256, 687)
        Me.PanelMenu.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.btnAbout.IconColor = System.Drawing.Color.Gainsboro
        Me.btnAbout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 511)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnAbout.Size = New System.Drawing.Size(256, 60)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnAlerts
        '
        Me.btnAlerts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlerts.FlatAppearance.BorderSize = 0
        Me.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlerts.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlerts.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAlerts.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.btnAlerts.IconColor = System.Drawing.Color.Gainsboro
        Me.btnAlerts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAlerts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlerts.Location = New System.Drawing.Point(0, 451)
        Me.btnAlerts.Name = "btnAlerts"
        Me.btnAlerts.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnAlerts.Size = New System.Drawing.Size(256, 60)
        Me.btnAlerts.TabIndex = 6
        Me.btnAlerts.Text = "Alerts"
        Me.btnAlerts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlerts.UseVisualStyleBackColor = True
        '
        'btnBills
        '
        Me.btnBills.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBills.FlatAppearance.BorderSize = 0
        Me.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBills.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBills.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBills.IconChar = FontAwesome.Sharp.IconChar.Outdent
        Me.btnBills.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBills.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBills.Location = New System.Drawing.Point(0, 391)
        Me.btnBills.Name = "btnBills"
        Me.btnBills.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnBills.Size = New System.Drawing.Size(256, 60)
        Me.btnBills.TabIndex = 5
        Me.btnBills.Text = "Bills"
        Me.btnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBills.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReports.IconChar = FontAwesome.Sharp.IconChar.Redhat
        Me.btnReports.IconColor = System.Drawing.Color.Gainsboro
        Me.btnReports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 331)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnReports.Size = New System.Drawing.Size(256, 60)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStaff.IconChar = FontAwesome.Sharp.IconChar.LaptopCode
        Me.btnStaff.IconColor = System.Drawing.Color.Gainsboro
        Me.btnStaff.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(0, 271)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnStaff.Size = New System.Drawing.Size(256, 60)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.Text = " Staff"
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Handshake
        Me.btnCustomers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 211)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(256, 60)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnAdModes
        '
        Me.btnAdModes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdModes.FlatAppearance.BorderSize = 0
        Me.btnAdModes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdModes.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdModes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAdModes.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnAdModes.IconColor = System.Drawing.Color.Gainsboro
        Me.btnAdModes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdModes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdModes.Location = New System.Drawing.Point(0, 151)
        Me.btnAdModes.Name = "btnAdModes"
        Me.btnAdModes.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.btnAdModes.Size = New System.Drawing.Size(256, 60)
        Me.btnAdModes.TabIndex = 1
        Me.btnAdModes.Text = "Ad Modes"
        Me.btnAdModes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdModes.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(256, 151)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnClose)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(256, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(841, 99)
        Me.PanelTitleBar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.Location = New System.Drawing.Point(735, 10)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(38, 31)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaximize.Location = New System.Drawing.Point(770, 13)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(30, 27)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClose.Location = New System.Drawing.Point(795, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 33)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(98, 31)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(98, 36)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.DarkViolet
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.DarkViolet
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 49
        Me.IconCurrentForm.Location = New System.Drawing.Point(42, 22)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(50, 49)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.AutoScroll = True
        Me.PanelDesktop.AutoSize = True
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(256, 99)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(841, 588)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(249, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(381, 287)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1097, 687)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.MinimumSize = New System.Drawing.Size(600, 726)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnAdModes As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents btnAbout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAlerts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBills As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReports As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStaff As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
End Class
