Public Class Form1

    Protected Overrides Sub OnLoad(e As EventArgs)

        MyBase.OnLoad(e)
        Dim m_TestForm As New Form With {.MdiParent = Me, .Text = "TestForm 1"}
        m_TestForm.Show()
        m_TestForm.Location = New Point(10, 10)

    End Sub

End Class
