Imports System.IO
Imports System.Windows.Forms
Imports System.Text
Imports System.Runtime.InteropServices
Imports System
Imports System.IO.Ports
Imports System.Threading



Public Class Form1

    Dim comPORT As String
    Dim receivedData As String = ""


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim read As String
        read = Cmd("ver")
        'TextBox1.Text = read

        Dim root As String = "C:\Program Files (x86)\Microchip\MPLABX\v3.55\mplab_ipe"
        Directory.SetCurrentDirectory(root)

        'TextBox1.Text = cmdline("")
        'cmdline("")

        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next


    End Sub

    Dim cmdprocess As New System.Diagnostics.Process()

    Public Function cmdline(ByVal Command As String) As String
        cmdprocess.StartInfo.FileName = "cmd.exe"
        
        cmdprocess.StartInfo.UseShellExecute = False
        cmdprocess.StartInfo.RedirectStandardInput = True
        cmdprocess.StartInfo.RedirectStandardOutput = True
        cmdprocess.StartInfo.RedirectStandardError = True
        cmdprocess.StartInfo.CreateNoWindow = True


        cmdprocess.Start()

        'Process.Start("pk3cmd", "-P16F877A -FC:\Users\Riolai\Desktop\PIC16F877A.hex -M -B")
        Process.Start("pk3cmd", "-P16F877A -FD:\USER\rioyclai\Desktop\P\PIC16F877A.hex -M -B")

        'Dim root As String = "C:\Program Files\Microchip\MPLABX\v3.00\mplab_ipe"
        'Directory.SetCurrentDirectory(root)

        'cmdprocess.StandardInput.WriteLine("path=C:\Program Files\Microchip\MPLABX\v3.00\mplab_ipe")
        'cmdprocess.StandardInput.WriteLine("pk3cmd -P16F877A -FC:\Users\Riolai\Desktop\PIC16F877A.hex -M") '執行指定的命令
        cmdprocess.StandardInput.WriteLine("exit")  '關閉視窗 

        Dim Result As String = cmdprocess.StandardOutput.ReadToEnd()
        Return Result

    End Function

    Public Function Cmd(ByVal Command As String) As String
        Dim process As New System.Diagnostics.Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardInput = True
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.StandardInput.WriteLine(Command) '執行指定的命令 

        process.StandardInput.WriteLine("exit")  '關閉視窗 

        Dim Result As String = process.StandardOutput.ReadToEnd()
        process.Close()
        Dim L As New List(Of String)
        L.AddRange(Result.Split(Chr(13)))
        L.RemoveAt(0) '移除首行 
        L.RemoveAt(0) '移除首行     
        L.RemoveAt(0) '移除首行 
        L.RemoveAt(0) '移除首行 
        L.RemoveAt(0) '移除首行 
        L.RemoveAt(L.Count - 1) '移除末行 
        L.RemoveAt(L.Count - 1) '移除末行 
        L.RemoveAt(L.Count - 1) '移除末行 
        Dim SB As New System.Text.StringBuilder
        For Each S In L
            SB.AppendLine(S)
        Next
        Return SB.ToString
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox1.Text = Cmd("ipconfig")
    End Sub

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

    Public Const WM_SETTEXT = &HC
    Public Const WM_COPYDATA As Integer = &H4A


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim hWnd As Integer
        hWnd = FindWindow(vbNullString, "cmd.exe")

        TextBox1.Text = hWnd.ToString

        Dim str As String = "XXX"
        Dim v As StringBuilder

        v = New StringBuilder(str)

        SendMessage(hWnd, WM_SETTEXT, 0, str)
        PostMessage(hWnd, WM_KEYDOWN, VK_ENTER, 0)

    End Sub


    Public Const WM_CHAR = &H66
    Public Const WM_KEYDOWN = &H100
    Public Const VK_ENTER As Integer = &HD

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        KeyDown_Enter()
    End Sub

    Dim path As String = "C:\Program Files (x86)\Microchip\MPLABX\v3.55\mplab_ipe\"

    Sub KeyDown_Enter()
        Dim hWnd As Integer

        hWnd = FindWindow(vbNullString, path + "pk3cmd.exe")
        'TextBox1.Text = hWnd.ToString

        'PostMessage KeyDown 'ENTER'
        PostMessage(hWnd, WM_KEYDOWN, 13, 0)
    End Sub

    Const WM_CLOSE = &H10
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim hWnd As Integer

        'hWnd = FindWindow(vbNullString, "C:\Windows\system32\cmd.exe")
        hWnd = FindWindow(vbNullString, path + "pk3cmd.exe")
        TextBox1.Text = hWnd.ToString

        PostMessage(hWnd, WM_CLOSE, 0, 0)
    End Sub

    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub


    Private Sub connect_BTN_Click(sender As System.Object, e As System.EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
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
                connect_BTN.Text = "Disconnect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        'If (receivedData.Trim() = "Button pressed.") Then
        '    KeyDown_Enter()
        '    MsgBox("KeyDown_Enter")
        'End If

        Select Case receivedData.Trim()
            Case "Button pressed."
                MsgBox("Button pressed.")
            Case "Button released."
                MsgBox("Button released.")

        End Select



        TextBox1.Text += receivedData
    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Const SW_HIDE = 0
    Const SW_SHOW = 5

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim hWnd As Integer = FindWindow(vbNullString, path + "pk3cmd.exe")
        ShowWindow(hWnd, SW_HIDE)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim hWnd As Integer = FindWindow(vbNullString, path + "pk3cmd.exe")
        ShowWindow(hWnd, SW_SHOW)
    End Sub



    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If SerialPort1.IsOpen Then
            Timer1.Enabled = False

            Dim sumData(5) As Integer
            Dim resultData() As Integer

            For j = 1 To 10
                resultData = CapturedAnalog()
                For i = 0 To 5
                    sumData(i) = (sumData(i) * (j - 1) + resultData(i)) / j
                Next
            Next

            resultData = CapturedAnalog()
            Dim diffData(5) As Integer
            Dim tmp As String = ""

            For index = 0 To 5
                diffData(index) = resultData(index) - sumData(index)
                tmp += sumData(index).ToString
                tmp += ","
            Next

            TextBox1.Text = tmp


            'SerialPort1.WriteLine("fac")
            'TextBox1.Text = SerialPort1.ReadLine().Trim

            Timer1.Enabled = True
        End If

    End Sub


    Public Function CapturedAnalog() As Integer()
        SerialPort1.WriteLine("analog")

        Thread.Sleep(20)
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

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            SerialPort1.Dispose()
        End If
    End Sub
End Class
