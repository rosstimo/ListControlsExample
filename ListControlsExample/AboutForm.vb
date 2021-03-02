Option Strict On
Option Explicit On

Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AboutLabel.Text = "List Control Example" & vbNewLine _
                        & "Acme Computer Products LLC." & vbNewLine _
                        & "Tim Rossiter" & vbNewLine _
                        & "Copyright 2021" & vbNewLine

    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        ListControlsExampleForm.Show()
        Me.Close()
    End Sub

    Private Sub SayHello()
        MsgBox("Hello")
    End Sub

End Class