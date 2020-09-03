using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class HighlightReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void HighlightReport_CanBeCreated()
        {
            //Given
            HighlightReport highlightReport;

            //When
            highlightReport = new HighlightReport();

            //Then
            Assert.NotNull(highlightReport);
        }
    }
}
