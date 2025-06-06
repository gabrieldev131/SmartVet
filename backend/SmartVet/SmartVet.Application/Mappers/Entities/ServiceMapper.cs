using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Create;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Delete;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetById;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Update;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace SmartVet.Application.Mappers.Entities
{
    public class ServiceMapper : Profile
    {
        public ServiceMapper()
        {
            #region Entidade para DTO's
            CreateMap<Service, ServiceResponseDTO>().ReverseMap();
            CreateMap<Service, ServiceRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();
            CreateMap<Service, GetByIdServiceCommand>().ReverseMap();
            CreateMap<Service, DeleteServiceCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<ServiceRequestDTO, CreateServiceCommand>().ReverseMap() ;
            CreateMap<ServiceRequestDTO, UpdateServiceCommand>().ReverseMap() ;
            CreateMap<ServiceRequestDTO, DeleteServiceCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, ServiceRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateServiceCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateServiceCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteServiceCommand>().ReverseMap();
            #endregion
        }
    }
}