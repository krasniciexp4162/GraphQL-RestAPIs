﻿using AutoMapper;
using Data.Mongo.Collections;
using Identity.Models;
using Models.DTOs.Account;
using Models.DTOs.Log;

namespace WebApi.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ApplicationUser, UserDto>()
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email));

            CreateMap<LoginLog, LogDto>()
               .ForMember(d => d.UserEmail, o => o.MapFrom(s => s.UserEmail))
               .ForMember(d => d.LoginTime, o => o.MapFrom(s => s.LoginTime));
        }
    }
}
