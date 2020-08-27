using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class ConfigurationItemRecordTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void ConfigurationItemRecord_CanBeCreated()
        {
            //Given
            ConfigurationItemRecord configurationItemRecord;

            //When
            configurationItemRecord = new ConfigurationItemRecord();

            //Then
            Assert.NotNull(configurationItemRecord);
        }
    }
}
