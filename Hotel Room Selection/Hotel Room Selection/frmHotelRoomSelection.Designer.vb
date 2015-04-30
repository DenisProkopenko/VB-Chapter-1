<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomSelection
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
        Me.picStandardRoom = New System.Windows.Forms.PictureBox()
        Me.picDeluxeRoom = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnStandardRoom = New System.Windows.Forms.Button()
        Me.btnSelectRoom = New System.Windows.Forms.Button()
        Me.btnDeluxeRoom = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.picStandardRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeluxeRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStandardRoom
        '
        Me.picStandardRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picStandardRoom.Image = Global.WindowsApplication1.My.Resources.Resources.StandardRoom
        Me.picStandardRoom.Location = New System.Drawing.Point(92, 76)
        Me.picStandardRoom.Name = "picStandardRoom"
        Me.picStandardRoom.Size = New System.Drawing.Size(274, 205)
        Me.picStandardRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStandardRoom.TabIndex = 0
        Me.picStandardRoom.TabStop = False
        Me.picStandardRoom.Visible = False
        '
        'picDeluxeRoom
        '
        Me.picDeluxeRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picDeluxeRoom.Image = Global.WindowsApplication1.My.Resources.Resources.DeluxeRoom
        Me.picDeluxeRoom.Location = New System.Drawing.Point(92, 76)
        Me.picDeluxeRoom.Name = "picDeluxeRoom"
        Me.picDeluxeRoom.Size = New System.Drawing.Size(274, 205)
        Me.picDeluxeRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeluxeRoom.TabIndex = 1
        Me.picDeluxeRoom.TabStop = False
        Me.picDeluxeRoom.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(95, 22)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(268, 29)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Hotel Room Selection"
        '
        'btnStandardRoom
        '
        Me.btnStandardRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStandardRoom.BackColor = System.Drawing.Color.LightSalmon
        Me.btnStandardRoom.Location = New System.Drawing.Point(76, 305)
        Me.btnStandardRoom.Name = "btnStandardRoom"
        Me.btnStandardRoom.Size = New System.Drawing.Size(98, 23)
        Me.btnStandardRoom.TabIndex = 3
        Me.btnStandardRoom.Text = "Standard Room"
        Me.btnStandardRoom.UseVisualStyleBackColor = False
        '
        'btnSelectRoom
        '
        Me.btnSelectRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelectRoom.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSelectRoom.Enabled = False
        Me.btnSelectRoom.Location = New System.Drawing.Point(180, 305)
        Me.btnSelectRoom.Name = "btnSelectRoom"
        Me.btnSelectRoom.Size = New System.Drawing.Size(98, 23)
        Me.btnSelectRoom.TabIndex = 4
        Me.btnSelectRoom.Text = "Slect Room"
        Me.btnSelectRoom.UseVisualStyleBackColor = False
        '
        'btnDeluxeRoom
        '
        Me.btnDeluxeRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeluxeRoom.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDeluxeRoom.Location = New System.Drawing.Point(285, 305)
        Me.btnDeluxeRoom.Name = "btnDeluxeRoom"
        Me.btnDeluxeRoom.Size = New System.Drawing.Size(98, 23)
        Me.btnDeluxeRoom.TabIndex = 5
        Me.btnDeluxeRoom.Text = "Deluxe Room"
        Me.btnDeluxeRoom.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(180, 428)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(76, 352)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(307, 16)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Choose room type and click ""Select Room"" button."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(127, 388)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(0, 16)
        Me.lblConfirmation.TabIndex = 8
        '
        'frmHotelRoomSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(459, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeluxeRoom)
        Me.Controls.Add(Me.btnSelectRoom)
        Me.Controls.Add(Me.btnStandardRoom)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picDeluxeRoom)
        Me.Controls.Add(Me.picStandardRoom)
        Me.Name = "frmHotelRoomSelection"
        Me.Text = "Hotel Room Selection"
        CType(Me.picStandardRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeluxeRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picStandardRoom As System.Windows.Forms.PictureBox
    Friend WithEvents picDeluxeRoom As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnStandardRoom As System.Windows.Forms.Button
    Friend WithEvents btnSelectRoom As System.Windows.Forms.Button
    Friend WithEvents btnDeluxeRoom As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label

End Class
