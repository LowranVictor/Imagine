using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using WilliamsSonoma.PageObject;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WilliamsSonoma
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver wd;
        private Cookware cw;
        private WilliamsSonomaPage ws;
        private CookSets cs;
        private Checkout co;

        [TestMethod]
        public void TestMethod1()
        {
            wd = new ChromeDriver(@"C:\Users\" + Environment.UserName + @"\source\repos\WilliamsSonoma\WilliamsSonoma\bin\Debug");
            cw = new Cookware(wd);
            ws = new WilliamsSonomaPage(wd);
            cs = new CookSets(wd);
            co = new Checkout(wd);

            abrePagina("https://www.williams-sonoma.com/?cm_sp=tnav-_-williams-sonoma-_-tab");
            Thread.Sleep(2000);

            //Acessando o menu Cookware Sets
            ws.abreMenu();
            Thread.Sleep(100);
            wd.Navigate().GoToUrl("https://www.williams-sonoma.com/shop/cookware/cookware-sets/?");
            Thread.Sleep(3000);

            //Abrindo o produto All-Clad d5 Stainless-Steel 10-Piece Cookware Set
            wd.Navigate().GoToUrl("https://www.williams-sonoma.com/products/all-clad-d5-stainless-steel-10-piece-cookware-set/?pkey=ccookware-sets&isx=0.0.800");
            Thread.Sleep(3000);

            //Adicionando produto ao carrinho
            cs.adcProdCart();
            Thread.Sleep(3000);

            //Abrindo a página de Checkout e verificando se o produto foi incluído no carrinho
            wd.Navigate().GoToUrl("https://www.williams-sonoma.com/shoppingcart/");
            Thread.Sleep(3000);
            co.verificaDado();

            //pesquisando por um Produto
            co.pesquisaProduto("All-Clad d5 Stainless-Steel 10-Piece Cookware Set");

            //Acessando o produto pesquisado
            wd.Navigate().GoToUrl("https://www.williams-sonoma.com/products/all-clad-d5-stainless-steel-10-piece-cookware-set/?pkey=e%7Call-clad%2Bd5%2Bstainless-steel%2B10-piece%2Bcookware%2Bset%7C3%7Cbest%7C0%7C1%7C24%7C%7C1&cm_src=PRODUCTSEARCH");

            wd.Close();
            wd.Quit();

        }

        public void abrePagina(string url)
        {
            wd.Navigate().GoToUrl(url);
            wd.Manage().Window.Maximize();
        }
    }
}
