// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class TestDangKy
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver(@"C:\Users\Na\Desktop\TestShopQuanAo");
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void dangKy()
    {
        driver.Navigate().GoToUrl("http://localhost:27660/TaiKhoan/DangKy");
        driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        driver.FindElement(By.Name("UserName")).SendKeys("qqqqqqqq");
        driver.FindElement(By.Name("Pass")).SendKeys("qqqqqqqqqqq");
        driver.FindElement(By.Name("RePass")).SendKeys("qqqqqqqqqqq");
        driver.FindElement(By.Name("Ten")).SendKeys("rrrrrr");
        driver.FindElement(By.Name("NgaySinh")).SendKeys("2022-05-30");
        driver.FindElement(By.Name("Email")).SendKeys("www");
        driver.FindElement(By.Name("SDT")).SendKeys("0963273900");
        driver.FindElement(By.Name("DiaChi")).SendKeys("aaâ");
        driver.FindElement(By.CssSelector(".btnSignUp")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(2) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(3) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(4) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(5) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(6) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(7) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(8) > .field-validation-error")).Click();
        driver.FindElement(By.CssSelector(".form-floating:nth-child(9) > .field-validation-error")).Click();
    }

    public void dangKy(string pUsername, string pPw, string pRpw, string pHoTen, string pNgSinh, string pEmail, string pSDT, string pDiaChi, int pTask, string pKq = "")
    {
        driver.Navigate().GoToUrl("http://localhost:27660/TaiKhoan/DangKy");
        driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        driver.FindElement(By.Name("UserName")).SendKeys(pUsername);
        driver.FindElement(By.Name("Pass")).SendKeys(pPw);
        driver.FindElement(By.Name("RePass")).SendKeys(pRpw);
        driver.FindElement(By.Name("Ten")).SendKeys(pHoTen);
        driver.FindElement(By.Name("NgaySinh")).SendKeys(pNgSinh);
        driver.FindElement(By.Name("Email")).SendKeys(pEmail);
        driver.FindElement(By.Name("SDT")).SendKeys(pSDT);
        driver.FindElement(By.Name("DiaChi")).SendKeys(pDiaChi);

        Thread.Sleep(2000);

        driver.FindElement(By.CssSelector(".btnSignUp")).Click();

        js.ExecuteScript("window.scrollBy(0,280)");

        Thread.Sleep(4000);

        if (pTask == 1) // kiểm tra hết các trường không nhập gì
        {
            if (string.IsNullOrEmpty(pUsername))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(2) > .field-validation-error")).Text, Is.EqualTo("Enter username"));
            if (string.IsNullOrEmpty(pPw))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(3) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào mật khẩu"));
            if (string.IsNullOrEmpty(pRpw))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(4) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào nhập lại mật khẩu"));
            if (string.IsNullOrEmpty(pHoTen))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(5) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào họ tên"));
            if (string.IsNullOrEmpty(pNgSinh))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(6) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào ngày tháng năm sinh"));
            if (string.IsNullOrEmpty(pEmail))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(7) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào địa chỉ email"));
            if (string.IsNullOrEmpty(pSDT))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(8) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào số điện thoại"));
            if (string.IsNullOrEmpty(pDiaChi))
                Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(9) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào địa chỉ"));
        } else // các trường hợp khác (pTask [2, 9])
        {
            Thread.Sleep(100);

            Assert.That(driver.FindElement(By.CssSelector(string.Format(".form-floating:nth-child({0}) > .field-validation-valid", pTask))).Text, Is.EqualTo(pKq));
        }


    }
}
