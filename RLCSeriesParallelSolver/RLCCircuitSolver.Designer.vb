<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RLCSeriesParallelCircuitSolver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SchematicPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.VgenLabel = New System.Windows.Forms.Label()
        Me.VgenTextBox = New System.Windows.Forms.TextBox()
        Me.FgenTextBox = New System.Windows.Forms.TextBox()
        Me.FgenLabel = New System.Windows.Forms.Label()
        Me.R1TextBox = New System.Windows.Forms.TextBox()
        Me.R1Label = New System.Windows.Forms.Label()
        Me.R2TextBox = New System.Windows.Forms.TextBox()
        Me.R2Label = New System.Windows.Forms.Label()
        Me.R3TextBox = New System.Windows.Forms.TextBox()
        Me.R3Label = New System.Windows.Forms.Label()
        Me.C1TextBox = New System.Windows.Forms.TextBox()
        Me.C1Label = New System.Windows.Forms.Label()
        Me.C2TextBox = New System.Windows.Forms.TextBox()
        Me.C2Label = New System.Windows.Forms.Label()
        Me.C3TextBox = New System.Windows.Forms.TextBox()
        Me.C3Label = New System.Windows.Forms.Label()
        Me.L1TextBox = New System.Windows.Forms.TextBox()
        Me.L1Label = New System.Windows.Forms.Label()
        Me.SolveButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.VpLabel = New System.Windows.Forms.Label()
        Me.HzLabel = New System.Windows.Forms.Label()
        Me.R1OmegaLabel = New System.Windows.Forms.Label()
        Me.R2OmegaLabel = New System.Windows.Forms.Label()
        Me.R3OmegaLabel = New System.Windows.Forms.Label()
        Me.C1FLabel = New System.Windows.Forms.Label()
        Me.C2FLabel = New System.Windows.Forms.Label()
        Me.C3FLabel = New System.Windows.Forms.Label()
        Me.L1HLabel = New System.Windows.Forms.Label()
        Me.RwOmegaLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RwLabel = New System.Windows.Forms.Label()
        CType(Me.SchematicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchematicPictureBox
        '
        Me.SchematicPictureBox.BackgroundImage = Global.RLCSeriesParallelSolver.My.Resources.Resources.Schematic1
        Me.SchematicPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.SchematicPictureBox.Name = "SchematicPictureBox"
        Me.SchematicPictureBox.Size = New System.Drawing.Size(566, 281)
        Me.SchematicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SchematicPictureBox.TabIndex = 0
        Me.SchematicPictureBox.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 16
        Me.DisplayListBox.Location = New System.Drawing.Point(12, 299)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(566, 388)
        Me.DisplayListBox.TabIndex = 20
        '
        'VgenLabel
        '
        Me.VgenLabel.AutoSize = True
        Me.VgenLabel.Location = New System.Drawing.Point(594, 15)
        Me.VgenLabel.Name = "VgenLabel"
        Me.VgenLabel.Size = New System.Drawing.Size(39, 16)
        Me.VgenLabel.TabIndex = 2
        Me.VgenLabel.Text = "Vgen"
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Location = New System.Drawing.Point(639, 12)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(126, 22)
        Me.VgenTextBox.TabIndex = 0
        '
        'FgenTextBox
        '
        Me.FgenTextBox.Location = New System.Drawing.Point(639, 40)
        Me.FgenTextBox.Name = "FgenTextBox"
        Me.FgenTextBox.Size = New System.Drawing.Size(126, 22)
        Me.FgenTextBox.TabIndex = 1
        '
        'FgenLabel
        '
        Me.FgenLabel.AutoSize = True
        Me.FgenLabel.Location = New System.Drawing.Point(594, 43)
        Me.FgenLabel.Name = "FgenLabel"
        Me.FgenLabel.Size = New System.Drawing.Size(38, 16)
        Me.FgenLabel.TabIndex = 4
        Me.FgenLabel.Text = "Fgen"
        '
        'R1TextBox
        '
        Me.R1TextBox.Location = New System.Drawing.Point(639, 78)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(126, 22)
        Me.R1TextBox.TabIndex = 2
        '
        'R1Label
        '
        Me.R1Label.AutoSize = True
        Me.R1Label.Location = New System.Drawing.Point(608, 81)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(24, 16)
        Me.R1Label.TabIndex = 6
        Me.R1Label.Text = "R1"
        '
        'R2TextBox
        '
        Me.R2TextBox.Location = New System.Drawing.Point(639, 106)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(126, 22)
        Me.R2TextBox.TabIndex = 3
        '
        'R2Label
        '
        Me.R2Label.AutoSize = True
        Me.R2Label.Location = New System.Drawing.Point(608, 109)
        Me.R2Label.Name = "R2Label"
        Me.R2Label.Size = New System.Drawing.Size(24, 16)
        Me.R2Label.TabIndex = 8
        Me.R2Label.Text = "R2"
        '
        'R3TextBox
        '
        Me.R3TextBox.Location = New System.Drawing.Point(639, 134)
        Me.R3TextBox.Name = "R3TextBox"
        Me.R3TextBox.Size = New System.Drawing.Size(126, 22)
        Me.R3TextBox.TabIndex = 4
        '
        'R3Label
        '
        Me.R3Label.AutoSize = True
        Me.R3Label.Location = New System.Drawing.Point(608, 137)
        Me.R3Label.Name = "R3Label"
        Me.R3Label.Size = New System.Drawing.Size(24, 16)
        Me.R3Label.TabIndex = 10
        Me.R3Label.Text = "R3"
        '
        'C1TextBox
        '
        Me.C1TextBox.Location = New System.Drawing.Point(639, 172)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(126, 22)
        Me.C1TextBox.TabIndex = 5
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.Location = New System.Drawing.Point(608, 175)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(23, 16)
        Me.C1Label.TabIndex = 12
        Me.C1Label.Text = "C1"
        '
        'C2TextBox
        '
        Me.C2TextBox.Location = New System.Drawing.Point(639, 200)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(126, 22)
        Me.C2TextBox.TabIndex = 6
        '
        'C2Label
        '
        Me.C2Label.AutoSize = True
        Me.C2Label.Location = New System.Drawing.Point(608, 203)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(23, 16)
        Me.C2Label.TabIndex = 14
        Me.C2Label.Text = "C2"
        '
        'C3TextBox
        '
        Me.C3TextBox.Location = New System.Drawing.Point(639, 228)
        Me.C3TextBox.Name = "C3TextBox"
        Me.C3TextBox.Size = New System.Drawing.Size(126, 22)
        Me.C3TextBox.TabIndex = 7
        '
        'C3Label
        '
        Me.C3Label.AutoSize = True
        Me.C3Label.Location = New System.Drawing.Point(608, 231)
        Me.C3Label.Name = "C3Label"
        Me.C3Label.Size = New System.Drawing.Size(23, 16)
        Me.C3Label.TabIndex = 16
        Me.C3Label.Text = "C3"
        '
        'L1TextBox
        '
        Me.L1TextBox.Location = New System.Drawing.Point(639, 266)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(126, 22)
        Me.L1TextBox.TabIndex = 8
        '
        'L1Label
        '
        Me.L1Label.AutoSize = True
        Me.L1Label.Location = New System.Drawing.Point(610, 269)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(21, 16)
        Me.L1Label.TabIndex = 18
        Me.L1Label.Text = "L1"
        '
        'SolveButton
        '
        Me.SolveButton.Location = New System.Drawing.Point(639, 359)
        Me.SolveButton.Name = "SolveButton"
        Me.SolveButton.Size = New System.Drawing.Size(126, 30)
        Me.SolveButton.TabIndex = 10
        Me.SolveButton.Text = "Solve"
        Me.SolveButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(639, 395)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(126, 30)
        Me.QuitButton.TabIndex = 11
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'VpLabel
        '
        Me.VpLabel.AutoSize = True
        Me.VpLabel.Location = New System.Drawing.Point(771, 15)
        Me.VpLabel.Name = "VpLabel"
        Me.VpLabel.Size = New System.Drawing.Size(24, 16)
        Me.VpLabel.TabIndex = 22
        Me.VpLabel.Text = "Vp"
        '
        'HzLabel
        '
        Me.HzLabel.AutoSize = True
        Me.HzLabel.Location = New System.Drawing.Point(771, 43)
        Me.HzLabel.Name = "HzLabel"
        Me.HzLabel.Size = New System.Drawing.Size(23, 16)
        Me.HzLabel.TabIndex = 23
        Me.HzLabel.Text = "Hz"
        '
        'R1OmegaLabel
        '
        Me.R1OmegaLabel.AutoSize = True
        Me.R1OmegaLabel.Location = New System.Drawing.Point(772, 81)
        Me.R1OmegaLabel.Name = "R1OmegaLabel"
        Me.R1OmegaLabel.Size = New System.Drawing.Size(17, 16)
        Me.R1OmegaLabel.TabIndex = 24
        Me.R1OmegaLabel.Text = "Ω"
        '
        'R2OmegaLabel
        '
        Me.R2OmegaLabel.AutoSize = True
        Me.R2OmegaLabel.Location = New System.Drawing.Point(771, 109)
        Me.R2OmegaLabel.Name = "R2OmegaLabel"
        Me.R2OmegaLabel.Size = New System.Drawing.Size(17, 16)
        Me.R2OmegaLabel.TabIndex = 25
        Me.R2OmegaLabel.Text = "Ω"
        '
        'R3OmegaLabel
        '
        Me.R3OmegaLabel.AutoSize = True
        Me.R3OmegaLabel.Location = New System.Drawing.Point(771, 137)
        Me.R3OmegaLabel.Name = "R3OmegaLabel"
        Me.R3OmegaLabel.Size = New System.Drawing.Size(17, 16)
        Me.R3OmegaLabel.TabIndex = 26
        Me.R3OmegaLabel.Text = "Ω"
        '
        'C1FLabel
        '
        Me.C1FLabel.AutoSize = True
        Me.C1FLabel.Location = New System.Drawing.Point(771, 175)
        Me.C1FLabel.Name = "C1FLabel"
        Me.C1FLabel.Size = New System.Drawing.Size(22, 16)
        Me.C1FLabel.TabIndex = 27
        Me.C1FLabel.Text = "uF"
        '
        'C2FLabel
        '
        Me.C2FLabel.AutoSize = True
        Me.C2FLabel.Location = New System.Drawing.Point(771, 203)
        Me.C2FLabel.Name = "C2FLabel"
        Me.C2FLabel.Size = New System.Drawing.Size(22, 16)
        Me.C2FLabel.TabIndex = 28
        Me.C2FLabel.Text = "uF"
        '
        'C3FLabel
        '
        Me.C3FLabel.AutoSize = True
        Me.C3FLabel.Location = New System.Drawing.Point(771, 231)
        Me.C3FLabel.Name = "C3FLabel"
        Me.C3FLabel.Size = New System.Drawing.Size(22, 16)
        Me.C3FLabel.TabIndex = 29
        Me.C3FLabel.Text = "uF"
        '
        'L1HLabel
        '
        Me.L1HLabel.AutoSize = True
        Me.L1HLabel.Location = New System.Drawing.Point(771, 269)
        Me.L1HLabel.Name = "L1HLabel"
        Me.L1HLabel.Size = New System.Drawing.Size(17, 16)
        Me.L1HLabel.TabIndex = 30
        Me.L1HLabel.Text = "H"
        '
        'RwOmegaLabel
        '
        Me.RwOmegaLabel.AutoSize = True
        Me.RwOmegaLabel.Location = New System.Drawing.Point(771, 297)
        Me.RwOmegaLabel.Name = "RwOmegaLabel"
        Me.RwOmegaLabel.Size = New System.Drawing.Size(17, 16)
        Me.RwOmegaLabel.TabIndex = 33
        Me.RwOmegaLabel.Text = "Ω"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(639, 294)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 22)
        Me.TextBox1.TabIndex = 9
        '
        'RwLabel
        '
        Me.RwLabel.AutoSize = True
        Me.RwLabel.Location = New System.Drawing.Point(608, 297)
        Me.RwLabel.Name = "RwLabel"
        Me.RwLabel.Size = New System.Drawing.Size(26, 16)
        Me.RwLabel.TabIndex = 32
        Me.RwLabel.Text = "Rw"
        '
        'RLCSeriesParallelCircuitSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 692)
        Me.Controls.Add(Me.RwOmegaLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RwLabel)
        Me.Controls.Add(Me.L1HLabel)
        Me.Controls.Add(Me.C3FLabel)
        Me.Controls.Add(Me.C2FLabel)
        Me.Controls.Add(Me.C1FLabel)
        Me.Controls.Add(Me.R3OmegaLabel)
        Me.Controls.Add(Me.R2OmegaLabel)
        Me.Controls.Add(Me.R1OmegaLabel)
        Me.Controls.Add(Me.HzLabel)
        Me.Controls.Add(Me.VpLabel)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.SolveButton)
        Me.Controls.Add(Me.L1TextBox)
        Me.Controls.Add(Me.L1Label)
        Me.Controls.Add(Me.C3TextBox)
        Me.Controls.Add(Me.C3Label)
        Me.Controls.Add(Me.C2TextBox)
        Me.Controls.Add(Me.C2Label)
        Me.Controls.Add(Me.C1TextBox)
        Me.Controls.Add(Me.C1Label)
        Me.Controls.Add(Me.R3TextBox)
        Me.Controls.Add(Me.R3Label)
        Me.Controls.Add(Me.R2TextBox)
        Me.Controls.Add(Me.R2Label)
        Me.Controls.Add(Me.R1TextBox)
        Me.Controls.Add(Me.R1Label)
        Me.Controls.Add(Me.FgenTextBox)
        Me.Controls.Add(Me.FgenLabel)
        Me.Controls.Add(Me.VgenTextBox)
        Me.Controls.Add(Me.VgenLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.SchematicPictureBox)
        Me.Name = "RLCSeriesParallelCircuitSolver"
        Me.Text = "RLC Series Parallel Circuit Solver"
        CType(Me.SchematicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchematicPictureBox As PictureBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents VgenLabel As Label
    Friend WithEvents VgenTextBox As TextBox
    Friend WithEvents FgenTextBox As TextBox
    Friend WithEvents FgenLabel As Label
    Friend WithEvents R1TextBox As TextBox
    Friend WithEvents R1Label As Label
    Friend WithEvents R2TextBox As TextBox
    Friend WithEvents R2Label As Label
    Friend WithEvents R3TextBox As TextBox
    Friend WithEvents R3Label As Label
    Friend WithEvents C1TextBox As TextBox
    Friend WithEvents C1Label As Label
    Friend WithEvents C2TextBox As TextBox
    Friend WithEvents C2Label As Label
    Friend WithEvents C3TextBox As TextBox
    Friend WithEvents C3Label As Label
    Friend WithEvents L1TextBox As TextBox
    Friend WithEvents L1Label As Label
    Friend WithEvents SolveButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents VpLabel As Label
    Friend WithEvents HzLabel As Label
    Friend WithEvents R1OmegaLabel As Label
    Friend WithEvents R2OmegaLabel As Label
    Friend WithEvents R3OmegaLabel As Label
    Friend WithEvents C1FLabel As Label
    Friend WithEvents C2FLabel As Label
    Friend WithEvents C3FLabel As Label
    Friend WithEvents L1HLabel As Label
    Friend WithEvents RwOmegaLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RwLabel As Label
End Class
