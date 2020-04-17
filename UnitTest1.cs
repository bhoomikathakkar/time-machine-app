using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace Desktop_Demo
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
       // private object windriver;

        [TestMethod]
        public void signin()
        {
            var dc = new DesiredCapabilities();
            dc.SetCapability("app", "C:/Users/thakkar/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/ContradoStaff/ContradoStaff.appref-ms");
            var driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
         
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Application launch successfully");
            driver.FindElement(By.Name("Recent")).SendKeys("1554587");
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.ClassName("WindowsForms10.BUTTON.app.0.2780b98_r9_ad1")).Submit();

            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("button click successfully");
            System.Threading.Thread.Sleep(5000);
           Boolean msg = driver.FindElement(By.XPath(".//ListItem[contains(.,'STAFF NOT  FOUND :']")).Displayed;
           //driver.FindElement(By.Name("STAFFNOTFOUND")).Displayed;
           // Console.WriteLine(msg);
          //Assert.AreEqual("STAFF NOT  FOUND:", msg,"login successfully");
           
        }
     
    }
}
