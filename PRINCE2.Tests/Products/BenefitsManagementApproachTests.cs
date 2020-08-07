using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class BenefitsManagementApproachTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void BenefitsManagementApproach_CanBeCreated()
        {
            //Given
            BenefitsManagementApproach benefitsManagementApproach;

            //When
            benefitsManagementApproach = new BenefitsManagementApproach();

            //Then
            Assert.NotNull(benefitsManagementApproach);
        }
    }
}
