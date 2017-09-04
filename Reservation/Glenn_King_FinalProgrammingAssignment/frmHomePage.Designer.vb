<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSteakhouse
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
        Me.btnMenus = New System.Windows.Forms.Button()
        Me.btnSpecials = New System.Windows.Forms.Button()
        Me.btnRoyalClub = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picCow = New System.Windows.Forms.PictureBox()
        CType(Me.picCow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenus
        '
        Me.btnMenus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMenus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenus.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenus.Location = New System.Drawing.Point(12, 12)
        Me.btnMenus.Name = "btnMenus"
        Me.btnMenus.Size = New System.Drawing.Size(95, 37)
        Me.btnMenus.TabIndex = 0
        Me.btnMenus.Text = "Menus"
        Me.btnMenus.UseVisualStyleBackColor = True
        '
        'btnSpecials
        '
        Me.btnSpecials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSpecials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSpecials.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpecials.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecials.Location = New System.Drawing.Point(200, 12)
        Me.btnSpecials.Name = "btnSpecials"
        Me.btnSpecials.Size = New System.Drawing.Size(95, 37)
        Me.btnSpecials.TabIndex = 1
        Me.btnSpecials.Text = "Specials"
        Me.btnSpecials.UseVisualStyleBackColor = True
        '
        'btnRoyalClub
        '
        Me.btnRoyalClub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRoyalClub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRoyalClub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoyalClub.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoyalClub.Location = New System.Drawing.Point(388, 12)
        Me.btnRoyalClub.Name = "btnRoyalClub"
        Me.btnRoyalClub.Size = New System.Drawing.Size(95, 37)
        Me.btnRoyalClub.TabIndex = 2
        Me.btnRoyalClub.Text = "Royal Club"
        Me.btnRoyalClub.UseVisualStyleBackColor = True
        '
        'btnReservation
        '
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReservation.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(576, 12)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(95, 37)
        Me.btnReservation.TabIndex = 3
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Fax", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitle.Location = New System.Drawing.Point(73, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(551, 110)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "   Glenn and King's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supreme Steakhouse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picCow
        '
        Me.picCow.Image = Global.Glenn_King_FinalProgrammingAssignment.My.Resources.Resources._471fcbe9ae13f105c13f6d30b02a6f35
        Me.picCow.Location = New System.Drawing.Point(164, 179)
        Me.picCow.Name = "picCow"
        Me.picCow.Size = New System.Drawing.Size(392, 240)
        Me.picCow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCow.TabIndex = 5
        Me.picCow.TabStop = False
        '
        'frmSteakhouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 523)
        Me.Controls.Add(Me.picCow)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.btnRoyalClub)
        Me.Controls.Add(Me.btnSpecials)
        Me.Controls.Add(Me.btnMenus)
        Me.Name = "frmSteakhouse"
        Me.Text = "Supreme Steakhouse"
        CType(Me.picCow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenus As Button
    Friend WithEvents btnSpecials As Button
    Friend WithEvents btnRoyalClub As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picCow As PictureBox
End Class
