﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.L1HLabel = New System.Windows.Forms.Label()
        Me.RwOmegaLabel = New System.Windows.Forms.Label()
        Me.RwTextBox = New System.Windows.Forms.TextBox()
        Me.RwLabel = New System.Windows.Forms.Label()
        Me.SchematicPictureBox = New System.Windows.Forms.PictureBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.SchematicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 14
        Me.DisplayListBox.Location = New System.Drawing.Point(9, 162)
        Me.DisplayListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(298, 312)
        Me.DisplayListBox.TabIndex = 20
        '
        'VgenLabel
        '
        Me.VgenLabel.AutoSize = True
        Me.VgenLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VgenLabel.Location = New System.Drawing.Point(309, 19)
        Me.VgenLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VgenLabel.Name = "VgenLabel"
        Me.VgenLabel.Size = New System.Drawing.Size(35, 14)
        Me.VgenLabel.TabIndex = 2
        Me.VgenLabel.Text = "Vgen"
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VgenTextBox.Location = New System.Drawing.Point(348, 11)
        Me.VgenTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(96, 22)
        Me.VgenTextBox.TabIndex = 0
        Me.VgenTextBox.Text = "10"
        '
        'FgenTextBox
        '
        Me.FgenTextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FgenTextBox.Location = New System.Drawing.Point(347, 37)
        Me.FgenTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FgenTextBox.Name = "FgenTextBox"
        Me.FgenTextBox.Size = New System.Drawing.Size(96, 22)
        Me.FgenTextBox.TabIndex = 1
        Me.FgenTextBox.Text = "1000"
        '
        'FgenLabel
        '
        Me.FgenLabel.AutoSize = True
        Me.FgenLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FgenLabel.Location = New System.Drawing.Point(308, 45)
        Me.FgenLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FgenLabel.Name = "FgenLabel"
        Me.FgenLabel.Size = New System.Drawing.Size(35, 14)
        Me.FgenLabel.TabIndex = 4
        Me.FgenLabel.Text = "Fgen"
        '
        'R1TextBox
        '
        Me.R1TextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1TextBox.Location = New System.Drawing.Point(348, 73)
        Me.R1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(96, 22)
        Me.R1TextBox.TabIndex = 2
        Me.R1TextBox.Text = "4300"
        '
        'R1Label
        '
        Me.R1Label.AutoSize = True
        Me.R1Label.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1Label.Location = New System.Drawing.Point(323, 76)
        Me.R1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(21, 14)
        Me.R1Label.TabIndex = 6
        Me.R1Label.Text = "R1"
        '
        'R2TextBox
        '
        Me.R2TextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2TextBox.Location = New System.Drawing.Point(348, 99)
        Me.R2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(96, 22)
        Me.R2TextBox.TabIndex = 3
        Me.R2TextBox.Text = "10000"
        '
        'R2Label
        '
        Me.R2Label.AutoSize = True
        Me.R2Label.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2Label.Location = New System.Drawing.Point(323, 102)
        Me.R2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R2Label.Name = "R2Label"
        Me.R2Label.Size = New System.Drawing.Size(21, 14)
        Me.R2Label.TabIndex = 8
        Me.R2Label.Text = "R2"
        '
        'R3TextBox
        '
        Me.R3TextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3TextBox.Location = New System.Drawing.Point(348, 125)
        Me.R3TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R3TextBox.Name = "R3TextBox"
        Me.R3TextBox.Size = New System.Drawing.Size(96, 22)
        Me.R3TextBox.TabIndex = 4
        Me.R3TextBox.Text = "4700"
        '
        'R3Label
        '
        Me.R3Label.AutoSize = True
        Me.R3Label.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3Label.Location = New System.Drawing.Point(323, 128)
        Me.R3Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R3Label.Name = "R3Label"
        Me.R3Label.Size = New System.Drawing.Size(21, 14)
        Me.R3Label.TabIndex = 10
        Me.R3Label.Text = "R3"
        '
        'C1TextBox
        '
        Me.C1TextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox.Location = New System.Drawing.Point(348, 162)
        Me.C1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(96, 22)
        Me.C1TextBox.TabIndex = 5
        Me.C1TextBox.Text = "0.02"
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Label.Location = New System.Drawing.Point(323, 165)
        Me.C1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(21, 14)
        Me.C1Label.TabIndex = 12
        Me.C1Label.Text = "C1"
        '
        'C2TextBox
        '
        Me.C2TextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2TextBox.Location = New System.Drawing.Point(348, 188)
        Me.C2TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(96, 22)
        Me.C2TextBox.TabIndex = 6
        Me.C2TextBox.Text = "0.008"
        '
        'C2Label
        '
        Me.C2Label.AutoSize = True
        Me.C2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2Label.Location = New System.Drawing.Point(322, 191)
        Me.C2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(22, 15)
        Me.C2Label.TabIndex = 14
        Me.C2Label.Text = "C2"
        '
        'L1TextBox
        '
        Me.L1TextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1TextBox.Location = New System.Drawing.Point(348, 226)
        Me.L1TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(96, 22)
        Me.L1TextBox.TabIndex = 7
        Me.L1TextBox.Text = "3.5"
        '
        'L1Label
        '
        Me.L1Label.AutoSize = True
        Me.L1Label.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1Label.Location = New System.Drawing.Point(323, 229)
        Me.L1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(21, 14)
        Me.L1Label.TabIndex = 18
        Me.L1Label.Text = "L1"
        '
        'SolveButton
        '
        Me.SolveButton.BackColor = System.Drawing.Color.White
        Me.SolveButton.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolveButton.Location = New System.Drawing.Point(347, 293)
        Me.SolveButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SolveButton.Name = "SolveButton"
        Me.SolveButton.Size = New System.Drawing.Size(94, 24)
        Me.SolveButton.TabIndex = 9
        Me.SolveButton.Text = "Solve"
        Me.SolveButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.White
        Me.QuitButton.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(347, 369)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(94, 24)
        Me.QuitButton.TabIndex = 10
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'VpLabel
        '
        Me.VpLabel.AutoSize = True
        Me.VpLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VpLabel.Location = New System.Drawing.Point(448, 19)
        Me.VpLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VpLabel.Name = "VpLabel"
        Me.VpLabel.Size = New System.Drawing.Size(21, 14)
        Me.VpLabel.TabIndex = 22
        Me.VpLabel.Text = "Vp"
        '
        'HzLabel
        '
        Me.HzLabel.AutoSize = True
        Me.HzLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HzLabel.Location = New System.Drawing.Point(447, 45)
        Me.HzLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HzLabel.Name = "HzLabel"
        Me.HzLabel.Size = New System.Drawing.Size(21, 14)
        Me.HzLabel.TabIndex = 23
        Me.HzLabel.Text = "Hz"
        '
        'R1OmegaLabel
        '
        Me.R1OmegaLabel.AutoSize = True
        Me.R1OmegaLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1OmegaLabel.Location = New System.Drawing.Point(448, 81)
        Me.R1OmegaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R1OmegaLabel.Name = "R1OmegaLabel"
        Me.R1OmegaLabel.Size = New System.Drawing.Size(14, 14)
        Me.R1OmegaLabel.TabIndex = 24
        Me.R1OmegaLabel.Text = "Ω"
        '
        'R2OmegaLabel
        '
        Me.R2OmegaLabel.AutoSize = True
        Me.R2OmegaLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2OmegaLabel.Location = New System.Drawing.Point(447, 107)
        Me.R2OmegaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R2OmegaLabel.Name = "R2OmegaLabel"
        Me.R2OmegaLabel.Size = New System.Drawing.Size(14, 14)
        Me.R2OmegaLabel.TabIndex = 25
        Me.R2OmegaLabel.Text = "Ω"
        '
        'R3OmegaLabel
        '
        Me.R3OmegaLabel.AutoSize = True
        Me.R3OmegaLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3OmegaLabel.Location = New System.Drawing.Point(447, 133)
        Me.R3OmegaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.R3OmegaLabel.Name = "R3OmegaLabel"
        Me.R3OmegaLabel.Size = New System.Drawing.Size(14, 14)
        Me.R3OmegaLabel.TabIndex = 26
        Me.R3OmegaLabel.Text = "Ω"
        '
        'C1FLabel
        '
        Me.C1FLabel.AutoSize = True
        Me.C1FLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1FLabel.Location = New System.Drawing.Point(447, 170)
        Me.C1FLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C1FLabel.Name = "C1FLabel"
        Me.C1FLabel.Size = New System.Drawing.Size(21, 14)
        Me.C1FLabel.TabIndex = 27
        Me.C1FLabel.Text = "uF"
        '
        'C2FLabel
        '
        Me.C2FLabel.AutoSize = True
        Me.C2FLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2FLabel.Location = New System.Drawing.Point(447, 196)
        Me.C2FLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.C2FLabel.Name = "C2FLabel"
        Me.C2FLabel.Size = New System.Drawing.Size(21, 14)
        Me.C2FLabel.TabIndex = 28
        Me.C2FLabel.Text = "uF"
        '
        'L1HLabel
        '
        Me.L1HLabel.AutoSize = True
        Me.L1HLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1HLabel.Location = New System.Drawing.Point(447, 234)
        Me.L1HLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L1HLabel.Name = "L1HLabel"
        Me.L1HLabel.Size = New System.Drawing.Size(14, 14)
        Me.L1HLabel.TabIndex = 30
        Me.L1HLabel.Text = "H"
        '
        'RwOmegaLabel
        '
        Me.RwOmegaLabel.AutoSize = True
        Me.RwOmegaLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RwOmegaLabel.Location = New System.Drawing.Point(447, 260)
        Me.RwOmegaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RwOmegaLabel.Name = "RwOmegaLabel"
        Me.RwOmegaLabel.Size = New System.Drawing.Size(14, 14)
        Me.RwOmegaLabel.TabIndex = 33
        Me.RwOmegaLabel.Text = "Ω"
        '
        'RwTextBox
        '
        Me.RwTextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RwTextBox.Location = New System.Drawing.Point(348, 252)
        Me.RwTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RwTextBox.Name = "RwTextBox"
        Me.RwTextBox.Size = New System.Drawing.Size(96, 22)
        Me.RwTextBox.TabIndex = 8
        Me.RwTextBox.Text = "0"
        '
        'RwLabel
        '
        Me.RwLabel.AutoSize = True
        Me.RwLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RwLabel.Location = New System.Drawing.Point(323, 255)
        Me.RwLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RwLabel.Name = "RwLabel"
        Me.RwLabel.Size = New System.Drawing.Size(21, 14)
        Me.RwLabel.TabIndex = 32
        Me.RwLabel.Text = "Rw"
        '
        'SchematicPictureBox
        '
        Me.SchematicPictureBox.BackgroundImage = Global.RLCSeriesParallelSolver.My.Resources.Resources.Schematic2
        Me.SchematicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SchematicPictureBox.Location = New System.Drawing.Point(9, 10)
        Me.SchematicPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SchematicPictureBox.Name = "SchematicPictureBox"
        Me.SchematicPictureBox.Size = New System.Drawing.Size(298, 145)
        Me.SchematicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SchematicPictureBox.TabIndex = 0
        Me.SchematicPictureBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.White
        Me.ClearButton.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(347, 321)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(94, 24)
        Me.ClearButton.TabIndex = 34
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'RLCSeriesParallelCircuitSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 488)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RwOmegaLabel)
        Me.Controls.Add(Me.RwTextBox)
        Me.Controls.Add(Me.RwLabel)
        Me.Controls.Add(Me.L1HLabel)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RLCSeriesParallelCircuitSolver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents L1HLabel As Label
    Friend WithEvents RwOmegaLabel As Label
    Friend WithEvents RwTextBox As TextBox
    Friend WithEvents RwLabel As Label
    Friend WithEvents ClearButton As Button
End Class
