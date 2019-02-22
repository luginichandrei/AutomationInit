using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    public class Test
    {
        public void ActionGo()
        {
            using (IWebDriver Browser = new ChromeDriver())
            {
                Browser.Navigate().GoToUrl("https://app.pluralsight.com/id?redirectTo=%2Fid%2Fdashboard");

                IWebElement elementUserName = Browser.FindElement(By.Id("Username"));
                elementUserName.SendKeys("semeniuc97@gmail.com");
                IWebElement elementPassword = Browser.FindElement(By.Id("Password"));
                elementPassword.SendKeys("!234qwer" + Keys.Enter);
                Browser.Quit();
            }
        }
    }
}