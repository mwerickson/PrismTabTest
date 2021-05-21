using Prism;
using Prism.Ioc;
using TabTest.ViewModels;
using TabTest.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace TabTest
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<TestTabbedPage, TestTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<TestTabbedPage, TestTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<TabPageOne, TabPageOneViewModel>();
            containerRegistry.RegisterForNavigation<TabPageTwo, TabPageTwoViewModel>();
            containerRegistry.RegisterForNavigation<TabPageThree, TabPageThreeViewModel>();
            containerRegistry.RegisterForNavigation<TabPageFour, TabPageFourViewModel>();
            containerRegistry.RegisterForNavigation<TabPageFive, TabPageFiveViewModel>();
            containerRegistry.RegisterForNavigation<AmazingContentPage, AmazingContentPageViewModel>();
        }
    }
}
