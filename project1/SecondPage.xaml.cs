using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            BindingContext = new SecondPageViewModel();
        }

        private async void OnNavigateToSecondPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
        private async void OnNavigateToMainPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
