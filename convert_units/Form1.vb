'Author: Julie Rapson
'Date: 3/14/2023
'Program Description: This program is a basic unit converter.  You will enter a value, choose a selection and then
'click convert.  Your selection options are Inches to Meters or Meters to Inches.  The program will do the calculation and
'return the result for you. You can clear and start again. You can also exit the program.

Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdInchesToMeters.CheckedChanged

    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        'Exit the program when the button is clicked.
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Setting the default radio button selection to Inches to meters. Clearing out the results area and the text box.
        'Making the text box the focus area.
        rdInchesToMeters.Checked = True
        txtEnteredNum.Text = ""
        lblResults.Text = ""
        txtEnteredNum.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting the default radio button selection to Inches to meters. Clearing out the results area and the text box.
        'Making the text box the focus area.
        rdInchesToMeters.Checked = True
        txtEnteredNum.Text = ""
        lblResults.Text = ""
        txtEnteredNum.Focus()

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declaring needed variables below. I had to do a check for numeric as well as creating
        'a variable for the result set.  I also set the values for the conversion calculations.
        Dim checkNum = IsNumeric(txtEnteredNum.Text)
        Dim conversionResult As Decimal
        Dim myNumtoconvert As String
        Dim decMeter As Decimal = 0.0254D
        Dim decInch As Decimal = 39.3701D
        Dim unitOfMeasure As String = "meters"
        Dim unitOfMeasure2 As String = " inches"

        'Dim myNumtoconvert = Convert.ToDecimal(txtEnteredNum.Text) 'Error happens here,but if I remove this, it doesnt calculate my values correctly

        'First thing to do is check if what was entered was an actual number, if yes convert to Decimal
        If IsNumeric(txtEnteredNum.Text) Then
            myNumtoconvert = Convert.ToDecimal(txtEnteredNum.Text)
            If myNumtoconvert > 0 Then
                'This is making sure its positive, if it is, do the math work!
                'Inches to Meters selection
                If rdInchesToMeters.Checked Then
                    conversionResult = myNumtoconvert * decMeter
                    unitOfMeasure = "inches "
                    unitOfMeasure2 = " meters"
                    'Meters to Inches selection
                ElseIf rdMetersToInches.Checked Then
                    conversionResult = myNumtoconvert * decInch
                    unitOfMeasure = "meters"
                    unitOfMeasure2 = " inches"
                End If
                'Take the results and print to the screen
                lblResults.Text = myNumtoconvert.ToString() + " " + unitOfMeasure + " is " + conversionResult.ToString() + unitOfMeasure2
                lblResults.Visible = True
            Else
                MsgBox("Please enter a positive value only.")
                lblResults.Text = ""
            End If
            'You did not pass the first test, so you automatically come here and get an error message
        Else
            MsgBox("Please only enter a valid number for your group.")
            lblResults.Text = ""
        End If
        'I left my old code below for my personal learning experience. I loved the analogy with good person, bad person! :) 

        'If String.IsNullOrEmpty(txtEnteredNum.Text) Then
        'MsgBox("Please enter a value in order to proceed.")
        'lblResults.Visible = False
        'ElseIf checkNum = False Then
        'MsgBox("Please only enter a valid number for your group.")
        'lblResults.Visible = False
        'ElseIf txtEnteredNum.Text < 1 Then
        'MsgBox("Please enter a positive value only.")
        'lblResults.Visible = False
        'ElseIf rdInchesToMeters.Checked = True Then
        'conversionResult = Convert.ToDecimal(txtEnteredNum.Text) * decMeter
        'unitOfMeasure = "inches "
        'unitOfMeasure2 = " meters"
        'lblResults.Text = myNumtoconvert.ToString() + " inches is " + conversionResult.ToString() + " meters."
        ' ElseIf rdMetersToInches.Checked = True Then
        'conversionResult = Convert.ToInt32(txtEnteredNum.Text) * decInch
        'unitOfMeasure = "meters"
        'unitOfMeasure2 = " inches"
        'lblResults.Text = myNumtoconvert.ToString() + " meters is " + conversionResult.ToString() + " inches." 
        'End If
        'Make label visible and show results of calculations
        'lblResults.Text = myNumtoconvert.ToString() + " " + unitOfMeasure + " is " + conversionResult.ToString() + unitOfMeasure2
        'lblResults.Visible = True

    End Sub
End Class
