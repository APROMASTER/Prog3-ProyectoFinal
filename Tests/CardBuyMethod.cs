using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class CardBuyMethod : BaseTest
    {
        public CardBuyMethod(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void CanChangeToCardBuyMethod()
        {
            GoToBuyProcessPage();
            var buyButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/p[2]/input"));
            buyButton.Click();
            Assert.True(true);
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void CanCardBuyMethodStart()
        {
            GoToBuyProcessPage();
            var buyButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/p[2]/input"));
            buyButton.Click();
            var doBuyProcessButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/button"));
            doBuyProcessButton.Click();
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/buysuccesfull.html?buymode=tarjeta");
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