using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class MultiViewModel : Conductor<object>
    {
        public void SampleA()
        {
            ActivateItem(new SampleAViewModel());
        }

        public void SampleB()
        {
            ActivateItem(new SampleBViewModel());
        }
    }
}
