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
public class TestDNKhongNhapGiTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver(@"C:\Users\Na\Desktop\TestShopQuanAo");
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  public void TearDown() {
    driver.Quit();
  }
  [Test]
  public void testDNKhongNhapGi() {
    driver.Navigate().GoToUrl("http://localhost:27660/");
    driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
    driver.FindElement(By.CssSelector(".header__top__links:nth-child(1) > a")).Click();
    driver.FindElement(By.Name("username")).SendKeys("");
    driver.FindElement(By.Name("pw")).SendKeys("");
    driver.FindElement(By.Id("btnSignin")).Click();
        Thread.Sleep(2000);
    Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(2) > .text-danger")).Text, Is.EqualTo("Tên đăng nhập không được bỏ trống"));
    Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(3) > .text-danger")).Text, Is.EqualTo("Vui lòng nhập mật khẩu"));
  }
    public void testDNSai()
    {
        driver.Navigate().GoToUrl("http://localhost:27660/");
        driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        driver.FindElement(By.CssSelector(".header__top__links:nth-child(1) > a")).Click();
        driver.FindElement(By.Name("username")).SendKeys("na1");
        driver.FindElement(By.Name("pw")).SendKeys("123");
        driver.FindElement(By.Id("btnSignin")).Click();
        Thread.Sleep(2000);
        driver.SwitchTo().Alert().Accept();
        Thread.Sleep(2000);
    }
    public void testDNKhongNhapUsername()
    {
        driver.Navigate().GoToUrl("http://localhost:27660/");
        driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        driver.FindElement(By.CssSelector(".header__top__links:nth-child(1) > a")).Click();
        driver.FindElement(By.Name("username")).SendKeys("");
        driver.FindElement(By.Name("pw")).SendKeys("123");
        driver.FindElement(By.Id("btnSignin")).Click();
        Thread.Sleep(2000);
        Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(2) > .text-danger")).Text, Is.EqualTo("Tên đăng nhập không được bỏ trống"));
    }
    public void testDNKhongNhapPass()
    {
        driver.Navigate().GoToUrl("http://localhost:27660/");
        driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
        driver.FindElement(By.CssSelector(".header__top__links:nth-child(1) > a")).Click();
        driver.FindElement(By.Name("username")).SendKeys("na");
        driver.FindElement(By.Name("pw")).SendKeys("");
        driver.FindElement(By.Id("btnSignin")).Click();
        Thread.Sleep(2000);
        Assert.That(driver.FindElement(By.CssSelector(".form-floating:nth-child(3) > .text-danger")).Text, Is.EqualTo("Vui lòng nhập mật khẩu"));
    }
}
