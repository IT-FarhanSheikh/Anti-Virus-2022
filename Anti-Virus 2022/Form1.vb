Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnBuyPremium.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit?", "Exit application",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Maximized
        Dim scr As Screen = Screen.FromControl(Me)   'get the screen where the app locate
        Me.MaximizedBounds = scr.WorkingArea         'set the max Size to workingarea 
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
        End If


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles pnlAreaBar.Paint

    End Sub





    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSideBar.Paint

    End Sub

    Private Sub pnlVirusScan_Paint(sender As Object, e As PaintEventArgs)

    End Sub







    Private Sub btnQuickScan1_Click(sender As Object, e As EventArgs) Handles btnQuickScan1.Click
        quick_scan.TopLevel = False
        quick_scan.TopMost = True
        Me.pnlAreaBar.Controls.Add(quick_scan)
        quick_scan.Show()

        picRadar.Hide()
    End Sub

    Private Sub btnFullCheck_Click(sender As Object, e As EventArgs) Handles btnFullCheck.Click
        quick_scan.TopLevel = False
        quick_scan.TopMost = True
        Me.pnlAreaBar.Controls.Add(quick_scan)
        quick_scan.Show()
        picRadar.Hide()
        btnQuickScan1.Hide()
        Toolbox.Hide()
        SpeedUp.Hide()
    End Sub

    Private Sub btnSpeedUp_Click_1(sender As Object, e As EventArgs) Handles btnSpeedUp.Click
        SpeedUp.TopLevel = False
        SpeedUp.TopMost = True
        Me.pnlAreaBar.Controls.Add(SpeedUp)
        SpeedUp.Show()
        picRadar.Hide()
        btnQuickScan1.Hide()
        Toolbox.Hide()
        quick_scan.Hide()
    End Sub

    Private Sub btnVirusScan_Click(sender As Object, e As EventArgs)
        quick_scan.TopLevel = False
        quick_scan.TopMost = True
        Me.pnlAreaBar.Controls.Add(quick_scan)
        quick_scan.Show()
        picRadar.Hide()
        btnQuickScan1.Hide()
        Toolbox.Hide()
        SpeedUp.Hide()
    End Sub



    Private Sub btnToolBox_Click_1(sender As Object, e As EventArgs) Handles btnToolBox.Click
        Toolbox.TopLevel = False
        Toolbox.TopMost = True
        Me.pnlAreaBar.Controls.Add(Toolbox)
        Toolbox.Show()
        picRadar.Hide()
        btnQuickScan1.Hide()
        SpeedUp.Hide()
        quick_scan.Hide()
    End Sub

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        SpeedUp.Hide()
        quick_scan.Hide()
        Toolbox.Hide()
        pnlAreaBar.Show()
        picRadar.Show()
        btnQuickScan1.Show()
        Me.Show()
    End Sub

    Private Sub CopyRight_Click(sender As Object, e As EventArgs) Handles CopyRight.Click

    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DateTime.Text = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
    End Sub

    Private Sub picRadar_Click(sender As Object, e As EventArgs) Handles picRadar.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
