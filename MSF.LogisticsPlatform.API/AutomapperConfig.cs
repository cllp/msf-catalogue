using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSF.LogisticsPlatform.API
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(ConfigAction);
        }

        public static Action<IMapperConfigurationExpression> ConfigAction = cfg =>
        {
            cfg.AddProfile<ProductProfile>();
            cfg.AddProfile<ProductDetailsProfile>();
        };


        public class ProductProfile : Profile
        {
            public ProductProfile()
            {
                CreateMap<BusinessLayer.Models.Product, Domain.Entities.Product>().ReverseMap();
            }
        }

        public class ProductDetailsProfile : Profile
        {
            public ProductDetailsProfile()
            {
                CreateMap<BusinessLayer.Models.ProductDetail, Domain.Entities.ProductDetail>().ReverseMap();
            }
        }
    }
}
