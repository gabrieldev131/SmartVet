using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Create;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Delete;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetById;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Update;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace SmartVet.Application.Mappers.Entities
{
    public class AdminMapper : Profile
    {
        public AdminMapper()
        {
            #region Entidade para DTO's
            CreateMap<Admin, AdminResponseDTO>().ReverseMap();
            CreateMap<Admin, AdminRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Admin, CreateAdminCommand>().ReverseMap();
            CreateMap<Admin, UpdateAdminCommand>().ReverseMap();
            CreateMap<Admin, GetByIdAdminCommand>().ReverseMap();
            CreateMap<Admin, DeleteAdminCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<AdminRequestDTO, CreateAdminCommand>().ReverseMap() ;
            CreateMap<AdminRequestDTO, UpdateAdminCommand>().ReverseMap() ;
            CreateMap<AdminRequestDTO, DeleteAdminCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, AdminRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateAdminCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateAdminCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteAdminCommand>().ReverseMap();
            #endregion
        }
    }
}