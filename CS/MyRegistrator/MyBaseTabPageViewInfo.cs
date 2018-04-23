using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using Example_HidePageHeader.MyTabControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_HidePageHeader {
    public class MyBaseTabPageViewInfo : BaseTabPageViewInfo {
        public MyBaseTabPageViewInfo(IXtraTabPage page)
            : base(page) {
        }
        public override System.Drawing.Rectangle Bounds {
            get {
                var nullRectangle = new System.Drawing.Rectangle(base.Bounds.Location, new System.Drawing.Size(0, 0));
                if(((MyXtraTabPage)Page).HidePageHeader) {
                    return nullRectangle;
                }
                return base.Bounds;
            }
            set {
                base.Bounds = value;
            }
        }
    }
}
