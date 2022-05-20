using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Pom_Calc.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pom_Calc.Tests
{
    public class SumNumberPagesTests
    {
        private ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void Close()
        {
            this.driver.Quit();
        }

        [Test]
        public void Test_Valid_Numbers()
        {
            var sumpage = new SumNumberPage(this.driver);
            sumpage.OpenPage();
            var result = sumpage.AddNumbers("5", "6");

            Assert.That(result, Is.EqualTo("Sum: 11"));
        }
    }
}
