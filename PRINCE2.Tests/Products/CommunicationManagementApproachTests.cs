using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class CommunicationManagementApproachTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void CommunicationManagementApproach_CanBeCreated()
        {
            //Given
            CommunicationManagementApproach communicationManagementApproach;

            //When
            communicationManagementApproach = new CommunicationManagementApproach();

            //Then
            Assert.NotNull(communicationManagementApproach);
        }
    }
}
