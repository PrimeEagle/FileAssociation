Imports System
Imports Org.Mentalis.Utilities

Public Class TestApp
	Public Shared Sub Main()
		Dim FA As New FileAssociation()
		FA.Extension = "xyz"
		FA.ContentType = "application/myprogram"
		FA.FullName = "My XYZ Files!"
		FA.ProperName = "XYZ File"
		FA.AddCommand("open", "C:\mydir\myprog.exe %1")
		FA.Create()
		'Remove the file type from the registry
		FA.Remove()
	End Sub
End Class