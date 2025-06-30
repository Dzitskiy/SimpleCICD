using Xunit;

namespace WebApi.Tests
{
    public class Tests
    {
        [Fact]
        void Test1()
        {
            // Arrange
            var expected = 42;
            // Act
            var actual = 42; // Simulate some operation
            // Assert
            if (actual != expected)
            {
                throw new Exception($"Test failed: expected {expected}, got {actual}");
            }
        }
    }
}
