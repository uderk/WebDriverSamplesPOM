using NUnit.Framework;
using Students_UI_Tests_POM.Pages;

namespace Students_UI_Tests_POM.Tests
{
    public class HomePageTests : BaseTests
    {
        [Test]
        public void Test_HomePage_TitleAndHeading()
        {
            var page = new HomePage(driver);
            page.Open();
            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeadingTexts(), Is.EqualTo("Students Registry"));
            Assert.Greater(page.GetStudentsCount(), 0);
        }

        [Test]
        public void Test_HomePage_ViewStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.LinkViewStudentPage.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());
        }

        [Test]
        public void Test_HomePage_OpenAddStudentPage()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.LinkAddStudentPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());
        }

        [Test]
        public void Test_HomePage_ViewHomeLinlk()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.LinkHomePage.Click();
            Assert.IsTrue(home_page.isOpen());
        }
    }
}
