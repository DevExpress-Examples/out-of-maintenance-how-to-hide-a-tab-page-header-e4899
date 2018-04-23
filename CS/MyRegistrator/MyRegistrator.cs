using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_HidePageHeader {
    public class MyRegistrator : SkinViewInfoRegistrator {
        public MyRegistrator() {
        }
        public override string ViewName {
            get {
                return "MyStyle";
            }
        }
        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo) {
            return new MySkinTabHeaderViewInfo(viewInfo);
        }
        public override DevExpress.XtraTab.Drawing.BaseTabPainter CreatePainter(DevExpress.XtraTab.IXtraTab tabControl) {
            return new MySkinTabPainter(tabControl);
        }
    }
}
