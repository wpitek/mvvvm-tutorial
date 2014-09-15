using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class LeftViewModel:Screen
    {
        private Address _address;
        public Address Ctx
        {
            get { return _address; }
            set
            {
                _address = value;
                NotifyOfPropertyChange("Ctx");
            }
        }

        private readonly IEventAggregator _eventAggregator;

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            Ctx = new Address();
            
        }

        public LeftViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public  void Save()
        {
            _eventAggregator.PublishOnUIThread(Ctx);
            Ctx = new Address();
        }

    }
}
