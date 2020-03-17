using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rj.CoreLogic
{
    public class FileFetcher : IFetcher<FileInfo>
    {
        private readonly IEnumerable<string> searchDirectories;
        private readonly string searchPattern;

        public FileFetcher(IEnumerable<string> directoriesToSearch, string pattern)
        {
            searchDirectories = directoriesToSearch;
            searchPattern = pattern;
        }

        public IEnumerable<FileInfo> Fetch()
        {
            var files = new List<FileInfo>();
            foreach (var d in searchDirectories)
            {
                var fileInfos = Directory.GetFiles(d, searchPattern).Select(s => new FileInfo(s));
                files.AddRange(fileInfos);
            }

            return files;
        }
    }
}
