using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class SeventhPageViewModel : INotifyPropertyChanged
    {
        private string _seventhPageTitle = "Welcome to Seventh Page";

        public string SeventhPageTitle
        {
            get => _seventhPageTitle;
            set
            {
                if (_seventhPageTitle != value)
                {
                    _seventhPageTitle = value;
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
