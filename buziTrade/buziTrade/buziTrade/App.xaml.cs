using System;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using buziTrade.PageModels;
using System.IO;
using buziTrade.Data;

namespace buziTrade
{
    public partial class App : Application
    {
        static buzyTrade_Database database;
        public static buzyTrade_Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                        buzyTrade_Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "buziTrade_db.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            XF.Material.Forms.Material.Init(this, "Material.Configuration");
            XF.Material.Forms.Material.Init(this);

            var startUp = FreshPageModelResolver.ResolvePageModel<BuziTradeStartupPageModel>();
            var firstNavigation = new FreshNavigationContainer(startUp);
            MainPage = firstNavigation;

        }

        //public App(string databaseLocation)
        //{
        //    InitializeComponent();

        //    XF.Material.Forms.Material.Init(this, "Material.Configuration");
        //    XF.Material.Forms.Material.Init(this);

        //    var startUp = FreshPageModelResolver.ResolvePageModel<BuziTradeStartupPageModel>();
        //    var firstNavigation = new FreshNavigationContainer(startUp);
        //    MainPage = firstNavigation;

        //    DatabaseLocation = databaseLocation;
        //}

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
