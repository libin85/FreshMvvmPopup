using System;
using FreshMvvmPopup.PageModels;
using Xamarin.Forms;

namespace FreshMvvmPopup.Popups
{
    public class SecondPopupPageModel : BasePageModel
    {
        public SecondPopupPageModel()
        {
        }
        public Command NavigateCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await PopupCoreMethods.PushPageModel<FirstPageModel>();
                });
            }
        }
    }
}
