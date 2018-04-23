Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Example_HidePageHeader.MyTabControl
	Public Class MyXtraTabPage
		Inherits XtraTabPage
		Private _HidePageHeader As Boolean

		Public Property HidePageHeader() As Boolean
			Get
				Return _HidePageHeader
			End Get
			Set(ByVal value As Boolean)
				If _HidePageHeader = value Then
					Return
				End If
				_HidePageHeader = value
				OnPageChanged()
			End Set
		End Property
	End Class
End Namespace
