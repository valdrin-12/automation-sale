using System;
using System.Xml.Linq;
using OpenQA.Selenium;

namespace AutomationTesting.Pages
{
	public class LogIn
	{
        public LogIn(IWebDriver webdriver)
        {
            Driver = webdriver;
        }
        public IWebDriver Driver { get; }



        public IWebElement addproduct => Driver.FindElement(By.CssSelector("body > app-root > app-shop > div > div > div.col-lg-9 > app-card-list > app-card:nth-child(1) > div > div.card-footer > button"));


        public IWebElement Clickcheckout => Driver.FindElement(By.PartialLinkText("Checkout"));

       // By.PartialLinkText("Shop")

        public void Clickadd() => addproduct.Click();


        public void ClickctoCheck() => Clickcheckout.Click();





    }
}

