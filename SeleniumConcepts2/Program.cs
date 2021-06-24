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
    class Program
    {
        static void Main(string[] args)
        {
            //Balaji
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--disable-notifications");

            IWebDriver driver = new ChromeDriver(option);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.irctc.co.in/nget/train-search";

            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
            driver.FindElement(By.XPath("//input[@role='searchbox']")).SendKeys("chenn");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()='CHENNAI EGMORE - MS']")).Click();

            driver.FindElement(By.XPath("//span[text()='All Classes']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()='AC 2 Tier (2A)']")).Click();

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}


