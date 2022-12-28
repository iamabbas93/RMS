using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RMS.ViewModels
{
    internal class vmProgressInfo:INotifyPropertyChanged
    {
        #region IRptProgress


        private bool _IsBusy = false;

        public bool IsBusy
        {
            get { return _IsBusy; }
            set
            {
                _IsBusy = value;
                if (IsBusy == false)
                {
                    MainTaskVisible = Visibility.Collapsed;
                }
                else
                {
                    MainTaskVisible = Visibility.Visible;
                }
                OnPropertyChanged("IsBusy");
            }
        }


        private Visibility _MainTaskVisible = Visibility.Visible;

        public Visibility MainTaskVisible
        {
            get { return _MainTaskVisible; }
            set
            {
                _MainTaskVisible = value;
                OnPropertyChanged("MainTaskVisible");
            }
        }
        private string _MainTaskText = "Gathering Information ...";

        public string MainTaskText
        {
            get { return _MainTaskText; }
            set
            {
                _MainTaskText = value;
                OnPropertyChanged("MainTaskText");
            }
        }

        private bool _MainTaskInderminate = true;

        public bool MainTaskInderminate
        {
            get { return _MainTaskInderminate; }
            set
            {
                _MainTaskInderminate = value;
                OnPropertyChanged("MainTaskInderminate");
            }
        }

        private double _MainTaskMinimumValue = 0;

        public double MainTaskMinimumValue
        {
            get { return _MainTaskMinimumValue; }
            set
            {
                _MainTaskMinimumValue = value;
                OnPropertyChanged("MainTaskMinimumValue");
            }
        }

        private double _MainTaskMaximumValue = 0;

        public double MainTaskMaximumValue
        {
            get { return _MainTaskMaximumValue; }
            set
            {
                _MainTaskMaximumValue = value;
                OnPropertyChanged("MainTaskMaximumValue");
            }
        }

        private double _MainTaskValue = 0;

        public double MainTaskValue
        {
            get { return _MainTaskValue; }
            set
            {
                _MainTaskValue = value;
                OnPropertyChanged("MainTaskValue");
            }
        }
        private Visibility _SubTaskVisible = Visibility.Collapsed;

        public Visibility SubTaskVisible
        {
            get { return _SubTaskVisible; }
            set
            {
                _SubTaskVisible = value;
                OnPropertyChanged("SubTaskVisible");
            }
        }
        private string _SubTaskText = "";

        public string SubTaskText
        {
            get { return _SubTaskText; }
            set
            {
                _SubTaskText = value;
                OnPropertyChanged("SubTaskText");
            }
        }

        private bool _SubTaskInderminate = false;

        public bool SubTaskInderminate
        {
            get { return _SubTaskInderminate; }
            set
            {
                _SubTaskInderminate = value;
                OnPropertyChanged("SubTaskInderminate");
            }
        }

        private double _SubTaskMinimumValue = 0;

        public double SubTaskMinimumValue
        {
            get { return _SubTaskMinimumValue; }
            set
            {
                _SubTaskMinimumValue = value;
                OnPropertyChanged("SubTaskMinimumValue");
            }
        }

        private double _SubTaskMaximumValue = 0;

        public double SubTaskMaximumValue
        {
            get { return _SubTaskMaximumValue; }
            set
            {
                _SubTaskMaximumValue = value;
                OnPropertyChanged("SubTaskMaximumValue");
            }
        }

        private double _SubTaskValue = 0;

        public double SubTaskValue
        {
            get { return _SubTaskValue; }
            set
            {
                _SubTaskValue = value;
                OnPropertyChanged("SubTaskValue");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
