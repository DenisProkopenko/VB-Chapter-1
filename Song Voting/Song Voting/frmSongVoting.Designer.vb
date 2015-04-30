<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongVoting
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
        Me.btnHipHop = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnRap = New System.Windows.Forms.Button()
        Me.btnVote1 = New System.Windows.Forms.Button()
        Me.btnVote2 = New System.Windows.Forms.Button()
        Me.btnHipHopArtist1 = New System.Windows.Forms.Button()
        Me.btnArtist2 = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnPopArtist1 = New System.Windows.Forms.Button()
        Me.btnPopArtist2 = New System.Windows.Forms.Button()
        Me.btnRapArtist1 = New System.Windows.Forms.Button()
        Me.btnRapArtist2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHipHop
        '
        Me.btnHipHop.Location = New System.Drawing.Point(24, 74)
        Me.btnHipHop.Name = "btnHipHop"
        Me.btnHipHop.Size = New System.Drawing.Size(75, 23)
        Me.btnHipHop.TabIndex = 0
        Me.btnHipHop.Text = "Hip Hop"
        Me.btnHipHop.UseVisualStyleBackColor = True
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(24, 132)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(75, 23)
        Me.btnPop.TabIndex = 1
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnRap
        '
        Me.btnRap.Location = New System.Drawing.Point(24, 192)
        Me.btnRap.Name = "btnRap"
        Me.btnRap.Size = New System.Drawing.Size(75, 23)
        Me.btnRap.TabIndex = 2
        Me.btnRap.Text = "Rap"
        Me.btnRap.UseVisualStyleBackColor = True
        '
        'btnVote1
        '
        Me.btnVote1.Location = New System.Drawing.Point(215, 271)
        Me.btnVote1.Name = "btnVote1"
        Me.btnVote1.Size = New System.Drawing.Size(75, 23)
        Me.btnVote1.TabIndex = 3
        Me.btnVote1.Text = "Vote 1"
        Me.btnVote1.UseVisualStyleBackColor = True
        '
        'btnVote2
        '
        Me.btnVote2.Location = New System.Drawing.Point(352, 270)
        Me.btnVote2.Name = "btnVote2"
        Me.btnVote2.Size = New System.Drawing.Size(75, 23)
        Me.btnVote2.TabIndex = 4
        Me.btnVote2.Text = "Vote 2"
        Me.btnVote2.UseVisualStyleBackColor = True
        '
        'btnHipHopArtist1
        '
        Me.btnHipHopArtist1.Location = New System.Drawing.Point(202, 241)
        Me.btnHipHopArtist1.Name = "btnHipHopArtist1"
        Me.btnHipHopArtist1.Size = New System.Drawing.Size(104, 23)
        Me.btnHipHopArtist1.TabIndex = 5
        Me.btnHipHopArtist1.Text = "Hip-Hop Artist 1"
        Me.btnHipHopArtist1.UseVisualStyleBackColor = True
        '
        'btnArtist2
        '
        Me.btnArtist2.Location = New System.Drawing.Point(337, 241)
        Me.btnArtist2.Name = "btnArtist2"
        Me.btnArtist2.Size = New System.Drawing.Size(104, 23)
        Me.btnArtist2.TabIndex = 6
        Me.btnArtist2.Text = "Hip-Hop Artist 2"
        Me.btnArtist2.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(223, 38)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(108, 20)
        Me.lblHeading.TabIndex = 7
        Me.lblHeading.Text = "Song Voting"
        '
        'btnPopArtist1
        '
        Me.btnPopArtist1.Location = New System.Drawing.Point(202, 242)
        Me.btnPopArtist1.Name = "btnPopArtist1"
        Me.btnPopArtist1.Size = New System.Drawing.Size(104, 23)
        Me.btnPopArtist1.TabIndex = 8
        Me.btnPopArtist1.Text = "Pop Artist 1"
        Me.btnPopArtist1.UseVisualStyleBackColor = True
        '
        'btnPopArtist2
        '
        Me.btnPopArtist2.Location = New System.Drawing.Point(337, 241)
        Me.btnPopArtist2.Name = "btnPopArtist2"
        Me.btnPopArtist2.Size = New System.Drawing.Size(104, 23)
        Me.btnPopArtist2.TabIndex = 9
        Me.btnPopArtist2.Text = "Pop Artist 2"
        Me.btnPopArtist2.UseVisualStyleBackColor = True
        '
        'btnRapArtist1
        '
        Me.btnRapArtist1.Location = New System.Drawing.Point(202, 242)
        Me.btnRapArtist1.Name = "btnRapArtist1"
        Me.btnRapArtist1.Size = New System.Drawing.Size(104, 23)
        Me.btnRapArtist1.TabIndex = 10
        Me.btnRapArtist1.Text = "Rap Artist 1"
        Me.btnRapArtist1.UseVisualStyleBackColor = True
        '
        'btnRapArtist2
        '
        Me.btnRapArtist2.Location = New System.Drawing.Point(337, 241)
        Me.btnRapArtist2.Name = "btnRapArtist2"
        Me.btnRapArtist2.Size = New System.Drawing.Size(104, 23)
        Me.btnRapArtist2.TabIndex = 11
        Me.btnRapArtist2.Text = "Rap Artist 2"
        Me.btnRapArtist2.UseVisualStyleBackColor = True
        '
        'frmSongVoting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 439)
        Me.Controls.Add(Me.btnRapArtist2)
        Me.Controls.Add(Me.btnRapArtist1)
        Me.Controls.Add(Me.btnPopArtist2)
        Me.Controls.Add(Me.btnPopArtist1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnArtist2)
        Me.Controls.Add(Me.btnHipHopArtist1)
        Me.Controls.Add(Me.btnVote2)
        Me.Controls.Add(Me.btnVote1)
        Me.Controls.Add(Me.btnRap)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnHipHop)
        Me.Name = "frmSongVoting"
        Me.Text = "Millennium Music"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHipHop As System.Windows.Forms.Button
    Friend WithEvents btnPop As System.Windows.Forms.Button
    Friend WithEvents btnRap As System.Windows.Forms.Button
    Friend WithEvents btnVote1 As System.Windows.Forms.Button
    Friend WithEvents btnVote2 As System.Windows.Forms.Button
    Friend WithEvents btnHipHopArtist1 As System.Windows.Forms.Button
    Friend WithEvents btnArtist2 As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnPopArtist1 As System.Windows.Forms.Button
    Friend WithEvents btnPopArtist2 As System.Windows.Forms.Button
    Friend WithEvents btnRapArtist1 As System.Windows.Forms.Button
    Friend WithEvents btnRapArtist2 As System.Windows.Forms.Button

End Class
