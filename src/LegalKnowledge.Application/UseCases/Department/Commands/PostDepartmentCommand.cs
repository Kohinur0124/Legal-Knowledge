using MediatR;

namespace LegalKnowledge.Application.UseCases.Department.Commands
{
	public class PostDepartmentCommand : IRequest<bool>
	{
		public int DepartmentNumber { get; set; }

		public string Title { get; set; }

		public int DocumentsId { get; set; }
	}
}
