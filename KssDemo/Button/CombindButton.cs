using Autodesk.Revit.UI;
using KssDemo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KssDemo.Button
{
    internal class CombindButton
    {
        public void Combine(UIControlledApplication app)
        {
            try
            {
                app.CreateRibbonTab(AppConstant.RibbonName);
            }
            catch { }
            RibbonPanel ribbonPanel = null;
            foreach (RibbonPanel item in app.GetRibbonPanels(AppConstant.RibbonName))
            {
                if (item.Name == AppConstant.PanelArchitecter)
                {
                    ribbonPanel = item;
                    break;
                }
            }
            if (ribbonPanel == null)
                ribbonPanel = app.CreateRibbonPanel(AppConstant.RibbonName, AppConstant.PanelArchitecter);

            BitmapSource bitmap = Extension.GetImageSource(Resources.icons8_crop_12);

            PushButtonData pushButtonData = new PushButtonData("CreateBeam2255555", "Create\nBeam1",
               Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData.LargeImage = bitmap;
            pushButtonData.Image = bitmap;
            pushButtonData.ToolTip = "Beam tooltip";
            pushButtonData.LongDescription = "Create beam description";
            pushButtonData.ToolTipImage = bitmap;

            PushButtonData pushButtonData2 = new PushButtonData("CreateBeam3335555", "Create\nBeam2",
              Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData2.LargeImage = bitmap;
            pushButtonData2.Image = bitmap;
            pushButtonData2.ToolTip = "Beam tooltip";
            pushButtonData2.LongDescription = "Create beam description";
            pushButtonData2.ToolTipImage = bitmap;


            PushButtonData pushButtonData3 = new PushButtonData("CreateBeam3344555555", "Create\nBeam4",
              Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData3.LargeImage = bitmap;
            pushButtonData3.Image = bitmap;
            pushButtonData3.ToolTip = "Beam tooltip";
            pushButtonData3.LongDescription = "Create beam description";
            pushButtonData3.ToolTipImage = bitmap;


            PushButtonData pushButtonData4 = new PushButtonData("CreateBeam222rrrKK", "Create\nBeam1",
               Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData4.LargeImage = bitmap;
            pushButtonData4.Image = bitmap;
            pushButtonData4.ToolTip = "Beam tooltip";
            pushButtonData4.LongDescription = "Create beam description";
            pushButtonData4.ToolTipImage = bitmap;

            SplitButtonData splitButtonData = new SplitButtonData("CreateBeamSplit22KK", "SplitButtons2");
            splitButtonData.ToolTip = " Tooltip";
            splitButtonData.LongDescription = "Dissss";

            IList<RibbonItem> listRibbonItems=  ribbonPanel.AddStackedItems(pushButtonData4,splitButtonData);
            foreach(RibbonItem item in listRibbonItems)
            {
                if(item.Name== "CreateBeamSplit22KK")
                {
                    SplitButton splitItem= item as SplitButton;
                    splitItem.AddPushButton(pushButtonData);
                    splitItem.AddSeparator();
                    splitItem.AddPushButton(pushButtonData2);
                    splitItem.AddPushButton(pushButtonData3);
                    splitItem.Enabled = true;
                }
            }



        }
    }
}
