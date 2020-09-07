using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class LessonsReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void LessonsReport_CanBeCreated()
        {
            //Given
            LessonsReport lessonsReport;

            //When
            lessonsReport = new LessonsReport();

            //Then
            Assert.NotNull(lessonsReport);
        }
    }
}
