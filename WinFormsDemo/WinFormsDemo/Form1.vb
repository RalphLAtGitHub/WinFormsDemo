Imports System.IO
Imports System.Reflection

Public Class Form1

    Protected Overrides Sub OnLoad(e As EventArgs)

        MyBase.OnLoad(e)

        Dim m_Button As New Button With {.Font = New Font(Me.Font, FontStyle.Bold), .Height = 50, .Width = Me.ClientRectangle.Width - 6,
            .Text = "Start 2nd instance"}
        Me.Controls.Add(m_Button)
        m_Button.Location = New Point(Me.ClientRectangle.Right - m_Button.Width - 3, Me.ClientRectangle.Bottom - m_Button.Height - 3)
        AddHandler m_Button.Click, AddressOf ButtonClickHandler

        Dim m_TestForm As New Form With {.MdiParent = Me, .Text = "TestForm 1"}
        m_TestForm.Show()
        m_TestForm.Location = New Point(10, 10)
        m_Button.Select()

    End Sub

    Private Sub ButtonClickHandler(sender As Object, e As EventArgs)

        Process.Start(Application.ExecutablePath)

    End Sub
