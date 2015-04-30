<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRafflePrizeSelection
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
        Me.picTV = New System.Windows.Forms.PictureBox()
        Me.picLaptop = New System.Windows.Forms.PictureBox()
        Me.picGrill = New System.Windows.Forms.PictureBox()
        Me.btnGrill = New System.Windows.Forms.Button()
        Me.btnTV = New System.Windows.Forms.Button()
        Me.btnLaptop = New System.Windows.Forms.Button()
        Me.btnSelectPrize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.picTV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(149, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(240, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Raffle Prize Selection"
        '
        'picTV
        '
        Me.picTV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picTV.Image = Global.RafflePrizeSelection.My.Resources.Resources.TV
        Me.picTV.Location = New System.Drawing.Point(202, 88)
        Me.picTV.Name = "picTV"
        Me.picTV.Size = New System.Drawing.Size(259, 227)
        Me.picTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTV.TabIndex = 1
        Me.picTV.TabStop = False
        Me.picTV.Visible = False
        '
        'picLaptop
        '
        Me.picLaptop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLaptop.Image = Global.RafflePrizeSelection.My.Resources.Resources.Laptop
        Me.picLaptop.Location = New System.Drawing.Point(202, 88)
        Me.picLaptop.Name = "picLaptop"
        Me.picLaptop.Size = New System.Drawing.Size(259, 227)
        Me.picLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaptop.TabIndex = 2
        Me.picLaptop.TabStop = False
        Me.picLaptop.Visible = False
        '
        'picGrill
        '
        Me.picGrill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picGrill.Image = Global.RafflePrizeSelection.My.Resources.Resources.Grill
        Me.picGrill.Location = New System.Drawing.Point(202, 88)
        Me.picGrill.Name = "picGrill"
        Me.picGrill.Size = New System.Drawing.Size(259, 227)
        Me.picGrill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrill.TabIndex = 3
        Me.picGrill.TabStop = False
        Me.picGrill.Visible = False
        '
        'btnGrill
        '
        Me.btnGrill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGrill.BackColor = System.Drawing.Color.Orange
        Me.btnGrill.Location = New System.Drawing.Point(78, 119)
        Me.btnGrill.Name = "btnGrill"
        Me.btnGrill.Size = New System.Drawing.Size(104, 34)
        Me.btnGrill.TabIndex = 4
        Me.btnGrill.Text = "Gas Grill"
        Me.btnGrill.UseVisualStyleBackColor = False
        '
        'btnTV
        '
        Me.btnTV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTV.BackColor = System.Drawing.Color.Orange
        Me.btnTV.Location = New System.Drawing.Point(78, 185)
        Me.btnTV.Name = "btnTV"
        Me.btnTV.Size = New System.Drawing.Size(104, 34)
        Me.btnTV.TabIndex = 5
        Me.btnTV.Text = "Flat-Screen TV"
        Me.btnTV.UseVisualStyleBackColor = False
        '
        'btnLaptop
        '
        Me.btnLaptop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLaptop.BackColor = System.Drawing.Color.Orange
        Me.btnLaptop.Location = New System.Drawing.Point(78, 253)
        Me.btnLaptop.Name = "btnLaptop"
        Me.btnLaptop.Size = New System.Drawing.Size(104, 34)
        Me.btnLaptop.TabIndex = 6
        Me.btnLaptop.Text = "Laptop"
        Me.btnLaptop.UseVisualStyleBackColor = False
        '
        'btnSelectPrize
        '
        Me.btnSelectPrize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelectPrize.BackColor = System.Drawing.Color.Orange
        Me.btnSelectPrize.Location = New System.Drawing.Point(273, 321)
        Me.btnSelectPrize.Name = "btnSelectPrize"
        Me.btnSelectPrize.Size = New System.Drawing.Size(104, 34)
        Me.btnSelectPrize.TabIndex = 7
        Me.btnSelectPrize.Text = "Select Prize"
        Me.btnSelectPrize.UseVisualStyleBackColor = False
        Me.btnSelectPrize.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(217, 416)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 34)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(116, 65)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(307, 20)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Look through the prizes, then choose one."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(161, 369)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(216, 20)
        Me.lblConfirmation.TabIndex = 10
        Me.lblConfirmation.Text = "You have selected your prize."
        Me.lblConfirmation.Visible = False
        '
        'frmRafflePrizeSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(538, 462)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectPrize)
        Me.Controls.Add(Me.btnLaptop)
        Me.Controls.Add(Me.btnTV)
        Me.Controls.Add(Me.btnGrill)
        Me.Controls.Add(Me.picGrill)
        Me.Controls.Add(Me.picLaptop)
        Me.Controls.Add(Me.picTV)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmRafflePrizeSelection"
        Me.Text = "Prize Selection"
        CType(Me.picTV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLaptop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picTV As System.Windows.Forms.PictureBox
    Friend WithEvents picLaptop As System.Windows.Forms.PictureBox
    Friend WithEvents picGrill As System.Windows.Forms.PictureBox
    Friend WithEvents btnGrill As System.Windows.Forms.Button
    Friend WithEvents btnTV As System.Windows.Forms.Button
    Friend WithEvents btnLaptop As System.Windows.Forms.Button
    Friend WithEvents btnSelectPrize As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label

End Class
