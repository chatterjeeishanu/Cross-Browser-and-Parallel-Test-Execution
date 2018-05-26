using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject___Facebook_Login.Global;

namespace UnitTestProject___Facebook_Login.Pages
{
    public class Login
    {
        //Common locCommon = new Common();
        public void Navigation(IWebDriver driver)
        {            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }
        public void Credentials(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("Type your user name");
            driver.FindElement(By.Id("pass")).SendKeys("Type your password");
            driver.FindElement(By.XPath("//*[@id='loginbutton']")).Click();
        }
    }
}
