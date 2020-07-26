using System;
using PRINCE2.Products;
using Xunit;

namespace PRINCE2.Tests
{
    public class Prince2ProjectTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void AppointExecutivesAndProjectManager_WithProjectMandate_ReturnsAppointedExecutivesAndProjectManager()
        {
            // Arrange
            var fakePrince2Project = new Prince2Project();
            var mockProjectMandate = new ProjectMandate()
            {
                Executive = new Random().Next().ToString(),
                ProjectManager = new Random().Next().ToString()
            };

            // Act
            AppointedExecutivesAndProjectManager appointedExecutivesAndProjectManager = fakePrince2Project.AppointExecutivesAndProjectManager(mockProjectMandate);

            // Assert
            Assert.Equal(mockProjectMandate.Executive, appointedExecutivesAndProjectManager.Executive);
            Assert.Equal(mockProjectMandate.ProjectManager, appointedExecutivesAndProjectManager.ProjectManager);
        }

        [Fact]
        public void AppointExecutivesAndProjectManager_WithProjectMandate_CreatesDailyLog()
        {
            // Arrange
            var fakePrince2Project = new Prince2Project();

            // Act
            AppointedExecutivesAndProjectManager appointedExecutivesAndProjectManager = fakePrince2Project.AppointExecutivesAndProjectManager(new ProjectMandate());

            // Assert
            Assert.NotNull(fakePrince2Project.DailyLog());
        }

        [Fact]
        public void AppointExecutivesAndProjectManager_WithProjectMandate_CreatesProjectBrief()
        {
            // Arrange
            var fakePrince2Project = new Prince2Project();
            var mockProjectMandate = new ProjectMandate()
            {
                Executive = new Random().Next().ToString(),
                ProjectManager = new Random().Next().ToString()
            };

            // Act
            AppointedExecutivesAndProjectManager appointedExecutivesAndProjectManager = fakePrince2Project.AppointExecutivesAndProjectManager(mockProjectMandate);

            // Assert
            ProjectBrief projectBrief = fakePrince2Project.ProjectBrief();
            Assert.NotNull(projectBrief.ExecutiveRoleDescription);
            Assert.NotNull(projectBrief.ProjectManagerRoleDescription);
        }
    }
}
