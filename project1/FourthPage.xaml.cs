using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
            BindingContext = new FourthPageViewModel();
        }
        private async void OnNavigateToFifthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FifthPage());
        }
        private async void OnNavigateToThirdPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
    }
}
