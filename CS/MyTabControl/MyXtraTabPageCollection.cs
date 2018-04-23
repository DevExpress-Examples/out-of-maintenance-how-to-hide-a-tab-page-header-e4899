using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_HidePageHeader.MyTabControl {
    public class MyXtraTabPageCollection : XtraTabPageCollection {
        public MyXtraTabPageCollection(XtraTabControl tabControl)
            : base(tabControl) {
        }
        protected override XtraTabPage CreatePage() {
            return new MyXtraTabPage();
        }
    }
}
