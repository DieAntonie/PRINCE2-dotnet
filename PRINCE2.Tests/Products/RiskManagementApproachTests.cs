using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class RiskManagementApproachTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void RiskManagementApproach_CanBeCreated()
        {
            //Given
            RiskManagementApproach riskManagementApproach;

            //When
            riskManagementApproach = new RiskManagementApproach();

            //Then
            Assert.NotNull(riskManagementApproach);
        }
    }
}
