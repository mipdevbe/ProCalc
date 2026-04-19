<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorForm))
        txtDisplay = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button15 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button17 = New Button()
        btnClear = New Button()
        lblFirstNumber = New Label()
        lblOperator = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.BorderStyle = BorderStyle.FixedSingle
        txtDisplay.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDisplay.Location = New Point(6, 43)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(321, 45)
        txtDisplay.TabIndex = 0
        txtDisplay.Text = "0"
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 24.6246243F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.2252254F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(Button15, 2, 3)
        TableLayoutPanel1.Controls.Add(Button13, 0, 3)
        TableLayoutPanel1.Controls.Add(Button14, 1, 3)
        TableLayoutPanel1.Controls.Add(Button9, 0, 2)
        TableLayoutPanel1.Controls.Add(Button10, 1, 2)
        TableLayoutPanel1.Controls.Add(Button11, 2, 2)
        TableLayoutPanel1.Controls.Add(Button12, 3, 2)
        TableLayoutPanel1.Controls.Add(Button8, 3, 1)
        TableLayoutPanel1.Controls.Add(Button7, 2, 1)
        TableLayoutPanel1.Controls.Add(Button6, 1, 1)
        TableLayoutPanel1.Controls.Add(Button5, 0, 1)
        TableLayoutPanel1.Controls.Add(Button4, 3, 0)
        TableLayoutPanel1.Controls.Add(Button3, 2, 0)
        TableLayoutPanel1.Controls.Add(Button2, 1, 0)
        TableLayoutPanel1.Controls.Add(Button1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 176)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(333, 249)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Button15
        ' 
        TableLayoutPanel1.SetColumnSpan(Button15, 2)
        Button15.Dock = DockStyle.Fill
        Button15.Font = New Font("Microsoft Sans Serif", 12F)
        Button15.Location = New Point(171, 192)
        Button15.Margin = New Padding(6)
        Button15.Name = "Button15"
        Button15.Size = New Size(156, 51)
        Button15.TabIndex = 16
        Button15.Text = "="
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Dock = DockStyle.Fill
        Button13.Font = New Font("Microsoft Sans Serif", 12F)
        Button13.Location = New Point(6, 192)
        Button13.Margin = New Padding(6)
        Button13.Name = "Button13"
        Button13.Size = New Size(71, 51)
        Button13.TabIndex = 15
        Button13.Text = "."
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Dock = DockStyle.Fill
        Button14.Font = New Font("Microsoft Sans Serif", 12F)
        Button14.Location = New Point(89, 192)
        Button14.Margin = New Padding(6)
        Button14.Name = "Button14"
        Button14.Size = New Size(70, 51)
        Button14.TabIndex = 14
        Button14.Text = "0"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Dock = DockStyle.Fill
        Button9.Font = New Font("Microsoft Sans Serif", 12F)
        Button9.Location = New Point(6, 130)
        Button9.Margin = New Padding(6)
        Button9.Name = "Button9"
        Button9.Size = New Size(71, 50)
        Button9.TabIndex = 11
        Button9.Text = "1"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Dock = DockStyle.Fill
        Button10.Font = New Font("Microsoft Sans Serif", 12F)
        Button10.Location = New Point(89, 130)
        Button10.Margin = New Padding(6)
        Button10.Name = "Button10"
        Button10.Size = New Size(70, 50)
        Button10.TabIndex = 10
        Button10.Text = "2"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Dock = DockStyle.Fill
        Button11.Font = New Font("Microsoft Sans Serif", 12F)
        Button11.Location = New Point(171, 130)
        Button11.Margin = New Padding(6)
        Button11.Name = "Button11"
        Button11.Size = New Size(72, 50)
        Button11.TabIndex = 9
        Button11.Text = "3"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Dock = DockStyle.Fill
        Button12.Font = New Font("Microsoft Sans Serif", 12F)
        Button12.Location = New Point(255, 130)
        Button12.Margin = New Padding(6)
        Button12.Name = "Button12"
        Button12.Size = New Size(72, 50)
        Button12.TabIndex = 8
        Button12.Text = "+"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Dock = DockStyle.Fill
        Button8.Font = New Font("Microsoft Sans Serif", 12F)
        Button8.Location = New Point(255, 68)
        Button8.Margin = New Padding(6)
        Button8.Name = "Button8"
        Button8.Size = New Size(72, 50)
        Button8.TabIndex = 7
        Button8.Text = "-"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Dock = DockStyle.Fill
        Button7.Font = New Font("Microsoft Sans Serif", 12F)
        Button7.Location = New Point(171, 68)
        Button7.Margin = New Padding(6)
        Button7.Name = "Button7"
        Button7.Size = New Size(72, 50)
        Button7.TabIndex = 6
        Button7.Text = "6"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Fill
        Button6.Font = New Font("Microsoft Sans Serif", 12F)
        Button6.Location = New Point(89, 68)
        Button6.Margin = New Padding(6)
        Button6.Name = "Button6"
        Button6.Size = New Size(70, 50)
        Button6.TabIndex = 5
        Button6.Text = "5"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Dock = DockStyle.Fill
        Button5.Font = New Font("Microsoft Sans Serif", 12F)
        Button5.Location = New Point(6, 68)
        Button5.Margin = New Padding(6)
        Button5.Name = "Button5"
        Button5.Size = New Size(71, 50)
        Button5.TabIndex = 4
        Button5.Text = "4"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Fill
        Button4.Font = New Font("Microsoft Sans Serif", 12F)
        Button4.Location = New Point(255, 6)
        Button4.Margin = New Padding(6)
        Button4.Name = "Button4"
        Button4.Size = New Size(72, 50)
        Button4.TabIndex = 3
        Button4.Text = "x"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Microsoft Sans Serif", 12F)
        Button3.Location = New Point(171, 6)
        Button3.Margin = New Padding(6)
        Button3.Name = "Button3"
        Button3.Size = New Size(72, 50)
        Button3.TabIndex = 2
        Button3.Text = "9"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Microsoft Sans Serif", 12F)
        Button2.Location = New Point(89, 6)
        Button2.Margin = New Padding(6)
        Button2.Name = "Button2"
        Button2.Size = New Size(70, 50)
        Button2.TabIndex = 1
        Button2.Text = "8"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Microsoft Sans Serif", 12F)
        Button1.Location = New Point(6, 6)
        Button1.Margin = New Padding(6)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 50)
        Button1.TabIndex = 0
        Button1.Text = "7"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 76.92308F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.0769234F))
        TableLayoutPanel2.Controls.Add(Button17, 1, 0)
        TableLayoutPanel2.Controls.Add(btnClear, 0, 0)
        TableLayoutPanel2.Location = New Point(0, 117)
        TableLayoutPanel2.Margin = New Padding(6)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(333, 54)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' Button17
        ' 
        Button17.Dock = DockStyle.Fill
        Button17.Font = New Font("Microsoft Sans Serif", 12F)
        Button17.Location = New Point(256, 5)
        Button17.Margin = New Padding(0, 5, 6, 5)
        Button17.Name = "Button17"
        Button17.Size = New Size(71, 44)
        Button17.TabIndex = 18
        Button17.Text = "%"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Dock = DockStyle.Fill
        btnClear.Font = New Font("Microsoft Sans Serif", 12F)
        btnClear.Location = New Point(6, 5)
        btnClear.Margin = New Padding(6, 5, 13, 5)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(237, 44)
        btnClear.TabIndex = 17
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblFirstNumber
        ' 
        lblFirstNumber.Location = New Point(6, 9)
        lblFirstNumber.Name = "lblFirstNumber"
        lblFirstNumber.Size = New Size(300, 25)
        lblFirstNumber.TabIndex = 3
        lblFirstNumber.Text = "20"
        lblFirstNumber.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblOperator
        ' 
        lblOperator.AutoSize = True
        lblOperator.Location = New Point(303, 9)
        lblOperator.Name = "lblOperator"
        lblOperator.Size = New Size(24, 25)
        lblOperator.TabIndex = 4
        lblOperator.Text = "+"
        ' 
        ' CalculatorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(333, 425)
        Controls.Add(lblOperator)
        Controls.Add(lblFirstNumber)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(txtDisplay)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "CalculatorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "`"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button17 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents lblOperator As Label
End Class
