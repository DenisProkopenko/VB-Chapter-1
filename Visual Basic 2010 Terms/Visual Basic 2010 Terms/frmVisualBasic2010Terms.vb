' Program Name:     Visual Basic 2010 Terms
' Developer:        Denis Prokopenko
' Date:             September 21, 2013
'                   This application allows the user to
'                   select terminology words and display
'                   their defenition.

Public Class frmVisualBasic2010Terms

    Private Sub btnComuterHardware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComuterHardware.Click
        'This code is executed when the user clicks on 
        'the "Computer Hardware" term. It displays the
        'defenition as well as hides other defenitions
        'that might have been visable before this code
        'was executed.

        lblComputerHardware.Visible = True              'Display the defenition of Computer Hardware
        lblDeveloper.Visible = False                    'Hide the defenition of Developer
        lblRapidApplicationDevelopment.Visible = False  'Hide the defenition of RAD
    End Sub

    Private Sub btnDeveloper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeveloper.Click
        'This code is executed when the user clicks on 
        'the "Developer" term. It displays the
        'defenition as well as hides other defenitions
        'that might have been visable before this code
        'was executed.

        lblComputerHardware.Visible = False             'Hide the defenition of Computer Hardware
        lblDeveloper.Visible = True                     'Display the defenition of Developer
        lblRapidApplicationDevelopment.Visible = False  'Hide the defenition of RAD
    End Sub

    Private Sub btnRapidApplicationDevelopment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRapidApplicationDevelopment.Click
        'This code is executed when the user clicks on 
        'the "RAD" term. It displays the defenition
        'as well as hides other defenitions that
        'might have been visable before this code
        'was executed.

        lblComputerHardware.Visible = False             'Hide the defenition of Computer Hardware
        lblDeveloper.Visible = False                    'Hide the defenition of Developer
        lblRapidApplicationDevelopment.Visible = True   'Display the defenition of RAD
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks
        'the Exit button. It closes the application 
        'execution

        Close()                                         'Close the application
    End Sub
End Class
