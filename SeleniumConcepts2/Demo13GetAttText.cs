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
    class Demo13GetAttText
    {
        static void Mai1n(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            string usernamePlaceHolderAtt = driver.FindElement(By.Id("authUser")).GetAttribute("placeholder");
            Console.WriteLine(usernamePlaceHolderAtt);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            String tagname = driver.FindElement(By.XPath("//div[contains(text(),'Invalid')]")).TagName;
            Console.WriteLine(tagname);

            String actualValue = driver.FindElement(By.XPath("//div[contains(text(),'Invalid')]")).Text;
            Console.WriteLine(actualValue);

            String actualValue2 = driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
            Console.WriteLine(actualValue2);

            string href = driver.FindElement(By.PartialLinkText("Licensing")).GetAttribute("href");
            Console.WriteLine(href);

            string text = driver.FindElement(By.PartialLinkText("Licensing")).Text;
            Console.WriteLine(text);
        }
    }
}


