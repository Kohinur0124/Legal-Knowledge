using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.Department.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.Department.Handlers
{
	public class DeleteDepartmentCommandHandler :
		IRequestHandler<DeleteDepartmentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.DBDepartments.FirstOrDefaultAsync(x => x.Id == request.Id);

				if (res == null)
				{
					return false;
				}

				_context.DBDepartments.Remove(res);
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
