using Caliburn.Micro;
using System;
using System.Windows;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        private readonly Person _person;

        public string FirstName
        {
            get
            {
                return _person.FirstName;
            }
            set
            {
                _person.FirstName = value;
                NotifyOfPropertyChange("FirstName");
                NotifyOfPropertyChange(() => CanSayHi);
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                NotifyOfPropertyChange("LastName");
                NotifyOfPropertyChange(() => CanSayHi);
            }
        }

        public string Address
        {
            get { return _person.Address; }
            set
            {
                _person.Address = value;
                NotifyOfPropertyChange("Address");
                NotifyOfPropertyChange(() => CanSayHi);
            }
        }

        public MainWindowViewModel()
        {
            _person = new Person();
        }

        public void SayHi()
        {
            if (!PersonExists(_person))
            {
                MessageBox.Show(string.Format("Hi {0} {1}!", _person.FirstName, _person.LastName));
                SavePerosn(_person);
            }
            else
                MessageBox.Show(string.Format("Hey {0} {1}, you exists in our database!", _person.FirstName, _person.LastName));
        }

        private void SavePerosn(Person _person)
        {
            //Some Database Logic
        }

        public bool CanSayHi
        {
            get { return !PersonExists(_person); }
        }

        private bool PersonExists(Person _person)
        {
            //Some logic
            return false;
        }

    }
}
