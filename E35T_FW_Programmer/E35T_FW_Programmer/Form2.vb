Option Strict On

Public Class Form2
    Private Results As String
    Private Delegate Sub delUpdate()
    Private Finished As New delUpdate(AddressOf UpdateText)
    Dim button_click As Integer = 0
    Dim myprocess As New Process
    Dim StartInfo As New System.Diagnostics.ProcessStartInfo
    'Setup the CMD window

    Private Sub opencmd()
        StartInfo.FileName = "cmd" 'starts cmd window
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.UseShellExecute = False 'required to redirect
        StartInfo.CreateNoWindow = True 'creates no cmd window
        myprocess.StartInfo = StartInfo
        myprocess.Start()
    End Sub
    'Setup for CMD function (scroll to text)
    Private Sub UpdateText()
        txtResults.AppendText(System.Environment.NewLine() & Results)
        txtResults.ScrollToCaret()
    End Sub


    'When clicked:
    'Send IPconfig command to cmd window

    'Button1 is ipconfig button, never labeled it
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button1.Click
        txtResults.Text = ""
        opencmd()
        Dim CMDThread As New Threading.Thread(AddressOf CMDAutomateipConfig)
        'start cmd thread
        CMDThread.Start()
    End Sub
    'IPconfig command function
    Private Sub CMDAutomateipConfig()
        myprocess.StandardInput.WriteLine("@echo off")
        myprocess.StandardInput.WriteLine("")
        myprocess.StandardInput.WriteLine("ipconfig")
        myprocess.StandardInput.WriteLine("")
        myprocess.StandardInput.WriteLine("exit")
        myprocess.StandardInput.WriteLine(System.Environment.NewLine())
        While myprocess.StandardOutput.EndOfStream = False
            Results = myprocess.StandardOutput.ReadLine()
            Invoke(Finished)
        End While
    End Sub
End Class