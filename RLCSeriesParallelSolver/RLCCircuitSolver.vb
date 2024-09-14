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

        angle = Math.Atan(y / x)

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

        Dim iT As Double = CDbl(VgenTextBox.Text) / zTPolar
        Dim iTAngle As Double = 0 - zTAngle

        Dim vParallel As Double = iT * zParallelPolar
        Dim vParallelAngle As Double = iTAngle + zParallelAngle

        Dim iB1 As Double = vParallel / zB1
        Dim iB1Angle As Double = vParallelAngle - zB1Angle
        Dim iB2 As Double = vParallel / zB2
        Dim iB2Angle As Double = vParallelAngle - zB2Angle

        Dim vR1 As Double = iT * r1
        Dim vR1Angle As Double = iTAngle
        Dim vC1 As Double = iT * xC1
        Dim vC1Angle As Double = -90 + iTAngle
        Dim vR2 As Double = iB1 * r2
        Dim vR2Angle As Double = iB1Angle
        Dim vL1 As Double = iB1 * zL1
        Dim vL1Angle As Double = zL1Angle + iB1Angle
        Dim vR3 As Double = iB2 * r3
        Dim vR3Angle As Double = iB2Angle
        Dim vC2 As Double = iB2 * xC2
        Dim vC2Angle As Double = -90 + iB2Angle

        Dim pR1 As Double = ((0.707 * vR1) * (0.707 * iT))
        Dim pR2 As Double = ((0.707 * vR2) * (0.707 * iB1))
        Dim pR3 As Double = ((0.707 * vR3) * (0.707 * iB2))
        Dim pC1 As Double = ((0.707 * vC1) * (0.707 * iT))
        Dim pC2 As Double = ((0.707 * vC2) * (0.707 * iB2))
        Dim pL1 As Double = ((0.707 * vL1) * (0.707 * iB1))

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
