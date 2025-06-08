using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Create;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Delete;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetById;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Update;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace SmartVet.Application.Mappers.Entities
{
    public class RecepcionistMapper : Profile
    {
        public RecepcionistMapper()
        {
            #region Entidade para DTO's
            CreateMap<Recepcionist, RecepcionistResponseDTO>().ReverseMap();
            CreateMap<Recepcionist, RecepcionistRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Recepcionist, CreateRecepcionistCommand>().ReverseMap();
            CreateMap<Recepcionist, UpdateRecepcionistCommand>().ReverseMap();
            CreateMap<Recepcionist, GetByIdRecepcionistCommand>().ReverseMap();
            CreateMap<Recepcionist, DeleteRecepcionistCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<RecepcionistRequestDTO, CreateRecepcionistCommand>().ReverseMap() ;
            CreateMap<RecepcionistRequestDTO, UpdateRecepcionistCommand>().ReverseMap() ;
            CreateMap<RecepcionistRequestDTO, DeleteRecepcionistCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, RecepcionistRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateRecepcionistCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateRecepcionistCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteRecepcionistCommand>().ReverseMap();
            #endregion
        }
    }
}