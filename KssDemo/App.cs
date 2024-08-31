using Autodesk.Revit.UI;
using KssDemo.Button;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KssDemo
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            new CreateBeamButton().CreateBeam(a);
            new ListSmallButton().Small(a);
            new DropButton().Drop(a);
            new CombindButton().Combine(a);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
