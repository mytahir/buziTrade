using FreshMvvm;
using PropertyChanged;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using XF.Material.Forms.UI.Dialogs;
using System.IO;
using SQLite;
using buziTrade.Model;
using buziTrade.Data;

namespace buziTrade.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class LoginPageModel : FreshBasePageModel
    {
        buzyTrade_Database bzdb;
        private string emailorPhone { get; set; }

        public string EmailorPhone
        {
            get { return emailorPhone; }
            set
            {
                emailorPhone = value;
                RaisePropertyChanged("EmailorPhone");
            }
        }

        private string password { get; set; }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged("Password");
            }
        }
        public ICommand RegisterPageCommand => new Command(async () => await RegisterPage());

        public ICommand LoginUserCommand => new Command(async () => await LoginUser());

        public LoginPageModel()
        {
           
        }

        private async Task LoginUser()
        {
                if (string.IsNullOrWhiteSpace(emailorPhone) || string.IsNullOrWhiteSpace(password))
                {
                    //await CoreMethods.PushPopupPageModel<UserValidationPageModel>();
                    //await Task.Delay(1000);
                    //await CoreMethods.PopAllPopups();
                    await MaterialDialog.Instance.AlertAsync(message: "All Fields are required!",
                                        title: "Login",
                                        acknowledgementText: "Got It");
                }
                else
                {

                    //await MaterialDialog.Instance.LoadingDialogAsync(message: "Registering your Account...");
                    using (await MaterialDialog.Instance.LoadingDialogAsync(message: "Logging into your Account..."))
                    {
                        await Task.Delay(5000); // Represents a task that is running.

                    try
                    {

                        //var options = new SQLiteConnectionString(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                        //    false);
                        //var conn = new SQLiteConnection(options);

                        //var login = conn.Table<Users>().Where(x => (x.PhoneNumber == emailorPhone || x.BusinessEmail == emailorPhone) && x.Password == password).FirstOrDefault();
                        //conn.Close();

                        //string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                        //    "buziTrade_db.db3");
                        //var db = new SQLiteConnection(dpPath);
                        //var data = db.Table<Users>();

                        //var data1 = data.Where(x => (x.PhoneNumber == emailorPhone || x.BusinessEmail == emailorPhone) && x.Password == password).FirstOrDefault();

                        var validdata = App.Database.LoginUser(emailorPhone, password);
                        if (validdata)
                        {
                            await CoreMethods.PushPageModel<MainPageModel>();
                            CoreMethods.RemoveFromNavigation<LoginPageModel>(true);
                        }
                        else
                        {
                            await MaterialDialog.Instance.AlertAsync(message: "This User does not exist, Please try again!",
                                   title: "Login",
                                   acknowledgementText: "Got It");
                        }
                    }
                    catch (Exception ex)
                    {

                        await MaterialDialog.Instance.AlertAsync(message: ex.ToString(),
                                   title: "Login",
                                   acknowledgementText: "Got It");
                    }
                    }
                }
        }


        //public List<Login> LoginDetails { get; set; }


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
