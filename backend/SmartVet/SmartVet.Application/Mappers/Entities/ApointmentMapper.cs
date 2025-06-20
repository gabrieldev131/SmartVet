using AutoMapper;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Base;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Create;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Delete;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetById;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Update;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;

namespace SmartVet.Application.Mappers.Entities
{
    public class ApointmentMapper : Profile
    {
        public ApointmentMapper()
        {
            #region Entidade para DTO's
            CreateMap<Apointment, ApointmentResponseDTO>().ReverseMap();
            CreateMap<Apointment, ApointmentRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Apointment, CreateApointmentCommand>().ReverseMap();
            CreateMap<Apointment, UpdateApointmentCommand>().ReverseMap();
            CreateMap<Apointment, GetByIdApointmentCommand>().ReverseMap();
            CreateMap<Apointment, DeleteApointmentCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<ApointmentRequestDTO, CreateApointmentCommand>().ReverseMap()
                                                                                    .ForMember(dest => dest.ApointmentAnimalId, opt => opt.MapFrom(src => src.AnimalId));
            //.ForMember(dest => dest.ApointmentVeterinarianId, opt => opt.MapFrom(src => src.VeterinarianId));
            CreateMap<ApointmentRequestDTO, UpdateApointmentCommand>().ReverseMap()
                                                                                    .ForMember(dest => dest.ApointmentAnimalId, opt => opt.MapFrom(src => src.AnimalId));
                                                                                    //.ForMember(dest => dest.ApointmentVeterinarianId, opt => opt.MapFrom(src => src.VeterinarianId));
            CreateMap<ApointmentRequestDTO, DeleteApointmentCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, ApointmentRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreateApointmentCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdateApointmentCommand>().ReverseMap();
            CreateMap<ApiResponse, DeleteApointmentCommand>().ReverseMap();
            #endregion
        }
    }
}