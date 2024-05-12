using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace LegalKnowledge.Infrastructure.Persistance
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
			if (databaseCreator != null)
			{
				if (!databaseCreator.CanConnect()) databaseCreator.Create();
				if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Chapters> DBChapters { get; set; }
		public DbSet<Departments> DBDepartments { get; set; }
		public DbSet<Documents> DBDocuments { get; set; }
		public DbSet<Substances> DBSubstances { get; set; }
		public DbSet<TestQuestions> DBTestQuestions { get; set; }
		public DbSet<User> DBUsers { get; set; }
	}



}

