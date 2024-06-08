<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
        Me.scrollTime = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTimeActuel = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtMinecraft = New System.Windows.Forms.RadioButton()
        Me.rbtMario = New System.Windows.Forms.RadioButton()
        Me.pnlTheme = New System.Windows.Forms.Panel()
        Me.rbtDragonBall = New System.Windows.Forms.RadioButton()
        Me.rbtSonic = New System.Windows.Forms.RadioButton()
        Me.pnlThemeSombre = New System.Windows.Forms.Panel()
        Me.rbtClair = New System.Windows.Forms.RadioButton()
        Me.rbtDark = New System.Windows.Forms.RadioButton()
        Me.grpBoxTheme = New System.Windows.Forms.GroupBox()
        Me.pnlSon = New System.Windows.Forms.Panel()
        Me.rbtVolumeOff = New System.Windows.Forms.RadioButton()
        Me.rbtVolumeOn = New System.Windows.Forms.RadioButton()
        Me.LabelMusic = New System.Windows.Forms.Label()
        Me.pnlTheme.SuspendLayout()
        Me.pnlThemeSombre.SuspendLayout()
        Me.grpBoxTheme.SuspendLayout()
        Me.pnlSon.SuspendLayout()
        Me.SuspendLayout()
        '
        'scrollTime
        '
        Me.scrollTime.Location = New System.Drawing.Point(20, 43)
        Me.scrollTime.Name = "scrollTime"
        Me.scrollTime.Size = New System.Drawing.Size(641, 30)
        Me.scrollTime.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(616, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "60:00"
        '
        'lblTimeActuel
        '
        Me.lblTimeActuel.AutoSize = True
        Me.lblTimeActuel.Location = New System.Drawing.Point(876, 43)
        Me.lblTimeActuel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeActuel.Name = "lblTimeActuel"
        Me.lblTimeActuel.Size = New System.Drawing.Size(0, 16)
        Me.lblTimeActuel.TabIndex = 3
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(45, 453)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(100, 68)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "←"
        Me.btnRetour.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(765, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temps actuel :"
        '
        'rbtMinecraft
        '
        Me.rbtMinecraft.AutoSize = True
        Me.rbtMinecraft.Location = New System.Drawing.Point(29, 73)
        Me.rbtMinecraft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtMinecraft.Name = "rbtMinecraft"
        Me.rbtMinecraft.Size = New System.Drawing.Size(82, 20)
        Me.rbtMinecraft.TabIndex = 9
        Me.rbtMinecraft.TabStop = True
        Me.rbtMinecraft.Text = "Minecraft"
        Me.rbtMinecraft.UseVisualStyleBackColor = True
        '
        'rbtMario
        '
        Me.rbtMario.AutoSize = True
        Me.rbtMario.Location = New System.Drawing.Point(29, 44)
        Me.rbtMario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtMario.Name = "rbtMario"
        Me.rbtMario.Size = New System.Drawing.Size(62, 20)
        Me.rbtMario.TabIndex = 10
        Me.rbtMario.TabStop = True
        Me.rbtMario.Text = "Mario"
        Me.rbtMario.UseVisualStyleBackColor = True
        '
        'pnlTheme
        '
        Me.pnlTheme.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlTheme.Controls.Add(Me.rbtDragonBall)
        Me.pnlTheme.Controls.Add(Me.rbtSonic)
        Me.pnlTheme.Controls.Add(Me.rbtMinecraft)
        Me.pnlTheme.Controls.Add(Me.rbtMario)
        Me.pnlTheme.Location = New System.Drawing.Point(28, 39)
        Me.pnlTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTheme.Name = "pnlTheme"
        Me.pnlTheme.Size = New System.Drawing.Size(175, 143)
        Me.pnlTheme.TabIndex = 11
        '
        'rbtDragonBall
        '
        Me.rbtDragonBall.AutoSize = True
        Me.rbtDragonBall.Location = New System.Drawing.Point(29, 16)
        Me.rbtDragonBall.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtDragonBall.Name = "rbtDragonBall"
        Me.rbtDragonBall.Size = New System.Drawing.Size(99, 20)
        Me.rbtDragonBall.TabIndex = 15
        Me.rbtDragonBall.TabStop = True
        Me.rbtDragonBall.Text = "Dragon Ball"
        Me.rbtDragonBall.UseVisualStyleBackColor = True
        '
        'rbtSonic
        '
        Me.rbtSonic.AutoSize = True
        Me.rbtSonic.Location = New System.Drawing.Point(29, 101)
        Me.rbtSonic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtSonic.Name = "rbtSonic"
        Me.rbtSonic.Size = New System.Drawing.Size(62, 20)
        Me.rbtSonic.TabIndex = 15
        Me.rbtSonic.TabStop = True
        Me.rbtSonic.Text = "Sonic"
        Me.rbtSonic.UseVisualStyleBackColor = True
        '
        'pnlThemeSombre
        '
        Me.pnlThemeSombre.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlThemeSombre.Controls.Add(Me.rbtClair)
        Me.pnlThemeSombre.Controls.Add(Me.rbtDark)
        Me.pnlThemeSombre.Location = New System.Drawing.Point(267, 39)
        Me.pnlThemeSombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlThemeSombre.Name = "pnlThemeSombre"
        Me.pnlThemeSombre.Size = New System.Drawing.Size(188, 143)
        Me.pnlThemeSombre.TabIndex = 12
        '
        'rbtClair
        '
        Me.rbtClair.AutoSize = True
        Me.rbtClair.Location = New System.Drawing.Point(11, 27)
        Me.rbtClair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtClair.Name = "rbtClair"
        Me.rbtClair.Size = New System.Drawing.Size(116, 20)
        Me.rbtClair.TabIndex = 14
        Me.rbtClair.TabStop = True
        Me.rbtClair.Text = "Principal (clair)"
        Me.rbtClair.UseVisualStyleBackColor = True
        '
        'rbtDark
        '
        Me.rbtDark.AutoSize = True
        Me.rbtDark.Location = New System.Drawing.Point(11, 75)
        Me.rbtDark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtDark.Name = "rbtDark"
        Me.rbtDark.Size = New System.Drawing.Size(157, 20)
        Me.rbtDark.TabIndex = 0
        Me.rbtDark.TabStop = True
        Me.rbtDark.Text = "Cave (mode Sombre)"
        Me.rbtDark.UseVisualStyleBackColor = True
        '
        'grpBoxTheme
        '
        Me.grpBoxTheme.Controls.Add(Me.pnlThemeSombre)
        Me.grpBoxTheme.Controls.Add(Me.pnlTheme)
        Me.grpBoxTheme.Location = New System.Drawing.Point(45, 138)
        Me.grpBoxTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBoxTheme.Name = "grpBoxTheme"
        Me.grpBoxTheme.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpBoxTheme.Size = New System.Drawing.Size(485, 217)
        Me.grpBoxTheme.TabIndex = 13
        Me.grpBoxTheme.TabStop = False
        Me.grpBoxTheme.Text = "Thème"
        '
        'pnlSon
        '
        Me.pnlSon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlSon.Controls.Add(Me.rbtVolumeOff)
        Me.pnlSon.Controls.Add(Me.rbtVolumeOn)
        Me.pnlSon.Location = New System.Drawing.Point(769, 204)
        Me.pnlSon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSon.Name = "pnlSon"
        Me.pnlSon.Size = New System.Drawing.Size(267, 134)
        Me.pnlSon.TabIndex = 14
        '
        'rbtVolumeOff
        '
        Me.rbtVolumeOff.AutoSize = True
        Me.rbtVolumeOff.Location = New System.Drawing.Point(67, 79)
        Me.rbtVolumeOff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtVolumeOff.Name = "rbtVolumeOff"
        Me.rbtVolumeOff.Size = New System.Drawing.Size(89, 20)
        Me.rbtVolumeOff.TabIndex = 16
        Me.rbtVolumeOff.Text = "Désactivé"
        Me.rbtVolumeOff.UseVisualStyleBackColor = True
        '
        'rbtVolumeOn
        '
        Me.rbtVolumeOn.AutoSize = True
        Me.rbtVolumeOn.Location = New System.Drawing.Point(67, 31)
        Me.rbtVolumeOn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtVolumeOn.Name = "rbtVolumeOn"
        Me.rbtVolumeOn.Size = New System.Drawing.Size(65, 20)
        Me.rbtVolumeOn.TabIndex = 15
        Me.rbtVolumeOn.Text = "Activé"
        Me.rbtVolumeOn.UseVisualStyleBackColor = True
        '
        'LabelMusic
        '
        Me.LabelMusic.AutoSize = True
        Me.LabelMusic.Location = New System.Drawing.Point(765, 185)
        Me.LabelMusic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMusic.Name = "LabelMusic"
        Me.LabelMusic.Size = New System.Drawing.Size(112, 16)
        Me.LabelMusic.TabIndex = 15
        Me.LabelMusic.Text = "MUSIC EN FOND"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.LabelMusic)
        Me.Controls.Add(Me.pnlSon)
        Me.Controls.Add(Me.grpBoxTheme)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblTimeActuel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scrollTime)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.pnlTheme.ResumeLayout(False)
        Me.pnlTheme.PerformLayout()
        Me.pnlThemeSombre.ResumeLayout(False)
        Me.pnlThemeSombre.PerformLayout()
        Me.grpBoxTheme.ResumeLayout(False)
        Me.pnlSon.ResumeLayout(False)
        Me.pnlSon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scrollTime As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTimeActuel As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtMinecraft As RadioButton
    Friend WithEvents rbtMario As RadioButton
    Friend WithEvents pnlTheme As Panel
    Friend WithEvents pnlThemeSombre As Panel
    Friend WithEvents rbtDark As RadioButton
    Friend WithEvents rbtClair As RadioButton
    Friend WithEvents grpBoxTheme As GroupBox
    Friend WithEvents pnlSon As Panel
    Friend WithEvents rbtVolumeOff As RadioButton
    Friend WithEvents rbtVolumeOn As RadioButton
    Friend WithEvents rbtSonic As RadioButton
    Friend WithEvents rbtDragonBall As RadioButton
    Friend WithEvents LabelMusic As Label
End Class
