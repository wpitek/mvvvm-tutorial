using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class SampleAViewModel : PropertyChangedBase 
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange("FirstName");
            }
        }

        public SampleAViewModel()
        {
            if (Execute.InDesignMode)
                FirstName = "john";

        }
    }
}
