﻿using OpenQA.Selenium;

namespace PageObjects.PageObjects
{
    public class TargetPage
    {
        #region locators
        IWebElement Message => driver.FindElement(By.Id("message"));
        #endregion locators

        IWebDriver driver;

        public TargetPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region methods
        public string GetMessage()
        {
            return Message.Text;
        }
        #endregion methods
    }
}
