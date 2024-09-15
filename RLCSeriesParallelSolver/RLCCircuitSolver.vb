'Alex Wheelock
'RCET 3371
'Fall 2024
'RLC Series Parallel Circuit Solver
'

Option Strict On
Option Explicit On

'TODO
'[ ] Take Inputs
'[ ] Create a sub that converts to rectangular from polar and vice versa
'[ ]
'[ ]
'[ ]
'[ ]
Public Class RLCSeriesParallelCircuitSolver

    Function RectangularToPolarMagnitude(x As Double, y As Double) As Double
        Dim magnitude As Double

        magnitude = Math.Sqrt((x * x) + (y * y))

        Return magnitude
    End Function

    Function RectangularToPolarAngle(x As Double, y As Double) As Double
        Dim angle As Double

        angle = Math.Atan(y / x) * (180 / Math.PI)

        Return angle
    End Function

    Function PolarToRectangularX(magnitude As Double, angle As Double) As Double
        Dim x As Double

        x = Math.Cos(angle) * magnitude

        Return x
    End Function

    Function PolarToRectangularY(magnitude As Double, angle As Double) As Double
        Dim y As Double

        y = Math.Sin(angle) * magnitude

        Return y
    End Function

    Function CapacitiveReactance(capacitance As Double) As Double
        Dim reactance As Double

        reactance = (1 / (Math.PI * 2 * capacitance * CDbl(FgenTextBox.Text)))

        Return reactance
    End Function

    Function InductiveReactance(inductance As Double) As Double
        Dim reactance As Double

        reactance = (Math.PI * 2 * CDbl(inductance) * CDbl(FgenTextBox.Text))

        Return reactance
    End Function

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
        Dim xC1 As Double = CapacitiveReactance(c1 * (10 ^ -6))
        Dim xC2 As Double = CapacitiveReactance(c2 * (10 ^ -6))

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

        Dim iT As Double = ((CDbl(VgenTextBox.Text) / zTPolar) * 10 ^ 3)
        Dim iTAngle As Double = 0 - zTAngle

        Dim vParallel As Double = (iT * zParallelPolar) / (10 ^ 3)
        Dim vParallelAngle As Double = iTAngle + zParallelAngle

        Dim iB1 As Double = (vParallel / zB1) * (10 ^ 3)
        Dim iB1Angle As Double = vParallelAngle - zB1Angle
        Dim iB2 As Double = (vParallel / zB2) * (10 ^ 3)
        Dim iB2Angle As Double = vParallelAngle - zB2Angle

        Dim vR1 As Double = (iT * r1) / (10 ^ 3)
        Dim vR1Angle As Double = iTAngle
        Dim vC1 As Double = (iT * xC1) / (10 ^ 3)
        Dim vC1Angle As Double = -90 + iTAngle
        Dim vR2 As Double = (iB1 * r2) / (10 ^ 3)
        Dim vR2Angle As Double = iB1Angle
        Dim vL1 As Double = (iB1 * zL1) / (10 ^ 3)
        Dim vL1Angle As Double = zL1Angle + iB1Angle
        Dim vR3 As Double = (iB2 * r3) / (10 ^ 3)
        Dim vR3Angle As Double = iB2Angle
        Dim vC2 As Double = (iB2 * xC2) / (10 ^ 3)
        Dim vC2Angle As Double = -90 + iB2Angle

        Dim pR1 As Double = (0.707 * vR1) * (0.707 * iT)
        Dim pR2 As Double = (0.707 * vR2) * (0.707 * iB1)
        Dim pR3 As Double = (0.707 * vR3) * (0.707 * iB2)
        Dim pC1 As Double = (0.707 * vC1) * (0.707 * iT)
        Dim pC2 As Double = (0.707 * vC2) * (0.707 * iB2)
        Dim pL1 As Double = (0.707 * vL1) * (0.707 * iB1)

        Dim outputList As New List(Of String)
        outputList.Clear()

        Dim temp As String

        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("Vgen = " & VgenTextBox.Text & "Vp")
        outputList.Add(temp)
        temp = ("Fgen = " & FgenTextBox.Text & "Hz")
        outputList.Add(temp)

        temp = (StrDup(100, "-"))
        outputList.Add(temp)
        temp = ("Vout = " & Math.Round(vParallel, 3) & "Vp, <" & Math.Round(vParallelAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("ZTotal = " & Math.Round(zTPolar, 3) & "Ω, <" & Math.Round(zTAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("Zparallel = " & Math.Round(zParallelPolar, 3) & "Ω, <" & Math.Round(zParallelAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("ITotal = " & Math.Round(iT, 3) & "mAp, <" & Math.Round(iTAngle, 3) & "°")
        outputList.Add(temp)
        temp = ("IB1 = " & Math.Round(iB1, 3) & "mAp, <" & Math.Round(iB1Angle, 3) & "°")
        outputList.Add(temp)
        temp = ("IB2 = " & Math.Round(iB2, 3) & "mAp, <" & Math.Round(iB2Angle, 3) & "°")
        outputList.Add(temp)

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

        For Each output In outputList
            DisplayListBox.Items.Add(output)
        Next

    End Sub

    Private Sub RLCCircuitSolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SolveCircuitAndDisplay()
    End Sub

    Private Sub SolveButton_Click(sender As Object, e As EventArgs) Handles SolveButton.Click
        SolveCircuitAndDisplay()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Close()
    End Sub
End Class
