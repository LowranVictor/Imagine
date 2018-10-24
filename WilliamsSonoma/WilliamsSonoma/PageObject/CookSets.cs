using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WilliamsSonoma.PageObject
{
    class CookSets
    {
        private IWebDriver driver;
        public CookSets(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = " All-Clad d5 Stainless-Steel 10-Piece Cookware Set")]
        private IWebElement allClad;

        [FindsBy(How = How.Id, Using = "primaryGroup_addToCart_0")]
        private IWebElement addCart;

        [FindsBy(How = How.Id, Using = "anchor-btn-checkout")]
        private IWebElement checkOut;

        public void abreAllClad() {
            try
            {
                allClad.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void adcProdCart()
        {
            try
            {
                addCart.Click();
                Thread.Sleep(2000);
                checkOut.Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }          
        }
        
    }
}
