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
        Me.pnlThemeSombre = New System.Windows.Forms.Panel()
        Me.rbtClair = New System.Windows.Forms.RadioButton()
        Me.rbtSombre = New System.Windows.Forms.RadioButton()
        Me.grpBoxTheme = New System.Windows.Forms.GroupBox()
        Me.pnlSon = New System.Windows.Forms.Panel()
        Me.rbtVolumeOff = New System.Windows.Forms.RadioButton()
        Me.rbtVolumeOn = New System.Windows.Forms.RadioButton()
        Me.pnlTheme.SuspendLayout()
        Me.pnlThemeSombre.SuspendLayout()
        Me.grpBoxTheme.SuspendLayout()
        Me.pnlSon.SuspendLayout()
        Me.SuspendLayout()
        '
        'scrollTime
        '
        Me.scrollTime.Location = New System.Drawing.Point(15, 35)
        Me.scrollTime.Name = "scrollTime"
        Me.scrollTime.Size = New System.Drawing.Size(481, 30)
        Me.scrollTime.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "60:00"
        '
        'lblTimeActuel
        '
        Me.lblTimeActuel.AutoSize = True
        Me.lblTimeActuel.Location = New System.Drawing.Point(657, 35)
        Me.lblTimeActuel.Name = "lblTimeActuel"
        Me.lblTimeActuel.Size = New System.Drawing.Size(0, 13)
        Me.lblTimeActuel.TabIndex = 3
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(34, 368)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(75, 55)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "←"
        Me.btnRetour.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(574, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temps actuel :"
        '
        'rbtMinecraft
        '
        Me.rbtMinecraft.AutoSize = True
        Me.rbtMinecraft.Location = New System.Drawing.Point(21, 37)
        Me.rbtMinecraft.Name = "rbtMinecraft"
        Me.rbtMinecraft.Size = New System.Drawing.Size(69, 17)
        Me.rbtMinecraft.TabIndex = 9
        Me.rbtMinecraft.TabStop = True
        Me.rbtMinecraft.Text = "Minecraft"
        Me.rbtMinecraft.UseVisualStyleBackColor = True
        '
        'rbtMario
        '
        Me.rbtMario.AutoSize = True
        Me.rbtMario.Location = New System.Drawing.Point(21, 100)
        Me.rbtMario.Name = "rbtMario"
        Me.rbtMario.Size = New System.Drawing.Size(51, 17)
        Me.rbtMario.TabIndex = 10
        Me.rbtMario.TabStop = True
        Me.rbtMario.Text = "Mario"
        Me.rbtMario.UseVisualStyleBackColor = True
        '
        'pnlTheme
        '
        Me.pnlTheme.Controls.Add(Me.rbtMinecraft)
        Me.pnlTheme.Controls.Add(Me.rbtMario)
        Me.pnlTheme.Location = New System.Drawing.Point(5, 19)
        Me.pnlTheme.Name = "pnlTheme"
        Me.pnlTheme.Size = New System.Drawing.Size(131, 147)
        Me.pnlTheme.TabIndex = 11
        '
        'pnlThemeSombre
        '
        Me.pnlThemeSombre.Controls.Add(Me.rbtClair)
        Me.pnlThemeSombre.Controls.Add(Me.rbtSombre)
        Me.pnlThemeSombre.Location = New System.Drawing.Point(200, 32)
        Me.pnlThemeSombre.Name = "pnlThemeSombre"
        Me.pnlThemeSombre.Size = New System.Drawing.Size(141, 104)
        Me.pnlThemeSombre.TabIndex = 12
        '
        'rbtClair
        '
        Me.rbtClair.AutoSize = True
        Me.rbtClair.Location = New System.Drawing.Point(8, 23)
        Me.rbtClair.Name = "rbtClair"
        Me.rbtClair.Size = New System.Drawing.Size(99, 17)
        Me.rbtClair.TabIndex = 14
        Me.rbtClair.TabStop = True
        Me.rbtClair.Text = "Principale (clair)"
        Me.rbtClair.UseVisualStyleBackColor = True
        '
        'rbtSombre
        '
        Me.rbtSombre.AutoSize = True
        Me.rbtSombre.Location = New System.Drawing.Point(8, 60)
        Me.rbtSombre.Name = "rbtSombre"
        Me.rbtSombre.Size = New System.Drawing.Size(124, 17)
        Me.rbtSombre.TabIndex = 0
        Me.rbtSombre.TabStop = True
        Me.rbtSombre.Text = "Cave (mode Sombre)"
        Me.rbtSombre.UseVisualStyleBackColor = True
        '
        'grpBoxTheme
        '
        Me.grpBoxTheme.Controls.Add(Me.pnlThemeSombre)
        Me.grpBoxTheme.Controls.Add(Me.pnlTheme)
        Me.grpBoxTheme.Location = New System.Drawing.Point(29, 112)
        Me.grpBoxTheme.Name = "grpBoxTheme"
        Me.grpBoxTheme.Size = New System.Drawing.Size(364, 192)
        Me.grpBoxTheme.TabIndex = 13
        Me.grpBoxTheme.TabStop = False
        Me.grpBoxTheme.Text = "Thème"
        '
        'pnlSon
        '
        Me.pnlSon.Controls.Add(Me.rbtVolumeOff)
        Me.pnlSon.Controls.Add(Me.rbtVolumeOn)
        Me.pnlSon.Location = New System.Drawing.Point(566, 246)
        Me.pnlSon.Name = "pnlSon"
        Me.pnlSon.Size = New System.Drawing.Size(200, 109)
        Me.pnlSon.TabIndex = 14
        '
        'rbtVolumeOff
        '
        Me.rbtVolumeOff.AutoSize = True
        Me.rbtVolumeOff.Location = New System.Drawing.Point(50, 64)
        Me.rbtVolumeOff.Name = "rbtVolumeOff"
        Me.rbtVolumeOff.Size = New System.Drawing.Size(73, 17)
        Me.rbtVolumeOff.TabIndex = 16
        Me.rbtVolumeOff.TabStop = True
        Me.rbtVolumeOff.Text = "Désactivé"
        Me.rbtVolumeOff.UseVisualStyleBackColor = True
        '
        'rbtVolumeOn
        '
        Me.rbtVolumeOn.AutoSize = True
        Me.rbtVolumeOn.Location = New System.Drawing.Point(50, 25)
        Me.rbtVolumeOn.Name = "rbtVolumeOn"
        Me.rbtVolumeOn.Size = New System.Drawing.Size(55, 17)
        Me.rbtVolumeOn.TabIndex = 15
        Me.rbtVolumeOn.TabStop = True
        Me.rbtVolumeOn.Text = "Activé"
        Me.rbtVolumeOn.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlSon)
        Me.Controls.Add(Me.grpBoxTheme)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblTimeActuel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scrollTime)
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
    Friend WithEvents rbtSombre As RadioButton
    Friend WithEvents rbtClair As RadioButton
    Friend WithEvents grpBoxTheme As GroupBox
    Friend WithEvents pnlSon As Panel
    Friend WithEvents rbtVolumeOff As RadioButton
    Friend WithEvents rbtVolumeOn As RadioButton
End Class
