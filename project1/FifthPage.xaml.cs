using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class FifthPage : ContentPage
    {
        public FifthPage()
        {
            InitializeComponent();
            BindingContext = new FifthPageViewModel();
        }
        private async void OnNavigateToSixthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SixthPage());
        }
        private async void OnNavigateToFourthPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FourthPage());
        }
    }
}
