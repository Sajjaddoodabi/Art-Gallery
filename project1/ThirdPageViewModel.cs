using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class ThirdPageViewModel : INotifyPropertyChanged
    {
        private string _thirdPageTitle = "Welcome to Third Page";

        public string ThirdPageTitle
        {
            get => _thirdPageTitle;
            set
            {
                if (_thirdPageTitle != value)
                {
                    _thirdPageTitle = value;
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
