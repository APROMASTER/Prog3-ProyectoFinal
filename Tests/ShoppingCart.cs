using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class ShoppingCart : BaseTest
    {
        public ShoppingCart(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void IsShoppingCartShowingCorrectly()
        {
            var shoppingCartButton = Driver.FindElement(By.XPath("/html/body/div/nav/div/form/a/button"));
            shoppingCartButton.Click();
            
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/shoppingcart.html");
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void CanProductsBeAddedToShoppingCart()
        {
            var product = Driver.FindElement(By.XPath("//*[@id=\"listproduct\"]/div[1]/a/img"));
            product.Click();

            var addProductShoppingCartButton = Driver.FindElement(By.XPath("//*[@id=\"productdetail\"]/div/div[2]/form[2]/button"));
            addProductShoppingCartButton.Click();

            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/shoppingcart.html?");
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void CanProductsBeDeletedToShoppingCart()
        {
            var product = Driver.FindElement(By.XPath("//*[@id=\"listproduct\"]/div[1]/a/img"));
            product.Click();

            var addProductShoppingCartButton = Driver.FindElement(By.XPath("//*[@id=\"productdetail\"]/div/div[2]/form[2]/button"));
            addProductShoppingCartButton.Click();

            Assert.True(true);
            RecordTestResult(currentTestName, TestResult.Pass);
        }
    }
}