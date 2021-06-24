using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumConcepts2
{
    class MultipleTabs
    {
        static void Main11(string[] args)
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            string parent = driver.CurrentWindowHandle;
            Console.WriteLine(parent);

            ReadOnlyCollection<string> windows= driver.WindowHandles;
            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);

            Console.WriteLine("-----------------------------");
            Console.WriteLine(driver.Title);

            Console.WriteLine("Switching to new tab!!");
            driver.SwitchTo().Window(windows[1]);

            Console.WriteLine(driver.Title);

            driver.Close();

        }
    }
}


