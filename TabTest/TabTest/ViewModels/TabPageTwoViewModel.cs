using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;
using ReactiveUI;
using Xamarin.Forms.Internals;

namespace TabTest.ViewModels
{
    public class TabPageTwoViewModel : ViewModelBase
    {
        public TabPageTwoViewModel(INavigationService navService) : base(navService)
        {
            Title = "Page 2";

            this.WhenAnyValue(x => x.IsActive)
                .Subscribe(x =>
                {
                    Debug.WriteLine($"TabPageTwoViewModel -> IsActive = {x}");
                });

            NavigateCommand = new DelegateCommand(NavigateToPage);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        private async void NavigateToPage()
        {
            //var tabUri =
            //    "/TestTabbedPage?createTab=NavigationPage|TabPageOne&createTab=NavigationPage|TabPageTwo&createTab=NavigationPage|TabPageThree&createTab=NavigationPage|TabPageFour&createTab=NavigationPage|TabPageFive";

            await NavigationService.NavigateAsync("NavigationPage/AmazingContentPage");
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            //IsActive = false;

            Debug.WriteLine($"Initialized: TabPageTwoViewModel, IsActive={IsActive}");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Debug.WriteLine("OnNavigatedTo: TabPageTwoViewModel");
            if (parameters["Message"] is string message)
            {
                Debug.WriteLine($"OnNavigatedTo: TabPageTwoViewModel: Message={message}");
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            Debug.WriteLine("OnNavigatedFrom: TabPageTwoViewModel");
        }
    }
}

