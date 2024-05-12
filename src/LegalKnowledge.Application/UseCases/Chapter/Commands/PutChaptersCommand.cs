using MediatR;

namespace LegalKnowledge.Application.UseCases.Chapter.Commands
{
	public class PutChaptersCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public int Number { get; set; }

		public string Title { get; set; }

		public int DepartmentsId { get; set; }
	}
}
