using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts2
{
    class GotoMeeting
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.gotomeeting.com/en-in";

            driver.FindElement(By.LinkText("Start for Free")).Click();

            driver.FindElement(By.Id("truste-consent-button")).Click();

            driver.FindElement(By.Id("first-name")).SendKeys("bala");
            driver.FindElement(By.Id("last-name")).SendKeys("dina");
            driver.FindElement(By.Id("login__email")).SendKeys("dina@gmail1.com");
            driver.FindElement(By.Id("contact-number")).SendKeys("78787887");
            SelectElement select = new SelectElement(driver.FindElement(By.Id("JobTitle")));
            select.SelectByText("Help Desk");
            driver.FindElement(By.Id("login__password")).SendKeys("bala#123");
  
            driver.FindElement(By.XPath("//input[@value='10 - 99']")).Click();

            driver.FindElement(By.XPath("//button[text()='Sign Up']")).Click();



        }
    }
}


