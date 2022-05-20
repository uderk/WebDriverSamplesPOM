using NUnit.Framework;
using Students_UI_Tests_POM.Pages;
using System;
using System.Linq;

namespace Students_UI_Tests_POM.Tests
{
    public class AddStudentTests : BaseTests
    {
        [Test]
        public void Test_AddStudentPage_TitleAndHeading()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            Assert.That(add_Student.GetPageTitle(), Is.EqualTo("Add Student"));
            Assert.That(add_Student.GetPageHeadingTexts(), Is.EqualTo("Register New Student"));
        }

        [Test]
        public void Test_AddStudentPage_EmptyFields()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            Assert.That(add_Student.EmailName.Text, Is.EqualTo(""));
        }

        [Test]
        public void Test_AddStudentPage_AddValidStudent()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            string name = "Pesho" + DateTime.Now.Ticks;
            string email = "Pesho" + DateTime.Now.Ticks + "@gmail.com";
            add_Student.AddStudent(name, email);
            var view_student = new ViewStudentsPage(driver);
            Assert.IsTrue(view_student.isOpen());
            var students = view_student.GetRegisteredStudents();
            var lastStudent = students.Last();
            string expected = name + " (" + email + ")";
            Assert.Contains(lastStudent, students);
        }

        [Test]
        public void Test_AddStudentPage_AddInValidStudent()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            string name = "";
            string email = "";
            add_Student.AddStudent(name, email);
            Assert.IsTrue(add_Student.isOpen());
            Assert.That(add_Student.ErrorMessage.Text, Is.EqualTo("Cannot add student. Name and email fields are required!"));
        }
    }
}
