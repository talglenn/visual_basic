<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompsalary
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
        Me.picCompimg = New System.Windows.Forms.PictureBox()
        Me.cboOccupation = New System.Windows.Forms.ComboBox()
        Me.lblHourlywage = New System.Windows.Forms.Label()
        Me.lblAnnualwage = New System.Windows.Forms.Label()
        Me.lblHourlyRaise = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHourlyval = New System.Windows.Forms.Label()
        Me.lblAnnualval = New System.Windows.Forms.Label()
        Me.lblHourlyRaiseval = New System.Windows.Forms.Label()
        Me.lblAnnualRaise = New System.Windows.Forms.Label()
        Me.lblAnnualRaiseval = New System.Windows.Forms.Label()
        CType(Me.picCompimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCompimg
        '
        Me.picCompimg.BackgroundImage = Global.prog2_ap.My.Resources.Resources.compimg
        Me.picCompimg.Location = New System.Drawing.Point(0, -2)
        Me.picCompimg.Name = "picCompimg"
        Me.picCompimg.Size = New System.Drawing.Size(563, 99)
        Me.picCompimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCompimg.TabIndex = 0
        Me.picCompimg.TabStop = False
        '
        'cboOccupation
        '
        Me.cboOccupation.BackColor = System.Drawing.SystemColors.Menu
        Me.cboOccupation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOccupation.FormattingEnabled = True
        Me.cboOccupation.Items.AddRange(New Object() {"Computer Developer", "Computer System Analyst", "Computer and Information System Manager", "Computer Software Engineer"})
        Me.cboOccupation.Location = New System.Drawing.Point(128, 112)
        Me.cboOccupation.Name = "cboOccupation"
        Me.cboOccupation.Size = New System.Drawing.Size(302, 27)
        Me.cboOccupation.TabIndex = 1
        Me.cboOccupation.Text = "Select an Occupation"
        '
        'lblHourlywage
        '
        Me.lblHourlywage.AutoSize = True
        Me.lblHourlywage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlywage.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblHourlywage.Location = New System.Drawing.Point(26, 181)
        Me.lblHourlywage.Name = "lblHourlywage"
        Me.lblHourlywage.Size = New System.Drawing.Size(183, 19)
        Me.lblHourlywage.TabIndex = 2
        Me.lblHourlywage.Text = "U.S. Hourly mean wage:"
        '
        'lblAnnualwage
        '
        Me.lblAnnualwage.AutoSize = True
        Me.lblAnnualwage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualwage.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblAnnualwage.Location = New System.Drawing.Point(26, 246)
        Me.lblAnnualwage.Name = "lblAnnualwage"
        Me.lblAnnualwage.Size = New System.Drawing.Size(151, 19)
        Me.lblAnnualwage.TabIndex = 3
        Me.lblAnnualwage.Text = "Annual mean wage:"
        '
        'lblHourlyRaise
        '
        Me.lblHourlyRaise.AutoSize = True
        Me.lblHourlyRaise.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyRaise.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblHourlyRaise.Location = New System.Drawing.Point(26, 312)
        Me.lblHourlyRaise.Name = "lblHourlyRaise"
        Me.lblHourlyRaise.Size = New System.Drawing.Size(244, 19)
        Me.lblHourlyRaise.TabIndex = 4
        Me.lblHourlyRaise.Text = "Hourly wage with a 4% increase:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCalculate.Location = New System.Drawing.Point(30, 394)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 50)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnClear.Location = New System.Drawing.Point(231, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 50)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnExit.Location = New System.Drawing.Point(433, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHourlyval
        '
        Me.lblHourlyval.AutoSize = True
        Me.lblHourlyval.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyval.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblHourlyval.Location = New System.Drawing.Point(227, 181)
        Me.lblHourlyval.Name = "lblHourlyval"
        Me.lblHourlyval.Size = New System.Drawing.Size(68, 19)
        Me.lblHourlyval.TabIndex = 11
        Me.lblHourlyval.Text = "$888.88"
        '
        'lblAnnualval
        '
        Me.lblAnnualval.AutoSize = True
        Me.lblAnnualval.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualval.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblAnnualval.Location = New System.Drawing.Point(227, 246)
        Me.lblAnnualval.Name = "lblAnnualval"
        Me.lblAnnualval.Size = New System.Drawing.Size(68, 19)
        Me.lblAnnualval.TabIndex = 12
        Me.lblAnnualval.Text = "$888.88"
        '
        'lblHourlyRaiseval
        '
        Me.lblHourlyRaiseval.AutoSize = True
        Me.lblHourlyRaiseval.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyRaiseval.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblHourlyRaiseval.Location = New System.Drawing.Point(311, 312)
        Me.lblHourlyRaiseval.Name = "lblHourlyRaiseval"
        Me.lblHourlyRaiseval.Size = New System.Drawing.Size(68, 19)
        Me.lblHourlyRaiseval.TabIndex = 13
        Me.lblHourlyRaiseval.Text = "$888.88"
        '
        'lblAnnualRaise
        '
        Me.lblAnnualRaise.AutoSize = True
        Me.lblAnnualRaise.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualRaise.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblAnnualRaise.Location = New System.Drawing.Point(26, 348)
        Me.lblAnnualRaise.Name = "lblAnnualRaise"
        Me.lblAnnualRaise.Size = New System.Drawing.Size(247, 19)
        Me.lblAnnualRaise.TabIndex = 14
        Me.lblAnnualRaise.Text = "Annual wage with a 4% increase:"
        '
        'lblAnnualRaiseval
        '
        Me.lblAnnualRaiseval.AutoSize = True
        Me.lblAnnualRaiseval.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualRaiseval.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblAnnualRaiseval.Location = New System.Drawing.Point(311, 348)
        Me.lblAnnualRaiseval.Name = "lblAnnualRaiseval"
        Me.lblAnnualRaiseval.Size = New System.Drawing.Size(68, 19)
        Me.lblAnnualRaiseval.TabIndex = 15
        Me.lblAnnualRaiseval.Text = "$888.88"
        '
        'frmCompsalary
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(559, 486)
        Me.Controls.Add(Me.lblAnnualRaiseval)
        Me.Controls.Add(Me.lblAnnualRaise)
        Me.Controls.Add(Me.lblHourlyRaiseval)
        Me.Controls.Add(Me.lblAnnualval)
        Me.Controls.Add(Me.lblHourlyval)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHourlyRaise)
        Me.Controls.Add(Me.lblAnnualwage)
        Me.Controls.Add(Me.lblHourlywage)
        Me.Controls.Add(Me.cboOccupation)
        Me.Controls.Add(Me.picCompimg)
        Me.Name = "frmCompsalary"
        Me.Text = "Salaries for Computer Occupations"
        CType(Me.picCompimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCompimg As PictureBox
    Friend WithEvents cboOccupation As ComboBox
    Friend WithEvents lblHourlywage As Label
    Friend WithEvents lblAnnualwage As Label
    Friend WithEvents lblHourlyRaise As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHourlyval As Label
    Friend WithEvents lblAnnualval As Label
    Friend WithEvents lblHourlyRaiseval As Label
    Friend WithEvents lblAnnualRaise As Label
    Friend WithEvents lblAnnualRaiseval As Label
End Class
