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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1DOELMAP = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3DWG = New System.Windows.Forms.CheckBox()
        Me.CheckBox2DXF = New System.Windows.Forms.CheckBox()
        Me.CheckBox1PDF = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox_Stempeltype = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Blanco = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Bedrijfsbureau = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Assemblage = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Werkplaats = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Printer = New System.Windows.Forms.GroupBox()
        Me.RadioButton_default = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Xerox_Boven = New System.Windows.Forms.RadioButton()
        Me.RadioButton_HP_5100 = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox_Stempeltype.SuspendLayout()
        Me.GroupBox_Printer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Selecteer doelmap"
        Me.ToolTip1.SetToolTip(Me.Button1, "Defineer de bestemming voor PDF, DXF & DWG printen")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 537)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Versie 1 Release 8"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'TextBox1DOELMAP
        '
        Me.TextBox1DOELMAP.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1DOELMAP.Name = "TextBox1DOELMAP"
        Me.TextBox1DOELMAP.Size = New System.Drawing.Size(706, 20)
        Me.TextBox1DOELMAP.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TextBox1DOELMAP, "Deze balk geeft de bestemming aan voor PDF, DXF & DWG printen")
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1DOELMAP)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 56)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doelmap"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3DWG)
        Me.GroupBox2.Controls.Add(Me.CheckBox2DXF)
        Me.GroupBox2.Controls.Add(Me.CheckBox1PDF)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 119)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bestandsformaat"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox4.Location = New System.Drawing.Point(7, 91)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "STEMPEL"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3DWG
        '
        Me.CheckBox3DWG.AutoSize = True
        Me.CheckBox3DWG.Location = New System.Drawing.Point(7, 68)
        Me.CheckBox3DWG.Name = "CheckBox3DWG"
        Me.CheckBox3DWG.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox3DWG.TabIndex = 2
        Me.CheckBox3DWG.Text = "DWG"
        Me.CheckBox3DWG.UseVisualStyleBackColor = True
        '
        'CheckBox2DXF
        '
        Me.CheckBox2DXF.AutoSize = True
        Me.CheckBox2DXF.Location = New System.Drawing.Point(7, 44)
        Me.CheckBox2DXF.Name = "CheckBox2DXF"
        Me.CheckBox2DXF.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox2DXF.TabIndex = 1
        Me.CheckBox2DXF.Text = "DXF"
        Me.CheckBox2DXF.UseVisualStyleBackColor = True
        '
        'CheckBox1PDF
        '
        Me.CheckBox1PDF.AutoSize = True
        Me.CheckBox1PDF.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1PDF.Name = "CheckBox1PDF"
        Me.CheckBox1PDF.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox1PDF.TabIndex = 0
        Me.CheckBox1PDF.Text = "PDF"
        Me.CheckBox1PDF.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(702, 524)
        Me.ListBox1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Sleep IDW's hierheen om een printlijst te maken.")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(167, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(714, 547)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Printlijst"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "Sleep IDW's hierheen om een printlijst te maken.")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 589)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Print tekeningen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox_Stempeltype
        '
        Me.GroupBox_Stempeltype.Controls.Add(Me.CheckBox_Blanco)
        Me.GroupBox_Stempeltype.Controls.Add(Me.CheckBox_Bedrijfsbureau)
        Me.GroupBox_Stempeltype.Controls.Add(Me.CheckBox_Assemblage)
        Me.GroupBox_Stempeltype.Controls.Add(Me.CheckBox_Werkplaats)
        Me.GroupBox_Stempeltype.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox_Stempeltype.Name = "GroupBox_Stempeltype"
        Me.GroupBox_Stempeltype.Size = New System.Drawing.Size(144, 110)
        Me.GroupBox_Stempeltype.TabIndex = 8
        Me.GroupBox_Stempeltype.TabStop = False
        Me.GroupBox_Stempeltype.Text = "Stempeltype"
        Me.GroupBox_Stempeltype.Visible = False
        '
        'CheckBox_Blanco
        '
        Me.CheckBox_Blanco.AutoSize = True
        Me.CheckBox_Blanco.Location = New System.Drawing.Point(7, 88)
        Me.CheckBox_Blanco.Name = "CheckBox_Blanco"
        Me.CheckBox_Blanco.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox_Blanco.TabIndex = 7
        Me.CheckBox_Blanco.Text = "Blanco"
        Me.CheckBox_Blanco.UseVisualStyleBackColor = True
        '
        'CheckBox_Bedrijfsbureau
        '
        Me.CheckBox_Bedrijfsbureau.AutoSize = True
        Me.CheckBox_Bedrijfsbureau.Location = New System.Drawing.Point(7, 65)
        Me.CheckBox_Bedrijfsbureau.Name = "CheckBox_Bedrijfsbureau"
        Me.CheckBox_Bedrijfsbureau.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox_Bedrijfsbureau.TabIndex = 6
        Me.CheckBox_Bedrijfsbureau.Text = "Bedrijfsbureau"
        Me.CheckBox_Bedrijfsbureau.UseVisualStyleBackColor = True
        '
        'CheckBox_Assemblage
        '
        Me.CheckBox_Assemblage.AutoSize = True
        Me.CheckBox_Assemblage.Location = New System.Drawing.Point(7, 42)
        Me.CheckBox_Assemblage.Name = "CheckBox_Assemblage"
        Me.CheckBox_Assemblage.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox_Assemblage.TabIndex = 5
        Me.CheckBox_Assemblage.Text = "Assemblage"
        Me.CheckBox_Assemblage.UseVisualStyleBackColor = True
        '
        'CheckBox_Werkplaats
        '
        Me.CheckBox_Werkplaats.AutoSize = True
        Me.CheckBox_Werkplaats.Location = New System.Drawing.Point(7, 19)
        Me.CheckBox_Werkplaats.Name = "CheckBox_Werkplaats"
        Me.CheckBox_Werkplaats.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox_Werkplaats.TabIndex = 4
        Me.CheckBox_Werkplaats.Text = "Werkplaats"
        Me.CheckBox_Werkplaats.UseVisualStyleBackColor = True
        '
        'GroupBox_Printer
        '
        Me.GroupBox_Printer.Controls.Add(Me.RadioButton_default)
        Me.GroupBox_Printer.Controls.Add(Me.RadioButton_Xerox_Boven)
        Me.GroupBox_Printer.Controls.Add(Me.RadioButton_HP_5100)
        Me.GroupBox_Printer.Location = New System.Drawing.Point(13, 283)
        Me.GroupBox_Printer.Name = "GroupBox_Printer"
        Me.GroupBox_Printer.Size = New System.Drawing.Size(152, 90)
        Me.GroupBox_Printer.TabIndex = 9
        Me.GroupBox_Printer.TabStop = False
        Me.GroupBox_Printer.Text = "Printer"
        Me.GroupBox_Printer.Visible = False
        '
        'RadioButton_default
        '
        Me.RadioButton_default.AutoSize = True
        Me.RadioButton_default.Location = New System.Drawing.Point(7, 66)
        Me.RadioButton_default.Name = "RadioButton_default"
        Me.RadioButton_default.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_default.TabIndex = 2
        Me.RadioButton_default.Text = "Default"
        Me.ToolTip1.SetToolTip(Me.RadioButton_default, "Print hetzelfde als je laatste print sinds Inventor voor het laatst is opgestart." &
        " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maar print (nog) alleen op A3.")
        Me.RadioButton_default.UseVisualStyleBackColor = True
        '
        'RadioButton_Xerox_Boven
        '
        Me.RadioButton_Xerox_Boven.AutoSize = True
        Me.RadioButton_Xerox_Boven.Checked = True
        Me.RadioButton_Xerox_Boven.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton_Xerox_Boven.Name = "RadioButton_Xerox_Boven"
        Me.RadioButton_Xerox_Boven.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton_Xerox_Boven.TabIndex = 1
        Me.RadioButton_Xerox_Boven.TabStop = True
        Me.RadioButton_Xerox_Boven.Text = "Xerox (Boven)"
        Me.ToolTip1.SetToolTip(Me.RadioButton_Xerox_Boven, resources.GetString("RadioButton_Xerox_Boven.ToolTip"))
        Me.RadioButton_Xerox_Boven.UseVisualStyleBackColor = True
        '
        'RadioButton_HP_5100
        '
        Me.RadioButton_HP_5100.AutoSize = True
        Me.RadioButton_HP_5100.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton_HP_5100.Name = "RadioButton_HP_5100"
        Me.RadioButton_HP_5100.Size = New System.Drawing.Size(132, 17)
        Me.RadioButton_HP_5100.TabIndex = 0
        Me.RadioButton_HP_5100.Text = "HP 5100 (Engineering)"
        Me.RadioButton_HP_5100.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 25000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Select Printer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 624)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox_Printer)
        Me.Controls.Add(Me.GroupBox_Stempeltype)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Alles in 1 printer."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox_Stempeltype.ResumeLayout(False)
        Me.GroupBox_Stempeltype.PerformLayout()
        Me.GroupBox_Printer.ResumeLayout(False)
        Me.GroupBox_Printer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1DOELMAP As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3DWG As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2DXF As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1PDF As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Stempeltype As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox_Bedrijfsbureau As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Assemblage As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Werkplaats As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Printer As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Xerox_Boven As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_HP_5100 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_default As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox_Blanco As System.Windows.Forms.CheckBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button3 As Button
End Class
