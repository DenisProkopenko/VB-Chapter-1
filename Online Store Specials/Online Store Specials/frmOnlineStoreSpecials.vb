' Program Name:     Online Store Specials
' Developer:        Denis Prokopenko
' Date:             September 21, 2013
'                   This applications displays the specials 
'                   of the online store. The user is able to 
'                   browse through the offers and select an
'                   item to be added to the cart.

Public Class frmOnlineStoreSpecials

    Private Sub btnDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaily.Click
        'This code is executed when the user clicks the Daily Special
        'button. It displays the special for that period of time, hides
        'all other specials if they are displayed, and enables the 
        'add to cart button.

        picCellPhone.Visible = True         'Cell phone pic visable
        picIpodShuffle.Visible = False      'iPod pic hidden
        picDigitalCamera.Visible = False    'Camera pic hidden
        lblCellPhonePrice.Visible = True    'Cell phone price visable
        lblIpodPrice.Visible = False        'iPod price hidden
        lblCameraPrice.Visible = False      'Camera rice hidden
        btnAddToCart.Enabled = True         'Add to Cart button enabled
    End Sub

    Private Sub btnWeekly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeekly.Click
        'This code is executed when the user clicks the Weekly Special
        'button. It displays the special for that period of time, hides
        'all other specials if they are displayed, and enables the 
        'add to cart button.

        picCellPhone.Visible = False        'Cell phone pic hidden
        picIpodShuffle.Visible = True       'iPod pic visable
        picDigitalCamera.Visible = False    'Camera pic hidden
        lblCellPhonePrice.Visible = False   'Cell phone price hidden
        lblIpodPrice.Visible = True         'iPod price visable
        lblCameraPrice.Visible = False      'Camera rice hidden
        btnAddToCart.Enabled = True         'Add to Cart button enabled
    End Sub

    Private Sub btnHoliday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoliday.Click
        'This code is executed when the user clicks the Holiday Special
        'button. It displays the special for that period of time, hides
        'all other specials if they are displayed, and enables the 
        'add to cart button.

        picCellPhone.Visible = False        'Cell phone pic hidden
        picIpodShuffle.Visible = False      'iPod pic hidden
        picDigitalCamera.Visible = True     'Camera pic visable
        lblCellPhonePrice.Visible = False   'Cell phone price hidden
        lblIpodPrice.Visible = False        'iPod price hidden
        lblCameraPrice.Visible = True       'Camera rice visable
        btnAddToCart.Enabled = True         'Add to Cart button enabled
    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click
        'This code is executed when the user clicks the Add to Cart
        'button. It disables the buttons to the special's selection,
        'hides the instructions, and displays the confirmation
        'message.

        btnDaily.Enabled = False            'Daily Special button disabled
        btnWeekly.Enabled = False           'Weekly Special button disabled
        btnHoliday.Enabled = False          'Holiday Special button disabled
        btnAddToCart.Enabled = False          'Add to Cart button disabled
        lblInstructions.Visible = False     'Hide Instructions
        lblConfirmation.Visible = True      'Show Confirmation Message
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'This code is executed when the user clicks the Exit button.
        'It ends the application execution.

        Close()                             'Close application
    End Sub
End Class
