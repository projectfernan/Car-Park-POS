Module Form_Drag_Move
    Public Structure FormMove
        Public Drag As Boolean
        Public mouseX As Integer
        Public mouseY As Integer
    End Structure

    Dim fm As FormMove

    Public Function Form_Mouse_Down(f As Form, d As Boolean) As FormMove

        fm.Drag = d
        fm.mouseX = Cursor.Position.X - f.Location.X
        fm.mouseY = Cursor.Position.Y - f.Location.Y

        Return fm
    End Function

    Public Function Set_Move_Drag(f As Form)
        If fm.Drag = True Then
            Dim x As Integer
            Dim y As Integer
            x = Cursor.Position.X - fm.mouseX
            y = Cursor.Position.Y - fm.mouseY
            f.Location = New Point(x, y)
        End If
    End Function

End Module
