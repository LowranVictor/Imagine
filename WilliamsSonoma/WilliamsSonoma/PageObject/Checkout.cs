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
    class Checkout
    {
        private IWebDriver driver;
        public Checkout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[class='cart-button']")]
        private IWebElement verCheckout;

        [FindsBy(How = How.CssSelector, Using = "[class='cart-table-row-title']")]
        private IWebElement produto;

        [FindsBy(How = How.Id, Using = "search-field")]
        private IWebElement pesquisa;

        [FindsBy(How = How.Id, Using = "btnSearch")]
        private IWebElement btnPesquisa;

        public void abreCheckout() { verCheckout.Click(); }

        public void verificaDado()
        {
            string atual = produto.GetAttribute("innerText").Trim();

            try
            {
                Assert.AreEqual("All-Clad d5 Stainless-Steel 10-Piece Cookware Set", atual);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            
        }

        public void pesquisaProduto(string prod)
        {
            try
            {
                pesquisa.SendKeys(prod);
                Thread.Sleep(300);
                btnPesquisa.Click();
                Thread.Sleep(300);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            
        }
    }
}
