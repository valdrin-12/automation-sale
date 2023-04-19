using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EdNunit
{
    public class Tests1
    {

        public IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
            webDriver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            webDriver.Navigate().GoToUrl("https://egjeta.com/");

            IWebElement lnkSignIn = webDriver.FindElement(By.Id("account_info_6517"));

            lnkSignIn.Click();
            //webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement lnkkycu = webDriver.FindElement(By.CssSelector("#dropdown_345 > div.ty-account-info__buttons.buttons-container > a.cm-dialog-opener.cm-dialog-auto-size.ty-btn.ty-btn__secondary"));

            lnkkycu.Click();


            IWebElement txtEmail = webDriver.FindElement(By.Id("login_popup6517"));
            // Assert.That(txtEmail.Displayed, Is.True);

            txtEmail.SendKeys("valdrin.qerimi1@gmail.com");


            IWebElement txtPass = webDriver.FindElement(By.Id("psw_popup6517"));


            txtPass.SendKeys("1234qwer");

            IWebElement createLogin = webDriver.FindElement(By.Name("dispatch[auth.login]"));

            createLogin.Click();

            IWebElement lnkbic = webDriver.FindElement(By.CssSelector(""));

            lnkbic.Click();





            // IWebElement RadioBtn = webDriver.FindElement(By.CssSelector("#account-creation_form > div:nth-child(1) > div.clearfix > div:nth-child(3) > label"));
            // RadioBtn.Click();
            //  IWebElement txtName = webDriver.FindElement(By.Id("customer_firstname"));
            // txtName.SendKeys("valdrin");
            // IWebElement txtLastName = webDriver.FindElement(By.Id("customer_lastname"));
            //  txtLastName.SendKeys("qerimi");
            //IWebElement txtEmail => Driver.FindElement(By.Name("email"));
            //   IWebElement txtPassword = webDriver.FindElement(By.Id("passwd"));
            // txtPassword.SendKeys("ghhhhhhhhhhh");







            Console.WriteLine("test1");

            Assert.Pass();
        }
    }
}