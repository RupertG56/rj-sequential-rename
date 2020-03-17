namespace Rj.CoreLogic
{
    using System.Collections.Generic;

    public interface IFetcher<TOut>
    {
        IEnumerable<TOut> Fetch();
    }
}