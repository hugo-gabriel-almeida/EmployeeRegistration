using System;
using AutoMapper;
using EmployeeRegistration.Dtos;
using EmployeeRegistration.Models;

namespace EmployeeRegistration.Profiles
{
    public class EmployeeProfiles: Profile
    {
        public EmployeeProfiles()
        {

            CreateMap<EmployeeCreateDto, Employee>().ForMember(destination => destination.BirthDay,
              map => map.MapFrom(
                  source => DateTime.ParseExact(source.BirthDay, "dd/MM/yyyy", null)));

            CreateMap<Employee, EmployeeReadDto>().ForMember(destination => destination.BirthDay,
              map => map.MapFrom(
                  source => source.BirthDay.ToString("dd/MM/yyyy")));
            CreateMap<EmployeeReadDto, Employee>();
        }
    }
}