using FreshMvvm;
using PropertyChanged;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace buziTrade.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class LoginPageModel : FreshBasePageModel
    {
        public ICommand RegisterPageCommand => new Command(async () => await RegisterPage());

        //public List<Login> LoginDetails { get; set; }

        public LoginPageModel()
        {
           
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            //LoginDetails = new List<Login>
            //{
            //    new Login {Email="musty4000@gmail.com", Password="musty4000", Phone="08094390848"}
            //};
        }

        private async Task RegisterPage()
        {
            await CoreMethods.PushPageModel<RegisterPageModel>();
            CoreMethods.RemoveFromNavigation<LoginPageModel>(true);
        }

    }
}
