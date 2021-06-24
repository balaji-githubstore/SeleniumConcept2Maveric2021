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
    class Demo15WebTable
    {
        static void Main22(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            SelectElement select = new SelectElement(driver.FindElement(By.Name("example_length")));
            select.SelectByText("100");


             int rowCount= driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;

            for (int i = 1; i <= rowCount; i++)
            {
                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;
                Console.WriteLine(name);
            }

            int totalLink= driver.FindElements(By.TagName("a")).Count;
            Console.WriteLine(totalLink);

        }
    }
}


