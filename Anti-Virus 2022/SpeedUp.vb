Imports System.IO
Imports System.Threading
Public Class SpeedUp
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MsgBox("SpeedUp Completed Successfully", MsgBoxStyle.Information, "Completed")

        End If
    End Sub

    Private Sub btnSpeedUp1_Click(sender As Object, e As EventArgs) Handles btnSpeedUp1.Click
        Timer1.Enabled = True
        Timer1.Interval = 50
    End Sub

    Private Sub SpeedUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChooseFiles1_Click(sender As Object, e As EventArgs) Handles btnChooseFiles1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = Path.GetFileName(OpenFileDialog1.FileName)
        TextBox2.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
    End Sub
End Class