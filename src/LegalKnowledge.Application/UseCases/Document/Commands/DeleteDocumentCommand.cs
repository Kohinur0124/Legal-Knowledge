using MediatR;

namespace LegalKnowledge.Application.UseCases.Document.Commands
{
	public class DeleteDocumentCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
