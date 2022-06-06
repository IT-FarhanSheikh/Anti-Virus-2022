<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbox
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
        Me.btnChangeTheme = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSHowUserName = New System.Windows.Forms.Label()
        Me.lblShowOsInfo = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnShowSystemInfo = New System.Windows.Forms.Button()
        Me.lblShowInfo = New System.Windows.Forms.Label()
        Me.lblShowMemory = New System.Windows.Forms.Label()
        Me.lblShowIp = New System.Windows.Forms.Label()
        Me.lblOsInfo = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ThemePic = New System.Windows.Forms.PictureBox()
        Me.cmbThemes = New System.Windows.Forms.ComboBox()
        Me.btnDefaultTheme = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChangeTheme
        '
        Me.btnChangeTheme.BackColor = System.Drawing.Color.Red
        Me.btnChangeTheme.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChangeTheme.ForeColor = System.Drawing.Color.White
        Me.btnChangeTheme.Location = New System.Drawing.Point(200, 336)
        Me.btnChangeTheme.Name = "btnChangeTheme"
        Me.btnChangeTheme.Size = New System.Drawing.Size(180, 52)
        Me.btnChangeTheme.TabIndex = 0
        Me.btnChangeTheme.Text = "Change Theme"
        Me.btnChangeTheme.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSHowUserName)
        Me.GroupBox1.Controls.Add(Me.lblShowOsInfo)
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.btnShowSystemInfo)
        Me.GroupBox1.Controls.Add(Me.lblShowInfo)
        Me.GroupBox1.Controls.Add(Me.lblShowMemory)
        Me.GroupBox1.Controls.Add(Me.lblShowIp)
        Me.GroupBox1.Controls.Add(Me.lblOsInfo)
        Me.GroupBox1.Controls.Add(Me.lblMemory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.ThemePic)
        Me.GroupBox1.Controls.Add(Me.cmbThemes)
        Me.GroupBox1.Controls.Add(Me.btnChangeTheme)
        Me.GroupBox1.Controls.Add(Me.btnDefaultTheme)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 394)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SETTINGS"
        '
        'lblSHowUserName
        '
        Me.lblSHowUserName.AutoSize = True
        Me.lblSHowUserName.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSHowUserName.Location = New System.Drawing.Point(420, 254)
        Me.lblSHowUserName.Name = "lblSHowUserName"
        Me.lblSHowUserName.Size = New System.Drawing.Size(106, 24)
        Me.lblSHowUserName.TabIndex = 15
        Me.lblSHowUserName.Text = "................"
        '
        'lblShowOsInfo
        '
        Me.lblShowOsInfo.AutoSize = True
        Me.lblShowOsInfo.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblShowOsInfo.Location = New System.Drawing.Point(429, 136)
        Me.lblShowOsInfo.Name = "lblShowOsInfo"
        Me.lblShowOsInfo.Size = New System.Drawing.Size(100, 24)
        Me.lblShowOsInfo.TabIndex = 14
        Me.lblShowOsInfo.Text = "..............."
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUserName.Location = New System.Drawing.Point(259, 254)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(130, 24)
        Me.lblUserName.TabIndex = 13
        Me.lblUserName.Text = "User Name :"
        '
        'btnShowSystemInfo
        '
        Me.btnShowSystemInfo.BackColor = System.Drawing.Color.Red
        Me.btnShowSystemInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShowSystemInfo.Location = New System.Drawing.Point(204, 45)
        Me.btnShowSystemInfo.Name = "btnShowSystemInfo"
        Me.btnShowSystemInfo.Size = New System.Drawing.Size(444, 38)
        Me.btnShowSystemInfo.TabIndex = 12
        Me.btnShowSystemInfo.Text = "SHOW SYSTEM INFO"
        Me.btnShowSystemInfo.UseVisualStyleBackColor = False
        '
        'lblShowInfo
        '
        Me.lblShowInfo.AutoSize = True
        Me.lblShowInfo.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblShowInfo.Location = New System.Drawing.Point(429, 102)
        Me.lblShowInfo.Name = "lblShowInfo"
        Me.lblShowInfo.Size = New System.Drawing.Size(94, 24)
        Me.lblShowInfo.TabIndex = 11
        Me.lblShowInfo.Text = ".............."
        '
        'lblShowMemory
        '
        Me.lblShowMemory.AutoSize = True
        Me.lblShowMemory.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblShowMemory.Location = New System.Drawing.Point(429, 177)
        Me.lblShowMemory.Name = "lblShowMemory"
        Me.lblShowMemory.Size = New System.Drawing.Size(100, 24)
        Me.lblShowMemory.TabIndex = 10
        Me.lblShowMemory.Text = "..............."
        '
        'lblShowIp
        '
        Me.lblShowIp.AutoSize = True
        Me.lblShowIp.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblShowIp.Location = New System.Drawing.Point(429, 213)
        Me.lblShowIp.Name = "lblShowIp"
        Me.lblShowIp.Size = New System.Drawing.Size(94, 24)
        Me.lblShowIp.TabIndex = 8
        Me.lblShowIp.Text = ".............."
        '
        'lblOsInfo
        '
        Me.lblOsInfo.AutoSize = True
        Me.lblOsInfo.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOsInfo.Location = New System.Drawing.Point(294, 136)
        Me.lblOsInfo.Name = "lblOsInfo"
        Me.lblOsInfo.Size = New System.Drawing.Size(95, 24)
        Me.lblOsInfo.TabIndex = 7
        Me.lblOsInfo.Text = "OS Info :"
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMemory.Location = New System.Drawing.Point(285, 177)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(104, 24)
        Me.lblMemory.TabIndex = 6
        Me.lblMemory.Text = "Memory :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(256, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "IP Address :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(204, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(185, 24)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Computer Name :"
        '
        'ThemePic
        '
        Me.ThemePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThemePic.Location = New System.Drawing.Point(6, 26)
        Me.ThemePic.Name = "ThemePic"
        Me.ThemePic.Size = New System.Drawing.Size(871, 270)
        Me.ThemePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThemePic.TabIndex = 3
        Me.ThemePic.TabStop = False
        '
        'cmbThemes
        '
        Me.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThemes.FormattingEnabled = True
        Me.cmbThemes.Location = New System.Drawing.Point(164, 302)
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.Size = New System.Drawing.Size(484, 28)
        Me.cmbThemes.TabIndex = 0
        '
        'btnDefaultTheme
        '
        Me.btnDefaultTheme.BackColor = System.Drawing.Color.Green
        Me.btnDefaultTheme.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDefaultTheme.ForeColor = System.Drawing.Color.White
        Me.btnDefaultTheme.Location = New System.Drawing.Point(429, 336)
        Me.btnDefaultTheme.Name = "btnDefaultTheme"
        Me.btnDefaultTheme.Size = New System.Drawing.Size(180, 52)
        Me.btnDefaultTheme.TabIndex = 2
        Me.btnDefaultTheme.Text = "Default Theme"
        Me.btnDefaultTheme.UseVisualStyleBackColor = False
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(907, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Toolbox"
        Me.Text = "Toolbox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnChangeTheme As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbThemes As ComboBox
    Friend WithEvents btnDefaultTheme As Button
    Friend WithEvents ThemePic As PictureBox
    Friend WithEvents lblOsInfo As Label
    Friend WithEvents lblMemory As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblShowInfo As Label
    Friend WithEvents lblShowMemory As Label
    Friend WithEvents lblShowIp As Label
    Friend WithEvents btnShowSystemInfo As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblSHowUserName As Label
    Friend WithEvents lblShowOsInfo As Label
End Class
