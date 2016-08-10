using Microsoft.VisualStudio.TestTools.UnitTesting;
using sso_acceptance_tests.Infrastructure;
using sso_acceptance_tests.Pages;
using TechTalk.SpecFlow;

namespace sso_acceptance_tests.Steps
{
    [Binding]
    public sealed class LoginSteps : BrowserBase
    {
        [Given(@"I have logged into my Marketing Cloud account")]
        public void GivenIHaveLoggedIntoMyMarketingCloudAccount()
        {
            SSO.Page<MarketingCloudPage>().Login();
        }

        [When(@"I select the Advertising Studio option from the navigation")]
        public void WhenISelectTheAdvertisingStudioOptionFromTheNavigation()
        {
            SSO.Page<MarketingCloudPage>().SelectAdvertisingStudio();
        }

        [Then(@"I should be redirected to Advertising Studio")]
        public void ThenIShouldBeRedirectedToAdvertisingStudio()
        {
            Assert.IsTrue(SSO.Page<AdvertisingStudioPage>().IsCurrentPage);
        }
    }
}
