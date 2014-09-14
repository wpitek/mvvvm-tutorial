using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class AboutViewModel : Screen
    {

        private string _displayVersion;
        public string DisplayVersion
        {
            get { return _displayVersion; }
            set
            {
                _displayVersion = value;
                NotifyOfPropertyChange("DisplayVersion");
            }
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            DisplayName = string.Format("About window. {0}", DateTime.Now.ToShortDateString());
        }


        public void Exit()
        {
            TryClose();
        }

        public AboutViewModel()
        {
            if (Execute.InDesignMode)
                LoadFakeData();
            LoadData();
        }

        private void LoadData()
        {
            DisplayVersion=Assembly.GetCallingAssembly().GetName().Version.ToString();
        }

        private void LoadFakeData()
        {
            DisplayVersion = new Version(0, 0, 0, 9).ToString();
        }
    }
}