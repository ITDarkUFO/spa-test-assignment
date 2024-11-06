using AutoMapper;
using WebServer.DTOs;
using WebServer.Models;

namespace WebServer.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
