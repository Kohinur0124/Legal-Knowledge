using LegalKnowledge.Application.UseCases.Document.Commands;
using LegalKnowledge.Application.UseCases.Document.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LegalKnowledge.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentsController : ControllerBase
{
	private readonly IMediator _mediator;

	public DocumentsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllDocuments()
	{
		var cards = await _mediator.Send(new GetDocumentCommand());
		return Ok(cards);
	}



	[HttpPost]

	public async ValueTask<bool> AddDocument(PostDocumentCommand postCard)
	{
		var t = await _mediator.Send(postCard);
		return t;
	}
	[HttpPut]

	public async ValueTask<IActionResult> UpdateDocument(PutDocumentCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}

	[HttpDelete]

	public async ValueTask<IActionResult> DeleteDocument(DeleteDocumentCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}


}
