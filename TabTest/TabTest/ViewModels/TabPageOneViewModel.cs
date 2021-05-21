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
    public class TabPageOneViewModel : ViewModelBase
    {
        public TabPageOneViewModel(INavigationService navService) : base(navService)
        {
            Title = "Page 1";

            this.WhenAnyValue(x => x.IsActive)
                .Subscribe(x =>
                {
                    Debug.WriteLine($"TabPageOneViewModel -> IsActive = {x}");
                });
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            //IsActive = false;

            Debug.WriteLine($"Initialized: TabPageOneViewModel, IsActive={IsActive}");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Debug.WriteLine("OnNavigatedTo: TabPageOneViewModel");
            if (parameters["Message"] is string message)
            {
                Debug.WriteLine($"OnNavigatedTo: TabPageOneViewModel: Message={message}");
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            Debug.WriteLine("OnNavigatedFrom: TabPageOneViewModel");
        }
    }
}

