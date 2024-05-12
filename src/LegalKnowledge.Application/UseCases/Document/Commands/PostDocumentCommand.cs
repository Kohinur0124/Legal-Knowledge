using MediatR;

namespace LegalKnowledge.Application.UseCases.Document.Commands
{
	public class PostDocumentCommand : IRequest<bool>
	{
		public string Title { get; set; }

		public int YearOdPublication { get; set; }

		public bool IsActive { get; set; }


	}
}
