using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts2
{
    class FrameDemo
    {
        static void Main22(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame("login_page");

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("test123");
            //click on continue
            driver.FindElement(By.XPath("//img[@alt='continue']")).Click();

            //come to main html
            driver.SwitchTo().DefaultContent();



        }
    }
}


