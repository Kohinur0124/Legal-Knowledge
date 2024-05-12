using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Department.Queries;
using LegalKnowledge.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.Department.Handlers
{
	public class GetDepartmentCommandHandler :
		  IRequestHandler<GetDepartmentCommand, List<Departments>>
	{
		private readonly IApplicationDbContext _context;

		public GetDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Departments>> Handle(GetDepartmentCommand request, CancellationToken cancellationToken)
		{
			return await _context.DBDepartments.ToListAsync();
		}
	}
}
