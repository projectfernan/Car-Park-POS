Public Class frmD8Test

    Private Sub frmD8Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInit.Click
        If d8_conn() = True Then
            saveAudiUpdate(str_SysUser, str_SysPosi, "Test d8 initialized succeed")

            MsgBox("Initialize succefully!    ", vbInformation, "Initilize")
        Else
            saveAudiUpdate(str_SysUser, str_SysPosi, "Test d8 initialized failed")

            MsgBox("Initialize Failed!    ", vbExclamation, "Initilize")
        End If
    End Sub

    Private Sub cmdBeep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBeep.Click
        d8_Beep()
        saveAudiUpdate(str_SysUser, str_SysPosi, "Test d8 beep")
    End Sub

    Private Sub cmdDetect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetect.Click
        If d8_Card() = True Then
            saveAudiUpdate(str_SysUser, str_SysPosi, "Test d8 card detected")
            MsgBox("Card detected!    ", vbInformation, "Detect")
        Else
            saveAudiUpdate(str_SysUser, str_SysPosi, "Test d8 card not detected")
            MsgBox("No card!    ", vbExclamation, "Detect")
        End If
    End Sub
End Class