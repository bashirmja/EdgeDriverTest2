using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace EdgeDriverTest2
{
    [TestClass]
    public class EdgeDriverTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        private EdgeDriver _driver;

        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            // Initialize edge driver 
            var options = new EdgeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            _driver = new EdgeDriver(options);
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            // Replace with your own test logic
            _driver.Url = "https://www.google.com";
            _driver.FindElement(By.XPath(@"/html/body/div[2]/div[2]/div[3]/span/div/div/div/div[3]/button[2]/div")).Click();
            _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[2]")).Click();

            Assert.AreEqual("Bing", _driver.Title);
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            _driver.Quit();
        }
    }
}
