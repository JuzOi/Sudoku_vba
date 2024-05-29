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
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lstClassement = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(342, 374)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(152, 43)
        Me.btnRetour.TabIndex = 0
        Me.btnRetour.Text = "retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'lstClassement
        '
        Me.lstClassement.FormattingEnabled = True
        Me.lstClassement.Location = New System.Drawing.Point(12, 36)
        Me.lstClassement.Name = "lstClassement"
        Me.lstClassement.Size = New System.Drawing.Size(282, 381)
        Me.lstClassement.TabIndex = 1
        '
        'Classement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 450)
        Me.Controls.Add(Me.lstClassement)
        Me.Controls.Add(Me.btnRetour)
        Me.Name = "Classement"
        Me.Text = "Classement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRetour As Button
    Friend WithEvents lstClassement As ListBox
End Class
