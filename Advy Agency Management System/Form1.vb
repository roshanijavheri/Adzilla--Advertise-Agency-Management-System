Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1
    'Feilds
    Private CurrentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\KEN\Desktop\Advt Management System\Advy Agency Management System\Adzlla.accdb")


    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form Border Removed Here
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    ' Methods

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            CurrentBtn = CType(senderBtn, IconButton)
            CurrentBtn.BackColor = Color.FromArgb(37, 36, 81)
            CurrentBtn.ForeColor = customColor
            CurrentBtn.IconColor = customColor
            CurrentBtn.TextAlign = ContentAlignment.MiddleCenter
            CurrentBtn.ImageAlign = ContentAlignment.MiddleCenter
            CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, CurrentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'Current Form Icon
            IconCurrentForm.IconChar = CurrentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub


    Private Sub DisableButton()
        If CurrentBtn IsNot Nothing Then
            CurrentBtn.BackColor = Color.FromArgb(31, 30, 68)
            CurrentBtn.ForeColor = Color.Gainsboro
            CurrentBtn.IconColor = Color.Gainsboro
            CurrentBtn.TextAlign = ContentAlignment.MiddleLeft
            CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft
            CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form)
        'Opens Only One Form at a time
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text

    End Sub

    Private Sub btnAdModes_Click(sender As Object, e As EventArgs) Handles btnAdModes.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New FormAdModes)
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FormCustomers)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New FormStaff)
    End Sub

    Private Sub btnQuatation_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New FormReports)
    End Sub

    Private Sub btnBills_Click(sender As Object, e As EventArgs) Handles btnBills.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FormBills)
    End Sub

    Private Sub btnAlerts_Click(sender As Object, e As EventArgs) Handles btnAlerts.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New FormAlerts)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New FormAbout)
    End Sub

    Private Sub IconCurrentForm_Click(sender As Object, e As EventArgs) Handles IconCurrentForm.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
    End Sub
    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    End Sub


    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnMaximize_Click(sender As Object, e As EventArgs) Handles BtnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                MsgBox("Not Connected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
    End Sub


End Class

