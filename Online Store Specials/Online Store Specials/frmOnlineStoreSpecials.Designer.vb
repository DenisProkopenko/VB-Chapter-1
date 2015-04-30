<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineStoreSpecials
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picCellPhone = New System.Windows.Forms.PictureBox()
        Me.picIpodShuffle = New System.Windows.Forms.PictureBox()
        Me.picDigitalCamera = New System.Windows.Forms.PictureBox()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnHoliday = New System.Windows.Forms.Button()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblCellPhonePrice = New System.Windows.Forms.ListBox()
        Me.lblIpodPrice = New System.Windows.Forms.ListBox()
        Me.lblCameraPrice = New System.Windows.Forms.ListBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.picCellPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIpodShuffle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDigitalCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(220, 16)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(240, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Online Store Specials"
        '
        'picCellPhone
        '
        Me.picCellPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picCellPhone.Image = Global.WindowsApplication1.My.Resources.Resources.CellPhone
        Me.picCellPhone.Location = New System.Drawing.Point(226, 83)
        Me.picCellPhone.Name = "picCellPhone"
        Me.picCellPhone.Size = New System.Drawing.Size(228, 201)
        Me.picCellPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCellPhone.TabIndex = 1
        Me.picCellPhone.TabStop = False
        Me.picCellPhone.Visible = False
        '
        'picIpodShuffle
        '
        Me.picIpodShuffle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picIpodShuffle.Image = Global.WindowsApplication1.My.Resources.Resources.iPod
        Me.picIpodShuffle.Location = New System.Drawing.Point(226, 83)
        Me.picIpodShuffle.Name = "picIpodShuffle"
        Me.picIpodShuffle.Size = New System.Drawing.Size(228, 201)
        Me.picIpodShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIpodShuffle.TabIndex = 2
        Me.picIpodShuffle.TabStop = False
        Me.picIpodShuffle.Visible = False
        '
        'picDigitalCamera
        '
        Me.picDigitalCamera.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picDigitalCamera.Image = Global.WindowsApplication1.My.Resources.Resources.DigitalCamera
        Me.picDigitalCamera.Location = New System.Drawing.Point(226, 83)
        Me.picDigitalCamera.Name = "picDigitalCamera"
        Me.picDigitalCamera.Size = New System.Drawing.Size(228, 201)
        Me.picDigitalCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDigitalCamera.TabIndex = 3
        Me.picDigitalCamera.TabStop = False
        Me.picDigitalCamera.Visible = False
        '
        'btnDaily
        '
        Me.btnDaily.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDaily.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDaily.Location = New System.Drawing.Point(60, 83)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(104, 47)
        Me.btnDaily.TabIndex = 4
        Me.btnDaily.Text = "Daily Special"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'btnWeekly
        '
        Me.btnWeekly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWeekly.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnWeekly.Location = New System.Drawing.Point(60, 160)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(104, 47)
        Me.btnWeekly.TabIndex = 5
        Me.btnWeekly.Text = "Weekly Special"
        Me.btnWeekly.UseVisualStyleBackColor = False
        '
        'btnHoliday
        '
        Me.btnHoliday.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHoliday.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnHoliday.Location = New System.Drawing.Point(60, 237)
        Me.btnHoliday.Name = "btnHoliday"
        Me.btnHoliday.Size = New System.Drawing.Size(104, 47)
        Me.btnHoliday.TabIndex = 6
        Me.btnHoliday.Text = "Holiday Special"
        Me.btnHoliday.UseVisualStyleBackColor = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddToCart.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddToCart.Enabled = False
        Me.btnAddToCart.Location = New System.Drawing.Point(510, 261)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(104, 23)
        Me.btnAddToCart.TabIndex = 7
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.Location = New System.Drawing.Point(279, 435)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'lblCellPhonePrice
        '
        Me.lblCellPhonePrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCellPhonePrice.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCellPhonePrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCellPhonePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCellPhonePrice.FormattingEnabled = True
        Me.lblCellPhonePrice.ItemHeight = 20
        Me.lblCellPhonePrice.Items.AddRange(New Object() {"Cell Phone", "", "Regular Price:" & Global.Microsoft.VisualBasic.ChrW(9) & "$99.95", "", "Special Price:" & Global.Microsoft.VisualBasic.ChrW(9) & "$84.50"})
        Me.lblCellPhonePrice.Location = New System.Drawing.Point(461, 128)
        Me.lblCellPhonePrice.Name = "lblCellPhonePrice"
        Me.lblCellPhonePrice.Size = New System.Drawing.Size(208, 100)
        Me.lblCellPhonePrice.TabIndex = 9
        Me.lblCellPhonePrice.Visible = False
        '
        'lblIpodPrice
        '
        Me.lblIpodPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIpodPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIpodPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblIpodPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIpodPrice.FormattingEnabled = True
        Me.lblIpodPrice.ItemHeight = 20
        Me.lblIpodPrice.Items.AddRange(New Object() {"iPod Shuffle", "", "Regular Price:" & Global.Microsoft.VisualBasic.ChrW(9) & "$39.95", "", "Special Price:" & Global.Microsoft.VisualBasic.ChrW(9) & "$29.95"})
        Me.lblIpodPrice.Location = New System.Drawing.Point(461, 128)
        Me.lblIpodPrice.Name = "lblIpodPrice"
        Me.lblIpodPrice.Size = New System.Drawing.Size(208, 100)
        Me.lblIpodPrice.TabIndex = 10
        Me.lblIpodPrice.Visible = False
        '
        'lblCameraPrice
        '
        Me.lblCameraPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCameraPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCameraPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCameraPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraPrice.FormattingEnabled = True
        Me.lblCameraPrice.ItemHeight = 20
        Me.lblCameraPrice.Items.AddRange(New Object() {"Digital Camera", "", "Regular Price:" & Global.Microsoft.VisualBasic.ChrW(9) & "$259.95", "", "Special Price:" & Global.Microsoft.VisualBasic.ChrW(9) & "$203.19"})
        Me.lblCameraPrice.Location = New System.Drawing.Point(461, 128)
        Me.lblCameraPrice.Name = "lblCameraPrice"
        Me.lblCameraPrice.Size = New System.Drawing.Size(208, 100)
        Me.lblCameraPrice.TabIndex = 11
        Me.lblCameraPrice.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(166, 319)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(349, 20)
        Me.lblInstructions.TabIndex = 12
        Me.lblInstructions.Text = "Check out our specials and add one to your cart."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(202, 365)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(275, 20)
        Me.lblConfirmation.TabIndex = 13
        Me.lblConfirmation.Text = "You have added this item to your cart."
        Me.lblConfirmation.Visible = False
        '
        'frmOnlineStoreSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(681, 470)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblCameraPrice)
        Me.Controls.Add(Me.lblIpodPrice)
        Me.Controls.Add(Me.lblCellPhonePrice)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.btnHoliday)
        Me.Controls.Add(Me.btnWeekly)
        Me.Controls.Add(Me.btnDaily)
        Me.Controls.Add(Me.picDigitalCamera)
        Me.Controls.Add(Me.picIpodShuffle)
        Me.Controls.Add(Me.picCellPhone)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmOnlineStoreSpecials"
        Me.Text = "Store Specials"
        CType(Me.picCellPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIpodShuffle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDigitalCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picCellPhone As System.Windows.Forms.PictureBox
    Friend WithEvents picIpodShuffle As System.Windows.Forms.PictureBox
    Friend WithEvents picDigitalCamera As System.Windows.Forms.PictureBox
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnHoliday As System.Windows.Forms.Button
    Friend WithEvents btnAddToCart As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblCellPhonePrice As System.Windows.Forms.ListBox
    Friend WithEvents lblIpodPrice As System.Windows.Forms.ListBox
    Friend WithEvents lblCameraPrice As System.Windows.Forms.ListBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label

End Class
