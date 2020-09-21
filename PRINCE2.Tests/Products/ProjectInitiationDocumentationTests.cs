using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ProjectInitiationDocumentationTests
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
            ProjectInitiationDocumentation projectInitiationDocumentation;

            //When
            projectInitiationDocumentation = new ProjectInitiationDocumentation();

            //Then
            Assert.NotNull(projectInitiationDocumentation);
        }
    }
}
