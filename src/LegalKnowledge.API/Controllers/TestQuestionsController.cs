using LegalKnowledge.Application.UseCases.TestQuestion.Commands;
using LegalKnowledge.Application.UseCases.TestQuestion.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LegalKnowledge.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestQuestionsController : ControllerBase
{
	private readonly IMediator _mediator;

	public TestQuestionsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllTestQuestions()
	{
		var cards = await _mediator.Send(new GetTestQuestionsCommand());
		return Ok(cards);
	}



	[HttpPost]

	public async ValueTask<bool> AddTestQuestions(PostTestQuestionsCommand postCard)
	{
		var t = await _mediator.Send(postCard);
		return t;
	}
	[HttpPut]

	public async ValueTask<IActionResult> UpdateTestQuestions(PutTestQuestionsCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}

	[HttpDelete]

	public async ValueTask<IActionResult> DeleteTestQuestions(DeleteTestQuestionsCommand postUser)
	{
		var t = await _mediator.Send(postUser);
		return Ok(t);
	}


}
