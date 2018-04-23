Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Drawing
Imports Example_HidePageHeader.MyTabControl
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Example_HidePageHeader
	Public Class MySkinTabPainter
		Inherits SkinTabPainter
		Public Sub New(ByVal tabControl As IXtraTab)
			MyBase.New(tabControl)
		End Sub
		Protected Overrides Sub DrawHeaderPage(ByVal e As TabDrawArgs, ByVal row As DevExpress.XtraTab.ViewInfo.BaseTabRowViewInfo, ByVal pInfo As DevExpress.XtraTab.ViewInfo.BaseTabPageViewInfo)
			If (CType(pInfo.Page, MyXtraTabPage)).HidePageHeader Then
				Return
			End If
			MyBase.DrawHeaderPage(e, row, pInfo)
		End Sub
	End Class
End Namespace
