using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class NinthPage : ContentPage
    {
        public NinthPage()
        {
            InitializeComponent();
            BindingContext = new NinthPageViewModel();
        }
        private async void OnNavigateToEighthPageBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EighthPage());
        }
    }
}
