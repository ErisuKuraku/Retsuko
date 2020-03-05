Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports MaterialSkin
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Me.AcceptButton = go_button
        go_button.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub go_button_Click(sender As Object, e As EventArgs) Handles go_button.Click
        Dim SetupPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & ".Retsuko"
        Dim dirinfo As IO.DirectoryInfo = New IO.DirectoryInfo(SetupPath)
        Dim Directory_ As System.IO.DirectoryInfo = System.IO.Directory.CreateDirectory(SetupPath)



        If ComboBox1.Text = "---------------------------" Then
            MessageBox.Show("Not a valid choice.", "Incorect Input")

        ElseIf ComboBox1.Text = "Windows 95" Then
            Form1.BackgroundImage = My.Resources.Windows95
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows 98" Then
            Form1.BackgroundImage = My.Resources.Windows98
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows 2000" Then
            Form1.BackgroundImage = My.Resources.Windows2000
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows ME" Then
            Form1.BackgroundImage = My.Resources.WindowsME
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows XP" Then
            Form1.BackgroundImage = My.Resources.WindowsXP
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows Vista" Then
            Form1.BackgroundImage = My.Resources.WindowsVista
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows 7" Then
            Form1.BackgroundImage = My.Resources.Windows7
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows 8" Then
            Form1.BackgroundImage = My.Resources.Windows8
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows 8.1" Then
            Form1.BackgroundImage = My.Resources.Windows81
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Windows 10" Then
            Form1.BackgroundImage = My.Resources.Windows10
            Form1.Visible = True
            Me.Close()
            '------------------------------------------------------------------------------

        ElseIf ComboBox1.Text = "Anime Train" Then
            Form1.BackgroundImage = My.Resources.AnimeTrain
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Night Sky City" Then
            Form1.BackgroundImage = My.Resources.NightSkyCity
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Star Gazing" Then
            Form1.BackgroundImage = My.Resources.StarGazing
            Form1.Visible = True
            Me.Close()

        ElseIf ComboBox1.Text = "Water Bulbs" Then
            Form1.BackgroundImage = My.Resources.WaterBulbs
            Form1.Visible = True
            Me.Close()


        ElseIf ComboBox1.Text = "LibreFinder" Then
            dirinfo.Attributes = IO.FileAttributes.Normal
            Dim ImagePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "librefinderimg.png"
            Dim Client As New WebClient
            Client.DownloadFile("http://www.librefinder.co.uk/images/slide01.jpg.png", ImagePath)
            Form1.BackgroundImage = System.Drawing.Image.FromFile(ImagePath)
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Form1.Visible = True
            Me.Close()
            '------------------------------------------------------------------------------
        ElseIf ComboBox1.Text = "Matrix" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "matrix.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.matrix, 0, My.Resources.matrix.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()


        ElseIf ComboBox1.Text = "Aerial" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "aerial.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.Aerial, 0, My.Resources.Aerial.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Flurry" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "flurry.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.Flurry, 0, My.Resources.Flurry.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Win98 - 3DMaze" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "_3DMaze.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources._3DMaze, 0, My.Resources._3DMaze.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Aurora" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "Aurora.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.Aurora, 0, My.Resources.Aurora.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "DVD" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "DVD.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.DVD, 0, My.Resources.DVD.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Plasma" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "Plasma.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.Plasma, 0, My.Resources.Plasma.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "3D Flower Box" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "3DFLBOX.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources._3D_Flower_Box, 0, My.Resources._3D_Flower_Box.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Nyan Cat" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "NYANCAT.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.NyanCat, 0, My.Resources.NyanCat.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Colour Bar" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "colourbar.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.colorbar, 0, My.Resources.colorbar.Length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()

        ElseIf ComboBox1.Text = "Dancing" Then
            Dim FileSetupPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ".Retsuko" & "\" & "karate.scr"
            dirinfo.Attributes = IO.FileAttributes.Normal
            Using sCreateSCRFile As New FileStream(FileSetupPath, FileMode.Create)
                sCreateSCRFile.Write(My.Resources.Karate, 0, My.Resources.Karate.length)
            End Using
            dirinfo.Attributes = IO.FileAttributes.Hidden
            Process.Start(FileSetupPath)
            Me.Close()
        End If


    End Sub

    Private Sub about_button_Click(sender As Object, e As EventArgs) Handles about_button.Click
        MessageBox.Show("All content in this program does not belong to me and are owned by their respective owners. if you have your art or screensaver on this program and want it removed, tweet me @ErisuKuraku", "Infomation about Retsuko")
    End Sub
End Class