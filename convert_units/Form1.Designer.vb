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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtEnteredNum = New System.Windows.Forms.TextBox()
        Me.rdInchesToMeters = New System.Windows.Forms.RadioButton()
        Me.rdMetersToInches = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.Image = Global.convert_units.My.Resources.Resources.building
        Me.picBuilding.Location = New System.Drawing.Point(3, 2)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(274, 186)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppTitle.Location = New System.Drawing.Point(345, 33)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(198, 29)
        Me.lblAppTitle.TabIndex = 1
        Me.lblAppTitle.Text = "Converter App"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(342, 107)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(205, 48)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter a value and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtEnteredNum
        '
        Me.txtEnteredNum.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnteredNum.Location = New System.Drawing.Point(618, 124)
        Me.txtEnteredNum.Name = "txtEnteredNum"
        Me.txtEnteredNum.Size = New System.Drawing.Size(100, 31)
        Me.txtEnteredNum.TabIndex = 3
        '
        'rdInchesToMeters
        '
        Me.rdInchesToMeters.AutoSize = True
        Me.rdInchesToMeters.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdInchesToMeters.Location = New System.Drawing.Point(29, 38)
        Me.rdInchesToMeters.Name = "rdInchesToMeters"
        Me.rdInchesToMeters.Size = New System.Drawing.Size(181, 24)
        Me.rdInchesToMeters.TabIndex = 4
        Me.rdInchesToMeters.TabStop = True
        Me.rdInchesToMeters.Text = "Inches to Meters"
        Me.rdInchesToMeters.UseVisualStyleBackColor = True
        '
        'rdMetersToInches
        '
        Me.rdMetersToInches.AutoSize = True
        Me.rdMetersToInches.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMetersToInches.Location = New System.Drawing.Point(29, 68)
        Me.rdMetersToInches.Name = "rdMetersToInches"
        Me.rdMetersToInches.Size = New System.Drawing.Size(181, 24)
        Me.rdMetersToInches.TabIndex = 5
        Me.rdMetersToInches.TabStop = True
        Me.rdMetersToInches.Text = "Meters to Inches"
        Me.rdMetersToInches.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.rdInchesToMeters)
        Me.GroupBox1.Controls.Add(Me.rdMetersToInches)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(372, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 122)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert Measurement"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumPurple
        Me.btnConvert.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(70, 415)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(169, 46)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumPurple
        Me.btnClear.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(344, 415)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 46)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.ForeColor = System.Drawing.Color.White
        Me.btExit.Location = New System.Drawing.Point(618, 415)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(169, 46)
        Me.btExit.TabIndex = 9
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(346, 358)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(79, 24)
        Me.lblResults.TabIndex = 10
        Me.lblResults.Text = "Label1"
        Me.lblResults.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 507)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEnteredNum)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblAppTitle)
        Me.Controls.Add(Me.picBuilding)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtEnteredNum As TextBox
    Friend WithEvents rdInchesToMeters As RadioButton
    Friend WithEvents rdMetersToInches As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btExit As Button
    Friend WithEvents lblResults As Label
End Class
