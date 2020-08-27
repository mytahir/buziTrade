using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace buziTrade.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipePage : PopupPage
    {
        public SwipePage()
        {
            InitializeComponent();
            this.CloseWhenBackgroundIsClicked = true;
        }
    }
}