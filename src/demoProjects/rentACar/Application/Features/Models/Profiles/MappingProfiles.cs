using Application.Features.Models.Dtos;
using Application.Features.Models.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model, ModelListDto>()
                .ForMember(modelListDto => modelListDto.BrandId, options => options.MapFrom(model => model.Brand.Id))
                .ForMember(modelListDto => modelListDto.BrandName, options => options.MapFrom(model => model.Brand.Name))
                .ForMember(modelListDto => modelListDto.BrandIsApproved, options => options.MapFrom(model => model.Brand.IsApproved))
                .ReverseMap();

            CreateMap<IPaginate<Model>, ModelListModel>().ReverseMap();
        }
    }
}
