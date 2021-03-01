Public Class ListControlsExampleForm


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click,
                                                                           ExitContextMenuItem.Click,
                                                                           ExitTopMenuStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click,
                                                                         GoContextMenuItem.Click,
                                                                         GoTopMenuStripMenuItem.Click

        NamesComboBox.Items.Add(InputTextBox.Text)
        NamesListBox.Items.Add(InputTextBox.Text)
        NamesComboBox.Sorted = True
        NamesListBox.Sorted = True
        NamesComboBox.SelectedIndex = NamesComboBox.Items.IndexOf(InputTextBox.Text)
        InputTextBox.Text = ""
    End Sub

    Private Sub NamesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamesComboBox.SelectedIndexChanged
        Me.Text = CStr(NamesComboBox.SelectedIndex)
        NamesListBox.SelectedIndex = NamesComboBox.SelectedIndex
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click,
                                                                                       ClearTopMenuStripMenuItem1.Click
        NamesComboBox.Items.Clear()
        NamesListBox.Items.Clear()
    End Sub


End Class
