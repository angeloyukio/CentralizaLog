using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Context.EntiyConfig {
    public class OperationLogEntityConfig : IEntityTypeConfiguration<OperationLog> {
        public void Configure(EntityTypeBuilder<OperationLog> builder) {
            throw new System.NotImplementedException();
        }
    }
}
