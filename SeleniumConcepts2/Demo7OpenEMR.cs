﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumConcepts2
{
    class OpenEMR
    {
        static void Main11(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys("pass");

            SelectElement select = new SelectElement(driver.FindElement(By.CssSelector("[name='languageChoice']")));
            select.SelectByText("English (Indian)");

            driver.FindElement(By.CssSelector("[type='submit']")).Click();

            //wait for page load completes //explicit wait
            //print the title
            String actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.Id("username"))).Perform();

            //click on logout //presence and visible 
            driver.FindElement(By.XPath("//li[text()='Logout']")).Click();

           

        }
    }
}


