using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Prism;
using Prism.Navigation.TabbedPages;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Forms;

namespace TabTest.ViewModels
{
    public class ViewModelBase : ReactiveObject, IInitialize, INavigationAware, IDestructible, IActiveAware
    {
        protected INavigationService NavigationService { get; private set; }

        [Reactive] public bool IsActive { get; set; }
        public event EventHandler IsActiveChanged;

        [Reactive] public string Title { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        public Command SelectTabCommand
        {
            get
            {
                return new Command<string>(async (tabPage) =>
                {
                    var p = new NavigationParameters() {{"Message", $"Hi {tabPage} from parameters!"}};
                    var result = await NavigationService.SelectTabAsync(tabPage, p);
                    if (!result.Success)
                    {
                        Debugger.Break();
                    }
                });
            }
        }

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
