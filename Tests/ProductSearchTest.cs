using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OfficeOpenXml;
using RozetkaUA_DDT.Tests.PageObject;
using RozetkaUA_DDT.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RozetkaUA_DDT.Tests
{
    public class ProductSearchTest : BaseTest
    {
        [TestCaseSource(typeof(GetDataBrandFromXml), "GetData")]
        [Test]
        public void ProductSearch(Filter filter)
        {
            string nameItem = filter.ProductName;
            string nameBrand = filter.BrandName;

            SearchPage searchPage = new SearchPage(driver);
            searchPage.EnterSearchText(nameItem);
            searchPage.ChooseBrandName();
            Thread.Sleep(2000);
            searchPage.AddElements();
            searchPage.ChoseItem(searchPage.GetFirstElement());

            NUnit.Framework.Assert.IsTrue(searchPage.CheckTextInTitle().Contains(nameBrand));
        }       
     }
}
