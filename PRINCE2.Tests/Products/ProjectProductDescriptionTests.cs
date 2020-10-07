using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ProjectProductDescriptionTests
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
            ProjectProductDescription projectProductDescription;

            //When
            projectProductDescription = new ProjectProductDescription();

            //Then
            Assert.NotNull(projectProductDescription);
        }
    }
}
