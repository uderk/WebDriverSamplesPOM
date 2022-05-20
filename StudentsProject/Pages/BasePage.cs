using OpenQA.Selenium;
using System;

namespace Students_UI_Tests_POM.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public IWebElement LinkHomePage => driver.FindElement(By.LinkText("Home"));
        public IWebElement LinkViewStudentPage => driver.FindElement(By.LinkText("View Students"));
        public IWebElement LinkAddStudentPage => driver.FindElement(By.LinkText("Add Student"));
        public IWebElement ElementPageHeading => driver.FindElement(By.CssSelector("body > h1"));

        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool isOpen()
        {
            return driver.Url == this.PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeadingTexts()
        {
            return ElementPageHeading.Text;
        }
    }
}
