using DevExpress.XtraTab.Registrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Example_HidePageHeader {
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm {
        public XtraForm1() {
            InitializeComponent();
            AddPaintStyle();
        }
        private static void AddPaintStyle() {
            PaintStyleCollection.DefaultPaintStyles.Add(new MyRegistrator());         
        }

        private void XtraForm1_Load(object sender, EventArgs e) {
            InitControls();
        }
        private void InitControls() {
            InitTabControl();
            InitNumUpDown();
        }
        private void InitTabControl() {
            myTabControl1.PaintStyleName = "MyStyle";
        }
        private void InitNumUpDown() {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = myTabControl1.TabPages.Count;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            myTabControl1.SelectedTabPageIndex = (int)((NumericUpDown)sender).Value - 1;
        }
    }
}