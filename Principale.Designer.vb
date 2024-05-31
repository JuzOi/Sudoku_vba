<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principale))
        Me.boxNom = New System.Windows.Forms.ComboBox()
        Me.btnLancer = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGrille4 = New System.Windows.Forms.Button()
        Me.btnGrille3 = New System.Windows.Forms.Button()
        Me.btnRegle = New System.Windows.Forms.Button()
        Me.btnFacile = New System.Windows.Forms.RadioButton()
        Me.btnMoyen = New System.Windows.Forms.RadioButton()
        Me.btnDifficile = New System.Windows.Forms.RadioButton()
        Me.pnlNiveau = New System.Windows.Forms.Panel()
        Me.pnlSelection = New System.Windows.Forms.Panel()
        Me.btnCommencer = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlNiveau.SuspendLayout()
        Me.pnlSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxNom
        '
        Me.boxNom.BackColor = System.Drawing.Color.Black
        Me.boxNom.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxNom.ForeColor = System.Drawing.Color.White
        Me.boxNom.FormattingEnabled = True
        Me.boxNom.Location = New System.Drawing.Point(25, 19)
        Me.boxNom.Name = "boxNom"
        Me.boxNom.Size = New System.Drawing.Size(209, 41)
        Me.boxNom.TabIndex = 0
        '
        'btnLancer
        '
        Me.btnLancer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLancer.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancer.ForeColor = System.Drawing.Color.White
        Me.btnLancer.Image = CType(resources.GetObject("btnLancer.Image"), System.Drawing.Image)
        Me.btnLancer.Location = New System.Drawing.Point(25, 79)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(207, 37)
        Me.btnLancer.TabIndex = 1
        Me.btnLancer.Text = "Nouvelle Partie"
        Me.btnLancer.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitter.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Location = New System.Drawing.Point(42, 290)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(168, 46)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.Font = New System.Drawing.Font("Mistral", 42.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Transparent
        Me.lblTitre.Location = New System.Drawing.Point(449, 20)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(192, 67)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "SUDOKU"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(42, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Classement"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGrille4
        '
        Me.btnGrille4.BackColor = System.Drawing.Color.Transparent
        Me.btnGrille4.BackgroundImage = CType(resources.GetObject("btnGrille4.BackgroundImage"), System.Drawing.Image)
        Me.btnGrille4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrille4.Location = New System.Drawing.Point(103, 13)
        Me.btnGrille4.Name = "btnGrille4"
        Me.btnGrille4.Size = New System.Drawing.Size(73, 57)
        Me.btnGrille4.TabIndex = 7
        Me.btnGrille4.UseVisualStyleBackColor = False
        '
        'btnGrille3
        '
        Me.btnGrille3.BackColor = System.Drawing.Color.Transparent
        Me.btnGrille3.BackgroundImage = CType(resources.GetObject("btnGrille3.BackgroundImage"), System.Drawing.Image)
        Me.btnGrille3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrille3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnGrille3.Location = New System.Drawing.Point(9, 13)
        Me.btnGrille3.Name = "btnGrille3"
        Me.btnGrille3.Size = New System.Drawing.Size(68, 57)
        Me.btnGrille3.TabIndex = 8
        Me.btnGrille3.UseVisualStyleBackColor = False
        '
        'btnRegle
        '
        Me.btnRegle.BackgroundImage = CType(resources.GetObject("btnRegle.BackgroundImage"), System.Drawing.Image)
        Me.btnRegle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegle.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegle.ForeColor = System.Drawing.Color.White
        Me.btnRegle.Location = New System.Drawing.Point(42, 183)
        Me.btnRegle.Name = "btnRegle"
        Me.btnRegle.Size = New System.Drawing.Size(168, 46)
        Me.btnRegle.TabIndex = 9
        Me.btnRegle.Text = "Règle"
        Me.btnRegle.UseVisualStyleBackColor = True
        '
        'btnFacile
        '
        Me.btnFacile.AutoSize = True
        Me.btnFacile.BackColor = System.Drawing.Color.Transparent
        Me.btnFacile.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacile.ForeColor = System.Drawing.Color.White
        Me.btnFacile.Location = New System.Drawing.Point(42, 151)
        Me.btnFacile.Name = "btnFacile"
        Me.btnFacile.Size = New System.Drawing.Size(84, 37)
        Me.btnFacile.TabIndex = 10
        Me.btnFacile.TabStop = True
        Me.btnFacile.Text = "Facile"
        Me.btnFacile.UseVisualStyleBackColor = False
        '
        'btnMoyen
        '
        Me.btnMoyen.AutoSize = True
        Me.btnMoyen.BackColor = System.Drawing.Color.Transparent
        Me.btnMoyen.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoyen.ForeColor = System.Drawing.Color.White
        Me.btnMoyen.Location = New System.Drawing.Point(42, 183)
        Me.btnMoyen.Name = "btnMoyen"
        Me.btnMoyen.Size = New System.Drawing.Size(90, 37)
        Me.btnMoyen.TabIndex = 11
        Me.btnMoyen.TabStop = True
        Me.btnMoyen.Text = "Moyen"
        Me.btnMoyen.UseVisualStyleBackColor = False
        '
        'btnDifficile
        '
        Me.btnDifficile.AutoSize = True
        Me.btnDifficile.BackColor = System.Drawing.Color.Transparent
        Me.btnDifficile.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifficile.ForeColor = System.Drawing.Color.White
        Me.btnDifficile.Location = New System.Drawing.Point(42, 214)
        Me.btnDifficile.Name = "btnDifficile"
        Me.btnDifficile.Size = New System.Drawing.Size(104, 37)
        Me.btnDifficile.TabIndex = 12
        Me.btnDifficile.TabStop = True
        Me.btnDifficile.Text = "Difficile"
        Me.btnDifficile.UseVisualStyleBackColor = False
        '
        'pnlNiveau
        '
        Me.pnlNiveau.BackColor = System.Drawing.Color.Transparent
        Me.pnlNiveau.Controls.Add(Me.Label2)
        Me.pnlNiveau.Controls.Add(Me.Label1)
        Me.pnlNiveau.Controls.Add(Me.btnDifficile)
        Me.pnlNiveau.Controls.Add(Me.btnMoyen)
        Me.pnlNiveau.Controls.Add(Me.btnFacile)
        Me.pnlNiveau.Controls.Add(Me.btnGrille4)
        Me.pnlNiveau.Controls.Add(Me.btnGrille3)
        Me.pnlNiveau.Location = New System.Drawing.Point(448, 177)
        Me.pnlNiveau.Name = "pnlNiveau"
        Me.pnlNiveau.Size = New System.Drawing.Size(193, 268)
        Me.pnlNiveau.TabIndex = 13
        '
        'pnlSelection
        '
        Me.pnlSelection.BackColor = System.Drawing.Color.Transparent
        Me.pnlSelection.Controls.Add(Me.btnOptions)
        Me.pnlSelection.Controls.Add(Me.btnRegle)
        Me.pnlSelection.Controls.Add(Me.Button1)
        Me.pnlSelection.Controls.Add(Me.btnQuitter)
        Me.pnlSelection.Controls.Add(Me.btnLancer)
        Me.pnlSelection.Controls.Add(Me.boxNom)
        Me.pnlSelection.Location = New System.Drawing.Point(419, 167)
        Me.pnlSelection.Name = "pnlSelection"
        Me.pnlSelection.Size = New System.Drawing.Size(245, 348)
        Me.pnlSelection.TabIndex = 14
        '
        'btnCommencer
        '
        Me.btnCommencer.BackColor = System.Drawing.Color.Transparent
        Me.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCommencer.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommencer.ForeColor = System.Drawing.Color.White
        Me.btnCommencer.Image = CType(resources.GetObject("btnCommencer.Image"), System.Drawing.Image)
        Me.btnCommencer.Location = New System.Drawing.Point(808, 478)
        Me.btnCommencer.Name = "btnCommencer"
        Me.btnCommencer.Size = New System.Drawing.Size(127, 37)
        Me.btnCommencer.TabIndex = 10
        Me.btnCommencer.Text = "Commencer"
        Me.btnCommencer.UseVisualStyleBackColor = False
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.Transparent
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRetour.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(148, 469)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(90, 46)
        Me.btnRetour.TabIndex = 10
        Me.btnRetour.Text = "←"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackgroundImage = CType(resources.GetObject("btnOptions.BackgroundImage"), System.Drawing.Image)
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOptions.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.White
        Me.btnOptions.Location = New System.Drawing.Point(42, 131)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(168, 46)
        Me.btnOptions.TabIndex = 10
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "3 x 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(116, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "4 x 4"
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1083, 639)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnCommencer)
        Me.Controls.Add(Me.pnlNiveau)
        Me.Controls.Add(Me.pnlSelection)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "Principale"
        Me.Text = "Principale"
        Me.pnlNiveau.ResumeLayout(False)
        Me.pnlNiveau.PerformLayout()
        Me.pnlSelection.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boxNom As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGrille4 As Button
    Friend WithEvents btnGrille3 As Button
    Friend WithEvents btnRegle As Button
    Friend WithEvents btnFacile As RadioButton
    Friend WithEvents btnMoyen As RadioButton
    Friend WithEvents btnDifficile As RadioButton
    Friend WithEvents pnlNiveau As Panel
    Friend WithEvents pnlSelection As Panel
    Friend WithEvents btnCommencer As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
