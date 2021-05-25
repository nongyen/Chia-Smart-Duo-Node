<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.timer_reload_node = New System.Windows.Forms.Timer(Me.components)
        Me.run_node = New System.Windows.Forms.Timer(Me.components)
        Me.timer_check_nodeonline = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.run_node_fromfile = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New Chia_Smart_Duo_Node.FormSkin
        Me.FlatButton4 = New Chia_Smart_Duo_Node.FlatButton
        Me.RadioButton2 = New Chia_Smart_Duo_Node.RadioButton
        Me.RadioButton1 = New Chia_Smart_Duo_Node.RadioButton
        Me.FlatLabel9 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatLabel8 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatLabel6 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatLabel7 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatButton3 = New Chia_Smart_Duo_Node.FlatButton
        Me.FlatLabel5 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatLabel4 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatStatusBar1 = New Chia_Smart_Duo_Node.FlatStatusBar
        Me.FlatLabel3 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatLabel2 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatMini1 = New Chia_Smart_Duo_Node.FlatMini
        Me.FlatClose1 = New Chia_Smart_Duo_Node.FlatClose
        Me.FlatLabel1 = New Chia_Smart_Duo_Node.FlatLabel
        Me.FlatTextBox1 = New Chia_Smart_Duo_Node.FlatTextBox
        Me.FlatButton2 = New Chia_Smart_Duo_Node.FlatButton
        Me.FlatButton1 = New Chia_Smart_Duo_Node.FlatButton
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer_reload_node
        '
        Me.timer_reload_node.Interval = 300000
        '
        'run_node
        '
        Me.run_node.Interval = 600000
        '
        'timer_check_nodeonline
        '
        Me.timer_check_nodeonline.Enabled = True
        Me.timer_check_nodeonline.Interval = 30000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'run_node_fromfile
        '
        Me.run_node_fromfile.Interval = 600000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.RadioButton2)
        Me.FormSkin1.Controls.Add(Me.RadioButton1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel9)
        Me.FormSkin1.Controls.Add(Me.FlatLabel8)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.FlatLabel7)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatTextBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.ListView1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(504, 421)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Chia Smart Duo Node"
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(335, 55)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(152, 28)
        Me.FlatButton4.TabIndex = 24
        Me.FlatButton4.Text = "Select File Node"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RadioButton2.Checked = False
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(253, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Options = Chia_Smart_Duo_Node.RadioButton._Options.Style1
        Me.RadioButton2.Size = New System.Drawing.Size(100, 22)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "From File"
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(151, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Options = Chia_Smart_Duo_Node.RadioButton._Options.Style1
        Me.RadioButton1.Size = New System.Drawing.Size(100, 22)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.Text = "From Server"
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(14, 57)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(131, 21)
        Me.FlatLabel9.TabIndex = 21
        Me.FlatLabel9.Text = "Select Node from"
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(14, 78)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(478, 21)
        Me.FlatLabel8.TabIndex = 20
        Me.FlatLabel8.Text = "------------------------------------------------------------------------------"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.FlatLabel6.Location = New System.Drawing.Point(339, 374)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(56, 21)
        Me.FlatLabel6.TabIndex = 19
        Me.FlatLabel6.Text = "0"
        Me.FlatLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(393, 374)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(98, 21)
        Me.FlatLabel7.TabIndex = 18
        Me.FlatLabel7.Text = "Node Online"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(359, 97)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(128, 32)
        Me.FlatButton3.TabIndex = 17
        Me.FlatButton3.Text = "Re-Load Node"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel5
        '
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.Tomato
        Me.FlatLabel5.Location = New System.Drawing.Point(117, 374)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(175, 21)
        Me.FlatLabel5.TabIndex = 16
        Me.FlatLabel5.Text = "Connect failed 0"
        Me.FlatLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlatLabel4
        '
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.Lime
        Me.FlatLabel4.Location = New System.Drawing.Point(11, 374)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(125, 21)
        Me.FlatLabel4.TabIndex = 15
        Me.FlatLabel4.Text = "Connected 0"
        Me.FlatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 398)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(504, 23)
        Me.FlatStatusBar1.TabIndex = 14
        Me.FlatStatusBar1.Text = "Chia Smart Duo Node By nOnGyEn V1.0"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.FlatLabel3.Location = New System.Drawing.Point(65, 131)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(126, 21)
        Me.FlatLabel3.TabIndex = 13
        Me.FlatLabel3.Text = "Loading Node.."
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(11, 131)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(55, 21)
        Me.FlatLabel2.TabIndex = 12
        Me.FlatLabel2.Text = "Status:"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(459, 3)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 11
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(483, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 10
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(14, 101)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(100, 21)
        Me.FlatLabel1.TabIndex = 9
        Me.FlatLabel1.Text = "Chia Version:"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Enabled = False
        Me.FlatTextBox1.Location = New System.Drawing.Point(115, 99)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(72, 29)
        Me.FlatTextBox1.TabIndex = 8
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Enabled = False
        Me.FlatButton2.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(276, 97)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(77, 32)
        Me.FlatButton2.TabIndex = 7
        Me.FlatButton2.Text = "Stop"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(193, 97)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(77, 32)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "Start"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Window
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 158)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(475, 215)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 226
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 151
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 421)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Add Node Chia By nOnGyEn"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Chia_Smart_Duo_Node.FormSkin
    Friend WithEvents FlatButton2 As Chia_Smart_Duo_Node.FlatButton
    Friend WithEvents FlatButton1 As Chia_Smart_Duo_Node.FlatButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FlatTextBox1 As Chia_Smart_Duo_Node.FlatTextBox
    Friend WithEvents FlatLabel1 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents FlatMini1 As Chia_Smart_Duo_Node.FlatMini
    Friend WithEvents FlatClose1 As Chia_Smart_Duo_Node.FlatClose
    Friend WithEvents FlatLabel2 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents FlatStatusBar1 As Chia_Smart_Duo_Node.FlatStatusBar
    Friend WithEvents FlatLabel3 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents FlatLabel4 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents FlatLabel5 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents timer_reload_node As System.Windows.Forms.Timer
    Friend WithEvents run_node As System.Windows.Forms.Timer
    Friend WithEvents FlatLabel6 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents FlatLabel7 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents timer_check_nodeonline As System.Windows.Forms.Timer
    Friend WithEvents FlatLabel8 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents RadioButton1 As Chia_Smart_Duo_Node.RadioButton
    Friend WithEvents FlatLabel9 As Chia_Smart_Duo_Node.FlatLabel
    Friend WithEvents RadioButton2 As Chia_Smart_Duo_Node.RadioButton
    Friend WithEvents FlatButton4 As Chia_Smart_Duo_Node.FlatButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents run_node_fromfile As System.Windows.Forms.Timer
    Friend WithEvents FlatButton3 As Chia_Smart_Duo_Node.FlatButton
End Class
