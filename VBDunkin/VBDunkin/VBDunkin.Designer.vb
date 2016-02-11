<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDunkin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDunkin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCostPurchase = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtCostDonuts = New System.Windows.Forms.TextBox()
        Me.txtNumDonuts = New System.Windows.Forms.TextBox()
        Me.lblProgramer = New System.Windows.Forms.Label()
        Me.lblDunkinD = New System.Windows.Forms.Label()
        Me.lblNumDonuts = New System.Windows.Forms.Label()
        Me.lblCostDonuts = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblCostPurchase = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ttpDunkin = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ttpDunkin.SetToolTip(Me.PictureBox1, "Donut.")
        '
        'txtCostPurchase
        '
        Me.txtCostPurchase.Location = New System.Drawing.Point(393, 367)
        Me.txtCostPurchase.Name = "txtCostPurchase"
        Me.txtCostPurchase.ReadOnly = True
        Me.txtCostPurchase.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPurchase.TabIndex = 1
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(393, 308)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 2
        '
        'txtCostDonuts
        '
        Me.txtCostDonuts.Location = New System.Drawing.Point(393, 257)
        Me.txtCostDonuts.Name = "txtCostDonuts"
        Me.txtCostDonuts.ReadOnly = True
        Me.txtCostDonuts.Size = New System.Drawing.Size(100, 20)
        Me.txtCostDonuts.TabIndex = 3
        '
        'txtNumDonuts
        '
        Me.txtNumDonuts.Location = New System.Drawing.Point(393, 138)
        Me.txtNumDonuts.Name = "txtNumDonuts"
        Me.txtNumDonuts.Size = New System.Drawing.Size(100, 20)
        Me.txtNumDonuts.TabIndex = 4
        '
        'lblProgramer
        '
        Me.lblProgramer.AutoSize = True
        Me.lblProgramer.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramer.Location = New System.Drawing.Point(375, 479)
        Me.lblProgramer.Name = "lblProgramer"
        Me.lblProgramer.Size = New System.Drawing.Size(110, 12)
        Me.lblProgramer.TabIndex = 5
        Me.lblProgramer.Text = "Alex Winstanley"
        Me.ttpDunkin.SetToolTip(Me.lblProgramer, "Programmer name")
        '
        'lblDunkinD
        '
        Me.lblDunkinD.AutoSize = True
        Me.lblDunkinD.Font = New System.Drawing.Font("Lucida Console", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDunkinD.Location = New System.Drawing.Point(115, 35)
        Me.lblDunkinD.Name = "lblDunkinD"
        Me.lblDunkinD.Size = New System.Drawing.Size(262, 32)
        Me.lblDunkinD.TabIndex = 6
        Me.lblDunkinD.Text = "Dunkin Donuts"
        Me.ttpDunkin.SetToolTip(Me.lblDunkinD, "Company name")
        '
        'lblNumDonuts
        '
        Me.lblNumDonuts.AutoSize = True
        Me.lblNumDonuts.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDonuts.Location = New System.Drawing.Point(270, 143)
        Me.lblNumDonuts.Name = "lblNumDonuts"
        Me.lblNumDonuts.Size = New System.Drawing.Size(117, 11)
        Me.lblNumDonuts.TabIndex = 7
        Me.lblNumDonuts.Text = "Number of Donuts"
        '
        'lblCostDonuts
        '
        Me.lblCostDonuts.AutoSize = True
        Me.lblCostDonuts.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostDonuts.Location = New System.Drawing.Point(284, 262)
        Me.lblCostDonuts.Name = "lblCostDonuts"
        Me.lblCostDonuts.Size = New System.Drawing.Size(103, 11)
        Me.lblCostDonuts.TabIndex = 8
        Me.lblCostDonuts.Text = "Cost of Donuts"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(256, 313)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(131, 11)
        Me.lblTax.TabIndex = 9
        Me.lblTax.Text = "Virginia Sales Tax"
        '
        'lblCostPurchase
        '
        Me.lblCostPurchase.AutoSize = True
        Me.lblCostPurchase.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPurchase.Location = New System.Drawing.Point(270, 372)
        Me.lblCostPurchase.Name = "lblCostPurchase"
        Me.lblCostPurchase.Size = New System.Drawing.Size(117, 11)
        Me.lblCostPurchase.TabIndex = 10
        Me.lblCostPurchase.Text = "Cost of Purchase"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(55, 438)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 44)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.ttpDunkin.SetToolTip(Me.btnExit, "exits the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(55, 316)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(111, 44)
        Me.btnCompute.TabIndex = 12
        Me.btnCompute.Text = "C&ompute"
        Me.ttpDunkin.SetToolTip(Me.btnCompute, "Computes your answer")
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(55, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 44)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "C&lear"
        Me.ttpDunkin.SetToolTip(Me.btnClear, "Clears the text boxes")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmDunkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(507, 500)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCostPurchase)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblCostDonuts)
        Me.Controls.Add(Me.lblNumDonuts)
        Me.Controls.Add(Me.lblDunkinD)
        Me.Controls.Add(Me.lblProgramer)
        Me.Controls.Add(Me.txtNumDonuts)
        Me.Controls.Add(Me.txtCostDonuts)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtCostPurchase)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmDunkin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dunkin Donuts -- Interactive Order Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCostPurchase As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtCostDonuts As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDonuts As System.Windows.Forms.TextBox
    Friend WithEvents lblProgramer As System.Windows.Forms.Label
    Friend WithEvents lblDunkinD As System.Windows.Forms.Label
    Friend WithEvents lblNumDonuts As System.Windows.Forms.Label
    Friend WithEvents lblCostDonuts As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblCostPurchase As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ttpDunkin As System.Windows.Forms.ToolTip

End Class
