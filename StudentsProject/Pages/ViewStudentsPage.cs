using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Linq;

namespace Students_UI_Tests_POM.Pages
{
    public class ViewStudentsPage : BasePage
    {
        public ViewStudentsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/students";

        public ReadOnlyCollection<IWebElement> ListItemsStudents =>
            driver.FindElements(By.CssSelector("body > ul > li"));

        public string[] GetRegisteredStudents()
        {
            var elementsStudent = this.ListItemsStudents.Select(s => s.Text).ToArray();
            return elementsStudent;
        }
    }
}
