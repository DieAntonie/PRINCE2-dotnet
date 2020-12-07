using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class QualityRegisterTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void QualityRegister_CanBeCreated()
        {
            //Given
            QualityRegister qualityRegister;

            //When
            qualityRegister = new QualityRegister();

            //Then
            Assert.NotNull(qualityRegister);
        }
    }
}
