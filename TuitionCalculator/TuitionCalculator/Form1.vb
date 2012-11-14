Public Class Form1
    'Austin Keener
    '11/14/2012
    'Tuition Calculator

    'Initialize required variables
    Const intUndergraduatePrice As Integer = 75     'Constants used because these prices never change.
    Const intGraduatePrice As Integer = 145
    Const intThesisPrice As Integer = 165
    Dim intHours As Integer = 0
    Dim dblTuition As Double = 0.0

    'Executed when the Calulcate button is clicked.
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Select Case lstDegrees.SelectedIndex
            Case -1                     'Case for nothing selected
                dblTuition = 0.0            'Set to 0 for boolean check later
            Case 0                      'Case for Undergraduate Selected
                dblTuition = intUndergraduatePrice
            Case 1                      'Case for Graduate Selected
                dblTuition = intGraduatePrice
            Case 2                      'Case for Thesis and Dissertation selected
                dblTuition = intThesisPrice
        End Select

        If Not dblTuition.Equals(0.0) Then      'Checks that a course level is selected based on the Case Select code above
            If Not intHours.Equals(0) Then      'Checks that an amount of credit hours has been specified
                lblDisplay.Text = "Tuition is " & (intHours * dblTuition).ToString("$##0.00")
            Else
                MessageBox.Show("Please selected an amount of credit hours")
            End If
        Else
            MessageBox.Show("Please select a course level")
        End If
    End Sub

    'Exectues when the selected value is changed in the Credit Hours combo-box
    Private Sub cboHours_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHours.SelectedIndexChanged
        Try                 'Try catch to prevent exceptions(errors)
            intHours = cboHours.Text
        Catch ex As Exception
            intHours = 0        'Set to 0 for boolean check
        End Try
    End Sub

    'Exectued when the program first loads
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboHours.Text = 0       'Sets the number shown in the Credit Hours box to be 0 for show. (not required, just for looks)
    End Sub
End Class
