<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecials
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
        Me.SuspendLayout()
        '
        'btnReservation
        '
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservation.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(575, 12)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(95, 37)
        Me.btnReservation.TabIndex = 7
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'btnRoyalClub
        '
        Me.btnRoyalClub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRoyalClub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRoyalClub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoyalClub.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoyalClub.Location = New System.Drawing.Point(387, 12)
        Me.btnRoyalClub.Name = "btnRoyalClub"
        Me.btnRoyalClub.Size = New System.Drawing.Size(95, 37)
        Me.btnRoyalClub.TabIndex = 6
        Me.btnRoyalClub.Text = "Royal Club"
        Me.btnRoyalClub.UseVisualStyleBackColor = True
        '
        'btnSpecials
        '
        Me.btnSpecials.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSpecials.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSpecials.FlatAppearance.BorderSize = 2
        Me.btnSpecials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSpecials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSpecials.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpecials.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecials.Location = New System.Drawing.Point(199, 12)
        Me.btnSpecials.Name = "btnSpecials"
        Me.btnSpecials.Size = New System.Drawing.Size(95, 37)
        Me.btnSpecials.TabIndex = 5
        Me.btnSpecials.Text = "Specials"
        Me.btnSpecials.UseVisualStyleBackColor = False
        '
        'btnMenus
        '
        Me.btnMenus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMenus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMenus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenus.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenus.Location = New System.Drawing.Point(11, 12)
        Me.btnMenus.Name = "btnMenus"
        Me.btnMenus.Size = New System.Drawing.Size(95, 37)
        Me.btnMenus.TabIndex = 4
        Me.btnMenus.Text = "Menus"
        Me.btnMenus.UseVisualStyleBackColor = False
        '
        'frmSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 523)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.btnRoyalClub)
        Me.Controls.Add(Me.btnSpecials)
        Me.Controls.Add(Me.btnMenus)
        Me.Name = "frmSpecials"
        Me.Text = "frmSpecials"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReservation As Button
    Friend WithEvents btnRoyalClub As Button
    Friend WithEvents btnSpecials As Button
    Friend WithEvents btnMenus As Button
End Class
