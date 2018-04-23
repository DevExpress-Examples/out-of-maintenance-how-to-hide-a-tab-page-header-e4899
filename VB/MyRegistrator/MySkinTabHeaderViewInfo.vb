Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Example_HidePageHeader
	Public Class MySkinTabHeaderViewInfo
		Inherits SkinTabHeaderViewInfo
		Public Sub New(ByVal viewInfo As BaseTabControlViewInfo)
			MyBase.New(viewInfo)
		End Sub
		Protected Overrides Function CreatePage(ByVal page As DevExpress.XtraTab.IXtraTabPage) As BaseTabPageViewInfo
			Return New MyBaseTabPageViewInfo(page)
		End Function

	End Class
End Namespace
