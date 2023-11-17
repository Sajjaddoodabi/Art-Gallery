using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourNamespace
{
    public class SecondPageViewModel : INotifyPropertyChanged
    {
        private string _secondPageTitle = "This is Second Page";
        private string _inputText;

        public string SecondPageTitle
        {
            get => _secondPageTitle;
            set
            {
                if (_secondPageTitle != value)
                {
                    _secondPageTitle = value;
                    OnPropertyChanged();
                }
            }
        }

        public string InputText
        {
            get => _inputText;
            set
            {
                if (_inputText != value)
                {
                    _inputText = value;
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
