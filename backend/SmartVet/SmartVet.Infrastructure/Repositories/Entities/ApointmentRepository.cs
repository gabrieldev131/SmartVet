﻿using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Infrastructure.Interfaces.Entities;
using SmartVet.Infrastructure.Context;
using SmartVet.Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartVet.Infrastructure.Repositories.Entities
{
    public class ApointmentRepository : BaseRepository<Apointment>, IApointmentRepository
    {
        public ApointmentRepository(AppDbContext context) : base(context) { }

    }
}
