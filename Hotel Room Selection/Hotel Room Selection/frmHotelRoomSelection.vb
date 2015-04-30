' Program Name:   Hotel Room Selection
' Developer:      Denis Prokopenko
' Date:           September 17, 2013
'                 This applications displays two
'                 hotel room types (standard and
'                 deluxe). The user can select 
'                 a room type.

Public Class frmHotelRoomSelection

    Private Sub btnStandardRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStandardRoom.Click
        ' This code is executed when the user
        ' clicks the Standard Room button, It
        ' it displays the Standard Room picture,
        ' keeps Deluxe Room picture hidden or 
        ' hides the picture if already visable,
        ' and enables the Select Room button.

        picStandardRoom.Visible = True                  'Display Picture
        picDeluxeRoom.Visible = False                   'Hide Picture
        btnSelectRoom.Enabled = True                    'Enable Button
    End Sub

    Private Sub btnDeluxeRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeluxeRoom.Click
        ' This code is executed when the user
        ' clicks the Deluxe Room button, It
        ' it displays the Deluxe Room picture,
        ' keeps Standard Room picture hidden or 
        ' hides the picture if already visable,
        ' and enables the Select Room button.

        picStandardRoom.Visible = False                 'Hide Picture
        picDeluxeRoom.Visible = True                    'Display Picture
        btnSelectRoom.Enabled = True                    'Enable Button
    End Sub

    Private Sub btnSelectRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectRoom.Click
        ' This code is executed when the user 
        ' clicks on the Select Room button.
        ' It will will disable the Standard
        ' Room button, Disable Select Room
        ' button, Disable the Deluxe Room
        ' button, Hide the Instructions Label,
        ' Display the Confirmation Message 
        ' Label, and it Enables the Exit
        ' Window button.

        btnStandardRoom.Enabled = False                                 'Disable Button
        btnDeluxeRoom.Enabled = False                                   'Disable Button
        btnSelectRoom.Enabled = False                                   'Disable Button
        btnExit.Enabled = True                                          'Enable Exit Window Button
        lblInstructions.Visible = False                                 'Hide Instructions
        If picStandardRoom.Visible = True Then
            lblConfirmation.Text = "You have selected Standard Room."   'Display Confirmation Message
        End If
        If picDeluxeRoom.Visible = True Then
            lblConfirmation.Text = "You have selected Deluxe Room."     'Display Confirmation Message
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' This code is executed when the user
        ' clicks the Exit button. It closes
        ' the window and terminates the 
        ' program execution.

        Close()                                         'Close the Application
    End Sub
End Class
