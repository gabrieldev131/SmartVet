using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Create;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Delete;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetById;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Update;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace SmartVet.Application.Mappers.Entities
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {
            #region Entidade para DTO's
            CreateMap<Client, ClientResponseDTO>().ReverseMap();
            CreateMap<Client, ClientRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Client, CreateClientCommand>().ReverseMap();
            CreateMap<Client, UpdateClientCommand>().ReverseMap();
            CreateMap<Client, GetByIdClientCommand>().ReverseMap();
            CreateMap<Client, DeleteClientCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<ClientRequestDTO, CreateClientCommand>().ReverseMap() ;
            CreateMap<ClientRequestDTO, UpdateClientCommand>().ReverseMap() ;
            CreateMap<ClientRequestDTO, DeleteClientCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, ClientRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateClientCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateClientCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteClientCommand>().ReverseMap();
            #endregion
        }
    }
}