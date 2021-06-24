using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts2
{
    class MultipleTab2
    {
        static void Main22(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            //switch to new tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.LinkText("Travel")).Click();
            driver.FindElement(By.Id("Email_Id")).SendKeys("bala@gmail.com");

            driver.Close();

            //switch to tab index 0
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            Console.WriteLine(driver.Title);
        }
    }
}


