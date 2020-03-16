using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rj.CoreLogic
{
    public class DirectoryFetcher : IFetcher
    {
        private readonly string directoryPattern;
        private readonly string path;

        public DirectoryFetcher(string pattern, string rootPath)
        {
            directoryPattern = pattern;
            path = rootPath;
        }

        public IEnumerable<string> Fetch()
        {
            return Directory.GetDirectories(path, directoryPattern);
        }
    }
}
