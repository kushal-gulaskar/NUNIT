using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace POM_Trainning.Browser
{

    class Browserr
    {
       static IWebDriver driver = null;

        public static String BrowserName = null;

        public Browserr(IWebDriver driverr)
        {
            driver = driverr;
        }
        /// <summary>
        /// set the Browser in which Application should be opened.
        /// </summary>
        /// <param name="BName">Enter the Name of Browser</param>
        /// <returns>Newly created instance of Respective Browser</returns>
        public static IWebDriver SetBrowserName(String BName)
        {
            switch (BName)
            {
                case "firefox":
                    {
                        driver = new FirefoxDriver();
                        break;
                    }
                case "chrome":
                    {

                        driver = new ChromeDriver();
                        break;
                    }

                case "headless":
                    {

                        ChromeOptions option = new ChromeOptions();
                        option.AddArgument("--headless");
                        driver = new ChromeDriver(option);
                        break;
                    }

                case "ie":
                    {
                        driver = new InternetExplorerDriver();
                        break;
                    }
                default:
                    {
                        driver = null;
                        break;
                    }
            }
            return driver;
        }

        public IWebDriver Setbrowser(String BrowserName)
        {
            driver = SetBrowserName(BrowserName);
            return driver;
        }

        public static void SetURL(String url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebDriver LaunchBrowser(String BrowserName,String url)
        {
            Setbrowser(BrowserName);
            SetURL(url);
            return driver;
        }
        /// <summary>
        /// Close the current Browser/Application
        /// </summary>
        public void Close()
        {
            driver.Close();
        }
    }
}
