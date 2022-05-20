using OpenQA.Selenium;

namespace Students_UI_Tests_POM.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";
        public IWebElement ElementStudentCount => driver.FindElement(By.CssSelector("body > p > b"));


        public int GetStudentsCount()
        {
            string studentCountText = this.ElementStudentCount.Text;
            return int.Parse(studentCountText);
        }
    }
}
