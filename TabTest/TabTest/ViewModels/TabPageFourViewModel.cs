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
    public class TabPageFourViewModel : ViewModelBase
    {
        public TabPageFourViewModel(INavigationService navService) : base(navService)
        {
            Title = "Page 4";

            this.WhenAnyValue(x => x.IsActive)
                .Subscribe(x =>
                {
                    Debug.WriteLine($"TabPageFourViewModel -> IsActive = {x}");
                });
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            //IsActive = false;

            Debug.WriteLine($"Initialized: TabPageFourViewModel, IsActive={IsActive}");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Debug.WriteLine("OnNavigatedTo: TabPageFourViewModel");
            if (parameters["Message"] is string message)
            {
                Debug.WriteLine($"OnNavigatedTo: TabPageFourViewModel: Message={message}");
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            Debug.WriteLine("OnNavigatedFrom: TabPageFourViewModel");
        }
    }
}

