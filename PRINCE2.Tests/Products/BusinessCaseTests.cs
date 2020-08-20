using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class BusinessCaseTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void BusinessCase_CanBeCreated()
        {
            //Given
            BusinessCase businessCase;

            //When
            businessCase = new BusinessCase();

            //Then
            Assert.NotNull(businessCase);
        }
    }
}
