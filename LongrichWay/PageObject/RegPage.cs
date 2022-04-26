using LongrichWay.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongrichWay.PageObject
{
    public class RegPage
    {
        public IWebDriver driver;
        public RegPage()
        {
            driver = WebHooks.driver;
        }
        private By register = By.XPath("//input[@id='firstname']");
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public void ClickRegister()
        {
            driver.FindElement(register).Click();

        }
       
    }
}
