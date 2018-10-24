using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WilliamsSonoma.PageObject
{
    class WilliamsSonomaPage
    {
        private IWebDriver driver;
        public WilliamsSonomaPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Cookware")]
        private IWebElement abreMenuCookWare;

        [FindsBy(How = How.LinkText, Using = "Woks")]
        private IWebElement woks;

        [FindsBy(How = How.LinkText, Using = "Hammered Round Bottom Wok with Ring, 14")]
        private IWebElement hammered;

        [FindsBy(How = How.Id, Using = "primaryGroup_addToCart_0")]
        private IWebElement addCart;

        [FindsBy(How = How.Id, Using = "NotasTecnicas")]
        private IWebElement notaTecnica;

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement email;

        public void abreMenu() {

            try
            {
                abreMenuCookWare.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
           
        }
            
        public void abreMenuWoks()
        {
            try
            {
                woks.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }           
        }
    }
}
