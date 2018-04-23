Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports Example_HidePageHeader.MyTabControl
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Example_HidePageHeader
	Public Class MyBaseTabPageViewInfo
		Inherits BaseTabPageViewInfo
		Public Sub New(ByVal page As IXtraTabPage)
			MyBase.New(page)
		End Sub
		Public Overrides Property Bounds() As System.Drawing.Rectangle
			Get
				Dim nullRectangle = New System.Drawing.Rectangle(MyBase.Bounds.Location, New System.Drawing.Size(0, 0))
				If (CType(Page, MyXtraTabPage)).HidePageHeader Then
					Return nullRectangle
				End If
				Return MyBase.Bounds
			End Get
			Set(ByVal value As System.Drawing.Rectangle)
				MyBase.Bounds = value
			End Set
		End Property
	End Class
End Namespace
