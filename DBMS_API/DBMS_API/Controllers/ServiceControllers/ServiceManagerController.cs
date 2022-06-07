using DBMS_API.Domain.Models.ServiceDepartment;
using DBMS_API.Stories.ServiceStories.ManagerStories.Contexts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DBMS_API.Controllers.ServiceControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceManagerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceManagerController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] AddServiceManagerStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ServiceManager>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetList(CancellationToken token)
        {
            var story = new ShowAllServiceManagerStoryContext();
            var response = await _mediator.Send(story, token);

            if (response.Count == 0)
            {
                return NotFound("Объекты не найдены");
            }

            return Ok(response);
        }

        [HttpGet("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceManager))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] ShowServiceManagerStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            if (response == null)
            {
                return NotFound("Объект не найден");
            }

            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put([FromBody] UpdateServiceManagerStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            return Ok();
        }

        [HttpDelete("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] DeleteServiceManagerStoryContext storyContext, CancellationToken token)
        {
            var response = await _mediator.Send(storyContext, token);

            if (response == null)
            {
                return NotFound("Объект не найден");
            }

            return NoContent();
        }








    }
}
