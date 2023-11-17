using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class SeventhPage : ContentPage
    {
        public SeventhPage()
        {
            InitializeComponent();
            BindingContext = new SeventhPageViewModel();
        }
        private async void OnNavigateToEighthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EighthPage());
        }
        private async void OnNavigateToSixthPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SixthPage());
        }
    }
}
