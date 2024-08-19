using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace KTPM_TestNuTy
{
    [TestClass]
    public class Login_96Duyen
    {
        private IWebDriver driver96_MyDuyen;
        private void Setup()
        {
            driver96_MyDuyen = new ChromeDriver();
            driver96_MyDuyen.Navigate().GoToUrl("https://nuty.vn/");
        }
        [TestMethod]
        public void TC1_96MyDuyen()
        {
            Setup();
            // Câu lệnh mở rộng màn hình khi chạy
            driver96_MyDuyen.Manage().Window.Maximize();
            // Thực hiện click vào biểu tượng tài khoản đăng nhập
            driver96_MyDuyen.FindElement(By.ClassName("before-login")).Click();
            // Điền số điện thoại
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$UserName")).SendKeys("0334331307");
            //Điền mật khẩu
            driver96_MyDuyen.FindElement(By.Id("ctl00_mainContent_login1_LoginCtrl_Password")).SendKeys("duyen123");
            // Nhấn đăng nhập
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$Login")).Click();
            Thread.Sleep(3000);              
        }

        [TestMethod]
        public void TC2_96MyDuyen()
        {
            Setup();
            // Câu lệnh mở rộng màn hình khi chạy
            driver96_MyDuyen.Manage().Window.Maximize();
            // Thực hiện click vào biểu tượng tài khoản đăng nhập
            driver96_MyDuyen.FindElement(By.ClassName("before-login")).Click();
            // Điền số điện thoại
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$UserName")).SendKeys("0334331308");
            //Điền mật khẩu
            driver96_MyDuyen.FindElement(By.Id("ctl00_mainContent_login1_LoginCtrl_Password")).SendKeys("duyen224");
            // Nhấn đăng nhập
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$Login")).Click();
            Thread.Sleep(3000);     
        }
        [TestMethod]
        public void TC3_96MyDuyen()
        {
            Setup();
            // Câu lệnh mở rộng màn hình khi chạy
            driver96_MyDuyen.Manage().Window.Maximize();
            // Thực hiện click vào biểu tượng tài khoản đăng nhập
            driver96_MyDuyen.FindElement(By.ClassName("before-login")).Click();
            // Điền số điện thoại
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$UserName")).SendKeys("0334331308");
            //Điền mật khẩu
            driver96_MyDuyen.FindElement(By.Id("ctl00_mainContent_login1_LoginCtrl_Password")).SendKeys("duyen123");
            // Nhấn đăng nhập
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$Login")).Click();
            Thread.Sleep(3000);
           
        }
       [TestMethod]
        public void TC4_96MyDuyen()
        {
            Setup();
            // Câu lệnh mở rộng màn hình khi chạy
            driver96_MyDuyen.Manage().Window.Maximize();
            // Thực hiện click vào biểu tượng tài khoản đăng nhập
            driver96_MyDuyen.FindElement(By.ClassName("before-login")).Click();
            // Điền số điện thoại
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$UserName")).SendKeys("0334331307");
            //Điền mật khẩu
            driver96_MyDuyen.FindElement(By.Id("ctl00_mainContent_login1_LoginCtrl_Password")).SendKeys("duyen224");
            // Nhấn đăng nhập
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$Login")).Click();
            Thread.Sleep(3000);          
        }
    }
}
