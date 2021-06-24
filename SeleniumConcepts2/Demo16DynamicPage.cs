using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;
namespace SeleniumConcepts2
{
    class Demo16DynamicPage
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.royalcaribbean.com/";

            driver.FindElement(By.XPath("//*[@class='email-capture__close']")).Click();

            driver.FindElement(By.Id("rciHeaderSignIn")).Click();

            driver.FindElement(By.LinkText("Create an account")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("bala");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("dina");

            //April 4 1992
            driver.FindElement(By.XPath("//span[text()='Month']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'December')]")).Click();
            
            driver.FindElement(By.XPath("//span[contains(text(),'Day')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'30')]")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("2000");

            driver.FindElement(By.XPath("//span[contains(text(),'Country/Region of residence')]")).Click();
            driver.FindElement(By.XPath("(//span[contains(text(),'India')])[2]")).Click();
        }
    }
}


