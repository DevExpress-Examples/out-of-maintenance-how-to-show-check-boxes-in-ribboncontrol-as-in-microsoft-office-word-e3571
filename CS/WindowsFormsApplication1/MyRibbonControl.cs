using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.Skins;

namespace DXSample
{
    public class MyRibbonControl : RibbonControl
    {
        public MyRibbonControl() : base() {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += OnStyleChanged;
        }

        void OnStyleChanged(object sender, EventArgs e)
        {
            UpdateCheckItemGlyph();
        }

        protected override RibbonBarManager CreateBarManager()
        {
            return new MyRibbonBarManager(this);
        }

        internal void UpdateCheckItemGlyph()
        {
            Manager.CheckImage = null;
            Manager.UncheckImage = null;
        }

        public new MyRibbonBarManager Manager {
            get { return base.Manager as MyRibbonBarManager; } 
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
                DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged -= OnStyleChanged;
            base.Dispose(disposing);
        }
    }
}
