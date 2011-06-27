<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_Inv
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
        Me.gb_Items = New System.Windows.Forms.GroupBox
        Me.b_Validate = New System.Windows.Forms.Button
        Me.b_Cancel = New System.Windows.Forms.Button
        Me.b_AdvancedMode = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'gb_Items
        '
        Me.gb_Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Items.Location = New System.Drawing.Point(12, 12)
        Me.gb_Items.Name = "gb_Items"
        Me.gb_Items.Size = New System.Drawing.Size(131, 19)
        Me.gb_Items.TabIndex = 0
        Me.gb_Items.TabStop = False
        Me.gb_Items.Text = "Objets"
        '
        'b_Validate
        '
        Me.b_Validate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.b_Validate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Validate.Location = New System.Drawing.Point(12, 37)
        Me.b_Validate.Name = "b_Validate"
        Me.b_Validate.Size = New System.Drawing.Size(62, 23)
        Me.b_Validate.TabIndex = 5
        Me.b_Validate.Text = "Valider"
        Me.b_Validate.UseVisualStyleBackColor = True
        '
        'b_Cancel
        '
        Me.b_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_Cancel.Location = New System.Drawing.Point(81, 37)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(62, 23)
        Me.b_Cancel.TabIndex = 10
        Me.b_Cancel.Text = "Annuler"
        Me.b_Cancel.UseVisualStyleBackColor = True
        '
        'b_AdvancedMode
        '
        Me.b_AdvancedMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.b_AdvancedMode.Location = New System.Drawing.Point(12, 66)
        Me.b_AdvancedMode.Name = "b_AdvancedMode"
        Me.b_AdvancedMode.Size = New System.Drawing.Size(131, 23)
        Me.b_AdvancedMode.TabIndex = 11
        Me.b_AdvancedMode.Text = "Mode d'édition avancé"
        Me.b_AdvancedMode.UseVisualStyleBackColor = True
        '
        'Form2_Inv
        '
        Me.AcceptButton = Me.b_Validate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.b_Cancel
        Me.ClientSize = New System.Drawing.Size(155, 101)
        Me.Controls.Add(Me.b_AdvancedMode)
        Me.Controls.Add(Me.b_Cancel)
        Me.Controls.Add(Me.b_Validate)
        Me.Controls.Add(Me.gb_Items)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2_Inv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventaire"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Items As System.Windows.Forms.GroupBox
    Friend WithEvents b_Validate As System.Windows.Forms.Button
    Friend WithEvents b_Cancel As System.Windows.Forms.Button
    Friend WithEvents b_AdvancedMode As System.Windows.Forms.Button
End Class
