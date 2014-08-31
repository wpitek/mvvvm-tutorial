using Caliburn.Micro;
using System;
using System.Windows;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        private Person _person;
        public Person Ctx
        {
            get { return _person; }
            set
            {
                _person = value;
                NotifyOfPropertyChange("Ctx");
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
                MessageBox.Show(string.Format("Hi {0} {1}!\nYou address is {2} {3}", _person.FirstName, _person.LastName, _person.Address.PostCode, _person.Address.Town));
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

        private bool PersonExists(Person person)
        {
            //Some logic
            return false;
        }

    }
}
