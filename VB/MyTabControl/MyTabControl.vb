Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Example_HidePageHeader.MyTabControl
	Public Class MyTabControl
		Inherits XtraTabControl
		Protected Overrides Function CreateTabCollection() As XtraTabPageCollection
			Return New MyXtraTabPageCollection(Me)
		End Function
	End Class
End Namespace
