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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlSideBar = New System.Windows.Forms.Panel()
        Me.lblIT = New System.Windows.Forms.Label()
        Me.CopyRight = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnToolBox = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSpeedUp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFullCheck = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlUpperBar = New System.Windows.Forms.Panel()
        Me.btnQuickScan1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCheckStatus = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTimePeriod = New System.Windows.Forms.Label()
        Me.btnTrialVs = New System.Windows.Forms.Button()
        Me.btnBuyPremium = New System.Windows.Forms.Button()
        Me.lblVirus = New System.Windows.Forms.Label()
        Me.lblAnti = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pnlAreaBar = New System.Windows.Forms.Panel()
        Me.picRadar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTime = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSideBar.SuspendLayout()
        CType(Me.CopyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUpperBar.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAreaBar.SuspendLayout()
        CType(Me.picRadar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSideBar.BackColor = System.Drawing.Color.Blue
        Me.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSideBar.Controls.Add(Me.lblIT)
        Me.pnlSideBar.Controls.Add(Me.CopyRight)
        Me.pnlSideBar.Controls.Add(Me.btnHome)
        Me.pnlSideBar.Controls.Add(Me.btnToolBox)
        Me.pnlSideBar.Controls.Add(Me.btnSpeedUp)
        Me.pnlSideBar.Controls.Add(Me.btnFullCheck)
        Me.pnlSideBar.ForeColor = System.Drawing.Color.White
        Me.pnlSideBar.Location = New System.Drawing.Point(0, 159)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(254, 590)
        Me.pnlSideBar.TabIndex = 0
        '
        'lblIT
        '
        Me.lblIT.AutoSize = True
        Me.lblIT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIT.Location = New System.Drawing.Point(72, 373)
        Me.lblIT.Name = "lblIT"
        Me.lblIT.Size = New System.Drawing.Size(86, 28)
        Me.lblIT.TabIndex = 13
        Me.lblIT.Text = "IT-2022"
        '
        'CopyRight
        '
        Me.CopyRight.Image = CType(resources.GetObject("CopyRight.Image"), System.Drawing.Image)
        Me.CopyRight.ImageRotate = 0!
        Me.CopyRight.InitialImage = CType(resources.GetObject("CopyRight.InitialImage"), System.Drawing.Image)
        Me.CopyRight.Location = New System.Drawing.Point(37, 373)
        Me.CopyRight.Name = "CopyRight"
        Me.CopyRight.Size = New System.Drawing.Size(29, 29)
        Me.CopyRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CopyRight.TabIndex = 12
        Me.CopyRight.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.BorderRadius = 20
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.FillColor = System.Drawing.Color.Black
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnHome.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.Anti_Virus_2022.My.Resources.Resources.home_48px
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnHome.Location = New System.Drawing.Point(11, 260)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(232, 56)
        Me.btnHome.TabIndex = 11
        Me.btnHome.Text = "Home"
        '
        'btnToolBox
        '
        Me.btnToolBox.BorderRadius = 20
        Me.btnToolBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToolBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToolBox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToolBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToolBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToolBox.FillColor = System.Drawing.Color.Black
        Me.btnToolBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnToolBox.ForeColor = System.Drawing.Color.White
        Me.btnToolBox.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnToolBox.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnToolBox.Image = Global.Anti_Virus_2022.My.Resources.Resources.toolbox_30px
        Me.btnToolBox.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnToolBox.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnToolBox.Location = New System.Drawing.Point(11, 180)
        Me.btnToolBox.Name = "btnToolBox"
        Me.btnToolBox.Size = New System.Drawing.Size(232, 56)
        Me.btnToolBox.TabIndex = 8
        Me.btnToolBox.Text = "ToolBox"
        '
        'btnSpeedUp
        '
        Me.btnSpeedUp.BorderRadius = 20
        Me.btnSpeedUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSpeedUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSpeedUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSpeedUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSpeedUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSpeedUp.FillColor = System.Drawing.Color.Black
        Me.btnSpeedUp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSpeedUp.ForeColor = System.Drawing.Color.White
        Me.btnSpeedUp.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnSpeedUp.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSpeedUp.Image = Global.Anti_Virus_2022.My.Resources.Resources.exercise_26px
        Me.btnSpeedUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSpeedUp.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSpeedUp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSpeedUp.Location = New System.Drawing.Point(11, 100)
        Me.btnSpeedUp.Name = "btnSpeedUp"
        Me.btnSpeedUp.Size = New System.Drawing.Size(232, 56)
        Me.btnSpeedUp.TabIndex = 7
        Me.btnSpeedUp.Text = "Speed Up"
        '
        'btnFullCheck
        '
        Me.btnFullCheck.BorderRadius = 20
        Me.btnFullCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFullCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFullCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFullCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFullCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFullCheck.FillColor = System.Drawing.Color.Black
        Me.btnFullCheck.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFullCheck.ForeColor = System.Drawing.Color.White
        Me.btnFullCheck.HoverState.FillColor = System.Drawing.Color.Fuchsia
        Me.btnFullCheck.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnFullCheck.Image = Global.Anti_Virus_2022.My.Resources.Resources.imac_32px
        Me.btnFullCheck.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFullCheck.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnFullCheck.Location = New System.Drawing.Point(11, 20)
        Me.btnFullCheck.Name = "btnFullCheck"
        Me.btnFullCheck.Size = New System.Drawing.Size(232, 56)
        Me.btnFullCheck.TabIndex = 6
        Me.btnFullCheck.Text = "Full Check"
        '
        'pnlUpperBar
        '
        Me.pnlUpperBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUpperBar.BackColor = System.Drawing.Color.Blue
        Me.pnlUpperBar.Controls.Add(Me.btnQuickScan1)
        Me.pnlUpperBar.Controls.Add(Me.lblCheckStatus)
        Me.pnlUpperBar.Controls.Add(Me.lblStatus)
        Me.pnlUpperBar.Controls.Add(Me.lblTimePeriod)
        Me.pnlUpperBar.Controls.Add(Me.btnTrialVs)
        Me.pnlUpperBar.Controls.Add(Me.btnBuyPremium)
        Me.pnlUpperBar.Controls.Add(Me.lblVirus)
        Me.pnlUpperBar.Controls.Add(Me.lblAnti)
        Me.pnlUpperBar.Location = New System.Drawing.Point(0, 35)
        Me.pnlUpperBar.Name = "pnlUpperBar"
        Me.pnlUpperBar.Size = New System.Drawing.Size(1160, 118)
        Me.pnlUpperBar.TabIndex = 1
        '
        'btnQuickScan1
        '
        Me.btnQuickScan1.BorderRadius = 20
        Me.btnQuickScan1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnQuickScan1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnQuickScan1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnQuickScan1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnQuickScan1.FillColor = System.Drawing.Color.Red
        Me.btnQuickScan1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuickScan1.ForeColor = System.Drawing.Color.White
        Me.btnQuickScan1.HoverState.FillColor = System.Drawing.Color.DarkKhaki
        Me.btnQuickScan1.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuickScan1.Location = New System.Drawing.Point(952, 30)
        Me.btnQuickScan1.Name = "btnQuickScan1"
        Me.btnQuickScan1.Size = New System.Drawing.Size(190, 56)
        Me.btnQuickScan1.TabIndex = 11
        Me.btnQuickScan1.Text = "Quick Scan"
        '
        'lblCheckStatus
        '
        Me.lblCheckStatus.AutoSize = True
        Me.lblCheckStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCheckStatus.ForeColor = System.Drawing.Color.White
        Me.lblCheckStatus.Location = New System.Drawing.Point(221, 95)
        Me.lblCheckStatus.Name = "lblCheckStatus"
        Me.lblCheckStatus.Size = New System.Drawing.Size(282, 23)
        Me.lblCheckStatus.TabIndex = 10
        Me.lblCheckStatus.Text = "Your Computer is Protected"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(131, 95)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(84, 23)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "STATUS"
        '
        'lblTimePeriod
        '
        Me.lblTimePeriod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimePeriod.AutoSize = True
        Me.lblTimePeriod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimePeriod.ForeColor = System.Drawing.Color.White
        Me.lblTimePeriod.Location = New System.Drawing.Point(1019, 95)
        Me.lblTimePeriod.Name = "lblTimePeriod"
        Me.lblTimePeriod.Size = New System.Drawing.Size(123, 23)
        Me.lblTimePeriod.TabIndex = 8
        Me.lblTimePeriod.Text = "30 Days Left"
        '
        'btnTrialVs
        '
        Me.btnTrialVs.BackColor = System.Drawing.Color.Red
        Me.btnTrialVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrialVs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTrialVs.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTrialVs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrialVs.Location = New System.Drawing.Point(324, 47)
        Me.btnTrialVs.Name = "btnTrialVs"
        Me.btnTrialVs.Size = New System.Drawing.Size(161, 39)
        Me.btnTrialVs.TabIndex = 7
        Me.btnTrialVs.Text = "Trial Version"
        Me.btnTrialVs.UseVisualStyleBackColor = False
        '
        'btnBuyPremium
        '
        Me.btnBuyPremium.BackColor = System.Drawing.Color.Green
        Me.btnBuyPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuyPremium.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuyPremium.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBuyPremium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuyPremium.Location = New System.Drawing.Point(123, 47)
        Me.btnBuyPremium.Name = "btnBuyPremium"
        Me.btnBuyPremium.Size = New System.Drawing.Size(195, 39)
        Me.btnBuyPremium.TabIndex = 6
        Me.btnBuyPremium.Text = "  Buy Premium"
        Me.btnBuyPremium.UseVisualStyleBackColor = False
        '
        'lblVirus
        '
        Me.lblVirus.AutoSize = True
        Me.lblVirus.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVirus.ForeColor = System.Drawing.Color.White
        Me.lblVirus.Location = New System.Drawing.Point(238, 1)
        Me.lblVirus.Name = "lblVirus"
        Me.lblVirus.Size = New System.Drawing.Size(132, 44)
        Me.lblVirus.TabIndex = 1
        Me.lblVirus.Text = "VIRUS"
        '
        'lblAnti
        '
        Me.lblAnti.AutoSize = True
        Me.lblAnti.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAnti.ForeColor = System.Drawing.Color.White
        Me.lblAnti.Location = New System.Drawing.Point(123, 1)
        Me.lblAnti.Name = "lblAnti"
        Me.lblAnti.Size = New System.Drawing.Size(109, 43)
        Me.lblAnti.TabIndex = 0
        Me.lblAnti.Text = "ANTI"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(0, 36)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(117, 123)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1116, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1075, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1034, -1)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'pnlAreaBar
        '
        Me.pnlAreaBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAreaBar.BackColor = System.Drawing.Color.Black
        Me.pnlAreaBar.Controls.Add(Me.picRadar)
        Me.pnlAreaBar.Location = New System.Drawing.Point(250, 159)
        Me.pnlAreaBar.Name = "pnlAreaBar"
        Me.pnlAreaBar.Size = New System.Drawing.Size(907, 418)
        Me.pnlAreaBar.TabIndex = 8
        '
        'picRadar
        '
        Me.picRadar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picRadar.BackColor = System.Drawing.Color.Transparent
        Me.picRadar.Image = CType(resources.GetObject("picRadar.Image"), System.Drawing.Image)
        Me.picRadar.Location = New System.Drawing.Point(192, 20)
        Me.picRadar.Name = "picRadar"
        Me.picRadar.Size = New System.Drawing.Size(510, 373)
        Me.picRadar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRadar.TabIndex = 3
        Me.picRadar.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DateTime
        '
        Me.DateTime.AutoSize = True
        Me.DateTime.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTime.Location = New System.Drawing.Point(4, 2)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(0, 31)
        Me.DateTime.TabIndex = 9
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 570)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.pnlAreaBar)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.pnlUpperBar)
        Me.Controls.Add(Me.pnlSideBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anti-Virus 2022"
        Me.pnlSideBar.ResumeLayout(False)
        Me.pnlSideBar.PerformLayout()
        CType(Me.CopyRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUpperBar.ResumeLayout(False)
        Me.pnlUpperBar.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAreaBar.ResumeLayout(False)
        CType(Me.picRadar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents pnlUpperBar As Panel
    Friend WithEvents lblAnti As Label
    Friend WithEvents lblVirus As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents pnlAreaBar As Panel
    Friend WithEvents btnBuyPremium As Button
    Friend WithEvents lblCheckStatus As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTimePeriod As Label
    Friend WithEvents btnTrialVs As Button
    Friend WithEvents picRadar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnQuickScan1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFullCheck As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSpeedUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTool As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnToolBox As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblIT As Label
    Friend WithEvents CopyRight As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DateTime As Label
    Friend WithEvents Timer2 As Timer
End Class
