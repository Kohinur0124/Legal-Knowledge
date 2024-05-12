using MediatR;

namespace LegalKnowledge.Application.UseCases.Department.Commands
{
	public class PutDepartmentCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public int DepartmentNumber { get; set; }

		public string Title { get; set; }

		public int DocumentsId { get; set; }
	}
}
