using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class CheckpointReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void CheckpointReport_CanBeCreated()
        {
            //Given
            CheckpointReport checkpointReport;

            //When
            checkpointReport = new CheckpointReport();

            //Then
            Assert.NotNull(checkpointReport);
        }
    }
}
