using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPITask.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile() { 
        CreateMap<API.Entities.Product, Models.ProductsDto>();
        CreateMap<Models.ProductsCreateDto, API.Entities.Product>();
        CreateMap<Models.ProductUpdateDto, API.Entities.Product>();
        CreateMap<API.Entities.Product, Models.ProductUpdateDto>();
        }
    }
}
