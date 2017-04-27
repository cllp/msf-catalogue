using System.Collections.Generic;
using Xunit;
using MSF.LogisticsPlatform.API.Controllers;
using MSF.LogisticsPlatform.BusinessLayer;
using MSF.LogisticsPlatform.BusinessLayer.Services;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using FakeItEasy;

namespace MSF.LogisticsPlatform.UnitTesting.MSF.LogisticsPlatform.API.Controllers
{

    public class FilterControllerTests
    {
        [Fact]
        public void GetAll_()
        {
            var filterGroups = new List<FilterGroup>();
            filterGroups.Add(new FilterGroup()
            {
                FilterGroupDescription = "Description 1",
                FilterItemsGroup = new List<FilterGroup.FilterItem>(new[]
                {
                    new FilterGroup.FilterItem() { Filter = "Filter 1", FilterCriteria = "Filter Criteria 1", IsChecked = false },
                    new FilterGroup.FilterItem() { Filter = "Filter 2", FilterCriteria = "Filter Criteria 2", IsChecked = true }
                })
            });

            var filterServiceFake = A.Fake<IFilterService>();
            A.CallTo(() => filterServiceFake.GetFilter("random category")).Returns<List<FilterGroup>>(filterGroups);

            var serviceFactoryFake = A.Fake<IServiceFactory>();
            A.CallTo(() => serviceFactoryFake.GetFilterService()).Returns<IFilterService>(filterServiceFake);

            var sut = new FilterController(serviceFactoryFake);

            var requestResult = sut.GetAll("random category");

            Assert.Equal("", requestResult.ToString());
        }
    }
}
