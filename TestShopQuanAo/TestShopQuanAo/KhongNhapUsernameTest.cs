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
public class KhongNhapUsernameTest
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
    public void khongNhapUsername()
    {
        driver.Navigate().GoToUrl("http://localhost:27660/TaiKhoan/DangKy");
        driver.Manage().Window.Size = new System.Drawing.Size(1040, 728);
        driver.FindElement(By.Name("UserName")).SendKeys("nhung12");
        driver.FindElement(By.Name("Pass")).SendKeys("nhung1234");
        driver.FindElement(By.Name("RePass")).SendKeys("nhung1234");
        driver.FindElement(By.Name("Ten")).SendKeys("Nguyễn Ngọc Nhung");
        driver.FindElement(By.Name("NgaySinh")).SendKeys("31/12/2001");//lỗi ngày và tháng
        driver.FindElement(By.Name("Email")).SendKeys("nhung@gmail.com");
        driver.FindElement(By.Name("SDT")).SendKeys("0362417182");
        driver.FindElement(By.Name("DiaChi")).SendKeys("Tân Phú");
        driver.FindElement(By.CssSelector(".btnSignUp")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(2) > .field-validation-error")).Text, Is.EqualTo("Vui lòng nhập vào username"));
        Thread.Sleep(2000);
    }
}
