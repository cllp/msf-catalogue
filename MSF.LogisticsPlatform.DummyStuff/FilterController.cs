using Newtonsoft.Json;


namespace MSF.LogisticsPlatform.DummyStuff
{
    public class FilterController
    {
        IServiceFactory _ServiceFactory;//Reference to Service Factory Interface to access the factory and create filter services.

        public FilterController(IServiceFactory serviceFactory)
        {
            _ServiceFactory = serviceFactory;
        }
        
        public string GetAll(string category)
        {
            //Call filter service to return all hardcoded layouts as list of FilterGroup
            var result = _ServiceFactory.GetFilterService().GetFilter(category);
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);//Serialize json objects to a proper format.
            return formatedResult;
        }
    }
}
