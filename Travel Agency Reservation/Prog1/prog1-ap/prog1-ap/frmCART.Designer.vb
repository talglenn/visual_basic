<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCART
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picAgency = New System.Windows.Forms.PictureBox()
        Me.lblBookingNum = New System.Windows.Forms.Label()
        Me.txtBookingNum = New System.Windows.Forms.TextBox()
        Me.lblNumOfPassengers = New System.Windows.Forms.Label()
        Me.lblClassic = New System.Windows.Forms.Label()
        Me.lblHighWater = New System.Windows.Forms.Label()
        Me.txtClassicPassengers = New System.Windows.Forms.TextBox()
        Me.txtHighWaterPassengers = New System.Windows.Forms.TextBox()
        Me.lblNumZipLine = New System.Windows.Forms.Label()
        Me.txtNumOfZipLine = New System.Windows.Forms.TextBox()
        Me.lblNumCanopy = New System.Windows.Forms.Label()
        Me.txtNumCanopy = New System.Windows.Forms.TextBox()
        Me.btnDisplayInvoice = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCostAmt = New System.Windows.Forms.Label()
        Me.lblFinalTotalAmt = New System.Windows.Forms.Label()
        Me.lblTaxAmt = New System.Windows.Forms.Label()
        Me.lblServiceChargeAmt = New System.Windows.Forms.Label()
        CType(Me.picAgency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(59, 186)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(466, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Columbus Agency for Regional Travel (CART)"
        '
        'picAgency
        '
        Me.picAgency.Image = Global.prog1_ap.My.Resources.Resources.Reykjavik_Exterior_Shot
        Me.picAgency.Location = New System.Drawing.Point(-1, -2)
        Me.picAgency.Name = "picAgency"
        Me.picAgency.Size = New System.Drawing.Size(585, 176)
        Me.picAgency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAgency.TabIndex = 1
        Me.picAgency.TabStop = False
        '
        'lblBookingNum
        '
        Me.lblBookingNum.AutoSize = True
        Me.lblBookingNum.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingNum.Location = New System.Drawing.Point(3, 250)
        Me.lblBookingNum.Name = "lblBookingNum"
        Me.lblBookingNum.Size = New System.Drawing.Size(151, 16)
        Me.lblBookingNum.TabIndex = 2
        Me.lblBookingNum.Text = "Enter the booking number: "
        '
        'txtBookingNum
        '
        Me.txtBookingNum.Location = New System.Drawing.Point(148, 246)
        Me.txtBookingNum.Name = "txtBookingNum"
        Me.txtBookingNum.Size = New System.Drawing.Size(33, 20)
        Me.txtBookingNum.TabIndex = 3
        '
        'lblNumOfPassengers
        '
        Me.lblNumOfPassengers.AutoSize = True
        Me.lblNumOfPassengers.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfPassengers.Location = New System.Drawing.Point(187, 250)
        Me.lblNumOfPassengers.Name = "lblNumOfPassengers"
        Me.lblNumOfPassengers.Size = New System.Drawing.Size(309, 16)
        Me.lblNumOfPassengers.TabIndex = 4
        Me.lblNumOfPassengers.Text = "and the number of passengers doing the whitewater rafting:"
        '
        'lblClassic
        '
        Me.lblClassic.AutoSize = True
        Me.lblClassic.Font = New System.Drawing.Font("Goudy Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassic.Location = New System.Drawing.Point(485, 230)
        Me.lblClassic.Name = "lblClassic"
        Me.lblClassic.Size = New System.Drawing.Size(38, 15)
        Me.lblClassic.TabIndex = 5
        Me.lblClassic.Text = "Classic"
        '
        'lblHighWater
        '
        Me.lblHighWater.AutoSize = True
        Me.lblHighWater.Font = New System.Drawing.Font("Goudy Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighWater.Location = New System.Drawing.Point(523, 230)
        Me.lblHighWater.Name = "lblHighWater"
        Me.lblHighWater.Size = New System.Drawing.Size(60, 15)
        Me.lblHighWater.TabIndex = 6
        Me.lblHighWater.Text = "High Water"
        '
        'txtClassicPassengers
        '
        Me.txtClassicPassengers.Location = New System.Drawing.Point(492, 248)
        Me.txtClassicPassengers.Name = "txtClassicPassengers"
        Me.txtClassicPassengers.Size = New System.Drawing.Size(33, 20)
        Me.txtClassicPassengers.TabIndex = 7
        '
        'txtHighWaterPassengers
        '
        Me.txtHighWaterPassengers.Location = New System.Drawing.Point(539, 248)
        Me.txtHighWaterPassengers.Name = "txtHighWaterPassengers"
        Me.txtHighWaterPassengers.Size = New System.Drawing.Size(33, 20)
        Me.txtHighWaterPassengers.TabIndex = 8
        '
        'lblNumZipLine
        '
        Me.lblNumZipLine.AutoSize = True
        Me.lblNumZipLine.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumZipLine.Location = New System.Drawing.Point(3, 299)
        Me.lblNumZipLine.Name = "lblNumZipLine"
        Me.lblNumZipLine.Size = New System.Drawing.Size(287, 16)
        Me.lblNumZipLine.TabIndex = 9
        Me.lblNumZipLine.Text = "Enter the number of passengers attempting the zip line:"
        '
        'txtNumOfZipLine
        '
        Me.txtNumOfZipLine.Location = New System.Drawing.Point(296, 297)
        Me.txtNumOfZipLine.Name = "txtNumOfZipLine"
        Me.txtNumOfZipLine.Size = New System.Drawing.Size(33, 20)
        Me.txtNumOfZipLine.TabIndex = 10
        '
        'lblNumCanopy
        '
        Me.lblNumCanopy.AutoSize = True
        Me.lblNumCanopy.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCanopy.Location = New System.Drawing.Point(3, 340)
        Me.lblNumCanopy.Name = "lblNumCanopy"
        Me.lblNumCanopy.Size = New System.Drawing.Size(275, 16)
        Me.lblNumCanopy.TabIndex = 11
        Me.lblNumCanopy.Text = "Enter the number of passengers on the canopy boat:"
        '
        'txtNumCanopy
        '
        Me.txtNumCanopy.Location = New System.Drawing.Point(296, 338)
        Me.txtNumCanopy.Name = "txtNumCanopy"
        Me.txtNumCanopy.Size = New System.Drawing.Size(33, 20)
        Me.txtNumCanopy.TabIndex = 12
        '
        'btnDisplayInvoice
        '
        Me.btnDisplayInvoice.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayInvoice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnDisplayInvoice.Location = New System.Drawing.Point(237, 363)
        Me.btnDisplayInvoice.Name = "btnDisplayInvoice"
        Me.btnDisplayInvoice.Size = New System.Drawing.Size(110, 29)
        Me.btnDisplayInvoice.TabIndex = 13
        Me.btnDisplayInvoice.Text = "Display Invoice"
        Me.btnDisplayInvoice.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(6, 417)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(62, 16)
        Me.lblTotalCost.TabIndex = 14
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(6, 448)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 16)
        Me.lblTax.TabIndex = 15
        Me.lblTax.Text = "Tax:"
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.AutoSize = True
        Me.lblServiceCharge.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.Location = New System.Drawing.Point(6, 477)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(82, 16)
        Me.lblServiceCharge.TabIndex = 16
        Me.lblServiceCharge.Text = "Service Charge:"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.Location = New System.Drawing.Point(6, 504)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(63, 16)
        Me.lblFinalTotal.TabIndex = 17
        Me.lblFinalTotal.Text = "Final Total:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClear.Location = New System.Drawing.Point(462, 410)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 29)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.Location = New System.Drawing.Point(462, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 29)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCostAmt
        '
        Me.lblTotalCostAmt.AutoSize = True
        Me.lblTotalCostAmt.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostAmt.Location = New System.Drawing.Point(94, 419)
        Me.lblTotalCostAmt.Name = "lblTotalCostAmt"
        Me.lblTotalCostAmt.Size = New System.Drawing.Size(47, 16)
        Me.lblTotalCostAmt.TabIndex = 24
        Me.lblTotalCostAmt.Text = "$888.88"
        '
        'lblFinalTotalAmt
        '
        Me.lblFinalTotalAmt.AutoSize = True
        Me.lblFinalTotalAmt.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotalAmt.Location = New System.Drawing.Point(94, 505)
        Me.lblFinalTotalAmt.Name = "lblFinalTotalAmt"
        Me.lblFinalTotalAmt.Size = New System.Drawing.Size(47, 16)
        Me.lblFinalTotalAmt.TabIndex = 25
        Me.lblFinalTotalAmt.Text = "$888.88"
        '
        'lblTaxAmt
        '
        Me.lblTaxAmt.AutoSize = True
        Me.lblTaxAmt.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmt.Location = New System.Drawing.Point(94, 449)
        Me.lblTaxAmt.Name = "lblTaxAmt"
        Me.lblTaxAmt.Size = New System.Drawing.Size(24, 16)
        Me.lblTaxAmt.TabIndex = 26
        Me.lblTaxAmt.Text = "7%"
        '
        'lblServiceChargeAmt
        '
        Me.lblServiceChargeAmt.AutoSize = True
        Me.lblServiceChargeAmt.Font = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceChargeAmt.Location = New System.Drawing.Point(94, 478)
        Me.lblServiceChargeAmt.Name = "lblServiceChargeAmt"
        Me.lblServiceChargeAmt.Size = New System.Drawing.Size(30, 16)
        Me.lblServiceChargeAmt.TabIndex = 27
        Me.lblServiceChargeAmt.Text = "15%"
        '
        'frmCART
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(584, 536)
        Me.Controls.Add(Me.lblServiceChargeAmt)
        Me.Controls.Add(Me.lblTaxAmt)
        Me.Controls.Add(Me.lblFinalTotalAmt)
        Me.Controls.Add(Me.lblTotalCostAmt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblServiceCharge)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnDisplayInvoice)
        Me.Controls.Add(Me.txtNumCanopy)
        Me.Controls.Add(Me.lblNumCanopy)
        Me.Controls.Add(Me.txtNumOfZipLine)
        Me.Controls.Add(Me.lblNumZipLine)
        Me.Controls.Add(Me.txtHighWaterPassengers)
        Me.Controls.Add(Me.txtClassicPassengers)
        Me.Controls.Add(Me.lblHighWater)
        Me.Controls.Add(Me.lblClassic)
        Me.Controls.Add(Me.lblNumOfPassengers)
        Me.Controls.Add(Me.txtBookingNum)
        Me.Controls.Add(Me.lblBookingNum)
        Me.Controls.Add(Me.picAgency)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCART"
        Me.Text = "Columbus Agency for Regional Travel Reservation System"
        CType(Me.picAgency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picAgency As PictureBox
    Friend WithEvents lblBookingNum As Label
    Friend WithEvents txtBookingNum As TextBox
    Friend WithEvents lblNumOfPassengers As Label
    Friend WithEvents lblClassic As Label
    Friend WithEvents lblHighWater As Label
    Friend WithEvents txtClassicPassengers As TextBox
    Friend WithEvents txtHighWaterPassengers As TextBox
    Friend WithEvents lblNumZipLine As Label
    Friend WithEvents txtNumOfZipLine As TextBox
    Friend WithEvents lblNumCanopy As Label
    Friend WithEvents txtNumCanopy As TextBox
    Friend WithEvents btnDisplayInvoice As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblServiceCharge As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCostAmt As Label
    Friend WithEvents lblFinalTotalAmt As Label
    Friend WithEvents lblTaxAmt As Label
    Friend WithEvents lblServiceChargeAmt As Label
End Class
