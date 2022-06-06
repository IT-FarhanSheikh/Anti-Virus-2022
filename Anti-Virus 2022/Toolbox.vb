Imports System.Environment
Imports System.Net
Imports System.IO

Public Class Toolbox

    Private Sub comboItem()
        cmbThemes.Items.Add("Default Theme")
        cmbThemes.Items.Add("Dark Theme")
        cmbThemes.Items.Add("Red Theme")
        cmbThemes.Items.Add("Green Theme")
    End Sub


    Private Sub Default_theme()
        Me.BackColor = Color.Blue
        Form1.pnlUpperBar.BackColor = Color.Blue
        Form1.pnlSideBar.BackColor = Color.Blue
        Form1.pnlAreaBar.BackColor = Color.Black
    End Sub

    Private Sub Dark_theme()
        Me.BackColor = Color.Black
        Form1.pnlUpperBar.BackColor = Color.Black
        Form1.pnlSideBar.BackColor = Color.Black
        Form1.pnlAreaBar.BackColor = Color.Black
    End Sub
    Private Sub Red_theme()
        Me.BackColor = Color.Red
        Form1.pnlUpperBar.BackColor = Color.Red
        Form1.pnlSideBar.BackColor = Color.Red
        Form1.pnlAreaBar.BackColor = Color.Red
    End Sub

    Private Sub Green_theme()
        Me.BackColor = Color.Green
        Form1.pnlUpperBar.BackColor = Color.Green
        Form1.pnlSideBar.BackColor = Color.Green
        Form1.pnlAreaBar.BackColor = Color.Green
    End Sub





    Private Sub Toolbox_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cmbThemes.SelectedItem = 1
        Catch ex As Exception

        End Try

        comboItem()
    End Sub

    Private Sub btnChangeTheme_Click(sender As Object, e As EventArgs) Handles btnChangeTheme.Click
        If cmbThemes.SelectedIndex = 0 Then
            Default_theme()
        Else
            If cmbThemes.SelectedIndex = 1 Then
                Dark_theme()
            End If
            If cmbThemes.SelectedIndex = 2 Then
                Red_theme()
            End If
            If cmbThemes.SelectedIndex = 3 Then
                Green_theme()
            End If
        End If
    End Sub

    Private Sub btnDefaultTheme_Click(sender As Object, e As EventArgs) Handles btnDefaultTheme.Click
        Default_theme()
    End Sub

    Private Sub btnShowSystemInfo_Click(sender As Object, e As EventArgs) Handles btnShowSystemInfo.Click
        Try
            getip()
        Catch ex As Exception
            ex.ToString()
        End Try


        lblShowInfo.Text = My.Computer.Name
        lblShowOsInfo.Text = My.Computer.Info.OSFullName
        lblShowMemory.Text = My.Computer.Info.AvailablePhysicalMemory
        lblSHowUserName.Text = SystemInformation.UserName
    End Sub

    Private Sub getip()
        Dim hostname As String = Dns.GetHostName
        Dim ip As String = System.Net.Dns.GetHostByName(hostname).AddressList(0).ToString
        Me.Text = ip
        lblShowIp.Text = ip
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class