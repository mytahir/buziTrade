using System;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using buziTrade.PageModels;

namespace buziTrade
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            XF.Material.Forms.Material.Init(this, "Material.Configuration");
            XF.Material.Forms.Material.Init(this);

            var startUp = FreshPageModelResolver.ResolvePageModel<BuziTradeStartupPageModel>();
            var firstNavigation = new FreshNavigationContainer(startUp);
            MainPage = firstNavigation;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
