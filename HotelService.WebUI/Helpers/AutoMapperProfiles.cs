using AutoMapper;
using HotelSerivce.Data.Concrete.EfCore;
using HotelService.Entity;
using HotelService.WebUI.ViewModels.City;
using HotelService.WebUI.ViewModels.Country;
using HotelService.WebUI.ViewModels.Customer;
using HotelService.WebUI.ViewModels.CustomerReservation;
using HotelService.WebUI.ViewModels.District;
using HotelService.WebUI.ViewModels.Document;
using HotelService.WebUI.ViewModels.Hotel;
using HotelService.WebUI.ViewModels.Reservation;
using HotelService.WebUI.ViewModels.Room;
using HotelService.WebUI.ViewModels.RoomType;
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
                .ForMember(dest => dest.CountryName, opt => { opt.MapFrom(src => src.Country.Name); });
            CreateMap<City, CityCreateVM>().ReverseMap();
            CreateMap<City, CityUpdateVM>().ReverseMap();
            CreateMap<City, CityDeleteVM>().ReverseMap();



            // Country
            CreateMap<Country, CountryIndexVM>();
            CreateMap<Country, CountryCreateVM>().ReverseMap();
            CreateMap<Country, CountryUpdateVM>().ReverseMap();
            CreateMap<Country, CountryDeleteVM>().ReverseMap();


            // District
            CreateMap<District, DistrictIndexVM>()
                .ForMember(dest => dest.City, opt => { opt.MapFrom(src => src.City.Name); });
            CreateMap<District, DistrictCreateVM>().ReverseMap();
            CreateMap<District, DistrictUpdateVM>().ReverseMap();
            CreateMap<District, DistrictDeleteVM>().ReverseMap();




            // Hotel

            CreateMap<Hotel, HotelIndexVM>()
                .ForMember(dest => dest.District, opt => { opt.MapFrom(src => src.District.Name); });
            CreateMap<Hotel, HotelCreateVM>().ReverseMap();
            CreateMap<Hotel, HotelUpdateVM>().ReverseMap();
            CreateMap<Hotel, HotelDeleteVM>().ReverseMap();




            // Customer
            CreateMap<Customer, CustomerIndexVM>()
               .ForMember(dest => dest.Genderr, opt => { opt.MapFrom(src => src.Gender); });
            CreateMap<Customer, CustomerCreateVM>().ReverseMap()
                .ForMember(dest => dest.Gender, opt => { opt.MapFrom(src => src.Genderr); });
            CreateMap<Customer, CustomerUpdateVM>().ReverseMap()
                .ForMember(dest => dest.Gender, opt => { opt.MapFrom(src => src.Genderr); });
            CreateMap<Customer, CustomerDeleteVM>().ReverseMap();





            // Document
            CreateMap<Document, DocumentIndexVM>()
                .ForMember(dest => dest.CustomerInfo, opt => { opt.MapFrom(src => src.Customer.FullName); });
            CreateMap<Document, DocumentCreateVM>().ReverseMap()
                .ForMember(dest => dest.Id, opt => { opt.MapFrom(src => src.CustomerId); });
            CreateMap<Document, DocumentUpdateVM>().ReverseMap()
                .ForMember(dest => dest.Id, opt => { opt.MapFrom(src => src.CustomerId); });
            CreateMap<Document, DocumentDeleteVM>().ReverseMap();




            // Reservation 
            CreateMap<Reservation, ReservationIndexVM>()
                .ForMember(dest => dest.RoomInfo, opt => { opt.MapFrom(src => src.Room.RoomType.RoomName); });
            CreateMap<Reservation, ReservationCreateVM>().ReverseMap();
            CreateMap<Reservation, ReservationUpdateVM>().ReverseMap();
            CreateMap<Reservation, ReservationDeleteVM>().ReverseMap();




            // CustomerReservation
            CreateMap<CustomerReservation, CustomerReservationIndexVM>()
                .ForMember(dest => dest.CustomerInfo, opt => { opt.MapFrom(src => src.Customer.FullName); })
                .ForMember(dest => dest.ReservationInfo, opt => { opt.MapFrom(src => src.Reservation.Room.RoomType.RoomName + " " + src.Reservation.PersonCount); });
            CreateMap<CustomerReservation, CustomerReservationCreateVM>().ReverseMap();
            CreateMap<CustomerReservation, CustomerReservationUpdateVM>().ReverseMap();
            CreateMap<CustomerReservation, CustomerReservationDeleteVM>().ReverseMap();

            // RoomType
            CreateMap<RoomType, RoomTypeIndexVM>();
            CreateMap<RoomType, RoomTypeCreateVM>().ReverseMap();
            CreateMap<RoomType, RoomTypeUpdateVM>().ReverseMap();
            CreateMap<RoomType, RoomTypeDeleteVM>().ReverseMap();

            // Room
            CreateMap<Room, RoomIndexVM>()
                .ForMember(dest => dest.HotelName, opt => { opt.MapFrom(src => src.Hotel.Name); })
                .ForMember(dest => dest.RoomType, opt => { opt.MapFrom(src => src.RoomType.RoomName); });
            CreateMap<Room, RoomCreateVM>().ReverseMap();
            CreateMap<Room, RoomUpdateVM>().ReverseMap();
            CreateMap<Room, RoomDeleteVM>().ReverseMap();




        }
    }
}
