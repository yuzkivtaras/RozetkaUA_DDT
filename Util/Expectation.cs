using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
namespace RozetkaUA_DDT.Util
{
    public static class Expectation
    {
        public static IWebElement WaitUntil(IWebDriver webDriver, By webElement)
        {
            try
            {
                return new WebDriverWait(webDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(webElement));
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot find lacator {webElement}", ex);
            }
        }
    }
}
