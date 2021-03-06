using System;
using PRINCE2.Products;
using PRINCE2.UNSORTED;
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
            fakePrince2Project.AppointExecutivesAndProjectManager(new ProjectMandate());

            // Assert
            DailyLog dailyLog = fakePrince2Project.DailyLog();
            Assert.NotNull(dailyLog);
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
            fakePrince2Project.AppointExecutivesAndProjectManager(mockProjectMandate);

            // Assert
            ProjectBrief projectBrief = fakePrince2Project.ProjectBrief();
            Assert.NotNull(projectBrief.roleDescriptions.ExecutiveRoleDescription);
            Assert.NotNull(projectBrief.roleDescriptions.ProjectManagerRoleDescription);
        }

        [Fact]
        public void CapturePreviousLessons_WithPreviousLessonsReport_CreatesLessonsLog()
        {
            // Arrange
            var fakePrince2Project = new Prince2Project();

            // Act
            fakePrince2Project.CapturePreviousLessons(new LessonsReport());

            // Assert
            LessonsLog lessonLog = fakePrince2Project.LessonsLog();
            Assert.NotNull(lessonLog);
        }
        
        // [Fact]
        // public void DesignAndAppointProjectTeam_WithExecutiveProjectManagerRoleDescriptionsAndLessonsLog_ReturnsAppointedProjectManagementTeam()
        // {
        //     // Arrange
        //     var fakePrince2Project = new Prince2Project();
        //     var mockProjectBrief = new ProjectBrief()
        //     {
        //         ExecutiveRoleDescription = new Random().Next().ToString(),
        //         ProjectManagerRoleDescription = new Random().Next().ToString()
        //     };

        //     // Act
        //     AppointedProjectManagementTeam appointedProjectManagementTeam = fakePrince2Project.DesignAndAppointProjectTeam(mockProjectBrief, new LessonsLog());

        //     // Assert
        // }
    }
}
