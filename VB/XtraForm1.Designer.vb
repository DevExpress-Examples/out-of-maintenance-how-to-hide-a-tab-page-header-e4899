Imports Microsoft.VisualBasic
Imports System
Namespace Example_HidePageHeader
	Partial Public Class XtraForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myTabControl1 = New Example_HidePageHeader.MyTabControl.MyTabControl()
			Me.myXtraTabPage1 = New Example_HidePageHeader.MyTabControl.MyXtraTabPage()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.myXtraTabPage2 = New Example_HidePageHeader.MyTabControl.MyXtraTabPage()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.myXtraTabPage3 = New Example_HidePageHeader.MyTabControl.MyXtraTabPage()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.myXtraTabPage4 = New Example_HidePageHeader.MyTabControl.MyXtraTabPage()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.myXtraTabPage5 = New Example_HidePageHeader.MyTabControl.MyXtraTabPage()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
			CType(Me.myTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myTabControl1.SuspendLayout()
			Me.myXtraTabPage1.SuspendLayout()
			Me.myXtraTabPage2.SuspendLayout()
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myXtraTabPage3.SuspendLayout()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myXtraTabPage4.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myXtraTabPage5.SuspendLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myTabControl1
			' 
			Me.myTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.myTabControl1.Location = New System.Drawing.Point(0, 86)
			Me.myTabControl1.Name = "myTabControl1"
			Me.myTabControl1.SelectedTabPage = Me.myXtraTabPage1
			Me.myTabControl1.Size = New System.Drawing.Size(785, 402)
			Me.myTabControl1.TabIndex = 0
			Me.myTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.myXtraTabPage1, Me.myXtraTabPage2, Me.myXtraTabPage3, Me.myXtraTabPage4, Me.myXtraTabPage5})
			' 
			' myXtraTabPage1
			' 
			Me.myXtraTabPage1.Controls.Add(Me.simpleButton1)
			Me.myXtraTabPage1.HidePageHeader = False
			Me.myXtraTabPage1.Name = "myXtraTabPage1"
			Me.myXtraTabPage1.Size = New System.Drawing.Size(779, 374)
			Me.myXtraTabPage1.Text = "myXtraTabPage1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(280, 119)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(203, 106)
			Me.simpleButton1.TabIndex = 5
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' myXtraTabPage2
			' 
			Me.myXtraTabPage2.Controls.Add(Me.dateEdit1)
			Me.myXtraTabPage2.HidePageHeader = True
			Me.myXtraTabPage2.Name = "myXtraTabPage2"
			Me.myXtraTabPage2.Size = New System.Drawing.Size(779, 374)
			Me.myXtraTabPage2.Text = "myXtraTabPage2"
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(441, 79)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
			Me.dateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default
			Me.dateEdit1.Size = New System.Drawing.Size(100, 20)
			Me.dateEdit1.TabIndex = 5
			' 
			' myXtraTabPage3
			' 
			Me.myXtraTabPage3.Controls.Add(Me.pictureEdit1)
			Me.myXtraTabPage3.HidePageHeader = False
			Me.myXtraTabPage3.Name = "myXtraTabPage3"
			Me.myXtraTabPage3.Size = New System.Drawing.Size(779, 374)
			Me.myXtraTabPage3.Text = "myXtraTabPage3"
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureEdit1.EditValue = My.Resources.Pyfn_yyYhM4
			Me.pictureEdit1.Location = New System.Drawing.Point(0, 0)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal
			Me.pictureEdit1.Size = New System.Drawing.Size(779, 374)
			Me.pictureEdit1.TabIndex = 5
			' 
			' myXtraTabPage4
			' 
			Me.myXtraTabPage4.Controls.Add(Me.gridControl1)
			Me.myXtraTabPage4.HidePageHeader = True
			Me.myXtraTabPage4.Name = "myXtraTabPage4"
			Me.myXtraTabPage4.Size = New System.Drawing.Size(779, 374)
			Me.myXtraTabPage4.Text = "myXtraTabPage4"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(779, 374)
			Me.gridControl1.TabIndex = 5
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' myXtraTabPage5
			' 
			Me.myXtraTabPage5.Controls.Add(Me.radioGroup1)
			Me.myXtraTabPage5.HidePageHeader = False
			Me.myXtraTabPage5.Name = "myXtraTabPage5"
			Me.myXtraTabPage5.Size = New System.Drawing.Size(779, 374)
			Me.myXtraTabPage5.Text = "myXtraTabPage5"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radioGroup1.Location = New System.Drawing.Point(0, 0)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem(), New DevExpress.XtraEditors.Controls.RadioGroupItem()})
			Me.radioGroup1.Size = New System.Drawing.Size(779, 374)
			Me.radioGroup1.TabIndex = 6
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top
			Me.numericUpDown1.Location = New System.Drawing.Point(0, 0)
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Size = New System.Drawing.Size(785, 21)
			Me.numericUpDown1.TabIndex = 1
'			Me.numericUpDown1.ValueChanged += New System.EventHandler(Me.numericUpDown1_ValueChanged);
			' 
			' XtraForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(785, 488)
			Me.Controls.Add(Me.numericUpDown1)
			Me.Controls.Add(Me.myTabControl1)
			Me.Name = "XtraForm1"
			Me.Text = "XtraForm1"
'			Me.Load += New System.EventHandler(Me.XtraForm1_Load);
			CType(Me.myTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myTabControl1.ResumeLayout(False)
			Me.myXtraTabPage1.ResumeLayout(False)
			Me.myXtraTabPage2.ResumeLayout(False)
			CType(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myXtraTabPage3.ResumeLayout(False)
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myXtraTabPage4.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myXtraTabPage5.ResumeLayout(False)
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myTabControl1 As MyTabControl.MyTabControl
		Private myXtraTabPage1 As MyTabControl.MyXtraTabPage
		Private myXtraTabPage2 As MyTabControl.MyXtraTabPage
		Private myXtraTabPage3 As MyTabControl.MyXtraTabPage
		Private myXtraTabPage4 As MyTabControl.MyXtraTabPage
		Private myXtraTabPage5 As MyTabControl.MyXtraTabPage
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace