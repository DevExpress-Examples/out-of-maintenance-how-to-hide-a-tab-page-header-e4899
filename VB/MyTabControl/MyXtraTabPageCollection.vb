Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Example_HidePageHeader.MyTabControl
	Public Class MyXtraTabPageCollection
		Inherits XtraTabPageCollection
		Public Sub New(ByVal tabControl As XtraTabControl)
			MyBase.New(tabControl)
		End Sub
		Protected Overrides Function CreatePage() As XtraTabPage
			Return New MyXtraTabPage()
		End Function
	End Class
End Namespace
