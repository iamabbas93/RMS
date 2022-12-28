using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using RMS.Pages;

namespace RMS.ViewModels
{
    internal class vmMain:ViewModelBase
    {
        private Page _MainContent = new pageEmployeeManagement();

        public Page MainContent
        {
            get { return _MainContent; }
            set
            {
                if (this._MainContent != value)
                {
                    this._MainContent = value;
                    OnPropertyChanged("MainContent");
                }
            }
        }


    }
}
