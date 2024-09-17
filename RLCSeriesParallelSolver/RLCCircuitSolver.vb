'Alex Wheelock
'RCET 3371
'Fall 2024
'RLC Series Parallel Circuit Solver
'https://github.com/AlexWheelock/RLCSeriesParallelSolver.git

Option Strict On
Option Explicit On
Public Class RLCSeriesParallelCircuitSolver

    Dim outputList As New List(Of String)
    Sub OutputToFile()
        Try
            FileOpen(1, "..\..\Data.txt", OpenMode.Append)

            For Each line In outputList
                PrintLine(1, line)
            Next

        Catch ex As Exception
            MsgBox("File not found!!!")
        End Try
        FileClose(1)
    End Sub

    'Validates the input values as numbers so that there is no issues trying to solve for the circuit
    Sub ValidateInputs()
        Dim valid As Boolean = True
        Dim test As Double
        Dim message As String = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf)

        'Verify Vgen is a number
        Try
            test = CDbl(VgenTextBox.Text)
        Catch ex As Exception
            valid = False
            message += "Vgen must be a number"
        End Try

        'Verify Fgen is a number
        Try
            test = CDbl(FgenTextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "Fgen must be a number"
            Else
                message += ", Fgen must be a number"
            End If
        End Try

        'Verify R1 is a number
        Try
            test = CDbl(R1TextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "R1 must be a number"
            Else
                message += ", R1 must be a number"
            End If
        End Try

        'Verify R2 is a number
        Try
            test = CDbl(R2TextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "R2 must be a number"
            Else
                message += ", R2 must be a number"
            End If
        End Try

        'Verify R3 is a number
        Try
            test = CDbl(R3TextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "R3 must be a number"
            Else
                message += ", R3 must be a number"
            End If
        End Try

        'Verify C1 is a number
        Try
            test = CDbl(C1TextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "C1 must be a number"
            Else
                message += ", C1 must be a number"
            End If
        End Try

        'Verify C2 is a number
        Try
            test = CDbl(C2TextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "C2 must be a number"
            Else
                message += ", C2 must be a number"
            End If
        End Try

        'Verify L1 is a number
        Try
            test = CDbl(L1TextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "L1 must be a number"
            Else
                message += ", L1 must be a number"
            End If
        End Try

        'Verify Rw is a number
        Try
            test = CDbl(RwTextBox.Text)
        Catch ex As Exception
            valid = False
            If message = ("The following fields are invalid:" & vbCrLf _
            & vbCrLf) Then
                message += "Rw must be a number"
            Else
                message += ", Rw must be a number"
            End If
        End Try

        'If valid = True, then all inputs are numbers and the circuit can be solved
        'If valid = false, it displays a message box to the user the fields that are invalid
        If valid Then
            SolveCircuitAndDisplay()
        Else
            MsgBox(message & ".")
        End If
    End Sub

    'Converts the x and y from rectangular form into the magnitude for polar form
    Function RectangularToPolarMagnitude(x As Double, y As Double) As Double
        Dim magnitude As Double

        magnitude = Math.Sqrt((x * x) + (y * y))

        Return magnitude
    End Function

    'Converts the x and y from rectangular form into the phase angle for polar form
    'Note: Atan gives the answer in radians, multiply by (180/pi) to convert to degrees
    Function RectangularToPolarAngle(x As Double, y As Double) As Double
        Dim angle As Double

        angle = Math.Atan(y / x) * (180 / Math.PI)

        Return angle
    End Function

    'Converts the polar magnitude and phase angle into the real component of resistance for rectangular form
    Function PolarToRectangularX(magnitude As Double, angle As Double) As Double
        Dim x As Double

        x = Math.Cos(angle) * magnitude

        Return x
    End Function

    'Converts the polar magnitude and phase angle into the imaginary component of resistance for rectangular form
    Function PolarToRectangularY(magnitude As Double, angle As Double) As Double
        Dim y As Double

        y = Math.Sin(angle) * magnitude

        Return y
    End Function

    'Solves for reactance of C1 & C2
    Function CapacitiveReactance(capacitance As Double) As Double
        Dim reactance As Double

        reactance = (1 / (Math.PI * 2 * capacitance * CDbl(FgenTextBox.Text)))

        Return reactance
    End Function

    'Solves for the reactance of L1
    Function InductiveReactance(inductance As Double) As Double
        Dim reactance As Double

        reactance = (Math.PI * 2 * CDbl(inductance) * CDbl(FgenTextBox.Text))

        Return reactance
    End Function

    'Calculates all values to solve the circuit within the variable declaration, then formats the data and displays it into DisplayListBox
    Sub SolveCircuitAndDisplay()
        Dim r1 As Double = CDbl(R1TextBox.Text)
        Dim r2 As Double = CDbl(R2TextBox.Text)
        Dim rW As Double = CDbl(RwTextBox.Text)
        Dim r3 As Double = CDbl(R3TextBox.Text)

        Dim l1 As Double = CDbl(L1TextBox.Text)
        Dim xL1 As Double = InductiveReactance(l1)
        Dim zL1 As Double = RectangularToPolarMagnitude(rW, xL1)
        Dim zL1Angle As Double = RectangularToPolarAngle(rW, xL1)

        Dim c1 As Double = CDbl(C1TextBox.Text)
        Dim c2 As Double = CDbl(C2TextBox.Text)
        Dim xC1 As Double = CapacitiveReactance(c1 * (10 ^ -6))             'Convert capacitance into uF by multiplying by 10^-6
        Dim xC2 As Double = CapacitiveReactance(c2 * (10 ^ -6))             'Convert capacitance into uF by multiplying by 10^-6

        Dim zB1 As Double = RectangularToPolarMagnitude(r2 + rW, xL1)
        Dim zB1Angle As Double = RectangularToPolarAngle(r2 + rW, xL1)
        Dim zB2 As Double = RectangularToPolarMagnitude(r3, -xC2)
        Dim zB2Angle As Double = RectangularToPolarAngle(r3, -xC2)

        Dim numerator As Double = zB1 * zB2
        Dim denominatorX As Double = r2 + rW + r3
        Dim denominatorY As Double = xL1 + (-xC2)
        Dim denominatorPolar As Double = RectangularToPolarMagnitude(denominatorX, denominatorY)
        Dim denominatorAngle As Double = RectangularToPolarAngle(denominatorX, denominatorY)

        Dim zParallelPolar As Double = numerator / denominatorPolar
        Dim zParallelAngle As Double = zB1Angle + zB2Angle - denominatorAngle
        Dim zParallelX As Double = PolarToRectangularX(zParallelPolar, zParallelAngle)
        Dim zParallelY As Double = PolarToRectangularY(zParallelPolar, zParallelAngle)
        Dim zTX As Double = zParallelX + r1
        Dim zTY As Double = zParallelY + (-xC1)
        Dim zTPolar As Double = RectangularToPolarMagnitude(zTX, zTY)
        Dim zTAngle As Double = RectangularToPolarAngle(zTX, zTY)

        Dim iT As Double = ((CDbl(VgenTextBox.Text) / zTPolar) * 10 ^ 3)    'Convert to mA so that the current is more readable by multiplying by 10^3
        Dim iTAngle As Double = 0 - zTAngle

        Dim vParallel As Double = (iT * zParallelPolar) / (10 ^ 3)          'Convert iT back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vParallelAngle As Double = iTAngle + zParallelAngle

        Dim iB1 As Double = (vParallel / zB1) * (10 ^ 3)                    'Convert current back into mA so that it is more readable by multiplying by 10^3
        Dim iB1Angle As Double = vParallelAngle - zB1Angle
        Dim iB2 As Double = (vParallel / zB2) * (10 ^ 3)                    'Convert current back into mA so that it is more readable by multiplying by 10^3
        Dim iB2Angle As Double = vParallelAngle - zB2Angle

        Dim vR1 As Double = (iT * r1) / (10 ^ 3)                            'Convert current back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vR1Angle As Double = iTAngle
        Dim vC1 As Double = (iT * xC1) / (10 ^ 3)                           'Convert current back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vC1Angle As Double = -90 + iTAngle
        Dim vR2 As Double = (iB1 * r2) / (10 ^ 3)                           'Convert current back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vR2Angle As Double = iB1Angle
        Dim vL1 As Double = (iB1 * zL1) / (10 ^ 3)                          'Convert current back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vL1Angle As Double = zL1Angle + iB1Angle
        Dim vR3 As Double = (iB2 * r3) / (10 ^ 3)                           'Convert current back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vR3Angle As Double = iB2Angle
        Dim vC2 As Double = (iB2 * xC2) / (10 ^ 3)                          'Convert current back to A so that the voltage calculation is correct by dividing by 10^3
        Dim vC2Angle As Double = -90 + iB2Angle

        Dim pR1 As Double = (0.707 * vR1) * (0.707 * iT)
        Dim pR2 As Double = (0.707 * vR2) * (0.707 * iB1)
        Dim pR3 As Double = (0.707 * vR3) * (0.707 * iB2)
        Dim pC1 As Double = (0.707 * vC1) * (0.707 * iT)
        Dim pC2 As Double = (0.707 * vC2) * (0.707 * iB2)
        Dim pL1 As Double = (0.707 * vL1) * (0.707 * iB1)

        outputList.Clear()

        Dim temp As String

        'This point to line 363 used to put the output together into outputList in proper formatting

        'Vgen & Fgen
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("Vgen = " & VgenTextBox.Text & "Vp")
        outputList.Add(temp)
        temp = ("Fgen = " & FgenTextBox.Text & "Hz")
        outputList.Add(temp)

        'Vout, Ztotal, Zparallel, Itotal, IB1, IB2
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("Vout = " & Math.Round(vParallel, 3) & "Vp, <" & Math.Round(vParallelAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("Ztotal = " & Math.Round(zTPolar, 3) & "Ω, <" & Math.Round(zTAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("Zparallel = " & Math.Round(zParallelPolar, 3) & "Ω, <" & Math.Round(zParallelAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("Itotal = " & Math.Round(iT, 3) & "mAp, <" & Math.Round(iTAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("IB1 = " & Math.Round(iB1, 3) & "mAp, <" & Math.Round(iB1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IB2 = " & Math.Round(iB2, 3) & "mAp, <" & Math.Round(iB2Angle, 3) & "°")
        outputList.Add(temp)

        'R1
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("R1  = " & Math.Round(r1, 3) & "Ω")
        outputList.Add(temp)
        temp = ("VR1 = " & Math.Round(vR1, 3) & "Vp, <" & Math.Round(vR1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IR1 = " & Math.Round(iT, 3) & "mAp <" & Math.Round(iTAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("PR1 = " & Math.Round(pR1, 3) & "mW")
        outputList.Add(temp)

        'R2
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("R2  = " & Math.Round(r2, 3) & "Ω")
        outputList.Add(temp)
        temp = ("VR2 = " & Math.Round(vR2, 3) & "Vp, <" & Math.Round(vR2Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IR2 = " & Math.Round(iB1, 3) & "mAp <" & Math.Round(iB1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("PR2 = " & Math.Round(pR2, 3) & "mW")
        outputList.Add(temp)

        'R3
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("R3  = " & Math.Round(r3, 3) & "Ω")
        outputList.Add(temp)
        temp = ("VR3 = " & Math.Round(vR3, 3) & "Vp, <" & Math.Round(vR3Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IR3 = " & Math.Round(iB2, 3) & "mAp <" & Math.Round(iB2Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("PR3 = " & Math.Round(pR3, 3) & "mW")
        outputList.Add(temp)

        'C1
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("C1  = " & c1 & "uF")
        outputList.Add(temp)
        temp = ("XC1 = " & Math.Round(xC1, 3) & "Ω, <-90°")
        outputList.Add(temp)
        temp = ("VC1 = " & Math.Round(vC1, 3) & "Vp, <" & Math.Round(vC1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IC1 = " & Math.Round(iT, 3) & "mAp <" & Math.Round(iTAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("PC1 = " & Math.Round(pC1, 3) & "mW")
        outputList.Add(temp)

        'C2
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("C2  = " & c2 & "uF")
        outputList.Add(temp)
        temp = ("XC2 = " & Math.Round(xC2, 3) & "Ω, <-90°")
        outputList.Add(temp)
        temp = ("VC2 = " & Math.Round(vC2, 3) & "Vp, <" & Math.Round(vC2Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IC2 = " & Math.Round(iB2, 3) & "mAp <" & Math.Round(iB2Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("PC2 = " & Math.Round(pC2, 3) & "mW")
        outputList.Add(temp)

        'L1
        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("L1  = " & l1 & "H")
        outputList.Add(temp)
        temp = ("Rw  = " & rW & "Ω")
        outputList.Add(temp)
        temp = ("XL1 = " & Math.Round(xL1, 3) & "Ω, <90°")
        outputList.Add(temp)
        temp = ("ZL1 = " & Math.Round(zL1, 3) & "Ω, <" & Math.Round(zL1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("VL1 = " & Math.Round(vL1, 3) & "Vp, <" & Math.Round(vL1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IL1 = " & Math.Round(iB1, 3) & "mAp <" & Math.Round(iB1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("PL1 = " & Math.Round(pL1, 3) & "mW")
        outputList.Add(temp)

        'Display the calculations into DisplayListBox
        For Each output In outputList
            DisplayListBox.Items.Add(output)
        Next
        OutputToFile()
    End Sub

    '================================================================================================================
    'Event handlers below this point 
    '================================================================================================================

    'Solves the circuit with the default values first thing
    Private Sub RLCCircuitSolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidateInputs()
        Try
            FileOpen(1, "..\..\Data.txt", OpenMode.Append)
        Catch ex As Exception
            FileOpen(1, "..\..\Data.txt", OpenMode.Output)
        End Try
        FileClose(1)
    End Sub

    'Tries to solve the circuit with new values, validates inputs first
    Private Sub SolveButton_Click(sender As Object, e As EventArgs) Handles SolveButton.Click
        DisplayListBox.Items.Clear()
        ValidateInputs()
    End Sub

    'Closes the form
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Close()
    End Sub

    'Clears the input text boxes & DisplayListBox
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
        VgenTextBox.Text = ""
        FgenTextBox.Text = ""
        R1TextBox.Text = ""
        R2TextBox.Text = ""
        R3TextBox.Text = ""
        C1TextBox.Text = ""
        C2TextBox.Text = ""
        L1TextBox.Text = ""
        RwTextBox.Text = ""
    End Sub
End Class
