using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Lottie.Forms.Droid;
using PanCardView.Droid;
using Xamarin.Forms.PancakeView;
using Android.Graphics;
using System.IO;
using Xamarin.Forms.Shapes;

namespace buziTrade.Droid
{
    [Activity(Label = "buziTrade", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        long LastPress;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            XF.Material.Droid.Material.Init(this, savedInstanceState); 
            AnimationViewRenderer.Init();
            CardsViewRenderer.Preserve();


            string dbName = "buzyTrade_db.sqlite";

            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string fullPath = System.IO.Path.Combine(folderPath, dbName);

            LoadApplication(new App(fullPath));

        }

        public override void OnBackPressed()
        {
            long CurrentTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;
            if (CurrentTime - LastPress > 5000)
            {
                Toast.MakeText(this, "Press back again to exit", ToastLength.Long).Show();
                LastPress = CurrentTime;
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}