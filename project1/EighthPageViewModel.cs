using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class EighthPageViewModel : INotifyPropertyChanged
    {
        private string _eighthPageTitle = "Welcome to Eighth Page";

        public string EighthPageTitle
        {
            get => _eighthPageTitle;
            set
            {
                if (_eighthPageTitle != value)
                {
                    _eighthPageTitle = value;
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
