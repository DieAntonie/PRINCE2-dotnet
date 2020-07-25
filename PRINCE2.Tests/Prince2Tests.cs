using System;
using Xunit;

namespace PRINCE2.Tests
{
    public class Prince2Tests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void NewProject_ReturnsEmptyPrince2Project()
        {
            // Arrange
            var fakePRINCE2 = new Prince2();

            // Act
            Prince2Project mockProject = fakePRINCE2.NewProject();

            // Assert
            Assert.NotNull(mockProject);
        }
    }
}
