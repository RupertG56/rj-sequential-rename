using Xunit;

namespace Rj.Directories.UnitTests
{
    public class DirectoryFetcherTest
    {
        [Theory]
        [InlineData("C:\\Temp\\TestFolder\\testns1d1")]
        [InlineData("C:\\Temp\\TestFolder\\testns1d2")]
        [InlineData("C:\\Temp\\TestFolder\\testns1d3")]
        [InlineData("C:\\Temp\\TestFolder\\testns1d4")]
        public void FetchReturnsDirectoriesMatchingPattern(string expected)
        {
            // Arrange
            var fetcher = new DirectoryFetcher("testns1*", "C:\\Temp\\TestFolder");

            // Act
            var directories = fetcher.Fetch();

            // Assert
            Assert.Contains(expected, directories);
        }
    }
}
