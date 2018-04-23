using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTab.Registrator;

namespace WindowsFormsApplication662 {
    public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator {
        public MySkinViewInfoRegistrator()
            : base() {

        }
        public override string ViewName {
            get {
                return "MyStyle";
            }
        }
        public override DevExpress.XtraTab.Drawing.BaseTabPainter CreatePainter(DevExpress.XtraTab.IXtraTab tabControl) {
            return new MySkinTapPainter(tabControl);
        }
    }
}
