using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTesting.Pages
{
    public class WaitersPage
    {
        public WaitersPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }



        //  IWebElement RadioBtn => Driver.FindElement(By.CssSelector("#account-creation_form > div:nth-child(1) > div.clearfix > div:nth-child(3) > label"));

        public void Waiters2()
        {

            //waits for E2ETest
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Shop")));





        }
    }
}

