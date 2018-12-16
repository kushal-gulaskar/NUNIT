using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.TestsProject
{
    [TestFixture]
    public class TestClass
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.co.in");
            driver.Manage().Window.Maximize();
        }

        [Test, Parallelizable]
        public void TestMethod1()
        {
            driver.FindElement(By.XPath(".//*[@id='tsf']/div[2]/div[3]/center/input[1]")).Click();
            Assert.IsTrue(true, "Passed");
        }

        [Test]
        public void TestMethod2()
        {
            driver.FindElement(By.XPath(".//*[@id='tsf']/div[2]/div[3]/center/input[1]")).Click();
            Assert.IsTrue(true, "Passed");
        }

        [Test]
        public void TestMethod3()
        {
            driver.FindElement(By.Id("gs_htif0")).SendKeys("kushal gulaskar");
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
