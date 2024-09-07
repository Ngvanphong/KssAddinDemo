using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KssDemo.FamilyManager
{
    public class FamilyCus : INotifyPropertyChanged
    {
        public FamilyCus(long inputId , string name)
        {
            (Id, Name)= (inputId, name);
        }
        private long id;
        public long Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged(nameof(Id));
            }
        }

        public bool IsCheck { set; get; }


        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
