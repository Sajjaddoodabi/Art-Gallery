using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class SixthPage : ContentPage
    {
        public SixthPage()
        {
            InitializeComponent();
            BindingContext = new SixthPageViewModel();
        }
        private async void OnNavigateToSeventhPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeventhPage());
        }
        private async void OnNavigateToFifthPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FifthPage());
        }
    }
}
