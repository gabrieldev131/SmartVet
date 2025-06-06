using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Create;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Delete;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetById;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Update;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace SmartVet.Application.Mappers.Entities
{
    public class AnimalMapper : Profile
    {
        public AnimalMapper()
        {
            #region Entidade para DTO's
            CreateMap<Animal, AnimalResponseDTO>().ReverseMap();
            CreateMap<Animal, AnimalRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Animal, CreateAnimalCommand>().ReverseMap();
            CreateMap<Animal, UpdateAnimalCommand>().ReverseMap();
            CreateMap<Animal, GetByIdAnimalCommand>().ReverseMap();
            CreateMap<Animal, DeleteAnimalCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<AnimalRequestDTO, CreateAnimalCommand>().ReverseMap()
                                                                            .ForMember(dest => dest.AnimalClientId, opt => opt.MapFrom(src => src.ClientId));
            CreateMap<AnimalRequestDTO, UpdateAnimalCommand>().ReverseMap()
                                                                            .ForMember(dest => dest.AnimalClientId, opt => opt.MapFrom(src => src.ClientId));
            CreateMap<AnimalRequestDTO, DeleteAnimalCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, AnimalRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateAnimalCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateAnimalCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteAnimalCommand>().ReverseMap();
            #endregion
        }
    }
}