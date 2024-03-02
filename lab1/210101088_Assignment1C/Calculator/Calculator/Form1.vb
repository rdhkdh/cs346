Option Explicit On

Public Class Form1
    ' Global variables
    Dim a, b, ans As Double
    Dim opern As String
    Dim temp As Decimal
    Dim limit_min As Single = -1000000000.0 ' Minimum limit of calculation
    Dim limit_max As Single = 1000000000.0  ' Maximum limit of calculation

    ' Clears the calculator display
    Private Sub clearbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbutton.Click
        display.Text = ""
    End Sub

    ' Appends 0 on the screen
    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        display.Text = display.Text + Button0.Text
    End Sub

    ' Appends 1 on the screen
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        display.Text = display.Text + Button1.Text
    End Sub

    ' Appends 2 on the screen
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        display.Text = display.Text + Button2.Text
    End Sub

    ' Appends 3 on the screen
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        display.Text = display.Text + Button3.Text
    End Sub

    ' Appends 4 on the screen
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        display.Text = display.Text + Button4.Text
    End Sub

    ' Appends 5 on the screen
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        display.Text = display.Text + Button5.Text
    End Sub

    ' Appends 6 on the screen
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        display.Text = display.Text + Button6.Text
    End Sub

    ' Appends 7 on the screen
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        display.Text = display.Text + Button7.Text
    End Sub

    ' Appends 8 on the screen
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        display.Text = display.Text + Button8.Text
    End Sub

    ' Appends 9 on the screen
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        display.Text = display.Text + Button9.Text
    End Sub

    ' Appends + operator on the screen
    Private Sub addbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbutton.Click
        ' Read the last line on display and store in variable a
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then      ' Check if a is in the defined range
                display.Text = "Beyond calculation scope"
            Else
                opern = "+"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"     ' TryParse returns False if input is not numeric
        End If
    End Sub

    ' Appends - operator on the screen
    Private Sub subtractbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractbutton.Click
        ' Read the last line on display and store in variable a
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then     ' Check if a is in the defined range
                display.Text = "Beyond calculation scope"
            Else
                opern = "-"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"   ' TryParse returns False if input is not numeric
        End If
    End Sub

    ' Appends * operator on the screen
    Private Sub multiplybutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplybutton.Click
        ' Read the last line on display and store in variable a
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then       ' Check if a is in the defined range
                display.Text = "Beyond calculation scope"
            Else
                opern = "*"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"    ' TryParse returns False if input is not numeric
        End If
    End Sub

    ' Appends / operator on the screen
    Private Sub dividebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dividebutton.Click
        ' Read the last line on display and store in variable a
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then       ' Check if a is in the defined range
                display.Text = "Beyond calculation scope"
            Else
                opern = "/"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"      ' TryParse returns False if input is not numeric
        End If
    End Sub

    ' Appends decimal point on the screen
    Private Sub dotbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dotbutton.Click
        display.Text = display.Text + "."
    End Sub

    ' Calculates the result and displays on screen
    Private Sub equalbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equalbutton.Click
        If display.Text = "" Then
            display.Text = "Invalid Input"
        End If
        ' Read the last line on display and store in variable b
        If Double.TryParse(display.Lines(display.Lines.Length - 1), b) Then
            Select Case opern
                Case "+"
                    display.Text = a.ToString + "+" + b.ToString + Environment.NewLine
                    ans = a + b  'Add the 2 nos
                    ans = Math.Round(ans, 7)   'Round off to 7 decimal places 
                    If ans > limit_max Or ans < limit_min Then   'Check that ans is within range
                        display.Text = "Beyond calculation scope"
                    Else
                        display.Text = display.Text + ans.ToString
                    End If
                Case "-"
                    display.Text = a.ToString + "-" + b.ToString + Environment.NewLine
                    ans = a - b   'Subtract the 2 nos
                    ans = Math.Round(ans, 7)  'Round off to 7 decimal places
                    If ans > limit_max Or ans < limit_min Then    'Check that ans is within range
                        display.Text = "Beyond calculation scope"
                    Else
                        display.Text = display.Text + ans.ToString
                    End If
                Case "*"
                    display.Text = a.ToString + "*" + b.ToString + Environment.NewLine
                    ans = a * b    'Multiply the 2 nos
                    ans = Math.Round(ans, 7)  'Round off to 7 decimal places
                    If ans > limit_max Or ans < limit_min Then     'Check that ans is within range
                        display.Text = "Beyond calculation scope"
                    Else
                        display.Text = display.Text + ans.ToString
                    End If
                Case "/"
                    If b = 0 Then   'Check for division by 0 error
                        display.Text = "Division by 0 not allowed"
                    Else
                        display.Text = a.ToString + "/" + b.ToString + Environment.NewLine
                        ans = a / b     'Divide the 2 nos
                        ans = Math.Round(ans, 7)   'Round off to 7 decimal places
                        If ans > limit_max Or ans < limit_min Then    'Check that ans is within range
                            display.Text = "Beyond calculation scope"
                        Else
                            display.Text = display.Text + ans.ToString
                        End If
                    End If
            End Select
        Else        'TryParse returns False if input is not numeric 
            display.Text = "Invalid Input"
        End If
    End Sub

    ' Removes last character from string in the display
    Private Sub backspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backspace.Click
        Dim str As String
        str = display.Text
        If str.Length > 0 Then
            str = str.Substring(0, str.Length - 1)
            display.Text = str
        End If
    End Sub

    'Toggles between positive or negative sign of the number on the last line of display
    Private Sub signbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signbutton.Click
        Dim x As Double
        If display.Lines.Length >= 1 Then
            Double.TryParse(display.Lines(display.Lines.Length - 1), x)   'Read number from the last line
            x = -x    'Toggle its sign
            If display.Lines.Length = 1 Then
                display.Text = x.ToString
            Else   'Preserve all lines but the last one, and append the modified line to the new array
                ' Create a new array with the modified last line
                Dim modifiedLines(display.Lines.Length - 1) As String
                Array.Copy(display.Lines, modifiedLines, display.Lines.Length)
                modifiedLines(display.Lines.Length - 1) = x.ToString

                ' Update the TextBox with the modified lines
                display.Lines = modifiedLines
            End If
        End If
    End Sub

End Class
