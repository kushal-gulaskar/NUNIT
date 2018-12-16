using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace POM_Trainning.Pages
{
    class Login
    {
        private readonly IWebDriver _driver;
        //Object Repository

        public Login(IWebDriver browser)
        {
            _driver = browser;
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Name, Using = "uid")]
        public IWebElement Uname;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Pass;

        [FindsBy(How = How.Name, Using = "btnLogin")]
        public IWebElement LoginButton;


        public void EnterUname(string textToType)
        {
            Uname.SendKeys(textToType);
        }

        public void EnterPassword(string textToType)
        {
            Pass.SendKeys(textToType);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public void Loginnn(string Uname, string pass)
        {
            EnterUname(Uname);
            EnterPassword(pass);
            ClickLogin();
        }

        public string GetLoginTitle()
        {
            
            return _driver.Title;
        }
    }
}
