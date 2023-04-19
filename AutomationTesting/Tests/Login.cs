using AutomationTesting.Pages;
using EdNunit.Pages;
//using AutomationTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Tests
{
    class Login
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/loginpagePractise/");
        }
        [Test]
        public void Login1()
        {

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HomePage homePage = new(webDriver);
            homePage.txtsendKeys();
           //nnnnnnnnnnnnnnnnn
            homePage.txtsendKeys2();
            homePage.ClickLogin();


            LogIn loginpage= new(webDriver);

            loginpage.Clickadd();
            WaitersPage waitP= new(webDriver);


            waitP.Waiters2();

            loginpage.ClickctoCheck();

            Screenshots screen = new(webDriver);
            screen.screenshots();



        }
       


    }
}
