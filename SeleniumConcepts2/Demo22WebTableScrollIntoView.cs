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
    class Demo22Webtable
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://datatables.net/examples/basic_init/scroll_y.html";


             int rowCount= driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;
            //document.querySelector("#main").scrollIntoView()

            for (int i = 1; i <= rowCount; i++)
            {

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver; //casting

                js.ExecuteScript("document.querySelector('[class=\"dataTables_scrollBody\"]').scrollBy(0,50)");

                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;
                Console.WriteLine(name);
            }

            int totalLink= driver.FindElements(By.TagName("a")).Count;
            Console.WriteLine(totalLink);

        }
    }
}


