using System.Collections.Generic;


namespace MSF.LogisticsPlatform.DummyStuff
{
    public interface IFilterService
    {
        List<FilterGroup> GetFilter(string category);
    }
}
