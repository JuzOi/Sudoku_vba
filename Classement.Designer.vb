<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classement
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
        Me.lstNom = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnTrieNom = New System.Windows.Forms.Button()
        Me.btnTrieScore = New System.Windows.Forms.Button()
        Me.cmbBoxnom = New System.Windows.Forms.ComboBox()
        Me.btnStatistique = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNom
        '
        Me.lstNom.FormattingEnabled = True
        Me.lstNom.Location = New System.Drawing.Point(12, 36)
        Me.lstNom.Name = "lstNom"
        Me.lstNom.Size = New System.Drawing.Size(158, 381)
        Me.lstNom.TabIndex = 1
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.Location = New System.Drawing.Point(295, 36)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(158, 381)
        Me.lstScore.TabIndex = 2
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Shanghai", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(12, 434)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(75, 55)
        Me.btnRetour.TabIndex = 6
        Me.btnRetour.Text = "←"
        Me.btnRetour.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnTrieNom
        '
        Me.btnTrieNom.Location = New System.Drawing.Point(12, 7)
        Me.btnTrieNom.Name = "btnTrieNom"
        Me.btnTrieNom.Size = New System.Drawing.Size(62, 23)
        Me.btnTrieNom.TabIndex = 7
        Me.btnTrieNom.Text = "Trier"
        Me.btnTrieNom.UseVisualStyleBackColor = True
        '
        'btnTrieScore
        '
        Me.btnTrieScore.Location = New System.Drawing.Point(295, 7)
        Me.btnTrieScore.Name = "btnTrieScore"
        Me.btnTrieScore.Size = New System.Drawing.Size(62, 23)
        Me.btnTrieScore.TabIndex = 8
        Me.btnTrieScore.Text = "Trier"
        Me.btnTrieScore.UseVisualStyleBackColor = True
        '
        'cmbBoxnom
        '
        Me.cmbBoxnom.FormattingEnabled = True
        Me.cmbBoxnom.Location = New System.Drawing.Point(170, 434)
        Me.cmbBoxnom.Name = "cmbBoxnom"
        Me.cmbBoxnom.Size = New System.Drawing.Size(121, 21)
        Me.cmbBoxnom.TabIndex = 9
        '
        'btnStatistique
        '
        Me.btnStatistique.Location = New System.Drawing.Point(409, 445)
        Me.btnStatistique.Name = "btnStatistique"
        Me.btnStatistique.Size = New System.Drawing.Size(103, 33)
        Me.btnStatistique.TabIndex = 10
        Me.btnStatistique.Text = "Statistiques"
        Me.btnStatistique.UseVisualStyleBackColor = True
        '
        'Classement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 501)
        Me.Controls.Add(Me.btnStatistique)
        Me.Controls.Add(Me.cmbBoxnom)
        Me.Controls.Add(Me.btnTrieScore)
        Me.Controls.Add(Me.btnTrieNom)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstNom)
        Me.Name = "Classement"
        Me.Text = "Classement"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstNom As ListBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnTrieNom As Button
    Friend WithEvents btnTrieScore As Button
    Friend WithEvents cmbBoxnom As ComboBox
    Friend WithEvents btnStatistique As Button
End Class
