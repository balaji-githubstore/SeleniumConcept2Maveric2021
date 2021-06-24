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
    class WebTable
    {
        static void Main4(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";


            //click on checkbox
            for (int i = 1; i <= 10; i++)
            {
                string name = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;
                Console.WriteLine(name);

                if (name.Equals("Brenden Wagner"))
                {
                    driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[1]")).Click();
                    break;
                }
            }

            /*   IWebDriver driver = new ChromeDriver();
               //InternetExplorerDriver driver = new InternetExplorerDriver();
               //FirefoxDriver driver = new FirefoxDriver();

               driver.Url = "https://www.pepperfry.com/";
               driver.Manage().Window.Maximize();
               driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);



               driver.FindElement(By.Id("search")).SendKeys("bedsheets");

               driver.FindElement(By.Id("searchButton")).Click();

               //close the popup

               //IJavaScriptExecutor j = (IJavaScriptExecutor)driver;
               //j.ExecuteScript("window.scrollBy(0,500)");

               // driver.FindElement(By.Id("brandsnameSleep_Dove")).Click();
               driver.FindElement(By.XPath("//label[@for='brandsnameSleep_Dove']")).Click();

   */
            // driver.Quit();

        }
    }
}


