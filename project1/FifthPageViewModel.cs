using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class FifthPageViewModel : INotifyPropertyChanged
    {
        private string _fifthPageTitle = "Welcome to Fifth Page";

        public string FifthPageTitle
        {
            get => _fifthPageTitle;
            set
            {
                if (_fifthPageTitle != value)
                {
                    _fifthPageTitle = value;
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
