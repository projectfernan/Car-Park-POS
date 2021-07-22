Imports System.Drawing.Printing
Module PrinterDriver
    Public Sub PopulateInstalledPrintersCombo(ByVal cbo As ComboBox)
        ' Add list of installed printers found to the combo box. 
        ' The pkInstalledPrinters string will be used to provide the display string. 
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            cbo.Items.Add(pkInstalledPrinters)
        Next
    End Sub
End Module
