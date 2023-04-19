using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Pages
{
	public class HomePage
	{
		public HomePage(IWebDriver webdriver)
		{
			Driver = webdriver;
		}
        public IWebDriver Driver { get; }



        public IWebElement lnkSignIn => Driver.FindElement(By.XPath("//input[@value='Sign In']"));



        IWebElement Username => Driver.FindElement(By.Id("username"));

        IWebElement txtPass => Driver.FindElement(By.Name("password"));






        public void txtsendKeys() => Username.SendKeys("rahulshettyacademy");
        public void txtsendKeys2() => txtPass.SendKeys("learning");
        public void ClickLogin() => lnkSignIn.Click();


    }
}

