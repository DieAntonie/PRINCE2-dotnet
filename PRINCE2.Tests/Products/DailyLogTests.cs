using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class DailyLogTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void DailyLog_CanBeCreated()
        {
            //Given
            DailyLog dailyLog;

            //When
            dailyLog = new DailyLog();

            //Then
            Assert.NotNull(dailyLog);
        }
    }
}
