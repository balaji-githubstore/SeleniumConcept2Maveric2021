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
    class Demo18Upload
    {
        static void Main22(string[] args)
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.naukri.com/";

            driver.FindElement(By.Id("file_upload")).SendKeys(@"D:\Profile.docx");

            Thread.Sleep(5000);
            Console.WriteLine(driver.PageSource.Contains("uploaded Successfully"));

        }
    }
}


