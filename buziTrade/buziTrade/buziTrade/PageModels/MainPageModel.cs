using FreshMvvm;
using System;
using Plugin.Connectivity;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using XF.Material.Forms.UI.Dialogs;

namespace buziTrade.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {

        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            await InternetNotification();
        }

        public async Task<string> InternetNotification()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                await Task.Delay(5000);
                await MaterialDialog.Instance.SnackbarAsync(message: "Internet available, Data Sync...",
                                            actionButtonText: "Got It",
                                            msDuration: 5000);
                return null;
            }
            else
            {
                await Task.Delay(5000);
                await MaterialDialog.Instance.SnackbarAsync(message: "Internet not available, Offline...",
                                            actionButtonText: "Got It",
                                            msDuration: 5000);
                return null;
            }
            
        }

    }
    }
