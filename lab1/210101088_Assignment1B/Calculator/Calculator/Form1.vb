Option Explicit On

Public Class Form1
    Dim a, b, ans As Double
    Dim opern As String
    Dim temp As Decimal
    Dim limit_min As Single = -1000000000.0
    Dim limit_max As Single = 1000000000.0
    'Private digits() As Button
    'Public Sub New()
    'InitializeComponent()
    'digits = New Button() {Button0, Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
    'End Sub
    'Private Sub digits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal index As Integer) Handles digits.Click
    'display.Text = display.Text + digits(index).Text
    'End Sub
    Private Sub clearbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbutton.Click
        display.Text = ""
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        display.Text = display.Text + Button0.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        display.Text = display.Text + Button1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        display.Text = display.Text + Button2.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        display.Text = display.Text + Button3.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        display.Text = display.Text + Button4.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        display.Text = display.Text + Button5.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        display.Text = display.Text + Button6.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        display.Text = display.Text + Button7.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        display.Text = display.Text + Button8.Text
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        display.Text = display.Text + Button9.Text
    End Sub

    Private Sub addbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbutton.Click
        'a = Val(display.Lines(display.Lines.Length - 1))
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then
                display.Text = "Beyond calculation scope"
            Else
                opern = "+"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"
        End If
    End Sub

    Private Sub subtractbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractbutton.Click
        'a = Val(display.Lines(display.Lines.Length - 1))
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then
                display.Text = "Beyond calculation scope"
            Else
                opern = "-"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"
        End If
    End Sub

    Private Sub multiplybutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplybutton.Click
        'a = Val(display.Lines(display.Lines.Length - 1))
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then
                display.Text = "Beyond calculation scope"
            Else
                opern = "*"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"
        End If
    End Sub

    Private Sub dividebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dividebutton.Click
        'a = Val(display.Lines(display.Lines.Length - 1))
        If Double.TryParse(display.Lines(display.Lines.Length - 1), a) Then
            If a > limit_max Or a < limit_min Then
                display.Text = "Beyond calculation scope"
            Else
                opern = "/"
                display.Text = a.ToString + opern + Environment.NewLine
            End If
        Else
            display.Text = "Invalid Input"
        End If
    End Sub

    Private Sub dotbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dotbutton.Click
        display.Text = display.Text + "."
    End Sub

    Private Sub equalbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equalbutton.Click
        'Second line is new number
        'b = Val(display.Lines(1))
        If Double.TryParse(display.Lines(display.Lines.Length - 1), b) Then
            Select Case opern
                Case "+"
                    display.Text = a.ToString + "+" + b.ToString + Environment.NewLine
                    ans = a + b
                    ans = Math.Round(ans, 7)
                    If ans > limit_max Or ans < limit_min Then
                        display.Text = "Beyond calculation scope"
                    Else
                        display.Text = display.Text + ans.ToString
                    End If
                Case "-"
                    display.Text = a.ToString + "-" + b.ToString + Environment.NewLine
                    ans = a - b
                    ans = Math.Round(ans, 7)
                    If ans > limit_max Or ans < limit_min Then
                        display.Text = "Beyond calculation scope"
                    Else
                        display.Text = display.Text + ans.ToString
                    End If
                Case "*"
                    display.Text = a.ToString + "*" + b.ToString + Environment.NewLine
                    ans = a * b
                    ans = Math.Round(ans, 7)
                    If ans > limit_max Or ans < limit_min Then
                        display.Text = "Beyond calculation scope"
                    Else
                        display.Text = display.Text + ans.ToString
                    End If
                Case "/"
                    If b = 0 Then
                        display.Text = "Division by 0 not allowed"
                    Else
                        display.Text = a.ToString + "/" + b.ToString + Environment.NewLine
                        ans = a / b
                        ans = Math.Round(ans, 7)
                        If ans > limit_max Or ans < limit_min Then
                            display.Text = "Beyond calculation scope"
                        Else
                            display.Text = display.Text + ans.ToString
                        End If
                    End If
            End Select
        Else
            display.Text = "Invalid Input"
        End If
    End Sub

    Private Sub backspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backspace.Click
        Dim str As String
        str = display.Text
        If str.Length > 0 Then
            str = str.Substring(0, str.Length - 1)
            display.Text = str
        End If
    End Sub

    Private Sub signbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signbutton.Click
        Dim x As Double
        If display.Lines.Length >= 1 Then
            Double.TryParse(display.Lines(display.Lines.Length - 1), x)
            x = -x
            If display.Lines.Length = 1 Then
                display.Text = x.ToString
            Else
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
