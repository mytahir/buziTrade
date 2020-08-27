using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace buziTrade.Pages.Walkthrough
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalkthroughPage : ContentPage
    {
        private View[] _views;
        public WalkthroughPage()
        {
            InitializeComponent();

            // ViewModel = new WalkThroughViewModel();
            // BindingContext = ViewModel;

            _views = new View[]
            {
                new WelcomeView(),
                new CloudSync(),
                new ChartView(),

            };

            Carousel.ItemsSource = _views;

        }

        private void OnCarouselPositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            var currentView = _views[e.NewValue];

            if (currentView is IAnimatedView animatedView)
            {
                animatedView.StartAnimation();
            }

        }

        private void Carousel_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
        }

        //private async void btnLog_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new LoginPage());
        //    Navigation.RemovePage(this);
        //}

        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    //await Navigation.PushAsync(new LoginPage());
        //}
    }
}