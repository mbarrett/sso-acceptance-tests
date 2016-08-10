using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace sso_acceptance_tests.Infrastructure
{
    public class BrowserBase
    {
        private IWebDriver Browser;

        public SSO SSO
        {
            get { return new SSO(Browser); }
        }

        [BeforeScenario]
        public void Setup()
        {
            Browser = InitialiseBrowser();
        }       

        [AfterScenario]
        public void TearDown()
        {
           CloseBrowser();
        }

        private IWebDriver InitialiseBrowser()
        {
            return new ChromeDriver();
        }

        private void CloseBrowser()
        {
            Browser.Close();
        }
    }
}
