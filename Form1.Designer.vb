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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cmdNewGame = New System.Windows.Forms.Button()
        Me.picCard0 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard4 = New System.Windows.Forms.PictureBox()
        Me.picCard5 = New System.Windows.Forms.PictureBox()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.picCard6 = New System.Windows.Forms.PictureBox()
        Me.picCard8 = New System.Windows.Forms.PictureBox()
        Me.picCard9 = New System.Windows.Forms.PictureBox()
        Me.picCard10 = New System.Windows.Forms.PictureBox()
        Me.picCard7 = New System.Windows.Forms.PictureBox()
        Me.cmdStand = New System.Windows.Forms.Button()
        Me.cmdHit = New System.Windows.Forms.Button()
        Me.cmdDeal = New System.Windows.Forms.Button()
        Me.lstPlayerCards = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optEleven = New System.Windows.Forms.RadioButton()
        Me.optOne = New System.Windows.Forms.RadioButton()
        Me.lstDealerCards = New System.Windows.Forms.ListBox()
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lstTopTen = New System.Windows.Forms.ListBox()
        Me.TimerMove1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblflash = New System.Windows.Forms.Label()
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerMove2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.lbl50 = New System.Windows.Forms.Label()
        Me.lbl25 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl500 = New System.Windows.Forms.Label()
        CType(Me.picCard0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(1535, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(117, 1396)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.Visible = False
        '
        'cmdNewGame
        '
        Me.cmdNewGame.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdNewGame.Enabled = False
        Me.cmdNewGame.Font = New System.Drawing.Font("Calibri", 26.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewGame.Location = New System.Drawing.Point(12, 12)
        Me.cmdNewGame.Name = "cmdNewGame"
        Me.cmdNewGame.Size = New System.Drawing.Size(180, 349)
        Me.cmdNewGame.TabIndex = 3
        Me.cmdNewGame.Text = "New Game"
        Me.cmdNewGame.UseVisualStyleBackColor = False
        '
        'picCard0
        '
        Me.picCard0.Image = CType(resources.GetObject("picCard0.Image"), System.Drawing.Image)
        Me.picCard0.Location = New System.Drawing.Point(198, 12)
        Me.picCard0.Name = "picCard0"
        Me.picCard0.Size = New System.Drawing.Size(72, 96)
        Me.picCard0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard0.TabIndex = 4
        Me.picCard0.TabStop = False
        '
        'picCard2
        '
        Me.picCard2.Image = CType(resources.GetObject("picCard2.Image"), System.Drawing.Image)
        Me.picCard2.Location = New System.Drawing.Point(198, 12)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(73, 97)
        Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard2.TabIndex = 5
        Me.picCard2.TabStop = False
        '
        'picCard3
        '
        Me.picCard3.Image = CType(resources.GetObject("picCard3.Image"), System.Drawing.Image)
        Me.picCard3.Location = New System.Drawing.Point(198, 12)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(73, 97)
        Me.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard3.TabIndex = 6
        Me.picCard3.TabStop = False
        '
        'picCard4
        '
        Me.picCard4.Image = CType(resources.GetObject("picCard4.Image"), System.Drawing.Image)
        Me.picCard4.Location = New System.Drawing.Point(198, 12)
        Me.picCard4.Name = "picCard4"
        Me.picCard4.Size = New System.Drawing.Size(73, 97)
        Me.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard4.TabIndex = 7
        Me.picCard4.TabStop = False
        '
        'picCard5
        '
        Me.picCard5.Image = CType(resources.GetObject("picCard5.Image"), System.Drawing.Image)
        Me.picCard5.Location = New System.Drawing.Point(198, 12)
        Me.picCard5.Name = "picCard5"
        Me.picCard5.Size = New System.Drawing.Size(73, 97)
        Me.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard5.TabIndex = 8
        Me.picCard5.TabStop = False
        '
        'picCard1
        '
        Me.picCard1.Image = CType(resources.GetObject("picCard1.Image"), System.Drawing.Image)
        Me.picCard1.Location = New System.Drawing.Point(198, 12)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(73, 97)
        Me.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard1.TabIndex = 9
        Me.picCard1.TabStop = False
        '
        'picCard6
        '
        Me.picCard6.Image = CType(resources.GetObject("picCard6.Image"), System.Drawing.Image)
        Me.picCard6.Location = New System.Drawing.Point(198, 12)
        Me.picCard6.Name = "picCard6"
        Me.picCard6.Size = New System.Drawing.Size(73, 97)
        Me.picCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard6.TabIndex = 10
        Me.picCard6.TabStop = False
        '
        'picCard8
        '
        Me.picCard8.Image = CType(resources.GetObject("picCard8.Image"), System.Drawing.Image)
        Me.picCard8.Location = New System.Drawing.Point(198, 12)
        Me.picCard8.Name = "picCard8"
        Me.picCard8.Size = New System.Drawing.Size(73, 97)
        Me.picCard8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard8.TabIndex = 11
        Me.picCard8.TabStop = False
        '
        'picCard9
        '
        Me.picCard9.Image = CType(resources.GetObject("picCard9.Image"), System.Drawing.Image)
        Me.picCard9.Location = New System.Drawing.Point(198, 12)
        Me.picCard9.Name = "picCard9"
        Me.picCard9.Size = New System.Drawing.Size(73, 97)
        Me.picCard9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard9.TabIndex = 12
        Me.picCard9.TabStop = False
        '
        'picCard10
        '
        Me.picCard10.Image = CType(resources.GetObject("picCard10.Image"), System.Drawing.Image)
        Me.picCard10.Location = New System.Drawing.Point(198, 12)
        Me.picCard10.Name = "picCard10"
        Me.picCard10.Size = New System.Drawing.Size(73, 97)
        Me.picCard10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard10.TabIndex = 13
        Me.picCard10.TabStop = False
        '
        'picCard7
        '
        Me.picCard7.Image = CType(resources.GetObject("picCard7.Image"), System.Drawing.Image)
        Me.picCard7.Location = New System.Drawing.Point(198, 12)
        Me.picCard7.Name = "picCard7"
        Me.picCard7.Size = New System.Drawing.Size(73, 97)
        Me.picCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCard7.TabIndex = 14
        Me.picCard7.TabStop = False
        '
        'cmdStand
        '
        Me.cmdStand.Enabled = False
        Me.cmdStand.Font = New System.Drawing.Font("Calibri Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStand.Location = New System.Drawing.Point(911, 1210)
        Me.cmdStand.Name = "cmdStand"
        Me.cmdStand.Size = New System.Drawing.Size(180, 120)
        Me.cmdStand.TabIndex = 15
        Me.cmdStand.Text = "Stay"
        Me.cmdStand.UseVisualStyleBackColor = True
        '
        'cmdHit
        '
        Me.cmdHit.Enabled = False
        Me.cmdHit.Font = New System.Drawing.Font("Calibri Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHit.Location = New System.Drawing.Point(1098, 1210)
        Me.cmdHit.Name = "cmdHit"
        Me.cmdHit.Size = New System.Drawing.Size(180, 120)
        Me.cmdHit.TabIndex = 16
        Me.cmdHit.Text = "Hit"
        Me.cmdHit.UseVisualStyleBackColor = True
        '
        'cmdDeal
        '
        Me.cmdDeal.BackColor = System.Drawing.Color.Maroon
        Me.cmdDeal.Enabled = False
        Me.cmdDeal.Font = New System.Drawing.Font("Calibri", 26.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeal.Location = New System.Drawing.Point(12, 376)
        Me.cmdDeal.Name = "cmdDeal"
        Me.cmdDeal.Size = New System.Drawing.Size(180, 349)
        Me.cmdDeal.TabIndex = 17
        Me.cmdDeal.Text = "Deal"
        Me.cmdDeal.UseVisualStyleBackColor = False
        '
        'lstPlayerCards
        '
        Me.lstPlayerCards.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayerCards.FormattingEnabled = True
        Me.lstPlayerCards.ItemHeight = 24
        Me.lstPlayerCards.Location = New System.Drawing.Point(1672, 12)
        Me.lstPlayerCards.Name = "lstPlayerCards"
        Me.lstPlayerCards.Size = New System.Drawing.Size(106, 1396)
        Me.lstPlayerCards.TabIndex = 18
        Me.lstPlayerCards.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.optEleven)
        Me.GroupBox1.Controls.Add(Me.optOne)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 825)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 197)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ace's"
        '
        'optEleven
        '
        Me.optEleven.AutoSize = True
        Me.optEleven.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEleven.Location = New System.Drawing.Point(30, 120)
        Me.optEleven.Name = "optEleven"
        Me.optEleven.Size = New System.Drawing.Size(152, 44)
        Me.optEleven.TabIndex = 1
        Me.optEleven.TabStop = True
        Me.optEleven.Text = "Eleven"
        Me.optEleven.UseVisualStyleBackColor = True
        '
        'optOne
        '
        Me.optOne.AutoSize = True
        Me.optOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOne.Location = New System.Drawing.Point(30, 65)
        Me.optOne.Name = "optOne"
        Me.optOne.Size = New System.Drawing.Size(110, 44)
        Me.optOne.TabIndex = 0
        Me.optOne.TabStop = True
        Me.optOne.Text = "One"
        Me.optOne.UseVisualStyleBackColor = True
        '
        'lstDealerCards
        '
        Me.lstDealerCards.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDealerCards.FormattingEnabled = True
        Me.lstDealerCards.ItemHeight = 24
        Me.lstDealerCards.Location = New System.Drawing.Point(1801, 12)
        Me.lstDealerCards.Name = "lstDealerCards"
        Me.lstDealerCards.Size = New System.Drawing.Size(106, 1396)
        Me.lstDealerCards.TabIndex = 20
        Me.lstDealerCards.Visible = False
        '
        'txtBet
        '
        Me.txtBet.BackColor = System.Drawing.Color.White
        Me.txtBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBet.Location = New System.Drawing.Point(109, 1223)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.ReadOnly = True
        Me.txtBet.Size = New System.Drawing.Size(161, 44)
        Me.txtBet.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 1223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 46)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Bet:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMoney.Location = New System.Drawing.Point(10, 1287)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(213, 59)
        Me.lblMoney.TabIndex = 27
        Me.lblMoney.Text = "$500.00"
        '
        'lstTopTen
        '
        Me.lstTopTen.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lstTopTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTopTen.ForeColor = System.Drawing.Color.White
        Me.lstTopTen.FormattingEnabled = True
        Me.lstTopTen.ItemHeight = 29
        Me.lstTopTen.Location = New System.Drawing.Point(1854, 1049)
        Me.lstTopTen.Name = "lstTopTen"
        Me.lstTopTen.Size = New System.Drawing.Size(286, 323)
        Me.lstTopTen.TabIndex = 28
        '
        'TimerMove1
        '
        Me.TimerMove1.Interval = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1845, 997)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 49)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Top Ten"
        '
        'lblflash
        '
        Me.lblflash.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblflash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblflash.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblflash.ForeColor = System.Drawing.Color.Maroon
        Me.lblflash.Location = New System.Drawing.Point(692, 63)
        Me.lblflash.Name = "lblflash"
        Me.lblflash.Size = New System.Drawing.Size(826, 117)
        Me.lblflash.TabIndex = 31
        Me.lblflash.Text = "Player Bust!"
        Me.lblflash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblflash.Visible = False
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-44, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1516, 924)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'TimerMove2
        '
        Me.TimerMove2.Interval = 25
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Peru
        Me.lbl5.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(12, 1042)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(133, 45)
        Me.lbl5.TabIndex = 33
        Me.lbl5.Text = "$5"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl100
        '
        Me.lbl100.BackColor = System.Drawing.Color.Peru
        Me.lbl100.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl100.Location = New System.Drawing.Point(12, 1159)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(133, 45)
        Me.lbl100.TabIndex = 34
        Me.lbl100.Text = "$100"
        Me.lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl50
        '
        Me.lbl50.BackColor = System.Drawing.Color.Peru
        Me.lbl50.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50.Location = New System.Drawing.Point(151, 1103)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(133, 45)
        Me.lbl50.TabIndex = 35
        Me.lbl50.Text = "$50"
        Me.lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl25
        '
        Me.lbl25.BackColor = System.Drawing.Color.Peru
        Me.lbl25.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl25.Location = New System.Drawing.Point(12, 1103)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(133, 45)
        Me.lbl25.TabIndex = 36
        Me.lbl25.Text = "$25"
        Me.lbl25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.Color.Peru
        Me.lbl10.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(151, 1042)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(133, 45)
        Me.lbl10.TabIndex = 37
        Me.lbl10.Text = "$10"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl500
        '
        Me.lbl500.BackColor = System.Drawing.Color.Peru
        Me.lbl500.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl500.Location = New System.Drawing.Point(151, 1159)
        Me.lbl500.Name = "lbl500"
        Me.lbl500.Size = New System.Drawing.Size(133, 45)
        Me.lbl500.TabIndex = 38
        Me.lbl500.Text = "$500"
        Me.lbl500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1928, 1388)
        Me.Controls.Add(Me.lbl500)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl25)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lblflash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstTopTen)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBet)
        Me.Controls.Add(Me.lstDealerCards)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstPlayerCards)
        Me.Controls.Add(Me.cmdDeal)
        Me.Controls.Add(Me.cmdHit)
        Me.Controls.Add(Me.cmdStand)
        Me.Controls.Add(Me.cmdNewGame)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.picCard0)
        Me.Controls.Add(Me.picCard1)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.picCard4)
        Me.Controls.Add(Me.picCard5)
        Me.Controls.Add(Me.picCard6)
        Me.Controls.Add(Me.picCard7)
        Me.Controls.Add(Me.picCard8)
        Me.Controls.Add(Me.picCard9)
        Me.Controls.Add(Me.picCard10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Black Jack"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picCard0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents cmdNewGame As Button
    Friend WithEvents picCard0 As PictureBox
    Friend WithEvents picCard2 As PictureBox
    Friend WithEvents picCard3 As PictureBox
    Friend WithEvents picCard4 As PictureBox
    Friend WithEvents picCard5 As PictureBox
    Friend WithEvents picCard1 As PictureBox
    Friend WithEvents picCard6 As PictureBox
    Friend WithEvents picCard8 As PictureBox
    Friend WithEvents picCard9 As PictureBox
    Friend WithEvents picCard10 As PictureBox
    Friend WithEvents picCard7 As PictureBox
    Friend WithEvents cmdStand As Button
    Friend WithEvents cmdHit As Button
    Friend WithEvents cmdDeal As Button
    Friend WithEvents lstPlayerCards As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optEleven As RadioButton
    Friend WithEvents optOne As RadioButton
    Friend WithEvents lstDealerCards As ListBox
    Friend WithEvents txtBet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lstTopTen As ListBox
    Friend WithEvents TimerMove1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblflash As Label
    Friend WithEvents tmrFlash As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerMove2 As Timer
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl100 As Label
    Friend WithEvents lbl50 As Label
    Friend WithEvents lbl25 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl500 As Label
End Class
