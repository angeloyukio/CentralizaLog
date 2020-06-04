using Data.Context;
using Data.Repositories;
using Domain.Services;
using Domain.Services.Interfaces;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injection.DependencyInjection {
    public class DependencyInjector {
        public static void Register(IServiceCollection services, IConfiguration configuration) {
            RegisterDbConnections(services, configuration);
            RegisterServices(services);
            RegisterRepositories(services);
        }

        private static void RegisterDbConnections(IServiceCollection services, IConfiguration configuration) {
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<CentralizeLogContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("CentralizeLogConnectionString"))
                );
        }

        public static void RegisterServices(IServiceCollection services) {
            services.AddScoped<IExceptionLogService, ExceptionLogService>();
            services.AddScoped<IOperationLogService, OperationLogService>();
        }

        public static void RegisterRepositories(IServiceCollection services) {
            services.AddScoped<IExceptionLogRepository, ExceptionLogRepository>();
            services.AddScoped<IOperationLogRepository, OperationLogRepository>();
        }
    }
}
