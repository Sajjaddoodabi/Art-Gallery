using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _mainPageTitle = "Welcome to MainPage";

        public string MainPageTitle
        {
            get => _mainPageTitle;
            set
            {
                if (_mainPageTitle != value)
                {
                    _mainPageTitle = value;
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
