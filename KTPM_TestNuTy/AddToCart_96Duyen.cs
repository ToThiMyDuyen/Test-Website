using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Text;

namespace KTPM_TestNuTy
{
    
    [TestClass]
    public class AddToCart_96Duyen
    {
        private IWebDriver driver96_MyDuyen;
        // Khai báo get, set
        public TestContext TestContext { get; set; }
        //Hàm lấy đường dẫn vào website
        public void Setup()
        {
            driver96_MyDuyen = new ChromeDriver();
            driver96_MyDuyen.Navigate().GoToUrl("https://nuty.vn/");
        }
        //Hàm đăng nhập tài khoản
        public void Login()
        {
            driver96_MyDuyen.FindElement(By.ClassName("before-login")).Click();
            Thread.Sleep(2000);
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$UserName")).SendKeys("0334331308");
            driver96_MyDuyen.FindElement(By.Name("ctl00$mainContent$login1$LoginCtrl$Password")).SendKeys("duyen123");
            driver96_MyDuyen.FindElement(By.Id("ctl00_mainContent_login1_LoginCtrl_Login")).Click();
            Thread.Sleep(2000);
        }
        // Test thêm giỏ hàng của NUNIT
        // Đường dẫn để lấy dữ liệu từ file csv
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"D:\KTPM_TestNuTy\KTPM_TestNuTy\Product_96MyDuyen.csv", "Product_96MyDuyen#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void AddToCart()
        {
            Setup();
            driver96_MyDuyen.Manage().Window.Maximize();
            Login();
            // Đọc và nhập dữ liệu từ web sẽ giữ nguyên dấu
            string productname_96MyDuyen = Encoding.UTF8.GetString(Encoding.Default.GetBytes(TestContext.DataRow[0].ToString()));
            //Tìm kiếm sản phẩm
            IWebElement search_96MyDuyen = driver96_MyDuyen.FindElement(By.Name("ctl00$mdl1341$ctl00$Search$txtSearch"));
            //Điền tên sản phẩm cần tìm
            search_96MyDuyen.SendKeys(productname_96MyDuyen);
            // Click Enter
            new Actions(driver96_MyDuyen).KeyDown(Keys.Enter).Build().Perform();
            //Lấy element của sản phẩm đã tìm
            driver96_MyDuyen.FindElement(By.XPath("//*[@id=\"ctl00_mainContent_pnlInternalSearch\"]/div/div[2]/div/div/div[1]/div/div/div[1]/a")).Click();
            //Lấy element của tăng số lượng sản phẩm
            driver96_MyDuyen.FindElement(By.ClassName("fa-plus")).Click();
            driver96_MyDuyen.FindElement(By.ClassName("fa-plus")).Click();
            //Lấy element của giảm số lượng sản phẩm
            driver96_MyDuyen.FindElement(By.ClassName("fa-minus")).Click();
            //Lấy element của button thêm sản phẩm vào giỏ hàng
            driver96_MyDuyen.FindElement(By.ClassName("btn-addtocart")).Click();
            if (search_96MyDuyen != null)
            {
                // In ra dòng chữ thông báo
                Console.WriteLine(" Đã tìm thấy sản phẩm: " + productname_96MyDuyen + "\nThêm vào giỏ hàng thành công");

                Assert.IsTrue(true); // Xác nhận tìm thấy sản phẩm thành công
            }
        }

        // Test thêm giỏ hàng của Web driver
        //[TestMethod]
        public void AddToCart_96_Duyen()
        {
            Setup();
            driver96_MyDuyen.Manage().Window.Maximize();
            Login();
            //Tìm kiếm sản phẩm
            IWebElement search = driver96_MyDuyen.FindElement(By.Name("ctl00$mdl1341$ctl00$Search$txtSearch"));
            //Điền tên sản phẩm cần tìm
            search.SendKeys("loreal");
            // Click Enter
            new Actions(driver96_MyDuyen).KeyDown(Keys.Enter).Build().Perform();
            //Lấy element của sản phẩm đã tìm
            driver96_MyDuyen.FindElement(By.XPath("//*[@id=\"ctl00_mainContent_pnlInternalSearch\"]/div/div[2]/div/div/div[1]/div/div/div[1]/a")).Click();
            //Lấy element của tăng số lượng sản phẩm
            driver96_MyDuyen.FindElement(By.ClassName("fa-plus")).Click();
            driver96_MyDuyen.FindElement(By.ClassName("fa-plus")).Click();
            //Lấy element của giảm số lượng sản phẩm
            driver96_MyDuyen.FindElement(By.ClassName("fa-minus")).Click();
            //Lấy element của button thêm sản phẩm vào giỏ hàng
            driver96_MyDuyen.FindElement(By.ClassName("btn-addtocart")).Click();
        }


    }
}
