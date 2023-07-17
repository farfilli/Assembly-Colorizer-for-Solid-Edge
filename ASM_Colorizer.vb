Public Class ASM_Colorizer

    Dim Styles As New List(Of SolidEdgeFramework.FaceStyle)
    Dim StyleDB As New Collection

    Private Sub BT_Colorize_Click(sender As Object, e As EventArgs) Handles BT_Colorize.Click

        Styles.Clear()
        StyleDB.Clear()

        Dim objApp As SolidEdgeFramework.Application
        Dim objAsm As SolidEdgeAssembly.AssemblyDocument

        Try
            objApp = GetObject(, "SolidEdge.Application")
            objAsm = objApp.ActiveDocument

        Catch ex As Exception
            End
        End Try

        PB.Maximum = objAsm.Occurrences.Count
        PB.Step = 1

        objApp.DelayCompute = True

        Colorize(objAsm)

        objApp.DelayCompute = False

    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Colorize(objAsm As SolidEdgeAssembly.AssemblyDocument, Optional SubOcc As SolidEdgeAssembly.SubOccurrences = Nothing)

        If IsNothing(SubOcc) Then

            For Each tmpOcc As SolidEdgeAssembly.Occurrence In objAsm.Occurrences

                If Not tmpOcc.Subassembly Or CB_SubOccurrences.Checked Then

                    PB.PerformStep()

                    tmpOcc.FaceStyle = ChooseStyle(tmpOcc.OccurrenceFileName, objAsm)

                Else

                    Colorize(objAsm, tmpOcc.SubOccurrences)

                End If

            Next

        Else

            For Each tmpSubOcc As SolidEdgeAssembly.SubOccurrence In SubOcc

                If Not tmpSubOcc.Subassembly Or CB_SubOccurrences.Checked Then

                    PB.PerformStep()

                    tmpSubOcc.FaceStyle = ChooseStyle(tmpSubOcc.SubOccurrenceFileName, objAsm)

                Else

                    Colorize(objAsm, tmpSubOcc.SubOccurrences)

                End If

            Next

        End If

    End Sub

    Private Function ChooseStyle(Name As String, objAsm As SolidEdgeAssembly.AssemblyDocument) As SolidEdgeFramework.FaceStyle

        If StyleDB.Contains(Name) And CB_SameColor.Checked Then Return StyleDB.Item(Name)

        If Styles.Count = 0 Then

            Dim tmpStyles As SolidEdgeFramework.FaceStyles = objAsm.FaceStyles
            For Each tmpStyle As SolidEdgeFramework.FaceStyle In tmpStyles
                Dim skip As Boolean = False
                For Each item In Split(SkipTXT.Text, ",")
                    If tmpStyle.StyleName.ToString.ToUpper.Contains(item.ToUpper) And item <> "" Then skip = True : Exit For
                Next
                If Not skip Then Styles.Add(tmpStyle)
            Next

        End If

        Dim r As Integer = GetRandom(0, Styles.Count - 1)
        Dim n As SolidEdgeFramework.FaceStyle = Styles.Item(r)

        Styles.RemoveAt(r)
        StyleDB.Add(n, Name)

        Return n

    End Function

End Class
