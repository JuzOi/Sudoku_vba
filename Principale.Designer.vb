﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.SuspendLayout()
        '
        'boxNom
        '
        Me.boxNom.BackColor = System.Drawing.Color.Black
        Me.boxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxNom.ForeColor = System.Drawing.Color.White
        Me.boxNom.FormattingEnabled = True
        Me.boxNom.Location = New System.Drawing.Point(170, 160)
        Me.boxNom.Name = "boxNom"
        Me.boxNom.Size = New System.Drawing.Size(209, 28)
        Me.boxNom.TabIndex = 0
        '
        'btnLancer
        '
        Me.btnLancer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancer.ForeColor = System.Drawing.Color.White
        Me.btnLancer.Image = CType(resources.GetObject("btnLancer.Image"), System.Drawing.Image)
        Me.btnLancer.Location = New System.Drawing.Point(170, 226)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(207, 33)
        Me.btnLancer.TabIndex = 1
        Me.btnLancer.Text = "Nouvelle Partie"
        Me.btnLancer.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.BackgroundImage = CType(resources.GetObject("btnQuitter.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.White
        Me.btnQuitter.Location = New System.Drawing.Point(187, 366)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(168, 46)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Black
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(284, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(265, 64)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "SUDOKU"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(187, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Classement"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGrille4
        '
        Me.btnGrille4.BackgroundImage = CType(resources.GetObject("btnGrille4.BackgroundImage"), System.Drawing.Image)
        Me.btnGrille4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrille4.Location = New System.Drawing.Point(566, 146)
        Me.btnGrille4.Name = "btnGrille4"
        Me.btnGrille4.Size = New System.Drawing.Size(73, 57)
        Me.btnGrille4.TabIndex = 7
        Me.btnGrille4.UseVisualStyleBackColor = True
        '
        'btnGrille3
        '
        Me.btnGrille3.BackgroundImage = CType(resources.GetObject("btnGrille3.BackgroundImage"), System.Drawing.Image)
        Me.btnGrille3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrille3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnGrille3.Location = New System.Drawing.Point(669, 146)
        Me.btnGrille3.Name = "btnGrille3"
        Me.btnGrille3.Size = New System.Drawing.Size(68, 57)
        Me.btnGrille3.TabIndex = 8
        Me.btnGrille3.UseVisualStyleBackColor = True
        '
        'btnRegle
        '
        Me.btnRegle.BackgroundImage = CType(resources.GetObject("btnRegle.BackgroundImage"), System.Drawing.Image)
        Me.btnRegle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegle.ForeColor = System.Drawing.Color.White
        Me.btnRegle.Location = New System.Drawing.Point(187, 265)
        Me.btnRegle.Name = "btnRegle"
        Me.btnRegle.Size = New System.Drawing.Size(168, 46)
        Me.btnRegle.TabIndex = 9
        Me.btnRegle.Text = "Règle"
        Me.btnRegle.UseVisualStyleBackColor = True
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(901, 511)
        Me.Controls.Add(Me.btnRegle)
        Me.Controls.Add(Me.btnGrille3)
        Me.Controls.Add(Me.btnGrille4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnLancer)
        Me.Controls.Add(Me.boxNom)
        Me.Name = "Principale"
        Me.Text = "Principale"
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
End Class
