using System;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace FreshMvvmPopup
{
    public  class BasePageModel: FreshBasePageModel
    {
        private readonly Command _navigateToBackCommand;

        public BasePageModel()
        {
            PopupCoreMethods = new PopupCoreMethods(CurrentPage, this);

            _navigateToBackCommand = new Command(NavigateToBack, CanNavigateToBack);
        }

        protected virtual bool CanNavigateToBack()
        {
            return true;
        }

        protected virtual void NavigateToBack()
        {
            CoreMethods.PopPageModel();
        }

        #region popups support

        public PopupCoreMethods PopupCoreMethods { get; set; }

        public async Task PushPopupPageModel<TPopupViewModel>(bool animate = true)
            where TPopupViewModel : FreshBasePageModel
        {
            var page = FreshPageModelResolver.ResolvePageModel<TPopupViewModel>() as PopupPage;
            if (page != null)
                await PopupNavigation.PushAsync(page, animate);
        }

        #endregion

        public ICommand NavigateToBackCommand => _navigateToBackCommand;
    }
}
