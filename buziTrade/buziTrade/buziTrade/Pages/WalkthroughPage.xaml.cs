using buziTrade.Pages.Walkthrough;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace buziTrade.Pages
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

            if (currentView is ChartView)
            {
                btnSkip.Text = "Login";
                //ThirdIndicator.Color = Color.FromHex("#FFC106");
                //SecondIndicator.Color = Color.White;
                //FirstIndicator.Color = Color.White;

            }

            if (currentView is CloudSync)
            {
                btnSkip.Text = "Skip";
                //ThirdIndicator.Color = Color.White;
                //SecondIndicator.Color = Color.FromHex("#FFC106");
                //FirstIndicator.Color = Color.White;

            }

            if (currentView is WelcomeView)
            {
                btnSkip.Text = "Skip";
                //ThirdIndicator.Color = Color.White;
                //SecondIndicator.Color = Color.White;
                //FirstIndicator.Color = Color.FromHex("#FFC106");

            }

        }
    }

    //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new RegPage());
    //    Navigation.RemovePage(this);
    //}
}