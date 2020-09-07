using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class LessonsLogTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void LessonsLog_CanBeCreated()
        {
            //Given
            LessonsLog lessonsLog;

            //When
            lessonsLog = new LessonsLog();

            //Then
            Assert.NotNull(lessonsLog);
        }
    }
}
