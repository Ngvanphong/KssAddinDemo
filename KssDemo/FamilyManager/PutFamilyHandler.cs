using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KssDemo.FamilyManager
{
    public class PutFamilyHandler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            ExternalEvent comboboxEvent = ExternalEvent.Create(new SelectedTypeHandler());
            ExternalEvent putFamilyEvent = ExternalEvent.Create(new PutFamilyHandler());

            var form2 = new FamilyManagerWpf(comboboxEvent,putFamilyEvent);
            form2.Show();
            form2.comboboxFamily.ItemsSource = FamilyManagerBinding.comboboSource;

            form2.Owner = FamilyManagerBinding.form;
            //Document doc = app.ActiveUIDocument.Document;
            //FamilySymbol sy = FamilyManagerBinding.form.listViewTypes.SelectedItem as FamilySymbol;
            //if (sy != null)
            //{
            //    using(Transaction t= new Transaction(doc, "PutFamily"))
            //    {
            //        t.Start();
            //        if (!sy.IsActive) sy.Activate();
            //        doc.Create.NewFamilyInstance(new XYZ(0, 0, 0), sy, Autodesk.Revit.DB.Structure.StructuralType.NonStructural);
            //        t.Commit();
            //    }
            //}
        }

        public string GetName()
        {
            return "PutFamily2";
        }
    }
}
