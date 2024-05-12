using MediatR;

namespace LegalKnowledge.Application.UseCases.SubStance.Commands
{
	public class PutSubStancesCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public int Number { get; set; }

		public int Part { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int ChaptersId { get; set; }


	}
}
