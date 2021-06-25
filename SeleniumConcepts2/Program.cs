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

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.CssSelector("[name='languageChoice']")));
            select.SelectByText("English (Indian)");

            driver.FindElement(By.CssSelector("[type='submit']")).Click();

            String actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            //click on logout //presence and visible 
            //driver.FindElement(By.XPath("//li[text()='Logout']")).Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; //casting
            js.ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//li[text()='Logout']")));

            //js.ExecuteScript("arguments[0].scrollIntoView()", driver.FindElement(By.XPath("//li[text()='Logout']")));

        }
    }
}


