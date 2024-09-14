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

    Sub SolveCircuit()
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

        Dim zT As Double
        Dim zTAngle As Double
        Dim zS As Double
        Dim zSAngle As Double
        Dim zB1 As Double
        Dim zB1Angle As Double
        Dim zB2 As Double
        Dim zB2Angle As Double
        Dim zParallel As Double
        Dim zParallelAngle As Double

        Dim iT As Double
        Dim iTAngle As Double
        Dim iB1 As Double
        Dim iB1Angle As Double
        Dim iB2 As Double
        Dim iB2Angle As Double

        Dim vR1 As Double
        Dim vR1Angle As Double
        Dim vC1 As Double
        Dim vC1Angle As Double
        Dim vR2 As Double
        Dim vR2Angle As Double
        Dim vL1 As Double
        Dim vL1Angle As Double
        Dim vR3 As Double
        Dim vR3Angle As Double
        Dim vC2 As Double
        Dim vC2Angle As Double

        Dim pR1 As Double
        Dim pR2 As Double
        Dim pR3 As Double
        Dim pC1 As Double
        Dim pC2 As Double
        Dim pL1 As Double



    End Sub

    Sub DisplayResults()

    End Sub

    Private Sub RLCCircuitSolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SolveCircuit()
    End Sub

    Private Sub SolveButton_Click(sender As Object, e As EventArgs) Handles SolveButton.Click
        SolveCircuit()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Close()
    End Sub
End Class
