using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.Skins;
using System.Drawing;
using DevExpress.Utils;

namespace DXSample
{
    public class MyRibbonBarManager : RibbonBarManager
    {
        Image checkImage, uncheckImage;
        public MyRibbonBarManager(RibbonControl control) : base(control) { }

        internal Image CheckImage
        {
            get {
                if (checkImage == null)
                    checkImage = GetCheckImage();
                return checkImage;
            }
            set { checkImage = value; }
        }

        internal Image UncheckImage
        {
            get
            {
                if (uncheckImage == null)
                    uncheckImage = GetUncheckImage();
                return uncheckImage;
            }
            set { uncheckImage = value; }
        }


        protected override DevExpress.XtraBars.Ribbon.ViewInfo.RibbonItemViewInfo CreateItemViewInfo(DevExpress.XtraBars.Ribbon.ViewInfo.BaseRibbonViewInfo viewInfo, IRibbonItem item)
        {
            BarCheckItemLink checkButtonLink = item as BarCheckItemLink;
            if (checkButtonLink != null)
            {
                BarCheckItem owner = checkButtonLink.Item as BarCheckItem;
                owner.Glyph = UncheckImage;
                owner.CheckedChanged -= OnCheckedChanged;
                owner.CheckedChanged += OnCheckedChanged;
                return new MyRibbonCheckItemViewInfo(viewInfo, item);
            }
            return base.CreateItemViewInfo(viewInfo, item);
        }

        void OnCheckedChanged(object sender, ItemClickEventArgs e)
        {
            BarCheckItem item = e.Item as BarCheckItem;
            item.Glyph = item.Checked ? CheckImage : UncheckImage; 
        }

        Image GetCheckImage()
        {
            Images images = GetImages();
            return images[4];
        }

        Image GetUncheckImage()
        {
            Images images = GetImages();
            return images[0];
        }

        private Images GetImages()
        {
            Skin skin = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);
            SkinElement elem = skin[EditorsSkins.SkinCheckBox];
            return elem.Image.GetImages().Images;
        }
    }
}
