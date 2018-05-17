using System;
using FreshMvvm;
using Xamarin.Forms;

namespace FreshMvvmPopup.PageModels
{
    public class FirstPageModel : BasePageModel
    {
        public FirstPageModel()
        {
        }

        public Command NavigateCommand
        {
            get
            {
                return new Command(() =>
                {
                    CoreMethods.PushPageModel<SecondPageModel>();
                });
            }
        }
    }
}
