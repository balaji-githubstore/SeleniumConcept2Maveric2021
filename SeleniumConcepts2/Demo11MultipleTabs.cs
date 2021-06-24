using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts2
{
    class Program11
    {
        static void Main11(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("User_Id")).SendKeys("bala");

            

        }
    }
}


