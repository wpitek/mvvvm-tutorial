using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class EventAggregatorViewModel : Screen
    {
        public LeftViewModel LeftPanel { get; private set; }
        public RightViewModel RightPanel { get; private set; }

        public EventAggregatorViewModel()
        {
            IEventAggregator eventAggregator = new EventAggregator();
            RightPanel = new RightViewModel(eventAggregator);
            LeftPanel = new LeftViewModel(eventAggregator);
        }
    }
}
