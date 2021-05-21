using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            ShowTabbedPageCommand = new DelegateCommand(ShowTabbedPage);

        }

        public DelegateCommand ShowTabbedPageCommand { get; private set; }

        private async void ShowTabbedPage()
        {
            //var tabUri =
            //    "/TestTabbedPage?createTab=NavigationPage|TabPageOne&createTab=NavigationPage|TabPageTwo&createTab=NavigationPage|TabPageThree&createTab=NavigationPage|TabPageFour&createTab=NavigationPage|TabPageFive";
            var tabUri =
                "/TestTabbedPage?createTab=TabPageOne&createTab=TabPageTwo&createTab=TabPageThree&createTab=TabPageFour&createTab=TabPageFive";

            await NavigationService.NavigateAsync(tabUri);
        }
    }
}
