using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace WebUnitTests
{
    [Collection("Test collection")]
    public class ProductCatalog : BaseTest
    {
        public ProductCatalog(ITestOutputHelper outputHelper) : base(outputHelper)
        {}

        [Fact]
        public void AreProductsShowedCorrectly()
        {
            IWebElement product = Driver.FindElement(By.XPath("//*[@id=\"listproduct\"]/div[3]/a/img"));
            Assert.True(product.Displayed);
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void IsShowingAllProducts()
        {
            int productsCount = 3;
            int showedProducts = 0;
            
            for (int i = 0; i < productsCount; i++)
            {
                IWebElement product = Driver.FindElement(By.XPath($"//*[@id=\"listproduct\"]/div[{i+1}]/a/img"));
                if (product.Displayed) showedProducts++;
            }

            Assert.Equal(showedProducts, productsCount);
            RecordTestResult(currentTestName, TestResult.Pass);
        }

        [Fact]
        public void AreProductsEasyToInteract()
        {
            IWebElement product = Driver.FindElement(By.XPath($"//*[@id=\"listproduct\"]/div[1]/a/img"));
            product.Click();
            
            Assert.True(Driver.Url == "file:///T:/@ITLA/6to%20Cuatrimestre/Programacion%20III/Prog3-ProyectoFinal/web/views/product.html?id=0");
            RecordTestResult(currentTestName, TestResult.Pass);
        }
    }
}