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
        Me.lblCard = New System.Windows.Forms.Label()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnHigher = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnSame = New System.Windows.Forms.Button()
        Me.tbCall = New System.Windows.Forms.TextBox()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.Location = New System.Drawing.Point(385, 116)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(0, 29)
        Me.lblCard.TabIndex = 0
        '
        'btnLower
        '
        Me.btnLower.Location = New System.Drawing.Point(140, 259)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(75, 61)
        Me.btnLower.TabIndex = 2
        Me.btnLower.Text = "Lower"
        Me.btnLower.UseVisualStyleBackColor = True
        '
        'btnHigher
        '
        Me.btnHigher.Location = New System.Drawing.Point(140, 171)
        Me.btnHigher.Name = "btnHigher"
        Me.btnHigher.Size = New System.Drawing.Size(75, 61)
        Me.btnHigher.TabIndex = 3
        Me.btnHigher.Text = "Higher"
        Me.btnHigher.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(317, 269)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 32)
        Me.lblResult.TabIndex = 4
        '
        'btnSame
        '
        Me.btnSame.BackColor = System.Drawing.Color.Yellow
        Me.btnSame.Font = New System.Drawing.Font("Copperplate Gothic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSame.ForeColor = System.Drawing.Color.Red
        Me.btnSame.Location = New System.Drawing.Point(12, 326)
        Me.btnSame.Name = "btnSame"
        Me.btnSame.Size = New System.Drawing.Size(383, 115)
        Me.btnSame.TabIndex = 5
        Me.btnSame.Text = "SAME (Do You Dare?)"
        Me.btnSame.UseVisualStyleBackColor = False
        '
        'tbCall
        '
        Me.tbCall.Location = New System.Drawing.Point(130, 56)
        Me.tbCall.Name = "tbCall"
        Me.tbCall.Size = New System.Drawing.Size(100, 22)
        Me.tbCall.TabIndex = 6
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(140, 84)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(75, 61)
        Me.btnCall.TabIndex = 7
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Call a number (10 is Jack, 11 is Queen, 13 is King)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.tbCall)
        Me.Controls.Add(Me.btnSame)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnHigher)
        Me.Controls.Add(Me.btnLower)
        Me.Controls.Add(Me.lblCard)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCard As Label
    Friend WithEvents btnLower As Button
    Friend WithEvents btnHigher As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnSame As Button
    Friend WithEvents tbCall As TextBox
    Friend WithEvents btnCall As Button
    Friend WithEvents Label1 As Label
End Class
