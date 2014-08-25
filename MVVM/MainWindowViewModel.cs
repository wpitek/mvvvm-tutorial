using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;


namespace MVVM
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly Person _person;

        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                _person.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Address
        {
            get { return _person.Address; }
            set
            {
                _person.Address = value;
                OnPropertyChanged("Address");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainWindowViewModel()
        {
            _person = new Person();
        }

        public ICommand SayHi { get { return new RelayCommand(SayHiExcute, CanSayHiExcute); } }

        private void SayHiExcute()
        {
            if (!PersonExists(_person))
            {
                MessageBox.Show(string.Format("Hi {0} {1}!", _person.FirstName, _person.LastName));
                SavePerosn(_person);
            }
            else
            {
                MessageBox.Show(string.Format("Hey {0} {1}, you exists in our database!", _person.FirstName, _person.LastName));
            }
        }

        private void SavePerosn(Person _person)
        {
            //Some Database Logic
        }

        private bool CanSayHiExcute()
        {
            return !PersonExists(_person);
        }

        private bool PersonExists(Person _person)
        {
            //Some logic
            return false;
        }

    }
}
