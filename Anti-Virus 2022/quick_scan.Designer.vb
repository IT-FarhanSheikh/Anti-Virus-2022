<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quick_scan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quick_scan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.cmbDriveName = New System.Windows.Forms.ComboBox()
        Me.txtFileList = New System.Windows.Forms.TextBox()
        Me.txtVirusesFound = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.btnQuickScan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Blue
        Me.GroupBox1.Controls.Add(Me.btnSelectFile)
        Me.GroupBox1.Controls.Add(Me.cmbDriveName)
        Me.GroupBox1.Controls.Add(Me.txtFileList)
        Me.GroupBox1.Controls.Add(Me.txtVirusesFound)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnFull)
        Me.GroupBox1.Controls.Add(Me.btnQuickScan)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scan for virus"
        '
        'btnSelectFile
        '
        Me.btnSelectFile.BackColor = System.Drawing.Color.Red
        Me.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectFile.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSelectFile.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectFile.Location = New System.Drawing.Point(530, 38)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(159, 40)
        Me.btnSelectFile.TabIndex = 20
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = False
        '
        'cmbDriveName
        '
        Me.cmbDriveName.FormattingEnabled = True
        Me.cmbDriveName.Items.AddRange(New Object() {"C:\", "D:\", "E:\"})
        Me.cmbDriveName.Location = New System.Drawing.Point(239, 46)
        Me.cmbDriveName.Name = "cmbDriveName"
        Me.cmbDriveName.Size = New System.Drawing.Size(275, 28)
        Me.cmbDriveName.TabIndex = 19
        '
        'txtFileList
        '
        Me.txtFileList.BackColor = System.Drawing.Color.Blue
        Me.txtFileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileList.ForeColor = System.Drawing.Color.Yellow
        Me.txtFileList.Location = New System.Drawing.Point(239, 117)
        Me.txtFileList.Name = "txtFileList"
        Me.txtFileList.Size = New System.Drawing.Size(275, 27)
        Me.txtFileList.TabIndex = 18
        '
        'txtVirusesFound
        '
        Me.txtVirusesFound.BackColor = System.Drawing.Color.Blue
        Me.txtVirusesFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVirusesFound.ForeColor = System.Drawing.Color.Yellow
        Me.txtVirusesFound.Location = New System.Drawing.Point(239, 152)
        Me.txtVirusesFound.Name = "txtVirusesFound"
        Me.txtVirusesFound.Size = New System.Drawing.Size(275, 27)
        Me.txtVirusesFound.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(129, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(77, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Affected Files :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(62, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Estimated Time :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(111, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Scanning :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(77, 231)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(612, 29)
        Me.ProgressBar1.TabIndex = 9
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Green
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(709, 193)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(159, 43)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE VIRUS"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnFull
        '
        Me.btnFull.BackColor = System.Drawing.Color.Orange
        Me.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFull.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFull.ForeColor = System.Drawing.SystemColors.Window
        Me.btnFull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFull.Location = New System.Drawing.Point(709, 117)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(159, 37)
        Me.btnFull.TabIndex = 7
        Me.btnFull.Text = "FULL SCAN"
        Me.btnFull.UseVisualStyleBackColor = False
        '
        'btnQuickScan
        '
        Me.btnQuickScan.BackColor = System.Drawing.Color.Red
        Me.btnQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickScan.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuickScan.ForeColor = System.Drawing.SystemColors.Window
        Me.btnQuickScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuickScan.Location = New System.Drawing.Point(709, 40)
        Me.btnQuickScan.Name = "btnQuickScan"
        Me.btnQuickScan.Size = New System.Drawing.Size(159, 40)
        Me.btnQuickScan.TabIndex = 6
        Me.btnQuickScan.Text = "QUICK SCAN"
        Me.btnQuickScan.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'quick_scan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(907, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "quick_scan"
        Me.Text = "quick_scan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFull As Button
    Friend WithEvents btnQuickScan As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtVirusesFound As TextBox
    Friend WithEvents txtFileList As TextBox
    Friend WithEvents cmbDriveName As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSelectFile As Button
End Class
