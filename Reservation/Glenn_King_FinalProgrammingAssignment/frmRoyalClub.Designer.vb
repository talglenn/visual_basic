<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoyalClub
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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.lblJoin = New System.Windows.Forms.Label()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.mskEmail = New System.Windows.Forms.MaskedTextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReservation
        '
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservation.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(583, 12)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(95, 37)
        Me.btnReservation.TabIndex = 7
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'btnRoyalClub
        '
        Me.btnRoyalClub.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnRoyalClub.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnRoyalClub.FlatAppearance.BorderSize = 2
        Me.btnRoyalClub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRoyalClub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRoyalClub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoyalClub.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoyalClub.Location = New System.Drawing.Point(395, 12)
        Me.btnRoyalClub.Name = "btnRoyalClub"
        Me.btnRoyalClub.Size = New System.Drawing.Size(95, 37)
        Me.btnRoyalClub.TabIndex = 6
        Me.btnRoyalClub.Text = "Royal Club"
        Me.btnRoyalClub.UseVisualStyleBackColor = False
        '
        'btnSpecials
        '
        Me.btnSpecials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSpecials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSpecials.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpecials.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecials.Location = New System.Drawing.Point(207, 12)
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
        Me.btnMenus.Location = New System.Drawing.Point(19, 12)
        Me.btnMenus.Name = "btnMenus"
        Me.btnMenus.Size = New System.Drawing.Size(95, 37)
        Me.btnMenus.TabIndex = 4
        Me.btnMenus.Text = "Menus"
        Me.btnMenus.UseVisualStyleBackColor = True
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(204, 153)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(0, 18)
        Me.lblGreeting.TabIndex = 9
        '
        'lblJoin
        '
        Me.lblJoin.AutoSize = True
        Me.lblJoin.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoin.Location = New System.Drawing.Point(128, 121)
        Me.lblJoin.Name = "lblJoin"
        Me.lblJoin.Size = New System.Drawing.Size(199, 32)
        Me.lblJoin.TabIndex = 10
        Me.lblJoin.Text = "Join the Club:"
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(16, 183)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(431, 18)
        Me.lblSign.TabIndex = 11
        Me.lblSign.Text = "Sign up by entering your email to recieve special offers:"
        '
        'mskEmail
        '
        Me.mskEmail.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskEmail.Location = New System.Drawing.Point(19, 223)
        Me.mskEmail.Name = "mskEmail"
        Me.mskEmail.Size = New System.Drawing.Size(428, 26)
        Me.mskEmail.TabIndex = 12
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
        Me.btnSubmit.Location = New System.Drawing.Point(174, 279)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(95, 37)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'frmRoyalClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 523)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.mskEmail)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.lblJoin)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.btnRoyalClub)
        Me.Controls.Add(Me.btnSpecials)
        Me.Controls.Add(Me.btnMenus)
        Me.Name = "frmRoyalClub"
        Me.Text = "frmRoyalClub"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReservation As Button
    Friend WithEvents btnRoyalClub As Button
    Friend WithEvents btnSpecials As Button
    Friend WithEvents btnMenus As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents lblJoin As Label
    Friend WithEvents lblSign As Label
    Friend WithEvents mskEmail As MaskedTextBox
    Friend WithEvents btnSubmit As Button
End Class
