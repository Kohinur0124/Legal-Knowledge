using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Department.Commands;
using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.Department.Handlers
{
	public class PostDepartmentCommandHandler :
		IRequestHandler<PostDepartmentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostDepartmentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Departments
				{
					DepartmentNumber = request.DepartmentNumber,
					Title = request.Title,
					DocumentsId = request.DocumentsId,

				};
				await _context.DBDepartments.AddAsync(res);
				await _context.SaveChangesAsync(cancellationToken);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
