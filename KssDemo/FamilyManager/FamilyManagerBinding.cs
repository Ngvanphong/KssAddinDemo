using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KssDemo.FamilyManager
{
    [Transaction(TransactionMode.Manual)]
    public class FamilyManagerBinding : IExternalCommand
    {
        public static FamilyManagerWpf form;
        public static IList<FamilyCus> comboboSource;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            IEnumerable<Family> funitureFamily = new FilteredElementCollector(doc).OfClass(typeof(Family))
                .Cast<Family>().Where(x => x.FamilyCategory.Id.Value == (long)BuiltInCategory.OST_Furniture);
            IList<FamilyCus> familyCustoms = (from cus in funitureFamily
                                             select new FamilyCus(cus.Id.Value, cus.Name))
                                             .ToList();
            comboboSource = familyCustoms;

            ExternalEvent comboboxEvent = ExternalEvent.Create(new SelectedTypeHandler());
            ExternalEvent putFamilyEvent= ExternalEvent.Create(new PutFamilyHandler()); 

            form = new FamilyManagerWpf(comboboxEvent, putFamilyEvent);
            form.comboboxFamily.ItemsSource= familyCustoms;

            //bool?resultDialog= form.ShowDialog();
            //if(resultDialog ==true)
            //{
            //    // todo

            //}

            form.Show();
            
    

            return Result.Succeeded;
        }
    }
}
