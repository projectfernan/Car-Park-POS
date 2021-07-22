Option Explicit On
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Module D8
    Public icdev As Int32
    'Public st As Int32

    '<DllImport("dcrf32.dll")> _
    'Public Function dc_init(ByVal port%, ByVal baud As Long) As Int32
    'End Function
    '<DllImport("dcrf32.dll")> _
    'Public Function dc_exit(ByVal icdev As Long) As Integer
    'End Function
    '<DllImport("dcrf32.dll")> _
    'Public Function dc_card(ByVal icdev As Int32, ByVal mode%, ByRef snr As Int32) As Int32
    'End Function
    '<DllImport("dcrf32.dll")> _
    'Public Function dc_load_key_hex(ByVal icdev As Int32, ByVal mode%, ByVal secnr%, ByVal nkey As String) As Int32
    'End Function
    '<DllImport("dcrf32.dll")> _
    'Public Function dc_read_hex(ByVal icdev As Int32, ByVal adr%, ByVal sdata$) As Int32
    'End Function
    <DllImport("dcrf32.dll")> _
   Public Function dc_authentication(ByVal icdev As Int32, ByVal mode%, ByVal scenr%) As Int32
    End Function
    <DllImport("dcrf32.dll")> _
   Public Function dc_read(ByVal icdev As Int32, ByVal adr%, ByVal sdata$) As Int32
    End Function
    <DllImport("dcrf32.dll")> _
  Public Function dc_write(ByVal icdev As Int32, ByVal adr%, ByVal sdata$) As Int32
    End Function
    <DllImport("dcrf32.dll")> _
 Public Function dc_halt(ByVal icdev As Int32) As Int32
    End Function

    Declare Function add_s Lib "dcrf32.dll" (ByVal i%) As Integer
    'edited
    Declare Function dc_init Lib "dcrf32.dll" (ByVal port As Short, ByVal baud As Integer) As Integer
    Declare Function dc_exit Lib "dcrf32.dll" (ByVal icdev As Integer) As Short
    Declare Function dc_card Lib "dcrf32.dll" (ByVal icdev As Integer, ByVal mode As Short, ByRef snr As Integer) As Short
    Declare Function dc_read_hex Lib "dcrf32.dll" (ByVal icdev As Integer, ByVal adr As Short, <MarshalAs(UnmanagedType.LPTStr)> ByVal sdata As String) As Short
    Declare Function dc_anticoll Lib "dcrf32.dll" (ByVal icdev As Integer, ByVal bcnt As Short, ByVal snr As Integer) As Short
    Declare Function dc_load_key_hex Lib "dcrf32.dll" (ByVal icdev As Integer, ByVal mode As Short, ByVal secnr As Short, ByVal nkey As String) As Short



    Declare Function dc_request Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode%, ByVal tagtype As Long) As Integer

    Declare Function dc_select Lib "dcrf32.dll" (ByVal icdev As Long, ByVal snr As Long, ByVal size As Byte) As Integer


    Declare Function dc_load_key Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode%, ByVal secnr%, ByRef nkey As Byte) As Integer
    'Declare Function dc_authentication Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode%, ByVal scenr%) As Integer
    'Declare Function dc_read Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal sdata$) As Integer

    Declare Function dc_write Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal sdata$) As Integer
    Declare Function dc_write_hex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal sdata$) As Integer
    Declare Function dc_changeb3 Lib "dcrf32.dll" (ByVal adr As Long, ByVal secer As Integer, ByRef KeyA As Byte, ByVal B0 As Integer, ByVal B1 As Integer, ByVal B2 As Integer, ByVal B3 As Integer, ByVal Bk As Integer, ByRef KeyB As Byte) As Integer
    Declare Function dc_read_allhex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal sdata$) As Integer
    Declare Function dc_write_allhex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal sdata$) As Integer
    Declare Function dc_set_autoflag Lib "dcrf32.dll" (ByVal icdev As Long, ByVal flag%) As Integer
    Declare Function dc_check_writehex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal cardid As Long, ByVal mode As Integer, ByVal adr%, ByVal sdata$) As Integer


    Declare Function dc_HL_initval Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode As Integer, ByVal adr%, ByVal value As Long, ByRef snr As Long) As Integer
    Declare Function dc_HL_increment Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode As Integer, ByVal adr%, ByVal value As Long, ByVal snr As Long, ByVal value As Long, ByRef snr As Long) As Integer
    Declare Function dc_HL_decrement Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode As Integer, ByVal adr%, ByVal value As Long, ByVal snr As Long, ByVal value As Long, ByRef snr As Long) As Integer

    '
    Declare Function dc_initval Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal value As Long) As Integer
    Declare Function dc_readval Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal value As Long) As Integer
    Declare Function dc_increment Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal value As Long) As Integer
    Declare Function dc_decrement Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal value As Long) As Integer
    Declare Function dc_restore Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%) As Integer
    Declare Function dc_transfer Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%) As Integer
    Declare Function dc_halt Lib "dcrf32.dll" (ByVal icdev As Long) As Integer

    'CPU card
    Declare Function dc_cpureset_hex Lib "dcrf32.dll" (ByVal icdev As Long, ByRef rlen As Byte, ByVal sdata$) As Integer
    Declare Function dc_cpudown Lib "dcrf32.dll" (ByVal icdev As Long) As Integer
    Declare Function dc_cpuapdu_hex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal slen%, ByVal senddata$, ByRef rlen As Byte, ByVal recdata As String) As Integer
    'device fuction
    Declare Function dc_srd_eepromhex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal lenth%, ByVal sdata$) As Integer
    Declare Function dc_swr_eepromhex Lib "dcrf32.dll" (ByVal icdev As Long, ByVal adr%, ByVal lenth%, ByVal sdata$) As Integer


    Declare Function dc_gettime Lib "dcrf32.dll" (ByVal icdev As Long, ByVal ctime As Byte) As Integer
    Declare Function dc_settime Lib "dcrf32.dll" (ByVal icdev As Long, ByVal ctime As Byte) As Integer


    Declare Function dc_ctl_mode Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode%) As Integer
    Declare Function dc_disp_mode Lib "dcrf32.dll" (ByVal icdev As Long, ByVal mode%) As Integer
    Declare Function dc_reset Lib "dcrf32.dll" (ByVal icdev As Long, ByVal msec%) As Integer
    Declare Function dc_disp_str Lib "dcrf32.dll" (ByVal icdev As Long, ByVal sdata$) As Integer
    Declare Function dc_high_disp Lib "dcrf32.dll" (ByVal icdev As Long, ByVal offset As Integer, ByVal displen As Integer, ByRef dispdata As Byte) As Integer
    Declare Function dc_light Lib "dcrf32.dll" (ByVal icdev As Long, ByVal onoff%) As Integer
    Declare Function dc_beep Lib "dcrf32.dll" (ByVal icdev As Int32, ByVal time1 As Long) As Integer

    Sub quit()
        If icdev > 0 Then
            st = dc_exit(icdev)
            icdev = -1
            'End
        End If
    End Sub
End Module
