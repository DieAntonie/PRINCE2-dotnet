using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class PlanReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void Plan_CanBeCreated()
        {
            //Given
            Plan plan;

            //When
            plan = new Plan();

            //Then
            Assert.NotNull(plan);
        }
    }
}
