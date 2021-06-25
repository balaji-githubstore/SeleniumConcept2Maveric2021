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
    class Demo19CompleteJs
    {
        static void Main22(string[] args)
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://phptravels.net/home";

            driver.FindElement(By.XPath("//a[@data-name='flights']")).Click();


            driver.FindElement(By.XPath("//span[text()='Economy']")).Click();
            driver.FindElement(By.XPath("//li[text()='Business']")).Click();

            //Daxian (DAX)
            //Los Angeles (LAX)
            //driver.FindElement(By.Id("FlightsDateStart")).SendKeys("2021-06-29");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; //casting
            js.ExecuteScript("document.querySelector('#FlightsDateStart').value='2021-07-28'");
        }
    }
}


