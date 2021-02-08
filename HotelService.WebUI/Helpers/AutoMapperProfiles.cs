using AutoMapper;
using HotelSerivce.Data.Concrete.EfCore;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.City;
using HotelService.WebUI.ViewModels.Country;
using HotelService.WebUI.ViewModels.Customer;
using HotelService.WebUI.ViewModels.District;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {


            // City
            CreateMap<City, CityIndexVM>()
                .ForMember(dest => dest.CountryName, opt => { opt.MapFrom(src => src.CountryId); });
            CreateMap<City, CityCreateVM>().ReverseMap();

            CreateMap<City, CityUpdateVM>().ReverseMap();
            CreateMap<City, CityDeleteVM>().ReverseMap();



            // Country
            CreateMap<Country, CountryIndexVM>();
            CreateMap<Country, CountryCreateVM>().ReverseMap();
            CreateMap<Country, CountryUpdateVM>().ReverseMap();
            CreateMap<Country, CountryDeleteVM>().ReverseMap();



            // Customer
            CreateMap<Customer, CustomerIndexVM>();
            //   .ForMember(dest => dest.FullName , opt => { opt.MapFrom(src => src.FirstName + src.LastName); });





            // District
            CreateMap<District, DistrictIndexVM>();
            CreateMap<District, DistrictCreateVM>().ReverseMap();
            CreateMap<District, DistrictUpdateVM>().ReverseMap();
            CreateMap<District, DistrictDeleteVM>().ReverseMap();

        }
    }
}
