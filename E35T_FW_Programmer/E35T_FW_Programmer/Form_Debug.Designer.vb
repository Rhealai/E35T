<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Debug
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(331, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(323, 263)
        Me.TextBox1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "WM_SETTEXT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 44)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "FindWindowsHwnd"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(31, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 41)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "WM_CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cmd -> TextBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(190, 235)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(114, 20)
        Me.comPort_ComboBox.TabIndex = 5
        '
        'Timer1
        '
        '
        'connect_BTN
        '
        Me.connect_BTN.Location = New System.Drawing.Point(226, 261)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(99, 25)
        Me.connect_BTN.TabIndex = 6
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Location = New System.Drawing.Point(188, 211)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(63, 12)
        Me.Timer_LBL.TabIndex = 7
        Me.Timer_LBL.Text = "Timer:Status"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(188, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 44)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "SW_HIDE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(188, 73)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 41)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "SW_SHOW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(188, 167)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 41)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "SendMessage"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "程式目錄"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(36, 329)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(518, 22)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "C:\Program Files (x86)\Microchip\MPLABX\v3.55\mplab_ipe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "指定指令"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(36, 385)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(96, 22)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = "pk3cmd.exe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "控制視窗名稱"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(36, 440)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(518, 22)
        Me.TextBox4.TabIndex = 12
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(585, 329)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 22)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Set"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(585, 385)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 22)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Set"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(585, 440)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(69, 22)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Set"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(32, 254)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(134, 38)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "Application Start"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(148, 385)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(405, 22)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "-P16F877A -FD:\USER\rioyclai\Desktop\P\PIC16F877A.hex -M -B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "擴充指令"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(32, 212)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(134, 32)
        Me.Button12.TabIndex = 16
        Me.Button12.Text = "Send Message ""Enter"""
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 474)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents comPort_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents connect_BTN As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button

End Class
