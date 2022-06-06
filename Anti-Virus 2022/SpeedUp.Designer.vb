<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeedUp
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
        Me.btnSpeedUp1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChooseFiles1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSpeedUp1
        '
        Me.btnSpeedUp1.BackColor = System.Drawing.Color.Green
        Me.btnSpeedUp1.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSpeedUp1.Location = New System.Drawing.Point(341, 329)
        Me.btnSpeedUp1.Name = "btnSpeedUp1"
        Me.btnSpeedUp1.Size = New System.Drawing.Size(147, 49)
        Me.btnSpeedUp1.TabIndex = 0
        Me.btnSpeedUp1.Text = "SpeedUp"
        Me.btnSpeedUp1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnChooseFiles1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 301)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Files"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(159, 249)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(534, 24)
        Me.ProgressBar1.TabIndex = 14
        Me.ProgressBar1.Text = "Guna2ProgressBar1"
        Me.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(128, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "File Path  :"
        '
        'btnChooseFiles1
        '
        Me.btnChooseFiles1.BorderRadius = 20
        Me.btnChooseFiles1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChooseFiles1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChooseFiles1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChooseFiles1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChooseFiles1.FillColor = System.Drawing.Color.Red
        Me.btnChooseFiles1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChooseFiles1.ForeColor = System.Drawing.Color.White
        Me.btnChooseFiles1.HoverState.FillColor = System.Drawing.Color.DarkKhaki
        Me.btnChooseFiles1.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnChooseFiles1.Location = New System.Drawing.Point(668, 99)
        Me.btnChooseFiles1.Name = "btnChooseFiles1"
        Me.btnChooseFiles1.Size = New System.Drawing.Size(190, 38)
        Me.btnChooseFiles1.TabIndex = 12
        Me.btnChooseFiles1.Text = "Choose File"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(316, 138)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(308, 27)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(316, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(308, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(128, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Name  :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SpeedUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(907, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSpeedUp1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SpeedUp"
        Me.Text = "SpeedUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpeedUp1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChooseFiles1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
