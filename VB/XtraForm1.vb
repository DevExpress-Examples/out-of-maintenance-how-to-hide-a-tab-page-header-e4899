Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab.Registrator
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace Example_HidePageHeader
	Partial Public Class XtraForm1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
			AddPaintStyle()
		End Sub
		Private Shared Sub AddPaintStyle()
			PaintStyleCollection.DefaultPaintStyles.Add(New MyRegistrator())
		End Sub

		Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitControls()
		End Sub
		Private Sub InitControls()
			InitTabControl()
			InitNumUpDown()
		End Sub
		Private Sub InitTabControl()
			myTabControl1.PaintStyleName = "MyStyle"
		End Sub
		Private Sub InitNumUpDown()
			numericUpDown1.Minimum = 1
			numericUpDown1.Maximum = myTabControl1.TabPages.Count
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
			myTabControl1.SelectedTabPageIndex = CInt(Fix((CType(sender, NumericUpDown)).Value)) - 1
		End Sub
	End Class
End Namespace