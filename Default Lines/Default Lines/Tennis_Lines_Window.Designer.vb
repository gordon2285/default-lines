<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tennis_Lines_Window
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
        Me.lblPlayer1Percentage = New System.Windows.Forms.Label()
        Me.lblPlayer2Percentage = New System.Windows.Forms.Label()
        Me.P1PercentageBox = New System.Windows.Forms.TextBox()
        Me.P2PercentageBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPlayer1Percentage
        '
        Me.lblPlayer1Percentage.AutoSize = True
        Me.lblPlayer1Percentage.Location = New System.Drawing.Point(27, 46)
        Me.lblPlayer1Percentage.Name = "lblPlayer1Percentage"
        Me.lblPlayer1Percentage.Size = New System.Drawing.Size(56, 13)
        Me.lblPlayer1Percentage.TabIndex = 0
        Me.lblPlayer1Percentage.Text = "Player 1 %"
        '
        'lblPlayer2Percentage
        '
        Me.lblPlayer2Percentage.AutoSize = True
        Me.lblPlayer2Percentage.Location = New System.Drawing.Point(27, 106)
        Me.lblPlayer2Percentage.Name = "lblPlayer2Percentage"
        Me.lblPlayer2Percentage.Size = New System.Drawing.Size(56, 13)
        Me.lblPlayer2Percentage.TabIndex = 1
        Me.lblPlayer2Percentage.Text = "Player 2 %"
        '
        'P1PercentageBox
        '
        Me.P1PercentageBox.Location = New System.Drawing.Point(110, 43)
        Me.P1PercentageBox.Name = "P1PercentageBox"
        Me.P1PercentageBox.Size = New System.Drawing.Size(100, 20)
        Me.P1PercentageBox.TabIndex = 2
        '
        'P2PercentageBox
        '
        Me.P2PercentageBox.Location = New System.Drawing.Point(110, 103)
        Me.P2PercentageBox.Name = "P2PercentageBox"
        Me.P2PercentageBox.Size = New System.Drawing.Size(100, 20)
        Me.P2PercentageBox.TabIndex = 3
        '
        'Tennis_Lines_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 147)
        Me.Controls.Add(Me.P2PercentageBox)
        Me.Controls.Add(Me.P1PercentageBox)
        Me.Controls.Add(Me.lblPlayer2Percentage)
        Me.Controls.Add(Me.lblPlayer1Percentage)
        Me.Name = "Tennis_Lines_Window"
        Me.Text = "Tennis_Lines_Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayer1Percentage As Label
    Friend WithEvents lblPlayer2Percentage As Label
    Friend WithEvents P1PercentageBox As TextBox
    Friend WithEvents P2PercentageBox As TextBox
End Class
