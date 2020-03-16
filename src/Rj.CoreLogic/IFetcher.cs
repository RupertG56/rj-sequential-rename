namespace Rj.CoreLogic
{
    using System.Collections.Generic;

    public interface IFetcher
    {
        IEnumerable<string> Fetch();
    }
}