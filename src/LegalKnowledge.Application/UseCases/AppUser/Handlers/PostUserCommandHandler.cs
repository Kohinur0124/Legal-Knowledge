using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.AppUser.Commands;
using LegalKnowledge.Domain.Entities;
using MediatR;

namespace LegalKnowledge.Application.UseCases.AppUser.Handlers
{
	public class PostUserCommandHandler :
		IRequestHandler<PostUserCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostUserCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostUserCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new User
				{
					Name = request.Name,
					Email = request.Email,
					Password = request.Password,
					Amount = request.Amount,
					Languagaes = request.Languagaes,

				};
				await _context.DBUsers.AddAsync(res);
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
