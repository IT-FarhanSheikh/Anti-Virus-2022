Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Public Class quick_scan

    'Dim SubDirectories As String() = System.IO.Directory.GetDirectories(Folder)
    'Dim Files As String() = System.IO.Directory.GetFiles(Folder)
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnQuickScan.Click
        'Timer1.Enabled = True
        'Timer1.Interval = 5

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("Scan Completed Successfully", MsgBoxStyle.Information, "Completed")

        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        'Timer1.Enabled = True
        ' Timer1.Interval = 1000

        If cmbDriveName.Text = "" Then
            MessageBox.Show("Select Drive To Scan")

        Else
            MessageBox.Show(cmbDriveName.Text)

        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub txtVirusesFound_TextChanged(sender As Object, e As EventArgs) Handles txtVirusesFound.TextChanged

    End Sub

    Private Sub cboDriveList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDriveName.SelectedIndexChanged

    End Sub

    Private Sub quick_scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        If cmbDriveName.Text = "" Then
            OpenFileDialog1.ShowDialog()
            cmbDriveName.Text = Path.GetFileName(OpenFileDialog1.FileName)

        Else
            MessageBox.Show(cmbDriveName.Text)

        End If
    End Sub
End Class