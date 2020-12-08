using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class WorkPackageTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void WorkPackage_CanBeCreated()
        {
            //Given
            WorkPackage workPackage;

            //When
            workPackage = new WorkPackage();

            //Then
            Assert.NotNull(workPackage);
        }
    }
}
