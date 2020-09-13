using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ProductStatusAccountTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void ProductStatusAccount_CanBeCreated()
        {
            //Given
            ProductStatusAccount productStatusAccount;

            //When
            productStatusAccount = new ProductStatusAccount();

            //Then
            Assert.NotNull(productStatusAccount);
        }
    }
}
