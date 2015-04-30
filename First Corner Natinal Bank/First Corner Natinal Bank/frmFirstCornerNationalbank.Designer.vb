<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstCornerNationalBank
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
        Me.picBank = New System.Windows.Forms.PictureBox()
        Me.lblInsured = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnBankingHours = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtHours = New System.Windows.Forms.ListBox()
        CType(Me.picBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBank
        '
        Me.picBank.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picBank.Image = Global.WindowsApplication1.My.Resources.Resources.BankBuilding
        Me.picBank.Location = New System.Drawing.Point(12, 12)
        Me.picBank.Name = "picBank"
        Me.picBank.Size = New System.Drawing.Size(173, 230)
        Me.picBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBank.TabIndex = 0
        Me.picBank.TabStop = False
        '
        'lblInsured
        '
        Me.lblInsured.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInsured.AutoSize = True
        Me.lblInsured.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsured.Location = New System.Drawing.Point(270, 117)
        Me.lblInsured.Name = "lblInsured"
        Me.lblInsured.Size = New System.Drawing.Size(137, 25)
        Me.lblInsured.TabIndex = 2
        Me.lblInsured.Text = "FDIC Insured"
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(269, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(196, 62)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "First Corner" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "National Bank"
        '
        'btnBankingHours
        '
        Me.btnBankingHours.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBankingHours.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnBankingHours.Location = New System.Drawing.Point(204, 360)
        Me.btnBankingHours.Name = "btnBankingHours"
        Me.btnBankingHours.Size = New System.Drawing.Size(126, 23)
        Me.btnBankingHours.TabIndex = 4
        Me.btnBankingHours.Text = "View Banking Hours"
        Me.btnBankingHours.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(230, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtHours
        '
        Me.txtHours.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.FormattingEnabled = True
        Me.txtHours.ItemHeight = 20
        Me.txtHours.Items.AddRange(New Object() {"Monday - Thursday" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "9:00 a.m to 5:00 p.m.", "Friday                                 " & Global.Microsoft.VisualBasic.ChrW(9) & "9:00 a.m to 8:00 p.m.", "Saturday                             " & Global.Microsoft.VisualBasic.ChrW(9) & "9:00 a.m to 1:00 p.m."})
        Me.txtHours.Location = New System.Drawing.Point(84, 262)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.txtHours.Size = New System.Drawing.Size(367, 80)
        Me.txtHours.TabIndex = 7
        Me.txtHours.Visible = False
        '
        'frmFirstCornerNationalBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(534, 441)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBankingHours)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblInsured)
        Me.Controls.Add(Me.picBank)
        Me.Name = "frmFirstCornerNationalBank"
        Me.Text = "Welcome"
        CType(Me.picBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBank As System.Windows.Forms.PictureBox
    Friend WithEvents lblInsured As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnBankingHours As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtHours As System.Windows.Forms.ListBox

End Class
