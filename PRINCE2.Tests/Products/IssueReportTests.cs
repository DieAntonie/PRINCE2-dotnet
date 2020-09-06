using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class IssueReportTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void IssueReport_CanBeCreated()
        {
            //Given
            IssueReport issueReport;

            //When
            issueReport = new IssueReport();

            //Then
            Assert.NotNull(issueReport);
        }
    }
}
