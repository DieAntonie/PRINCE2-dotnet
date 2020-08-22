using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ChangeControlApproachTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void ChangeControlApproach_CanBeCreated()
        {
            //Given
            ChangeControlApproach changeControlApproach;

            //When
            changeControlApproach = new ChangeControlApproach();

            //Then
            Assert.NotNull(changeControlApproach);
        }
    }
}
