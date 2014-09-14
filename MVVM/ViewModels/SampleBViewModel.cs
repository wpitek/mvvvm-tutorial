using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class SampleBViewModel : PropertyChangedBase 
    {
        private decimal _weight;
        public decimal Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                NotifyOfPropertyChange("Weight");
            }
        }
    }
}
