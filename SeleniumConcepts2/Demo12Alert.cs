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
    class Demo12Alert
    {
        static void Main22(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://www.echoecho.com/javascript4.htm";

            Thread.Sleep(2000);
            driver.FindElement(By.Name("B3")).Click();

            Thread.Sleep(2000);
            string alertText= driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);

            driver.SwitchTo().Alert().SendKeys("test123");

            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Dismiss();

            

        }
    }
}


