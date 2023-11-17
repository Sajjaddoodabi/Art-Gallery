using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class NinthPageViewModel : INotifyPropertyChanged
    {
        private string _ninthPageTitle = "Welcome to Ninth Page";

        public string NinthPageTitle
        {
            get => _ninthPageTitle;
            set
            {
                if (_ninthPageTitle != value)
                {
                    _ninthPageTitle = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
