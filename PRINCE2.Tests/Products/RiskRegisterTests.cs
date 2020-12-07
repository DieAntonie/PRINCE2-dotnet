using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class RiskRegisterTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void RiskRegister_CanBeCreated()
        {
            //Given
            RiskRegister riskRegister;

            //When
            riskRegister = new RiskRegister();

            //Then
            Assert.NotNull(riskRegister);
        }
    }
}
