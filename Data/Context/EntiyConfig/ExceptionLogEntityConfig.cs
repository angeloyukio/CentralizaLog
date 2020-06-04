using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Context.EntiyConfig {
    public class ExceptionLogEntityConfig : IEntityTypeConfiguration<ExceptionLog> {
        public void Configure(EntityTypeBuilder<ExceptionLog> builder) {
            throw new NotImplementedException();
        }
    }
}
