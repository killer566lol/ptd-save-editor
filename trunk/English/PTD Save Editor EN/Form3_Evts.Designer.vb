<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_Evts
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
        Me.b_DoEvent = New System.Windows.Forms.Button
        Me.lb_Events = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'b_DoEvent
        '
        Me.b_DoEvent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.b_DoEvent.Enabled = False
        Me.b_DoEvent.Location = New System.Drawing.Point(49, 269)
        Me.b_DoEvent.Name = "b_DoEvent"
        Me.b_DoEvent.Size = New System.Drawing.Size(75, 23)
        Me.b_DoEvent.TabIndex = 0
        Me.b_DoEvent.Text = "Do event"
        Me.b_DoEvent.UseVisualStyleBackColor = True
        '
        'lb_Events
        '
        Me.lb_Events.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Events.FormattingEnabled = True
        Me.lb_Events.IntegralHeight = False
        Me.lb_Events.Items.AddRange(New Object() {"Make Starter Shiny", "Get a Shiny Bulbasaur", "Get a Shiny Charmander", "Get a Shiny Squirtle", "Get the Shiny Mew", "Get the Shiny Pikachu", "Get the Shiny Pidgey", "Get the Shiny Geodude", "Get the Shiny Jigglypuff", "Get the Shiny Rattata", "Get Jynx", "Get the Shiny Zubat", "Get the Shiny Abra", "Get the Shiny Charmander", "Get the Shiny Spearow", "Get the Shiny Magikarp", "Get Farfetch'd", "Get the Regular Onix", "Get the Shiny Onix"})
        Me.lb_Events.Location = New System.Drawing.Point(12, 12)
        Me.lb_Events.Name = "lb_Events"
        Me.lb_Events.Size = New System.Drawing.Size(160, 251)
        Me.lb_Events.TabIndex = 1
        '
        'Form3_Evts
        '
        Me.AcceptButton = Me.b_DoEvent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 304)
        Me.Controls.Add(Me.lb_Events)
        Me.Controls.Add(Me.b_DoEvent)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(200, 10000)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 106)
        Me.Name = "Form3_Evts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Events"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents b_DoEvent As System.Windows.Forms.Button
    Friend WithEvents lb_Events As System.Windows.Forms.ListBox
End Class
