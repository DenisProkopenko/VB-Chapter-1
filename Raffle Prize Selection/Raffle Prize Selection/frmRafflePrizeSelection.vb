' Program Name:     Raffle Prize Selection
' Developer:        Denis Prokopenko
' Date:             September 22, 2013
'                   This application allows the user to
'                   view and select one prize from the 
'                   listed raffle prizes.
Public Class frmRafflePrizeSelection

    Private Sub btnGrill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrill.Click
        'This code is executed when the user clicks on the
        'Gas Grill button. It ______

        picGrill.Visible = True         'Displays Grill pic
        picTV.Visible = False           'Hides TV pic
        picLaptop.Visible = False       'Hides Laptop Pic
        btnSelectPrize.Visible = True   'Displays Select Prize Button
    End Sub

    Private Sub btnTV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTV.Click
        'This code is executed when the user clicks on the
        'Flat-Screen TV button. It ______

        picGrill.Visible = False        'Hides Grill pic
        picTV.Visible = True            'Displays the TV pic
        picLaptop.Visible = False       'Hides Laptop pic
        btnSelectPrize.Visible = True   'Displays Select Prize Button
    End Sub

    Private Sub btnLaptop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaptop.Click
        'This code is executed when the user clicks on the
        'Laptop button. It ______

        picGrill.Visible = False        'Hides Grill pic
        picTV.Visible = False           'Hides TV pic
        picLaptop.Visible = True        'Displays the Laptop pic
        btnSelectPrize.Visible = True   'Displays Select Prize Button
    End Sub

    Private Sub btnSelectPrize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPrize.Click
        'This code is executed when the user clicks on the
        'Select Prize button. It ______

        btnGrill.Enabled = False        'Disables the Grill Button
        btnTV.Enabled = False           'Disables the TV Button
        btnLaptop.Enabled = False       'Disables the Laptop Button
        btnSelectPrize.Enabled = False    'Disables the Select Prize Button
        lblInstructions.Visible = False 'Hides the Instructions
        lblConfirmation.Visible = True  'Displays the Confirmation
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks on the
        'Exit button. It ______

        Close()                         'Closes the application execution
    End Sub
End Class
