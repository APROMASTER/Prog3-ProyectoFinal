using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class StartPage : BaseTest
    {
        public StartPage(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void IsStartPageLoaded()
        {
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/home.html");
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void IsStartPageShowingSomething()
        {
            var element = Driver.FindElement(By.XPath("//*[@id=\"listproduct\"]/div[3]/a/img"));
            Actions actions = new Actions(Driver);
            actions.ScrollToElement(element);
            bool result = false;
            try
            {
                actions.Perform();
            }
            catch
            {
                result = true;
            }
            Assert.True(result);
            RecordTestResult(currentTestName, TestResult.Pass);
        }
    }
}