<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_Inv_Adv
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
        Me.b_Validate = New System.Windows.Forms.Button
        Me.b_Cancel = New System.Windows.Forms.Button
        Me.lb_Items = New System.Windows.Forms.ListBox
        Me.b_Modify = New System.Windows.Forms.Button
        Me.cb_ItemList = New System.Windows.Forms.ComboBox
        Me.b_Delete = New System.Windows.Forms.Button
        Me.b_Add = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'b_Validate
        '
        Me.b_Validate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_Validate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Validate.Location = New System.Drawing.Point(12, 233)
        Me.b_Validate.Name = "b_Validate"
        Me.b_Validate.Size = New System.Drawing.Size(75, 23)
        Me.b_Validate.TabIndex = 0
        Me.b_Validate.Text = "Validate"
        Me.b_Validate.UseVisualStyleBackColor = True
        '
        'b_Cancel
        '
        Me.b_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_Cancel.Location = New System.Drawing.Point(194, 233)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_Cancel.TabIndex = 1
        Me.b_Cancel.Text = "Cancel"
        Me.b_Cancel.UseVisualStyleBackColor = True
        '
        'lb_Items
        '
        Me.lb_Items.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Items.FormattingEnabled = True
        Me.lb_Items.Location = New System.Drawing.Point(12, 12)
        Me.lb_Items.Name = "lb_Items"
        Me.lb_Items.Size = New System.Drawing.Size(257, 186)
        Me.lb_Items.TabIndex = 2
        '
        'b_Modify
        '
        Me.b_Modify.Location = New System.Drawing.Point(113, 204)
        Me.b_Modify.Name = "b_Modify"
        Me.b_Modify.Size = New System.Drawing.Size(75, 23)
        Me.b_Modify.TabIndex = 3
        Me.b_Modify.Text = "Modify"
        Me.b_Modify.UseVisualStyleBackColor = True
        '
        'cb_ItemList
        '
        Me.cb_ItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ItemList.FormattingEnabled = True
        Me.cb_ItemList.Location = New System.Drawing.Point(12, 205)
        Me.cb_ItemList.Name = "cb_ItemList"
        Me.cb_ItemList.Size = New System.Drawing.Size(95, 21)
        Me.cb_ItemList.TabIndex = 4
        '
        'b_Delete
        '
        Me.b_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Delete.Location = New System.Drawing.Point(194, 204)
        Me.b_Delete.Name = "b_Delete"
        Me.b_Delete.Size = New System.Drawing.Size(75, 23)
        Me.b_Delete.TabIndex = 5
        Me.b_Delete.Text = "Remove"
        Me.b_Delete.UseVisualStyleBackColor = True
        '
        'b_Add
        '
        Me.b_Add.Location = New System.Drawing.Point(113, 233)
        Me.b_Add.Name = "b_Add"
        Me.b_Add.Size = New System.Drawing.Size(75, 23)
        Me.b_Add.TabIndex = 6
        Me.b_Add.Text = "Add"
        Me.b_Add.UseVisualStyleBackColor = True
        '
        'Form2_Inv_Adv
        '
        Me.AcceptButton = Me.b_Validate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.b_Cancel
        Me.ClientSize = New System.Drawing.Size(281, 268)
        Me.Controls.Add(Me.b_Add)
        Me.Controls.Add(Me.b_Delete)
        Me.Controls.Add(Me.cb_ItemList)
        Me.Controls.Add(Me.b_Modify)
        Me.Controls.Add(Me.lb_Items)
        Me.Controls.Add(Me.b_Cancel)
        Me.Controls.Add(Me.b_Validate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2_Inv_Adv"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory - Advanced mode"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents b_Validate As System.Windows.Forms.Button
    Friend WithEvents b_Cancel As System.Windows.Forms.Button
    Friend WithEvents lb_Items As System.Windows.Forms.ListBox
    Friend WithEvents b_Modify As System.Windows.Forms.Button
    Friend WithEvents cb_ItemList As System.Windows.Forms.ComboBox
    Friend WithEvents b_Delete As System.Windows.Forms.Button
    Friend WithEvents b_Add As System.Windows.Forms.Button
End Class
