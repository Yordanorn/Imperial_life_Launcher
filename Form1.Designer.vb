<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackGround = New Imperial_Life.FormSkin()
        Me.BtnDiscord = New Imperial_Life.FlatButton()
        Me.BtnWebSite = New Imperial_Life.FlatButton()
        Me.ProgBarDownloadMod = New Imperial_Life.FlatProgressBar()
        Me.BtnPlay = New Imperial_Life.FlatButton()
        Me.BtnMaj = New Imperial_Life.FlatButton()
        Me.BtnMini = New Imperial_Life.FlatMini()
        Me.BtnClose = New Imperial_Life.FlatClose()
        Me.BackGround.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackGround
        '
        Me.BackGround.BackColor = System.Drawing.Color.White
        Me.BackGround.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BackGround.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BackGround.Controls.Add(Me.BtnDiscord)
        Me.BackGround.Controls.Add(Me.BtnWebSite)
        Me.BackGround.Controls.Add(Me.ProgBarDownloadMod)
        Me.BackGround.Controls.Add(Me.BtnPlay)
        Me.BackGround.Controls.Add(Me.BtnMaj)
        Me.BackGround.Controls.Add(Me.BtnMini)
        Me.BackGround.Controls.Add(Me.BtnClose)
        Me.BackGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackGround.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BackGround.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BackGround.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackGround.HeaderMaximize = False
        Me.BackGround.Location = New System.Drawing.Point(0, 0)
        Me.BackGround.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BackGround.Name = "BackGround"
        Me.BackGround.Size = New System.Drawing.Size(600, 488)
        Me.BackGround.TabIndex = 0
        Me.BackGround.Text = "Launcher Imperial Life"
        '
        'BtnDiscord
        '
        Me.BtnDiscord.BackColor = System.Drawing.Color.Transparent
        Me.BtnDiscord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnDiscord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDiscord.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDiscord.Location = New System.Drawing.Point(482, 316)
        Me.BtnDiscord.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnDiscord.Name = "BtnDiscord"
        Me.BtnDiscord.Rounded = False
        Me.BtnDiscord.Size = New System.Drawing.Size(110, 50)
        Me.BtnDiscord.TabIndex = 6
        Me.BtnDiscord.Text = "Discord"
        Me.BtnDiscord.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BtnWebSite
        '
        Me.BtnWebSite.BackColor = System.Drawing.Color.Transparent
        Me.BtnWebSite.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnWebSite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWebSite.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnWebSite.Location = New System.Drawing.Point(482, 373)
        Me.BtnWebSite.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnWebSite.Name = "BtnWebSite"
        Me.BtnWebSite.Rounded = False
        Me.BtnWebSite.Size = New System.Drawing.Size(110, 50)
        Me.BtnWebSite.TabIndex = 5
        Me.BtnWebSite.Text = "Site"
        Me.BtnWebSite.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ProgBarDownloadMod
        '
        Me.ProgBarDownloadMod.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ProgBarDownloadMod.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ProgBarDownloadMod.Location = New System.Drawing.Point(9, 429)
        Me.ProgBarDownloadMod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ProgBarDownloadMod.Maximum = 100
        Me.ProgBarDownloadMod.Name = "ProgBarDownloadMod"
        Me.ProgBarDownloadMod.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ProgBarDownloadMod.Size = New System.Drawing.Size(582, 42)
        Me.ProgBarDownloadMod.TabIndex = 4
        Me.ProgBarDownloadMod.Text = "FlatProgressBar1"
        Me.ProgBarDownloadMod.Value = 50
        '
        'BtnPlay
        '
        Me.BtnPlay.BackColor = System.Drawing.Color.Transparent
        Me.BtnPlay.BaseColor = System.Drawing.Color.Red
        Me.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnPlay.Location = New System.Drawing.Point(9, 316)
        Me.BtnPlay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Rounded = False
        Me.BtnPlay.Size = New System.Drawing.Size(110, 50)
        Me.BtnPlay.TabIndex = 3
        Me.BtnPlay.Text = "Jouer"
        Me.BtnPlay.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BtnMaj
        '
        Me.BtnMaj.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaj.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnMaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaj.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnMaj.Location = New System.Drawing.Point(9, 373)
        Me.BtnMaj.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnMaj.Name = "BtnMaj"
        Me.BtnMaj.Rounded = False
        Me.BtnMaj.Size = New System.Drawing.Size(110, 50)
        Me.BtnMaj.TabIndex = 2
        Me.BtnMaj.Text = "Mise à jour"
        Me.BtnMaj.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BtnMini
        '
        Me.BtnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMini.BackColor = System.Drawing.Color.White
        Me.BtnMini.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnMini.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.BtnMini.Location = New System.Drawing.Point(560, 13)
        Me.BtnMini.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(18, 18)
        Me.BtnMini.TabIndex = 1
        Me.BtnMini.Text = "FlatMini1"
        Me.BtnMini.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnClose.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.BtnClose.Location = New System.Drawing.Point(578, 13)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(18, 18)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "FlatClose1"
        Me.BtnClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 488)
        Me.Controls.Add(Me.BackGround)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher Imperial Life"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BackGround.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackGround As FormSkin
    Friend WithEvents BtnMini As FlatMini
    Friend WithEvents BtnClose As FlatClose
    Friend WithEvents BtnMaj As FlatButton
    Friend WithEvents BtnPlay As FlatButton
    Friend WithEvents ProgBarDownloadMod As FlatProgressBar
    Friend WithEvents BtnWebSite As FlatButton
    Friend WithEvents BtnDiscord As FlatButton
End Class
