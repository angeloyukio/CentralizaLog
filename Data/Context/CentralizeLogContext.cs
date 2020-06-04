using Data.Context.EntiyConfig;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context {
    public class CentralizeLogContext : DbContext {
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public DbSet<OperationLog> OperationLogs { get; set; }

        public CentralizeLogContext(DbContextOptions<CentralizeLogContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration<ExceptionLog>(new ExceptionLogEntityConfig());
            modelBuilder.ApplyConfiguration<OperationLog>(new OperationLogEntityConfig());
        }
    }
}
