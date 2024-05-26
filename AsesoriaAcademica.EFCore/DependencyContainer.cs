using AsesoriaAcademica.EFCore.Repository;
using AsesoriaAcademica.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaAcademica.EFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection DependencyEF(this IServiceCollection services)
        {
            services.AddScoped<IEstudianteRepository, EstudianteRepository>();
            services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddScoped<IAsesorRepository, AsesorRepository>();
            services.AddScoped<ICitaRepository, CitaRepository>();
            services.AddDbContext<GestionAsesoriaAcademicaContext>(optionsBuilder =>
            { 
             optionsBuilder.
             UseSqlServer("server=DESKTOP-BTD8DEL;database=GestionAsesoriaAcademica;Integrated Security=True;Encrypt=False");
            });
            return services;
        }
    }
}
