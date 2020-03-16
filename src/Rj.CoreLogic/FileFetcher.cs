﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rj.CoreLogic
{
    public class FileFetcher : IFetcher
    {
        private readonly IEnumerable<string> searchDirectories;
        private readonly string searchPattern;

        public FileFetcher(IEnumerable<string> directoriesToSearch, string pattern)
        {
            searchDirectories = directoriesToSearch;
            searchPattern = pattern;
        }

        public IEnumerable<string> Fetch()
        {
            throw new NotImplementedException();
        }
    }
}