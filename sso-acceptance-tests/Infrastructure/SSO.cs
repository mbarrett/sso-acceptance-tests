using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using sso_acceptance_tests.Pages;

namespace sso_acceptance_tests.Infrastructure
{
    public class SSO
    {
        private readonly IWebDriver _browser;
        private readonly IList<IPageObject> _pageObjects;

        public SSO(IWebDriver browser)
        {
            _browser = browser;

            _pageObjects = new List<IPageObject>
            {
                new AdvertisingStudioPage(_browser),
                new MarketingCloudPage(_browser)
            };
        }
        
        public T Page<T>() where T : IPageObject
        {
            try
            {
                return (T)_pageObjects.First(s => s.GetType().Name == typeof(T).Name);
            }
            catch (Exception)
            {
                throw new ArgumentException(String.Format("Cannot find page object of type '{0}'", typeof(T).Name));
            }
        }
    }
}
