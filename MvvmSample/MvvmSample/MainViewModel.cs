using System;
using System.ComponentModel;

namespace MvvmSample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public MainViewModel()
        {
            Name = "Melbourne";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
   
