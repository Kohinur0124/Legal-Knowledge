using LegalKnowledge.Application.UseCases.Chapter.Commands;
using LegalKnowledge.Application.UseCases.Chapter.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LegalKnowledge.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChaptersController : ControllerBase
{
	private readonly IMediator _mediator;

	public ChaptersController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllChapters()
	{
		var cards = await _mediator.Send(new GetChaptersCommand());
		return Ok(cards);
	}



	[HttpPost]

	public async ValueTask<bool> AddChapter(PostChaptersCommand postCard)
	{
		var t = await _mediator.Send(postCard);
		return t;
	}
	[HttpPut]

	public async ValueTask<IActionResult> UpdateChapter(PutChaptersCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}

	[HttpDelete]

	public async ValueTask<IActionResult> DeleteChapter(DeleteChaptersCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}


}
