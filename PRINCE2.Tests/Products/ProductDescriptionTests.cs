using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ProductDescriptionTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void ProductDescription_CanBeCreated()
        {
            //Given
            ProductDescription productDescription;

            //When
            productDescription = new ProductDescription();

            //Then
            Assert.NotNull(productDescription);
        }
    }
}
