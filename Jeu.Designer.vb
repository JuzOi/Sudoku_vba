<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.monTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pnlGrille = New System.Windows.Forms.Panel()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnRegenerer = New System.Windows.Forms.Button()
        Me.btnSolution = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Mistral", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(12, 129)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(0, 44)
        Me.lblNom.TabIndex = 1
        '
        'monTimer
        '
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(14, 209)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 42)
        Me.lblTimer.TabIndex = 2
        '
        'pnlGrille
        '
        Me.pnlGrille.Location = New System.Drawing.Point(268, 129)
        Me.pnlGrille.Name = "pnlGrille"
        Me.pnlGrille.Size = New System.Drawing.Size(353, 314)
        Me.pnlGrille.TabIndex = 3
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Mistral", 42.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(269, 24)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(192, 67)
        Me.lblTitre.TabIndex = 4
        Me.lblTitre.Text = "SUDOKU"
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(18, 546)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(75, 55)
        Me.btnRetour.TabIndex = 5
        Me.btnRetour.Text = "←"
        Me.btnRetour.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnRegenerer
        '
        Me.btnRegenerer.Location = New System.Drawing.Point(587, 540)
        Me.btnRegenerer.Name = "btnRegenerer"
        Me.btnRegenerer.Size = New System.Drawing.Size(75, 23)
        Me.btnRegenerer.TabIndex = 6
        Me.btnRegenerer.Text = "regénérer"
        Me.btnRegenerer.UseVisualStyleBackColor = True
        '
        'btnSolution
        '
        Me.btnSolution.Location = New System.Drawing.Point(482, 540)
        Me.btnSolution.Name = "btnSolution"
        Me.btnSolution.Size = New System.Drawing.Size(75, 23)
        Me.btnSolution.TabIndex = 7
        Me.btnSolution.Text = "solution"
        Me.btnSolution.UseVisualStyleBackColor = True
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 613)
        Me.Controls.Add(Me.btnSolution)
        Me.Controls.Add(Me.btnRegenerer)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.pnlGrille)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Jeu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNom As Label
    Friend WithEvents monTimer As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents pnlGrille As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnRegenerer As Button
    Friend WithEvents btnSolution As Button
End Class
