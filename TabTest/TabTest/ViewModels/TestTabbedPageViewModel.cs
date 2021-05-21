using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;

namespace TabTest.ViewModels
{
    public class TestTabbedPageViewModel : ViewModelBase
    {
        public TestTabbedPageViewModel(INavigationService navService) : base(navService)
        {

        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            Debug.WriteLine($"Initialized: TestTabbedPageViewModel");
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Debug.WriteLine("OnNavigatedTo: TestTabbedPageViewModel");
            if (parameters["Message"] is string message)
            {
                Debug.WriteLine($"OnNavigatedTo: TestTabbedPageViewModel: Message={message}");
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            Debug.WriteLine("OnNavigatedFrom: TestTabbedPageViewModel");
        }
    }
}
