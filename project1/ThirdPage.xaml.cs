using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
            BindingContext = new ThirdPageViewModel();
        }
        private async void OnNavigateToFourthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FourthPage());
        }
        private async void OnNavigateToSecondPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
