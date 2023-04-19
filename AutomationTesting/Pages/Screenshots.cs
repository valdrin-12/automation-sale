using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Pages
{
    public class Screenshots
    {
        public Screenshots(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }




        public void screenshots()
        {

            ITakesScreenshot screenshot = ((ITakesScreenshot)Driver);
            Screenshot ss = screenshot.GetScreenshot();
            string filepath = "/Users/macbookpro/Desktop/demo/AutomationTesting/AutomationTesting";
            ss.SaveAsFile(filepath + "screenshot123" + ".png", ScreenshotImageFormat.Png);

        }
        //*[@id="login_form"]

        


        

        





    }
}
