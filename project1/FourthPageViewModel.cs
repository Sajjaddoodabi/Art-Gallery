using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class FourthPageViewModel : INotifyPropertyChanged
    {
        private string _fourthPageTitle = "Welcome to Fourth Page";

        public string FourthPageTitle
        {
            get => _fourthPageTitle;
            set
            {
                if (_fourthPageTitle != value)
                {
                    _fourthPageTitle = value;
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
