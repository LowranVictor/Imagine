using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilliamsSonoma.PageObject
{
    class Woks
    {
        private IWebDriver driver;
        public Woks(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Hammered Round Bottom Wok with Ring, 14")]
        private IWebElement hammered;

        [FindsBy(How = How.Id, Using = "primaryGroup_addToCart_0")]
        private IWebElement addCart;

    }
}
