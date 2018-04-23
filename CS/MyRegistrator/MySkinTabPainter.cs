using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;
using Example_HidePageHeader.MyTabControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_HidePageHeader {
    public class MySkinTabPainter : SkinTabPainter {
        public MySkinTabPainter(IXtraTab tabControl)
            : base(tabControl) {
        }
        protected override void DrawHeaderPage(TabDrawArgs e, DevExpress.XtraTab.ViewInfo.BaseTabRowViewInfo row, DevExpress.XtraTab.ViewInfo.BaseTabPageViewInfo pInfo) {
            if(((MyXtraTabPage)pInfo.Page).HidePageHeader) return;
            base.DrawHeaderPage(e, row, pInfo);
        }
    }
}
