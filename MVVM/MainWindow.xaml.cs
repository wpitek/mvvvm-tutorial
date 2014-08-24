using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SayHi_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person
            {
                FirstName=FirstName.Text,
                LastName=LastName.Text,
                Addres=Address.Text
            };
            if (!PersonExists(person))
            {
                MessageBox.Show(string.Format("Hi {0} {1}!", person.FirstName, person.LastName));
                SavePerosn(person);
            }
            else
            {
                MessageBox.Show(string.Format("Hey {0} {1}, you exists in our database!", person.FirstName, person.LastName));
            }
        }

        private bool PersonExists(Person person)
        {
            //Logic goes here
            return false;
        }

        private void SavePerosn(Person person)
        {
            //Logic goes here
        }
    }
}
