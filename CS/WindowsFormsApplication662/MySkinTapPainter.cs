using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;

namespace WindowsFormsApplication662 {

    public class MySkinTapPainter : SkinTabPainter {
        public MySkinTapPainter(IXtraTab tabControl)
            : base(tabControl) {

        }
        protected override void DrawHeaderPage(TabDrawArgs e, DevExpress.XtraTab.ViewInfo.BaseTabRowViewInfo row, DevExpress.XtraTab.ViewInfo.BaseTabPageViewInfo pInfo) {
            base.DrawHeaderPage(e, row, pInfo);
            Rectangle rect = pInfo.Bounds;
            rect.Height = 2;
            e.Graphics.FillRectangle(Brushes.Red, rect);
            e.Graphics.FillRectangle(new SolidBrush(pInfo.Page.Appearance.Header.BackColor2), rect);
        }
    }
}
