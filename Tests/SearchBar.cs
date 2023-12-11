using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class SearchBar : BaseTest
    {
        public SearchBar(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void IsSeachBarShowingCorrectly()
        {
            var searchBar = Driver.FindElement(By.XPath("/html/body/div/nav/div/form/input"));
            Assert.True(searchBar.Displayed);
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void IsSearchBarWorkingProperly()
        {
            string[] searchs = {"Gominola", "2", "Producto"};

            var searchBar = Driver.FindElement(By.XPath("/html/body/div/nav/div/form/input"));
            foreach (var search in searchs)
            {
                searchBar.SendKeys(search + Keys.Return);
                if (Driver.Url != $"file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/search.html?search={search}") throw new Exception("No cargo la busqueda correcta.");
                searchBar = Driver.FindElement(By.XPath("/html/body/div/nav/div/form/input"));
            }
            Assert.True(true);
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void IsSearchBarEasyToUse()
        {
            string search = "Hola";
            var searchBar = Driver.FindElement(By.XPath("/html/body/div/nav/div/form/input"));
            searchBar.SendKeys(search);
            var searchButton = Driver.FindElement(By.XPath("/html/body/div/nav/div/form/button"));
            searchButton.Click();
            Assert.True(Driver.Url == $"file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/search.html?search={search}");
            RecordTestResult(currentTestName, TestResult.Pass);
        }
    }
}