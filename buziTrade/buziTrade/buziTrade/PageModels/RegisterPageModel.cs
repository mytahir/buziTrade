using FreshMvvm;
using PropertyChanged;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FreshMvvm.Popups;
using XF.Material.Forms.UI.Dialogs;
using buziTrade.Pages;

namespace buziTrade.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class RegisterPageModel : FreshBasePageModel
    {

        private string fullName { get; set; }

        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                RaisePropertyChanged("FullName");
            }
        }

        private string conAddress { get; set; }
        public string ConAddress
        {
            get { return conAddress; }
            set
            {
                conAddress = value;
                RaisePropertyChanged("ConAddress");
            }
        }

        private string phoneNo { get; set; }

        public string PhoneNo
        {
            get { return phoneNo; }
            set
            {
                phoneNo = value;
                RaisePropertyChanged("PhoneNo");
            }
        }
        private string businessName { get; set; }

        public string BusinessName
        {
            get { return businessName; }
            set
            {
                businessName = value;
                RaisePropertyChanged("BusinessName");
            }
        }
        private string businessAddress { get; set; }

        public string BusinessAddress
        {
            get { return businessAddress; }
            set
            {
                businessAddress = value;
                RaisePropertyChanged("BusinessAddress");
            }
        }
        private string businessEmail { get; set; }

        public string BusinessEmail
        {
            get { return businessEmail; }
            set
            {
                businessEmail = value;
                RaisePropertyChanged("BusinessEmail");
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
        private string rePassword { get; set; }

        public string RePassword
        {
            get { return rePassword; }
            set
            {
                rePassword = value;
                RaisePropertyChanged("RePassword");
            }
        }


        private bool isSwipeEnabled { get; set; }

        public ICommand RegisterUserCommand => new Command(async () => await RegisterUser());

        public ICommand LoginPageCommand => new Command(async () => await LoginPage());
        //public ICommand OnRegister => new Command(async () => await RegisterUser());

        public RegisterPageModel()
        {

        }

        //protected override async void ViewIsAppearing(object sender, EventArgs e)
        //{
        //    base.ViewIsAppearing(sender, e);
        //    await CoreMethods.PushPopupPageModel<SwipePageModel>();

        //}

        /// <summary>
        /// This Function registers Users after filling the Form
        /// </summary>
        /// <returns></returns>
        private async Task RegisterUser()
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(conAddress) || string.IsNullOrWhiteSpace(phoneNo) ||
                string.IsNullOrWhiteSpace(businessName) || string.IsNullOrWhiteSpace(businessAddress) || string.IsNullOrWhiteSpace(businessEmail)
                || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rePassword))
            {
                //await CoreMethods.PushPopupPageModel<UserValidationPageModel>();
                //await Task.Delay(1000);
                //await CoreMethods.PopAllPopups();
                await MaterialDialog.Instance.AlertAsync(message: "All Fields are required!",
                                    title: "Register",
                                    acknowledgementText: "Got It");
            }
            else if (password != rePassword)
            {
                await MaterialDialog.Instance.AlertAsync(message: "Password and Re-Password didn't match!",
                                    title: "Password",
                                    acknowledgementText: "Got It");
            }
            else
            {
                //await MaterialDialog.Instance.LoadingDialogAsync(message: "Registering your Account...");
                using (await MaterialDialog.Instance.LoadingDialogAsync(message: "Registering your Account..."))
                {
                    await Task.Delay(3000); // Represents a task that is running.
                }
                await Task.Delay(3000);
                await MaterialDialog.Instance.AlertAsync(message: "Registration Successful!");
            }

        }


        //private async Task RegisterUser()
        //{
        //    if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(conAddress) || string.IsNullOrWhiteSpace(phoneNo) ||
        //        string.IsNullOrWhiteSpace(businessName) || string.IsNullOrWhiteSpace(businessAddress) || string.IsNullOrWhiteSpace(businessEmail)
        //        || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rePassword))
        //    {
        //        try
        //        {

        //            //isSwipeEnabled = false;
        //            //await CoreMethods.PushPopupPageModel<UserValidationPageModel>();
        //            await Task.Delay(1000);
        //            //await CoreMethods.PopAllPopups();
        //            await MaterialDialog.Instance.AlertAsync(message: "Personal Information Fields Are Required!");
        //        }
        //        catch
        //        {

        //            //await CoreMethods.PushPopupPageModel<UserValidationPageModel>();
        //        }
        //    }

        //    //if (string.IsNullOrWhiteSpace(businessName) || string.IsNullOrWhiteSpace(businessAddress) || string.IsNullOrWhiteSpace(businessEmail))
        //    //{
        //    //    try
        //    //    {

        //    //    isSwipeEnabled = false;
        //    //    await CoreMethods.PushPopupPageModel<BusinessValidationPageModel>();
        //    //    await Task.Delay(1000);
        //    //    await CoreMethods.PopAllPopups();
        //    //    //await MaterialDialog.Instance.AlertAsync(message: "Personal Information Fields Are Required!");
        //    //    }
        //    //    catch
        //    //    {

        //    //        await CoreMethods.PushPopupPageModel<BusinessValidationPageModel>();
        //    //    }
        //    //}

        //    //else
        //    //{
        //    //   // isSwipeEnabled = true;
        //    //}
        //}

        private async Task LoginPage()
        {
            await CoreMethods.PushPageModel<LoginPageModel>();
            CoreMethods.RemoveFromNavigation<RegisterPageModel>(true);
        }

    }
}
