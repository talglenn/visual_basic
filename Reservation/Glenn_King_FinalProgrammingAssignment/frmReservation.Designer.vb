<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
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
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnRoyalClub = New System.Windows.Forms.Button()
        Me.btnSpecials = New System.Windows.Forms.Button()
        Me.btnMenus = New System.Windows.Forms.Button()
        Me.lblSeating = New System.Windows.Forms.Label()
        Me.lblNumCustomers = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cboSeatingType = New System.Windows.Forms.ComboBox()
        Me.txtNumOfCustomers = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnReservation
        '
        Me.btnReservation.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnReservation.FlatAppearance.BorderSize = 2
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservation.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(580, 12)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(95, 37)
        Me.btnReservation.TabIndex = 7
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'btnRoyalClub
        '
        Me.btnRoyalClub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRoyalClub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRoyalClub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoyalClub.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoyalClub.Location = New System.Drawing.Point(392, 12)
        Me.btnRoyalClub.Name = "btnRoyalClub"
        Me.btnRoyalClub.Size = New System.Drawing.Size(95, 37)
        Me.btnRoyalClub.TabIndex = 6
        Me.btnRoyalClub.Text = "Royal Club"
        Me.btnRoyalClub.UseVisualStyleBackColor = True
        '
        'btnSpecials
        '
        Me.btnSpecials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSpecials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSpecials.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpecials.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecials.Location = New System.Drawing.Point(204, 12)
        Me.btnSpecials.Name = "btnSpecials"
        Me.btnSpecials.Size = New System.Drawing.Size(95, 37)
        Me.btnSpecials.TabIndex = 5
        Me.btnSpecials.Text = "Specials"
        Me.btnSpecials.UseVisualStyleBackColor = True
        '
        'btnMenus
        '
        Me.btnMenus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMenus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenus.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenus.Location = New System.Drawing.Point(16, 12)
        Me.btnMenus.Name = "btnMenus"
        Me.btnMenus.Size = New System.Drawing.Size(95, 37)
        Me.btnMenus.TabIndex = 4
        Me.btnMenus.Text = "Menus"
        Me.btnMenus.UseVisualStyleBackColor = True
        '
        'lblSeating
        '
        Me.lblSeating.AutoSize = True
        Me.lblSeating.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeating.Location = New System.Drawing.Point(16, 132)
        Me.lblSeating.Name = "lblSeating"
        Me.lblSeating.Size = New System.Drawing.Size(111, 18)
        Me.lblSeating.TabIndex = 8
        Me.lblSeating.Text = "Seating Type:"
        '
        'lblNumCustomers
        '
        Me.lblNumCustomers.AutoSize = True
        Me.lblNumCustomers.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCustomers.Location = New System.Drawing.Point(16, 202)
        Me.lblNumCustomers.Name = "lblNumCustomers"
        Me.lblNumCustomers.Size = New System.Drawing.Size(92, 36)
        Me.lblNumCustomers.TabIndex = 9
        Me.lblNumCustomers.Text = "Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(16, 290)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(102, 36)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name under" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Reservation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboSeatingType
        '
        Me.cboSeatingType.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeatingType.FormattingEnabled = True
        Me.cboSeatingType.Items.AddRange(New Object() {"Booth", "Round Table", "Squared Table"})
        Me.cboSeatingType.Location = New System.Drawing.Point(178, 129)
        Me.cboSeatingType.Name = "cboSeatingType"
        Me.cboSeatingType.Size = New System.Drawing.Size(182, 26)
        Me.cboSeatingType.TabIndex = 12
        Me.cboSeatingType.Text = "Select seating type"
        '
        'txtNumOfCustomers
        '
        Me.txtNumOfCustomers.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfCustomers.Location = New System.Drawing.Point(178, 212)
        Me.txtNumOfCustomers.Name = "txtNumOfCustomers"
        Me.txtNumOfCustomers.Size = New System.Drawing.Size(100, 26)
        Me.txtNumOfCustomers.TabIndex = 13
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Gold
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSubmit.FlatAppearance.BorderSize = 2
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(527, 437)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(95, 37)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OldLace
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(392, 437)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 37)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(178, 287)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 26)
        Me.txtName.TabIndex = 21
        '
        'frmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 523)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtNumOfCustomers)
        Me.Controls.Add(Me.cboSeatingType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblNumCustomers)
        Me.Controls.Add(Me.lblSeating)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.btnRoyalClub)
        Me.Controls.Add(Me.btnSpecials)
        Me.Controls.Add(Me.btnMenus)
        Me.Name = "frmReservation"
        Me.Text = "frmReservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReservation As Button
    Friend WithEvents btnRoyalClub As Button
    Friend WithEvents btnSpecials As Button
    Friend WithEvents btnMenus As Button
    Friend WithEvents lblSeating As Label
    Friend WithEvents lblNumCustomers As Label
    Friend WithEvents lblName As Label
    Friend WithEvents cboSeatingType As ComboBox
    Friend WithEvents txtNumOfCustomers As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtName As TextBox
End Class
