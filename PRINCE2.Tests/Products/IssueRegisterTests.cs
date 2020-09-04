using System;
using Xunit;

namespace PRINCE2.Products.Tests
{
    public class IssueRegisterTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void IssueRegister_CanBeCreated()
        {
            //Given
            IssueRegister issueRegister;

            //When
            issueRegister = new IssueRegister();

            //Then
            Assert.NotNull(issueRegister);
        }
    }
}
