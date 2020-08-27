using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace buziTrade.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class WalkthroughPageModel : FreshBasePageModel
    {
        public ICommand LoginCommand => new Command(async () => await LoginPage());

        private async Task LoginPage()
        {
            await CoreMethods.PushPageModel<LoginPageModel>();
            CoreMethods.RemoveFromNavigation<WalkthroughPageModel>(true);

        }

        public WalkthroughPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

    }
}
