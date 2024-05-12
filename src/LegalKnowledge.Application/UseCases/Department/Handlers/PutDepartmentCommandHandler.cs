using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Department.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.Department.Handlers
{
	public class PutDepartmentCommandHandler :
		 IRequestHandler<PutDepartmentCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutDepartmentCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.DBDepartments.
					FirstOrDefaultAsync(x => x.Id == request.Id);

				res.Title = request.Title;
				res.DepartmentNumber = request.DepartmentNumber;
				res.DocumentsId = request.DocumentsId;

				_context.DBDepartments.Update(res);

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
