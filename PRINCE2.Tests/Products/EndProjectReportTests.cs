using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class EndProjectReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void EndProjectReport_CanBeCreated()
        {
            //Given
            EndProjectReport endProjectReport;

            //When
            endProjectReport = new EndProjectReport();

            //Then
            Assert.NotNull(endProjectReport);
        }
    }
}
