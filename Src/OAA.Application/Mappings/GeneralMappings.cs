using AutoMapper;
using OAA.Application.DTO.Selects;
using OAA.Application.DTO.ViewModels;
using OAA.Domain.Entities;

namespace OAA.Application.Mappings
{
    /// <summary>
    /// Mapping class
    /// </summary>
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            //School mappings
            CreateMap<School, SchoolSelect>().ReverseMap();
            CreateMap<School, SchoolViewModel>().ReverseMap();
        }
    }
}