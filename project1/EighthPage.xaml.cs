using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class EighthPage : ContentPage
    {
        public EighthPage()
        {
            InitializeComponent();
            BindingContext = new EighthPageViewModel();
        }
        private async void OnNavigateToNinthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NinthPage());
        }
        private async void OnNavigateToSeventhPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeventhPage());
        }
    }
}
