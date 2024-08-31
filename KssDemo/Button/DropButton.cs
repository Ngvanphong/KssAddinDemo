﻿using Autodesk.Revit.UI;
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
    internal class DropButton
    {
        public void Drop(UIControlledApplication app)
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

            PushButtonData pushButtonData = new PushButtonData("CreateBeam2255", "Create\nBeam1",
               Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData.LargeImage = bitmap;
            pushButtonData.Image = bitmap;
            pushButtonData.ToolTip = "Beam tooltip";
            pushButtonData.LongDescription = "Create beam description";
            pushButtonData.ToolTipImage = bitmap;

            PushButtonData pushButtonData2 = new PushButtonData("CreateBeam33355", "Create\nBeam2",
              Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData2.LargeImage = bitmap;
            pushButtonData2.Image = bitmap;
            pushButtonData2.ToolTip = "Beam tooltip";
            pushButtonData2.LongDescription = "Create beam description";
            pushButtonData2.ToolTipImage = bitmap;


            PushButtonData pushButtonData3 = new PushButtonData("CreateBeam3344555", "Create\nBeam4",
              Assembly.GetExecutingAssembly().Location, "KssDemo.CreateBeam.CreateBeamBinding");
            pushButtonData3.LargeImage = bitmap;
            pushButtonData3.Image = bitmap;
            pushButtonData3.ToolTip = "Beam tooltip";
            pushButtonData3.LongDescription = "Create beam description";
            pushButtonData3.ToolTipImage = bitmap;

            SplitButtonData splitButtonData = new SplitButtonData("CreateBeamSplit", "SplitButtons");
            splitButtonData.ToolTip = " Tooltip";
            splitButtonData.LongDescription = "Dissss";
            SplitButton splitButton= ribbonPanel.AddItem(splitButtonData) as SplitButton;
            splitButton.AddPushButton(pushButtonData);
            splitButton.AddSeparator();
            splitButton.AddPushButton(pushButtonData2);
            splitButton.AddPushButton(pushButtonData3);


        }
    }
}
