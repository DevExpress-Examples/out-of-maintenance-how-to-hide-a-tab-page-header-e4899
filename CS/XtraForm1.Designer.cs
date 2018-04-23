namespace Example_HidePageHeader {
    partial class XtraForm1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myTabControl1 = new Example_HidePageHeader.MyTabControl.MyTabControl();
            this.myXtraTabPage1 = new Example_HidePageHeader.MyTabControl.MyXtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.myXtraTabPage2 = new Example_HidePageHeader.MyTabControl.MyXtraTabPage();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.myXtraTabPage3 = new Example_HidePageHeader.MyTabControl.MyXtraTabPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.myXtraTabPage4 = new Example_HidePageHeader.MyTabControl.MyXtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.myXtraTabPage5 = new Example_HidePageHeader.MyTabControl.MyXtraTabPage();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.myTabControl1)).BeginInit();
            this.myTabControl1.SuspendLayout();
            this.myXtraTabPage1.SuspendLayout();
            this.myXtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.myXtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.myXtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.myXtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // myTabControl1
            // 
            this.myTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myTabControl1.Location = new System.Drawing.Point(0, 86);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.SelectedTabPage = this.myXtraTabPage1;
            this.myTabControl1.Size = new System.Drawing.Size(785, 402);
            this.myTabControl1.TabIndex = 0;
            this.myTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.myXtraTabPage1,
            this.myXtraTabPage2,
            this.myXtraTabPage3,
            this.myXtraTabPage4,
            this.myXtraTabPage5});
            // 
            // myXtraTabPage1
            // 
            this.myXtraTabPage1.Controls.Add(this.simpleButton1);
            this.myXtraTabPage1.HidePageHeader = false;
            this.myXtraTabPage1.Name = "myXtraTabPage1";
            this.myXtraTabPage1.Size = new System.Drawing.Size(779, 374);
            this.myXtraTabPage1.Text = "myXtraTabPage1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(280, 119);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(203, 106);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // myXtraTabPage2
            // 
            this.myXtraTabPage2.Controls.Add(this.dateEdit1);
            this.myXtraTabPage2.HidePageHeader = true;
            this.myXtraTabPage2.Name = "myXtraTabPage2";
            this.myXtraTabPage2.Size = new System.Drawing.Size(779, 374);
            this.myXtraTabPage2.Text = "myXtraTabPage2";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(441, 79);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 5;
            // 
            // myXtraTabPage3
            // 
            this.myXtraTabPage3.Controls.Add(this.pictureEdit1);
            this.myXtraTabPage3.HidePageHeader = false;
            this.myXtraTabPage3.Name = "myXtraTabPage3";
            this.myXtraTabPage3.Size = new System.Drawing.Size(779, 374);
            this.myXtraTabPage3.Text = "myXtraTabPage3";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::Example_HidePageHeader.Properties.Resources.Pyfn_yyYhM4;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal;
            this.pictureEdit1.Size = new System.Drawing.Size(779, 374);
            this.pictureEdit1.TabIndex = 5;
            // 
            // myXtraTabPage4
            // 
            this.myXtraTabPage4.Controls.Add(this.gridControl1);
            this.myXtraTabPage4.HidePageHeader = true;
            this.myXtraTabPage4.Name = "myXtraTabPage4";
            this.myXtraTabPage4.Size = new System.Drawing.Size(779, 374);
            this.myXtraTabPage4.Text = "myXtraTabPage4";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(779, 374);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // myXtraTabPage5
            // 
            this.myXtraTabPage5.Controls.Add(this.radioGroup1);
            this.myXtraTabPage5.HidePageHeader = false;
            this.myXtraTabPage5.Name = "myXtraTabPage5";
            this.myXtraTabPage5.Size = new System.Drawing.Size(779, 374);
            this.myXtraTabPage5.Text = "myXtraTabPage5";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup1.Location = new System.Drawing.Point(0, 0);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(),
            new DevExpress.XtraEditors.Controls.RadioGroupItem()});
            this.radioGroup1.Size = new System.Drawing.Size(779, 374);
            this.radioGroup1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(785, 21);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 488);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.myTabControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myTabControl1)).EndInit();
            this.myTabControl1.ResumeLayout(false);
            this.myXtraTabPage1.ResumeLayout(false);
            this.myXtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.myXtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.myXtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.myXtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyTabControl.MyTabControl myTabControl1;
        private MyTabControl.MyXtraTabPage myXtraTabPage1;
        private MyTabControl.MyXtraTabPage myXtraTabPage2;        
        private MyTabControl.MyXtraTabPage myXtraTabPage3;
        private MyTabControl.MyXtraTabPage myXtraTabPage4;
        private MyTabControl.MyXtraTabPage myXtraTabPage5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;             
    }
}