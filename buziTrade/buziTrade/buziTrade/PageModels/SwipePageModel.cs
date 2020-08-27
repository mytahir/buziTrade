using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using FreshMvvm.Popups;
using Xamarin.Forms;

namespace buziTrade.PageModels
{
    public class SwipePageModel : FreshBasePageModel
    {
        public ICommand BackgroundClicked => new Command(async () => await SwipePageAsync());

        private async Task SwipePageAsync()
        {
            await CoreMethods.PopPopupPageModel();
        }

        public SwipePageModel()
        {

        }
    }
}
