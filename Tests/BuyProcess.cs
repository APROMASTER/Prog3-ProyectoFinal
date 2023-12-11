using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class BuyProcess : BaseTest
    {
        public BuyProcess(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void IsBuyProccessStartCorrectly()
        {
            GoToBuyProcessPage();
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/buyprocess.html?");
            RecordTestResult(currentTestName, TestResult.Pass);
        }


        [Fact]
        public void CanBuyProccessChangeBuyMethod()
        {
            GoToBuyProcessPage();
            var buyButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/p[1]/input"));
            buyButton.Click();
            Assert.True(true);
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void CanDoBuyProccess()
        {
            GoToBuyProcessPage();
            var buyButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/p[1]/input"));
            buyButton.Click();
            var doBuyProcessButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/button"));
            doBuyProcessButton.Click();
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/buysuccesfull.html?buymode=efectivo");
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        void GoToBuyProcessPage()
        {
            var product = Driver.FindElement(By.XPath("//*[@id=\"listproduct\"]/div[1]/a/img"));
            product.Click();

            var addProductShoppingCartButton = Driver.FindElement(By.XPath("//*[@id=\"productdetail\"]/div/div[2]/form[2]/button"));
            addProductShoppingCartButton.Click();

            var buyButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div/button"));
            buyButton.Click();
        }
    }
}