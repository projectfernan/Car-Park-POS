Option Strict Off
Option Explicit On
Module LED_FUNCTION
    '1.Í¨Ñ¶ÉèÖÃ
    Public Declare Function SetTransMode Lib "ListenPlayDll.dll" (ByVal TransMode As Integer, ByVal ConType As Integer) As Integer
    '2.ÍøÂçÍ¨Ñ¶²ÎÊýÉèÖÃ
    Public Declare Function SetNetworkPara Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal ip As String) As Integer
    '11´®¿ÚÍ¨Ñ¶²ÎÊýÉèÖÃ
    Public Declare Function SetSerialPortPara Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal port As Integer, ByVal baund As Integer) As Integer
    '3.³õÊ¼»¯xml
    Public Declare Sub StartSend Lib "ListenPlayDll.dll" ()
    '4.Ìí¼ÓÏÔÊ¾ÆÁ
    Public Declare Function AddControl Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal DBColor As Integer) As Integer
    '5.Ìí¼Ó½ÚÄ¿
    Public Declare Function AddProgram Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal playTime As Integer) As Integer
    '5.Ìí¼Óµ¥ÐÐÎÄ±¾
    'UPGRADE_NOTE: right ÒÑÉý¼¶µ½ right_Renamed¡£ µ¥»÷ÒÔ»ñµÃ¸ü¶àÐÅÏ¢:¡°ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"¡±
    'UPGRADE_NOTE: left ÒÑÉý¼¶µ½ left_Renamed¡£ µ¥»÷ÒÔ»ñµÃ¸ü¶àÐÅÏ¢:¡°ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"¡±
    Public Declare Function AddLnTxtArea Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal qno As Integer, ByVal left_Renamed As Integer, ByVal top As Integer, ByVal right_Renamed As Integer, ByVal height As Integer, ByVal LnFileName As String, ByVal playstyle As Integer, ByVal playspeed As Integer, ByVal times As Integer) As Integer

    'Í¨¹ý×Ö·û´®Ìí¼ÓÎÄ±¾
    Public Declare Function AddLnTxtString Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal qno As Integer, ByVal left_Renamed As Integer, ByVal top As Integer, ByVal width As Integer, ByVal height As Integer, ByVal str As String, ByVal strFont As String, ByVal fontsize As Integer, ByVal fontcolor As Integer, ByVal bold As Boolean, ByVal italic As Boolean, ByVal underline As Boolean, ByVal PlayStyle As Integer, ByVal Playspeed As Integer, ByVal times As Integer) As Integer

    '
    Public Declare Function AddFileString Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal qno As Integer, ByVal mno As Integer, ByVal str As String, ByVal strFont As String, ByVal fontsize As Integer, ByVal fontcolor As Integer, ByVal bold As Boolean, ByVal italic As Boolean, ByVal underline As Boolean, ByVal iduiqi As Integer, ByVal width As Integer, ByVal height As Integer, ByVal playstyle As Integer, ByVal QuitStyle As Integer, ByVal playspeed As Integer, ByVal delay As Integer, ByVal MidText As Integer, ByVal Mode As Integer) As Integer

    '6·¢ËÍÆÁ²Î
    Public Declare Function SendScreenPara Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal DBColor As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
    '7·¢ËÍÊý¾Ý
    Public Declare Function SendControl Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal SendType As Integer, ByVal hwnd As Integer) As Integer
    '8.Ìí¼Óµ¥ÐÐÎÄ±¾
    'UPGRADE_NOTE: right ÒÑÉý¼¶µ½ right_Renamed¡£ µ¥»÷ÒÔ»ñµÃ¸ü¶àÐÅÏ¢:¡°ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"¡±
    'UPGRADE_NOTE: left ÒÑÉý¼¶µ½ left_Renamed¡£ µ¥»÷ÒÔ»ñµÃ¸ü¶àÐÅÏ¢:¡°ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"¡±
    Public Declare Function AddQuitText Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal qno As Integer, ByVal left_Renamed As Integer, ByVal top As Integer, ByVal right_Renamed As Integer, ByVal height As Integer, ByVal FontColor As Integer, ByVal fontName As String, ByVal fontSize As Integer, ByVal fontBold As Integer, ByVal itlic As Integer, ByVal Underline As Integer, ByVal text As String) As Integer
    '9Ìí¼ÓÎÄ¼þÇøÓò
    'UPGRADE_NOTE: left ÒÑÉý¼¶µ½ left_Renamed¡£ µ¥»÷ÒÔ»ñµÃ¸ü¶àÐÅÏ¢:¡°ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"¡±
    Public Declare Function AddFileArea Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal qno As Integer, ByVal left_Renamed As Integer, ByVal top As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
    '10Ìí¼ÓÎÄ¼þ
    Public Declare Function AddFile Lib "ListenPlayDll.dll" (ByVal pno As Integer, ByVal jno As Integer, ByVal qno As Integer, ByVal mno As Integer, ByVal filename As String, ByVal width As Integer, ByVal height As Integer, ByVal playstyle As Integer, ByVal QuitStyle As Integer, ByVal playspeed As Integer, ByVal delay As Integer, ByVal MidText As Integer, ByVal Mode As Integer) As Integer


    Public Function LEDcon(Ip As String, Com As Integer) As Boolean
        '//µÚÒ»¸ö²ÎÊý1ÎªÍøÂç 2Îª´®¿Ú£¬µÚ¶þ¸ö²ÎÊý¿ØÖÆÆ÷ÐÍºÅ (1:N1,N2,L1) (2:N3)  (3:T1,T2,T3)
        Dim iTransMode As Integer
        iTransMode = 1
        Dim iConType As Integer
        iConType = 1

        Dim iresult As Integer
        iresult = SetTransMode(iTransMode, iConType)
        If iresult = 1 Then

        Else
            Return False
        End If


        '//Éè²ÎÊý
        Dim iping As Integer
        iping = Com + 1

        Dim strIP As String
        strIP = Ip

        Dim iRe As Integer
        iRe = SetNetworkPara(iping, strIP)
        If iRe = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LEDMsg(msg As String, Com As Integer) As Boolean
        'Dim ipos As Integer
        Dim iping As Integer

        iping = Com + 1
    
        StartSend()

        AddControl(iping, 2) '       //²ÎÊýÒÀ´ÎÎª£ºÆÁºÅ£¬µ¥Ë«É«
        AddProgram(iping, 1, 0) '     //²ÎÊýÒÀ´ÎÎª£ºÆÁºÅ£¬½ÚÄ¿ºÅ£¬½ÚÄ¿²¥·ÅÊ±¼ä  

        Dim result As Integer
        result = AddFileArea(iping, 1, 1, 0, 1, 64, 32)
        If result <> 1 Then
            MessageBox.Show("Ìí¼ÓÎÄ¼þÇøÓòÊ§°Ü")
        End If

        'FOR FULL 
        'font size 17
        'midtext 2

        'FOR 123
        'font size 26
        'midtext 1

        Dim ire2 As Integer
        ire2 = AddFileString(iping, 1, 1, 1, msg, "TAHOMA", 9, 255, False, False, False, 3, 64, 32, 1, 255, 10, 0, 3, 0)
        If ire2 = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SendLEDmsg(com As Integer)
        'Dim ipos As Integer
        Dim iping As Integer

        iping = com + 1

        Dim result As Integer
        result = SendControl(iping, 1, 0)
        If result = 1 Then
            MsgBox("Send successfully!", vbInformation, "Send")
        ElseIf result = 2 Then
            MsgBox("Failed to send!", vbExclamation, "Send")
        ElseIf result = 3 Then
            MsgBox("Send successfully but no change!", vbInformation, "Send")
        End If

    End Sub
End Module
