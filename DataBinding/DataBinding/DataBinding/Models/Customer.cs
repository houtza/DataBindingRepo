using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding.Models
{
    class Customer : INotifyPropertyChanged
    {
        public Customer(String customerName)
        {
            Name = customerName;
        }

        private String _Name;

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propteryName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != Null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
