using Caliburn.Micro;
using System;
using System.Windows;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MainWindowViewModel : Screen 
    {
        private readonly WindowManager _windowManager;

        private Person _customer;
        public Person SelectedCustomer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                NotifyOfPropertyChange("SelectedCustomer");
            }
        }

        private BindableCollection<Person> _customers;
        public BindableCollection<Person> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                NotifyOfPropertyChange("Customers");
            }
        }

        public MainWindowViewModel()
        {
            if (Execute.InDesignMode)
            {
                LoadFakeData();
            }
            else
            {
                _windowManager = new WindowManager();
                LoadFakeData();
            }
        }

        private void LoadFakeData()
        {
            _customers = new BindableCollection<Person>();
            Address a1 = new Address { Town = "Example1", PostCode = "0xFF" };
            Address a2 = new Address { Town = "Example2", PostCode = "0xAA" };
            _customers.Add(new Person { FirstName = "A", LastName = "A", Address = a1 });
            _customers.Add(new Person { FirstName = "B", LastName = "B", Address = a2 });
            SelectedCustomer = Customers[0];
        }

        public void About()
        {
            _windowManager.ShowDialog(new AboutViewModel());
        }

        public void MultiView()
        {
            _windowManager.ShowDialog(new MultiViewModel());
        }

        public void EventAggregatorExample()
        {
            _windowManager.ShowDialog(new EventAggregatorViewModel());
        }

    }
}
