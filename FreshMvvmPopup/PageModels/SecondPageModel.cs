using System;
using FreshMvvm;
using FreshMvvmPopup.Popups;
using Xamarin.Forms;

namespace FreshMvvmPopup.PageModels
{
    public class SecondPageModel : BasePageModel
    {
        public SecondPageModel()
        {
        }

        public Command OpenPopupCommand
        {
            get{
                return new Command(async() =>
                {
                    await PopupCoreMethods.PushPageModel<SamplePopupPageModel>();
                });
            }
        }
    }
}
