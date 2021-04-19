using NUnit.Framework;
using System.IO;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject_NUnit_
{
    public class Tests
    {
        String test_url = "https://www.999.md";

        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.ClassName("tt-input"));

            searchText.SendKeys("computer");

            IWebElement searchButton = driver.FindElement(By.ClassName("header__search__button"));

            System.Threading.Thread.Sleep(3000);

            searchButton.Click();

            System.Threading.Thread.Sleep(3000);

            
            Console.WriteLine(driver.FindElement(By.ClassName("header_bar_logo")).Displayed.ToString());

            /*
            Boolean result = driver.FindElement(By.ClassName("header_bar_logo")).Displayed;
            if (result)
            {
                Console.WriteLine("Header is present");
            }
            */

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}