using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class EndStageReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void EndStageReport_CanBeCreated()
        {
            //Given
            EndStageReport endStageReport;

            //When
            endStageReport = new EndStageReport();

            //Then
            Assert.NotNull(endStageReport);
        }
    }
}
