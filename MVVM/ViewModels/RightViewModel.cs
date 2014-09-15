using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class RightViewModel : Screen, IHandle<Address>
    {
        public BindableCollection<Address> Items { get; set; }

        private readonly IEventAggregator _eventAggregator;

        public RightViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            Items = new BindableCollection<Address>();
            _eventAggregator.Subscribe(this);
        }

        public void Handle(Address message)
        {
            Items.Add(message);
        }
    }
}
