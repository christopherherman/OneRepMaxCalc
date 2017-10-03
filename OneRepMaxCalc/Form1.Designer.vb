<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.weightLifted = New System.Windows.Forms.TextBox()
        Me.repsCompleted = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.oneRepMax = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weight Lifted:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reps Completed:"
        '
        'weightLifted
        '
        Me.weightLifted.Location = New System.Drawing.Point(123, 20)
        Me.weightLifted.Name = "weightLifted"
        Me.weightLifted.Size = New System.Drawing.Size(100, 20)
        Me.weightLifted.TabIndex = 2
        '
        'repsCompleted
        '
        Me.repsCompleted.Location = New System.Drawing.Point(123, 45)
        Me.repsCompleted.Name = "repsCompleted"
        Me.repsCompleted.Size = New System.Drawing.Size(100, 20)
        Me.repsCompleted.TabIndex = 3
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(29, 71)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(194, 23)
        Me.calculate.TabIndex = 4
        Me.calculate.Text = "Calculate One Rep Max"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "One Rep Max:"
        '
        'oneRepMax
        '
        Me.oneRepMax.Location = New System.Drawing.Point(123, 101)
        Me.oneRepMax.Name = "oneRepMax"
        Me.oneRepMax.Size = New System.Drawing.Size(100, 20)
        Me.oneRepMax.TabIndex = 6
        '
        'Form1
        '
        Me.AcceptButton = Me.calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 148)
        Me.Controls.Add(Me.oneRepMax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.repsCompleted)
        Me.Controls.Add(Me.weightLifted)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculate Max"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents weightLifted As TextBox
    Friend WithEvents repsCompleted As TextBox
    Friend WithEvents calculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents oneRepMax As TextBox
End Class
