using OpenQA.Selenium;

namespace sso_acceptance_tests.Pages
{
    public class AdvertisingStudioPage : IPageObject
    {
        private IWebDriver _browser;

        public AdvertisingStudioPage(IWebDriver browser)
        {
            _browser = browser;
        }

        public bool IsCurrentPage
        {
            get { return _browser.PageSource.Contains("Advertising Campaigns"); }
        }
    }
}
