using System;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using buziTrade.PageModels;

namespace buziTrade
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            XF.Material.Forms.Material.Init(this, "Material.Configuration");
            XF.Material.Forms.Material.Init(this);

            var startUp = FreshPageModelResolver.ResolvePageModel<BuziTradeStartupPageModel>();
            var firstNavigation = new FreshNavigationContainer(startUp);
            MainPage = firstNavigation;

        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            XF.Material.Forms.Material.Init(this, "Material.Configuration");
            XF.Material.Forms.Material.Init(this);

            var startUp = FreshPageModelResolver.ResolvePageModel<BuziTradeStartupPageModel>();
            var firstNavigation = new FreshNavigationContainer(startUp);
            MainPage = firstNavigation;

            DatabaseLocation = databaseLocation;
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
