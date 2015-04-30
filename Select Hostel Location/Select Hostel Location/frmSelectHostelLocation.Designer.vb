<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectHostelLocation
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
        Me.btnLondonHostel = New System.Windows.Forms.Button()
        Me.btnSelectLocation = New System.Windows.Forms.Button()
        Me.btnDublinHostel = New System.Windows.Forms.Button()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        Me.picLondon = New System.Windows.Forms.PictureBox()
        Me.picDublin = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        CType(Me.picLondon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDublin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLondonHostel
        '
        Me.btnLondonHostel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLondonHostel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnLondonHostel.Location = New System.Drawing.Point(102, 320)
        Me.btnLondonHostel.Name = "btnLondonHostel"
        Me.btnLondonHostel.Size = New System.Drawing.Size(93, 23)
        Me.btnLondonHostel.TabIndex = 1
        Me.btnLondonHostel.Text = "London Hostel"
        Me.btnLondonHostel.UseVisualStyleBackColor = False
        '
        'btnSelectLocation
        '
        Me.btnSelectLocation.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSelectLocation.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSelectLocation.Enabled = False
        Me.btnSelectLocation.Location = New System.Drawing.Point(229, 320)
        Me.btnSelectLocation.Name = "btnSelectLocation"
        Me.btnSelectLocation.Size = New System.Drawing.Size(93, 23)
        Me.btnSelectLocation.TabIndex = 2
        Me.btnSelectLocation.Text = "Select Location"
        Me.btnSelectLocation.UseVisualStyleBackColor = False
        '
        'btnDublinHostel
        '
        Me.btnDublinHostel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDublinHostel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDublinHostel.Location = New System.Drawing.Point(356, 320)
        Me.btnDublinHostel.Name = "btnDublinHostel"
        Me.btnDublinHostel.Size = New System.Drawing.Size(93, 23)
        Me.btnDublinHostel.TabIndex = 3
        Me.btnDublinHostel.Text = "Dublin Hostel"
        Me.btnDublinHostel.UseVisualStyleBackColor = False
        '
        'btnExitWindow
        '
        Me.btnExitWindow.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExitWindow.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExitWindow.Enabled = False
        Me.btnExitWindow.Location = New System.Drawing.Point(229, 444)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(93, 23)
        Me.btnExitWindow.TabIndex = 4
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = False
        '
        'picLondon
        '
        Me.picLondon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picLondon.Image = Global.WindowsApplication1.My.Resources.Resources.LondonHostel
        Me.picLondon.Location = New System.Drawing.Point(12, 62)
        Me.picLondon.Name = "picLondon"
        Me.picLondon.Size = New System.Drawing.Size(247, 227)
        Me.picLondon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLondon.TabIndex = 5
        Me.picLondon.TabStop = False
        Me.picLondon.Visible = False
        '
        'picDublin
        '
        Me.picDublin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picDublin.Image = Global.WindowsApplication1.My.Resources.Resources.DublinHostel
        Me.picDublin.Location = New System.Drawing.Point(292, 62)
        Me.picDublin.Name = "picDublin"
        Me.picDublin.Size = New System.Drawing.Size(247, 227)
        Me.picDublin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDublin.TabIndex = 6
        Me.picDublin.TabStop = False
        Me.picDublin.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(146, 363)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(259, 13)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Identify your choice and then click ""Select Location""."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Location = New System.Drawing.Point(176, 402)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(199, 13)
        Me.lblConfirmation.TabIndex = 8
        Me.lblConfirmation.Text = "You have selected your Hostel Location."
        Me.lblConfirmation.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(127, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(296, 29)
        Me.lblHeading.TabIndex = 9
        Me.lblHeading.Text = "Select a Hostel Location"
        '
        'frmSelectHostelLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(551, 490)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picDublin)
        Me.Controls.Add(Me.picLondon)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.btnDublinHostel)
        Me.Controls.Add(Me.btnSelectLocation)
        Me.Controls.Add(Me.btnLondonHostel)
        Me.Name = "frmSelectHostelLocation"
        Me.Text = "European Hostel"
        CType(Me.picLondon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDublin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLondonHostel As System.Windows.Forms.Button
    Friend WithEvents btnSelectLocation As System.Windows.Forms.Button
    Friend WithEvents btnDublinHostel As System.Windows.Forms.Button
    Friend WithEvents btnExitWindow As System.Windows.Forms.Button
    Friend WithEvents picLondon As System.Windows.Forms.PictureBox
    Friend WithEvents picDublin As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label

End Class
