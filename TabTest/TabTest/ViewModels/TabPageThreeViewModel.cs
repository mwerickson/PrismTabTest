using Prism.Commands;
using Prism.Mvvm;
using Prism;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;
using ReactiveUI;

namespace TabTest.ViewModels
{
    public class TabPageThreeViewModel : ViewModelBase, IActiveAware
    {
        public TabPageThreeViewModel(INavigationService navService) : base(navService)
        {
            Title = "Page 3";

            this.WhenAnyValue(x => x.IsActive)
                .Subscribe(x =>
                {
                    Debug.WriteLine($"TabPageThreeViewModel -> IsActive = {x}");
                });
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            //IsActive = false;

            Debug.WriteLine($"Initialized: TabPageThreeViewModel, IsActive={IsActive}");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Debug.WriteLine("OnNavigatedTo: TabPageThreeViewModel");
            if (parameters["Message"] is string message)
            {
                Debug.WriteLine($"OnNavigatedTo: TabPageThreeViewModel: Message={message}");
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            Debug.WriteLine("OnNavigatedFrom: TabPageThreeViewModel");
        }

        
    }
}

