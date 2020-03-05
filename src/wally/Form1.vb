Imports System.IO
Public Class Form1

    Dim Allow As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        'Me.Bounds = Screen.GetWorkingArea(Me) (FileSetupPath)
        System.Threading.Thread.Sleep(3000)

        'Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim result As DialogResult = MessageBox.Show("Close Retsuko?", "Hold On...", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        ElseIf Allow = "True" Then
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            System.Threading.Thread.Sleep(0700)
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            Dim SetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko"
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            Me.BackgroundImage = My.Resources.NightSkyCity
            System.IO.Directory.Delete(SetupPath, True)
        Else
            MsgBox("Can't Let YOU Do That, Sorry...", MsgBoxStyle.Critical, "Oops!!!")
            e.Cancel = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Allow = "True"
        Me.Close()
        Allow = ""
    End Sub
End Class
