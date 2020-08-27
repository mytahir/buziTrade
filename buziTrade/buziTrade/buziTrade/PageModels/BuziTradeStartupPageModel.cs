using FreshMvvm;
using FreshMvvm.Popups;
using PropertyChanged;
using System;
using System.Threading.Tasks;

namespace buziTrade.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class BuziTradeStartupPageModel : FreshBasePageModel
    {
        private bool isBusy { get; set; }
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {

                if (isBusy != value)
                    RaisePropertyChanged("IsBusy");

            }
        }

        public BuziTradeStartupPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            isBusy = true;
            await Task.Delay(5000);
            await CoreMethods.PushPageModel<WalkthroughPageModel>();
            isBusy = false;
            CoreMethods.RemoveFromNavigation<BuziTradeStartupPageModel>(true);
            PreviousPageModel = null;

        }

    }


}
