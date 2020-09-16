using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ProjectBriefTests
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
            ProjectBrief projectBrief;

            //When
            projectBrief = new ProjectBrief();

            //Then
            Assert.NotNull(projectBrief);
        }
    }
}
