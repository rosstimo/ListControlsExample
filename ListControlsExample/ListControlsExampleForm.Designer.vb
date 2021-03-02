<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListControlsExampleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NamesComboBox = New System.Windows.Forms.ComboBox()
        Me.NamesListBox = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoTopMenuStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NamesComboBox
        '
        Me.NamesComboBox.FormattingEnabled = True
        Me.NamesComboBox.Location = New System.Drawing.Point(36, 89)
        Me.NamesComboBox.Name = "NamesComboBox"
        Me.NamesComboBox.Size = New System.Drawing.Size(314, 28)
        Me.NamesComboBox.TabIndex = 1
        '
        'NamesListBox
        '
        Me.NamesListBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.NamesListBox.FormattingEnabled = True
        Me.NamesListBox.ItemHeight = 20
        Me.NamesListBox.Location = New System.Drawing.Point(376, 46)
        Me.NamesListBox.Name = "NamesListBox"
        Me.NamesListBox.Size = New System.Drawing.Size(375, 264)
        Me.NamesListBox.TabIndex = 2
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoContextMenuItem, Me.ClearToolStripMenuItem, Me.ExitContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(124, 100)
        '
        'GoContextMenuItem
        '
        Me.GoContextMenuItem.Name = "GoContextMenuItem"
        Me.GoContextMenuItem.Size = New System.Drawing.Size(123, 32)
        Me.GoContextMenuItem.Text = "&Go"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(123, 32)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitContextMenuItem
        '
        Me.ExitContextMenuItem.Name = "ExitContextMenuItem"
        Me.ExitContextMenuItem.Size = New System.Drawing.Size(123, 32)
        Me.ExitContextMenuItem.Text = "E&xit"
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(36, 46)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(314, 26)
        Me.InputTextBox.TabIndex = 0
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(376, 333)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(172, 90)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = "&Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(579, 333)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(172, 90)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(774, 33)
        Me.TopMenuStrip.TabIndex = 5
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoTopMenuStripMenuItem, Me.ExitTopMenuStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'GoTopMenuStripMenuItem
        '
        Me.GoTopMenuStripMenuItem.Name = "GoTopMenuStripMenuItem"
        Me.GoTopMenuStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.GoTopMenuStripMenuItem.Text = "&Go"
        '
        'ExitTopMenuStripMenuItem
        '
        Me.ExitTopMenuStripMenuItem.Name = "ExitTopMenuStripMenuItem"
        Me.ExitTopMenuStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitTopMenuStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearTopMenuStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearTopMenuStripMenuItem1
        '
        Me.ClearTopMenuStripMenuItem1.Name = "ClearTopMenuStripMenuItem1"
        Me.ClearTopMenuStripMenuItem1.Size = New System.Drawing.Size(153, 34)
        Me.ClearTopMenuStripMenuItem1.Text = "&Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutTopMenuStripMenuItem
        '
        Me.AboutTopMenuStripMenuItem.Name = "AboutTopMenuStripMenuItem"
        Me.AboutTopMenuStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AboutTopMenuStripMenuItem.Text = "&About"
        '
        'ListControlsExampleForm
        '
        Me.AcceptButton = Me.GoButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(774, 449)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.NamesListBox)
        Me.Controls.Add(Me.NamesComboBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "ListControlsExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NamesComboBox As ComboBox
    Friend WithEvents NamesListBox As ListBox
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents GoButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents GoContextMenuItem As ToolStripMenuItem
    Friend WithEvents ExitContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoTopMenuStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTopMenuStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutTopMenuStripMenuItem As ToolStripMenuItem
End Class
