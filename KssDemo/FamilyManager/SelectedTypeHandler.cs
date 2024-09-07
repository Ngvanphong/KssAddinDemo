using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KssDemo.FamilyManager
{
    public class SelectedTypeHandler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            Document doc = app.ActiveUIDocument.Document;
            FamilyCus fa= FamilyManagerBinding.form.comboboxFamily.SelectedItem as FamilyCus;
            Family family = doc.GetElement(new ElementId(fa.Id)) as Family;
            var symbolIds= family.GetFamilySymbolIds();
            IList<FamilySymbol> symbols= new List<FamilySymbol>();  
            foreach (ElementId id in symbolIds)
            {
                FamilySymbol sym= doc.GetElement(id) as FamilySymbol;
                symbols.Add(sym);
            }

            FamilyManagerBinding.form.listViewTypes.ItemsSource = symbols;
        }

        public string GetName()
        {
            return "SelecteTypeHandler2";
        }
    }
}
