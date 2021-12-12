<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(484, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Version 1.0"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(808, 171)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "This Software is created with aim to Manage Customers, Staff, Billing, Services. " &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This Software is capable of creating different Reports according to user's req" &
    "uirement. "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(308, 226)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(476, 24)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://www.rgsoftcomcompanyadzilla.com/contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(301, 493)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(518, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "© 2021 RG Software Company. All rights reserved."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 163)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(320, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(481, 34)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Advt Agency Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(423, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 75)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Adzilla"
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.Name = "FormAbout"
        Me.Text = "About"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
