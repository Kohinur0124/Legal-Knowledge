using LegalKnowledge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.Abstraction
{
	public interface IApplicationDbContext
	{
		public DbSet<Chapters> DBChapters { get; set; }
		public DbSet<Departments> DBDepartments { get; set; }
		public DbSet<Documents> DBDocuments { get; set; }
		public DbSet<Substances> DBSubstances { get; set; }
		public DbSet<TestQuestions> DBTestQuestions { get; set; }
		public DbSet<User> DBUsers { get; set; }

		public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
