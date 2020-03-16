using Xunit;
using System.IO;

namespace Rj.CoreLogic.UnitTests
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

        private void SetupTestFolderStructure(string basePath, string baseFolderName, int dirCount)
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            for (var x = 1; x <= dirCount; x++)
            {
                string lastPart = $"{baseFolderName}{x}";
                string directoryToCreate = Path.Combine(basePath, lastPart);
                if (Directory.Exists(directoryToCreate)) continue;

                Directory.CreateDirectory(directoryToCreate);
            }
        }

        private void RemoveTestFolderStructure(string basePath, string baseFolderName, int dirCount)
        {
            for (var x = 1; x <= dirCount; x++)
            {
                string lastPart = $"{baseFolderName}{x}";
                string directoryToDelete = Path.Combine(basePath, lastPart);
                if (!Directory.Exists(directoryToDelete)) continue;

                Directory.Delete(directoryToDelete);
            }

            if (Directory.Exists(basePath))
            {
                Directory.Delete(basePath);
            }
        }
    }
}
