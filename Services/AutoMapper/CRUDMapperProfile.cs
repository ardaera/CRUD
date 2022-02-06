using ArdalanAraghi_CRUD.Models;
using ArdalanAraghi_CRUD.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Services.AutoMapper
{
    public class CRUDMapperProfile : Profile
    {
        public CRUDMapperProfile()
        {
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}
