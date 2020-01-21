using System.Collections.Generic;
using ManoeuvreNotification.Others;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ManoeuvreNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _mediator.Publish(new Ping
            {
                Name = "Bla"
            });

            return new string[] { "value1", "value2" };
        }
    }
}
