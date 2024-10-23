<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTPNR = New System.Windows.Forms.TextBox()
        Me.TXTTICKETAMOUNT = New System.Windows.Forms.TextBox()
        Me.TXTREFUNDAMOUNT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdsubmit = New System.Windows.Forms.Button()
        Me.cmdrefund = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PNR Number     :"
        '
        'TXTPNR
        '
        Me.TXTPNR.Location = New System.Drawing.Point(522, 212)
        Me.TXTPNR.Name = "TXTPNR"
        Me.TXTPNR.Size = New System.Drawing.Size(129, 20)
        Me.TXTPNR.TabIndex = 1
        '
        'TXTTICKETAMOUNT
        '
        Me.TXTTICKETAMOUNT.Location = New System.Drawing.Point(522, 284)
        Me.TXTTICKETAMOUNT.Name = "TXTTICKETAMOUNT"
        Me.TXTTICKETAMOUNT.Size = New System.Drawing.Size(129, 20)
        Me.TXTTICKETAMOUNT.TabIndex = 2
        '
        'TXTREFUNDAMOUNT
        '
        Me.TXTREFUNDAMOUNT.Location = New System.Drawing.Point(522, 364)
        Me.TXTREFUNDAMOUNT.Name = "TXTREFUNDAMOUNT"
        Me.TXTREFUNDAMOUNT.Size = New System.Drawing.Size(129, 20)
        Me.TXTREFUNDAMOUNT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ticket Amount    :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Refund Amount   :"
        '
        'cmdsubmit
        '
        Me.cmdsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdsubmit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsubmit.Location = New System.Drawing.Point(721, 203)
        Me.cmdsubmit.Name = "cmdsubmit"
        Me.cmdsubmit.Size = New System.Drawing.Size(108, 44)
        Me.cmdsubmit.TabIndex = 6
        Me.cmdsubmit.Text = "Submit"
        Me.cmdsubmit.UseVisualStyleBackColor = False
        '
        'cmdrefund
        '
        Me.cmdrefund.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdrefund.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrefund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdrefund.Location = New System.Drawing.Point(375, 476)
        Me.cmdrefund.Name = "cmdrefund"
        Me.cmdrefund.Size = New System.Drawing.Size(123, 48)
        Me.cmdrefund.TabIndex = 7
        Me.cmdrefund.Text = "Refund"
        Me.cmdrefund.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdReturn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdReturn.Location = New System.Drawing.Point(605, 476)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(129, 48)
        Me.cmdReturn.TabIndex = 8
        Me.cmdReturn.Text = "Return"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1325, 87)
        Me.Panel1.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox1.Font = New System.Drawing.Font("Century Schoolbook", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(372, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(469, 48)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "   TICKET REFUND"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1333, 675)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.cmdrefund)
        Me.Controls.Add(Me.cmdsubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTREFUNDAMOUNT)
        Me.Controls.Add(Me.TXTTICKETAMOUNT)
        Me.Controls.Add(Me.TXTPNR)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTPNR As System.Windows.Forms.TextBox
    Friend WithEvents TXTTICKETAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TXTREFUNDAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdsubmit As System.Windows.Forms.Button
    Friend WithEvents cmdrefund As System.Windows.Forms.Button
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
