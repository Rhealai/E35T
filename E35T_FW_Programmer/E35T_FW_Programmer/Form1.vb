Imports System.IO
Imports System.IO.Ports
Imports System.Threading


Public Class Form1

    Dim comPORT As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbAppPath.Text = My.Settings.AppRootPath
        tbApp.Text = My.Settings.AppName
        tbAppAugmented.Text = My.Settings.AppAugmented
        tbControlWinName.Text = My.Settings.ControlWinName
        tbReadyTime.Text = My.Settings.ReadyTime
        tbBuringTime.Text = My.Settings.BuringTime

        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbSelectCom.Items.Add(sp)
        Next

        ToolStripStatusLabel1.Text = "燒錄次數 = " & wrtCount

    End Sub

    Private Sub btnConnected_Click(sender As System.Object, e As System.EventArgs) Handles btnConnected.Click
        If (btnConnected.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                btnConnected.Text = "Disconnect"
                Timer1.Enabled = True
                lbTimer1.Text = "連線狀態: ON"
                ledStatus3.FillColor = Color.Green
                'RichTextBox1.Text += "Timer : ON" & vbCrLf

                SerialPort1.WriteLine("btn")
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            btnConnected.Text = "Connect"
            Timer1.Enabled = False
            lbTimer1.Text = "連線狀態: OFF"
            ledStatus3.FillColor = Color.Yellow
            'RichTextBox1.Text += "Timer : OFF" & vbCrLf
        End If
    End Sub

    Dim receivedData As String = ""


    Declare Auto Function FindWindow Lib "user32.dll" _
(ByVal IpClassName As String, ByVal IpWindowName As String) As Integer

    Declare Auto Function SendMessage Lib "user32.dll" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer,
         ByVal wParam As Integer, ByVal lParam As String) As Integer

    Declare Auto Function PostMessage Lib "user32.dll" _
    (ByVal hwnd As Integer, ByVal wMsg As Integer,
     ByVal wParam As Integer, ByVal lParam As String) As Boolean

    Declare Auto Function ShowWindow Lib "user32.dll" _
        (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    Public Const WM_KEYDOWN = &H100
    Public Const VK_ENTER As Integer = &HD

    Dim BurningFlag As Boolean

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim hWnd As Integer
        hWnd = FindWindow(vbNullString, My.Settings.ControlWinName)


        If hWnd <> 0 Then
            lbProcessStatus.Text = "燒錄程序:燒錄程式就緒"
            ledStatus1.FillColor = Color.Green
            CmdRdy = True
        Else
            lbProcessStatus.Text = "燒錄程序:燒錄程式未就緒"
            ledStatus1.FillColor = Color.Yellow
            CmdRdy = False
        End If

        receivedData = ReceiveSerialData().Trim
        Select Case receivedData
            Case "Button pressed."
                lbProbePin.Text = "探針接觸狀態:接觸"
                ledStatus2.FillColor = Color.Green

                If CmdRdy Then
                    CalcAnalogData()

                    Dim tmp As Integer = 0
                    For index = 0 To 5
                        tmp += diffData(index)
                    Next

                    If tmp > 50 Then
                        SignalCheck = False
                        RichTextBox1.Text += "此電路板未完成燒錄" & vbCrLf
                        RichTextBox1.Text += "開始進行燒錄" & vbCrLf

                        PostMessage(hWnd, WM_KEYDOWN, 13, 0)
                        ProgrammingStatus()

                        CalcAnalogData()

                        SignalMeasure()

                    Else
                        SignalCheck = True
                        RichTextBox1.Text += "此電路已完成燒錄" & vbCrLf
                        RichTextBox1.Text += "請移除電路板" & vbCrLf

                        SignalMeasure()

                    End If
                End If

            Case "Button released."
                lbProbePin.Text = "探針接觸狀態:分開"
                ledStatus2.FillColor = Color.Yellow
        End Select

        receivedData = ""

        ToolStripStatusLabel1.Text = "燒錄次數 = " & wrtCount

    End Sub

    Sub ProgrammingStatus()

        Timer1.Enabled = False
        lbProcessStatus.Text = "燒錄程序:韌體燒錄中"
        ledStatus1.FillColor = Color.Red

        Sleep(My.Settings.BuringTime)

        lbProcessStatus.Text = "燒錄程序:完成燒錄"
        ledStatus1.FillColor = Color.Green

        wrtCount += 1

        Timer1.Enabled = True

    End Sub

    Sub SignalMeasure()
        Timer1.Enabled = False
        lbProcessStatus.Text = "燒錄程序:訊號量測"
        ledStatus1.FillColor = Color.Blue

        'CalcAnalogData()

        Dim tmpResult As String = ""

        For index = 0 To 4
            tmpResult &= resultData(index).ToString & ","
        Next
        tmpResult &= resultData(5).ToString
        RichTextBox1.Text += tmpResult & vbCrLf

        Sleep(500)

        lbProcessStatus.Text = "燒錄程序:完成量測"
        ledStatus1.FillColor = Color.Green

        Sleep(500)

        Timer1.Enabled = True
    End Sub


    Private Sub cbSelectCom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbSelectCom.SelectedIndexChanged
        If (cbSelectCom.SelectedItem <> "") Then
            comPORT = cbSelectCom.SelectedItem
        End If
    End Sub

    Const WM_CLOSE = &H10
    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        Dim hWnd As Integer = FindWindow(vbNullString, My.Settings.ControlWinName)

        If hWnd <> 0 Then
            PostMessage(hWnd, WM_CLOSE, 0, 0)
        End If
    End Sub

    Private Sub btnAppPathSet_Click(sender As System.Object, e As System.EventArgs) Handles btnAppPathSet.Click
        My.Settings.AppRootPath = tbAppPath.Text
        My.Settings.Save()

    End Sub

    Private Sub btnAppSet_Click(sender As System.Object, e As System.EventArgs) Handles btnAppSet.Click
        My.Settings.AppName = tbApp.Text
        My.Settings.AppAugmented = tbAppAugmented.Text
        My.Settings.Save()
    End Sub

    Private Sub btnControlWinNameSet_Click(sender As System.Object, e As System.EventArgs) Handles btnControlWinNameSet.Click
        My.Settings.ControlWinName = tbControlWinName.Text
        My.Settings.Save()
    End Sub


    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming & vbCrLf
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out." & vbCrLf
        End Try

    End Function

    Dim avgData(5) As Integer
    Dim resultData() As Integer
    Dim diffData(5) As Integer
    Dim wrtCount As Integer = 0

    Dim CmdRdy As Boolean

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim tmp As String = ""
        If SerialPort1.IsOpen Then
            Timer1.Enabled = False

            Dim blReadFlag As Boolean = False

            SerialPort1.WriteLine("btn")
            'Thread.Sleep(20)
            Sleep(20)
            receivedData = SerialPort1.ReadLine().Trim

            '"Button pressed."
            If receivedData = "Button pressed." Then
                blReadFlag = True
            Else
                blReadFlag = False
            End If

            receivedData = ""

            If (blReadFlag) Then
                Dim root As String = My.Settings.AppRootPath
                Directory.SetCurrentDirectory(root)
                AppExecute(My.Settings.AppName, My.Settings.AppAugmented)

                Sleep(My.Settings.ReadyTime)

                If FindWindow(vbNullString, My.Settings.ControlWinName) Then
                    ProgrammingStatus()
                    CmdRdy = True
                End If
                
            End If

            Timer1.Enabled = True
        End If
    End Sub

    Dim SignalCheck As Boolean
    Dim blReadFlag As Boolean

    Public Function CapturedAnalog() As Integer()
        SerialPort1.WriteLine("analog")

        'Thread.Sleep(20)
        Sleep(20)
        Dim receviedData As String = SerialPort1.ReadLine()
        receviedData.Trim()

        Dim tmp As String = Mid(receviedData, 2, receviedData.Length - 3)
        Dim data() As String = tmp.Split(",")
        Dim intData(5) As Integer
        If data.Length = 6 Then
            For index = 0 To 5
                intData(index) = Val(data(index))
            Next
        Else
            For index = 0 To 5
                intData(index) = 0
            Next
        End If


        Return intData
    End Function

    Sub CalcAnalogData()
        For j = 1 To 3
            resultData = CapturedAnalog()
            For i = 0 To 5
                avgData(i) = (avgData(i) * (j - 1) + resultData(i)) / j
            Next
        Next

        resultData = CapturedAnalog()

        Dim tmp As String = ""

        For index = 0 To 5
            diffData(index) = resultData(index) - avgData(index)
        Next
    End Sub


    Dim cmdprocess As New System.Diagnostics.Process()
    Sub AppExecute(ByVal application As String, ByVal augmented As String)
        cmdprocess.StartInfo.FileName = "cmd.exe"

        cmdprocess.StartInfo.UseShellExecute = False
        cmdprocess.StartInfo.RedirectStandardInput = True
        cmdprocess.StartInfo.RedirectStandardOutput = True
        cmdprocess.StartInfo.RedirectStandardError = True
        cmdprocess.StartInfo.CreateNoWindow = True

        cmdprocess.Start()

        Process.Start(application, augmented)
        Dim S As String = cmdprocess.StandardOutput.ReadLine() 'Console.ReadLine()

        cmdprocess.StandardInput.WriteLine("exit")  '關閉視窗 

    End Sub

    Public Shared Sub Sleep(ByVal Interval)
        Dim __time As DateTime = DateTime.Now
        Dim __Span As Int64 = Interval * 10000 '因為時間是以100納秒為單位。
        While (DateTime.Now.Ticks - __time.Ticks < __Span)
            Application.DoEvents()
        End While
    End Sub

    Private Sub btnDelaySetting_Click(sender As System.Object, e As System.EventArgs) Handles btnDelaySetting.Click
        My.Settings.ReadyTime = Val(tbReadyTime.Text)
        My.Settings.BuringTime = Val(tbBuringTime.Text)
        My.Settings.Save()

    End Sub
End Class