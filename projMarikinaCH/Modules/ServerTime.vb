Imports System.Runtime.InteropServices
Imports System
Imports System.ComponentModel

Module ServerTime

    <StructLayoutAttribute(LayoutKind.Sequential)> _
    Structure SystemTime
        Public year As Short
        Public month As Short
        Public dayOfWeek As Short
        Public day As Short
        Public hour As Short
        Public minute As Short
        Public second As Short
        Public milliseconds As Short
    End Structure

    'P/Invoke dec for setting the system time...
    <DllImport("kernel32.dll")> _
    Private Function SetLocalTime(ByRef time As SystemTime) As Boolean

    End Function


    Public Function SetDeviceTime(ByVal p_NewDate As Date) As Date
        'Populate structure...
        'Substitute <YOUR DATE OBJECT> with your date object returned via GPRS...
        Try
            Dim st As SystemTime
            st.year = p_NewDate.Year
            st.month = p_NewDate.Month
            st.dayOfWeek = p_NewDate.DayOfWeek
            st.day = p_NewDate.Day
            st.hour = p_NewDate.Hour
            st.minute = p_NewDate.Minute
            st.second = p_NewDate.Second
            st.milliseconds = p_NewDate.Millisecond

            'Set the new time...
            SetLocalTime(st)
        Catch ex As Exception
            Save_ErrLogs("[SetDeviceTime]", ex.Message)
        End Try
    End Function
End Module
