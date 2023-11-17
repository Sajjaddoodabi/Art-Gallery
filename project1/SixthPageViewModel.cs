using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class SixthPageViewModel : INotifyPropertyChanged
    {
        private string _sixthPageTitle = "Welcome to Sixth Page";

        public string SixthPageTitle
        {
            get => _sixthPageTitle;
            set
            {
                if (_sixthPageTitle != value)
                {
                    _sixthPageTitle = value;
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
