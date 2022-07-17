using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sample.Application.Services.Implementations;
using Sample.Application.Services.Interfaces;
using Sample.Infra.Data.Contexts;
using Sample.Infra.Data.Entities;
using Sample.Infra.Data.Repositories.Implementations;
using Sample.Infra.Data.Repositories.Interfaces;
using Sample.Infra.Data.UnitOfWork.Implementations;
using Sample.Infra.Data.UnitOfWork.Interfaces;

namespace Sample.Infra.IoC
{
    public static class DependencyInjectionRegisterExtension
    {
        public static void RegisterServices(this IServiceCollection services,
           IConfiguration configuration)
        {

            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<OracleSampleContext, OracleSampleContext>();
            services.AddScoped<IBaseRepository<PessoaEntity>, BaseRepository<PessoaEntity>>();
        }
    }
}
