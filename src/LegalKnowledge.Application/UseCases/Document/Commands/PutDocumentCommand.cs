using MediatR;

namespace LegalKnowledge.Application.UseCases.Document.Commands
{
	public class PutDocumentCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public int YearOdPublication { get; set; }

		public bool IsActive { get; set; }


	}
}
