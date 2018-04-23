using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.Skins;
using System.Drawing;
using DevExpress.XtraBars.Ribbon;

namespace DXSample
{
    public class MyRibbonCheckItemViewInfo : RibbonCheckItemViewInfo
    {
        int glyphIndent = 2;
        public MyRibbonCheckItemViewInfo(BaseRibbonViewInfo viewInfo, IRibbonItem item)
            : base(viewInfo, item) { }
        
        public override DevExpress.Skins.SkinElementInfo GetItemInfo()
        {
            SkinElementInfo info = base.GetItemInfo();
            if (info.State != DevExpress.Utils.Drawing.ObjectState.Normal)
            {
                Rectangle rect = info.Bounds;
                info.Bounds = new Rectangle(GlyphBounds.X - glyphIndent, rect.Y, GlyphBounds.Width + 2 * glyphIndent, rect.Height);
            }
            return info;
        }
    }
}
