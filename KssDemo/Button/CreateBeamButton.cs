using Autodesk.Revit.UI;
using KssDemo.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KssDemo.Button
{
    internal class CreateBeamButton
    {
        public void CreateBeam(UIControlledApplication app)
        {
            try
            {
                app.CreateRibbonTab(AppConstant.RibbonName);
            }
            catch { }
            RibbonPanel ribbonPanel = null;
            foreach(RibbonPanel item in app.GetRibbonPanels(AppConstant.RibbonName))
            {
                if(item.Name== AppConstant.PanelArchitecter)
                {
                    ribbonPanel = item;
                    break;
                }
            }
            if (ribbonPanel == null)
                ribbonPanel = app.CreateRibbonPanel(AppConstant.RibbonName, AppConstant.PanelArchitecter);

            BitmapSource bitmap = Extension.GetImageSource(Resources.icons8_crop_24__2_);
            PushButtonData pushButtonData = new PushButtonData("CreateBeam", "Create\nBeam",
               Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData.LargeImage = bitmap;
            pushButtonData.Image = bitmap;
            pushButtonData.ToolTip = "Beam tooltip";
            pushButtonData.LongDescription = "Create beam description";
            pushButtonData.ToolTipImage = bitmap;

            PushButton pushButton= ribbonPanel.AddItem(pushButtonData) as PushButton;
            pushButton.Enabled = true;

        }
    }
}
