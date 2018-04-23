using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_HidePageHeader.MyTabControl {
    public class MyXtraTabPage : XtraTabPage {
        private bool _HidePageHeader;

        public bool HidePageHeader {
            get {
                return _HidePageHeader;
            }
            set {
                if(_HidePageHeader == value) {
                    return;
                }
                _HidePageHeader = value;
                OnPageChanged();
            }
        }
    }
}
