using System.Diagnostics;
using Xamarin.Forms;

namespace TabTest.Views
{
    public partial class TestTabbedPage : TabbedPage
    {
        public TestTabbedPage()
        {
            InitializeComponent();

            this.CurrentPageChanged += TestTabbedPage_CurrentPageChanged;
        }

        private void TestTabbedPage_CurrentPageChanged(object sender, System.EventArgs e)
        {
            var tabbedPage = sender as TabbedPage;
            if (tabbedPage == null) return;

            var currentPage = tabbedPage.CurrentPage;
            Debug.WriteLine($"CurrentPageChanged: Current Tab Name = {currentPage.Title}");
        }
    }
}
