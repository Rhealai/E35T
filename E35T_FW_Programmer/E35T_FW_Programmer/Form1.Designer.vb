<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ledStatus1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ledStatus2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbSelectCom = New System.Windows.Forms.ComboBox()
        Me.btnConnected = New System.Windows.Forms.Button()
        Me.tbAppPath = New System.Windows.Forms.TextBox()
        Me.tbApp = New System.Windows.Forms.TextBox()
        Me.tbAppAugmented = New System.Windows.Forms.TextBox()
        Me.tbControlWinName = New System.Windows.Forms.TextBox()
        Me.btnAppPathSet = New System.Windows.Forms.Button()
        Me.btnAppSet = New System.Windows.Forms.Button()
        Me.btnControlWinNameSet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ledStatus3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lbProcessStatus = New System.Windows.Forms.Label()
        Me.lbProbePin = New System.Windows.Forms.Label()
        Me.lbTimer1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 140)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(412, 233)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(730, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ledStatus3, Me.ledStatus2, Me.ledStatus1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(730, 406)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'ledStatus1
        '
        Me.ledStatus1.FillColor = System.Drawing.Color.Yellow
        Me.ledStatus1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ledStatus1.Location = New System.Drawing.Point(24, 12)
        Me.ledStatus1.Name = "ledStatus1"
        Me.ledStatus1.Size = New System.Drawing.Size(30, 30)
        '
        'ledStatus2
        '
        Me.ledStatus2.FillColor = System.Drawing.Color.Yellow
        Me.ledStatus2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ledStatus2.Location = New System.Drawing.Point(24, 51)
        Me.ledStatus2.Name = "ledStatus2"
        Me.ledStatus2.Size = New System.Drawing.Size(30, 30)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(294, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 103)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbSelectCom
        '
        Me.cbSelectCom.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.cbSelectCom.FormattingEnabled = True
        Me.cbSelectCom.Location = New System.Drawing.Point(456, 15)
        Me.cbSelectCom.Name = "cbSelectCom"
        Me.cbSelectCom.Size = New System.Drawing.Size(240, 20)
        Me.cbSelectCom.TabIndex = 4
        '
        'btnConnected
        '
        Me.btnConnected.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.btnConnected.Location = New System.Drawing.Point(606, 41)
        Me.btnConnected.Name = "btnConnected"
        Me.btnConnected.Size = New System.Drawing.Size(90, 29)
        Me.btnConnected.TabIndex = 5
        Me.btnConnected.Text = "Connect"
        Me.btnConnected.UseVisualStyleBackColor = True
        '
        'tbAppPath
        '
        Me.tbAppPath.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.tbAppPath.Location = New System.Drawing.Point(17, 46)
        Me.tbAppPath.Multiline = True
        Me.tbAppPath.Name = "tbAppPath"
        Me.tbAppPath.Size = New System.Drawing.Size(237, 30)
        Me.tbAppPath.TabIndex = 6
        '
        'tbApp
        '
        Me.tbApp.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.tbApp.Location = New System.Drawing.Point(20, 124)
        Me.tbApp.Name = "tbApp"
        Me.tbApp.Size = New System.Drawing.Size(59, 22)
        Me.tbApp.TabIndex = 7
        '
        'tbAppAugmented
        '
        Me.tbAppAugmented.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.tbAppAugmented.Location = New System.Drawing.Point(93, 124)
        Me.tbAppAugmented.Name = "tbAppAugmented"
        Me.tbAppAugmented.Size = New System.Drawing.Size(161, 22)
        Me.tbAppAugmented.TabIndex = 7
        '
        'tbControlWinName
        '
        Me.tbControlWinName.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.tbControlWinName.Location = New System.Drawing.Point(18, 202)
        Me.tbControlWinName.Name = "tbControlWinName"
        Me.tbControlWinName.Size = New System.Drawing.Size(234, 22)
        Me.tbControlWinName.TabIndex = 7
        '
        'btnAppPathSet
        '
        Me.btnAppPathSet.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.btnAppPathSet.Location = New System.Drawing.Point(207, 82)
        Me.btnAppPathSet.Name = "btnAppPathSet"
        Me.btnAppPathSet.Size = New System.Drawing.Size(47, 26)
        Me.btnAppPathSet.TabIndex = 8
        Me.btnAppPathSet.Text = "Set"
        Me.btnAppPathSet.UseVisualStyleBackColor = True
        '
        'btnAppSet
        '
        Me.btnAppSet.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.btnAppSet.Location = New System.Drawing.Point(207, 152)
        Me.btnAppSet.Name = "btnAppSet"
        Me.btnAppSet.Size = New System.Drawing.Size(47, 26)
        Me.btnAppSet.TabIndex = 8
        Me.btnAppSet.Text = "Set"
        Me.btnAppSet.UseVisualStyleBackColor = True
        '
        'btnControlWinNameSet
        '
        Me.btnControlWinNameSet.Font = New System.Drawing.Font("新細明體", 10.0!)
        Me.btnControlWinNameSet.Location = New System.Drawing.Point(205, 230)
        Me.btnControlWinNameSet.Name = "btnControlWinNameSet"
        Me.btnControlWinNameSet.Size = New System.Drawing.Size(47, 26)
        Me.btnControlWinNameSet.TabIndex = 8
        Me.btnControlWinNameSet.Text = "Set"
        Me.btnControlWinNameSet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "程式目錄"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "指定程式"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "擴充指令"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "控制視窗名稱"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbAppPath)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbApp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbAppAugmented)
        Me.GroupBox1.Controls.Add(Me.tbControlWinName)
        Me.GroupBox1.Controls.Add(Me.btnControlWinNameSet)
        Me.GroupBox1.Controls.Add(Me.btnAppPathSet)
        Me.GroupBox1.Controls.Add(Me.btnAppSet)
        Me.GroupBox1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 266)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定程式關聯"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'ledStatus3
        '
        Me.ledStatus3.FillColor = System.Drawing.Color.Yellow
        Me.ledStatus3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ledStatus3.Location = New System.Drawing.Point(24, 93)
        Me.ledStatus3.Name = "ledStatus3"
        Me.ledStatus3.Size = New System.Drawing.Size(30, 30)
        '
        'lbProcessStatus
        '
        Me.lbProcessStatus.AutoSize = True
        Me.lbProcessStatus.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.lbProcessStatus.Location = New System.Drawing.Point(75, 23)
        Me.lbProcessStatus.Name = "lbProcessStatus"
        Me.lbProcessStatus.Size = New System.Drawing.Size(72, 16)
        Me.lbProcessStatus.TabIndex = 12
        Me.lbProcessStatus.Text = "燒錄程序"
        '
        'lbProbePin
        '
        Me.lbProbePin.AutoSize = True
        Me.lbProbePin.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.lbProbePin.Location = New System.Drawing.Point(75, 66)
        Me.lbProbePin.Name = "lbProbePin"
        Me.lbProbePin.Size = New System.Drawing.Size(104, 16)
        Me.lbProbePin.TabIndex = 12
        Me.lbProbePin.Text = "探針接觸狀態"
        '
        'lbTimer1
        '
        Me.lbTimer1.AutoSize = True
        Me.lbTimer1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.lbTimer1.Location = New System.Drawing.Point(75, 103)
        Me.lbTimer1.Name = "lbTimer1"
        Me.lbTimer1.Size = New System.Drawing.Size(86, 16)
        Me.lbTimer1.TabIndex = 12
        Me.lbTimer1.Text = "Timer:Status"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 406)
        Me.Controls.Add(Me.lbTimer1)
        Me.Controls.Add(Me.lbProbePin)
        Me.Controls.Add(Me.lbProcessStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConnected)
        Me.Controls.Add(Me.cbSelectCom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ledStatus1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ledStatus2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbSelectCom As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnected As System.Windows.Forms.Button
    Friend WithEvents tbAppPath As System.Windows.Forms.TextBox
    Friend WithEvents tbApp As System.Windows.Forms.TextBox
    Friend WithEvents tbAppAugmented As System.Windows.Forms.TextBox
    Friend WithEvents tbControlWinName As System.Windows.Forms.TextBox
    Friend WithEvents btnAppPathSet As System.Windows.Forms.Button
    Friend WithEvents btnAppSet As System.Windows.Forms.Button
    Friend WithEvents btnControlWinNameSet As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbProcessStatus As System.Windows.Forms.Label
    Friend WithEvents lbProbePin As System.Windows.Forms.Label
    Friend WithEvents lbTimer1 As System.Windows.Forms.Label
    Public WithEvents ledStatus3 As Microsoft.VisualBasic.PowerPacks.OvalShape
End Class
