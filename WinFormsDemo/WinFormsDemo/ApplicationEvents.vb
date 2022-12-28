Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            Debug.WriteLine("StartupNextInstance event raised.")

            Dim m_TestForm As New Form With {.MdiParent = Form1, .Text = "TestForm 2"}
            m_TestForm.Show()
            m_TestForm.Location = New Point(50, 50)

            Debug.WriteLine("StartupNextInstance event finished.")

        End Sub

    End Class

End Namespace
