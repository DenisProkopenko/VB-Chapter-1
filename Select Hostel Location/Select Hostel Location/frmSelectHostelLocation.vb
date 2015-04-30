' Program Name:   Select Hostel Location
' Developer:      Denis Prokopenko
' Date:           September 20, 2013
'                 This applications displays two
'                 Hostel Locations (London and
'                 Dublin). The user can select 
'                 the Hostel Location.

Public Class frmSelectHostelLocation

    Private Sub btnLondonHostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLondonHostel.Click
        'This code is executed when the user clicks on the
        '"London Hostel" button. It displays the London Hostel
        'picture, hides the Dublin Hostel picture if visable,
        'or keeps it hidden. It also enables the Select 
        'Location button.

        picLondon.Visible = True            'London Pic Visable
        picDublin.Visible = False           'Dublin Pic Hidden
        btnSelectLocation.Enabled = True    'Select Location Button Enabled

    End Sub

    Private Sub btnDublinHostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDublinHostel.Click
        'This code is executed when the user clicks on the
        '"Dublin Hostel" button. It displays the Dublin Hostel
        'picture, hides the London Hostel picture if visable,
        'or keeps it hidden. It also enables the Select 
        'Location button.

        picLondon.Visible = False           'London Pic Hidden
        picDublin.Visible = True            'Dublin Pic Visable
        btnSelectLocation.Enabled = True    'Select Location Button Enabled
    End Sub

    Private Sub btnSelectLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectLocation.Click
        'This code is executed when the user click on the 
        '"Sellect Location" button. It hides the Instructions
        'Label, Displays the Confirmation Label, Disables 
        'London and Dublin Location Buttons, as well as 
        'Enables the Exit Window Button.

        lblInstructions.Visible = False     'Instruction Lable Hidden
        lblConfirmation.Visible = True      'Confirmation Label Visable
        btnExitWindow.Enabled = True        'Exit Window Button Enabled
        btnLondonHostel.Enabled = False     'London Hostel Button Disabled
        btnDublinHostel.Enabled = False     'Dublin Hostel Button Disabled
        btnSelectLocation.Enabled = False     'Select Location Button Disabled
    End Sub

    Private Sub btnExitWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitWindow.Click
        'This code is executed once the user clicks on the 
        'Exit Window button. It closes the application.

        Close()                             'close the application
    End Sub
End Class
