using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.AppUser.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LegalKnowledge.Application.UseCases.AppUser.Handlers
{
	public class PutUserCommandHandler :
		 IRequestHandler<PutUserCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutUserCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutUserCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.DBUsers.
					FirstOrDefaultAsync(x => x.Id == request.Id);

				res.Name = request.Name;
				res.Email = request.Email;
				res.Password = request.Password;
				res.Amount = request.Amount;
				res.Languagaes = request.Languagaes;


				_context.DBUsers.Update(res);

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
