<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zodiac
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.zodiac_cb = New System.Windows.Forms.ComboBox()
        Me.lbl_sign = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(93, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 236)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'zodiac_cb
        '
        Me.zodiac_cb.FormattingEnabled = True
        Me.zodiac_cb.Items.AddRange(New Object() {"Aries", "Taurus", "Gemini", "Cancer,", "Leo", "Virgo,", "Libra,", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"})
        Me.zodiac_cb.Location = New System.Drawing.Point(93, 326)
        Me.zodiac_cb.Name = "zodiac_cb"
        Me.zodiac_cb.Size = New System.Drawing.Size(121, 24)
        Me.zodiac_cb.TabIndex = 2
        '
        'lbl_sign
        '
        Me.lbl_sign.AutoSize = True
        Me.lbl_sign.Location = New System.Drawing.Point(512, 50)
        Me.lbl_sign.Name = "lbl_sign"
        Me.lbl_sign.Size = New System.Drawing.Size(34, 16)
        Me.lbl_sign.TabIndex = 3
        Me.lbl_sign.Text = "Sign"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(515, 150)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(36, 16)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.Text = "Date"
        '
        'Zodiac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_sign)
        Me.Controls.Add(Me.zodiac_cb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Zodiac"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents zodiac_cb As ComboBox
    Friend WithEvents lbl_sign As Label
    Friend WithEvents lbl_date As Label
End Class
