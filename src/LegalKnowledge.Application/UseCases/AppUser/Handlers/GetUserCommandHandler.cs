using LegalKnowledge.Application.Abstraction;
using LegalKnowledge.Application.UseCases.AppUser.Queries;
using LegalKnowledge.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace LegalKnowledge.Application.UseCases.AppUser.Handlers
{
	public class GetUserCommandHandler :
		  IRequestHandler<GetUserCommand, List<User>>
	{
		private readonly IApplicationDbContext _context;

		public GetUserCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<User>> Handle(GetUserCommand request, CancellationToken cancellationToken)
		{
			return await _context.DBUsers.ToListAsync();
		}
	}
}
