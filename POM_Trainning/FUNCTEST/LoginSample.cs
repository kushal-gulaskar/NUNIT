using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM_Trainning.Pages;
using POM_Trainning.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Trainning.FUNCTEST
{
    [TestFixture]
    public class LoginSample
    {
        public IWebDriver driver;
        

        [SetUp]
        public void SetUp()
        {
            // var Br = new Browserr(driver);
            Browserr obj = new Browserr(driver);

             driver= obj.Setbrowser("chrome");
            Browserr.SetURL("http://demo.guru99.com/V4/");
        }

        [Test]
        public void Login()
        {
            var LoginSampl = new Login(driver);
            LoginSampl.Loginnn("mngr118955", "EdEbagy");
            Assert.AreEqual(LoginSampl.GetLoginTitle(),"Guru99 Bank Manager HomePage");
        }

        [TearDown]
        public void EndTest()
        {
            var Br = new Browserr(driver);
            Br.Close();
        }
    }
}
