using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rj.Directories
{
    public class DirectoryFetcher
    {
        private readonly string directoryPattern;
        private readonly string path;

        public DirectoryFetcher(string pattern, string rootPath)
        {
            directoryPattern = pattern;
            path = rootPath;
        }

        public List<string> Fetch()
        {
            return Directory.GetDirectories(path, directoryPattern).ToList();
        }
    }
}
