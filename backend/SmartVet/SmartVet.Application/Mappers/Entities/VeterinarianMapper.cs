using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Create;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Delete;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetById;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Update;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace SmartVet.Application.Mappers.Entities
{
    public class VeterinarianMapper : Profile
    {
        public VeterinarianMapper()
        {
            #region Entidade para DTO's
            CreateMap<Veterinarian, VeterinarianResponseDTO>().ReverseMap();
            CreateMap<Veterinarian, VeterinarianRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Veterinarian, CreateVeterinarianCommand>().ReverseMap();
            CreateMap<Veterinarian, UpdateVeterinarianCommand>().ReverseMap();
            CreateMap<Veterinarian, GetByIdVeterinarianCommand>().ReverseMap();
            CreateMap<Veterinarian, DeleteVeterinarianCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<VeterinarianRequestDTO, CreateVeterinarianCommand>().ReverseMap() ;
            CreateMap<VeterinarianRequestDTO, UpdateVeterinarianCommand>().ReverseMap() ;
            CreateMap<VeterinarianRequestDTO, DeleteVeterinarianCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, VeterinarianRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateVeterinarianCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateVeterinarianCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteVeterinarianCommand>().ReverseMap();
            #endregion
        }
    }
}