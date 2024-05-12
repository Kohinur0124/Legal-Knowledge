using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LegalKnowledge.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			var con = "Server=SEVINCH;Database=KnowledgeLegalDB;Trusted_Connection=True;TrustServerCertificate=True;";

			services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
			options.UseSqlServer(con));
			return services;
		}
	}
}
