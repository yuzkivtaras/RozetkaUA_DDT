using OpenQA.Selenium;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RozetkaUA_DDT.Util;

namespace RozetkaUA_DDT.Tests.PageObject
{
    public class SearchPage
    {
        public IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private List<IWebElement> _itemsInList = new List<IWebElement>();

        public readonly By _searchField = By.XPath("//input[@name='search']");
        public readonly By _brandName = By.XPath("//a[@data-id='Apple']");
        public readonly By _products = By.XPath("//div[@class='goods-tile__inner']//a[@class='goods-tile__heading ng-star-inserted']");
        public readonly By _title = By.XPath("//h1[@class='product__title']");

        public void EnterSearchText(string searchItem) => driver.FindElement(_searchField).SendKeys(searchItem + Keys.Enter);
        public void ChooseBrandName() => Expectation.WaitUntil(driver, _brandName).Click();
        public string CheckTextInTitle()
        {
            return Expectation.WaitUntil(driver, _title).FindElement(_title).Text;
        }

        public List<IWebElement> AddElements()
        {
            var elements = Expectation.WaitUntil(driver, _products).FindElements(_products).ToList();
            _itemsInList = elements;
            return elements;
        }

        public IWebElement GetFirstElement()
        {
            return _itemsInList.First();
        }

        public void ChoseItem(IWebElement element)
        {
            element.Click();
        }
    }

}
