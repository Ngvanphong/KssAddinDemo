using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KssDemo.FamilyManager
{
    /// <summary>
    /// Interaction logic for FamilyManagerWpf.xaml
    /// </summary>
    public partial class FamilyManagerWpf : Window
    {
        private readonly ExternalEvent _comboboxSelectionEvent;
        private readonly ExternalEvent _putFaimilyEvent;
        public FamilyManagerWpf(ExternalEvent comboboxSelectionEvent, ExternalEvent putFaimilyEvent)
        {
            InitializeComponent();
            _comboboxSelectionEvent = comboboxSelectionEvent;
            _putFaimilyEvent = putFaimilyEvent;
        }

        private void comboboxFamilyChanged(object sender, SelectionChangedEventArgs e)
        {
            _comboboxSelectionEvent.Raise();
        }

        private void btnClickOk(object sender, RoutedEventArgs e)
        {
            _putFaimilyEvent.Raise();
        }
    }
}
