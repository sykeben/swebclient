<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.AppFrame = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Gainsboro
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu.Size = New System.Drawing.Size(800, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "Menu"
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Gainsboro
        Me.HomeButton.BackgroundImage = Global.swebclient.My.Resources.Resources.Home__Blue__Flat_Ish__16x16
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Location = New System.Drawing.Point(2, 0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(23, 23)
        Me.HomeButton.TabIndex = 1
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'AppFrame
        '
        Me.AppFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppFrame.Location = New System.Drawing.Point(0, 24)
        Me.AppFrame.MinimumSize = New System.Drawing.Size(20, 20)
        Me.AppFrame.Name = "AppFrame"
        Me.AppFrame.Size = New System.Drawing.Size(800, 426)
        Me.AppFrame.TabIndex = 2
        Me.AppFrame.Url = New System.Uri("https://sykeben.github.io/swebserver/", System.UriKind.Absolute)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AppFrame)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Main"
        Me.Text = "SykesWeb Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents HomeButton As Button
    Friend WithEvents AppFrame As WebBrowser
End Class
