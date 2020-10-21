using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class QualityManagementApproachTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void ProjectBrief_CanBeCreated()
        {
            //Given
            QualityManagementApproach qualityManagementApproach;

            //When
            qualityManagementApproach = new QualityManagementApproach();

            //Then
            Assert.NotNull(qualityManagementApproach);
        }
    }
}
