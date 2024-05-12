using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.AppUser.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.AppUser.Handlers
{
	public class DeleteUserCommandHandler :
		IRequestHandler<DeleteUserCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteUserCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.DBUsers.FirstOrDefaultAsync(x => x.Id == request.Id);

				if (res == null)
				{
					return false;
				}

				_context.DBUsers.Remove(res);
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
