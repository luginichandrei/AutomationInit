using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitTest
{
    [TestFixture]
    public class AutomationCore
    {
        [SetUp]
        public void startTest()
        {
            Browsers.Init();
        }

        [Test]
        public void blogTest()
        {
            Browsers.getDriver.FindElement(By.Id("menu-item-1296")).Click();
            Assert.IsTrue(Pages.contactUs.isAt());
        }

        [TearDown]
        public void endtest()
        {
            Browsers.Close();
        }
    }
}