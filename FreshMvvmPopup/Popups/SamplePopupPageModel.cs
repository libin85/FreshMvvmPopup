using System;
using Xamarin.Forms;

namespace FreshMvvmPopup.Popups
{
    public class SamplePopupPageModel : BasePageModel
    {
        public SamplePopupPageModel()
        {
        }
        public Command OpenPopup
        {
            get
            {
                return new Command(async() =>
                {
                    await PopupCoreMethods.PushPageModel<SecondPopupPageModel>();
                });
            }
        }
    }
}
