using MediatR;

namespace LegalKnowledge.Application.UseCases.Chapter.Commands
{
	public class PostChaptersCommand : IRequest<bool>
	{
		public int Number { get; set; }

		public string Title { get; set; }

		public int DepartmentsId { get; set; }
	}
}
