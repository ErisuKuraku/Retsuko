<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.go_button = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.about_button = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Windows 95", "Windows 98", "Windows 2000", "Windows ME", "Windows XP", "Windows Vista", "Windows 7", "Windows 8", "Windows 8.1", "Windows 10", "---------------------------", "Anime Train", "LibreFinder", "Night Sky City", "Star Gazing", "Water Bulbs", "---------------------------", "Aerial", "Aurora", "Colour Bar", "DVD", "Flurry", "Matrix", "Nyan Cat", "Plasma", "Win98 - 3DMaze", "3D Flower Box", "Dancing"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'go_button
        '
        Me.go_button.Depth = 0
        Me.go_button.Location = New System.Drawing.Point(50, 99)
        Me.go_button.MouseState = MaterialSkin.MouseState.HOVER
        Me.go_button.Name = "go_button"
        Me.go_button.Primary = True
        Me.go_button.Size = New System.Drawing.Size(59, 23)
        Me.go_button.TabIndex = 6
        Me.go_button.Text = "GO!"
        Me.go_button.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 160)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(141, 19)
        Me.MaterialLabel1.TabIndex = 7
        Me.MaterialLabel1.Text = "©Erisu Kuraku 2020"
        '
        'about_button
        '
        Me.about_button.Depth = 0
        Me.about_button.Location = New System.Drawing.Point(50, 128)
        Me.about_button.MouseState = MaterialSkin.MouseState.HOVER
        Me.about_button.Name = "about_button"
        Me.about_button.Primary = True
        Me.about_button.Size = New System.Drawing.Size(59, 23)
        Me.about_button.TabIndex = 8
        Me.about_button.Text = "About"
        Me.about_button.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(168, 188)
        Me.Controls.Add(Me.about_button)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.go_button)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(168, 188)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(168, 188)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retsuko by Erisu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents go_button As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents about_button As MaterialSkin.Controls.MaterialRaisedButton
End Class
