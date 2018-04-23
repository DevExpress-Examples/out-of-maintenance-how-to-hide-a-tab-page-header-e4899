using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_HidePageHeader {
    public class MySkinTabHeaderViewInfo : SkinTabHeaderViewInfo {
        public MySkinTabHeaderViewInfo(BaseTabControlViewInfo viewInfo)
            : base(viewInfo) {
        }
        protected override BaseTabPageViewInfo CreatePage(DevExpress.XtraTab.IXtraTabPage page) {
            return new MyBaseTabPageViewInfo(page);
        }

    }
}
