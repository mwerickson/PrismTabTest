using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;
using ReactiveUI;

namespace TabTest.ViewModels
{
    public class TabPageFiveViewModel : ViewModelBase
    {
        public TabPageFiveViewModel(INavigationService navService) : base(navService)
        {
            Title = "Page 5";

            this.WhenAnyValue(x => x.IsActive)
                .Subscribe(x =>
                {
                    Debug.WriteLine($"TabPageFiveViewModel -> IsActive = {x}");
                });
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            //IsActive = false;

            Debug.WriteLine($"Initialized: TabPageFiveViewModel, IsActive={IsActive}");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Debug.WriteLine("OnNavigatedTo: TabPageFiveViewModel");
            if (parameters["Message"] is string message)
            {
                Debug.WriteLine($"OnNavigatedTo: TabPageFiveViewModel: Message={message}");
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            Debug.WriteLine("OnNavigatedFrom: TabPageFiveViewModel");
        }
    }
}
