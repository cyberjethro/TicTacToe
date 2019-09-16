<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtPlay1 = New System.Windows.Forms.TextBox()
        Me.txtPlay2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlay1
        '
        Me.txtPlay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlay1.Location = New System.Drawing.Point(9, 29)
        Me.txtPlay1.Name = "txtPlay1"
        Me.txtPlay1.Size = New System.Drawing.Size(153, 30)
        Me.txtPlay1.TabIndex = 1
        Me.txtPlay1.Text = "Player 1"
        Me.txtPlay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlay2
        '
        Me.txtPlay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlay2.Location = New System.Drawing.Point(201, 29)
        Me.txtPlay2.Name = "txtPlay2"
        Me.txtPlay2.Size = New System.Drawing.Size(152, 30)
        Me.txtPlay2.TabIndex = 2
        Me.txtPlay2.Text = "Player 2"
        Me.txtPlay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(119, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*Enter player names"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.PaleGreen
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStart.Location = New System.Drawing.Point(9, 65)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(344, 57)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(362, 134)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPlay2)
        Me.Controls.Add(Me.txtPlay1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlay1 As TextBox
    Friend WithEvents txtPlay2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
End Class
