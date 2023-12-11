using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class RefundProcess : BaseTest
    {
        public RefundProcess(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void CanRefundProcessStart()
        {
            DoBuyProcess();
            var doRefundButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/form[2]/button"));
            doRefundButton.Click();
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/refundprocess.html?");
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void CheckThatRefundIsCompleted()
        {
            DoBuyProcess();
            var doRefundButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/form[2]/button"));
            doRefundButton.Click();
            var confirmRefundButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/button"));
            confirmRefundButton.Click();
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/refundsuccesfull.html?");
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        void DoBuyProcess()
        {
            var product = Driver.FindElement(By.XPath("//*[@id=\"listproduct\"]/div[1]/a/img"));
            product.Click();

            var addProductShoppingCartButton = Driver.FindElement(By.XPath("//*[@id=\"productdetail\"]/div/div[2]/form[2]/button"));
            addProductShoppingCartButton.Click();

            var goToBuyProcessButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div/button"));
            goToBuyProcessButton.Click();

            var changeBuyMethodButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/p[2]/input"));
            changeBuyMethodButton.Click();
            
            var doBuyProcessButton = Driver.FindElement(By.XPath("/html/body/section/div/div[3]/div[2]/form/button"));
            doBuyProcessButton.Click();

            var confirmBuyButton = Driver.FindElement(By.XPath("/html/body/section/div/div[2]/div/form/button"));
            confirmBuyButton.Click();
        }
    }
}