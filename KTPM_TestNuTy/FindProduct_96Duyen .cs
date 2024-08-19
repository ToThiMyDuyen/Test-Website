using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace KTPM_TestNuTy
{
   
    [TestClass]
    public class FindProduct_96Duyen
    {
        private IWebDriver driver96_MyDuyen;
        public TestContext TestContext { get; set; }
        public void Setup()
        {
            driver96_MyDuyen = new ChromeDriver();
            driver96_MyDuyen.Navigate().GoToUrl("https://nuty.vn/");
        }
        public void Login()
        {
            driver96_MyDuyen.FindElement(By.ClassName("before-login")).Click();
            Thread.Sleep(2000);
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$UserName")).SendKeys("0334331308");
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$Password")).SendKeys("duyen123");
            driver96_MyDuyen.FindElement(By.Id("ctl00_mainContent_login1_LoginCtrl_Login")).Click();
            Thread.Sleep(2000);
        }


        [TestMethod]
        public void SearchNotFoundProduct_96Duyen()
        {
            Setup();
            driver96_MyDuyen.Manage().Window.Maximize();
            Login();
            //Tìm kiếm sản phẩm
            IWebElement search_96MyDuyen = driver96_MyDuyen.FindElement(By.Name("ctl00$mdl1341$ctl00$Search$txtSearch"));
            search_96MyDuyen.SendKeys("gfgfghh");
            // Click Enter
            new Actions(driver96_MyDuyen).KeyDown(Keys.Enter).Build().Perform();
        }
    }
}
