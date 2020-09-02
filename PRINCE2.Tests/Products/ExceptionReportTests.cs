using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ExceptionReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void ExceptionReport_CanBeCreated()
        {
            //Given
            ExceptionReport exceptionReport;

            //When
            exceptionReport = new ExceptionReport();

            //Then
            Assert.NotNull(exceptionReport);
        }
    }
}
