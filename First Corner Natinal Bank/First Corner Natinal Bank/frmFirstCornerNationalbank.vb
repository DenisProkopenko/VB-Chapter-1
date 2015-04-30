' Program Name: First Corner National Bank
' Developer:    Denis Prokopenko
' Date:         September 21, 2013
' Purpose:      This application allows the user
'               to view the bank hours.

Public Class frmFirstCornerNationalBank

    Private Sub btnBankingHours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBankingHours.Click
        'This code is executed when the user 
        'clicks on the "View Banking Hours". It
        'enables the text of the bank's available
        'hours, dissables the button from being
        'clicked again, and enables the exit button.

        txtHours.Visible = True             'Make hours text visable
        btnBankingHours.Enabled = False     'Disable the View Banking Hours button
        btnExit.Enabled = True              'Enables the exit button
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This code is executed when the user 
        'clicks on the Exit button, it closes
        'the application execution.

        Close()                             'Close the application
    End Sub
End Class
