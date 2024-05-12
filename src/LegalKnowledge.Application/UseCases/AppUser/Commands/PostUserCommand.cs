using LegalKnowledge.Domain.Enums;
using MediatR;

namespace LegalKnowledge.Application.UseCases.AppUser.Commands
{
	public class PostUserCommand : IRequest<bool>
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public int Amount { get; set; } = 0;

		public LanguagaesEnum Languagaes { get; set; }

	}
}
