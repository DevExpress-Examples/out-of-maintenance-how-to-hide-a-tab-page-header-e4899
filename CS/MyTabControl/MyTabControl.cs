using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_HidePageHeader.MyTabControl {
    public class MyTabControl : XtraTabControl {
        protected override XtraTabPageCollection CreateTabCollection() {
            return new MyXtraTabPageCollection(this);
        }
    }
}
